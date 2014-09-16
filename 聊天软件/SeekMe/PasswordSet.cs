using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SeekMe
{
    public partial class PasswordSet : Form
    {
        private Point offset;
        public PasswordSet()
        {
            InitializeComponent();
        }

        private void PasswordSet_Load(object sender, EventArgs e)
        {

        }

        private void PasswordSet_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void PasswordSet_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        private bool CheckOldPW(string Old_PW)
        {
            bool state = false;

            //需要传送到数据库的内容
            string sql = string.Format("select pw_sha1 from info where id='{0}'", Friends.myInfo.id);
            //创建Connection对象
            SqlConnection conn = new SqlConnection(Friends.connstring);
            //创建Command对象
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                string pw_sha1 = command.ExecuteScalar().ToString();

                if (string.Compare(pw_sha1, Old_PW) == 0)
                {
                    state = true;
                }
                else
                {
                    MessageBox.Show("旧密码错误", "Error");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "修改密码发生错误");
            }
            finally
            {
                conn.Close();
            }
            return state;
        }
        private bool JudgeNewPW(string pw1, string pw2)
        {

            //首先判断是否科学;
            int len1 = pw1.Length;
            int len2 = pw2.Length;
            if (len1 != len2)
            {
                MessageBox.Show("密码长度不一致", "Sorry");
                return false;
            }
            for (int i = 0; i < len1; i++)
            {
                if (pw1[i] != pw2[i])
                {
                    MessageBox.Show("密码输入不一致", "Sorry");
                    return false;
                }
            }
            if (len1 >= 6 && len1 <= 20)
            {
                for (int i = 0; i < len1; i++)
                {
                    if (pw1[i] < 33 && pw2[i] > 126)
                    {
                        MessageBox.Show("密码可能包含非法字符", "Sorry");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("密码长度不正确", "Sorry");
                return false;
            }
            return true;

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

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string old_pw_sha1_input = GetSHA1(PassSetOld_textbox.Text);
            string new_pw_sha1_input = GetSHA1(PassSetNew_textbox.Text);

            if (CheckOldPW(old_pw_sha1_input))
            {
                if (JudgeNewPW(PassSetNew_textbox.Text, PassSetNewCon_textbox.Text))
                {
                    //需要传送到数据库的内容
                    string sql = string.Format("update info set pw_sha1='{0}' where id='{1}'", new_pw_sha1_input, Friends.myInfo.id);
                    //创建Connection对象
                    SqlConnection conn = new SqlConnection(Friends.connstring);
                    //创建Command对象
                    SqlCommand command = new SqlCommand(sql, conn);
                    try
                    {
                        conn.Open();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("修改成功");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("修改失败");
                        }

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error: " + exc.Message, "修改密码时发生错误");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}