using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.App.Desktop
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();
        }
        double time = 0; // quy ra s
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            if(time == 0)
            {
                timer1.Stop();
            }
            if (time <= 60)
            {
                txtPhut.Text = "00";
                if(time < 10)
                {
                    txtGiay.Text = "0" + time.ToString();
                    txtGiay.ForeColor = Color.Red;
                    txtPhut.ForeColor = Color.Red;
                    txtHaiCham.ForeColor = Color.Red;
                }
                else
                {
                    txtGiay.Text = time.ToString();              
                }
                
            }
            else
            {
                int soPhut = (int)time / 60;
                int soGiay = Convert.ToUInt16( time % 60);
                if (soPhut < 10)
                {
                    txtPhut.Text = "0" + soPhut.ToString();
                }
                else
                {
                    txtPhut.Text = soPhut.ToString();
                }

                if (soGiay < 10)
                {
                    txtGiay.Text = "0" + soGiay.ToString();
                }
                else
                {
                    txtGiay.Text = soGiay.ToString();
                }
            
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Application.StartupPath, "Asset", "ring.wav");
            
            timer1.Stop();
        }

        private void inputBtnPhut_ValueChanged(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SettingForm();
            if(f.ShowDialog() == DialogResult.OK)
            {
                time = f.time;

                double soPhut = Convert.ToDouble(time);
                if (soPhut < 10)
                {
                    txtPhut.Text = "0" + soPhut.ToString();
                }
                else
                {
                    txtPhut.Text = soPhut.ToString();
                }

                if (soPhut >= 100)
                {
                    // show message

                }


                time = soPhut * 60;
            }
            
        }
    }
}
