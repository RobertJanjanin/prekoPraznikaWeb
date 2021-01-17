using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prekoPraznika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonIspis_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void buttonGmail_Click(object sender, EventArgs e)
        {
            string gmail = "https://www.gmail.com/";
            webBrowser1.Navigate(gmail);
        }

        private void buttonWebmail_Click(object sender, EventArgs e)
        {
            string webmail = "https://webmail.carnet.hr/login.php";
            webBrowser1.Navigate(webmail);
        }

        private void buttonIdi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
