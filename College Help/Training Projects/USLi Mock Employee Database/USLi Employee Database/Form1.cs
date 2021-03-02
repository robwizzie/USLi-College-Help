using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace USLi_Employee_Database
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        DatabaseConnection objConnect;
        string conString;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int inc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.EmployeesConnectionString;

                objConnect.connection_string = conString;

                objConnect.Sql = Properties.Settings.Default.SQL;

                ds = objConnect.GetConnection;
                MaxRows = ds.Tables[0].Rows.Count;

                NavigateRecords();


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            // TODO: This line of code loads data into the 'employeesDataSet.tbl_employees' table. You can move, or remove it, as needed.
            this.tbl_employeesTableAdapter.Fill(this.employeesDataSet.tbl_employees);

        }

        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];
            txtFirstName.Text = dRow.ItemArray.GetValue(1).ToString();
            txtLastName.Text = dRow.ItemArray.GetValue(2).ToString();
            txtSSN.Text = dRow.ItemArray.GetValue(3).ToString();
            txtDOB.Text = dRow.ItemArray.GetValue(4).ToString();
            txtGender.Text = dRow.ItemArray.GetValue(5).ToString();
            txtMaritalStatus.Text = dRow.ItemArray.GetValue(6).ToString();
            txtCollege.Text = dRow.ItemArray.GetValue(7).ToString();
            txtHireDate.Text = dRow.ItemArray.GetValue(8).ToString();
            txtDepartment.Text = dRow.ItemArray.GetValue(9).ToString();
            txtGymMember.Text = dRow.ItemArray.GetValue(10).ToString();
        }

        private void labelUpdate()
        {
            label12.Text = "Record " + (inc + 1) + "of " + MaxRows;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtDOB.Clear();
            txtDepartment.Clear();
            txtCollege.Clear();
            txtGender.Clear();
            txtGymMember.Clear();
            txtHireDate.Clear();
            txtLastName.Clear();
            txtMaritalStatus.Clear();
            txtSSN.Clear();

            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[1] = txtFirstName.Text;
            row[2] = txtLastName.Text;
            row[3] = txtSSN.Text;
            row[4] = txtDOB.Text;
            row[5] = txtGender.Text;
            row[6] = txtMaritalStatus.Text;
            row[7] = txtCollege.Text;
            row[8] = txtHireDate.Text;
            row[9] = txtDepartment.Text;
            row[10] = txtGymMember.Text;


            ds.Tables[0].Rows.Add(row);

            try
            {
                objConnect.UpdateDatabase(ds);
                MaxRows = MaxRows + 1;
                inc = MaxRows - 1;
                MessageBox.Show("Database Updated");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnAddNew.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigateRecords();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnAddNew.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].Rows[inc];

            row[1] = txtFirstName.Text;
            row[2] = txtLastName.Text;
            row[3] = txtSSN.Text;
            row[4] = txtDOB.Text;
            row[5] = txtGender.Text;
            row[6] = txtMaritalStatus.Text;
            row[7] = txtCollege.Text;
            row[8] = txtHireDate.Text;
            row[9] = txtDepartment.Text;
            row[10] = txtGymMember.Text;

            try
            {
                objConnect.UpdateDatabase(ds);

                MessageBox.Show("Record Updated");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Tables[0].Rows[inc].Delete();
                objConnect.UpdateDatabase(ds);

                MaxRows = ds.Tables[0].Rows.Count;
                inc--;
                NavigateRecords();

                MessageBox.Show("Record Deleted");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(inc != MaxRows - 1)
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No More Rows");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {

                inc--;
                NavigateRecords();

            }
            else
            {

                MessageBox.Show("First Record");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtDOB.Text != "" && txtCollege.Text != "" && txtDepartment.Text != "" && txtGender.Text != "" && txtGymMember.Text != "" && txtHireDate.Text != "" && txtMaritalStatus.Text != "" && txtSSN.Text != "")
            {
                cmd = new SqlCommand("insert into tbl_employees(FirstName,LastName,DOB,College,Department,Gender,GymMember,HireDate,MaritalStatus,SSN) values(@firstname,@lastname,@dob,@college,@department,@gender,@gymmember,@hiredate,@maritalstatus,@ssn)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@firstname",txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dob", txtDOB.Text);
                cmd.Parameters.AddWithValue("@college", txtCollege.Text);
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@gymmember", txtGymMember.Text);
                cmd.Parameters.AddWithValue("@hiredate", txtHireDate.Text);
                cmd.Parameters.AddWithValue("@maritalstatus", txtMaritalStatus.Text);
                cmd.Parameters.AddWithValue("@ssn", txtSSN.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_employees", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDOB.Text = "";
            txtCollege.Text = "";
            txtDepartment.Text = "";
            txtGender.Text = "";
            txtGymMember.Text = "";
            txtHireDate.Text = "";
            txtMaritalStatus.Text = "";
            txtSSN.Text = "";
            ID = 0;
        }

    }
}
