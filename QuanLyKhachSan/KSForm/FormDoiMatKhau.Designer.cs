namespace QuanLyKhachSan.KSForm
{
    partial class FormDoiMatKhau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXN = new DevExpress.XtraEditors.TextEdit();
            this.txtMKM = new DevExpress.XtraEditors.TextEdit();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnXN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtXN);
            this.groupBox1.Controls.Add(this.txtMKM);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnXN
            // 
            this.btnXN.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXN.Location = new System.Drawing.Point(307, 245);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(287, 33);
            this.btnXN.TabIndex = 7;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // txtXN
            // 
            this.txtXN.Location = new System.Drawing.Point(307, 188);
            this.txtXN.Name = "txtXN";
            this.txtXN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXN.Properties.Appearance.Options.UseFont = true;
            this.txtXN.Properties.MaxLength = 50;
            this.txtXN.Properties.UseSystemPasswordChar = true;
            this.txtXN.Size = new System.Drawing.Size(370, 28);
            this.txtXN.TabIndex = 5;
            this.txtXN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXN_KeyPress);
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(307, 138);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKM.Properties.Appearance.Options.UseFont = true;
            this.txtMKM.Properties.MaxLength = 50;
            this.txtMKM.Properties.UseSystemPasswordChar = true;
            this.txtMKM.Size = new System.Drawing.Size(370, 28);
            this.txtMKM.TabIndex = 4;
            this.txtMKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKM_KeyPress);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(307, 88);
            this.txtMK.Name = "txtMK";
            this.txtMK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Properties.Appearance.Options.UseFont = true;
            this.txtMK.Properties.MaxLength = 50;
            this.txtMK.Properties.UseSystemPasswordChar = true;
            this.txtMK.Size = new System.Drawing.Size(370, 28);
            this.txtMK.TabIndex = 3;
            this.txtMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMK_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 428);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtXN;
        private DevExpress.XtraEditors.TextEdit txtMKM;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXN;
    }
}