namespace ass2
{
    partial class fBaoVo
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tImage = new System.Windows.Forms.TextBox();
            this.dtDate_Start = new System.Windows.Forms.DateTimePicker();
            this.lbxSex = new System.Windows.Forms.ListBox();
            this.nbAge = new System.Windows.Forms.NumericUpDown();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.tCO_Salary = new System.Windows.Forms.TextBox();
            this.tCMND = new System.Windows.Forms.TextBox();
            this.tLName = new System.Windows.Forms.TextBox();
            this.tCountry = new System.Windows.Forms.TextBox();
            this.tFName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Merge = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(713, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 37);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(713, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 323);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tImage);
            this.groupBox1.Controls.Add(this.dtDate_Start);
            this.groupBox1.Controls.Add(this.lbxSex);
            this.groupBox1.Controls.Add(this.nbAge);
            this.groupBox1.Controls.Add(this.tAddress);
            this.groupBox1.Controls.Add(this.tCO_Salary);
            this.groupBox1.Controls.Add(this.tCMND);
            this.groupBox1.Controls.Add(this.tLName);
            this.groupBox1.Controls.Add(this.tCountry);
            this.groupBox1.Controls.Add(this.tFName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(27, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 232);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // tImage
            // 
            this.tImage.Location = new System.Drawing.Point(509, 198);
            this.tImage.Name = "tImage";
            this.tImage.Size = new System.Drawing.Size(156, 22);
            this.tImage.TabIndex = 28;
            // 
            // dtDate_Start
            // 
            this.dtDate_Start.Location = new System.Drawing.Point(508, 83);
            this.dtDate_Start.Name = "dtDate_Start";
            this.dtDate_Start.Size = new System.Drawing.Size(199, 22);
            this.dtDate_Start.TabIndex = 27;
            // 
            // lbxSex
            // 
            this.lbxSex.FormattingEnabled = true;
            this.lbxSex.ItemHeight = 16;
            this.lbxSex.Items.AddRange(new object[] {
            "1",
            "0",
            "-1"});
            this.lbxSex.Location = new System.Drawing.Point(110, 198);
            this.lbxSex.Name = "lbxSex";
            this.lbxSex.Size = new System.Drawing.Size(192, 20);
            this.lbxSex.TabIndex = 26;
            this.lbxSex.SelectedIndexChanged += new System.EventHandler(this.lbxSex_SelectedIndexChanged);
            // 
            // nbAge
            // 
            this.nbAge.Location = new System.Drawing.Point(110, 158);
            this.nbAge.Name = "nbAge";
            this.nbAge.Size = new System.Drawing.Size(192, 22);
            this.nbAge.TabIndex = 24;
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(507, 121);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(160, 22);
            this.tAddress.TabIndex = 23;
            // 
            // tCO_Salary
            // 
            this.tCO_Salary.Location = new System.Drawing.Point(508, 162);
            this.tCO_Salary.Name = "tCO_Salary";
            this.tCO_Salary.Size = new System.Drawing.Size(159, 22);
            this.tCO_Salary.TabIndex = 22;
            // 
            // tCMND
            // 
            this.tCMND.Location = new System.Drawing.Point(110, 123);
            this.tCMND.Name = "tCMND";
            this.tCMND.Size = new System.Drawing.Size(191, 22);
            this.tCMND.TabIndex = 20;
            // 
            // tLName
            // 
            this.tLName.Location = new System.Drawing.Point(111, 83);
            this.tLName.Name = "tLName";
            this.tLName.Size = new System.Drawing.Size(190, 22);
            this.tLName.TabIndex = 19;
            // 
            // tCountry
            // 
            this.tCountry.Location = new System.Drawing.Point(508, 38);
            this.tCountry.Name = "tCountry";
            this.tCountry.Size = new System.Drawing.Size(160, 22);
            this.tCountry.TabIndex = 18;
            // 
            // tFName
            // 
            this.tFName.Location = new System.Drawing.Point(111, 38);
            this.tFName.Name = "tFName";
            this.tFName.Size = new System.Drawing.Size(191, 22);
            this.tFName.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Date Start";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "CO_Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "LastName";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(713, 21);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(173, 39);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(107, 12);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(171, 22);
            this.tb_search.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "WorkPoints";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Merge
            // 
            this.Merge.AutoSize = true;
            this.Merge.Location = new System.Drawing.Point(533, 17);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(80, 17);
            this.Merge.TabIndex = 11;
            this.Merge.Text = "Expendture";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = global::ass2.Properties.Resources.back;
            this.button2.Location = new System.Drawing.Point(860, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 40);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ass2.Properties.Resources.icons8_search_24;
            this.btnSearch.Location = new System.Drawing.Point(284, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 32);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // fBaoVo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 622);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fBaoVo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.fBaoVo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDate_Start;
        private System.Windows.Forms.ListBox lbxSex;
        private System.Windows.Forms.NumericUpDown nbAge;
        private System.Windows.Forms.TextBox tAddress;
        private System.Windows.Forms.TextBox tCO_Salary;
        private System.Windows.Forms.TextBox tCMND;
        private System.Windows.Forms.TextBox tLName;
        private System.Windows.Forms.TextBox tCountry;
        private System.Windows.Forms.TextBox tFName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox tImage;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Merge;
        private System.Windows.Forms.Button button2;
    }
}