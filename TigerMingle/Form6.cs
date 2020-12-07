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
    public partial class HangmanForm : Form
    {
        
        public string answerString;
        public string currentString;
        public int lives;
        public HangmanForm(Form startGameForm, String answerString)
        {
            InitializeComponent();

            this.answerString = answerString.ToLower();
            this.lives = 6;

            //display placement of letters w/ underscores
            String startingString = "";
            for (int i = 0; i < answerString.Length; i++)
            {
                if (answerString[i] == ' ')
                {
                    startingString += " ";
                }
                else
                {
                    startingString += "_";
                }
            }
            this.archiveRichTextBox.Text = startingString;
            currentString = startingString;

            this.aButton.Click += new EventHandler(aButton__Click);
            this.bButton.Click += new EventHandler(bButton__Click);
            this.cButton.Click += new EventHandler(cButton__Click);
            this.dButton.Click += new EventHandler(dButton__Click);
            this.eButton.Click += new EventHandler(eButton__Click);
            this.fButton.Click += new EventHandler(fButton__Click);
            this.gButton.Click += new EventHandler(gButton__Click);
            this.hButton.Click += new EventHandler(hButton__Click);
            this.iButton.Click += new EventHandler(iButton__Click);
            this.jButton.Click += new EventHandler(jButton__Click);
            this.kButton.Click += new EventHandler(kButton__Click);
            this.lButton.Click += new EventHandler(lButton__Click);
            this.mButton.Click += new EventHandler(mButton__Click);
            this.nButton.Click += new EventHandler(nButton__Click);
            this.oButton.Click += new EventHandler(oButton__Click);
            this.pButton.Click += new EventHandler(pButton__Click);
            this.qButton.Click += new EventHandler(qButton__Click);
            this.rButton.Click += new EventHandler(rButton__Click);
            this.sButton.Click += new EventHandler(sButton__Click);
            this.tButton.Click += new EventHandler(tButton__Click);
            this.uButton.Click += new EventHandler(uButton__Click);
            this.vButton.Click += new EventHandler(vButton__Click);
            this.wButton.Click += new EventHandler(wButton__Click);
            this.xButton.Click += new EventHandler(xButton__Click);
            this.yButton.Click += new EventHandler(yButton__Click);
            this.zButton.Click += new EventHandler(zButton__Click);

        }

        private void aButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('a'))
            {
              this.archiveRichTextBox.Text = replaceUnderscore('a', currentString);
              aButton.Enabled = false;
            } 
            else
            {
              loseLife();
              aButton.Enabled = false;
            }
        }

        private void bButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('b'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('b', currentString);
                bButton.Enabled = false;
            }
            else
            {
                loseLife();
                bButton.Enabled = false;
            }
        }

        private void cButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('c'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('c', currentString);
                cButton.Enabled = false;
            }
            else
            {
                loseLife();
                cButton.Enabled = false;
            }

        }

        private void dButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('d'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('d', currentString);
                dButton.Enabled = false;
            }
            else
            {
                loseLife();
                dButton.Enabled = false;
            }
        }

        private void eButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('e'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('e', currentString);
                eButton.Enabled = false;
            }
            else
            {
                loseLife();
                eButton.Enabled = false;
            }
        }

        private void fButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('f'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('f', currentString);
                fButton.Enabled = false;
            }
            else
            {
                loseLife();
                fButton.Enabled = false;
            }
        }

        private void gButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('g'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('g', currentString);
                gButton.Enabled = false;
            }
            else
            {
                loseLife();
                gButton.Enabled = false;
            }
        }

        private void hButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('h'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('h', currentString);
                hButton.Enabled = false;
            }
            else
            {
                loseLife();
                hButton.Enabled = false;
            }
        }

        private void iButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('i'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('i', currentString);
                iButton.Enabled = false;
            }
            else
            {
                loseLife();
                iButton.Enabled = false;
            }
        }

        private void jButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('j'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('j', currentString);
                jButton.Enabled = false;
            }
            else
            {
                loseLife();
                jButton.Enabled = false;
            }
        }

        private void kButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('k'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('k', currentString);
                kButton.Enabled = false;
            }
            else
            {
                loseLife();
                kButton.Enabled = false;
            }
        }

        private void lButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('l'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('l', currentString);
                lButton.Enabled = false;
            }
            else
            {
                loseLife();
                lButton.Enabled = false;
            }
        }

        private void mButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('m'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('m', currentString);
                mButton.Enabled = false;
            }
            else
            {
                loseLife();
                mButton.Enabled = false;
            }
        }

        private void nButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('n'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('n', currentString);
                nButton.Enabled = false;
            }
            else
            {
                loseLife();
                nButton.Enabled = false;
            }
        }

        private void oButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('o'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('o', currentString);
                oButton.Enabled = false;
            }
            else
            {
                loseLife();
                oButton.Enabled = false;
            }
        }

        private void pButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('p'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('p', currentString);
                pButton.Enabled = false;
            }
            else
            {
                loseLife();
                pButton.Enabled = false;
            }
        }

        private void qButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('q'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('q', currentString);
                qButton.Enabled = false;
            }
            else
            {
                loseLife();
                qButton.Enabled = false;
            }
        }

        private void rButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('r'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('r', currentString);
                rButton.Enabled = false;
            }
            else
            {
                loseLife();
                rButton.Enabled = false;
            }
        }

        private void sButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('s'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('s', currentString);
                sButton.Enabled = false;
            }
            else
            {
                loseLife();
                sButton.Enabled = false;
            }
        }

        private void tButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('t'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('t', currentString);
                tButton.Enabled = false;
            }
            else
            {
                loseLife();
                tButton.Enabled = false;
            }
        }

        private void uButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('u'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('u', currentString);
                uButton.Enabled = false;
            }
            else
            {
                loseLife();
                uButton.Enabled = false;
            }
        }

        private void vButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('v'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('v', currentString);
                vButton.Enabled = false;
            }
            else
            {
                loseLife();
                vButton.Enabled = false;
            }
        }

        private void wButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('w'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('w', currentString);
                wButton.Enabled = false;
            }
            else
            {
                loseLife();
                wButton.Enabled = false;
            }
        }

        private void xButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('x'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('x', currentString);
                xButton.Enabled = false;
            }
            else
            {
                loseLife();
                xButton.Enabled = false;
            }
        }

        private void yButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('y'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('y', currentString);
                yButton.Enabled = false;
            }
            else
            {
                loseLife();
                yButton.Enabled = false;
            }
        }

        private void zButton__Click(object sender, EventArgs e)
        {
            if (answerString.Contains('z'))
            {
                this.archiveRichTextBox.Text = replaceUnderscore('z', currentString);
                zButton.Enabled = false;
            }
            else
            {
                loseLife();
                zButton.Enabled = false;
            }
        }

        private string replaceUnderscore(Char letter, String phrase)
        {
            String newPhrase = "";
            for(int i = 0; i < phrase.Length; i++)
            {
                if(phrase[i] == letter)
                {
                    newPhrase += letter;
                } else
                {
                    newPhrase += phrase[i];
                }
            }
            return newPhrase;
        }

        private void loseLife()
        {
            lives--;
            if(lives == 0)
            {
                endGame();
            }

        }

        private void endGame()
        {

        }
    }
}
