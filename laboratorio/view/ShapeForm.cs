using System;
using System.Drawing;
using System.Windows.Forms;

namespace laboratorio.view
{
    public partial class ShapeForm : Form
    {
        private readonly string shapeName;
        private readonly ShapeType shapeType;
        public ShapeForm(string name, ShapeType type)
        {
            InitializeComponent();
            shapeName = name;
            shapeType = type;
            this.Text = shapeName;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Paint += ShapeForm_Paint;
        }

        private void ShapeForm_Paint(object sender, PaintEventArgs e)
        {
            DrawShape(e.Graphics);
        }
        private void DrawShape(Graphics g)
        {
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    DrawEllipse(g);
                    break;
                case ShapeType.Rectangle:
                    DrawRectangle(g);
                    break;
                case ShapeType.Triangle:
                    DrawTriangle(g);
                    break;
            }
        }

        private void DrawEllipse(Graphics g)
        {
            Rectangle rect = new Rectangle(this.Width/4, this.Height/4, 500, 260);
            g.FillEllipse(Brushes.Red, rect);
            g.DrawEllipse(Pens.Yellow, rect);
        }

        private void DrawRectangle(Graphics g)
        {
            Rectangle rect = new Rectangle(this.Width/4, this.Height/4, 500, 260);
            g.FillRectangle(Brushes.Green, rect);
            g.DrawRectangle(Pens.Blue, rect);
        }
        private void DrawTriangle(Graphics g)
        {
            Point[] points =
            {
                new Point(100, 100),
                new Point(300, 100),
                new Point(200, 300)
            };

            g.FillPolygon(Brushes.Yellow, points);
            g.DrawPolygon(Pens.Blue, points);
        }
    }
}
