
namespace Kasper_3._0
{
    partial class DrawingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pencil = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textColor2 = new System.Windows.Forms.TextBox();
            this.textColor3 = new System.Windows.Forms.TextBox();
            this.textColor1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pencil);
            this.groupBox1.Controls.Add(this.rectangle);
            this.groupBox1.Controls.Add(this.point);
            this.groupBox1.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tools";
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.Color.White;
            this.pencil.ForeColor = System.Drawing.Color.Black;
            this.pencil.Location = new System.Drawing.Point(245, 29);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(108, 36);
            this.pencil.TabIndex = 3;
            this.pencil.Text = "pencil";
            this.pencil.UseVisualStyleBackColor = false;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rectangle.Location = new System.Drawing.Point(87, 29);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(152, 36);
            this.rectangle.TabIndex = 2;
            this.rectangle.Text = "rectangle";
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.White;
            this.point.ForeColor = System.Drawing.SystemColors.ControlText;
            this.point.Location = new System.Drawing.Point(6, 29);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 36);
            this.point.TabIndex = 1;
            this.point.Text = "points";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textColor2);
            this.groupBox2.Controls.Add(this.textColor3);
            this.groupBox2.Controls.Add(this.textColor1);
            this.groupBox2.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "color";
            // 
            // textColor2
            // 
            this.textColor2.Location = new System.Drawing.Point(62, 32);
            this.textColor2.Name = "textColor2";
            this.textColor2.Size = new System.Drawing.Size(50, 33);
            this.textColor2.TabIndex = 4;
            this.textColor2.Text = "0";
            // 
            // textColor3
            // 
            this.textColor3.ForeColor = System.Drawing.Color.Black;
            this.textColor3.Location = new System.Drawing.Point(119, 32);
            this.textColor3.Name = "textColor3";
            this.textColor3.Size = new System.Drawing.Size(50, 33);
            this.textColor3.TabIndex = 3;
            this.textColor3.Text = "0";
            // 
            // textColor1
            // 
            this.textColor1.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textColor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textColor1.Location = new System.Drawing.Point(6, 32);
            this.textColor1.Name = "textColor1";
            this.textColor1.Size = new System.Drawing.Size(50, 33);
            this.textColor1.TabIndex = 2;
            this.textColor1.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxWidth);
            this.groupBox3.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(193, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 71);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "width";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(6, 32);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(94, 33);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.Text = "0";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 166);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(556, 394);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("ISOCTEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(382, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(580, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrawingForm";
            this.Text = "DRAWING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrawingForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxMain;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button pencil;
        public System.Windows.Forms.Button rectangle;
        public System.Windows.Forms.Button point;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textColor2;
        public System.Windows.Forms.TextBox textColor3;
        public System.Windows.Forms.TextBox textColor1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textBoxWidth;
        public System.Windows.Forms.Button button1;
    }
}