using System;
using System.Windows.Forms;
using laboratorio.view;

namespace laboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Task_3_1 form_Task = new Form_Task_3_1();
            form_Task.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Task_3_2 form_Task = new Form_Task_3_2();
            form_Task.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Task_3_3 form_Task = new Form_Task_3_3();
            form_Task.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Task_3_4 form_Task = new Form_Task_3_4();
            form_Task.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Task_3_5 form_Task = new Form_Task_3_5();
            form_Task.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Task_3_6 form_Task = new Form_Task_3_6();
            form_Task.ShowDialog();
        }
    }
}
