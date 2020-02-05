using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskMenu
{
    public partial class Form1 : Form
    {
        string DirPath;
        int ImgIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                cboSeconds.Items.Add(i);
                cboSeconds.SelectedIndex = 0;
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            DirPath = folderBrowserDialog1.SelectedPath;
            string[] files = Directory.GetFiles(DirPath, "*.jpg");
            foreach (string file in files)
            {
                int pos = file.LastIndexOf("||");
                string FName = file.Substring(pos + 1);
                listBox1.Items.Add(FName);
            }
            listBox1.SelectedIndex = ImgIndex = 0;
            btnPrevious.Enabled = true;
            btnNext.Enabled = btnSlideShow.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainPictureBox.ImageLocation = listBox1.SelectedItem.ToString();
            // pictureBox1.ImageLocation = Dirpath + "\\" + listBox1.SelectedItem;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (ImgIndex > 0)
            {
                ImgIndex -= 1;
                if (ImgIndex == 0)
                {
                    btnPrevious.Enabled = false;
                }
                if (ImgIndex < listBox1.Items.Count - 1)
                    btnNext.Enabled = true;
                listBox1.SelectedIndex = ImgIndex;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (imgindex < listBox1.Items.Count - 1)
            {
                imgindex += 1;
                if (imgindex == listBox1.Items.Count - 1)
                    btnnext.Enabled = false;
                if (imgindex > 0)
                    btnprev.Enabled = true;
                listBox1.SelectedIndex = imgindex;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnnext.PerformClick();
        }
    }
}
