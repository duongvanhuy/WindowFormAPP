namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        double result = 0;
        double numberFirst = 0;
        int math = 0;
        private void number_onClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var value = button.Text;
            if (count == 0)
            {
               
                if (txtResult.Text == "0")
                {
                    txtResult.Text = value;
                    return;
                }
                value = txtResult.Text + value;
                txtResult.Text = Convert.ToDouble(value).ToString("#,##0");
            }
            else
            {
                txtResult.Text = Convert.ToDouble(value).ToString("#,##0");
                txtMathText.Text = txtMathText.Text + " " + txtResult.Text;

                switch (math)
                {
                    case 1:
                        result = numberFirst / Convert.ToDouble(value);

                        break;
                    case 2:
                        result = numberFirst * Convert.ToDouble(value);

                        break;
                    case 3:
                        result = numberFirst - Convert.ToDouble(value);

                        break;
                    case 4:
                        result = numberFirst + Convert.ToDouble(value);

                        break;
                }
                //result = 
            }
            
        }

        private void clear_onClick(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtMathText.Text = "";
            count = 0;
        }

        private void mathBasic_onClick(object sender, EventArgs e)
        {
            // var numberFirst = Convert.ToDouble(txtResult.Text);
            var numberOne = txtResult.Text;

            var button = (Button)sender;
            var numberMath = button.Tag; // kiểm tra đang chọn phép chia nào

            switch (numberMath)
            {
                case "1":
                    txtMathText.Text = numberOne + " / ";
                    math = 1;
                    numberFirst = Convert.ToDouble(numberOne);
                    break;
                case "2":
                    txtMathText.Text = numberOne + " * ";
                    math = 2;
                    numberFirst = Convert.ToDouble(numberOne);
                    break;
                case "3":
                    txtMathText.Text = numberOne + " - ";
                    math = 3;
                    numberFirst = Convert.ToDouble(numberOne);
                    break;
                case "4":
                    txtMathText.Text = numberOne + " + " ;
                    math = 4;
                    numberFirst = Convert.ToDouble(numberOne);
                    break;
            }
            count ++;
        }

        private void result_onClick(object sender, EventArgs e)
        {
          //  txtResult.Text = result.ToString("#,##0");
            txtResult.Text = result.ToString();
        }
    }
}