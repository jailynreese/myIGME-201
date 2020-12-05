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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            HintForm hintForm = new HintForm(this);
            hintForm.ShowDialog();
            this.archiveRichTextBox.Text += hintForm.hint;
        }
    }
}
