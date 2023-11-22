using System;
using System.Windows.Forms;
using laboratorio.view;


namespace laboratorio.view
{
    public enum ShapeType
    {
        Ellipse,
        Rectangle,
        Triangle
    }
    public partial class Form_Task_3_6 : Form
    {
        public Form_Task_3_6()
        {
            InitializeComponent();
            this.KeyDown += Form_Task_3_6_KeyDown;
            this.FormClosing += Form_Task_3_6_FormClosing;
            this.Text = "Выберите фигуру";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form_Task_3_6_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.E:
                    ShowShapeForm("Эллипс", ShapeType.Ellipse);
                    break;
                case Keys.K:
                    ShowShapeForm("Квадрат", ShapeType.Rectangle);
                    break;
                case Keys.T:
                    ShowShapeForm("Треугольник", ShapeType.Triangle);
                    break;
                case Keys.Escape:
                    CloseApplication();
                    break;
            }
        }
        private void ShowShapeForm(string shapeName, ShapeType shapeType)
        {
            ShapeForm shapeForm = new ShapeForm(shapeName, shapeType);
            shapeForm.Show();
        }
        private void CloseApplication()
        {

            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }


        private void Form_Task_3_6_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseApplication();
        }
    }
}
