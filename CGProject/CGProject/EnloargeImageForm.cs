using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace CGProject
{
    public partial class EnloargeImageForm : Form
    {
        private byte[] image;

        public EnloargeImageForm(byte[] image)
        {
            InitializeComponent();
            this.image = image;
            MemoryStream stream = new MemoryStream(image);
            imagePictureBox.Image = System.Drawing.Bitmap.FromStream(stream);
            imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
