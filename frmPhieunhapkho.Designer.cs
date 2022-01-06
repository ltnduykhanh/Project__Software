
namespace Management
{
    partial class frmPhieunhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Masanpham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Maphieunhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieunhapkho = new System.Windows.Forms.DataGridView();
            this.btn_In = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhapkho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_In);
            this.panel1.Controls.Add(this.btn_Dong);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 0;
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(695, 22);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(75, 23);
            this.btn_Dong.TabIndex = 5;
            this.btn_Dong.Text = "&Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::Management.Properties.Resources.add_row;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(31, 22);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_ThemClick);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(604, 22);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_LuuClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(285, 22);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::Management.Properties.Resources.delete_obj;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(153, 22);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_soluong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_Masanpham);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Maphieunhap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 192);
            this.panel2.TabIndex = 1;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(191, 116);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(100, 22);
            this.txt_soluong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Masanpham
            // 
            this.txt_Masanpham.Location = new System.Drawing.Point(191, 73);
            this.txt_Masanpham.Name = "txt_Masanpham";
            this.txt_Masanpham.Size = new System.Drawing.Size(279, 22);
            this.txt_Masanpham.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã sản phẩm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Maphieunhap
            // 
            this.txt_Maphieunhap.Location = new System.Drawing.Point(191, 34);
            this.txt_Maphieunhap.Name = "txt_Maphieunhap";
            this.txt_Maphieunhap.Size = new System.Drawing.Size(279, 22);
            this.txt_Maphieunhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(305, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu nhập kho";
            // 
            // dgvPhieunhapkho
            // 
            this.dgvPhieunhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieunhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieunhapkho.Location = new System.Drawing.Point(0, 192);
            this.dgvPhieunhapkho.Name = "dgvPhieunhapkho";
            this.dgvPhieunhapkho.RowHeadersWidth = 51;
            this.dgvPhieunhapkho.RowTemplate.Height = 24;
            this.dgvPhieunhapkho.Size = new System.Drawing.Size(800, 193);
            this.dgvPhieunhapkho.TabIndex = 2;
            this.dgvPhieunhapkho.Click += new System.EventHandler(this.dgvPhieunhapkho_Click);
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(456, 22);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(75, 23);
            this.btn_In.TabIndex = 6;
            this.btn_In.Text = "In";
            this.btn_In.UseVisualStyleBackColor = true;
           
            // 
            // frmPhieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPhieunhapkho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhieunhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu nhập kho";
            this.Load += new System.EventHandler(this.frmDMchatlieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhapkho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieunhapkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Maphieunhap;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Masanpham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_In;
    }
}