using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number1;

        string op;
        private void btnArti_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "+";
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "-";
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "*";
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            op = "/";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            double number2 = Convert.ToDouble(textBox1.Text);
            double result = 0;
            if (op == "+")
            {
                result = number1 + number2;
            }
            else if (op == "-")
            {
                result = number1 - number2;
            }
            else if (op == "*")
            {
                result = number1 * number2;
            }
            else if (op == "/")
            {
                result = number1 / number2;
            }
            textBox1.Text = result.ToString();
        }
    }
}
