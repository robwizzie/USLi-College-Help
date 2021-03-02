using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsProject
{
    public partial class Form1 : Form
    {
        List<Developer> developerList = new List<Developer>();
        Developer newDeveloper = new Developer("Robert", "Wiscount", "| Ext: 1532", "Male");
        Developer newDeveloper1 = new Developer("Jay", "Frink", "| Ext: 9116", "Male");
        Developer newDeveloper2 = new Developer("Peter", "Johnson", "| Ext: 5309", "Male");
        Developer newDeveloper3 = new Developer("Bridget", "Pizzo", "| Ext: 2849", "Female");

        


        public Form1()
        {
            InitializeComponent();


            
            developerList.Add(newDeveloper);
            developerList.Add(newDeveloper1);
            developerList.Add(newDeveloper2);
            developerList.Add(newDeveloper3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnLoadDevelopers_Click(object sender, EventArgs e)
        {


            listBox1.Items.Clear();

            for (int i = 0; i < developerList.Count; i++)
            {

                listBox1.Items.Add(developerList[i]);

            }


            // Join strings into one CSV line.
            //MessageBox.Show(newDeveloper.ToString());
            //MessageBox.Show(newDeveloper1.ToString());
            listBox1.Items.Clear();
            listBox1.Items.Add(newDeveloper);
            listBox1.Items.Add(newDeveloper1);
            listBox1.Items.Add(newDeveloper2);
            listBox1.Items.Add(newDeveloper3);
                

        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            for (int i = 0; i < developerList.Count; i++)
            {

                listBox1.Items.Add(developerList[i]);

            }

            //listBox1.Items.Clear();
            //listBox1.Items.Add(newDeveloper);
            //listBox1.Items.Add(newDeveloper1);
            //listBox1.Items.Add(newDeveloper2);
            //listBox1.Items.Add(newDeveloper3);
        }

        private void btnDisplayMen_Click(object sender, EventArgs e)
        {
          

            listBox1.Items.Clear();
            
            if (newDeveloper.gender == "Male")
            {
                listBox1.Items.Add(newDeveloper);
            }

            if (newDeveloper1.gender == "Male")
            {
                listBox1.Items.Add(newDeveloper1);
            }

            if (newDeveloper2.gender == "Male")
            {
                listBox1.Items.Add(newDeveloper2);
            }

            if (newDeveloper3.gender == "Male")
            {
                listBox1.Items.Add(newDeveloper3);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btnDisplayWomen_Click(object sender, EventArgs e)
        {
         

            listBox1.Items.Clear();

            if (newDeveloper.gender == "Female")
            {
                listBox1.Items.Add(newDeveloper);
            }

            if (newDeveloper1.gender == "Female")
            {
                listBox1.Items.Add(newDeveloper1);
            }

            if (newDeveloper2.gender == "Female")
            {
                listBox1.Items.Add(newDeveloper2);
            }

            if (newDeveloper3.gender == "Female")
            {
                listBox1.Items.Add(newDeveloper3);
            }

            //for (int i = 0; i < 6; i++)
            //{ if (newDeveloper[i].gender == "Female") { listBox1.Items.Add(newDeveloper[i]) } }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            var FemaleDevelopers = developerList.Where(i => i.gender.Equals(true)).ToList();
            listBox1.Items.Add(FemaleDevelopers);

            //if(developerList.Contains("Male"))
            //{

            //}

            //developerList.;

        }
    }
    }

