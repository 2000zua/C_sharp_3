using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio.view
{
    public partial class Form_Task_3_3 : Form
    {
        private const int squareSize = 10;
        private const int stepSize = 5;
        private const int minSquareSide = 1;
        private int maxSquareSide;

        private Rectangle square;
        private bool shiftPressed;

        public Form_Task_3_3()
        {
            InitializeComponent();

            square = new Rectangle((Width - squareSize) / 2, (Height - squareSize) / 2, squareSize, squareSize);
            maxSquareSide = Math.Min(Width, Height) - squareSize;

            KeyDown += Form_Task_3_3_KeyDown;
            KeyUp += Form_Task_3_3_KeyUp;
            Paint += Form_Task_3_3_Paint;
        }

        private void Form_Task_3_3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    CreateSquare();
                    break;
                case Keys.Up:
                    MoveSquare(0, -stepSize);
                    break;
                case Keys.Down:
                    MoveSquare(0, stepSize);
                    break;
                case Keys.Left:
                    MoveSquare(-stepSize, 0);
                    break;
                case Keys.Right:
                    MoveSquare(stepSize, 0);
                    break;
                case Keys.ShiftKey:
                    shiftPressed = true;
                    break;
                case Keys.F1:
                    ShowAboutDialog();
                    break;
            }

            if (shiftPressed)
            {
                ResizeSquare(e.KeyCode);
            }

            Invalidate();
        }

        private void Form_Task_3_3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shiftPressed = false;
            }
        }

        private void ResizeSquare(Keys keyCode)
        {
            int newSide = squareSize;

            if (keyCode == Keys.Up || keyCode == Keys.Down)
            {
                newSide = shiftPressed ? Math.Max(minSquareSide, square.Height - stepSize) : Math.Min(maxSquareSide, square.Height + stepSize);
            }
            else if (keyCode == Keys.Left || keyCode == Keys.Right)
            {
                newSide = shiftPressed ? Math.Max(minSquareSide, square.Width - stepSize) : Math.Min(maxSquareSide, square.Width + stepSize);
            }

            int newX = square.X + (square.Width - newSide) / 2;
            int newY = square.Y + (square.Height - newSide) / 2;

            square = new Rectangle(newX, newY, newSide, newSide);
        }

        private void Form_Task_3_3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, square);
        }
        private void CreateSquare()
        {
            square = new Rectangle((Width - squareSize) / 2, (Height - squareSize) / 2, squareSize, squareSize);
        }

        private void MoveSquare(int deltaX, int deltaY)
        {
            square.X = Math.Max(0, Math.Min(square.X + deltaX, Width - squareSize));
            square.Y = Math.Max(0, Math.Min(square.Y + deltaY, Height - squareSize));
        }
        private void ShowAboutDialog()
        {
            MessageBox.Show("Программа создана [ВАШЕ ИМЯ И ФАМИЛИЯ].", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
