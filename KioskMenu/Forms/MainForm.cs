using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskMenu.Forms
{
    public partial class MainForm : Form
    {
        const string password = "kioskPassword2017";
        public MainForm()
        {
            InitializeComponent();
        }  

        private void btnPhotoBoothCode_Click(object sender, EventArgs e)
        {

        }

        private void btnPhotoBooth_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\"; // Change photo booth file location
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void btnNavigationCode_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\"; // Change navigation file location
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void btnGameCode_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\"; // Change game file location
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Passwprd: ", "Enter Password");

            if (promptValue == password)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }
    }
}
