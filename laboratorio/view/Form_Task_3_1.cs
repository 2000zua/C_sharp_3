using System;
using System.Windows.Forms;

namespace laboratorio.view
{
    public partial class Form_Task_3_1 : Form
    {
        public Form_Task_3_1()
        {
            InitializeComponent();

            this.KeyDown += Form_Task_3_1_KeyDown;
            this.KeyPress += Form_Task_3_1_KeyPress;
        }

        private void Form_Task_3_1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text =  ($"Key Down: {e.KeyCode}");
            label2.Text =  ($"Is Digit: {char.IsDigit((char)e.KeyCode)}");
            label3.Text =  ($"Is Letter: {char.IsLetter((char)e.KeyCode)}");
            label4.Text =  ($"Is Upper: {char.IsUpper((char)e.KeyCode)}");
            label5.Text =  ($"Is Lower: {char.IsLower((char)e.KeyCode)}");
            label6.Text =  ($"Is Cyrillic: {IsCyrillic((char)e.KeyCode)}");
            Console.WriteLine();
        }

        private bool IsCyrillic(char c)
        {
            return (c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё';
        }

        private void Form_Task_3_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label7.Text = ($"Key Press: {e.KeyChar}");
            Console.WriteLine();
        }
    }
}
