namespace WinForms.App.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {

            try
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.Clear();
                
                var _soThuNhat = txtSoThuNhat.Text;
                var _soThuHai = txtSoThuHai.Text;
                // validate
                if (string.IsNullOrEmpty(_soThuNhat))
                {
                    errorProvider.SetError(txtSoThuNhat, "Vui lòng nhập số");
                    return;
                }
                
               
                var _ketQua = double.Parse(_soThuNhat) + double.Parse(_soThuHai);
                lblKetQua.Text = _ketQua.ToString();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất và số thứ hai");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Số vừa nhập quá lớn");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi");

            }
        }

        private void lblTacGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new Author();
            f.ShowDialog();
        }
    }
}