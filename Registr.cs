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
    public partial class Registr : Form
    {
        Timer tm = new Timer();
        Timer ButtonDopTimer = new Timer();

        Random rnd = new Random();

        int nameForBut = 1000;
        public Registr()
        {
            InitializeComponent();
            tm.Interval = 500;
            tm.Tick += Tm_tik;
            ButtonDopTimer.Interval = 100;
            ButtonDopTimer.Tick += ButtonDopTimerTick;
        }

        private void ButtonDopTimerTick(object sender, EventArgs e)
        {
        }

        private void Tm_tik(object sender, EventArgs e)
        {
            Update();
            switch (rnd.Next(5)) {
                case 0:
                    radioButton1.Checked = true;
                    break;
                case 1:
                    radioButton2.Checked = true;
                    break;
                case 2:
                    radioButton3.Checked = true;
                    break;
                case 3:
                    radioButton4.Checked = true;
                    break;
                case 4:
                    radioButton5.Checked = true;
                    break;
            }
            switch (rnd.Next(4))
            {
                case 0:
                    radioButton10.Checked = true;
                    break;
                case 1:
                    radioButton9.Checked = true;
                    break;
                case 2:
                    radioButton8.Checked = true;
                    break;
                case 3:
                    radioButton7.Checked = true;
                    break;
            }
            textBoxAge.Text = "age: " + rnd.Next(1500);
            textBoxNumber.Text = "+7" + rnd.Next(10000, 100000) + rnd.Next(10000, 100000);
            label2.Text = "your login: User" + rnd.Next(5000);
            textBoxPass.Text = "" + rnd.Next(99999999);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myFormMain = new Form1();
            this.Hide();
            myFormMain.Show();

        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            tm.Start();
            textBoxNumber.Text = "+7" + rnd.Next(10000, 100000) + rnd.Next(10000, 100000);
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            //параша
            tm.Stop();
            nameForBut = rnd.Next(5000);
            ButtonDopTimer.Start();
            Button ButtonDop = new Button();
            groupBox2.Visible = false;
            if (textBoxPass.Text != "0")
            {
                switch (rnd.Next(4)) {
                    case 0:
                        ButtonDop.Text = "this password is already used by the user User" + rnd.Next(5000);
                        break;
                    case 1:
                        ButtonDop.Text = "this phone number is already used by the user User" + rnd.Next(5000);
                        break;
                    case 2:
                        ButtonDop.Text = "error" + rnd.Next(5000) + " the system didn't like you";
                        break;
                }
            }
            else
            {
                ButtonDop.Text = "you need to come up with a password";
            }
            
            ButtonDop.Location = new Point(12, 221);
            ButtonDop.Size = new Size(425, 226);
            ButtonDop.ForeColor = Color.DeepPink;
            ButtonDop.Font = new Font("ISOCTEUR", 12);
            this.Controls.Add(ButtonDop);
            ButtonDop.Click += bt_click;
        }

        private void bt_click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox2.Enabled = true;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            nameForBut = rnd.Next(5000);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
