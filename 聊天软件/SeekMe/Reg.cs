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
    public partial class Reg : Form
    {
        private Point offset;
        string sex = "男";
        public Reg()
        {
            InitializeComponent();
            for(int i=10;i<=70;i++)
            {
                Age.Items.Add(i.ToString());
            }
        }

        private int SearchID(string id)
        {
            int state = 0;
            //首先判断是否科学;
            int len = id.Length;
            if(len>=2 && len<=20)
            {
                for(int i=0;i<len;i++)
                {
                    if(!((id[i]>='0'&&id[i]<='9')||(id[i]>='a'&&id[i]<='z')||
                        (id[i]>='A'&&id[i]<='Z')||id[i]=='_'))
                    {
                        MessageBox.Show("用户名字符不符合规范", "Sorry");
                        return state;
                    }
                }
            }
            else
            {
                MessageBox.Show("用户名长度不符合规范", "Sorry");
                return state;
            }
 
            //start_SQL
            //连接字符串
            String connString = Friends.connstring;
            //创建Connection对象
            SqlConnection conn = new SqlConnection(connString);
            //需要传送到数据库的内容
            string sql = string.Format("select id from info where id='{0}'",id);
            //创建Command对象
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                String s4 = Convert.ToString(command.ExecuteScalar());
                if (String.Compare("", s4) != 0)
                { 
                    MessageBox.Show("很抱歉，此用户名已存在","Sorry");                 
                    //MessageBox.Show("数据库连接成功", "谁说不是呢");
                    
                }
                else
                {
                    state = 1;
                }
            }
            catch
            {
                MessageBox.Show("数据库错误", "Sorry");
            }
            finally
            {
                conn.Close();
                //MessageBox.Show("数据库关闭成功", "谁说不是呢");
            }
            return state;
        }

        private int JudgeNickname(string nickname)
        {
            //首先判断是否科学;
            int len = nickname.Length;
            if (len <= 16)
            {
                for (int i = 0; i < len; i++)
                {
                    if (nickname[i] < 33 && nickname[i] > 126)
                    {
                        MessageBox.Show("昵称可能包含特殊字符", "Sorry");
                        return 0;

                    }
                }
            }
            else
            {
                MessageBox.Show("昵称长度不正确", "Sorry");
                return 0;
            }
            return 1;
        }

        public static int JudgePW(string pw1,string pw2)
        {
            //首先判断是否科学;
            int len1 = pw1.Length;
            int len2 = pw2.Length;
            if (len1 != len2)
            {
                MessageBox.Show("密码长度不一致", "Sorry");
                return 0;
            }
            for (int i = 0; i < len1;i++ )
            {
                if (pw1[i] != pw2[i])
                {
                    MessageBox.Show("密码输入不一致", "Sorry");
                    return 0;
                }
            }
            if (len1>=6 && len1 <= 20)
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

        private void Submit_Click(object sender, EventArgs e)
        {
           
            if(SearchID(id.Text)==0)
            {
                return;
            }
            else if(JudgeNickname(nickname.Text)==0)
            {
                return;
            }
            else if(String.Compare(Age.Text,"")==0)
            {
                MessageBox.Show("请选择年龄!","SeekMe!");
                return;
            }
            else if(JudgePW(ps_1.Text,ps_2.Text)==0)
            {
                return;
            }
            else if(question.Text=="")
            {
                MessageBox.Show("密保问题为空，请填写");
                return;
            }
            else if (answer.Text == "")
            {
                MessageBox.Show("密保答案为空，请填写");
                return;
            }
            else
            {
                int state = 0;
                SqlConnection Reg = new SqlConnection(Friends.connstring);
                String InsertNewComm =string.Format( "INSERT INTO info(id,nickname,pw_sha1,email,question,answer,birthday,age,sex) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",id.Text,nickname.Text,Login.GetSHA1(ps_1.Text),email.Text,question.Text,answer.Text,date.Value.ToShortDateString(),Age.Text,sex);
                SqlCommand RegComm = new SqlCommand(InsertNewComm,Reg);
                try
                {
                    Reg.Open();
                    if(RegComm.ExecuteNonQuery()==1)
                    {
                        string InsertNewFriendList = string.Format("insert into friends(id,num) values('{0}',0)",id.Text);
                        SqlCommand FriComm = new SqlCommand(InsertNewFriendList, Reg);
                        if(FriComm.ExecuteNonQuery()==1)
                            state = 1;
                    }
                    else
                    {
                        state = 0;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "写入注册信息错误");                    
                }
                finally
                {
                    Reg.Close();
                }
                if(state==1)
                {
                    MessageBox.Show("恭喜你，注册成功，请登陆。", "SeekMe!");    

                }
                    
            }

            this.DialogResult = DialogResult.OK;
        }

        private void ID_Check_Click(object sender, EventArgs e)
        {
            String id = this.id.Text;
            if(SearchID(id)==1)
                MessageBox.Show("此用户名可以使用", "SeekMe!");
        }

        private void Sex_M_CheckedChanged(object sender, EventArgs e)
        {
            if (Sex_M.Checked == true) sex = "男";
            else sex = "女";
        }
 
        private void Reg_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void Reg_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
