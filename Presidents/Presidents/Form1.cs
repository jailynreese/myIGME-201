using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.allRadioButton.Checked = true;

            this.allRadioButton.CheckedChanged += new EventHandler(AllRadioButton___CheckedChanged);
            this.democratRadioButton.CheckedChanged += new EventHandler(DemocratRadioButton__CheckedChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(RepublicanRadioButton__CheckedChanged);
            this.democraticRepublicanRadioButton.CheckedChanged += new EventHandler(DemocraticRepublicanRadioButton__CheckedChanged);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FederalistRadioButton__CheckedChanged);

            this.harrisonRadioButton.CheckedChanged += new EventHandler(HarrisonRadioButton__CheckedChanged);
            this.fdrRadioButton.CheckedChanged += new EventHandler(FdrRadioButton__CheckedChanged);
            this.clintonRadioButton.CheckedChanged += new EventHandler(ClintonRadioButton__CheckedChanged);
            this.buchananRadioButton.CheckedChanged += new EventHandler(BuchananRadioButton__CheckedChanged);
            this.pierceRadioButton.CheckedChanged += new EventHandler(PierceRadioButton__CheckedChanged);
            this.bushRadioButton.CheckedChanged += new EventHandler(BushRadioButton__CheckedChanged);
            this.obamaRadioButton.CheckedChanged += new EventHandler(ObamaRadioButton__CheckedChanged);
            this.kennedyRadioButton.CheckedChanged += new EventHandler(KennedyRadioButton__CheckedChanged);
            this.mckinleyRadioButton.CheckedChanged += new EventHandler(MckinleyRadioButton__CheckedChanged);
            this.reaganRadioButton.CheckedChanged += new EventHandler(ReaganRadioButton__CheckedChanged);
            this.eisenhowerRadioButton.CheckedChanged += new EventHandler(EisenhowerRadioButton__CheckedChanged);
            this.vanburenRadioButton.CheckedChanged += new EventHandler(VanburenRadioButton__CheckedChanged);
            this.washingtonRadioButton.CheckedChanged += new EventHandler(WashingtonRadioButton__CheckedChanged);
            this.adamsRadioButton.CheckedChanged += new EventHandler(AdamsRadioButton__CheckedChanged);
            this.rooseveltRadioButton.CheckedChanged += new EventHandler(RooseveltRadioButton__CheckedChanged);
            this.jeffersonRadioButton.CheckedChanged += new EventHandler(JeffersonRadioButton__CheckedChanged);

            this.pictureBox1.MouseHover += new EventHandler(PictureBox1__MouseHover);
            this.pictureBox1.MouseLeave += new EventHandler(PictureBox1__MouseLeave);

            this.harrisonTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.fdrTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.bushTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.mckinleyTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.vanburanTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.washingtonTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.rooseveltTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            this.jeffersonTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

            this.exitButton.Click += new EventHandler(ExitButton__Clicked);

            this.harrisonTextBox.Validating += new CancelEventHandler(HarrisonTextBox_Validated);
            this.fdrTextBox.Validating += new CancelEventHandler(FdrTextBox_Validated);
            this.clintonTextBox.Validating += new CancelEventHandler(ClintonTextBox_Validated);
            this.buchananTextBox.Validating += new CancelEventHandler(BuchananTextBox_Validated);
            this.pierceTextBox.Validating += new CancelEventHandler(PierceTextBox_Validated);
            this.bushTextBox.Validating += new CancelEventHandler(BushTextBox_Validated);
            this.obamaTextBox.Validating += new CancelEventHandler(ObamaTextBox_Validated);
            this.kennedyTextBox.Validating += new CancelEventHandler(KennedyTextBox_Validated);
            this.mckinleyTextBox.Validating += new CancelEventHandler(MckinleyTextBox_Validated);
            this.reaganTextBox.Validating += new CancelEventHandler(ReaganTextBox_Validated);
            this.eisenhowerTextBox.Validating += new CancelEventHandler(EisenhowerTextBox_Validated);
            this.vanburanTextBox.Validating += new CancelEventHandler(VanburenTextBox_Validated);
            this.washingtonTextBox.Validating += new CancelEventHandler(WashingtonTextBox_Validated);
            this.adamsTextBox.Validating += new CancelEventHandler(AdamsTextBox_Validated);
            this.rooseveltTextBox.Validating += new CancelEventHandler(RooseveltTextBox_Validated);
            this.jeffersonTextBox.Validating += new CancelEventHandler(JeffersonTextBox_Validated);

            timer1.Tick += new EventHandler(Timer__Tick);

            this.timer1.Interval = 1000;

            this.toolStripProgressBar1.Value = 100;

            this.harrisonTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.fdrTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.clintonTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.buchananTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.pierceTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.bushTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.obamaTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.kennedyTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.mckinleyTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.reaganTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.eisenhowerTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.vanburanTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.washingtonTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.adamsTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.rooseveltTextBox.MouseHover += new EventHandler(TxtBox__Hover);
            this.jeffersonTextBox.MouseHover += new EventHandler(TxtBox__Hover);

        }

        private void TxtBox__Hover(object sender, EventArgs e)
        {
            toolTip1.Show("what # president?", this);
        }

        private void AllRadioButton___CheckedChanged(object sender, EventArgs e)
        {

            this.harrisonRadioButton.Visible = true;
            this.fdrRadioButton.Visible = true;
            this.clintonRadioButton.Visible = true;
            this.buchananRadioButton.Visible = true;
            this.pierceRadioButton.Visible = true;
            this.bushRadioButton.Visible = true;
            this.obamaRadioButton.Visible = true;
            this.kennedyRadioButton.Visible = true;
            this.mckinleyRadioButton.Visible = true;
            this.reaganRadioButton.Visible = true;
            this.eisenhowerRadioButton.Visible = true;
            this.vanburenRadioButton.Visible = true;
            this.washingtonRadioButton.Visible = true;
            this.adamsRadioButton.Visible = true;
            this.rooseveltRadioButton.Visible = true;
            this.jeffersonRadioButton.Visible = true;
        }

        private void DemocratRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            this.harrisonRadioButton.Visible = false;
            this.fdrRadioButton.Visible = true;
            this.clintonRadioButton.Visible = true;
            this.buchananRadioButton.Visible = true;
            this.pierceRadioButton.Visible = true;
            this.bushRadioButton.Visible = false;
            this.obamaRadioButton.Visible = true;
            this.kennedyRadioButton.Visible = true;
            this.mckinleyRadioButton.Visible = false;
            this.reaganRadioButton.Visible = false;
            this.eisenhowerRadioButton.Visible = false;
            this.vanburenRadioButton.Visible = true;
            this.washingtonRadioButton.Visible = false;
            this.adamsRadioButton.Visible = false;
            this.rooseveltRadioButton.Visible = false;
            this.jeffersonRadioButton.Visible = false;
        }

        private void RepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            this.harrisonRadioButton.Visible = true;
            this.fdrRadioButton.Visible = false;
            this.clintonRadioButton.Visible = false;
            this.buchananRadioButton.Visible = false;
            this.pierceRadioButton.Visible = false;
            this.bushRadioButton.Visible = true;
            this.obamaRadioButton.Visible = false;
            this.kennedyRadioButton.Visible = false;
            this.mckinleyRadioButton.Visible = true;
            this.reaganRadioButton.Visible = true;
            this.eisenhowerRadioButton.Visible = true;
            this.vanburenRadioButton.Visible = false;
            this.washingtonRadioButton.Visible = false;
            this.adamsRadioButton.Visible = false;
            this.rooseveltRadioButton.Visible = true;
            this.jeffersonRadioButton.Visible = false;
        }

        private void DemocraticRepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            this.harrisonRadioButton.Visible = false;
            this.fdrRadioButton.Visible = false;
            this.clintonRadioButton.Visible = false;
            this.buchananRadioButton.Visible = false;
            this.pierceRadioButton.Visible = false;
            this.bushRadioButton.Visible = false;
            this.obamaRadioButton.Visible = false;
            this.kennedyRadioButton.Visible = false;
            this.mckinleyRadioButton.Visible = false;
            this.reaganRadioButton.Visible = false;
            this.eisenhowerRadioButton.Visible = false;
            this.vanburenRadioButton.Visible = false;
            this.washingtonRadioButton.Visible = false;
            this.adamsRadioButton.Visible = false;
            this.rooseveltRadioButton.Visible = false;
            this.jeffersonRadioButton.Visible = true;
        }

        private void FederalistRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            this.harrisonRadioButton.Visible = false;
            this.fdrRadioButton.Visible = false;
            this.clintonRadioButton.Visible = false;
            this.buchananRadioButton.Visible = false;
            this.pierceRadioButton.Visible = false;
            this.bushRadioButton.Visible = false;
            this.obamaRadioButton.Visible = false;
            this.kennedyRadioButton.Visible = false;
            this.mckinleyRadioButton.Visible = false;
            this.reaganRadioButton.Visible = false;
            this.eisenhowerRadioButton.Visible = false;
            this.vanburenRadioButton.Visible = false;
            this.washingtonRadioButton.Visible = true;
            this.adamsRadioButton.Visible = true;
            this.rooseveltRadioButton.Visible = false;
            this.jeffersonRadioButton.Visible = false;
        }

        private void PictureBox1__MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(300, 350);
        }

        private void PictureBox1__MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(154, 206);
        }


        private void HarrisonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (harrisonRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Benjamin_Harrison");
                pictureBox1.Load("https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void FdrRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (fdrRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Franklin_D._Roosevelt");
                pictureBox1.Load("https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ClintonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (clintonRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Bill_Clinton");
                pictureBox1.Load("https://people.rit.edu/dxsigm/WilliamJClinton.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BuchananRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (buchananRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/James_Buchanan");
                pictureBox1.Load("https://people.rit.edu/dxsigm/JamesBuchanan.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PierceRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (pierceRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Franklin_Pierce");
                pictureBox1.Load("https://people.rit.edu/dxsigm/FranklinPierce.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BushRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (bushRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/George_W._Bush");
                pictureBox1.Load("https://people.rit.edu/dxsigm/GeorgeWBush.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ObamaRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (obamaRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Barack_Obama");
                pictureBox1.Load("https://people.rit.edu/dxsigm/BarackObama.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void KennedyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (kennedyRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/John_F._Kennedy");
                pictureBox1.Load("https://people.rit.edu/dxsigm/JohnFKennedy.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void MckinleyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (mckinleyRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/William_McKinley");
                pictureBox1.Load("https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ReaganRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (reaganRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Ronald_Reagan");
                pictureBox1.Load("https://people.rit.edu/dxsigm/RonaldReagan.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void EisenhowerRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (eisenhowerRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Dwight_D._Eisenhower");
                pictureBox1.Load("https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void VanburenRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (vanburenRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Martin_Van_Buren");
                pictureBox1.Load("https://people.rit.edu/dxsigm/MartinVanBuren.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void WashingtonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (washingtonRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/George_Washington");
                pictureBox1.Load("https://people.rit.edu/dxsigm/GeorgeWashington.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void AdamsRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (adamsRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/John_Adams");
                pictureBox1.Load("https://people.rit.edu/dxsigm/JohnAdams.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void RooseveltRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (rooseveltRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Theodore_Roosevelt");
                pictureBox1.Load("https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void JeffersonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (jeffersonRadioButton.Checked)
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/Thomas_Jefferson");
                pictureBox1.Load("https://people.rit.edu/dxsigm/ThomasJefferson.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            timer1.Start();
        }

        private void ExitButton__Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HarrisonTextBox_Validated(object sender, CancelEventArgs e)
        {
            if(harrisonTextBox.Text != "23" & harrisonTextBox.Text != "0")
            {
                errorProvider1.SetError(harrisonTextBox, " ");
                e.Cancel = true;
            }
        }

        private void FdrTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (fdrTextBox.Text != "32" & fdrTextBox.Text != "0")
            {
                errorProvider1.SetError(fdrTextBox, " ");
                e.Cancel = true;
            }
        }

        private void ClintonTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (clintonTextBox.Text != "42" & clintonTextBox.Text != "0")
            {
                errorProvider1.SetError(clintonTextBox, " ");
                e.Cancel = true;
            }
        }

        private void BuchananTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (buchananTextBox.Text != "15" & buchananTextBox.Text != "0")
            {
                errorProvider1.SetError(buchananTextBox, " ");
                e.Cancel = true;
            }
        }

        private void PierceTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (pierceTextBox.Text != "14" & pierceTextBox.Text != "0")
            {
                errorProvider1.SetError(pierceTextBox, " ");
                e.Cancel = true;
            }
        }

        private void BushTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (bushTextBox.Text != "43" & bushTextBox.Text != "0")
            {
                errorProvider1.SetError(bushTextBox, " ");
                e.Cancel = true;
            }
        }

        private void ObamaTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (obamaTextBox.Text != "44" & obamaTextBox.Text != "0")
            {
                errorProvider1.SetError(obamaTextBox, " ");
                e.Cancel = true;
            }
        }

        private void KennedyTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (kennedyTextBox.Text != "35" & kennedyTextBox.Text != "0")
            {
                errorProvider1.SetError(kennedyTextBox, " ");
                e.Cancel = true;
            }
        }

        private void MckinleyTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (mckinleyTextBox.Text != "25" & mckinleyTextBox.Text != "0")
            {
                errorProvider1.SetError(mckinleyTextBox, " ");
                e.Cancel = true;
            }
        }

        private void ReaganTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (reaganTextBox.Text != "40" & reaganTextBox.Text != "0")
            {
                errorProvider1.SetError(reaganTextBox, " ");
                e.Cancel = true;
            }
        }

        private void EisenhowerTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (eisenhowerTextBox.Text != "34" & eisenhowerTextBox.Text != "0")
            {
                errorProvider1.SetError(eisenhowerTextBox, " ");
                e.Cancel = true;
            }
        }

        private void VanburenTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (vanburanTextBox.Text != "8" & vanburanTextBox.Text != "0")
            {
                errorProvider1.SetError(vanburanTextBox, " ");
                e.Cancel = true;
            }
        }

        private void WashingtonTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (washingtonTextBox.Text != "1" & washingtonTextBox.Text != "0")
            {
                errorProvider1.SetError(washingtonTextBox, " ");
                e.Cancel = true;
            }
        }

        private void AdamsTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (adamsTextBox.Text != "2" & adamsTextBox.Text != "0")
            {
                errorProvider1.SetError(adamsTextBox, " ");
                e.Cancel = true;
            }
        }

        private void RooseveltTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (rooseveltTextBox.Text != "26" & rooseveltTextBox.Text != "0")
            {
                errorProvider1.SetError(rooseveltTextBox, " ");
                e.Cancel = true;
            }
        }

        private void JeffersonTextBox_Validated(object sender, CancelEventArgs e)
        {
            if (jeffersonTextBox.Text != "26" & jeffersonTextBox.Text != "0")
            {
                errorProvider1.SetError(jeffersonTextBox, " ");
                e.Cancel = true;
            } 
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
   

            if (this.toolStripProgressBar1.Value == 0)
            {
                timer1.Stop();

                this.harrisonTextBox.Text = "0";
                this.fdrTextBox.Text = "0";
                this.clintonTextBox.Text = "0";
                this.buchananTextBox.Text = "0";
                this.pierceTextBox.Text = "0";
                this.bushTextBox.Text = "0";
                this.obamaTextBox.Text = "0";
                this.kennedyTextBox.Text = "0";
                this.mckinleyTextBox.Text = "0";
                this.reaganTextBox.Text = "0";
                this.eisenhowerTextBox.Text = "0";
                this.vanburanTextBox.Text = "0";
                this.washingtonTextBox.Text = "0";
                this.adamsTextBox.Text = "0";
                this.rooseveltTextBox.Text = "0";
                this.jeffersonTextBox.Text = "0";

                this.toolStripProgressBar1.Value = 100;

                timer1.Start();
            } else
            {
                --this.toolStripProgressBar1.Value;
            }

        }
    }
}
