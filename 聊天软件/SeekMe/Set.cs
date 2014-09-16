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

namespace SeekMe
{
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
            IP.Text = Friends.IP;
            port.Text = Friends.Port.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Friends.IP = IP.Text;
            Friends.Port = Convert.ToInt32(port.Text);
            Friends.connstring = String.Format( "Data Source={0};Initial Catalog=UsersData;User ID=guo;Password=2014summer",Friends.IP);
            Friends.IP_Address = IPAddress.Parse(Friends.IP);
            Friends.IP_EndPoint.Port = Friends.Port;
            this.Close();
        }

        private void IP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
