﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37.Sıra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, toplam;
            sayi1 = Convert.ToInt16(textBox1.Text);
            toplam = sayi1 * sayi1;
            MessageBox.Show(toplam.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
