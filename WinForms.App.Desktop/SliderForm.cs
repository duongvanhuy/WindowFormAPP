using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.App.Desktop
{
    public partial class SliderForm : Form
    {
        public SliderForm()
        {
            InitializeComponent();
            cmdCheDo.SelectedIndex = 2;
        }

        private void cmdCheDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmdCheDo.SelectedIndex;
            switch (index)
            {
                case 1:
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 2:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
            }
        }

        private void btnXoayTrai_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }

        private void btnXoayPhai_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(fileName);
            }
        }
    }
}
