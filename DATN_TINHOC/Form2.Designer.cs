namespace DATN_TINHOC
{
    partial class Form2
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
            btt_Chuongtrinh = new Button();
            btt_thoat = new Button();
            SuspendLayout();
            // 
            // btt_Chuongtrinh
            // 
            btt_Chuongtrinh.BackColor = SystemColors.ControlDark;
            btt_Chuongtrinh.Location = new Point(87, 128);
            btt_Chuongtrinh.Name = "btt_Chuongtrinh";
            btt_Chuongtrinh.Size = new Size(88, 40);
            btt_Chuongtrinh.TabIndex = 0;
            btt_Chuongtrinh.Text = "Vào chương trình";
            btt_Chuongtrinh.UseVisualStyleBackColor = false;
            btt_Chuongtrinh.Click += btt_Chuongtrinh_Click;
            // 
            // btt_thoat
            // 
            btt_thoat.BackColor = SystemColors.ControlDark;
            btt_thoat.Location = new Point(87, 193);
            btt_thoat.Name = "btt_thoat";
            btt_thoat.Size = new Size(88, 38);
            btt_thoat.TabIndex = 1;
            btt_thoat.Text = "Thoát";
            btt_thoat.UseVisualStyleBackColor = false;
            btt_thoat.Click += btt_thoat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._421db6526d6db1926c16a5d380b09ab6;
            ClientSize = new Size(580, 369);
            Controls.Add(btt_thoat);
            Controls.Add(btt_Chuongtrinh);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btt_Chuongtrinh;
        private Button btt_thoat;
    }
}