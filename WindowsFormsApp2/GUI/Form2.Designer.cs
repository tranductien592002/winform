
namespace WindowsFormsApp2.GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_maHang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_xuatTH = new System.Windows.Forms.TextBox();
            this.txt_xuatMH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_xuatDG = new System.Windows.Forms.TextBox();
            this.txt_xuatSL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hàng:\r\n";
            // 
            // lb_maHang
            // 
            this.lb_maHang.AutoSize = true;
            this.lb_maHang.Location = new System.Drawing.Point(180, 48);
            this.lb_maHang.Name = "lb_maHang";
            this.lb_maHang.Size = new System.Drawing.Size(8, 17);
            this.lb_maHang.TabIndex = 2;
            this.lb_maHang.Text = "\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Hàng:\r\n";
            // 
            // txt_xuatTH
            // 
            this.txt_xuatTH.Location = new System.Drawing.Point(187, 93);
            this.txt_xuatTH.Name = "txt_xuatTH";
            this.txt_xuatTH.Size = new System.Drawing.Size(189, 22);
            this.txt_xuatTH.TabIndex = 4;
            // 
            // txt_xuatMH
            // 
            this.txt_xuatMH.Location = new System.Drawing.Point(187, 42);
            this.txt_xuatMH.Name = "txt_xuatMH";
            this.txt_xuatMH.Size = new System.Drawing.Size(189, 22);
            this.txt_xuatMH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn Giá:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số Lượng:\r\n";
            // 
            // txt_xuatDG
            // 
            this.txt_xuatDG.Location = new System.Drawing.Point(187, 147);
            this.txt_xuatDG.Name = "txt_xuatDG";
            this.txt_xuatDG.Size = new System.Drawing.Size(189, 22);
            this.txt_xuatDG.TabIndex = 8;
            // 
            // txt_xuatSL
            // 
            this.txt_xuatSL.Location = new System.Drawing.Point(187, 196);
            this.txt_xuatSL.Name = "txt_xuatSL";
            this.txt_xuatSL.Size = new System.Drawing.Size(189, 22);
            this.txt_xuatSL.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoat\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_xuatSL);
            this.Controls.Add(this.txt_xuatDG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_xuatMH);
            this.Controls.Add(this.txt_xuatTH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_maHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_maHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_xuatTH;
        private System.Windows.Forms.TextBox txt_xuatMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_xuatDG;
        private System.Windows.Forms.TextBox txt_xuatSL;
        private System.Windows.Forms.Button button1;
    }
}