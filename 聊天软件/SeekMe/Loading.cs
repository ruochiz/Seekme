using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeekMe
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        public static int temp = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            temp = 1;
            this.Close(); 
        }
    }
}
