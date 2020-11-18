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
            if(e.KeyCode == Keys.E)
            {
                nonNumberEntered = true;
            }

            //if the user typed a, there is a space that replaces it
            if(e.KeyCode == Keys.A)
            {
                nonNumberEntered = true;
            }

            //if then user typed t, there is a * that replaces it
            if (e.KeyCode == Keys.T)
            {
                nonNumberEntered = true;
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
    }
}
