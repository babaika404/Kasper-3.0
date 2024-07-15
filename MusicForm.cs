using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kasper_3._0.cs;
using Kasper_3._0.Properties;

namespace Kasper_3._0
{
    public partial class MusicForm : Form
    {
        public MusicForm()
        {
            InitializeComponent();
        }

        private void buttonS1_Click(object sender, EventArgs e)
        {

        }

        private void MusicForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Vars.Files.Add(openFileDialog1.FileName);
            listBoxPlayList.Items.Add(Vars.GetFileName(openFileDialog1.FileName));
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if ((listBoxPlayList.Items.Count != 0) && (listBoxPlayList.SelectedIndex != -1)) 
            {
                string current = Vars.Files[listBoxPlayList.SelectedIndex];
                BassLike.Play(current, BassLike.Volume);
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                SlTime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                SlTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
            SlTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            BassLike.Stop();
            timer1.Enabled = false;
            SlTime.Value = 0;
            label1.Text = "00:00:00";
        }

        private void SlTime_Scroll(object sender, ScrollEventArgs e)
        {
            BassLike.SetPosOfScroll(BassLike.Stream, SlTime.Value);
        }

        private void SlVol_Scroll(object sender, ScrollEventArgs e)
        {
            BassLike.SetVolumeToStream(BassLike.Stream, SlVol.Value);
        }

        private void MusicForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BassLike.Stop();
            this.Close();
        }
    }
}
