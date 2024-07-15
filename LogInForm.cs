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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 myFormMain = new Form1();
            this.Hide();
            myFormMain.Show();
        }

        private void buttonContin_Click(object sender, EventArgs e)
        {
            if ((textBoxLogin.Text == "Dekart" || textBoxLogin.Text == "dekart") && (textBoxPassword.Text == "3141"))
            {
                MainForm myyyyFoorm = new MainForm();
                this.Hide();
                myyyyFoorm.Show();
            }
            else 
            {
                label3.Text = "неверный логин или пароль";
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
