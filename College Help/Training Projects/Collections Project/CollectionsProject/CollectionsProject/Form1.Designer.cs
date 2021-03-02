namespace CollectionsProject
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnDisplayMen = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDisplayWomen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadDevelopers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(45, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(589, 270);
            this.listBox1.TabIndex = 0;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.Orange;
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAll.Location = new System.Drawing.Point(509, 304);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(125, 62);
            this.btnDisplayAll.TabIndex = 1;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnDisplayMen
            // 
            this.btnDisplayMen.BackColor = System.Drawing.Color.Orange;
            this.btnDisplayMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayMen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayMen.ForeColor = System.Drawing.Color.White;
            this.btnDisplayMen.Location = new System.Drawing.Point(45, 304);
            this.btnDisplayMen.Name = "btnDisplayMen";
            this.btnDisplayMen.Size = new System.Drawing.Size(140, 62);
            this.btnDisplayMen.TabIndex = 2;
            this.btnDisplayMen.Text = "Display Men";
            this.btnDisplayMen.UseVisualStyleBackColor = false;
            this.btnDisplayMen.Click += new System.EventHandler(this.btnDisplayMen_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Orange;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(509, 401);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 62);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDisplayWomen
            // 
            this.btnDisplayWomen.BackColor = System.Drawing.Color.Orange;
            this.btnDisplayWomen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayWomen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayWomen.ForeColor = System.Drawing.Color.White;
            this.btnDisplayWomen.Location = new System.Drawing.Point(34, 401);
            this.btnDisplayWomen.Name = "btnDisplayWomen";
            this.btnDisplayWomen.Size = new System.Drawing.Size(163, 62);
            this.btnDisplayWomen.TabIndex = 4;
            this.btnDisplayWomen.Text = "Display Women";
            this.btnDisplayWomen.UseVisualStyleBackColor = false;
            this.btnDisplayWomen.Click += new System.EventHandler(this.btnDisplayWomen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CollectionsProject.Properties.Resources.usli_logo;
            this.pictureBox1.Location = new System.Drawing.Point(249, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoadDevelopers
            // 
            this.btnLoadDevelopers.BackColor = System.Drawing.Color.Orange;
            this.btnLoadDevelopers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDevelopers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDevelopers.ForeColor = System.Drawing.Color.White;
            this.btnLoadDevelopers.Location = new System.Drawing.Point(235, 353);
            this.btnLoadDevelopers.Name = "btnLoadDevelopers";
            this.btnLoadDevelopers.Size = new System.Drawing.Size(229, 62);
            this.btnLoadDevelopers.TabIndex = 6;
            this.btnLoadDevelopers.Text = "Load Developers";
            this.btnLoadDevelopers.UseVisualStyleBackColor = false;
            this.btnLoadDevelopers.Click += new System.EventHandler(this.btnLoadDevelopers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(699, 565);
            this.Controls.Add(this.btnLoadDevelopers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDisplayWomen);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDisplayMen);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnDisplayMen;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDisplayWomen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoadDevelopers;
    }
}

