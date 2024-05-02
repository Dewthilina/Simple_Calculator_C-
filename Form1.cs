using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //initialize Variables
        string CalTotal,Option;
        int Number1, Number2,Result;

        // 0 to 9 Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TextTotal.Text = TextTotal.Text + btn0.Text;
        }

        //Buttons of Arithmetic Operations (+,-,x,/)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Option = "+";
            Number1=int.Parse(TextTotal.Text);
            TextTotal.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Option = "-";
            Number1 = int.Parse(TextTotal.Text);
            TextTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Option = "x";
            Number1 = int.Parse(TextTotal.Text);
            TextTotal.Clear();
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            Option = "/";
            Number1 = int.Parse(TextTotal.Text);
            TextTotal.Clear();
        }

        // "=" Button
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Number2 = int.Parse(TextTotal.Text);

            if (Option.Equals("+"))
                Result= Number1+ Number2;

            if (Option.Equals("-"))
                Result = Number1 - Number2;

            if (Option.Equals("x"))
                Result = Number1 * Number2;
            
            //in devide show only integer part. Decimal Will not show because Result is Integer
            if (Option.Equals("/"))
                Result = Number1 / Number2;

            TextTotal.Text=Result+"";
        }

        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            TextTotal.Clear();
            Result = (0);
            Number1 = (0);
            Number2 = (0);

        }

    }
}
