using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections;


namespace SeekMe
{
    public partial class Friends : Form
    {
        //连接服务器的基本信息
        public static string IP = "59.66.135.77";//默认的服务器IP
        //public static string IP_Local = "";
        public static int Port = 8082;//默认的端口
        public static string connstring = String.Format("Data Source={0};Initial Catalog=UsersData;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        public static IPAddress IP_Address = IPAddress.Parse(IP);//定义IP地址（类型）
        public static IPEndPoint IP_EndPoint = new IPEndPoint(IP_Address, Port);//定义EndPoint

        //离线消息有关
        public static Hashtable hashtable = new Hashtable();
        public static int count = 1;
        public static int temp = 0;

        //移动窗体相关
        private Point offset;
        
        //登陆时获取
        public static InfoofFriend myInfo;
       
        //获取好友列表以及基本信息
        public static int FriendsNum;
        public static InfoofFriend[] FriendInfo ;

        //网络Socket相关
        public static TcpClient tcpClient;
        public static NetworkStream Stream;
        public static string CLOSED = "closed";
        public static string CONNECTED = "connected";
        public string state = CLOSED;
        public static bool stopFlag;
        

        public class InfoofFriend
        {
            public string id = "";
            public string nickname = "";
            public string sex = "";
            public string birthday = "";
            public int age;
            public Chat chat = null;
            public int imagenum;
            public int state;
        };

        public Friends()
        {
            InitializeComponent();
        }
        private void Friends_Load(object sender, EventArgs e)
        {
            LoadProgram();
            ConnectServer();
        }

        //以下为加载方法
        private void LoadProgram()
        {
            LoadFriendID();
            LoadFriendInfo();
            DownloadImages();
            LoadListBox();
            welcome_label.Text = string.Format("{0} ({1})", myInfo.nickname, myInfo.id);
        }

        private bool LoadFriendID()
        {
            bool state = true;
            SqlConnection GetFriendInfoConn = new SqlConnection(connstring);
            string GetFriendList = string.Format("select * from friends where id='{0}'", myInfo.id);//首先获取好友的id信息
            SqlCommand GetFriendListComm = new SqlCommand(GetFriendList, GetFriendInfoConn);
            SqlDataReader FriendListData;
            try
            {
                GetFriendInfoConn.Open();
                FriendListData = GetFriendListComm.ExecuteReader();
                if (FriendListData.Read())
                {
                    FriendsNum = (int)FriendListData[1];
                    FriendInfo = new InfoofFriend[FriendsNum];
                    for (int i = 0; i < FriendsNum; i++)
                    {
                        FriendInfo[i] = new InfoofFriend();
                        FriendInfo[i].id = FriendListData[i + 2].ToString();
                    }

                }
                else
                {
                    state = false;
                }
                FriendListData.Close();
                GetFriendInfoConn.Close();
            }
            catch (Exception str)
            {
                MessageBox.Show("Error: " + str.Message, "获取好友ID错误");
                state = false;
            }
            return state;
        }

        private bool LoadFriendInfo()
        {
            bool state = true;
            SqlConnection GetFriendInfoConn = new SqlConnection(connstring);
            try
            {
                GetFriendInfoConn.Open();
                for (int i = 0; i < FriendsNum; i++)
                {
                    string FriendID = FriendInfo[i].id;
                    string GetFriendInfo = string.Format("select * from info where id='{0}'", FriendID);//首先获取好友的id信息
                    SqlCommand GetFriendInfoComm = new SqlCommand(GetFriendInfo, GetFriendInfoConn);
                    SqlDataReader FriendInfoList = GetFriendInfoComm.ExecuteReader();
                    if (FriendInfoList.Read())
                    {
                        FriendInfo[i].id = FriendID;
                        FriendInfo[i].nickname = Convert.ToString(FriendInfoList["nickname"]);
                        FriendInfo[i].sex = Convert.ToString(FriendInfoList["sex"]);
                        FriendInfo[i].birthday = Convert.ToString(FriendInfoList["birthday"]);
                        FriendInfo[i].age = Convert.ToInt32(FriendInfoList["age"]);
                    }
                    else
                    {
                        state = false;
                    }
                    FriendInfoList.Close();
                }
                GetFriendInfoConn.Close();
            }
            catch (Exception str)
            {
                MessageBox.Show("Error: " + str, "获取好友编号错误");
                state = false;
            }
            return state;
        }


        private bool DownloadImages()
        {
            bool state = true;
            for(int i=0;i<FriendsNum;i++)
            {
                string imagefilepath = "";
                string id = FriendInfo[i].id;
                if (getImage(id))
                {
                    imagefilepath = "images\\" + id + ".jpg";
                    imageList.Images.Add(Image.FromFile(imagefilepath));
                    imageList_small.Images.Add(Image.FromFile(imagefilepath));
                }
                else
                {
                    imageList.Images.Add(Properties.Resources.touxiang);
                    imageList_small.Images.Add(Properties.Resources.touxiang);
                    state = false;
                }
            }
            return state;
        }
        private bool getImage(string id)
        {
            bool state = true;
            string filename = id + ".jpg";
            string filepath = "http://" + IP + "/images/" + filename;//头像网络路径
            if (!Directory.Exists("images"))
            {
                Directory.CreateDirectory("images");
            }
            try
            {
                WebClient nf = new WebClient();
                WebRequest req = WebRequest.Create(filepath);
                WebResponse res = null;
                res = req.GetResponse();
                if (res != null)
                    nf.DownloadFile(filepath, "images\\" + filename);
                else
                    state = false;
                res.Close();
            }
            catch
            {
                state = false;
            }
            return state;
        }

        private void LoadListBox()
        {
            FriList.BeginUpdate();//数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
            for (int i = 0; i < FriendsNum; i++)
            {
                String NewItemName = String.Format("{0} ({1})", FriendInfo[i].nickname, FriendInfo[i].id);
                ListViewItem user = new ListViewItem();
                user.Text = NewItemName;
                user.ImageIndex = i;
                FriList.Items.Add(user);
            }
            FriList.EndUpdate();
        }

        private void ConnectServer()//连接服务器
        {
            if (state == CONNECTED)
            {
                return;
            }
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(IP_Address,Port);
                Stream = tcpClient.GetStream();
                //启动一个新的线程，执行方法this.ServerResponse()，以响应从服务器的消息
                Thread thread1 = new Thread(new ThreadStart(this.ServerResponse));
                thread1.IsBackground = true;
                thread1.Start();
                //向服务器发送CONN请求命令
                //命令格式为：命令标志符CONN|发送者的用户名
                string cmd = "ONLINE|" + myInfo.id + "|";
                Byte[] outbytes = Encoding.GetEncoding("gb2312").GetBytes(cmd.ToCharArray());//修改过
                Stream.Write(outbytes, 0, outbytes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"服务器错误,服务器将关闭");
                this.Close();
            }

        }

