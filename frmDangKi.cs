using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide12_Multiple_Document_Interface
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí?",
                "Confirm"
                ,MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool checke = true;
            if(txtTaiKhoan.Text == "")
            {
                errorProvider1.SetError(txtTaiKhoan, "Vui lòng không bỏ trống");
                checke = false;
            }
            if(txtMatKhau.Text == "")
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng không bỏ trống");
                checke = false;
            }
            if(txtNhapLaiMK.Text == "")
            {
                errorProvider1.SetError(txtNhapLaiMK, "Vui lòng không bỏ trống");
                checke = false;
            }



            bool ktra = txtMatKhau.Text.Equals(txtNhapLaiMK.Text);
            if (checke)
            {
                if (ktra)
                {
                    MessageBox.Show("Đăng kí thành công");
                    Close();
                }
                else
                    MessageBox.Show("Mật khẩu không chính xác,Vui lòng nhập lại");
            }

        }
    }
}
