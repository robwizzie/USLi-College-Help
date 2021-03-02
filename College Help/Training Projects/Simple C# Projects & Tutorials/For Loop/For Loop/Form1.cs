using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int outputValue = 0;
            bool isNumber = false;

            isNumber = int.TryParse(textBox1.Text, out outputValue);

            if (!isNumber)
            { 

                MessageBox.Show("Please type a number into the box.");

            }

            else
            {


            int loopStart;
            int loopEnd;
            int answer = 0;
            int multiplyBy;
            loopStart = int.Parse(textBox1.Text);
            loopEnd = int.Parse(textBox2.Text);
            multiplyBy = int.Parse(textBox3.Text);


            listBox1.Items.Clear();


                for (int i = loopStart; i <= loopEnd; i++)
                {

                    answer = multiplyBy * i;



                    listBox1.Items.Add(i + " times " + multiplyBy + " = " + answer.ToString());

                }

                MessageBox.Show(answer.ToString());

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
