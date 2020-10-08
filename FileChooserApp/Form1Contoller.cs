using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FileChooserApp
{
    class Form1Contoller
    {
        public void OnSubmit(PictureBox pb, String text)
        {
            if (File.Exists(text))
            {
                pb.Image = Image.FromFile(text);
            }
            else
            {
                MessageBox.Show("The file does not exist", "Error");
            }
        }
    }
}
