using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class CalculadoraSimples : Form
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        private void btnNum_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btnPlus_Click(object plus, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                previousOperation = Operation.Add;
            }
            else
            {
                performCalculation(previousOperation);
            }
            txtDisplay.Text += (plus as Button).Text;
        }

        private void performCalculation(Operation previousOperation)
        {
            List<double> lstNums = new List<double>();
            switch (previousOperation)
            {
                case Operation.Add:
                    lstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] + lstNums[1]).ToString();
                    break;
                case Operation.Sub:
                    lstNums = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] - lstNums[1]).ToString();
                    break;
                case Operation.Mul:
                    lstNums = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] * lstNums[1]).ToString();
                    break;
                case Operation.Div:
                    lstNums = txtDisplay.Text.Split('/').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] / lstNums[1]).ToString();
                    break;
                case Operation.None:
                    break;
                default:
                    break;
            }
        }

            private void btnMinus_Click(object minus, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                previousOperation = Operation.Sub;
            }
            else
            {
                performCalculation(previousOperation);
            }
            txtDisplay.Text += (minus as Button).Text;
        }

        private void btnMulti_Click(object multi, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                previousOperation = Operation.Mul;
            }
            else
            {
                performCalculation(previousOperation);
            }
            txtDisplay.Text += (multi as Button).Text;
        }

        private void btnDiv_Click(object div, EventArgs e)
        {
            if (previousOperation == Operation.None)
            {
                previousOperation = Operation.Div;
            }
            else
            {
                performCalculation(previousOperation);
            }
            txtDisplay.Text += (div as Button).Text;
        }

        enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            None
        }

        static Operation previousOperation = Operation.None;
    }
}
