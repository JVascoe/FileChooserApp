using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileChooserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\sf14\Documents\Fall2020\Paychex OCR",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "(*.jpg)|*.jpg|(*.png)|*.png",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = openFileDialog1.FileName;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            Form1Contoller cont1 = new Form1Contoller();
            cont1.OnSubmit(pictureBox1, fileName.Text);
        }
    }
}
