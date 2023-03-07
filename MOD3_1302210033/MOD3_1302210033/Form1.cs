using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD3_1302210033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bil = 0;
        int i = -1;
        int[] bilangan = new int[100];
      
        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
            bil = bil * 10 + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
            bil = bil * 10 + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
            bil = bil * 10 ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
            bil = bil * 10 + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
            bil = bil * 10 + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
            bil = bil * 10 + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
            bil = bil * 10 + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
            bil = bil * 10 + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
            bil = bil * 10 + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
            bil = bil * 10 + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
            i++;
            bilangan[i] = bil;
            bil = 0;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = label1.Text + "=";
            bilangan[i] = bil;
            int n = 0;
            bil = 0;
            int total = 0;

            

            while(n <= i)
            {
                total = total + bilangan[n];
                n++;

            }
            label1.Text = "" + total;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
