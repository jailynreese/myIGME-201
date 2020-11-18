using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceFromHell
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.linkLabel1.MouseHover += new EventHandler(linkLabel1__MouseHover);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1__MouseHover(object sender, EventArgs e)
        {
            linkLabel1.BackColor = Color.White;
        }
    }
}
