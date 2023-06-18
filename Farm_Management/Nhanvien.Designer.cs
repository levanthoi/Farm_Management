namespace Farm_Management
{
    partial class Nhanvien
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
            this.btnTim = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbVitri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTaoTk = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio0 = new System.Windows.Forms.RadioButton();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTim.Location = new System.Drawing.Point(214, 0);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(92, 38);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnTim);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Location = new System.Drawing.Point(570, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(306, 38);
            this.panel7.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 32);
            this.textBox3.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(200, 441);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 36);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(106, 441);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 36);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 441);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 36);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AllowUserToDeleteRows = false;
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanvien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.ReadOnly = true;
            this.dgvNhanvien.RowHeadersVisible = false;
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.Size = new System.Drawing.Size(768, 380);
            this.dgvNhanvien.TabIndex = 0;
            this.dgvNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.dgvNhanvien);
            this.panel6.Location = new System.Drawing.Point(403, 97);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(768, 380);
            this.panel6.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(140, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(230, 22);
            this.txtSDT.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 35);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức vụ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChucvu);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 35);
            this.panel3.TabIndex = 12;
            // 
            // cbChucvu
            // 
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Items.AddRange(new object[] {
            "Chủ trang trại",
            "Người quản lý",
            "Nhân viên"});
            this.cbChucvu.Location = new System.Drawing.Point(140, 7);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(230, 24);
            this.cbChucvu.TabIndex = 4;
            this.cbChucvu.SelectedIndexChanged += new System.EventHandler(this.cbChucvu_SelectedIndexChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(140, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(230, 22);
            this.txtTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 35);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(140, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(230, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 35);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbVitri);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(12, 216);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 35);
            this.panel5.TabIndex = 11;
            // 
            // cbVitri
            // 
            this.cbVitri.Enabled = false;
            this.cbVitri.FormattingEnabled = true;
            this.cbVitri.Items.AddRange(new object[] {
            "Kho",
            "Chăn nuôi",
            "Kỹ thuật",
            "Bán hàng"});
            this.cbVitri.Location = new System.Drawing.Point(140, 7);
            this.cbVitri.Name = "cbVitri";
            this.cbVitri.Size = new System.Drawing.Size(230, 24);
            this.cbVitri.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vị trí làm";
            // 
            // cbTaoTk
            // 
            this.cbTaoTk.AutoSize = true;
            this.cbTaoTk.Location = new System.Drawing.Point(12, 341);
            this.cbTaoTk.Name = "cbTaoTk";
            this.cbTaoTk.Size = new System.Drawing.Size(111, 20);
            this.cbTaoTk.TabIndex = 0;
            this.cbTaoTk.Text = "Tạo tài khoản";
            this.cbTaoTk.UseVisualStyleBackColor = true;
            this.cbTaoTk.CheckedChanged += new System.EventHandler(this.cbTaoTk_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 36);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtEmail);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(12, 134);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(373, 35);
            this.panel8.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.radio0);
            this.panel9.Controls.Add(this.radio1);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(12, 257);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(373, 35);
            this.panel9.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình trạng";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(138, 10);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(113, 20);
            this.radio1.TabIndex = 1;
            this.radio1.TabStop = true;
            this.radio1.Text = "Đang làm việc";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio0
            // 
            this.radio0.AutoSize = true;
            this.radio0.Location = new System.Drawing.Point(257, 8);
            this.radio0.Name = "radio0";
            this.radio0.Size = new System.Drawing.Size(81, 20);
            this.radio0.TabIndex = 2;
            this.radio0.TabStop = true;
            this.radio0.Text = "Nghỉ làm";
            this.radio0.UseVisualStyleBackColor = true;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 489);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cbTaoTk);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbChucvu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbVitri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbTaoTk;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radio0;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.Label label7;
    }
}