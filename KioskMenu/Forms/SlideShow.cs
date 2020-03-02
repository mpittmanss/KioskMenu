using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KioskMenu.Resources;

namespace KioskMenu.Forms
{
    public partial class SlideShow : Form
    {
        private int _imageLocation = 0;
        private List<Bitmap> imgFiles;

        public SlideShow()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void SlideShow_Load(object sender, EventArgs e)
        {
            SlideShowTimer.Enabled = true;
            /* imgFiles = SlideShowResources.ResourceManager
                       .GetResourceSet(CultureInfo.CurrentCulture, true, true)
                       .Cast<DictionaryEntry>()
                       .Where(x => x.Value.GetType() == typeof(Bitmap))
                       .Select(x => new { Name = x.Key.ToString(), Image = x.Value })
                       .ToList();
            */
            imgFiles = new List<Bitmap>();

            ResourceSet rsrcSet = SlideShowResources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);

            foreach (DictionaryEntry entry in rsrcSet)
            {
                imgFiles.Add((Bitmap)entry.Value);
            }
        }

        private void picSlideShow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SlideShowTimer_Tick(object sender, EventArgs e)
        {
            DisplayNextImage();
        }

        private void DisplayNextImage()
        {
            if (_imageLocation == imgFiles.Count - 1)
            {
                _imageLocation = 0;
                picSlideShow.Image = imgFiles[_imageLocation];
            }
            else
            {
                _imageLocation++;
                picSlideShow.Image = imgFiles[_imageLocation];
            }
        }
    }
}
