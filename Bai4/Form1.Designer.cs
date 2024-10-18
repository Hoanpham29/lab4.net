namespace Bai4
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSoNguyen = new System.Windows.Forms.ListBox();
            this.BtnCapNhat = new System.Windows.Forms.Button();
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnThem2 = new System.Windows.Forms.Button();
            this.BtnChanDau = new System.Windows.Forms.Button();
            this.BtnLeCuoi = new System.Windows.Forms.Button();
            this.BtnXoaDangChon = new System.Windows.Forms.Button();
            this.BtnXoaDau = new System.Windows.Forms.Button();
            this.BtnXoaCuoi = new System.Windows.Forms.Button();
            this.BtnKetThuc = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnXoaCuoi);
            this.groupBox2.Controls.Add(this.BtnXoaDau);
            this.groupBox2.Controls.Add(this.BtnXoaDangChon);
            this.groupBox2.Controls.Add(this.BtnLeCuoi);
            this.groupBox2.Controls.Add(this.BtnChanDau);
            this.groupBox2.Controls.Add(this.BtnThem2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(363, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 346);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // lstSoNguyen
            // 
            this.lstSoNguyen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstSoNguyen.FormattingEnabled = true;
            this.lstSoNguyen.ItemHeight = 19;
            this.lstSoNguyen.Items.AddRange(new object[] {
            "1",
            "12",
            "4",
            "5",
            "6",
            "54"});
            this.lstSoNguyen.Location = new System.Drawing.Point(35, 77);
            this.lstSoNguyen.Name = "lstSoNguyen";
            this.lstSoNguyen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSoNguyen.Size = new System.Drawing.Size(308, 346);
            this.lstSoNguyen.TabIndex = 0;
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnCapNhat.Location = new System.Drawing.Point(564, 27);
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.Size = new System.Drawing.Size(94, 27);
            this.BtnCapNhat.TabIndex = 10;
            this.BtnCapNhat.Text = "Cập nhật";
            this.BtnCapNhat.UseVisualStyleBackColor = true;
            this.BtnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoNguyen.Location = new System.Drawing.Point(198, 27);
            this.txtSoNguyen.Name = "txtSoNguyen";
            this.txtSoNguyen.Size = new System.Drawing.Size(354, 25);
            this.txtSoNguyen.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // BtnThem2
            // 
            this.BtnThem2.Location = new System.Drawing.Point(6, 26);
            this.BtnThem2.Name = "BtnThem2";
            this.BtnThem2.Size = new System.Drawing.Size(283, 34);
            this.BtnThem2.TabIndex = 0;
            this.BtnThem2.Text = "Tăng mỗi phần tử lên 2";
            this.BtnThem2.UseVisualStyleBackColor = true;
            this.BtnThem2.Click += new System.EventHandler(this.BtnThem2_Click);
            // 
            // BtnChanDau
            // 
            this.BtnChanDau.Location = new System.Drawing.Point(6, 82);
            this.BtnChanDau.Name = "BtnChanDau";
            this.BtnChanDau.Size = new System.Drawing.Size(283, 34);
            this.BtnChanDau.TabIndex = 1;
            this.BtnChanDau.Text = "Chọn số chẵn đầu";
            this.BtnChanDau.UseVisualStyleBackColor = true;
            this.BtnChanDau.Click += new System.EventHandler(this.BtnChanDau_Click);
            // 
            // BtnLeCuoi
            // 
            this.BtnLeCuoi.Location = new System.Drawing.Point(6, 138);
            this.BtnLeCuoi.Name = "BtnLeCuoi";
            this.BtnLeCuoi.Size = new System.Drawing.Size(283, 34);
            this.BtnLeCuoi.TabIndex = 2;
            this.BtnLeCuoi.Text = "Chọn số lẻ cuối";
            this.BtnLeCuoi.UseVisualStyleBackColor = true;
            this.BtnLeCuoi.Click += new System.EventHandler(this.BtnLeCuoi_Click);
            // 
            // BtnXoaDangChon
            // 
            this.BtnXoaDangChon.Location = new System.Drawing.Point(6, 194);
            this.BtnXoaDangChon.Name = "BtnXoaDangChon";
            this.BtnXoaDangChon.Size = new System.Drawing.Size(283, 34);
            this.BtnXoaDangChon.TabIndex = 3;
            this.BtnXoaDangChon.Text = "Xóa phần tử đang chọn";
            this.BtnXoaDangChon.UseVisualStyleBackColor = true;
            this.BtnXoaDangChon.Click += new System.EventHandler(this.BtnXoaDangChon_Click);
            // 
            // BtnXoaDau
            // 
            this.BtnXoaDau.Location = new System.Drawing.Point(6, 250);
            this.BtnXoaDau.Name = "BtnXoaDau";
            this.BtnXoaDau.Size = new System.Drawing.Size(283, 34);
            this.BtnXoaDau.TabIndex = 4;
            this.BtnXoaDau.Text = "Xóa phần tử đầu";
            this.BtnXoaDau.UseVisualStyleBackColor = true;
            this.BtnXoaDau.Click += new System.EventHandler(this.BtnXoaDau_Click);
            // 
            // BtnXoaCuoi
            // 
            this.BtnXoaCuoi.Location = new System.Drawing.Point(6, 306);
            this.BtnXoaCuoi.Name = "BtnXoaCuoi";
            this.BtnXoaCuoi.Size = new System.Drawing.Size(283, 34);
            this.BtnXoaCuoi.TabIndex = 5;
            this.BtnXoaCuoi.Text = "Xóa phần tử cuối";
            this.BtnXoaCuoi.UseVisualStyleBackColor = true;
            this.BtnXoaCuoi.Click += new System.EventHandler(this.BtnXoaCuoi_Click);
            // 
            // BtnKetThuc
            // 
            this.BtnKetThuc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnKetThuc.Location = new System.Drawing.Point(35, 437);
            this.BtnKetThuc.Name = "BtnKetThuc";
            this.BtnKetThuc.Size = new System.Drawing.Size(623, 34);
            this.BtnKetThuc.TabIndex = 13;
            this.BtnKetThuc.Text = "Kết thúc";
            this.BtnKetThuc.UseVisualStyleBackColor = true;
            this.BtnKetThuc.Click += new System.EventHandler(this.BtnKetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 483);
            this.Controls.Add(this.BtnKetThuc);
            this.Controls.Add(this.lstSoNguyen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnCapNhat);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSoNguyen;
        private System.Windows.Forms.Button BtnCapNhat;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnXoaCuoi;
        private System.Windows.Forms.Button BtnXoaDau;
        private System.Windows.Forms.Button BtnXoaDangChon;
        private System.Windows.Forms.Button BtnLeCuoi;
        private System.Windows.Forms.Button BtnChanDau;
        private System.Windows.Forms.Button BtnThem2;
        private System.Windows.Forms.Button BtnKetThuc;
    }
}

