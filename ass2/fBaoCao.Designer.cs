namespace ass2
{
    partial class fBaoCao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDiemKH = new System.Windows.Forms.Label();
            this.btAddKH = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbSoluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "off";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbDiemKH);
            this.panel3.Controls.Add(this.btAddKH);
            this.panel3.Controls.Add(this.btThanhToan);
            this.panel3.Controls.Add(this.lbTenKH);
            this.panel3.Controls.Add(this.lbTenNV);
            this.panel3.Location = new System.Drawing.Point(554, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 125);
            this.panel3.TabIndex = 2;
            // 
            // lbDiemKH
            // 
            this.lbDiemKH.Location = new System.Drawing.Point(181, 49);
            this.lbDiemKH.Name = "lbDiemKH";
            this.lbDiemKH.Size = new System.Drawing.Size(46, 17);
            this.lbDiemKH.TabIndex = 3;
            // 
            // btAddKH
            // 
            this.btAddKH.Location = new System.Drawing.Point(13, 80);
            this.btAddKH.Name = "btAddKH";
            this.btAddKH.Size = new System.Drawing.Size(111, 25);
            this.btAddKH.TabIndex = 2;
            this.btAddKH.Text = "Thành viên";
            this.btAddKH.UseVisualStyleBackColor = true;
            this.btAddKH.Click += new System.EventHandler(this.btAddKH_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(130, 80);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(97, 25);
            this.btThanhToan.TabIndex = 2;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            // 
            // lbTenKH
            // 
            this.lbTenKH.Location = new System.Drawing.Point(12, 45);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(168, 23);
            this.lbTenKH.TabIndex = 1;
            // 
            // lbTenNV
            // 
            this.lbTenNV.Location = new System.Drawing.Point(11, 18);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(200, 23);
            this.lbTenNV.TabIndex = 0;
            this.lbTenNV.Text = "Tên NV:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.tbSoluong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbItem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbItem);
            this.panel2.Location = new System.Drawing.Point(554, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 276);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(152, 245);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbSoluong
            // 
            this.tbSoluong.Location = new System.Drawing.Point(66, 217);
            this.tbSoluong.MaxLength = 2;
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.ReadOnly = true;
            this.tbSoluong.Size = new System.Drawing.Size(161, 22);
            this.tbSoluong.TabIndex = 2;
            this.tbSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(66, 189);
            this.tbItem.MaxLength = 4;
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(161, 22);
            this.tbItem.TabIndex = 2;
            this.tbItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbItem.TextChanged += new System.EventHandler(this.tbItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // pbItem
            // 
            this.pbItem.Location = new System.Drawing.Point(3, 3);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(224, 175);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            this.pbItem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvItem);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 409);
            this.panel1.TabIndex = 0;
            // 
            // lvItem
            // 
            this.lvItem.AllowDrop = true;
            this.lvItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItem.GridLines = true;
            this.lvItem.HideSelection = false;
            this.lvItem.Location = new System.Drawing.Point(0, 0);
            this.lvItem.Name = "lvItem";
            this.lvItem.Size = new System.Drawing.Size(540, 409);
            this.lvItem.TabIndex = 0;
            this.lvItem.UseCompatibleStateImageBehavior = false;
            this.lvItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBaoCao";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Button btAddKH;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbSoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbDiemKH;
    }
}