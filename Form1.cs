using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (IsHorizontalScrollbarPresent)
            {
                webBrowser1.Size = new Size(webBrowser1.Document.Body.ScrollRectangle.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
                Form1.ActiveForm.Size = new Size(webBrowser1.Document.Body.ScrollRectangle.Width, webBrowser1.Document.Body.ScrollRectangle.Height);
            }
        }

        public bool IsHorizontalScrollbarPresent
        {
            get
            {
                var widthofScrollableArea = webBrowser1.Document.Body.ScrollRectangle.Width;
                var widthofControl = webBrowser1.Document.Window.Size.Width;

                return widthofScrollableArea > widthofControl;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

   

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
