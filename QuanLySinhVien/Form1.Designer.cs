namespace QuanLySinhVien
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbLop = new TextBox();
            tbDiemTrungBinh = new TextBox();
            tbMaSinhVien = new TextBox();
            tbTenSinhVien = new TextBox();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnTraCuu = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbLop);
            groupBox1.Controls.Add(tbDiemTrungBinh);
            groupBox1.Controls.Add(tbMaSinhVien);
            groupBox1.Controls.Add(tbTenSinhVien);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 199);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 203);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 7;
            label4.Text = "Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 150);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Điểm tb:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 98);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 43);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên sinh viên:";
            // 
            // tbLop
            // 
            tbLop.Location = new Point(119, 196);
            tbLop.Name = "tbLop";
            tbLop.Size = new Size(165, 27);
            tbLop.TabIndex = 3;
            tbLop.TextChanged += tbLop_TextChanged;
            // 
            // tbDiemTrungBinh
            // 
            tbDiemTrungBinh.Location = new Point(119, 143);
            tbDiemTrungBinh.Name = "tbDiemTrungBinh";
            tbDiemTrungBinh.Size = new Size(165, 27);
            tbDiemTrungBinh.TabIndex = 2;
            tbDiemTrungBinh.TextChanged += tbDiemTrungBinh_TextChanged;
            // 
            // tbMaSinhVien
            // 
            tbMaSinhVien.Location = new Point(119, 91);
            tbMaSinhVien.Name = "tbMaSinhVien";
            tbMaSinhVien.Size = new Size(165, 27);
            tbMaSinhVien.TabIndex = 1;
            tbMaSinhVien.TextChanged += tbMaSinhVien_TextChanged;
            // 
            // tbTenSinhVien
            // 
            tbTenSinhVien.Location = new Point(119, 42);
            tbTenSinhVien.Name = "tbTenSinhVien";
            tbTenSinhVien.Size = new Size(165, 27);
            tbTenSinhVien.TabIndex = 0;
            tbTenSinhVien.TextChanged += tbTenSinhVien_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTraCuu);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(12, 323);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(24, 70);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(164, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(308, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(480, 426);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(450, 252);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Location = new Point(164, 70);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(94, 29);
            btnTraCuu.TabIndex = 3;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbTenSinhVien;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbLop;
        private TextBox tbDiemTrungBinh;
        private TextBox tbMaSinhVien;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private Button btnTraCuu;
    }
}
