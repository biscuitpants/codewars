using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAboutPage : Form
    {
        public frmAboutPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Open the default mail app with an adddress and subject
            System.Diagnostics.Process.Start("mailto:chrismetheridge@gmail.com?subject=Contact%20from%20Code%20Wars");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}