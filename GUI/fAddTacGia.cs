using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class fAddTacGia : Form
    {
        public fAddTacGia()
        {
            InitializeComponent();
        }

        private void fAddTacGia_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_luuTG_Click(object sender, EventArgs e)
        {
            string tenTacGia = tenTG.Text.Trim();

            if (string.IsNullOrEmpty(tenTacGia))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi BUS để thêm tác giả
            int id = BUSTacGia.Instance.AddTacGia(tenTacGia);

            if (id == -1)
            {
                MessageBox.Show("Thêm tác giả thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thêm tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }

    }
}
