using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kasper_3._0.Properties;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Kasper_3._0
{
    public partial class MainForm : Form
    {
        Timer KasperActionTimer = new Timer();
        Timer TimeTimer = new Timer();
        
        Timer UpdateTimer = new Timer();
        Timer UpdateLevels = new Timer();
        Timer KasperWarning = new Timer();
        int i = 0;
        int indexColor = 0;

        int Food = 100;
        int Mood = 50;
        int Sleep = 50;
        int Work = 50;
        int Agressive = 30;
        int Health = 100;

        bool flagAction = true;
        public bool EngLangue = false;

        UndergroundForm formUnd;
        MusicForm formMus;
        DrawingForm formDra;
        TrainForm formTra;

        Random rnd = new Random();

        public class MyListBoxItem
        {
            public Color ForeColor { get; set; }
            public Color BackColor { get; set; }
            public string Text { get; set; }

            public MyListBoxItem(Color foreColor, Color backColor, string text)
            {
                ForeColor = foreColor;
                Text = text;
                BackColor = backColor;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            KasperActionTimer.Interval = 100;
            KasperActionTimer.Tick += KasperActionTimerTick;
            TimeTimer.Interval = 100;
            TimeTimer.Tick += TimeTick;

            
            UpdateTimer.Interval = 100;
            UpdateLevels.Interval = 10000;
            KasperWarning.Interval = 10000;

            KasperWarning.Tick += KasperWarning_Tick;
            UpdateLevels.Tick += UpdateLevels_Tick;
            UpdateTimer.Tick += UpdateTimer_Tick; 
        }

        private void KasperWarning_Tick(object sender, EventArgs e)
        {
            if (EngLangue == false) 
            {
                if (Food > 25)
                {
                    labelKasperSp.Text = "я хочу есть";
                }
                if (Mood > 60)
                {
                    labelKasperSp.Text = "слишком скучная атмосфера";
                }
                if (Sleep < 40)
                {
                    labelKasperSp.Text = "я хочу спать";
                }

                if (Agressive > 50)
                {
                    switch (rnd.Next(2))
                    {
                        case 0:
                            labelKasperSp.Text = "я не хочу работать с тобой.";
                            break;
                        case 1:
                            labelKasperSp.Text = ".";
                            break;
                    }
                }
                if (Health < 25)
                {
                    labelKasperSp.Text = "ты разбил мне сердце";
                }
            }
        }

        private void UpdateLevels_Tick(object sender, EventArgs e)
        {
            Health -= 1;
            Agressive += 1;
            Work -= 10;
            Sleep -= 15;
            Mood -= 10;
            Food += 10;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (EngLangue)
            {
                labelFood.Text = "Hunger: " + Food;
                labelHealth.Text = "Health: " + Health;
                labelAgressive.Text = "Agressive: " + Agressive;
                labelWork.Text = "Desire to work: " + Work;
                labelSleep.Text = "Sleep: " + Sleep;
                labelMood.Text = "Boredom: " + Mood;

            }
            else
            {
                labelFood.Text = "Голод: " + Food;
                labelHealth.Text = "Здоровье: " + Health;
                labelAgressive.Text = "Агрессия: " + Agressive;
                labelWork.Text = "Желание работать: " + Work;
                labelSleep.Text = "Сон: " + Sleep;
                labelMood.Text = "Скука: " + Mood;
            }
        }

        private void TimeTick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void KasperActionTimerTick(object sender, EventArgs e)
        {
            
            switch (i) {
                case 0:
                    pictureBoxKasperImage.Image = Resources._0;
                    flagAction = true;
                    break;
                case 1:
                    pictureBoxKasperImage.Image = Resources._1;
                    break;
                case 2:
                    pictureBoxKasperImage.Image = Resources._2;
                    break;
                case 3:
                    pictureBoxKasperImage.Image = Resources._3;
                    break;
                case 4:
                    pictureBoxKasperImage.Image = Resources._4;
                    break;
                case 5:
                    pictureBoxKasperImage.Image = Resources._5;
                    break;
                case 6:
                    pictureBoxKasperImage.Image = Resources._6;
                    break;
                case 7:
                    pictureBoxKasperImage.Image = Resources._7;
                    break;
                case 8:
                    pictureBoxKasperImage.Image = Resources._8;
                    break;
                case 9:
                    pictureBoxKasperImage.Image = Resources._9;
                    break;
                default:
                    pictureBoxKasperImage.Image = Resources._10;
                    i = 10;
                    flagAction = false;
                    break;
            }
            if (flagAction)
            {
                i++;
            }
            else 
            {
                i--;
            }
            
        }

        private void labelKasperSp_Click(object sender, EventArgs e)
        {
            if (KasperActionTimer.Enabled == true)
            {
                KasperActionTimer.Stop();
                pictureBoxKasperImage.Image = Resources._0;
            }
            else 
            {  
                KasperActionTimer.Start();
            }
        }

        private void buttonMusic_Click(object sender, EventArgs  e)
        {
            Mood -= 25;
            Sleep -= 10;
            Work += 10;
            Agressive -= 15;

            formMus = new MusicForm();
            formMus.FormClosed += formMus_FormClosed;
            formMus.Show();
            buttonMusic.Enabled = false;
            pictureBoxKasperImage.Image = Resources._2zFo;
        }

        private void formMus_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonMusic.Enabled = true;
            pictureBoxKasperImage.Image = Resources._0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDrawing_Click(object sender, EventArgs e)
        {
            Food += 5;
            Mood -= 15;
            Sleep -= 10;
            Agressive -= 15;
            
            formDra = new DrawingForm();
            formDra.FormClosed += formDra_FormClosed;
            formDra.Show();
            buttonDrawing.Enabled = false;
        }

        private void formDra_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonDrawing.Enabled = true; 
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            if (labelTime.Visible == true)
            {
                TimeTimer.Stop();
                labelTime.Visible = false;
            }
            else 
            {
                TimeTimer.Start();
                labelTime.Visible = true;
            }
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //listBoxPlan.Items.Add(textBoxPlan.Text + " " + );
            if (e.Start.ToShortDateString() == e.End.ToShortDateString())
            {
                listBoxPlan.Items.Add(new MyListBoxItem(listBoxPlan.ForeColor, Color.Blue, e.Start.ToShortDateString() + " - " + textBoxPlan.Text + " " + textBoxTime.Text));
                //this.listBoxPlan.Items.Add(e.Start.ToShortDateString() + " - " + textBoxPlan.Text + " " + textBoxTime.Text);
            }
            else 
            {
                if (EngLangue)
                {
                    //this.listBoxPlan.Items.Add("from " + e.Start.ToShortDateString() + " to " + e.End.ToShortDateString() + " - " + textBoxPlan.Text + " " + textBoxTime.Text);
                    listBoxPlan.Items.Add(new MyListBoxItem(listBoxPlan.ForeColor, Color.Blue, "from " + e.Start.ToShortDateString() + " to " + e.End.ToShortDateString() + " - " + textBoxPlan.Text + " " + textBoxTime.Text));
                }
                else 
                {
                    //this.listBoxPlan.Items.Add("c " + e.Start.ToShortDateString() + " по " + e.End.ToShortDateString() + " - " + textBoxPlan.Text + " " + textBoxTime.Text);
                    listBoxPlan.Items.Add(new MyListBoxItem(listBoxPlan.ForeColor, Color.Blue, "с " + e.Start.ToShortDateString() + " по " + e.End.ToShortDateString() + " - " + textBoxPlan.Text + " " + textBoxTime.Text));

                }
            }
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            if (groupBoxPlan.Visible == true)
            {
                groupBoxPlan.Visible = false;
                monthCalendar1.Visible = false;
            }
            else 
            {
                groupBoxPlan.Visible = true;
                monthCalendar1.Visible = true;
            }
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxPlan.Items.Remove(listBoxPlan.Items[listBoxPlan.SelectedIndex]);
        }

        private void buttonFastAct_Click(object sender, EventArgs e)
        {
            //Rectangle rc = listBoxPlan.GetItemRectangle(listBoxPlan.SelectedIndex);
            //LinearGradientBrush brush = new LinearGradientBrush(
            //    rc, Color.Transparent, Color.Red, LinearGradientMode.ForwardDiagonal);
            //Graphics g = Graphics.FromHwnd(listBoxPlan.Handle);

            //g.FillRectangle(brush, rc);
            //listBoxPlan.DrawMode = DrawMode.OwnerDrawFixed;
            //listBoxPlan.DrawItem += listBoxPlan_DrawItem;
            ((MyListBoxItem)listBoxPlan.SelectedItem).ForeColor = Color.HotPink;
            //listBoxPlan.ForeColor = Color.HotPink;

        }

        private void listBoxPlan_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index == -1)
                return;
            var item = (MyListBoxItem)listBoxPlan.Items[e.Index];
            e.Graphics.DrawString(
                item.Text,
                listBoxPlan.Font,
                new SolidBrush(item.ForeColor),
                0,
                e.Index * listBoxPlan.ItemHeight);
            //Graphics g = e.Graphics;
            //g.FillRectangle(new SolidBrush(Color.Black), e.Bounds);
            //ListBox lb = (ListBox)sender;
            //g.DrawString(lb.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Plum), new PointF(e.Bounds.X, e.Bounds.Y));

            //e.DrawFocusRectangle();
        }

        private void buttonNotFastAct_Click(object sender, EventArgs e)
        {
            //listBoxPlan.ForeColor = Color.Plum;
            ((MyListBoxItem)listBoxPlan.SelectedItem).ForeColor = Color.Plum;

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            //listBoxPlan.ForeColor = Color.Gray;
            ((MyListBoxItem)listBoxPlan.SelectedItem).ForeColor = Color.Gray;

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonUnderground_Click(object sender, EventArgs e)
        {
            Food += 5;
            Mood -= 50;
            Sleep -= 50;
            Agressive += 15;
            Health -= 15; 
            formUnd = new UndergroundForm();
            formUnd.FormClosed += formUnd_FormClosed;
            formUnd.Show();
            buttonUnderground.Enabled = false;
            
        }

        private void formUnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonUnderground.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBoxSettings.Visible == true)
            {
                groupBoxSettings.Enabled = false;
                groupBoxSettings.Visible = false;
            }
            else 
            {
                groupBoxSettings.Enabled = true;
                groupBoxSettings.Visible = true;
            }
        }

        private void buttonNextSett_Click(object sender, EventArgs e)
        {
            indexColor++;
            switch (indexColor) 
            {
                case 1:
                    pictureBoxColorSettings.BackColor = Color.DarkSlateGray;
                    break;
                case 2:
                    pictureBoxColorSettings.BackColor = Color.MidnightBlue;
                    break;
                case 3:
                    pictureBoxColorSettings.BackColor = Color.SlateGray;
                    break;
                case 4:
                    pictureBoxColorSettings.BackColor = Color.DarkSlateBlue;
                    break;
                default:
                    pictureBoxColorSettings.BackColor = Color.Black;
                    indexColor = 0;
                    break;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            switch (indexColor)
            {
                case 1:
                    this.BackColor = Color.DarkSlateGray;
                    break;
                case 2:
                    this.BackColor = Color.MidnightBlue;
                    break;
                case 3:
                    this.BackColor = Color.SlateGray;
                    break;
                case 4:
                    this.BackColor = Color.DarkSlateBlue;
                    break;
                default:
                    this.BackColor = Color.Black;
                    indexColor = 0;
                    break;
            }
        }

        private void buttonSpeach_Click(object sender, EventArgs e)
        {
            if (buttonOkUserText.Visible == true)
            {
                buttonOkUserText.Visible = false;
                buttonOkUserText.Enabled = false;
                textBoxUserSpeach.Visible = false;
                textBoxUserSpeach.Enabled = false;
            }
            else 
            {
                buttonOkUserText.Visible = true;
                buttonOkUserText.Enabled = true;
                textBoxUserSpeach.Visible = true;
                textBoxUserSpeach.Enabled = true;
            }
        }

        private void buttonOkUserText_Click(object sender, EventArgs e)
        {
            if (EngLangue)
            {
                if (textBoxUserSpeach.Text == "Plan" || textBoxUserSpeach.Text == "plan" )
                {
                    labelKasperSp.Text = "your plan: ";
                    groupBoxPlan.Visible = true;
                    groupBoxPlan.Enabled = true;
                }
                if (textBoxUserSpeach.Text == "hide plan" || textBoxUserSpeach.Text == "Hide plan")
                {
                    labelKasperSp.Text = "the schedule is hidden";
                    groupBoxPlan.Visible = false;
                    groupBoxPlan.Enabled = false;
                }
                if (textBoxUserSpeach.Text == "time" || textBoxUserSpeach.Text == "Time")
                {
                    labelKasperSp.Text = "now: " + DateTime.Now.ToString("HH:mm:ss");
                }
                if (textBoxUserSpeach.Text == "Dance" || textBoxUserSpeach.Text == "dance")
                {
                    labelKasperSp.Text = "ok.";
                    KasperActionTimer.Start();
                }
                if (textBoxUserSpeach.Text == "Settings" || textBoxUserSpeach.Text == "settings")
                {
                    labelKasperSp.Text = "now you can change the settings";
                    groupBoxSettings.Enabled = true;
                    groupBoxSettings.Visible = true;
                }
                if (textBoxUserSpeach.Text == "Hide settings" || textBoxUserSpeach.Text == "hide settings")
                {
                    labelKasperSp.Text = "оk...";
                    groupBoxSettings.Enabled = false;
                    groupBoxSettings.Visible = false;
                }
                if (textBoxUserSpeach.Text == "how are you" || textBoxUserSpeach.Text == "How are you" || textBoxUserSpeach.Text == "how are you?" || textBoxUserSpeach.Text == "How are you?")
                {
                    switch (rnd.Next(5))
                    {
                        case 1:
                            labelKasperSp.Text = "I'm " + rnd.Next(101) + "% satisfied with life";
                            break;
                        case 2:
                            labelKasperSp.Text = "I'm " + rnd.Next(101) + "% tired";
                            break;
                        case 3:
                            labelKasperSp.Text = "So happy I'm ready to dance";
                            KasperActionTimer.Start();
                            break;
                        case 4:
                            labelKasperSp.Text = "I don't like you " + rnd.Next(101) + "%";
                            break;
                        default:
                            labelKasperSp.Text = "I like you " + rnd.Next(101) + "%";
                            break;
                    }
                }
                if (textBoxUserSpeach.Text == "hello" || textBoxUserSpeach.Text == "Hello")
                {
                    switch (rnd.Next(5))
                    {
                        case 1:
                            labelKasperSp.Text = "good morning";
                            break;
                        case 2:
                            labelKasperSp.Text = "рад вас видеть";
                            break;
                        case 3:
                            labelKasperSp.Text = "I'm not very glad to see you";
                            break;
                        default:
                            labelKasperSp.Text = "I like you on " + rnd.Next(101) + "%";
                            break;
                    }
                }
            }
            else 
            {
                if (textBoxUserSpeach.Text == "План" || textBoxUserSpeach.Text == "план" || textBoxUserSpeach.Text == "мне нужен план" || textBoxUserSpeach.Text == "Мне нужен план" ||
                    textBoxUserSpeach.Text == "покажи план" || textBoxUserSpeach.Text == "Покажи план" || textBoxUserSpeach.Text == "ежедневник" || textBoxUserSpeach.Text == "Ежедневник")
                {
                    labelKasperSp.Text = "ваше расписание";
                    groupBoxPlan.Visible = true;
                    groupBoxPlan.Enabled = true;
                }
                if (textBoxUserSpeach.Text == "убери план" || textBoxUserSpeach.Text == "Убери план" || textBoxUserSpeach.Text == "спрячь план" || textBoxUserSpeach.Text == "Спрячь план")
                {
                    labelKasperSp.Text = "расписание спрятано";
                    groupBoxPlan.Visible = false;
                    groupBoxPlan.Enabled = false;
                }
                if (textBoxUserSpeach.Text == "время" || textBoxUserSpeach.Text == "Время" || textBoxUserSpeach.Text == "сколько время" || textBoxUserSpeach.Text == "Сколько время" ||
                    textBoxUserSpeach.Text == "сколько время?" || textBoxUserSpeach.Text == "Сколько время?" ||
                    textBoxUserSpeach.Text == "который час" || textBoxUserSpeach.Text == "Который час" || textBoxUserSpeach.Text == "который час?" || textBoxUserSpeach.Text == "Который час?")
                {
                    labelKasperSp.Text = "сейчас: " + DateTime.Now.ToString("HH:mm:ss");
                }
                if (textBoxUserSpeach.Text == "Танцуй" || textBoxUserSpeach.Text == "танцуй" || textBoxUserSpeach.Text == "станцуй для меня" || textBoxUserSpeach.Text == "Станцуй для меня")
                {
                    labelKasperSp.Text = "ладно.";
                    KasperActionTimer.Start();
                }
                if (textBoxUserSpeach.Text == "настройки" || textBoxUserSpeach.Text == "Настройки")
                {
                    labelKasperSp.Text = "ок.";
                    groupBoxSettings.Enabled = true;
                    groupBoxSettings.Visible = true;
                }
                if (textBoxUserSpeach.Text == "Спрячь настройки" || textBoxUserSpeach.Text == "спрячь настройки" || textBoxUserSpeach.Text == "Убери настройки" || textBoxUserSpeach.Text == "убери настройки")
                {
                    labelKasperSp.Text = "ок...";
                    groupBoxSettings.Enabled = false;
                    groupBoxSettings.Visible = false;
                }
                if (textBoxUserSpeach.Text == "как дела" || textBoxUserSpeach.Text == "Как дела" || textBoxUserSpeach.Text == "как дела?" || textBoxUserSpeach.Text == "Как дела?")
                {
                    switch (rnd.Next(5))
                    {
                        case 1:
                            labelKasperSp.Text = "я на " + rnd.Next(101) + "% доволен жизнью";
                            break;
                        case 2:
                            labelKasperSp.Text = "я на " + rnd.Next(101) + "% устал";
                            break;
                        case 3:
                            labelKasperSp.Text = "так счастлив, что готов танцевать";
                            KasperActionTimer.Start();
                            break;
                        case 4:
                            labelKasperSp.Text = "ты мне на " + rnd.Next(101) + "% не нравишься";
                            break;
                        default:
                            labelKasperSp.Text = "ты мне на " + rnd.Next(101) + "% нравишься";
                            break;
                    }
                }
                if (textBoxUserSpeach.Text == "привет" || textBoxUserSpeach.Text == "Привет" || textBoxUserSpeach.Text == "привет!" || textBoxUserSpeach.Text == "Привет!")
                {
                    switch (rnd.Next(5))
                    {
                        case 1:
                            labelKasperSp.Text = "доброе утро";
                            break;
                        case 2:
                            labelKasperSp.Text = "рад вас видеть";
                            break;
                        case 3:
                            labelKasperSp.Text = "не очень рад вас видеть";
                            break;
                        default:
                            labelKasperSp.Text = "ты мне на " + rnd.Next(101) + "% нравишься";
                            break;
                    }
                }

            }
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            if (groupBoxHelp.Visible == true)
            {
                groupBoxHelp.Visible = false;
                groupBoxHelp.Enabled = false;
                groupBoxHelp.Visible = false;
                groupBoxHelp.Enabled = false;
            }
            else
            {
                groupBoxHelp.Visible = true;
                groupBoxHelp.Enabled = true;
                groupBoxHelp.Visible = true;
                groupBoxHelp.Enabled = true;
            }
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            Food += 5;
            Mood += 5;
            Sleep -= 10;
            Work -= 10;
            Agressive += 15;
            Health += 15; 
            
            formTra = new TrainForm();
            formTra.FormClosed += formTra_FormClosed;
            formTra.Show();
            buttonTrain.Enabled = false;
        }

        private void formTra_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonTrain.Enabled = true;
        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonColors_Click(object sender, EventArgs e)
        {

        }

        private void buttonWeather_Click(object sender, EventArgs e)
        {
            if (groupBoxWeather.Visible == true)
            {
                groupBoxWeather.Visible = false;
                groupBoxWeather.Enabled = false;
            }
            else
            {
                groupBoxWeather.Visible = true;
                groupBoxWeather.Enabled = true;
            }
        }

        private void buttonNextTown_Click(object sender, EventArgs e)
        {
            if (label4.Text == "MOSCOW" || label4.Text == "МОСКВА")
            {
                if (EngLangue)
                {
                    groupBox2.Text = "Wind";
                    buttonNextTown.Text = "next";
                    label4.Text = "GELENDZIK";
                    label2.Text = "+20°C";
                    label1.Text = "Clear weather";
                    label3.Text = "Pressure: 752 mmHg.";
                    label5.Text = "Sunrise: 4:48 Sunset: 20:01";
                    label6.Text = "Speed: 1.7 m/s";
                    label17.Text = "Waning moon";
                    label7.Text = "Direction: West";
                    panel1.BackgroundImage = Resources._02d;
                }
                else
                {
                    groupBox2.Text = "Ветер";
                    buttonNextTown.Text = "далее";
                    label4.Text = "ГЕЛЕНДЖИК";
                    label2.Text = "+20°C";
                    label1.Text = "Ясно";
                    label3.Text = "Давление: 752 мм.рт.ст.";
                    label5.Text = "Восход: 4:48 Закат: 20:01";
                    label6.Text = "Скорость: 1,7 м/с";
                    label7.Text = "Направление: Запад";
                    label17.Text = "Убывающая луна";
                    panel1.BackgroundImage = Resources._02d;
                }
            }
            else 
            {
                if (EngLangue)
                {
                    groupBox2.Text = "Wind";
                    buttonNextTown.Text = "next";
                    label4.Text = "MOSCOW";
                    label2.Text = "+11°C";
                    label1.Text = "Showers";
                    label3.Text = "Pressure: 735 mmHg.";
                    label5.Text = "Sunrise: 3:58 Sunset: 20:55";
                    label6.Text = "Speed: 7.1 m/s";
                    label17.Text = "Waning moon";
                    label7.Text = "Direction: West";
                    panel1.BackgroundImage = Resources._10d;
                }
                else
                {
                    groupBox2.Text = "Ветер";
                    buttonNextTown.Text = "далее";
                    label4.Text = "МОСКВА";
                    label2.Text = "+11°C";
                    label1.Text = "Ливни";
                    label3.Text = "Давление: 735 мм.рт.ст.";
                    label5.Text = "Восход: 3:58 Закат: 20:55";
                    label6.Text = "Скорость: 7,1 м/с";
                    label17.Text = "Убывающая луна";
                    label7.Text = "Направление: Запад";
                    panel1.BackgroundImage = Resources._10d;
                }
            }
        }

        private void buttonLangue_Click(object sender, EventArgs e)
        {
            if (EngLangue == false)
            {
                EngLangue = true;
                groupBoxWeather.Text = "Weather";
                groupBoxMenu.Text = "Main Menu";
                groupBoxSettings.Text = "Settings";
                groupBoxHelp.Text = "Help";
                groupBoxPlan.Text = "Daily planner";
                groupBoxKasperAction.Text = "Interactions with Kasper";

                buttonMusic.Text = "Music";
                buttonDrawing.Text = "Drawing";
                buttonTrain.Text = "Trainer";
                buttonUnderground.Text = "Underground";
                buttonPlan.Text = "Plan";
                buttonTime.Text = "Time";
                buttonSpeach.Text = "Conversation";
                buttonWeather.Text = "Weather";
                buttonOkUserText.Text = "ok";
                buttonNextSett.Text = "next";
                buttonOK.Text = "ok";
                buttonLangue.Text = "Rus";
                buttonHelp.Text = "Help";
                button2.Text = "Settings";
                buttonExit.Text = "EXIT";
                button1.Text = "delete an event";
                buttonNotFastAct.Text = "non-urgent event";
                buttonFastAct.Text = "urgent event";
                buttonFinish.Text = "executed event";
                buttonAction.Text = "Action";

                labelKasperSp.Text = "English is installed";
                label11.Text = "Time for the event:";
                label15.Text = "How are you - An interaction option. " +
                    "Dance - A variant of interaction. " +
                    "Time - Kasper will display the time. " +
                    "Plan - Kasper will bring out a group to interact with the schedule. " +
                    "Settings - Kasper will display a group to interact with the form settings. " +
                    "Hide (what?) - Kasper will remove the announced group. ";
                
                labelFood.Text = "Hunger: " + Food;
                labelHealth.Text = "Health: " + Health;
                labelAgressive.Text = "Agressive: " + Agressive;
                labelWork.Text = "Desire to work: " + Work;
                labelSleep.Text = "Sleep: " + Sleep;
                labelMood.Text = "Boredom: " + Mood;

                buttonFood.Text = "feed";
                buttonSleep.Text = "sleep";
                buttonPraise.Text = "praise";
                buttonRespect.Text = "respect";
                buttonLove.Text = "love";
                //Music
                //formMus = new MusicForm();
                //formMus.button1.Text = "back";
                //Drawings
                //formDra = new DrawingForm();
                //formDra.groupBox1.Text = "tools";
                //formDra.point.Text = "point";
                //formDra.rectangle.Text = "rectangle";
                //formDra.pencil.Text = "pencil";
                //formDra.button1.Text = "back";
                //formDra.groupBox2.Text = "color";
                //formDra.groupBox3.Text = "width";
                //Train
                //formTra = new TrainForm();
                //formTra.buttonStart.Text = "START";
                //formTra.buttonBack.Text = "BACK";
                //formTra.labelMistake.Text = "ERROR";
                //Underground
                //formUnd = new UndergroundForm();
                //formUnd.button1.Text = "YES";


                if (label4.Text == "ГЕЛЕНДЖИК" || label4.Text == "GELENDZIK")
                {
                    groupBox2.Text = "Wind";
                    buttonNextTown.Text = "next";
                    label4.Text = "GELENDZIK";
                    label2.Text = "+20°C";
                    label1.Text = "Clear weather";
                    label3.Text = "Pressure: 752 mmHg.";
                    label5.Text = "Sunrise: 4:48 Sunset: 20:01";
                    label6.Text = "Speed: 1.7 m/s";
                    label17.Text = "Waning moon";
                    label7.Text = "Direction: West";
                    panel1.BackgroundImage = Resources._02d;
                }
                else 
                {
                    groupBox2.Text = "Wind";
                    buttonNextTown.Text = "next";
                    label4.Text = "MOSCOW";
                    label2.Text = "+11°C";
                    label1.Text = "Showers";
                    label3.Text = "Pressure: 735 mmHg.";
                    label5.Text = "Sunrise: 3:58 Sunset: 20:55";
                    label6.Text = "Speed: 7.1 m/s";
                    label17.Text = "Waning moon";
                    label7.Text = "Direction: West";
                    panel1.BackgroundImage = Resources._10d;
                }
            }
            else 
            {
                EngLangue = false;
                groupBoxWeather.Text = "Погода";
                groupBoxMenu.Text = "Главное меню";
                groupBoxSettings.Text = "Настройки";
                groupBoxHelp.Text = "Помощь";
                groupBoxPlan.Text = "Ежедневник";
                groupBoxKasperAction.Text = "Взаимодействия с Каспером";

                buttonMusic.Text = "Музыка";
                buttonDrawing.Text = "Рисование";
                buttonTrain.Text = "Тренажёр";
                buttonUnderground.Text = "Андеграунд";
                buttonPlan.Text = "План";
                buttonTime.Text = "Время";
                buttonSpeach.Text = "Разговор";
                buttonWeather.Text = "Погода";
                buttonOkUserText.Text = "ок";
                buttonNextSett.Text = "далее";
                buttonOK.Text = "ок";
                buttonLangue.Text = "Eng";
                buttonHelp.Text = "Помощь";
                button2.Text = "Настройки";
                buttonExit.Text = "ВЫХОД";
                button1.Text = "удалить событие";
                buttonNotFastAct.Text = "не срочное событие";
                buttonFastAct.Text = "срочное событие";
                buttonFinish.Text = "выполненное событие";
                buttonAction.Text = "Действия";

                labelKasperSp.Text = "установлен русский язык";
                label11.Text = "Время для события:";
                label15.Text = "Как дела - Вариант взаимодействия. " +
                    "Танцуй - Вариант взаимодействия. " +
                    "Время - Каспер выведет время. " +
                    "План - Каспер выведет группу для взаимодействия с расписанием. " +
                    "Настройки - Каспер выведет группу для взаимодействия с настройками формы. " +
                    "Спрячь/убери(что ?) - Каспер уберёт обьявленную группу.";

                
                labelFood.Text = "Голод: " + Food;
                labelHealth.Text = "Здоровье: " + Health;
                labelAgressive.Text = "Агрессия: " + Agressive;
                labelWork.Text = "Желание работать: " + Work;
                labelSleep.Text = "Сон: " + Sleep;
                labelMood.Text = "Скука: " + Mood;

                buttonFood.Text = "кормить";
                buttonSleep.Text = "спать";
                buttonPraise.Text = "хвалить";
                buttonRespect.Text = "уважать";
                buttonLove.Text = "любить";
                //Music
                //formMus = new MusicForm();
                //formMus.button1.Text = "назад";
                //Drawings
                //formDra = new DrawingForm();
                //formDra.groupBox1.Text = "инструменты";
                //formDra.point.Text = "точки";
                //formDra.rectangle.Text = "прямоугольники";
                //formDra.pencil.Text = "карандаш";
                //formDra.button1.Text = "назад";
                //formDra.groupBox2.Text = "цвет";
                //formDra.groupBox3.Text = "толщина";
                //Train
                //formTra = new TrainForm();
                //formTra.buttonStart.Text = "СТАРТ";
                //formTra.buttonBack.Text = "НАЗАД";
                //formTra.labelMistake.Text = "ОШИБКА";
                //Underground
                //formUnd = new UndergroundForm();
                //formUnd.button1.Text = "ДА";

                if (label4.Text == "ГЕЛЕНДЖИК" || label4.Text == "GELENDZIK")
                {
                    groupBox2.Text = "Ветер";
                    buttonNextTown.Text = "далее";
                    label4.Text = "ГЕЛЕНДЖИК";
                    label2.Text = "+20°C";
                    label1.Text = "Ясно";
                    label3.Text = "Давление: 752 мм.рт.ст.";
                    label5.Text = "Восход: 4:48 Закат: 20:01";
                    label6.Text = "Скорость: 1,7 м/с";
                    label7.Text = "Направление: Запад";
                    label17.Text = "Убывающая луна";
                    panel1.BackgroundImage = Resources._02d;
                }
                else
                {
                    groupBox2.Text = "Ветер";
                    buttonNextTown.Text = "далее";
                    label4.Text = "МОСКВА";
                    label2.Text = "+11°C";
                    label1.Text = "Ливни";
                    label3.Text = "Давление: 735 мм.рт.ст.";
                    label5.Text = "Восход: 3:58 Закат: 20:55";
                    label6.Text = "Скорость: 7,1 м/с";
                    label17.Text = "Убывающая луна";
                    label7.Text = "Направление: Запад";
                    panel1.BackgroundImage = Resources._10d;
                }
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            UpdateTimer.Start();
            UpdateLevels.Start();
            if (groupBoxKasperAction.Visible == true)
            {
                groupBoxKasperAction.Visible = false;
                groupBoxKasperAction.Enabled = false;
            }
            else
            {
                groupBoxKasperAction.Visible = true;
                groupBoxKasperAction.Enabled = true;
            }

        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            Food -= 50;
            Mood -= 5;
            Sleep -= 10;
            Work -= 10;
            Agressive -= 15;
            Health += 15;
        }

        private void buttonLove_Click(object sender, EventArgs e)
        {
            Mood += 25;
            Work += 10;
            Agressive -= 25;
            Health += 10;
        }

        private void buttonRespect_Click(object sender, EventArgs e)
        {
            Mood += 25;
            Work -= 10;
            Agressive -= 15;
            Health += 15;
        }

        private void buttonPraise_Click(object sender, EventArgs e)
        {
            Mood -= 50;
            Sleep += 15;
            Work += 50;
            Agressive -= 25;
            Health += 25;
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            Food += 50;
            Mood -= 25;
            Sleep += 70;
            Work -= 25;
            Health += 25;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBoxUserSpeach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
