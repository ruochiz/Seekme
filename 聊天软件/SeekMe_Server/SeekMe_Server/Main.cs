using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Collections;


//以下为一对一聊天的服务器
namespace SeekMe_Server
{
    public partial class Main : Form
    {
        public static string connstring = "Data Source=Rhodes-PC;Initial Catalog=UsersData;Integrated Security=True";
        public static String IP = "59.66.135.77";
        public static int Port = 8082;
        public static IPAddress IP_Address = IPAddress.Parse(IP);//IP实例

        internal static Hashtable clients = new Hashtable();
        //clients数组保存当前在线用户的client对象         

        private TcpListener listener;//该服务器默认的监听端口号         
        static int MAX_NUM = 100; //服务器可以支持的客户端的最大连接数         
        internal static bool SocketServiceFlag = false;//开始服务的标志  

        Thread ListenerThread;



        public Main()
        {
            InitializeComponent();
        }

    private  static bool IsSocketConnected(Socket client)
    {
        bool blockingState = client.Blocking;
        try
        {
            byte[] tmp = new byte[1];
            client.Blocking = false;
            client.Send(tmp, 0, 0);
            return false;
        }
        catch(SocketException e)
        {
            // 产生 10035 == WSAEWOULDBLOCK 错误，说明被阻止了，但是还是连接的
            if (e.NativeErrorCode.Equals(10035))
                return false;
            else
                return true;
        }
        finally
        {
            client.Blocking = blockingState;    // 恢复状态
         }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                listener = new TcpListener(IP_Address, Port);
                listener.Start();
                label1.Text = "开始监听";
                listBox.Items.Add("开始监听" + IP + ":" + Port.ToString());
                listBox.SelectedIndex = listBox.Items.Count - 1;
                //启动一个新的线程，执行方法this.StartSocketListen,
                //以便在一个独立的进程中执行确认与客户端Socket连接的操作

                SocketServiceFlag = true;
                ListenerThread = new Thread(StartSocketListen);
                ListenerThread.IsBackground = true;
                ListenerThread.Start();

                this.StartListenButton.Enabled = false;
                this.StopListenButton.Enabled = true;
            }
            catch (Exception ex)
            {
                this.listBox.Items.Add("Error: " + ex.Message);
                listBox.SelectedIndex = listBox.Items.Count - 1;//发生错误
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SocketServiceFlag = false;
            this.StartListenButton.Enabled = true;
            this.StopListenButton.Enabled = false;
            ListenerThread.Abort();
            listener.Stop();
            label1.Text = "结束侦听";
            listBox.Items.Add("结束监听" + IP + ":" + Port.ToString());
            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void StartSocketListen()//监听线程
        {
            while (SocketServiceFlag)
            {
                try
                {
                    if (listener.Pending())//确认是否有挂起的连接请求
                    {

                        Socket mySocket = listener.AcceptSocket();

                        if (clients.Count >= MAX_NUM)
                        {
                            this.listBox.Items.Add("达到最大连接数,拒绝新连接");
                            listBox.SelectedIndex = listBox.Items.Count - 1;
                            mySocket.Close();
                        }
                        else
                        {
                            //启动一个新的线程
                            //执行方法this.ServiceClient,处理用户相应的请求
                            listBox.Items.Add("建立了新连接(Socket):" + mySocket.RemoteEndPoint);
                            listBox.SelectedIndex = listBox.Items.Count - 1;
                            Client client = new Client(this, mySocket);
                            Thread clientService = new Thread(new ThreadStart(client.ServiceClient));
                            clientService.IsBackground = true;
                            clientService.Start();
                            listBox.Items.Add("成功建立新线程 For:"+mySocket.RemoteEndPoint);
                            listBox.SelectedIndex = listBox.Items.Count - 1;
                        }
                    }
                    Thread.Sleep(200);
                }
                catch (Exception str)
                {
                    listBox.Items.Add("Error: "+str.Message);
                    listBox.SelectedIndex = listBox.Items.Count - 1;
                }
            }
        }

        public void addUser(string username)
        {
            this.lbSocketClients.Items.Add(username);
            this.tbSocketClientsNum.Text = System.Convert.ToString(clients.Count);
        }
        public void removeUser(string username)
        {
            this.lbSocketClients.Items.Remove(username);
            this.tbSocketClientsNum.Text = System.Convert.ToString(clients.Count);
        }
        public string GetUserList()//用户列表 like A|B|C|D|
        {
            string Rtn = "";
            for (int i = 0; i < lbSocketClients.Items.Count; i++)
            {
                Rtn += lbSocketClients.Items[i].ToString() + "|";
            }
            return Rtn;
        }
        public void updateUI(string msg)
        {
            this.listBox.Items.Add(msg);
            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SocketServiceFlag = false;
        }

        //下面为Client类定义


        public class Client
        {
            private string name;//保存用户名
            private Socket currentSocket = null;//保存与当前用户连接的Socket对象
            private string ipAddress;//保存用户的IP地址
            private Main server;
            //保存当前连接状态Closed--connected--closed
            private string state = "closed";
            public Client(Main server, Socket clientSocket)
            {
                this.server = server;
                this.currentSocket = clientSocket;
                ipAddress = getRemoteIPAddress();
            }

            /*
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public Socket CurrentSocket
            {
                get
                {
                    return currentSocket;//ipAddress
                }
            }
            */

            private string getRemoteIPAddress()
            {
                return ((IPEndPoint)currentSocket.RemoteEndPoint).Address.ToString();
            }

            private void SendToClient(Client client, string msg)//发送到客户端数据
            {
                System.Byte[] message = System.Text.Encoding.GetEncoding("gb2312").GetBytes(msg.ToCharArray());
                client.currentSocket.Send(message, message.Length, 0);
            }

            //ServiceClient 方法用于和客户端进行数据通信，根据不同的请求命令执行相应的操作
            public void ServiceClient()
            {
                string[] tokens = null;
                byte[] buff = new byte[1024];
                bool keepConnect = true;
                string clientCommand = "";
                //用循环来不断地与客户端进行交互，直到客户端发出“OFFLINE”命令
                //将keepConnect职为false，退出循环，关闭连接，并中止当前线程

                while (keepConnect && Main.SocketServiceFlag)
                {
                    //tokens=null;
                    try
                    {
                        if (currentSocket == null || currentSocket.Available < 1)
                        {
                            Thread.Sleep(300);
                            continue;
                        }
                        int len = currentSocket.Receive(buff);
                        clientCommand = Encoding.GetEncoding("gb2312").GetString(buff, 0, len);
                        server.updateUI("Server收到命令--> " + clientCommand+" -->待解析");
                        //tokens[0]为命令标志符，很多很多种，我也记不清了
                        tokens = clientCommand.Split(new char[] { '|' });
                        if (tokens == null)
                        {
                            Thread.Sleep(200);
                            continue;
                        }
                    }
                    catch (Exception e)
                    {
                        server.updateUI("Error: 信息接受异常" + e.Message);
                    }
                    //以上代码用于服务器接收客户端发送来的数据。解析命令
                    if (tokens[0] == "ONLINE")
                    {
                        //此时接收到的命令格式化为命令标识符CONN|发送者的用户名|tokens[1]中保存了发送者的用户名
                        this.name = tokens[1];
                        if (Main.clients.Contains(this.name))
                        {
                            SendToClient(this, "ERROR|ISONLINE|");
                            server.updateUI(this.name + "重复登录,已返回重复登录的客户端错误信息");
                        }
                        else
                        {
                            Hashtable syncClients = Hashtable.Synchronized(Main.clients);
                            syncClients.Add(this.name, this);
                            //更新界面
                            server.addUser(this.name);
                            
                            System.Collections.IEnumerator myEnumerator = Main.clients.Values.GetEnumerator();
                            while (myEnumerator.MoveNext())
                            {
                                Client client = (Client)myEnumerator.Current;
                                SendToClient(client,clientCommand);
                                Thread.Sleep(100);
                            }
                            //更新状态
                            state = "connected";
                            SendToClient(this, "OKONLINE");
                            //向客户端发送OKLIST命令，以此更新客户端的当前在线用户列表
                            string msgUsers = "LIST|" + server.GetUserList();
                            SendToClient(this, msgUsers);
                            server.updateUI(this.name + "上线啦");
                            try
                            {
                                SqlConnection sqlconn = new SqlConnection(connstring);
                                sqlconn.Open();
                                string command1 = string.Format("select * from messages where receiver_id='{0}'", this.name);
                                SqlCommand sqlcomm1 = new SqlCommand(command1, sqlconn);
                                string command2 = string.Format("select * from request where receiver_id='{0}'", this.name);
                                SqlCommand sqlcomm2 = new SqlCommand(command2, sqlconn);
                                string command5 = string.Format("select * from uploadedmessage where id='{0}'", this.name);
                                SqlCommand sqlcomm5 = new SqlCommand(command5, sqlconn);


                                //利用循环把消息都发给用户
                                SqlDataReader sdr1 = sqlcomm1.ExecuteReader();
                                while (sdr1.Read())
                                {
                                    SendToClient((Client)(Main.clients[sdr1[1].ToString()]), sdr1[0].ToString());
                                }
                                sdr1.Close();
                                SqlDataReader sdr2 = sqlcomm2.ExecuteReader();
                                while (sdr2.Read())
                                {
                                    SendToClient((Client)(Main.clients[sdr2[1].ToString()]), sdr2[0].ToString());
                                }
                                sdr2.Close();
                                SqlDataReader sdr5 = sqlcomm5.ExecuteReader();
                                while (sdr5.Read())
                                {
                                    SendToClient((Client)(Main.clients[sdr5[0].ToString()]), "DOWNLOAD" + "|" + sdr5[1].ToString() + "|");
                                }
                                sdr5.Close();
                                //发完后把现在数据库内与这个人有关的数据清空
                                string command3 = string.Format("delete from messages where receiver_id='{0}'", this.name);
                                SqlCommand sqlcomm3 = new SqlCommand(command3, sqlconn);
                                string command4 = string.Format("delete from request where receiver_id='{0}'", this.name);
                                SqlCommand sqlcomm4 = new SqlCommand(command4, sqlconn);
                                string command6 = string.Format("delete from uploadedmessage where id='{0}'", this.name);
                                SqlCommand sqlcomm6 = new SqlCommand(command6, sqlconn);
                                int temp1 = sqlcomm3.ExecuteNonQuery();
                                int temp2 = sqlcomm4.ExecuteNonQuery();
                                int temp3 = sqlcomm6.ExecuteNonQuery();

                                sqlconn.Dispose();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.ToString());
                            }
                        }
                    }
                    else if (tokens[0] == "OFFLINE")
                    {
                        //向所有当前在线的用户发送该用户已离开的消息
                        if (clients.Contains(tokens[1]))
                        {
                            Client client = (Client)Main.clients[tokens[1]];
                            //将该用户对应Client对象从clients中删除
                            Hashtable syncClients = Hashtable.Synchronized(Main.clients);
                            syncClients.Remove(client.name);
                            server.removeUser(client.name);
                            //向所有客户端发送QUIT命令
                            string message = "OFFLINE|" + tokens[1];
                            System.Collections.IEnumerator myEnumerator = Main.clients.Values.GetEnumerator();
                            while (myEnumerator.MoveNext())
                            {
                                Client c = (Client)myEnumerator.Current;
                                //将发送者的用户名：发送内容  转发给用户
                                SendToClient(c, clientCommand);
                            }
                            server.updateUI(name + "下线了");
                        }
                        //退出当前线程 break;

                    }
                        
                    else if (tokens[0] == "PRIV")
                    {
                        if (state == "connected")
                        {
                            //tokens[1]中保存了发生者的用户名
                            string sender = tokens[1];
                            //tokens[2]中保存了发送者的用户名
                            string receiver = tokens[2];
                            //tokens[3]中保存了发送的内容
                            string content = tokens[3];
                            string message = sender + "发送到" + receiver + ":" + content;
                            string ReturnSenderMessage = "OKPRIV|" + receiver + "|" + content + "|";
                            //仅将信息转发给法送者和接收者
                            if (Main.clients.Contains(receiver))
                             {
                               if (IsSocketConnected(((Client)Main.clients[receiver]).currentSocket) == false)
                                {
                                    SendToClient((Client)Main.clients[receiver], clientCommand);
                                }
                                    
                                else
                                {
                                     Client client = (Client)Main.clients[tokens[2]];
                                     //将该用户对应Client对象从clients中删除
                                     Hashtable syncClients = Hashtable.Synchronized(Main.clients);
                                     syncClients.Remove(client.name);
                                     server.removeUser(client.name);

                                     //将信息保存到messages这个数据库里
                                     SqlConnection sqlconn = new SqlConnection(connstring);
                                     string command1 = string.Format("INSERT INTO messages(content,receiver_id) VALUES('{0}','{1}')", clientCommand, receiver);
                                     SqlCommand sqlcomm1 = new SqlCommand(command1, sqlconn);
                                     int fnum;
                                     try
                                     {
                                         sqlconn.Open();
                                         fnum = (int)sqlcomm1.ExecuteNonQuery();
                                         sqlconn.Close();
                                     }
                                     catch (Exception ex)
                                    {
                                         MessageBox.Show("Error: " + ex.ToString());
                                     }
                                }
                            }
                            else
                            {
                                SqlConnection sqlconn = new SqlConnection(connstring);
                                string command1 = string.Format("INSERT INTO messages(content,receiver_id) VALUES('{0}','{1}')", clientCommand, receiver);
                                SqlCommand sqlcomm1 = new SqlCommand(command1, sqlconn);
                                int fnum;
                                try
                                {
                                    sqlconn.Open();
                                    fnum = (int)sqlcomm1.ExecuteNonQuery();
                                    sqlconn.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.ToString());
                                }
                                    //退出当前线程 break;
                            }
                            if (Main.clients.Contains(sender))
                            {
                                SendToClient((Client)Main.clients[sender], ReturnSenderMessage);
                            }
                            server.updateUI(message);
                        }
                        else
                        {
                            //send err to server
                            SendToClient(this, "ERR|SERVERERR|");
                        }
                    }
                    
                    else if(tokens[0]=="VIBRATE")
                    {
                        if (state == "connected")
                        {
                            //tokens[1]中保存了发生者的用户名
                            string sender = tokens[1];
                            //tokens[2]中保存了发送者的用户名
                            string receiver = tokens[2];

                            string message = "窗口震动"+sender + "-->" + receiver;
                            //仅将信息转发给法送者和接收者
                            if (Main.clients.Contains(receiver))
                            {
                                SendToClient((Client)Main.clients[receiver], clientCommand);
                            }
                            server.updateUI(message);
                        }
                        else
                        {
                            //send err to server
                            SendToClient(this, "ERR|SERVERERR|");
                        }
                    }

                    else if(tokens[0]=="FRIREQ")
                    {
                        if (state == "connected")
                        {
                            //tokens[1]中保存了发生者的用户名
                            string sender = tokens[1];
                            //tokens[2]中保存了发送者的用户名
                            string receiver = tokens[2];
                            //tokens[3]中保存了发送的内容
                            string content = tokens[3];
                            if (Main.clients.Contains(receiver))
                            {
                                if (IsSocketConnected(((Client)Main.clients[receiver]).currentSocket) == true)
                                    SendToClient((Client)Main.clients[receiver], clientCommand);
                                else
                                {
                                    Client client = (Client)Main.clients[tokens[2]];
                                    //将该用户对应Client对象从clients中删除
                                    Hashtable syncClients = Hashtable.Synchronized(Main.clients);
                                    syncClients.Remove(client.name);
                                    server.removeUser(client.name);

                                    //将好友请求保存到request这个数据库里
                                    SqlConnection sqlconn = new SqlConnection(connstring);
                                    string command1 = string.Format("INSERT INTO request(content,receiver_id) VALUES('{0}','{1}')", clientCommand, receiver);
                                    SqlCommand sqlcomm1 = new SqlCommand(command1, sqlconn);
                                    int fnum;
                                    try
                                    {
                                        sqlconn.Open();
                                        fnum = (int)sqlcomm1.ExecuteNonQuery();
                                        sqlconn.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Error: " + ex.ToString());
                                    }
                                }
                            }
                            else
                            {
                                SqlConnection sqlconn = new SqlConnection(connstring);
                                string command1 = string.Format("INSERT INTO request(content,receiver_id) VALUES('{0}','{1}')", clientCommand, receiver);
                                SqlCommand sqlcomm1 = new SqlCommand(command1, sqlconn);
                                int fnum;
                                try
                                {
                                    sqlconn.Open();
                                    fnum = (int)sqlcomm1.ExecuteNonQuery();
                                    sqlconn.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.ToString());
                                }
                                //退出当前线程 break;
                            }
                            if (Main.clients.Contains(receiver))
                            {
                                SendToClient((Client)Main.clients[receiver], clientCommand);
                            }
                            server.updateUI(sender + "提出好友申请,希望加的好友为" + receiver);
                        }
                        else
                        {
                            //send err to server
                            SendToClient(this, "ERR|SERVERERR|");
                        }
                    }

                    else if (tokens[0] == "ACCREQ")
                    {
                        if (state == "connected")
                        {
                            //tokens[1]中保存了发生者的用户名
                            string sender = tokens[1];
                            //tokens[2]中保存了发送者的用户名
                            string receiver = tokens[2];
                            //tokens[3]中保存了发送的内容
                            string content = tokens[3];


                            bool isSucceed=true;
                            //数据库处理
                            SqlConnection sqlconn = new SqlConnection(connstring);
                            string command1 = string.Format("select num from friends where id='{0}'", sender);
                            string command2 = string.Format("select num from friends where id='{0}'", receiver);
                            SqlCommand sqlcomm1 = new SqlCommand(command1, sqlconn);
                            SqlCommand sqlcomm2 = new SqlCommand(command2, sqlconn);
                            int fnumR;
                            int fnumS;
                            try
                            {
                                sqlconn.Open();
                                fnumS = (int)sqlcomm1.ExecuteScalar();
                                fnumR = (int)sqlcomm2.ExecuteScalar();
                                string command3 = string.Format("update friends set num={0},f{1}='{2}' where id='{3}'",(fnumR+1).ToString(),(fnumR+1).ToString(),sender,receiver);
                                SqlCommand sqlcomm3=new SqlCommand(command3,sqlconn);
                                if(sqlcomm3.ExecuteNonQuery()!=1)
                                {
                                    isSucceed = false;
                                }
                                string command4 = string.Format("update friends set num={0},f{1}='{2}' where id='{3}'", (fnumS + 1).ToString(), (fnumS + 1).ToString(), receiver, sender);
                                SqlCommand sqlcomm4 = new SqlCommand(command4, sqlconn);
                                if (sqlcomm4.ExecuteNonQuery() != 1)
                                {
                                    isSucceed = false;
                                }
                                sqlconn.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.ToString());
                                isSucceed = false;
                            }
                            if(isSucceed==true)
                            {
                                server.updateUI(sender + "接受了" + receiver + "的好友申请,希望加的好友为");
                                if (Main.clients.Contains(receiver))
                                {
                                    SendToClient((Client)Main.clients[receiver], clientCommand);
                                    Thread.Sleep(100);
                                    SendToClient((Client)Main.clients[receiver], "FRESH|");
                                }
                                if(Main.clients.Contains(sender))
                                {
                                    SendToClient((Client)Main.clients[sender], "FRESH|");
                                }
                            }
                        }
                        else
                        {
                            //send err to server
                            SendToClient(this, "ERR|SERVERERR|");
                        }
                    }

