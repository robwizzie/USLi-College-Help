using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GroceryStore
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["GroceryStore.Properties.Settings.InventoryConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateInventory();

        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void PopulateInventory()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inventory", connection))
            {

                DataTable inventoryTable = new DataTable();
                adapter.Fill(inventoryTable);

                listInventory.DisplayMember = "Name";
                listInventory.ValueMember = "Id";
                listInventory.DataSource = inventoryTable;

            }
        }

        private void listInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inventory", connection))
            {

                DataTable inventoryTable = new DataTable();
                adapter.Fill(inventoryTable);

                if (listInventory.SelectedIndex == 1)
                {
                    listPrice.DisplayMember = "Price";
                    listInventory.ValueMember = "Id";
                    listPrice.DataSource = inventoryTable;

                }
            }
        }

        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            //string Name = ((InventoryDataSet)e.ListItem).Name;
            //string Price = ((InventoryDataSet)e.ListItem).Price;
            //e.Value = Name + " | Price: " + Price;
        }

        private void listQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}