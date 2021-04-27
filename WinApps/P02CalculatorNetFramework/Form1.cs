using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02CalculatorNetFramework
{
    public partial class Form1 : Form
    {
        private bool isResultProvided = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            if (isResultProvided)
            {
                txtCalculation.Text = null;
                isResultProvided = false;
            }
            Button button = (Button) sender;
            txtCalculation.Text += button.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalculation.Text = null;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string calculation = txtCalculation.Text;
            string[] calc1 = calculation.Split('+');
            string[] calc2 = calculation.Split('-');
            string[] calc3 = calculation.Split('*');
            string[] calc4 = calculation.Split('/');

            if (calc1.Length == 2)
            {
                txtCalculation.Text = Convert.ToString(Convert.ToInt32(calc1[0]) + Convert.ToInt32(calc1[1]));
            }

            if (calc2.Length == 2)
            {
                txtCalculation.Text = Convert.ToString(Convert.ToInt32(calc2[0]) - Convert.ToInt32(calc2[1]));
            }

            if (calc3.Length == 2)
            {
                txtCalculation.Text = Convert.ToString(Convert.ToInt32(calc3[0]) * Convert.ToInt32(calc3[1]));
            }

            if (calc4.Length == 2)
            {
                txtCalculation.Text = Convert.ToString(Convert.ToInt32(calc4[0]) / Convert.ToInt32(calc4[1]));
            }

            isResultProvided = true;
        }
    }
}