                    else if (tokens[0] == "REFREQ")
                    {
                        if (state == "connected")
                        {
                            //tokens[1]中保存了发生者的用户名
                            string sender = tokens[1];
                            //tokens[2]中保存了发送者的用户名
                            string receiver = tokens[2];
                            //tokens[3]中保存了发送的内容
                            string content = tokens[3];

                            if (Main.clients.Contains(receiver))
                            {
                                SendToClient((Client)Main.clients[receiver], clientCommand);
                            }
                            server.updateUI(sender + "接受了" + receiver + "的好友申请,希望加的好友为");
                        }
                        else
                        {
                            //send err to server
                            SendToClient(this, "ERR|SERVERERR|");
                        }
                    }
                    else if (tokens[0]=="UPLOAD")
                    {
                        SqlConnection sqlconn = new SqlConnection(connstring);
                        string command1 = string.Format("INSERT INTO uploadedmessage(id,content) VALUES('{0}','{1}')",tokens[1] ,tokens[2] );
                        SqlCommand sqlcomm1 = new SqlCommand(command1, sqlconn);
                        int fnum;
                        try
                        {
                            sqlconn.Open();
                            fnum = (int)sqlcomm1.ExecuteNonQuery();
                            sqlconn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.ToString());
                        }
                    }

                    Thread.Sleep(200);
                    
                    /*
                    else if (tokens[0] == "CHATROOM")
                    {
                        if (state == "connected")
                        {
                            //此时收到的命令的格式为：命令标识符CHAT|发送者的用户名：发送内容|向所有当前在线的用户转发此信息
                            System.Collections.IEnumerator myEnumerator = Main.clients.Values.GetEnumerator();
                            while (myEnumerator.MoveNext())
                            {
                                Client client = (Client)myEnumerator.Current;
                                //将发送者的用户名：发送内容  转发给用户
                                SendToClient(client,clientCommand);
                            }
                            server.updateUI("聊天室消息:"+tokens[1]);
                        }
                        else
                        {
                            //send err to server
                            SendToClient(this, "ERR|state error,please login first");
                        }
                    }
                         */
                    Thread.Sleep(200);
                }
            }
        }
    }
}

