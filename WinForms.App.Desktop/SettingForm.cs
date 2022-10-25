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
    public partial class SettingForm : Form
    {
        public int time
        {
            get; private set;
        }
        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            time = (int)inputBtnPhut.Value;
            DialogResult = DialogResult.OK;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
