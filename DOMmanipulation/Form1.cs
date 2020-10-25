using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOMmanipulation
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



            this.webBrowser1.Navigate("Z:\\IGMProfile\\Documents\\repos\\DOMmanipulation\\temp\\example.html");
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);


        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #A44;";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Page";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Info";

            htmlElement = htmlElementCollection[1];
            htmlElement.InnerHtml = "My UFO Pictures";

            htmlElementCollection[2].InnerText = "";

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerHtml = "Report your UFO sightings here: <a href='http://www.nuforc.org'>http://www.nuforc.org</a>";
            htmlElement.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44;";

            htmlElementCollection[1].InnerText = "";

            htmlElement = webBrowser.Document.GetElementById("lastParagraph");

            HtmlElement htmlElement1 = webBrowser.Document.CreateElement("img");
            htmlElement1.SetAttribute("src", "https://images.axios.com/40yKmjksUxd94lm5FsUDW9g_Plk=/0x0:6850x3853/1920x1080/2019/04/25/1556227241167.jpg");
            htmlElement1.Style += "width: 40%;";

            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, htmlElement1);

            htmlElement1 = webBrowser.Document.CreateElement("footer");

            htmlElement1.InnerHtml = "&copy;2020 Jailyn Talavera";
            webBrowser.Document.Body.AppendChild(htmlElement1);
        }
    }
    
} 
