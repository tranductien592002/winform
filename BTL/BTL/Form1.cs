using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int temIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btn_closeform.Visible = false;
        }
        private Color SelectColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while(temIndex == index)
            {
               index= random.Next(ThemeColor.colorList.Count);
            }
            temIndex = index;
            string color = ThemeColor.colorList[temIndex];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveteButton( object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
                    paneltitel.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btn_closeform.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach ( Control previosBtn in panelMenu.Controls)
            {
                if (previosBtn.GetType() == typeof(Button))
                {
                    previosBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previosBtn.ForeColor = Color.Gainsboro;
                    previosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenchildForm(Form childForm, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveteButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelhome.Controls.Add(childForm);
            this.panelhome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labeltitel.Text = childForm.Text;
        }

        private void Otn_sanPham_Click(object sender, EventArgs e)
        {
            OpenchildForm(new GUI.SanPham(),sender);
        }

        private void btn_donHang_Click(object sender, EventArgs e)
        {
            OpenchildForm(new GUI.SanPham(), sender);
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            OpenchildForm(new GUI.SanPham(), sender);
        }

        private void btn_thongBao_Click(object sender, EventArgs e)
        {
            OpenchildForm(new GUI.SanPham(), sender);
        }

        private void Ctn_caiDat_Click(object sender, EventArgs e)
        {
            OpenchildForm(new GUI.SanPham(), sender);
        }

        private void btn_closeform_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            labeltitel.Text = "TRANG CHỦ";
            paneltitel.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btn_closeform.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_full_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}