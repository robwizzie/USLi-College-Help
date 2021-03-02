using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Variables_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringVar = textBox1.Text;
            textBox1.Text = stringVar.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringTrim = textBox2.Text;

            stringTrim = stringTrim.Trim();

            int stringLength = stringTrim.Length;

            MessageBox.Show(stringLength.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stringEmail = textBox3.Text;

            int result = stringEmail.IndexOf("@");

            if (result == -1)
            {
                MessageBox.Show("Invalid Email Address");

            }
            else
            {
                MessageBox.Show("@ found at position " + result.ToString());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string someText = "Some Text";

            MessageBox.Show(someText);

            someText = someText.Insert(5, "More ");

            MessageBox.Show(someText);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string paddingLeft = textBox5.Text;

            paddingLeft = paddingLeft.PadLeft(20);

            textBox5.Text = paddingLeft;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string oldString = "some text text text";

            MessageBox.Show(oldString);

            string newString = oldString.Remove(10, 9);

            MessageBox.Show(newString);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string lineOfText = "item1, item2, item3";

            string[] wordArray = lineOfText.Split(',');

            string joinedText;

            joinedText = String.Join("-", wordArray);

            MessageBox.Show(joinedText);

            //MessageBox.Show(wordArray[0]);
            //MessageBox.Show(wordArray[1]);
            //MessageBox.Show(wordArray[2]);
        }
    }
}
