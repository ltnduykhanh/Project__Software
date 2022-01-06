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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();

        }

        private void mnuThoát_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();
        }

        private void mnuPhieunhapkho_Click(object sender, EventArgs e)
        {
            frmPhieunhap frm = new frmPhieunhap();
           
            frm.ShowDialog();

        }

        private void mnuPhieuxuatkho_Click(object sender, EventArgs e)
        {
            frmPhieuxuatkho frm = new frmPhieuxuatkho();
            
            frm.ShowDialog();
        }
    }
}
