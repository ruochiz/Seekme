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
    public partial class Search : Form
    {
       
        public Search()
        {
            InitializeComponent();
            
        }


        private void Search_button_Click_1(object sender, EventArgs e)
        {
            bool isExist = false;
            string nickname = nickname_Text.Text;
            string id = id_textbox.Text;
            string CommandString="";
            if(string.Compare(nickname,"")==0&&string.Compare(id,"")==0)
            {
                MessageBox.Show("请输入用户名或者昵称", "内容为空");
            }
            else if(string.Compare(nickname,"")==0)//仅填写id
            {
                CommandString = string.Format("select * from info where id='{0}'", id);
            }
            else if (string.Compare(id, "") == 0)//仅填写nickname
            {
                CommandString = string.Format("select * from info where nickname='{0}'",nickname );
            }
            else//id和nickname都填写了
            {
                CommandString = string.Format("select * from info where id='{0}' and nickname='{1}'", id,nickname);
            }
            SqlConnection sqlconn = new SqlConnection(Friends.connstring);
            SqlCommand sqlcomm = new SqlCommand(CommandString, sqlconn);
            try
            {
                sqlconn.Open();
                SqlDataReader data = sqlcomm.ExecuteReader();
                listView1.Items.Clear();
                while (data.Read())
                {

                    ListViewItem item = new ListViewItem();
                    item.SubItems.Clear();
                    item.SubItems[0].Text = data["id"].ToString();
                    item.SubItems.Add(data["nickname"].ToString());
                    item.SubItems.Add(data["age"].ToString());
                    item.SubItems.Add(data["sex"].ToString());
                    listView1.Items.Add(item);
                    isExist = true;
                }
                data.Close();
                sqlconn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"获取查询信息错误");
            }
            if(isExist==true)
            {
                tabControl.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("没有找到相关数据，重新输入试试", "Sorry");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID_Selected = listView1.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show("获取资料:" + ID_Selected);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID_Selected = listView1.SelectedItems[0].SubItems[0].Text;
            
            //判断是否已经是自己的好友
            bool isfriend =false;
            for(int i=0;i<Friends.FriendsNum;i++)
            {
                if (Friends.FriendInfo[i].id == ID_Selected)
                    isfriend = true;
            }
            if(isfriend==true)
            {
                MessageBox.Show("这已经是您的好友了");
                return;
            }
            SendRequest sr = new SendRequest(ID_Selected);
            sr.ShowDialog();
            if(sr.DialogResult==DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
