
namespace WindowsFormsApp3
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
            this.listViewbt = new System.Windows.Forms.ListView();
            this.columMSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columTSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MSV = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewbt
            // 
            this.listViewbt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columMSV,
            this.columTSV});
            this.listViewbt.HideSelection = false;
            this.listViewbt.Location = new System.Drawing.Point(62, 243);
            this.listViewbt.Name = "listViewbt";
            this.listViewbt.Size = new System.Drawing.Size(381, 168);
            this.listViewbt.TabIndex = 0;
            this.listViewbt.UseCompatibleStateImageBehavior = false;
            // 
            // columMSV
            // 
            this.columMSV.Text = "Mã Sinh Viên";
            // 
            // columTSV
            // 
            this.columTSV.Text = "Tên Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Sinh Viên:";
            // 
            // txt_MSV
            // 
            this.txt_MSV.Location = new System.Drawing.Point(225, 80);
            this.txt_MSV.Name = "txt_MSV";
            this.txt_MSV.Size = new System.Drawing.Size(192, 22);
            this.txt_MSV.TabIndex = 4;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(225, 136);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(192, 22);
            this.txt_hoTen.TabIndex = 5;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(62, 205);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(86, 32);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "ADD";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(357, 205);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(86, 32);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "DELETE";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(500, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnTT
            // 
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.Location = new System.Drawing.Point(664, 423);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(87, 36);
            this.btnTT.TabIndex = 9;
            this.btnTT.Text = "Continue";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 471);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.txt_MSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewbt;
        private System.Windows.Forms.ColumnHeader columMSV;
        private System.Windows.Forms.ColumnHeader columTSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MSV;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTT;
    }
}

