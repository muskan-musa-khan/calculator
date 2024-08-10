namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Builds UI (Buttons, Textboxes etc.)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // What you want to do initially when the form loads
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;

            bool isValidNum1 = double.TryParse(textBox1.Text, out num1);
            bool isValidNum2 = double.TryParse(textBox2.Text, out num2);

            if (!isValidNum1 && !isValidNum2)
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            string op = textBox3.Text;

            if (!string.IsNullOrEmpty(op)) {
                switch (op)
                {
                    case "+":
                        label2.Text = (num1 + num2).ToString();
                        break;

                    case "-":
                        label2.Text = (num1 - num2).ToString();
                        break;

                    case "*":
                        label2.Text = (num1 * num2).ToString();
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Division by zero is not allowed!");
                        }
                        else
                        {
                            label2.Text = (num1 / num2).ToString();
                        }
                        break;
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}