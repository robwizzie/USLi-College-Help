using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int age;

            age = int.Parse(textBox1.Text);

            if (age < 17)

            {

                MessageBox.Show("Wow, you're a youngster!!");

            }

            if (age >= 17 & age <= 25)

            {

                MessageBox.Show("You're in your prime, have fun!!");

            }

            if (age >= 26 & age <= 40)

            {

                MessageBox.Show("I guess you still have time");

            }

            if (age > 40)

            {

                MessageBox.Show("Oh dear, you've probably missed it");

            }

        }
    }
}
