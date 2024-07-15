using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kasper_3._0.Properties;

namespace Kasper_3._0
{
    public partial class UndergroundForm : Form
    {
        Timer ActionTimer = new Timer();

        public UndergroundForm()
        {
            InitializeComponent();
            ActionTimer.Interval = 500;
            ActionTimer.Tick += ActionTimerTick;
        }

        private void ActionTimerTick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            //p1
            switch (rnd.Next(30)) 
            {
                case 0:
                    pictureBox1.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox1.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox1.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox1.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox1.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox1.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox1.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox1.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox1.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox1.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox1.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox1.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox1.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox1.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox1.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox1.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox1.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox1.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox1.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox1.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox1.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox1.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox1.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox1.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox1.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox1.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox1.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox1.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox1.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox1.Image = Resources.UDDD;
                    break;
            }
            //p2
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox2.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox2.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox2.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox2.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox2.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox2.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox2.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox2.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox2.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox2.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox2.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox2.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox2.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox2.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox2.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox2.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox2.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox2.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox2.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox2.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox2.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox2.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox2.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox2.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox2.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox2.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox2.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox2.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox2.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox2.Image = Resources.UDDD;
                    break;
            }
            //p3
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox3.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox3.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox3.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox3.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox3.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox3.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox3.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox3.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox3.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox3.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox3.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox3.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox3.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox3.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox3.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox3.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox3.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox3.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox3.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox3.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox3.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox3.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox3.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox3.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox3.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox3.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox3.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox3.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox3.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox3.Image = Resources.UDDD;
                    break;
            }
            //p4
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox4.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox4.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox4.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox4.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox4.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox4.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox4.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox4.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox4.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox4.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox4.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox4.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox4.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox4.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox4.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox4.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox4.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox4.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox4.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox4.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox4.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox4.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox4.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox4.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox4.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox4.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox4.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox4.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox4.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox4.Image = Resources.UDDD;
                    break;
            }
            //p5
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox5.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox5.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox5.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox5.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox5.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox5.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox5.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox5.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox5.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox5.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox5.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox5.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox5.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox5.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox5.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox5.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox5.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox5.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox5.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox5.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox5.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox5.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox5.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox5.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox5.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox5.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox5.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox5.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox5.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox5.Image = Resources.UDDD;
                    break;
            }
            //p6
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox6.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox6.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox6.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox6.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox6.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox6.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox6.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox6.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox6.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox6.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox6.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox6.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox6.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox6.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox6.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox6.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox6.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox6.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox6.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox6.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox6.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox6.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox6.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox6.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox6.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox6.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox6.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox6.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox6.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox6.Image = Resources.UDDD;
                    break;
            }
            //p7
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox7.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox7.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox7.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox7.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox7.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox7.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox7.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox7.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox7.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox7.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox7.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox7.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox7.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox7.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox7.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox7.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox7.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox7.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox7.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox7.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox7.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox7.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox7.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox7.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox7.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox7.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox7.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox7.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox7.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox7.Image = Resources.UDDD;
                    break;
            }
            //p8
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox8.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox8.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox8.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox8.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox8.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox8.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox8.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox8.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox8.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox8.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox8.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox8.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox8.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox8.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox8.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox8.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox8.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox8.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox8.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox8.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox8.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox8.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox8.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox8.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox8.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox8.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox8.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox8.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox8.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox8.Image = Resources.UDDD;
                    break;
            }
            //p9
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox9.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox9.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox9.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox9.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox9.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox9.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox9.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox9.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox9.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox9.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox9.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox9.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox9.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox9.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox9.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox9.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox9.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox9.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox9.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox9.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox9.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox9.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox9.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox9.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox9.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox9.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox9.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox9.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox9.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox9.Image = Resources.UDDD;
                    break;
            }
            //p10
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox10.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox10.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox10.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox10.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox10.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox10.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox10.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox10.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox10.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox10.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox10.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox10.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox10.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox10.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox10.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox10.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox10.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox10.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox10.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox10.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox10.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox10.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox10.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox10.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox10.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox10.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox10.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox10.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox10.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox10.Image = Resources.UDDD;
                    break;
            }
            //p11
            switch (rnd.Next(30))
            {
                case 0:
                    pictureBox11.Image = Resources._2zFo;
                    break;
                case 1:
                    pictureBox11.Image = Resources.KMH1;
                    break;
                case 2:
                    pictureBox11.Image = Resources.S36A;
                    break;
                case 3:
                    pictureBox11.Image = Resources._7gnB;
                    break;
                case 4:
                    pictureBox11.Image = Resources.ApiG;
                    break;
                case 5:
                    pictureBox11.Image = Resources.QiTt;
                    break;
                case 6:
                    pictureBox11.Image = Resources.Hihj;
                    break;
                case 7:
                    pictureBox11.Image = Resources._6Jb2;
                    break;
                case 8:
                    pictureBox11.Image = Resources._5Vs;
                    break;
                case 9:
                    pictureBox11.Image = Resources.U57u;
                    break;
                case 10:
                    pictureBox11.Image = Resources._7SvD;
                    break;
                case 11:
                    pictureBox11.Image = Resources._7Sv5;
                    break;
                case 12:
                    pictureBox11.Image = Resources._7V0;
                    break;
                case 13:
                    pictureBox11.Image = Resources.D9FM;
                    break;
                case 14:
                    pictureBox11.Image = Resources.OSNw;
                    break;
                case 15:
                    pictureBox11.Image = Resources.Nbu5;
                    break;
                case 16:
                    pictureBox11.Image = Resources.G1JO;
                    break;
                case 17:
                    pictureBox11.Image = Resources.McDn;
                    break;
                case 18:
                    pictureBox11.Image = Resources._5j4F;
                    break;
                case 19:
                    pictureBox11.Image = Resources.J43I;
                    break;
                case 20:
                    pictureBox11.Image = Resources.VBuM;
                    break;
                case 21:
                    pictureBox11.Image = Resources._7o1u;
                    break;
                case 22:
                    pictureBox11.Image = Resources._298L;
                    break;
                case 23:
                    pictureBox11.Image = Resources._9ZFU;
                    break;
                case 24:
                    pictureBox11.Image = Resources._7U4;
                    break;
                case 25:
                    pictureBox11.Image = Resources.Dtph;
                    break;
                case 26:
                    pictureBox11.Image = Resources.WmD;
                    break;
                case 27:
                    pictureBox11.Image = Resources.BNW5;
                    break;
                case 28:
                    pictureBox11.Image = Resources.AksR;
                    break;
                case 29:
                    pictureBox11.Image = Resources.UDDD;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "YES")
            {
                button1.Text = "NO";

            }
            else if (button1.Text == "STOP")
            {
                this.Close();
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                button1.Size = new Size(191, 104);
                button1.Text = "STOP";

                button1.Location = new Point(12, 869);
                ActionTimer.Start();
            }
        }

        private void UndergroundForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
