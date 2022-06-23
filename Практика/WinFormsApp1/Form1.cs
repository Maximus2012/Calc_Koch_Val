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
            
        }

        private void division_Click(object sender, EventArgs e)
        {
            
        }

        private void pow_Click(object sender, EventArgs e)
        {
            
        }

        private void cos_Click(object sender, EventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            text.Text = "";
            Operation.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            calculate();
            

        }


        private void calculate()
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

                default:
                    break;
            }

        }

    }
}