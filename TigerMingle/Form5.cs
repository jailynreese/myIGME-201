using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyscord
{
    public partial class PhraseForm : Form
    {
        public String answer = "";
        public PhraseForm(Form owner)
        {
            InitializeComponent();
            this.Owner = owner;
            this.CenterToParent();


            this.sendButton.Click += new EventHandler(SendButton__Click);
        }

        private void SendButton__Click(object sender, EventArgs e)
        {
            this.answer = this.richTextBox1.Text;
            this.Close();
        }
    }
}
