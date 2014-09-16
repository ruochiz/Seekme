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

namespace SeekMe
{
    public partial class Login : Form
    {
        private Point offset;
        
        public Login()
        {
            InitializeComponent();
        }

        private void ShowUp()
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        public static string GetSHA1(string pwdata_s)
        {
            System.Security.Cryptography.SHA1CryptoServiceProvider osha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] pwdata_b = enc.GetBytes(pwdata_s);//password(string) to byte[]
            byte[] pwsha1_b = osha1.ComputeHash(pwdata_b);//ToHash
            string pwsha1_s = BitConverter.ToString(pwsha1_b).Replace("-", "");//hash to string
            return pwsha1_s;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if(ConfirmPassword())
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("用户名密码输入错误，请重新输入一下吧！", "Error!");
        }

        private bool ConfirmPassword()//返回0表示验证错误，返回非0
        {
            bool state = true;
            String pw_sha1 = GetSHA1(Password.Text);
            String ID_text = this.ID.Text;

            string sql = string.Format("select * from info where id='{0}' and pw_sha1='{1}'", ID_text ,pw_sha1);
            SqlConnection conn = new SqlConnection(Friends.connstring);
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    Friends.myInfo = new Friends.InfoofFriend();
                    Friends.myInfo.id = ID_text;
                    Friends.myInfo.nickname = Convert.ToString(data["nickname"]);
                    Friends.myInfo.sex = Convert.ToString(data["sex"]);
                    Friends.myInfo.birthday = Convert.ToString(data["birthday"]);
                    Friends.myInfo.age = Convert.ToInt32(data["age"]);
                }
                else
                    state = false;
                data.Close();
                conn.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: "+exc.Message, "确认密码时发生错误");
                state = false;
            }
            return state;
        }

        private void Set_Button_Click(object sender, EventArgs e)
        {
            Set Set1=new Set();
            Set1.ShowDialog();
        }

        private void Reg_Button_Click(object sender, EventArgs e)
        {
            Reg Reg1 = new Reg();
            Reg1.ShowDialog();
            if(Reg1.DialogResult==DialogResult.OK)
            {
                ID.Text = Reg1.id.Text;
            }
        }

        private void 打开SeekMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUp();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon_Login_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowUp();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon_Login.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordSetQ sp = new PasswordSetQ();
            sp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        } 
    }
}
