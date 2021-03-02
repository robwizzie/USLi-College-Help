using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUp(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

            void AddUp(int firstNumber, int secondNumber)
            {
            int answer;

            answer = firstNumber + secondNumber;

                MessageBox.Show(answer.ToString());

                return;

            }

        private int Subtract(int firstNumber, int secondNumber)
        {
            int answer;

            answer = firstNumber - secondNumber;

            return answer;
        }

        private int Multiply(int firstNumber, int secondNumber)
        {
            int answer;

            answer = firstNumber * secondNumber;

            return answer;
        }

        private int Divide(int firstNumber, int secondNumber)
        {
            int answer;

            answer = firstNumber / secondNumber;

            return answer;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            returnValue = Subtract(number1, number2);

            MessageBox.Show(returnValue.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            returnValue = Multiply(number1, number2);

            MessageBox.Show(returnValue.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            returnValue = Divide(number1, number2);

            MessageBox.Show(returnValue.ToString());
        }
    }
}
