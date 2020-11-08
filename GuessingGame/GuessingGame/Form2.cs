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
    public partial class GameForm : System.Windows.Forms.Form
    {
        Random rand = new Random();
        int nRandom = 0;

        int tries = 0;

        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            nRandom = rand.Next(1, 101);

            this.guessButton.Click += new EventHandler(guessButton__Click);
        }

        private void guessButton__Click(object sender, EventArgs e)
        {
            if(int.TryParse(this.inputTextBox.Text) == "true")
            {
                int guess = Int32.Parse(this.inputTextBox.Text);

                tries++;

                if (guess > nRandom)
                {
                    outputLabel.Text = "Your guess is too high.";
                }
                else if (guess < nRandom)
                {
                    outputLabel.Text = "Your guess is too low.";
                }
            } 
            else
            {
                MessageBox.Show("Invalid Response!");
            }
            

            
        }
    }
}
