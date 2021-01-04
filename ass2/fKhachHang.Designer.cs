namespace ass2
{
    partial class fKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvKH = new System.Windows.Forms.DataGridView();
            this.tbChon = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.cbbLoai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 102);
            this.panel1.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Enabled = false;
            this.tbSearch.Location = new System.Drawing.Point(216, 58);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(251, 22);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Id",
            "Phone"});
            this.cbbLoai.Location = new System.Drawing.Point(315, 22);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(152, 24);
            this.cbbLoai.TabIndex = 4;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dtgvKH);
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 192);
            this.panel2.TabIndex = 0;
            // 
            // dtgvKH
            // 
            this.dtgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKH.Location = new System.Drawing.Point(0, 0);
            this.dtgvKH.Name = "dtgvKH";
            this.dtgvKH.RowHeadersWidth = 51;
            this.dtgvKH.RowTemplate.Height = 24;
            this.dtgvKH.Size = new System.Drawing.Size(667, 192);
            this.dtgvKH.TabIndex = 0;
            // 
            // tbChon
            // 
            this.tbChon.Location = new System.Drawing.Point(228, 316);
            this.tbChon.Name = "tbChon";
            this.tbChon.Size = new System.Drawing.Size(75, 23);
            this.tbChon.TabIndex = 1;
            this.tbChon.Text = "Chọn";
            this.tbChon.UseVisualStyleBackColor = true;
            this.tbChon.Click += new System.EventHandler(this.tbChon_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(404, 316);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(690, 351);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.tbChon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvKH;
        private System.Windows.Forms.Button tbChon;
        private System.Windows.Forms.Button btThoat;
    }
}