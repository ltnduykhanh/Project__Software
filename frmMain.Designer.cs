
namespace Management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoát = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatlieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tốtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trungBìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cocaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pepsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.đạiLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiMuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieunhapkho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuxuatkho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhmuc,
            this.mnuPhieunhapkho,
            this.mnuPhieuxuatkho,
            this.mnuThongke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoát});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(69, 24);
            this.mnuFile.Text = "&Tệp tin";
            // 
            // mnuThoát
            // 
            this.mnuThoát.Name = "mnuThoát";
            this.mnuThoát.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoát.Size = new System.Drawing.Size(224, 26);
            this.mnuThoát.Text = "Thoát";
            this.mnuThoát.Click += new System.EventHandler(this.mnuThoát_Click);
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChatlieu,
            this.mnuHanghoa,
            this.toolStripMenuItem1,
            this.mnuKhachHang});
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhmuc.Text = "&Danh mục";
            // 
            // mnuChatlieu
            // 
            this.mnuChatlieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tốtToolStripMenuItem,
            this.trungBìnhToolStripMenuItem});
            this.mnuChatlieu.Image = global::Management.Properties.Resources.save;
            this.mnuChatlieu.Name = "mnuChatlieu";
            this.mnuChatlieu.Size = new System.Drawing.Size(224, 26);
            this.mnuChatlieu.Text = "&Chất liệu";
            // 
            // tốtToolStripMenuItem
            // 
            this.tốtToolStripMenuItem.Image = global::Management.Properties.Resources.b_save;
            this.tốtToolStripMenuItem.Name = "tốtToolStripMenuItem";
            this.tốtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tốtToolStripMenuItem.Text = "Tốt";
            // 
            // trungBìnhToolStripMenuItem
            // 
            this.trungBìnhToolStripMenuItem.Image = global::Management.Properties.Resources.b_save;
            this.trungBìnhToolStripMenuItem.Name = "trungBìnhToolStripMenuItem";
            this.trungBìnhToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trungBìnhToolStripMenuItem.Text = "Trung bình";
            // 
            // mnuHanghoa
            // 
            this.mnuHanghoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cocaToolStripMenuItem,
            this.pepsiToolStripMenuItem,
            this.stingToolStripMenuItem});
            this.mnuHanghoa.Image = global::Management.Properties.Resources.save;
            this.mnuHanghoa.Name = "mnuHanghoa";
            this.mnuHanghoa.Size = new System.Drawing.Size(224, 26);
            this.mnuHanghoa.Text = "&Hàng hóa";
            // 
            // cocaToolStripMenuItem
            // 
            this.cocaToolStripMenuItem.Image = global::Management.Properties.Resources.b_save;
            this.cocaToolStripMenuItem.Name = "cocaToolStripMenuItem";
            this.cocaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cocaToolStripMenuItem.Text = "Coca";
            // 
            // pepsiToolStripMenuItem
            // 
            this.pepsiToolStripMenuItem.Image = global::Management.Properties.Resources.b_save;
            this.pepsiToolStripMenuItem.Name = "pepsiToolStripMenuItem";
            this.pepsiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pepsiToolStripMenuItem.Text = "Pepsi";
            // 
            // stingToolStripMenuItem
            // 
            this.stingToolStripMenuItem.Image = global::Management.Properties.Resources.b_save;
            this.stingToolStripMenuItem.Name = "stingToolStripMenuItem";
            this.stingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stingToolStripMenuItem.Text = "Sting";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đạiLíToolStripMenuItem,
            this.ngườiMuaToolStripMenuItem});
            this.mnuKhachHang.Image = global::Management.Properties.Resources.save;
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(224, 26);
            this.mnuKhachHang.Text = "&Khách hàng";
            // 
            // đạiLíToolStripMenuItem
            // 
            this.đạiLíToolStripMenuItem.Image = global::Management.Properties.Resources.b_save;
            this.đạiLíToolStripMenuItem.Name = "đạiLíToolStripMenuItem";
            this.đạiLíToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đạiLíToolStripMenuItem.Text = "Đại lí";
            // 
            // ngườiMuaToolStripMenuItem
            // 
            this.ngườiMuaToolStripMenuItem.Image = global::Management.Properties.Resources.b_save;
            this.ngườiMuaToolStripMenuItem.Name = "ngườiMuaToolStripMenuItem";
            this.ngườiMuaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ngườiMuaToolStripMenuItem.Text = "Người mua";
            // 
            // mnuPhieunhapkho
            // 
            this.mnuPhieunhapkho.Name = "mnuPhieunhapkho";
            this.mnuPhieunhapkho.Size = new System.Drawing.Size(124, 24);
            this.mnuPhieunhapkho.Text = "&Phiếu nhập kho";
            this.mnuPhieunhapkho.Click += new System.EventHandler(this.mnuPhieunhapkho_Click);
            // 
            // mnuPhieuxuatkho
            // 
            this.mnuPhieuxuatkho.Name = "mnuPhieuxuatkho";
            this.mnuPhieuxuatkho.Size = new System.Drawing.Size(119, 24);
            this.mnuPhieuxuatkho.Text = "&Phiếu xuất kho";
            this.mnuPhieuxuatkho.Click += new System.EventHandler(this.mnuPhieuxuatkho_Click);
            // 
            // mnuThongke
            // 
            this.mnuThongke.Name = "mnuThongke";
            this.mnuThongke.Size = new System.Drawing.Size(84, 24);
            this.mnuThongke.Text = "&Thống kê";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Phần mềm bán hàng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoát;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuChatlieu;
        private System.Windows.Forms.ToolStripMenuItem tốtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trungBìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem đạiLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiMuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHanghoa;
        private System.Windows.Forms.ToolStripMenuItem cocaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pepsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieunhapkho;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuxuatkho;
        private System.Windows.Forms.ToolStripMenuItem mnuThongke;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

