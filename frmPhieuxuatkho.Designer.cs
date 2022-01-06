
namespace Management
{
    partial class frmPhieuxuatkho
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
            this.btn_In = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dt_Ngayxuat = new System.Windows.Forms.DateTimePicker();
            this.txt_Giaca = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_Madonhang = new System.Windows.Forms.TextBox();
            this.txt_Manhanvien = new System.Windows.Forms.TextBox();
            this.txt_Maphieuxuat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuxuat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_In);
            this.panel1.Controls.Add(this.btn_Dong);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Tao);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 0;
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(15, 6);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(75, 23);
            this.btn_In.TabIndex = 6;
            this.btn_In.Text = "In";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(673, 6);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(75, 23);
            this.btn_Dong.TabIndex = 4;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(573, 6);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(445, 8);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::Management.Properties.Resources.delete_obj;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(338, 8);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Tao
            // 
            this.btn_Tao.Image = global::Management.Properties.Resources.add_row;
            this.btn_Tao.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Tao.Location = new System.Drawing.Point(224, 8);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(75, 23);
            this.btn_Tao.TabIndex = 0;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = true;
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dt_Ngayxuat);
            this.panel2.Controls.Add(this.txt_Giaca);
            this.panel2.Controls.Add(this.txt_soluong);
            this.panel2.Controls.Add(this.txt_Madonhang);
            this.panel2.Controls.Add(this.txt_Manhanvien);
            this.panel2.Controls.Add(this.txt_Maphieuxuat);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 184);
            this.panel2.TabIndex = 1;
            // 
            // dt_Ngayxuat
            // 
            this.dt_Ngayxuat.Location = new System.Drawing.Point(559, 128);
            this.dt_Ngayxuat.Name = "dt_Ngayxuat";
            this.dt_Ngayxuat.Size = new System.Drawing.Size(161, 22);
            this.dt_Ngayxuat.TabIndex = 12;
            // 
            // txt_Giaca
            // 
            this.txt_Giaca.Location = new System.Drawing.Point(559, 85);
            this.txt_Giaca.Name = "txt_Giaca";
            this.txt_Giaca.Size = new System.Drawing.Size(161, 22);
            this.txt_Giaca.TabIndex = 11;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(559, 47);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(161, 22);
            this.txt_soluong.TabIndex = 10;
            // 
            // txt_Madonhang
            // 
            this.txt_Madonhang.Location = new System.Drawing.Point(127, 128);
            this.txt_Madonhang.Name = "txt_Madonhang";
            this.txt_Madonhang.Size = new System.Drawing.Size(172, 22);
            this.txt_Madonhang.TabIndex = 9;
            // 
            // txt_Manhanvien
            // 
            this.txt_Manhanvien.Location = new System.Drawing.Point(127, 87);
            this.txt_Manhanvien.Name = "txt_Manhanvien";
            this.txt_Manhanvien.Size = new System.Drawing.Size(172, 22);
            this.txt_Manhanvien.TabIndex = 8;
            // 
            // txt_Maphieuxuat
            // 
            this.txt_Maphieuxuat.Location = new System.Drawing.Point(127, 52);
            this.txt_Maphieuxuat.Name = "txt_Maphieuxuat";
            this.txt_Maphieuxuat.Size = new System.Drawing.Size(172, 22);
            this.txt_Maphieuxuat.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gía cả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã đơn hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(315, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu xuất kho";
            // 
            // dgvPhieuxuat
            // 
            this.dgvPhieuxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuxuat.Location = new System.Drawing.Point(0, 184);
            this.dgvPhieuxuat.Name = "dgvPhieuxuat";
            this.dgvPhieuxuat.RowHeadersWidth = 51;
            this.dgvPhieuxuat.RowTemplate.Height = 24;
            this.dgvPhieuxuat.Size = new System.Drawing.Size(800, 223);
            this.dgvPhieuxuat.TabIndex = 2;
            this.dgvPhieuxuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuxuat_CellContentClick);
            // 
            // frmPhieuxuatkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPhieuxuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPhieuxuatkho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu xuất kho";
            this.Load += new System.EventHandler(this.frmPhieuxuatkho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuxuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuxuat;
        private System.Windows.Forms.TextBox txt_Giaca;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_Madonhang;
        private System.Windows.Forms.TextBox txt_Manhanvien;
        private System.Windows.Forms.TextBox txt_Maphieuxuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.DateTimePicker dt_Ngayxuat;
    }
}