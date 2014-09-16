using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;

namespace SeekMe
{
    public partial class Chat : Form
    {
        private Point offset;
        int SendState = 0;
        Friends.InfoofFriend myfriendinfo;
        string myid;

        public Chat(Friends.InfoofFriend myFriendInfo)
        {
            InitializeComponent();
            //好友的基本信息
            myfriendinfo = myFriendInfo;
            myid = Friends.myInfo.id;
            
            //处理窗口文字内容
            this.Text = myFriendInfo.nickname;
            label2.Text = "来自\"" + myFriendInfo.nickname + "\"的消息";
            if (myFriendInfo.sex=="男")
                pictureBox2.BackgroundImage = SeekMe.Properties.Resources.boy;
            else
                pictureBox2.BackgroundImage = SeekMe.Properties.Resources.girl;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
           e.Cancel = true;
           this.Hide();
           //this.Dispose();
        }

        private void SendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                string receiver = myfriendinfo.id;
                string time = DateTime.Now.ToLongTimeString(); 
                string msg = MsgToBeSent.Text;
                //消息的格式是：命令标识符PRIV|发送者的用户名|接收者的用户名|发送内容|时间|
                string message = "PRIV|" + Friends.myInfo.id + "|" + receiver + "|" + msg + "|"+ time +"|";
                byte[] outbytes = System.Text.Encoding.GetEncoding("gb2312").GetBytes(message.ToCharArray());   //将字符串转化为字符数组
                Friends.Stream.Write(outbytes, 0, outbytes.Length);
                MsgToBeSent.Clear();
                MsgReceived.AppendText(myid + "(" + time + ")" + "\n" + msg + "\n");
            }
            catch
            {
                MessageBox.Show("网络发生错误！");
            }
        }

        private void MsgToBeSent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Control.ModifierKeys == Keys.Control && SendState == 0)
            {
                SendMsg_Click(sender, e);
            }
            else if (SendState == 1)
            {
                if (e.KeyCode == Keys.Enter && Control.ModifierKeys != Keys.Control)
                    SendMsg_Click(sender, e);
            }
        }

        private void 按Enter发送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendState = 1;
            label1.Text = "按Enter发送消息";
            EnterToSend.Checked = true;
            CtrlEnterToSend.Checked = false;
        }


        private void CtrlEnterToSend_Click(object sender, EventArgs e)
        {
            SendState = 0;
            label1.Text = "按Ctrl+Enter发送消息";
            EnterToSend.Checked = false;
            CtrlEnterToSend.Checked = true;
        }

        private void Chat_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void Chat_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        private void MsgReceived_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            vibrate();
            try
            {
                string receiver = myfriendinfo.id;
                //消息的格式是：命令标识符PRIV|发送者的用户名|接收者的用户名|发送内容|时间|
                string message = "VIBRATE|" + Friends.myInfo.id + "|" + receiver + "|";
                byte[] outbytes = System.Text.Encoding.GetEncoding("gb2312").GetBytes(message.ToCharArray());   //将字符串转化为字符数组
                Friends.Stream.Write(outbytes, 0, outbytes.Length);
                MsgReceived.AppendText("您发送了一个窗口震动\n");
            }
            catch
            {
                MessageBox.Show("网络发生错误！");
            }
        }
        public int index = 0;
        public int count = 0;
        public void vibrate()
        {
               
            Random ran = new Random((int)DateTime.Now.Ticks);

            Point point = this.Location;

            for (int i = 0; i < 40; i++)
            {
                this.Location = new Point(point.X + ran.Next(8) - 4, point.Y + ran.Next(8) - 4);

                System.Threading.Thread.Sleep(15);

                this.Location = point;

                System.Threading.Thread.Sleep(15);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MsgReceived.AppendText("---------------以上为历史消息---------------\n");
            this.Close();
        }
    }
}


