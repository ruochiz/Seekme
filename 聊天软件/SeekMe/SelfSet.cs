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
    public partial class SelfSet : Form
    {
        public SelfSet()
        {
            InitializeComponent();
        }

        private void NameSet_textbox_TextChanged(object sender, EventArgs e)
        {
          /*  SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.FromArgb(50, 40, 60, 82);*/
        }

        private void StarSet_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelfSet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
