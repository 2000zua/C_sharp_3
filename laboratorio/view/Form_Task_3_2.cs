using System;
using System.Drawing;
using System.Windows.Forms;

namespace laboratorio.view
{
    public partial class Form_Task_3_2 : Form
    {
        private float kx = 3.0f;
        private float ky = 3.0f;
        public Form_Task_3_2()
        {
            InitializeComponent();

            this.Paint += Form_Task_3_2_Paint;
            this.KeyDown += Form_Task_3_2_KeyDown;
            this.DoubleBuffered = true;
        }

        private void Form_Task_3_2_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics);
        }

        private void Form_Task_3_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                kx += 0.1f;
            }
            else if (e.KeyCode == Keys.Down)
            {
                kx = Math.Max(0.1f, kx - 0.1f);
            }
            else if (e.KeyCode == Keys.Left)
            {
                ky = Math.Max(0.1f, ky - 0.1f);
            }
            else if (e.KeyCode == Keys.Right)
            {
                ky += 0.1f;
            }
            this.Invalidate();
        }
        private void DrawGraph(Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            float step = 0.1f;

            for (float x = -10.0f; x <= 10.0f; x += step)
            {
                float y = (float)Math.Tan(x);
                float scaledX = kx * x + this.Width / 2;
                float scaledY = this.Height / 2 - ky * y;

                g.DrawEllipse(pen, scaledX, scaledY, 1, 1);
            }
        }
    }
}
