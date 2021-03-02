namespace USLi_Employee_Database
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtCollege = new System.Windows.Forms.TextBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGymMember = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialSecurityNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gymMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblemployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDataSet = new USLi_Employee_Database.EmployeesDataSet();
            this.tbl_employeesTableAdapter = new USLi_Employee_Database.EmployeesDataSetTableAdapters.tbl_employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.socialSecurityNumberDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.collegeDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.gymMemberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblemployeesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.Location = new System.Drawing.Point(236, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddNew.Location = new System.Drawing.Point(221, 733);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(160, 74);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSave.Location = new System.Drawing.Point(463, 733);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 74);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Location = new System.Drawing.Point(1003, 733);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 74);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(181, 529);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 20);
            this.txtID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(181, 589);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(146, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(431, 590);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(146, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(333, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name:";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(431, 529);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(146, 20);
            this.txtSSN.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(382, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "SSN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(594, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(644, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(877, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Marital Status:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(715, 529);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(146, 20);
            this.txtDOB.TabIndex = 16;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(715, 589);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(146, 20);
            this.txtGender.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(932, 588);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "College:";
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Location = new System.Drawing.Point(1003, 526);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(146, 20);
            this.txtMaritalStatus.TabIndex = 19;
            // 
            // txtCollege
            // 
            this.txtCollege.Location = new System.Drawing.Point(1003, 590);
            this.txtCollege.Name = "txtCollege";
            this.txtCollege.Size = new System.Drawing.Size(146, 20);
            this.txtCollege.TabIndex = 20;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(1271, 525);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(146, 20);
            this.txtHireDate.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1178, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hire Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1166, 588);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Department:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(1271, 586);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(146, 20);
            this.txtDepartment.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(599, 642);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Gym Member:";
            // 
            // txtGymMember
            // 
            this.txtGymMember.Location = new System.Drawing.Point(715, 643);
            this.txtGymMember.Name = "txtGymMember";
            this.txtGymMember.Size = new System.Drawing.Size(146, 20);
            this.txtGymMember.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Location = new System.Drawing.Point(743, 733);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 74);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Location = new System.Drawing.Point(1257, 733);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 74);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(740, 835);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 29;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.Location = new System.Drawing.Point(977, 643);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(197, 50);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(357, 642);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 50);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnInsert.Location = new System.Drawing.Point(12, 733);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(160, 74);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox1.Image = global::USLi_Employee_Database.Properties.Resources.usli_logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 92);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // socialSecurityNumberDataGridViewTextBoxColumn
            // 
            this.socialSecurityNumberDataGridViewTextBoxColumn.DataPropertyName = "Social Security Number";
            this.socialSecurityNumberDataGridViewTextBoxColumn.HeaderText = "Social Security Number";
            this.socialSecurityNumberDataGridViewTextBoxColumn.Name = "socialSecurityNumberDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital Status";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital Status";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            // 
            // collegeDataGridViewTextBoxColumn
            // 
            this.collegeDataGridViewTextBoxColumn.DataPropertyName = "College";
            this.collegeDataGridViewTextBoxColumn.HeaderText = "College";
            this.collegeDataGridViewTextBoxColumn.Name = "collegeDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "Hire Date";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "Hire Date";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // gymMemberDataGridViewTextBoxColumn
            // 
            this.gymMemberDataGridViewTextBoxColumn.DataPropertyName = "Gym Member?";
            this.gymMemberDataGridViewTextBoxColumn.HeaderText = "Gym Member?";
            this.gymMemberDataGridViewTextBoxColumn.Name = "gymMemberDataGridViewTextBoxColumn";
            // 
            // tblemployeesBindingSource
            // 
            this.tblemployeesBindingSource.DataMember = "tbl_employees";
            this.tblemployeesBindingSource.DataSource = this.employeesDataSet;
            // 
            // employeesDataSet
            // 
            this.employeesDataSet.DataSetName = "EmployeesDataSet";
            this.employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_employeesTableAdapter
            // 
            this.tbl_employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1489, 872);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtGymMember);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.txtCollege);
            this.Controls.Add(this.txtMaritalStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "USLi Employee Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeesDataSet employeesDataSet;
        private System.Windows.Forms.BindingSource tblemployeesBindingSource;
        private EmployeesDataSetTableAdapters.tbl_employeesTableAdapter tbl_employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialSecurityNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gymMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtCollege;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGymMember;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
    }
}

