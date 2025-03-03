﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsOrTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            string[] questions = { "Yes", "No" }; // yes => yazı, no => tura
            string question = "";
            DialogResult result;
            do
            {
                int number = random.Next(0, 2);
                question = questions[number];
                result = MessageBox.Show("Yazı mı? tura mı?\nYazı ise Yes\nTura ise No seçeneğini seçiniz.", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            } while (result.ToString() != question);
            MessageBox.Show("Kazandınız");
        }
    }
}
