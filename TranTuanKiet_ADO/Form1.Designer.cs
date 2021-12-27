
namespace TranTuanKiet_ADO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbsono = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(59, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(714, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ROW);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 165;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 165;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số tiền Nợ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Chi Tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tiền Nợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(171, 283);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(163, 27);
            this.tbid.TabIndex = 6;
            // 
            // tbsono
            // 
            this.tbsono.Location = new System.Drawing.Point(171, 411);
            this.tbsono.Name = "tbsono";
            this.tbsono.Size = new System.Drawing.Size(163, 27);
            this.tbsono.TabIndex = 7;
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(171, 371);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(163, 27);
            this.tbsdt.TabIndex = 8;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(171, 330);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(265, 27);
            this.tbname.TabIndex = 9;
            // 
            // tbnThem
            // 
            this.tbnThem.Location = new System.Drawing.Point(653, 234);
            this.tbnThem.Name = "tbnThem";
            this.tbnThem.Size = new System.Drawing.Size(94, 29);
            this.tbnThem.TabIndex = 10;
            this.tbnThem.Text = "Thêm";
            this.tbnThem.UseVisualStyleBackColor = true;
            this.tbnThem.Click += new System.EventHandler(this.tbnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(653, 371);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(653, 330);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(94, 29);
            this.btnghi.TabIndex = 12;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(653, 283);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(0, 0);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 23);
            this.Sua.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tbnThem);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbsono);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbsono;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button tbnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button Sua;
    }
}

