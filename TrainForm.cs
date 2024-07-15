using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasper_3._0
{
    public partial class TrainForm : Form
    {
        int[] arrPi = new int[30] { 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9, 3, 2, 3, 8, 4, 6, 2, 6, 4, 3, 3, 8, 3, 2, 7, 9 };
        int i = 0;
        public TrainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStart.Visible = false;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            textBoxDigit.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.HotPink;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 1)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else 
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30) 
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;

                    buttonBack.Visible = true;
                    buttonBack.Enabled = true;
                }
            }
            else 
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i]) 
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.HotPink;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 2)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    buttonBack.Visible = true;
                    buttonBack.Enabled = true;
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.HotPink;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 3)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    buttonBack.Visible = true;
                    buttonBack.Enabled = true;
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.HotPink;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 4)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    buttonBack.Visible = true;
                    buttonBack.Enabled = true;
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.HotPink;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 5)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    labelMistake.Text = "Поздравляю!";
                    labelMistake.Visible = true;
                    buttonStart.Enabled = true;
                    buttonStart.Visible = true;
                    buttonStart.Text = "НАЗАД";
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.HotPink;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 6)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    labelMistake.Text = "Поздравляю!";
                    labelMistake.Visible = true;
                    buttonStart.Enabled = true;
                    buttonStart.Visible = true;
                    buttonStart.Text = "НАЗАД";
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.HotPink;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 7)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    buttonBack.Visible = true;
                    buttonBack.Enabled = true;
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.HotPink;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 8)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    buttonBack.Visible = true;
                    buttonBack.Enabled = true;
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.HotPink;
            button0.ForeColor = Color.DarkViolet;

            if (arrPi[i] == 9)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    buttonBack.Visible = true;
                    buttonBack.Enabled = true;
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Digit " + i;
            button1.ForeColor = Color.DarkViolet;
            button2.ForeColor = Color.DarkViolet;
            button3.ForeColor = Color.DarkViolet;
            button4.ForeColor = Color.DarkViolet;
            button5.ForeColor = Color.DarkViolet;
            button6.ForeColor = Color.DarkViolet;
            button7.ForeColor = Color.DarkViolet;
            button8.ForeColor = Color.DarkViolet;
            button9.ForeColor = Color.DarkViolet;
            button0.ForeColor = Color.HotPink;

            if (arrPi[i] == 0)
            {
                if (i > 3)
                {
                    textBoxDigit.Text = arrPi[i - 2].ToString() + arrPi[i - 1].ToString() + arrPi[i].ToString();
                }
                else
                {
                    textBoxDigit.Text += arrPi[i].ToString();
                }
                labelMistake.Visible = false;
                i++;
                if (i >= 30)
                {
                    groupBox1.Enabled = false;
                    groupBox1.Visible = false;
                    textBoxDigit.Visible = false;
                    buttonBack.Visible = true;
                    buttonBack.Enabled = true;
                }
            }
            else
            {
                labelMistake.Visible = true;
                button1.ForeColor = Color.DarkViolet;
                button2.ForeColor = Color.DarkViolet;
                button3.ForeColor = Color.DarkViolet;
                button4.ForeColor = Color.DarkViolet;
                button5.ForeColor = Color.DarkViolet;
                button6.ForeColor = Color.DarkViolet;
                button7.ForeColor = Color.DarkViolet;
                button8.ForeColor = Color.DarkViolet;
                button9.ForeColor = Color.DarkViolet;
                button0.ForeColor = Color.DarkViolet;
                switch (arrPi[i])
                {
                    case 0:
                        button0.ForeColor = Color.HotPink;
                        break;
                    case 1:
                        button1.ForeColor = Color.HotPink;
                        break;
                    case 2:
                        button2.ForeColor = Color.HotPink;
                        break;
                    case 3:
                        button3.ForeColor = Color.HotPink;
                        break;
                    case 4:
                        button4.ForeColor = Color.HotPink;
                        break;
                    case 5:
                        button5.ForeColor = Color.HotPink;
                        break;
                    case 6:
                        button6.ForeColor = Color.HotPink;
                        break;
                    case 7:
                        button7.ForeColor = Color.HotPink;
                        break;
                    case 8:
                        button8.ForeColor = Color.HotPink;
                        break;
                    case 9:
                        button9.ForeColor = Color.HotPink;
                        break;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
