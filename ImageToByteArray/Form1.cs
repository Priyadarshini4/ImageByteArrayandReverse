using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToByteArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create an image object from file

            Image image = Image.FromFile(@"D:\Test\bird.jpg");
            //Create a memory stream
            var ms = new MemoryStream();
            //Save byte to ms
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //Toget the bytes we type
            var bytes = ms.ToArray();

            //We need to create memory stream from byte array
            var imageMemoryStraem = new MemoryStream(bytes);
            //Now create image from byte stream
            Image imgFromStream = Image.FromStream(imageMemoryStraem);
            pictureBox1.Image = imgFromStream;
        }
    }
}
