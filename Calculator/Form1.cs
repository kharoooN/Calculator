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
        
        Models.Calculate calculate = new Models.Calculate();
        public FormMain()
        {
            InitializeComponent();
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            
        }

        private double number1, number2, operation;


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

        private void btnButton_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = null;
            }
            
            txtDisplay.Text += button.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            txtDisplay.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            
            txtDisplay.Text = "0";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
            
           
        }



        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(txtDisplay.Text);
            if (operation == '/')
            {
                txtDisplay.Text = calculate.Divide(number1,number2).ToString();
            }
            if (operation == '*')
            {
                txtDisplay.Text = calculate.Multiply(number1, number2).ToString();
            }
            if (operation == '-')
            {
                txtDisplay.Text = calculate.Subtraction(number1, number2).ToString();
            }
            if (operation == '+')
            {
                txtDisplay.Text = calculate.Add(number1, number2).ToString();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            operation = '+';
            txtDisplay.Text = "0";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            operation = '-';
            txtDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            operation = '*';
            txtDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtDisplay.Text);
            operation = '/';
            txtDisplay.Text = "0";
        }

        private void btnNegativeOrPositive_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.StartsWith("-"))
            {
               
                txtDisplay.Text = txtDisplay.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(txtDisplay.Text) && decimal.Parse(txtDisplay.Text) != 0)
            {
                
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (((float.Parse(txtDisplay.Text)) * (float.Parse(txtDisplay.Text)) / 100)).ToString();
        }

     

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text = txtDisplay.Text += ",";
                
            }
        }
    }
}
