using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

           
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);


        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;
        }

        private void HomepageWebBrowser__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;

            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElement = wb.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #a000a0;";

            htmlElementCollection = wb.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My Kitten Page";

            htmlElementCollection = wb.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "Meow!";

            htmlElement = htmlElementCollection[1];
            htmlElement.InnerHtml = "<a href='http://www.kittens.com'>Kitties!</a>";

            htmlElementCollection[2].InnerText = "";

            htmlElement = wb.Document.GetElementById("lastParagraph");

            HtmlElement htmlElement1 = wb.Document.CreateElement("img");
            htmlElement1.SetAttribute("src", "https://en.bcdn.biz/Images/2018/6/12/27565ee3-ffc0-4a4d-af63-ce8731b65f26.jpg");
            htmlElement1.SetAttribute("title", "awwww");

            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, htmlElement1);

            htmlElement1 = wb.Document.CreateElement("footer");

            htmlElement1.InnerHtml = "&copy;2020 <a href='people.rit.edu/dxsigm'>D.Schuh</a>";
            wb.Document.Body.AppendChild(htmlElement1);
        }
    }
}
