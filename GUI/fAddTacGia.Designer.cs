namespace GUI
{
    partial class fAddTacGia
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
            this.label_TG = new System.Windows.Forms.Label();
            this.tenTG = new System.Windows.Forms.TextBox();
            this.btn_luuTG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_TG
            // 
            this.label_TG.AutoSize = true;
            this.label_TG.Location = new System.Drawing.Point(39, 91);
            this.label_TG.Name = "label_TG";
            this.label_TG.Size = new System.Drawing.Size(88, 16);
            this.label_TG.TabIndex = 0;
            this.label_TG.Text = "Tên Tác Giả: ";
            this.label_TG.Click += new System.EventHandler(this.label1_Click);
            // 
            // tenTG
            // 
            this.tenTG.Location = new System.Drawing.Point(133, 88);
            this.tenTG.Name = "tenTG";
            this.tenTG.Size = new System.Drawing.Size(192, 22);
            this.tenTG.TabIndex = 1;
            // 
            // btn_luuTG
            // 
            this.btn_luuTG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_luuTG.Location = new System.Drawing.Point(149, 278);
            this.btn_luuTG.Name = "btn_luuTG";
            this.btn_luuTG.Size = new System.Drawing.Size(75, 23);
            this.btn_luuTG.TabIndex = 2;
            this.btn_luuTG.Text = "Lưu";
            this.btn_luuTG.UseVisualStyleBackColor = false;
            this.btn_luuTG.Click += new System.EventHandler(this.btn_luuTG_Click);
            // 
            // fAddTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(393, 371);
            this.Controls.Add(this.btn_luuTG);
            this.Controls.Add(this.tenTG);
            this.Controls.Add(this.label_TG);
            this.Name = "fAddTacGia";
            this.Text = "Thêm tác giả";
            this.Load += new System.EventHandler(this.fAddTacGia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TG;
        private System.Windows.Forms.TextBox tenTG;
        private System.Windows.Forms.Button btn_luuTG;
    }
}