        private void ServerResponse()//响应服务器的命令
        {
            //定义一个byte数组，用于接收从服务器端发来的数据
            //每次所能接受的数据包的最大长度为1024个字节
            byte[] buff = new byte[1024];
            string msg;
            int len;
            try
            {
                if (Stream.CanRead == false)
                {
                    return;
                }
                stopFlag = false;
                while (!stopFlag)
                {
                    //从流中得到数据，并存入到buff字符数组中
                    len = Stream.Read(buff, 0, buff.Length);
                    if (len < 1)
                    {
                        Thread.Sleep(200);
                        continue;
                    }
                    msg = Encoding.GetEncoding("gb2312").GetString(buff, 0, len);
                    msg.Trim();
                    string[] tokens = msg.Split(new char[] { '|' });
                    //把命令分解开 tokens[0]为命令类型
                    //下面为处理各种命令
                    
                    if (tokens[0].ToUpper() == "PRIV")
                    {
                        string sender = tokens[1];
                        string content = tokens[3];
                        string time = tokens[4];
                        int i;
                        for (i = 0; FriendInfo[i].id != sender; i++) ;

                        if (FriendInfo[i].chat==null || FriendInfo[i].chat.Visible == false) 
                        {
                            //窗口未打开的情况
                            hashtable.Add((count++), sender + "(" + time + ")" + "\t" + content + "\n");
                            MessageBox.Show("您收到一条新消息,请进入消息中心");
                                                     
                        }
                        else
                        {
                            string addmsg = (sender + "(" + time + ")" + "\n" + content + "\n");
                            FriendInfo[i].chat.MsgReceived.AppendText(addmsg);
                        }
                    }
                    else if(tokens[0].ToUpper()=="OKPRIV")
                    {
                        string receiver = tokens[1];
                        string content = tokens[2];
                        int i;
                        for (i = 0; FriendInfo[i].id != receiver; i++) ;

                        if (FriendInfo[i].chat == null || FriendInfo[i].chat.Visible == false)
                        {
                            //如果窗口没有打开 待处理
                        }
                        else
                        {
                            string addmsg = "\""+content+"\""+"(已成功发送)\n";
                            FriendInfo[i].chat.MsgReceived.AppendText(addmsg);
                        }
                    }

                    else if (tokens[0].ToUpper() == "DOWNLOAD")
                    {
                        hashtable.Add(hashtable.Count + 1, tokens[1]);
                    }

                    else if (tokens[0].ToUpper() == "VIBRATE")
                    {
                        string sender = tokens[1];
                        int i;
                        for (i = 0; FriendInfo[i].id != sender; i++) ;

                        if (FriendInfo[i].chat == null)
                        {
                            FriendInfo[i].chat = new Chat(FriendInfo[i]);
                        }
                        FriendInfo[i].chat.Show();
                        FriendInfo[i].chat.MsgReceived.AppendText("Receive窗口震动\n");
                        FriendInfo[i].chat.vibrate();
                    }
                    else if (tokens[0].ToUpper() == "LIST")
                    {
                        //暂时未定义
                        //此时从服务器返回的消息格式：命令标志符LIST|用户名1|用户名2|。。（所有在线用户名）
                        /*lstUsers.Items.Clear();
                        for (int i = 1; i < tokens.Length - 1; i++)
                        {
                            lstUsers.Items.Add(tokens[i].Trim());
                        }*/
                    }
                    else if (tokens[0] == "FRIREQ")
                    {
                        string id = tokens[1];
                        string content = tokens[3];
                        ReceiveRequest rr = new ReceiveRequest(id, content);
                        rr.ShowDialog();
                        if (rr.DialogResult == DialogResult.OK)
                        {
                            MessageBox.Show("接受" + id + "为好友");
                        }

                    }
                    else if (tokens[0] == "REFREQ")
                    {
                        MessageBox.Show("您的好友请求被拒绝：" + tokens[1]);
                    }
                    else if (tokens[0] == "ACCREQ")
                    {
                        MessageBox.Show("您的好友已通过\n" + tokens[1] + "已成为您的好友");
                    }
                    else if (tokens[0].ToUpper() == "OKONLINE")
                    {
                        OnlineState.Text = "在线";
                        this.state = CONNECTED;
                    }
                    else if (tokens[0].ToUpper() == "ONLINE")
                    {
                        if (tokens[1] != myInfo.id)
                        {
                            MessageBox.Show(tokens[1] + "上线");

                        }
                        else
                        {
                            this.state = CONNECTED;
                        }
                    }
                    else if (tokens[0].ToUpper() == "OFFLINE")
                    {
                        if (tokens[1] != myInfo.id)
                        {
                            MessageBox.Show(tokens[1] + "下线");
                        }
                        else
                        {
                            this.state = CONNECTED;
                        }
                    }
                    else if (tokens[0].ToUpper() == "FRESH")
                    {
                        FriList.Clear();
                        imageList.Images.Clear();
                        imageList_small.Images.Clear();
                        LoadProgram();
                    }
                    else if (tokens[0].ToUpper() == "ERROR")
                    {
                        if (tokens[1] == "ISONLINE")
                        {
                            MessageBox.Show("该账户已经登陆,此窗口会自动关闭");
                            this.state = CLOSED;
                            this.Close();
                        }
                        else if (tokens[1] == "SERVERERR")
                        {
                            MessageBox.Show("服务器连接错误，信息并未成功发送");
                        }
                    }
                    else
                    {
                        //如果从服务器返回的其他消息格式，则直接显示
                        MessageBox.Show(msg, "客户端收到其他种类的消息");
                    }
                }
                //关闭连接
                tcpClient.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"与服务器的连接断开");
                this.state = CLOSED;
                
            }
        }

