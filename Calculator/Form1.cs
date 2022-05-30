using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkRed;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
