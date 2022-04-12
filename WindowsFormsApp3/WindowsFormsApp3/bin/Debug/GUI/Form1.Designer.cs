
namespace WindowsFormsApp3.GUI
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
            this.listViewSV = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtTSV = new System.Windows.Forms.TextBox();
            this.columMSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columTSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSV
            // 
            this.listViewSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columMSV,
            this.columTSV});
            this.listViewSV.HideSelection = false;
            this.listViewSV.Location = new System.Drawing.Point(87, 259);
            this.listViewSV.Name = "listViewSV";
            this.listViewSV.Size = new System.Drawing.Size(434, 159);
            this.listViewSV.TabIndex = 0;
            this.listViewSV.UseCompatibleStateImageBehavior = false;
            this.listViewSV.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Sinh Viên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Sinh Viên:";
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(191, 74);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(250, 22);
            this.txtMSV.TabIndex = 4;
            // 
            // txtTSV
            // 
            this.txtTSV.Location = new System.Drawing.Point(191, 133);
            this.txtTSV.Name = "txtTSV";
            this.txtTSV.Size = new System.Drawing.Size(250, 22);
            this.txtTSV.TabIndex = 5;
            // 
            // columMSV
            // 
            this.columMSV.Text = "Mã SV:";
            // 
            // columTSV
            // 
            this.columTSV.Text = "Tên SV:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(191, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 36);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "ADD";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(347, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 36);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "DELETE";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTSV);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSV);
            this.Name = "Form1";
            this.Text = "Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSV;
        private System.Windows.Forms.ColumnHeader columMSV;
        private System.Windows.Forms.ColumnHeader columTSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtTSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}