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
    public partial class Theater : Form
    {
        public Theater()
        {
            InitializeComponent();
            pnlContent.Location = new Point((this.Width - pnlContent.Width) / 2, (this.Height - pnlContent.Height) / 2);

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;

        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }

        private void Theater_Load(object sender, EventArgs e)
        {
            CenterControlInParent(pnlContent);
        }
    }
}
