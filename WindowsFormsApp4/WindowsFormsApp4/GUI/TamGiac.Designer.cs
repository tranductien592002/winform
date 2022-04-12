
namespace WindowsFormsApp4.GUI
{
    partial class TamGiac
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.btn_ktraTG = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ktra = new System.Windows.Forms.TextBox();
            this.txt_KQ = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_KQDT = new System.Windows.Forms.TextBox();
            this.Thoát = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểm Tra Tam Giác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cạnh a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cạnh b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cạnh c:";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(176, 98);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(375, 22);
            this.txt_A.TabIndex = 4;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(176, 150);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(375, 22);
            this.txt_B.TabIndex = 5;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(176, 200);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(375, 22);
            this.txt_C.TabIndex = 6;
            // 
            // btn_ktraTG
            // 
            this.btn_ktraTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ktraTG.Location = new System.Drawing.Point(12, 283);
            this.btn_ktraTG.Name = "btn_ktraTG";
            this.btn_ktraTG.Size = new System.Drawing.Size(135, 31);
            this.btn_ktraTG.TabIndex = 8;
            this.btn_ktraTG.Text = "KT Tam Giác";
            this.btn_ktraTG.UseVisualStyleBackColor = true;
            this.btn_ktraTG.Click += new System.EventHandler(this.btn_ktraTG_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tính Chu Vi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ktra
            // 
            this.txt_ktra.Location = new System.Drawing.Point(176, 292);
            this.txt_ktra.Name = "txt_ktra";
            this.txt_ktra.Size = new System.Drawing.Size(375, 22);
            this.txt_ktra.TabIndex = 10;
            // 
            // txt_KQ
            // 
            this.txt_KQ.Location = new System.Drawing.Point(176, 350);
            this.txt_KQ.Name = "txt_KQ";
            this.txt_KQ.Size = new System.Drawing.Size(375, 22);
            this.txt_KQ.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Tính Diện Tích";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_KQDT
            // 
            this.txt_KQDT.Location = new System.Drawing.Point(176, 410);
            this.txt_KQDT.Name = "txt_KQDT";
            this.txt_KQDT.Size = new System.Drawing.Size(375, 22);
            this.txt_KQDT.TabIndex = 13;
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(271, 448);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(101, 30);
            this.Thoát.TabIndex = 14;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Quay Lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TamGiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 490);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.txt_KQDT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_KQ);
            this.Controls.Add(this.txt_ktra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ktraTG);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TamGiac";
            this.Text = "TamGiac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.Button btn_ktraTG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ktra;
        private System.Windows.Forms.TextBox txt_KQ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_KQDT;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button button3;
    }
}