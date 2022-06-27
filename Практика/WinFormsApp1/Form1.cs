namespace WinFormsApp1
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void number0_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 0;
        }

        private void number1_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 1; 
        }

        private void number2_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 2;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 3;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 4;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 5;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 6;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 7;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 8;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 9;
        }

        private void nonint_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + ",";
        }
        double first, second;
        int count;
        bool znak = true;


        private void plus_Click(object sender, EventArgs e)
        {
            Operation.Text = "+";
            first = double.Parse(text.Text);
            text.Clear();
            count = 1;
            znak = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Operation.Text = "-";
            first = double.Parse(text.Text);
            text.Clear();
            count = 2;
            znak = true;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Operation.Text = "*";
            first = double.Parse(text.Text);
            text.Clear();
            count = 3;
            znak = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            Operation.Text = "/";
            first = double.Parse(text.Text);
            text.Clear();
            count = 4;
            znak = true;
        }

        private void pow_Click(object sender, EventArgs e)
        {
            Operation.Text = "^";
            first = double.Parse(text.Text);
            text.Clear();
            count = 5;
            znak = true;
        }

        private void cos_Click(object sender, EventArgs e)
        {
            Operation.Text = "";
            first = double.Parse(text.Text);
            text.Clear();
            Operation.Clear();
            second = Math.Cos(first);
            text.Text = second.ToString();
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            text.Text = "";
            Operation.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    Operation.Clear();
                    second = first + double.Parse(text.Text);
                    text.Text = second.ToString();
                    break;
                case 2:
                    Operation.Clear();
                    second = first - double.Parse(text.Text);
                    text.Text = second.ToString();
                    break;
                case 3:
                    Operation.Clear();
                    second = first * double.Parse(text.Text);
                    text.Text = second.ToString();
                    break;
                case 4:
                    Operation.Clear();
                    second = first / double.Parse(text.Text);
                    text.Text = second.ToString();
                    break;
                case 5:
                    Operation.Clear();
                    second = Math.Pow(first, double.Parse(text.Text));
                    text.Text = second.ToString();
                    break;
                default:
                    break;
            }


        }

        private void sin_Click(object sender, EventArgs e)
        {
            Operation.Text = "";
            first = double.Parse(text.Text);
            text.Clear();
            Operation.Clear();
            second = Math.Sin(first);
            text.Text = second.ToString();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            Operation.Text = "";
            first = double.Parse(text.Text);
            text.Clear();
            Operation.Clear();
            second = Math.Tan(first);
            text.Text = second.ToString();
        }

        private void plusormin_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                text.Text = "-" + text.Text;
                znak = false;
            }
            else if (znak == false)
            {
                text.Text = text.Text.Replace("-", "");
                znak = true;
            }
        }

        private void erase_Click(object sender, EventArgs e)
        {
            int lenght = text.Text.Length - 1;
            int i;
            string textik = text.Text;
            text.Clear();
            for (i = 0; i < lenght; i++)
            {
                text.Text = text.Text + textik[i];
            }
        }

       

        }

    }

