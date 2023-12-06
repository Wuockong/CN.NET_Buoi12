namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonKetThuc = new System.Windows.Forms.Button();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.textBoxMaHoiNghi = new System.Windows.Forms.TextBox();
            this.textBoxTenHoiNghi = new System.Windows.Forms.TextBox();
            this.textBoxSoNguoi = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHoiNghi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoiNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "- THÔNG TIN PHÒNG HỘI NGHỊ -";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hội nghị :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hội nghị :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại phòng hội nghị :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số người tham gia :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ và tên sv: Bùi Quốc Công. mssv: 2001210455.";
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMoi.Location = new System.Drawing.Point(166, 127);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(84, 23);
            this.buttonThemMoi.TabIndex = 6;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = true;
            this.buttonThemMoi.Click += new System.EventHandler(this.buttonThemMoi_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(256, 127);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(110, 23);
            this.buttonLuu.TabIndex = 7;
            this.buttonLuu.Text = "Lưu thêm mới";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(372, 127);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(90, 23);
            this.buttonXoa.TabIndex = 8;
            this.buttonXoa.Text = "Xóa phòng";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonKetThuc
            // 
            this.buttonKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKetThuc.Location = new System.Drawing.Point(804, 127);
            this.buttonKetThuc.Name = "buttonKetThuc";
            this.buttonKetThuc.Size = new System.Drawing.Size(84, 23);
            this.buttonKetThuc.TabIndex = 9;
            this.buttonKetThuc.Text = "Kết thúc";
            this.buttonKetThuc.UseVisualStyleBackColor = true;
            this.buttonKetThuc.Click += new System.EventHandler(this.buttonKetThuc_Click);
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(633, 415);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(254, 23);
            this.buttonLoc.TabIndex = 10;
            this.buttonLoc.Text = "Lọc danh sách theo loại phòng hội nghị";
            this.buttonLoc.UseVisualStyleBackColor = true;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // textBoxMaHoiNghi
            // 
            this.textBoxMaHoiNghi.Location = new System.Drawing.Point(118, 38);
            this.textBoxMaHoiNghi.Name = "textBoxMaHoiNghi";
            this.textBoxMaHoiNghi.Size = new System.Drawing.Size(769, 22);
            this.textBoxMaHoiNghi.TabIndex = 11;
            // 
            // textBoxTenHoiNghi
            // 
            this.textBoxTenHoiNghi.Location = new System.Drawing.Point(118, 66);
            this.textBoxTenHoiNghi.Name = "textBoxTenHoiNghi";
            this.textBoxTenHoiNghi.Size = new System.Drawing.Size(769, 22);
            this.textBoxTenHoiNghi.TabIndex = 12;
            // 
            // textBoxSoNguoi
            // 
            this.textBoxSoNguoi.Location = new System.Drawing.Point(600, 97);
            this.textBoxSoNguoi.Name = "textBoxSoNguoi";
            this.textBoxSoNguoi.Size = new System.Drawing.Size(112, 22);
            this.textBoxSoNguoi.TabIndex = 13;
            // 
            // comboBoxLoaiPhong
            // 
            this.comboBoxLoaiPhong.FormattingEnabled = true;
            this.comboBoxLoaiPhong.Location = new System.Drawing.Point(166, 97);
            this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            this.comboBoxLoaiPhong.Size = new System.Drawing.Size(266, 24);
            this.comboBoxLoaiPhong.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewHoiNghi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 253);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng hội nghị :";
            // 
            // dataGridViewHoiNghi
            // 
            this.dataGridViewHoiNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoiNghi.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewHoiNghi.Name = "dataGridViewHoiNghi";
            this.dataGridViewHoiNghi.RowHeadersWidth = 51;
            this.dataGridViewHoiNghi.RowTemplate.Height = 24;
            this.dataGridViewHoiNghi.Size = new System.Drawing.Size(861, 226);
            this.dataGridViewHoiNghi.TabIndex = 0;
            this.dataGridViewHoiNghi.SelectionChanged += new System.EventHandler(this.dataGridViewHoiNghi_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxLoaiPhong);
            this.Controls.Add(this.textBoxSoNguoi);
            this.Controls.Add(this.textBoxTenHoiNghi);
            this.Controls.Add(this.textBoxMaHoiNghi);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.buttonKetThuc);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonThemMoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Mã hội nghị :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoiNghi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonKetThuc;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.TextBox textBoxMaHoiNghi;
        private System.Windows.Forms.TextBox textBoxTenHoiNghi;
        private System.Windows.Forms.TextBox textBoxSoNguoi;
        private System.Windows.Forms.ComboBox comboBoxLoaiPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewHoiNghi;
    }
}