        private void ShowUp()
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowUp();       
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 打开SeekMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUp();
        }

        private void Friends_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon.Visible = false;
            //隐藏任务栏图标
            if (this.state == CONNECTED)
            {
                string ExitMsg = "OFFLINE|" + myInfo.id + "|";
                //将字符串转化为字符数组
                byte[] outbytes = Encoding.GetEncoding("gb2312").GetBytes(ExitMsg.ToCharArray());
                Stream.Write(outbytes, 0, outbytes.Length);
                Stream.Close();
            }
            this.state = CLOSED;
            stopFlag = true;
            
        }

        private void Set_Click(object sender, EventArgs e)
        {
            Set Set1 = new Set();
            Set1.ShowDialog();
        }

        private void PassWordSet_Click(object sender, EventArgs e)
        {
            PasswordSet PSet = new PasswordSet();
            PSet.ShowDialog();
        }

        private void AddFriend_Click(object sender, EventArgs e)
        {
            Search SearchF = new Search();
            SearchF.Show();
        }

        private void SetSelfInfo_Click(object sender, EventArgs e)
        {
            SelfSet ss = new SelfSet();
            ss.Show();
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FriList.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FriList.View = View.SmallIcon;
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FriList.View = View.List;
        }

        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FriList.View = View.Tile;
        }

        private void FriList_DoubleClick(object sender, EventArgs e)
        {
            if (FriendInfo[FriList.SelectedItems[0].Index].chat==null)
            {
                FriendInfo[FriList.SelectedItems[0].Index].chat = new Chat(FriendInfo[FriList.SelectedItems[0].Index]);
            }
            
            FriendInfo[FriList.SelectedItems[0].Index].chat.Show();           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            foreach (DictionaryEntry dicEntry in hashtable)
            {
                string message = "UPLOAD" + "|"+myInfo.id + "|" +dicEntry.Value+ "|";
                byte[] outbytes = System.Text.Encoding.GetEncoding("gb2312").GetBytes(message.ToCharArray());   //将字符串转化为字符数组
                Stream.Write(outbytes, 0, outbytes.Length);
                Thread currentThread = Thread.CurrentThread;//得到当前线程
                Thread.Sleep(100); //让线程休息0.1秒钟
            }
            Thread.Sleep(100); //让线程休息0.1秒钟
            if (this.state == CONNECTED)
            {
                string ExitMsg = "OFFLINE|" + myInfo.id + "|";
                //将字符串转化为字符数组
                byte[] outbytes = Encoding.GetEncoding("gb2312").GetBytes(ExitMsg.ToCharArray());
                Stream.Write(outbytes, 0, outbytes.Length);
                Stream.Close();
            }
            this.state = CLOSED;
            stopFlag = true;
            this.Close();
        }

        private void Friends_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void Friends_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        private void 皮肤1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = SeekMe.Properties.Resources.好友列表背景1;
        }

        private void 皮肤2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = SeekMe.Properties.Resources.好友列表背景2;
        }

        private void 皮肤3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = SeekMe.Properties.Resources.好友列表背景3;
        }

        private void TimerForCheckConn_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MsgBox msgbox1 = new MsgBox();
                msgbox1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temp = 0;
        }
    }
}
