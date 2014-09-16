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

namespace SeekMe
{
    public partial class PasswordSet2 : Form
    {
        public PasswordSet2(string id)
        {
            InitializeComponent();
            label2.Text = id;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bool state = true;
            if(JudgePW(PassNew1.Text,PassNew2.Text)==1)
            {
                SqlConnection sqlconn = new SqlConnection(Friends.connstring);
                string command = string.Format("update info set pw_sha1='{0}' where id='{1}'", Login.GetSHA1(PassNew1.Text),label2.Text);
                SqlCommand sqlcomm = new SqlCommand(command, sqlconn);
                try
                {
                    sqlconn.Open();
                    if(sqlcomm.ExecuteNonQuery()==1)
                    {
                        MessageBox.Show("密码修改成功");
                    }
                    else
                    {
                        MessageBox.Show("数据库访问错误，密码修改失败");
                        state = false;
                    }
                    sqlconn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "修改密码数据库相关错误");
                    state = false;
                }
            }
            if(state==true)
            {
                this.DialogResult = DialogResult.OK;
            }
            
        }
        public static int JudgePW(string pw1, string pw2)
        {
            //首先判断是否科学;
            int len1 = pw1.Length;
            int len2 = pw2.Length;
            if (len1 != len2)
            {
                MessageBox.Show("密码长度不一致", "Sorry");
                return 0;
            }
            for (int i = 0; i < len1; i++)
            {
                if (pw1[i] != pw2[i])
                {
                    MessageBox.Show("密码输入不一致", "Sorry");
                    return 0;
                }
            }
            if (len1 >= 6 && len1 <= 20)
            {
                for (int i = 0; i < len1; i++)
                {
                    if (pw1[i] < 33 && pw2[i] > 126)
                    {
                        MessageBox.Show("密码可能包含非法字符", "Sorry");
                        return 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("密码长度不正确", "Sorry");
                return 0;
            }
            return 1;
        }
    }
}
