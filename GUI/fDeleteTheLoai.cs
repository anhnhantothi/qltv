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
    public partial class fDeleteTheLoai : Form
    {
        private List<THELOAI> theLoaiList;
        public fDeleteTheLoai()
        {
            InitializeComponent();
            LoadTheLoai();
        }
        private void LoadTheLoai()
        {
            theLoaiList = BUSTheLoai.Instance.GetAllTheLoai();
            comboBox1.DataSource = theLoaiList;
            comboBox1.DisplayMember = "TenTheLoai";
            comboBox1.ValueMember = "id";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is THELOAI selected)
            {
                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa thể loại '{selected.TenTheLoai}'?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool result = BUSTheLoai.Instance.DelTheLoai(selected.id);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa. Có thể đang có sách thuộc thể loại này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
