using System;
using System.Drawing;
using System.Windows.Forms;

namespace laboratorio.view
{
    public partial class Form_Task_3_4 : Form
    {
        private const int minFormWidth = 150;
        private const int minFormHeight = 150;
        private const int circleRadius = 30;
        public Form_Task_3_4()
        {
            InitializeComponent();
            this.MinimumSize = new Size(minFormWidth, minFormHeight);

            this.Resize += Form_Task_3_4_Resize;

            this.Paint += Form_Task_3_4_Paint;
            UpdateFormTitle();
        }

        private void Form_Task_3_4_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            UpdateFormTitle();
        }

        private void Form_Task_3_4_Paint(object sender, PaintEventArgs e)
        {
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            e.Graphics.FillEllipse(Brushes.Yellow, centerX - circleRadius, centerY - circleRadius, 2 * circleRadius, 2 * circleRadius);

        }
        private void UpdateFormTitle()
        {
            this.Text = $"Размеры: {this.Width}x{this.Height}, Координаты: ({this.Location.X}, {this.Location.Y})";
        }
    }
}
