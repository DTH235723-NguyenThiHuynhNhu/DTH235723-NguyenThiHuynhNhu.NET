namespace Bai2._9
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChuVi = new System.Windows.Forms.Button();
            this.btnDienTich = new System.Windows.Forms.Button();
            this.btnDuongCheo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(292, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HINH CHU NHAT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(284, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(79, 61);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(79, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "a:";
            // 
            // btnChuVi
            // 
            this.btnChuVi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnChuVi.Location = new System.Drawing.Point(132, 308);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.Size = new System.Drawing.Size(78, 37);
            this.btnChuVi.TabIndex = 4;
            this.btnChuVi.Text = "Chu Vi";
            this.btnChuVi.UseVisualStyleBackColor = false;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // btnDienTich
            // 
            this.btnDienTich.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDienTich.Location = new System.Drawing.Point(253, 308);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(81, 37);
            this.btnDienTich.TabIndex = 5;
            this.btnDienTich.Text = "Dien Tich";
            this.btnDienTich.UseVisualStyleBackColor = false;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // btnDuongCheo
            // 
            this.btnDuongCheo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDuongCheo.Location = new System.Drawing.Point(380, 308);
            this.btnDuongCheo.Name = "btnDuongCheo";
            this.btnDuongCheo.Size = new System.Drawing.Size(107, 37);
            this.btnDuongCheo.TabIndex = 6;
            this.btnDuongCheo.Text = "Duong Cheo";
            this.btnDuongCheo.UseVisualStyleBackColor = false;
            this.btnDuongCheo.Click += new System.EventHandler(this.btnDuongCheo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThoat.Location = new System.Drawing.Point(540, 308);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 37);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDuongCheo);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai2.9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChuVi;
        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.Button btnDuongCheo;
        private System.Windows.Forms.Button btnThoat;
    }
}

