using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZImageViewer
{
    public partial class ZImageViewer : Form
    {
        private Bitmap myImage;
        AboutForm myAboutForm;
        public ZImageViewer()
        {
            myAboutForm = new AboutForm();
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();

            openImage.Filter = "Bitmap Image (.bmp)|*.bmp|All Files (*.*)|*.*";
            openImage.FilterIndex = 1;

            openImage.ShowDialog();

            if (openImage.FileName != "")
            {
                myImage = new Bitmap(openImage.FileName);
                pictureBox.Image = (Image)myImage;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            myAboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // Send the terminate command to all application threads.
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // If the program isn't working properly, this should kill it.
                System.Environment.Exit(1);
            }
        }
    }
}
