
namespace Kasper_3._0
{
    partial class MusicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicForm));
            this.listBoxPlayList = new System.Windows.Forms.ListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SlVol = new MB.Controls.ColorSlider();
            this.SlTime = new MB.Controls.ColorSlider();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPlayList
            // 
            this.listBoxPlayList.BackColor = System.Drawing.Color.Black;
            this.listBoxPlayList.Font = new System.Drawing.Font("ISOCTEUR", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPlayList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBoxPlayList.FormattingEnabled = true;
            this.listBoxPlayList.ItemHeight = 19;
            this.listBoxPlayList.Location = new System.Drawing.Point(12, 12);
            this.listBoxPlayList.Name = "listBoxPlayList";
            this.listBoxPlayList.Size = new System.Drawing.Size(288, 213);
            this.listBoxPlayList.TabIndex = 6;
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackgroundImage = global::Kasper_3._0.Properties.Resources.menu_dots_vertical_free_icon_font;
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Location = new System.Drawing.Point(405, 300);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(30, 30);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::Kasper_3._0.Properties.Resources.stop_free_icon_font;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(48, 300);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(25, 28);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImage = global::Kasper_3._0.Properties.Resources.play_free_icon_font;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(12, 298);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(30, 30);
            this.buttonPlay.TabIndex = 7;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kasper_3._0.Properties.Resources._7VA;
            this.pictureBox1.Location = new System.Drawing.Point(254, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ISOCTEUR", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ISOCTEUR", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(220, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SlVol
            // 
            this.SlVol.BackColor = System.Drawing.Color.Transparent;
            this.SlVol.BarInnerColor = System.Drawing.Color.Indigo;
            this.SlVol.BarOuterColor = System.Drawing.Color.Indigo;
            this.SlVol.BarPenColor = System.Drawing.SystemColors.ControlText;
            this.SlVol.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SlVol.ElapsedInnerColor = System.Drawing.Color.Fuchsia;
            this.SlVol.ElapsedOuterColor = System.Drawing.Color.Fuchsia;
            this.SlVol.LargeChange = ((uint)(5u));
            this.SlVol.Location = new System.Drawing.Point(263, 262);
            this.SlVol.Maximum = 1000;
            this.SlVol.Name = "SlVol";
            this.SlVol.Size = new System.Drawing.Size(172, 30);
            this.SlVol.SmallChange = ((uint)(1u));
            this.SlVol.TabIndex = 11;
            this.SlVol.Text = "colorSlider1";
            this.SlVol.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.SlVol.Value = 100;
            this.SlVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlVol_Scroll);
            // 
            // SlTime
            // 
            this.SlTime.BackColor = System.Drawing.Color.Transparent;
            this.SlTime.BarInnerColor = System.Drawing.Color.Indigo;
            this.SlTime.BarOuterColor = System.Drawing.Color.Indigo;
            this.SlTime.BarPenColor = System.Drawing.SystemColors.ControlText;
            this.SlTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.SlTime.ElapsedInnerColor = System.Drawing.Color.Fuchsia;
            this.SlTime.ElapsedOuterColor = System.Drawing.Color.Fuchsia;
            this.SlTime.LargeChange = ((uint)(5u));
            this.SlTime.Location = new System.Drawing.Point(12, 262);
            this.SlTime.Name = "SlTime";
            this.SlTime.Size = new System.Drawing.Size(245, 30);
            this.SlTime.SmallChange = ((uint)(1u));
            this.SlTime.TabIndex = 10;
            this.SlTime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.SlTime.Value = 0;
            this.SlTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlTime_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("ISOCTEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(319, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(455, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SlVol);
            this.Controls.Add(this.SlTime);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxPlayList);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUSIC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MusicForm_FormClosed);
            this.Load += new System.EventHandler(this.MusicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxPlayList;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonOpen;
        private MB.Controls.ColorSlider SlTime;
        private MB.Controls.ColorSlider SlVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button button1;
    }
}