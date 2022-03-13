
namespace WindowsFormsApp1.GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_toStringTS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btl_Nhan = new System.Windows.Forms.Button();
            this.btl_Chia = new System.Windows.Forms.Button();
            this.btl_Tru = new System.Windows.Forms.Button();
            this.btc_Cong = new System.Windows.Forms.Button();
            this.txt_MS1 = new System.Windows.Forms.TextBox();
            this.txt_TS1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TS2 = new System.Windows.Forms.TextBox();
            this.txt_MS2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_toTringMS = new System.Windows.Forms.TextBox();
            this.btTiepTuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btTiepTuc);
            this.groupBox1.Controls.Add(this.txt_toTringMS);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_MS2);
            this.groupBox1.Controls.Add(this.txt_TS2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_toStringTS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btl_Nhan);
            this.groupBox1.Controls.Add(this.btl_Chia);
            this.groupBox1.Controls.Add(this.btl_Tru);
            this.groupBox1.Controls.Add(this.btc_Cong);
            this.groupBox1.Controls.Add(this.txt_MS1);
            this.groupBox1.Controls.Add(this.txt_TS1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(153, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính 2 phân số";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_toStringTS
            // 
            this.txt_toStringTS.Location = new System.Drawing.Point(296, 295);
            this.txt_toStringTS.Name = "txt_toStringTS";
            this.txt_toStringTS.Size = new System.Drawing.Size(47, 27);
            this.txt_toStringTS.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả";
            // 
            // btl_Nhan
            // 
            this.btl_Nhan.Location = new System.Drawing.Point(125, 225);
            this.btl_Nhan.Name = "btl_Nhan";
            this.btl_Nhan.Size = new System.Drawing.Size(75, 31);
            this.btl_Nhan.TabIndex = 7;
            this.btl_Nhan.Text = "Nhân";
            this.btl_Nhan.UseVisualStyleBackColor = true;
            this.btl_Nhan.Click += new System.EventHandler(this.btl_Nhan_Click);
            // 
            // btl_Chia
            // 
            this.btl_Chia.Location = new System.Drawing.Point(246, 225);
            this.btl_Chia.Name = "btl_Chia";
            this.btl_Chia.Size = new System.Drawing.Size(75, 31);
            this.btl_Chia.TabIndex = 6;
            this.btl_Chia.Text = "Chia";
            this.btl_Chia.UseVisualStyleBackColor = true;
            this.btl_Chia.Click += new System.EventHandler(this.btl_Chia_Click);
            // 
            // btl_Tru
            // 
            this.btl_Tru.Location = new System.Drawing.Point(246, 171);
            this.btl_Tru.Name = "btl_Tru";
            this.btl_Tru.Size = new System.Drawing.Size(75, 38);
            this.btl_Tru.TabIndex = 5;
            this.btl_Tru.Text = "Trừ";
            this.btl_Tru.UseVisualStyleBackColor = true;
            this.btl_Tru.Click += new System.EventHandler(this.btl_Tru_Click);
            // 
            // btc_Cong
            // 
            this.btc_Cong.Location = new System.Drawing.Point(125, 171);
            this.btc_Cong.Name = "btc_Cong";
            this.btc_Cong.Size = new System.Drawing.Size(75, 38);
            this.btc_Cong.TabIndex = 4;
            this.btc_Cong.Text = "Cộng";
            this.btc_Cong.UseVisualStyleBackColor = true;
            this.btc_Cong.Click += new System.EventHandler(this.btc_Cong_Click);
            // 
            // txt_MS1
            // 
            this.txt_MS1.Location = new System.Drawing.Point(84, 114);
            this.txt_MS1.Name = "txt_MS1";
            this.txt_MS1.Size = new System.Drawing.Size(35, 27);
            this.txt_MS1.TabIndex = 3;
            // 
            // txt_TS1
            // 
            this.txt_TS1.Location = new System.Drawing.Point(84, 81);
            this.txt_TS1.Name = "txt_TS1";
            this.txt_TS1.Size = new System.Drawing.Size(35, 27);
            this.txt_TS1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phân số 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân số 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "TS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "MS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "TS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "MS:";
            // 
            // txt_TS2
            // 
            this.txt_TS2.Location = new System.Drawing.Point(296, 81);
            this.txt_TS2.Name = "txt_TS2";
            this.txt_TS2.Size = new System.Drawing.Size(35, 27);
            this.txt_TS2.TabIndex = 14;
            // 
            // txt_MS2
            // 
            this.txt_MS2.Location = new System.Drawing.Point(296, 114);
            this.txt_MS2.Name = "txt_MS2";
            this.txt_MS2.Size = new System.Drawing.Size(35, 27);
            this.txt_MS2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "TS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "MS:";
            // 
            // txt_toTringMS
            // 
            this.txt_toTringMS.Location = new System.Drawing.Point(296, 343);
            this.txt_toTringMS.Name = "txt_toTringMS";
            this.txt_toTringMS.Size = new System.Drawing.Size(47, 27);
            this.txt_toTringMS.TabIndex = 18;
            // 
            // btTiepTuc
            // 
            this.btTiepTuc.Location = new System.Drawing.Point(41, 316);
            this.btTiepTuc.Name = "btTiepTuc";
            this.btTiepTuc.Size = new System.Drawing.Size(77, 37);
            this.btTiepTuc.TabIndex = 19;
            this.btTiepTuc.Text = "Xuat";
            this.btTiepTuc.UseVisualStyleBackColor = true;
            this.btTiepTuc.Click += new System.EventHandler(this.btTiepTuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_toStringTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btl_Nhan;
        private System.Windows.Forms.Button btl_Chia;
        private System.Windows.Forms.Button btl_Tru;
        private System.Windows.Forms.Button btc_Cong;
        private System.Windows.Forms.TextBox txt_MS1;
        private System.Windows.Forms.TextBox txt_TS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MS2;
        private System.Windows.Forms.TextBox txt_TS2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_toTringMS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btTiepTuc;
    }
}