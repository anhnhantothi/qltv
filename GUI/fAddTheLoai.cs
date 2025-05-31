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
    public partial class fAddTheLoai : Form
    {
        public fAddTheLoai()
        {
            InitializeComponent();
        }

        private Label label1;
        private TextBox tenTheLoai;
        private Button btn_Luu;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tenTheLoai = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thể loại: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tenTheLoai
            // 
            this.tenTheLoai.Location = new System.Drawing.Point(176, 46);
            this.tenTheLoai.Name = "tenTheLoai";
            this.tenTheLoai.Size = new System.Drawing.Size(173, 31);
            this.tenTheLoai.TabIndex = 1;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(154, 116);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 50);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // fAddTheLoai
            // 
            this.ClientSize = new System.Drawing.Size(412, 342);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.tenTheLoai);
            this.Controls.Add(this.label1);
            this.Name = "fAddTheLoai";
            this.Load += new System.EventHandler(this.fAddTheLoai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string ten = tenTheLoai.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!");
                return;
            }

            var existed = BUSTheLoai.Instance.GetAllTheLoai().FirstOrDefault(t => t.TenTheLoai == ten);
            if (existed != null)
            {
                var confirm = MessageBox.Show("Thể loại này đã tồn tại. Bạn vẫn muốn thêm?",
                                              "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) return;
            }

            bool result = BUSTheLoai.Instance.AddTheLoai(ten);
            if (!result)
                MessageBox.Show("Thêm thể loại thất bại!", "Lỗi");
            else
            {
                MessageBox.Show("Thêm thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fAddTheLoai_Load(object sender, EventArgs e)
        {

        }
    }
}
