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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            this.blueRadioButton.CheckedChanged += new EventHandler(BlueRadioButton__CheckedChanged);
            this.redRadioButton.CheckedChanged += new EventHandler(RedRadioButton__CheckedChanged);
            this.button1.Click += new EventHandler(Button_Click);

            this.checkBox1.CheckedChanged += new EventHandler(CheckBox__CheckedChanged);

        }

        private void CheckBox__CheckedChanged(object sender, System.EventArgs e)
        {

            this.button1.Visible = true;
        }

        private void BlueRadioButton__CheckedChanged(object sender, System.EventArgs e)
        {
           
               this.BackColor = Color.Blue;
        }

        private void RedRadioButton__CheckedChanged(object sender, System.EventArgs e)
        {

            this.BackColor = Color.Red;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
