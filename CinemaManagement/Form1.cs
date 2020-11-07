using CinemaManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //TopMost = true;
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //panel1.BackColor = ColorTranslator.FromHtml("#C9D9EB");
            //Init skin
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red300, MaterialSkin.Primary.Red900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

            //pnlLogin.Left = (this.Width - pnlLogin.Width) / 2;
            //pnlLogin.Top = (this.Height - pnlLogin.Height) / 2;
            pnlLogin.Location = new Point((this.Width - pnlLogin.Width) / 2, (this.Height - pnlLogin.Height) / 2);

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;

        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterControlInParent(pnlLogin);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            UserDAO uDao = new UserDAO();
            uDao.Login(txtUsername.Text,txtPass.Text);
            Theater t = new Theater();
            this.Visible=false;
            t.Visible=true;
        }
    }

}
