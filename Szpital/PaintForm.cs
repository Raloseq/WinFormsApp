using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szpital.Custom.Forms;

namespace Szpital
{
    public partial class PaintForm : BaseForm
    {
        Pen pen = new Pen(Color.Black);
        bool isChecked = false;
        int width = 5;
        int x = 0;
        int y = 0;
        public PaintForm()
        {
            InitializeComponent();
        }

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = paintPanel.CreateGraphics();
            g.DrawEllipse(pen, x, y, width, width);
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                paintPanel_Paint(this, null);
            }
        }

        private void paintButton1_Click(object sender, EventArgs e)
        {
            if(isChecked)
            {
                paintPanel.BackColor = paintButton1.BackColor;
            }
            pen = new Pen(paintButton1.BackColor);
        }

        private void paintButton2_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                paintPanel.BackColor = paintButton2.BackColor;
            }
            pen = new Pen(paintButton2.BackColor);
        }

        private void paintButton3_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                paintPanel.BackColor = paintButton3.BackColor;
            }
            pen = new Pen(paintButton3.BackColor);
        }

        private void paintButton4_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                paintPanel.BackColor = paintButton4.BackColor;
            }
            pen = new Pen(paintButton4.BackColor);
        }

        private void paintButton5_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                paintPanel.BackColor = paintButton5.BackColor;
            }
            pen = new Pen(paintButton5.BackColor);
        }

        private void paintButton6_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                paintPanel.BackColor = paintButton6.BackColor;
            }
            pen = new Pen(paintButton6.BackColor);
        }

        private void paintButton7_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                paintPanel.BackColor = paintButton7.BackColor;
            }
            pen = new Pen(paintButton7.BackColor);
        }

        private void paintTrackBar_SizeChanged(object sender, EventArgs e)
        {
            width = paintTrackBar.Value;
        }

        private void paintTrackBar_Scroll(object sender, EventArgs e)
        {
            trackBarValue1.Text = paintTrackBar.Value.ToString();
            width = paintTrackBar.Value;
        }

        private void fillPaint_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = fillPaint.Checked;
        }
    }
}
