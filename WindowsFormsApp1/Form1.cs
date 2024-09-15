using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double Result_Value = 0;
        String Operator_Performed = " ";
        bool PerformedOp = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e) // Numbers and point
        {
            if (textBox_Result.Text == "0" || PerformedOp)
                textBox_Result.Clear();

            PerformedOp = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }
            else
                textBox_Result.Text += button.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Operator_click_Event(object sender, EventArgs e) // Basic operators: +, -, *, /
        {
            Button button = (Button)sender;

            if (Result_Value != 0)
            {
                button16.PerformClick();
                Operator_Performed = button.Text;
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
            else
            {
                Operator_Performed = button.Text;
                Result_Value = Double.Parse(textBox_Result.Text);
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
        }

        private void button5_Click(object sender, EventArgs e) // CLEAR ENTRY BUTTON
        {
            textBox_Result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e) // CLEAR BUTTON
        {
            textBox_Result.Text = "0";
            Result_Value = 0;
            label_Show_Op.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e) // EQUALS BUTTON
        {
            switch (Operator_Performed)
            {
                case "+":
                    textBox_Result.Text = (Result_Value + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (Result_Value - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (Result_Value * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (Result_Value / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;
            }
            Result_Value = Double.Parse(textBox_Result.Text);
            label_Show_Op.Text = " ";
        }

        // Updated scientific function methods
        private void buttonSin_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(textBox_Result.Text);
            Result_Value = Math.Sin(value * (Math.PI / 180)); // Convert degrees to radians
            textBox_Result.Text = Result_Value.ToString();
            label_Show_Op.Text = "sin(" + value + ")";
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(textBox_Result.Text);
            Result_Value = Math.Cos(value * (Math.PI / 180)); // Convert degrees to radians
            textBox_Result.Text = Result_Value.ToString();
            label_Show_Op.Text = "cos(" + value + ")";
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(textBox_Result.Text);
            Result_Value = Math.Tan(value * (Math.PI / 180)); // Convert degrees to radians
            textBox_Result.Text = Result_Value.ToString();
            label_Show_Op.Text = "tan(" + value + ")";
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(textBox_Result.Text);
            Result_Value = Math.Log10(value); // Logarithm base 10
            textBox_Result.Text = Result_Value.ToString();
            label_Show_Op.Text = "log(" + value + ")";
        }
    }
}
