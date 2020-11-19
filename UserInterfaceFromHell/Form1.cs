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
    public partial class firstForm : Form
    {
        private bool nonNumberEntered = false;
        public firstForm()
        {
            InitializeComponent();

            this.nameTextBox.KeyPress += new KeyPressEventHandler(NameTextBox__KeyPress);
            this.nameTextBox.KeyDown += new KeyEventHandler(NameTextBox__KeyDown);
            this.submitButton.Click += new EventHandler(SubmitButton__Click);

        }

        private void NameTextBox__KeyDown(object sender, KeyEventArgs e)
        {
            //if the user typed e, z replaces it
            if(e.KeyCode == Keys.E | e.KeyCode == Keys.T)
            {
                nonNumberEntered = true;

            } else
            {
                nonNumberEntered = false;
            }

            if(e.KeyCode == Keys.I | e.KeyCode == Keys.A)
            {
                Random rand = new Random();
                submitButton.Location = new Point(rand.Next(507), rand.Next(101));
            }
        }

        private void NameTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if(nonNumberEntered)
            {
                e.Handled = true;
            } 


        }

        private void SubmitButton__Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
