using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace binaryadder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int c0, a0, b0, a1, b1, a2, b2, a3, b3, s0, s1, s2, s3, c4;

        /*  c0 a0 b0 a1 b1 a2 b2 a3 b3 s0 s1 s2 s3 c4
         *  1  2  4  3  8  7  6  5  12 11 10 9  14 13 textboxN
         *      
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            c0 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            c0 = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            a0 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
            a0 = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = "0";
            b0 = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = "1";
            b0 = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            a1 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "1";
            a1 = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox8.Text = "0";
            b1 = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox8.Text = "1";
            b1 = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox7.Text = "0";
            a2 = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox7.Text = "1";
            a2 = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox6.Text = "1";
            b2 = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox6.Text = "0";
            b2 = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Text = "1";
            a3 = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
            a3 = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox12.Text = "1";
            b3 = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox12.Text = "0";
            b3 = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
            textBox15.Text += c0.ToString();
            textBox15.Text += " ";
            textBox15.Text += a0.ToString();
            textBox15.Text += " ";
            textBox15.Text += b0.ToString();
            textBox15.Text += " ";
            textBox15.Text += a1.ToString();
            textBox15.Text += " ";
            textBox15.Text += b1.ToString();
            textBox15.Text += " ";
            textBox15.Text += a2.ToString();
            textBox15.Text += " ";
            textBox15.Text += b2.ToString();
            textBox15.Text += " ";
            textBox15.Text += a3.ToString();
            textBox15.Text += " ";
            textBox15.Text += b3.ToString();
            textBox15.Text += " ";

            calculatefunctiondBA4bit();

        }

        public void calculatefunctiondBA4bit()
        { 
            //s0 s1 s2 s3 c4
            //11 10 9 14 13

            string a = a0.ToString() + b0.ToString() + a1.ToString() + b1.ToString();
            string b = a2.ToString() + b2.ToString() + a3.ToString() + b3.ToString();
            int ia = 0;
            int ib = 0;
            int c=0;

            if (a == "0000") { ia = 0; }
            if (a == "0001") { ia = 1; }
            if (a == "0010") { ia = 2; }
            if (a == "0011") { ia = 3; }
            if (a == "0100") { ia = 4; }
            if (a == "0101") { ia = 5; }
            if (a == "0110") { ia = 6; }
            if (a == "0111") { ia = 7; }
            if (a == "1000") { ia = 8; }
            if (a == "1001") { ia = 9; }
            if (a == "1010") { ia = 10; }
            if (a == "1011") { ia = 11; }
            if (a == "1100") { ia = 12; }
            if (a == "1101") { ia = 13; }
            if (a == "1110") { ia = 14; }
            if (a == "1111") { ia = 15; }

            if (b == "0000") { ib = 0; }
            if (b == "0001") { ib = 1; }
            if (b == "0010") { ib = 2; }
            if (b == "0011") { ib = 3; }
            if (b == "0100") { ib = 4; }
            if (b == "0101") { ib = 5; }
            if (b == "0110") { ib = 6; }
            if (b == "0111") { ib = 7; }
            if (b == "1000") { ib = 8; }
            if (b == "1001") { ib = 9; }
            if (b == "1010") { ib = 10; }
            if (b == "1011") { ib = 11; }
            if (b == "1100") { ib = 12; }
            if (b == "1101") { ib = 13; }
            if (b == "1110") { ib = 14; }
            if (b == "1111") { ib = 15; }

            c = c0;


            Text = c.ToString() + "+" + ia.ToString() + "+" + ib.ToString() + " = " + (c + ia + ib).ToString();
            
          
            
            bitpair r = new bitpair();
            binaryops bo = new binaryops();

            int rez = (c + ia + ib);
            //de adaugat codul aici
  

           //adunati cifrele binare ale a0 b0 a1 b1 si a2 b2 a3 b3 si c0 
            //si depunetile in s0 s1 s2 s3 c4
            
            //rezulatul poate fi
            // s0 s1 s2 s3 c4 deca
            // 0  0  0  0  0    0
            if (rez == 0) { s0 = 0; s1 = 0; s2 = 0; s3 = 0; c4 = 0; }
            // 0  0  0  1  0    1 
            if (rez == 1) { s0 = 0; s1 = 0; s2 = 0; s3 = 1; c4 = 0; }
            // 0  0  1  0  0    2
            if (rez == 2) { s0 = 0; s1 = 0; s2 = 1; s3 = 0; c4 = 0; }
            // 0  0  1  1  0    3
            if (rez == 3) { s0 = 0; s1 = 0; s2 = 1; s3 = 1; c4 = 0; }
            // 0  1  0  0  0    4
            if (rez == 4) { s0 = 0; s1 = 1; s2 = 0; s3 = 0; c4 = 0; }
            // 0  1  0  1  0    5
            if (rez == 5) { s0 = 0; s1 = 1; s2 = 0; s3 = 1; c4 = 0; }
            // 0  1  1  0  0    6
            if (rez == 6) { s0 = 0; s1 = 1; s2 = 1; s3 = 0; c4 = 0; }
            // 0  1  1  1  0    7
            if (rez == 7) { s0 = 0; s1 = 1; s2 = 1; s3 = 1; c4 = 0; }
            // 1  0  0  0  0    8
            if (rez == 8) { s0 = 1; s1 = 0; s2 = 0; s3 = 0; c4 = 0; }
            // 1  0  0  1  0    9
            if (rez == 9) { s0 = 1; s1 = 0; s2 = 0; s3 = 1; c4 = 0; }
            // 1  0  1  0  0    10
            if (rez == 10) { s0 = 1; s1 = 0; s2 = 1; s3 = 0; c4 = 0; }
            // 1  0  1  1  0    11
            if (rez == 11) { s0 = 1; s1 = 0; s2 = 1; s3 = 1; c4 = 0; }
            // 1  1  0  0  0    12
            if (rez == 12) { s0 = 1; s1 = 1; s2 = 0; s3 = 0; c4 = 0; }
            // 1  1  0  1  0    13
            if (rez == 13) { s0 = 1; s1 = 1; s2 = 0; s3 = 1; c4 = 0; }
            // 1  1  1  0  0    14
            if (rez == 14) { s0 = 1; s1 = 1; s2 = 1; s3 = 0; c4 = 0; }
            // 1  1  1  1  0    15
            if (rez == 15) { s0 = 1; s1 = 1; s2 = 1; s3 = 1; c4 = 0; }
            // 0  0  0  0  1    16
            if (rez == 16) { s0 = 0; s1 = 0; s2 = 0; s3 = 0; c4 = 1; }
            // 0  0  0  1  1    17 
            if (rez == 17) { s0 = 0; s1 = 0; s2 = 0; s3 = 1; c4 = 1; }
            // 0  0  1  0  1    18
            if (rez == 18) { s0 = 0; s1 = 0; s2 = 1; s3 = 0; c4 = 1; }
            // 0  0  1  1  1    19
            if (rez == 19) { s0 = 0; s1 = 0; s2 = 1; s3 = 1; c4 = 1; }
            // 0  1  0  0  1    20
            if (rez == 20) { s0 = 0; s1 = 1; s2 = 0; s3 = 0; c4 = 1; }
            // 0  1  0  1  1    21
            if (rez == 21) { s0 = 0; s1 = 1; s2 = 0; s3 = 1; c4 = 1; }
            // 0  1  1  0  1    22
            if (rez == 22) { s0 = 0; s1 = 1; s2 = 1; s3 = 0; c4 = 1; }
            // 0  1  1  1  1    23
            if (rez == 23) { s0 = 0; s1 = 1; s2 = 1; s3 = 1; c4 = 1; }
            // 1  0  0  0  1    24
            if (rez == 24) { s0 = 1; s1 = 0; s2 = 0; s3 = 0; c4 = 1; }
            // 1  0  0  1  1    25
            if (rez == 25) { s0 = 1; s1 = 0; s2 = 0; s3 = 1; c4 = 1; }
            // 1  0  1  0  1    26
            if (rez == 26) { s0 = 1; s1 = 0; s2 = 1; s3 = 0; c4 = 1; }
            // 1  0  1  1  1    27
            if (rez == 27) { s0 = 1; s1 = 0; s2 = 1; s3 = 1; c4 = 1; }
            // 1  1  0  0  1    28
            if (rez == 28) { s0 = 1; s1 = 1; s2 = 0; s3 = 0; c4 = 1; }
            // 1  1  0  1  1    29
            if (rez == 29) { s0 = 1; s1 = 1; s2 = 0; s3 = 1; c4 = 1; }
            // 1  1  1  0  1    30
            if (rez == 30) { s0 = 1; s1 = 1; s2 = 1; s3 = 0; c4 = 1; }
            // 1  1  1  1  1    31
            if (rez == 31) { s0 = 1; s1 = 1; s2 = 1; s3 = 1; c4 = 1; }
            
            //sfarsit de sectiune cod

            textBox11.Text = s0.ToString();
            textBox10.Text = s1.ToString();
            textBox9.Text = s2.ToString();
            textBox14.Text = s3.ToString();
            textBox13.Text = c4.ToString();

        }
    }
}
