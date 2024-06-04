using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuş_Takımı_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            { label1.Text = "3"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            { label1.Text = "1"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            { label1.Text = "2"; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            { label1.Text = "4"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            { label1.Text = "5"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            { label1.Text = "6"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            { label1.Text = "7"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            { label1.Text = "8"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            { label1.Text = "9"; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            { label1.Text = "0"; }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void button2_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button3_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void Button4_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;
        }

        private void Button5_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
        }

        private void Button6_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Button7_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }

        private void Button7_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Button8_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void Button8_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
        }

        private void Button9_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSalmon;
        }

        private void Button9_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkTurquoise;
        }

        private void Mouse0_MouseMove(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue; 
        }

        private void Mouse0_MoseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrchid;
        }
    }
}
