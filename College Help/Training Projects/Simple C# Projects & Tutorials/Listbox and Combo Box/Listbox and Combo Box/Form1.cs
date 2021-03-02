using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_and_Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                loadListBox();

            }
            if(listBox1.SelectedIndex == 0)
            {
                loadListBoxCheque();
            }
            if(listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Clear();
            }
        }

        private void loadListBox()

        {

            listBox2.Items.Clear();

            listBox2.Items.Add("American Express");
            listBox2.Items.Add("Discover");
            listBox2.Items.Add("Mastercard");
            listBox2.Items.Add("Visa");

        }

        private void loadListBoxCheque()
        {
            listBox2.Items.Clear();

            listBox2.Items.Add("Buisness Cheque");
            listBox2.Items.Add("eCheque");
            listBox2.Items.Add("Personal Cheque");


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
