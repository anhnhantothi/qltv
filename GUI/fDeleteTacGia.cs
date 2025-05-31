using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class fDeleteTacGia : Form
    {

        private List<TACGIA> tacGiaList;
        public fDeleteTacGia()
        {
            InitializeComponent();
            this.Load += fDeleteTacGia_Load;
        }

        private void fDeleteTacGia_Load(object sender, EventArgs e)
        {
            LoadTacGia();
        }

        private void LoadTacGia()
        {
            tacGiaList = BUSTacGia.Instance.GetAllTacGia();
            comboBox1.DisplayMember = "TenTacGia";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = tacGiaList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is TACGIA selectedTacGia)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa tác giả '{selectedTacGia.TenTacGia}' không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    string result = BUSTacGia.Instance.DelTacGia(selectedTacGia.id);
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
