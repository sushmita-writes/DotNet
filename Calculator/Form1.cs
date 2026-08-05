namespace Calculator
{
    public partial class Form1 : Form
    {
        string inputNumber = "";
        double firstNum = 0;
        double secondNum = 0;
        double result = 0;
        string operation = "";
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            inputBox.Clear();
            inputNumber = "";
            result = 0;
            firstNum = 0;
            secondNum = 0;
            operation = "";
            operationPending = false;
        }

        private void Calculate()
        {
            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        Clear();
                        return;
                    }
                    break;
            }

            // display result in inputBox
            inputBox.Text = result.ToString();

            inputNumber = "";
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;

            if (operationPending) // second number is being entered
            {
                inputNumber += n.Text;
                inputBox.Text += n.Text;
                secondNum = Convert.ToDouble(inputNumber);
            }
            else // first number is being entered
            {
                inputNumber += n.Text;
                inputBox.Text += n.Text;
                firstNum = Convert.ToDouble(inputNumber);
            }
        }

        private void n0_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n1_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n2_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n3_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n4_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n5_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n6_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n7_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n8_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }
        private void n9_Click(object sender, EventArgs e) 
        { 
            Digit_Click(sender, e); 
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;

            // if an operator clicked previously
            // and second number entered
            // calcualte the result of previous operation
            if (operationPending && inputNumber != "")
            {
                Calculate();
                firstNum = result;
            }

            
            operation = op.Text;
            inputNumber = "";
            operationPending = true;
            inputBox.Text += " " + operation + " ";
        }

        private void plus_Click(object sender, EventArgs e) 
        { 
            Operator_Click(sender, e); 
        }
        private void minus_Click(object sender, EventArgs e) 
        { 
            Operator_Click(sender, e); 
        }
        private void multiply_Click(object sender, EventArgs e) 
        { 
            Operator_Click(sender, e); 
        }
        private void divide_Click(object sender, EventArgs e) 
        { 
            Operator_Click(sender, e); 
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void equalsTo_Click(object sender, EventArgs e)
        {
            if (operationPending && inputNumber != "")
            {
                Calculate();
                firstNum = result;
                operationPending = false;
            }
        }
    }
}