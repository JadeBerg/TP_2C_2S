using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_tp
{
    public partial class Form1 : Form
    {
        public Form2 f;
        public Form1()
        {
            InitializeComponent();
            Op_1.Checked = true;
        }
        private void Input(TextBox textBox, object sender, KeyPressEventArgs e) // Проверка ввода
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar == '-')
                {
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('-'))
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == '+')
                        e.KeyChar = (char)Keys.None;
                if (e.KeyChar == ',')
                {
                    e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != ',')
                    e.KeyChar = (char)Keys.None;
            }

        }
        private void N_KeyPress(object sender, KeyPressEventArgs e) // ввод N
        {
            try
            {
                Input(N, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void A_KeyPress(object sender, KeyPressEventArgs e) // ввод A
        {
            try
            {
                Input(A, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void B_KeyPress(object sender, KeyPressEventArgs e) // ввод B
        {
            try
            {
                Input(B, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Author_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            f.Text = Author.Text;
        }
        private void Input_data_Click(object sender, EventArgs e)
        {
            string op = " ";
            int num = 0;
            if (Op_1.Checked)
            {
                op = "Выбрана операция : Отсортировать элементы массива по возрастанию в строках,представить их в квадратном массиве";
                num = 1;
            }
            if (Op_2.Checked)
            {
                op = "Выбрана операция : Определить минимальный элемент среди элементов с четной суммойиндексов массива";
                num = 2;
            }
            if (Op_3.Checked)
            {
                op = "Выбрана операция : Отцентрировать элементы массива";
                num = 3;
            }
            f = new Form2(N.Text, A.Text, B.Text, op, num);
            f.Show();
        }
    }

}
