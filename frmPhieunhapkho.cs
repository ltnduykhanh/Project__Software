using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management.Class;
using System.Data.SqlClient;
namespace Management
{
    public partial class frmPhieunhap : Form
    {
        DataTable Phieunhapkho;
        public frmPhieunhap()
        {
            InitializeComponent();
        }

        private void frmDMchatlieu_Load(object sender, EventArgs e)
        {
            txt_Maphieunhap.Enabled = false;
            btn_Luu.Enabled = false;
            LoadDataGirdView();
        }
        private void LoadDataGirdView()
        {
            string sql;
            sql = "SELECT maPhieu,maSanpham,soluong FROM Phieunhapkho";
            Phieunhapkho = Function.GetDataToTable(sql);
            dgvPhieunhapkho.DataSource = Phieunhapkho;
            dgvPhieunhapkho.Columns[0].HeaderText = "Mã phiếu nhập";
            
            dgvPhieunhapkho.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvPhieunhapkho.Columns[2].HeaderText = "Số lượng";
            dgvPhieunhapkho.Columns[0].Width = 100;
            
            dgvPhieunhapkho.Columns[1].Width = 100;
            dgvPhieunhapkho.Columns[2].Width = 100;
            dgvPhieunhapkho.AllowUserToAddRows = false;
            dgvPhieunhapkho.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhieunhapkho_Click(object sender, EventArgs e)
        {
            if(btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Maphieunhap.Focus();
                return;
            }
            if(Phieunhapkho.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txt_Maphieunhap.Text = dgvPhieunhapkho.CurrentRow.Cells["maPhieu"].Value.ToString();
           
            txt_Masanpham.Text = dgvPhieunhapkho.CurrentRow.Cells["maSanpham"].Value.ToString();
            txt_soluong.Text = dgvPhieunhapkho.CurrentRow.Cells["soluong"].Value.ToString();
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void btn_ThemClick(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            ResetValue();
            txt_Maphieunhap.Enabled = true;
            txt_Maphieunhap.Focus();

        }

        private void ResetValue()
        {
            txt_Maphieunhap.Text = "";
            
            txt_Masanpham.Text = "";
            txt_soluong.Text = "";
        }

        private void btn_LuuClick(object sender, EventArgs e)
        {
            string sql; 
            if (txt_Maphieunhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Maphieunhap.Focus();
                return;
            }
            
            if (txt_Masanpham.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Masanpham.Focus();
                return;
            }
            if (txt_soluong.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluong.Focus();
                return;
            }
            sql = "Select maPhieu From Phieunhapkho where maPhieu=N'" + txt_Maphieunhap.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã phiếu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Maphieunhap.Focus();
                return;
            }
            
                sql = "INSERT INTO Phieunhapkho(maPhieu,maSanpham,soluong) VALUES(N'" + txt_Maphieunhap.Text + "',N'" + txt_Masanpham.Text + "',N'"+int.Parse(txt_soluong.Text)+"')";
                
            Function.RunSQL(sql); 
            
          
            LoadDataGirdView();
            ResetValue();
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
           
            btn_Luu.Enabled = false;
            txt_Maphieunhap.Enabled = false;
        }

        
            

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (Phieunhapkho.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Maphieunhap.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn mã phiếu nhập nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Masanpham.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_soluong.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE Phieunhapkho SET maSanpham=N'" +
                txt_Masanpham.Text +
                "' WHERE maPhieu=N'" + txt_Maphieunhap.Text + "'";
            Function.RunSQL(sql);
            LoadDataGirdView();
            ResetValue();


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (Phieunhapkho.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Maphieunhap.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Phieunhapkho WHERE maPhieu=N'" + txt_Maphieunhap.Text + "'";
                Class.Function.RunSQL(sql);
                LoadDataGirdView();
                ResetValue();
            }
        }

        
    }
}
