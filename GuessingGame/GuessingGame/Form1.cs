using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton__Click);
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            lowNumber = Int32.Parse(this.lowTextBox.Text);
            highNumber = Int32.Parse(this.highTextBox.Text);

            if(lowNumber < 1 | highNumber > 100)
            {
                MessageBox.Show("The numbers are invalid");
            } else
            {
                GameForm gameForm = new GameForm(lowNumber, highNumber);
                gameForm.ShowDialog();
            }
        }

    }
}
