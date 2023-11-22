using System;
using System.Windows.Forms;

namespace laboratorio.view
{
    public partial class Form_Task_3_5 : Form
    {
        public Form_Task_3_5()
        {
            InitializeComponent();
            this.KeyDown += Form_Task_3_5_KeyDown;
        }

        private void Form_Task_3_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                OpenNewWindow();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                OpenNewWindow();
                OpenNewWindow();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                OpenNewWindow();
                OpenNewWindow();
                OpenNewWindow();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                OpenNewWindow();
                OpenNewWindow();
                OpenNewWindow();
                OpenNewWindow();
            }
        }

        private void OpenNewWindow()
        {
            Form newForm = new Form();
            newForm.Text = "Новое Окно";
            newForm.Show();
        }
    }
}
