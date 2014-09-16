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
    public partial class PasswordSetQ : Form
    {
        private Point offset;
        string answerRight = "";
        

        public PasswordSetQ()
        {
            InitializeComponent();
        }

        private void GetQuestion_Click(object sender, EventArgs e)
        {
            string CommandString = string.Format("select * from info where id='{0}'",id_textbox.Text);
            SqlConnection sqlconn = new SqlConnection(Friends.connstring);
            SqlCommand sqlcomm = new SqlCommand(CommandString, sqlconn);
            
            try
            {
                sqlconn.Open();
                SqlDataReader sqldata = sqlcomm.ExecuteReader();
                if (sqldata.Read())
                {
                    PassQue_label.Text = sqldata["question"].ToString();
                    answerRight = sqldata["answer"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("找不到此用户", "请重新输入");
                }
                sqldata.Close();
                sqlconn.Close();
            }
            catch(Exception str)
            {
                MessageBox.Show(str.Message, "错误");
            }
        }

        private void PasswordSetQ_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void PasswordSetQ_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            string question = PassQue_label.Text;
            string answer = PassAns_textbox.Text;
            if (string.Compare(question, "") == 0 || string.Compare(question, "") == 0)
            {
                MessageBox.Show("问题和答案不能为空", "Sorry");
            }
            else if (string.Compare(answerRight, answer) == 0)
            {
                PasswordSet2 pwset = new PasswordSet2(id_textbox.Text);
                if (pwset.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("您可能填写错啦", "Sorry");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
