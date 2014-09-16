using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeekMe
{
    public partial class SendRequest : Form
    {
        string myid = Friends.myInfo.id;
        string requestid = "";
        public SendRequest(string id)
        {
            InitializeComponent();
            requestid = id;
        }

        private void SendRequest_Load(object sender, EventArgs e)
        {

        }

        private void SendRequest_button_Click(object sender, EventArgs e)
        {
            string message = "FRIREQ|" + myid + "|" + requestid + "|" + SendRequest_richtextbox.Text + "|";
            byte[] outbytes = System.Text.Encoding.GetEncoding("gb2312").GetBytes(message.ToCharArray());   //将字符串转化为字符数组
            Friends.Stream.Write(outbytes, 0, outbytes.Length);
            MessageBox.Show("好友请求已发送");
            this.DialogResult = DialogResult.OK;
        }
    }
}
