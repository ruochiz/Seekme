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
    public partial class ReceiveRequest : Form
    {
        private Point offset;
        string myid = Friends.myInfo.id;
        string requestid = "";
        public ReceiveRequest(string id,string content)
        {
            InitializeComponent();
            requestid = id;
            ReReName_label.Text = id;
            ReReCon_label.Text = content;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReRef_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReceiveRequest_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void ReceiveRequest_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        private void ReRec_button_Click(object sender, EventArgs e)
        {
            string message = "ACCREQ|" + myid + "|" + requestid + "|" ;
            byte[] outbytes = System.Text.Encoding.GetEncoding("gb2312").GetBytes(message.ToCharArray());   //将字符串转化为字符数组
            Friends.Stream.Write(outbytes, 0, outbytes.Length);
            this.DialogResult = DialogResult.OK;
        }
    }
}
