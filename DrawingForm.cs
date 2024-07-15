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
    public partial class DrawingForm : Form
    {
        bool points = false;
        bool rectangles = false;
        bool lines = false;

        bool linesDraw = false;
        int lastX;
        int lastY;
        public DrawingForm()
        {
            InitializeComponent();
        }

        private void point_Click(object sender, EventArgs e)
        {
            point.BackColor = Color.Green;
            pencil.BackColor = Color.White;
            rectangle.BackColor = Color.White;

            points = true;
            rectangles = false;
            lines = false;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            point.BackColor = Color.White;
            pencil.BackColor = Color.White;
            rectangle.BackColor = Color.Green;

            points = false;
            rectangles = true;
            lines = false;
        }

        private void pencil_Click(object sender, EventArgs e)
        {
            point.BackColor = Color.White;
            pencil.BackColor = Color.Green;
            rectangle.BackColor = Color.White;

            points = false;
            rectangles = false;
            lines = true;
        }

        private void pictureBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            int penWidth = Convert.ToInt32(textBoxWidth.Text);
            Pen pen = new Pen(
                Color.FromArgb(
                    Convert.ToInt32(textColor1.Text),
                    Convert.ToInt32(textColor2.Text),
                    Convert.ToInt32(textColor3.Text)),
                penWidth);
            if (points)
                pictureBoxMain.CreateGraphics().FillEllipse(
                    pen.Brush,
                    e.X - penWidth / 2, e.Y - penWidth / 2,
                    penWidth, penWidth);
            else if (rectangles)
                pictureBoxMain.CreateGraphics().FillRectangle(
                    pen.Brush,
                    e.X - penWidth / 2, e.Y - penWidth / 2,
                    penWidth, penWidth);
            else if (lines)
            {
                if (!linesDraw)
                {
                    linesDraw = true;
                    lastX = e.X;
                    lastY = e.Y;
                }
                else
                    linesDraw = false;
            }
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(
                Color.FromArgb(
                    Convert.ToInt32(textColor1.Text),
                    Convert.ToInt32(textColor2.Text),
                    Convert.ToInt32(textColor3.Text)));
            if (linesDraw)
            {
                pictureBoxMain.CreateGraphics().DrawLine(
                    pen,
                    lastX, lastY,
                    e.X, e.Y);
                lastX = e.X;
                lastY = e.Y;
            } 
        }

        private void DrawingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
