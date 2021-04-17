using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public interface Calc
    {
        void Put_A(double a);

        void Clear_A();

        double Mul(double b);

        double Div(double b);

        double Sum(double b);

        double Sub(double b);

        double Sqrt();

        double MemoryShow();

        void Memory_Clear();
        double cos();
    }
    public partial class Form1 : Form, Calc
    {
        private double a = 0;
        private double memory = 0;
        int k;
        public void Put_A(double a)
        {
            this.a = a;
        }
        /// Clear row
        public void Clear_A()
        {
            a = 0;
        }
        /// Multiplication
        public double Mul(double b)
        {
            return a * b;
        }
        /// Division
        public double Div(double b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
                return a / b;
        }
        /// sum
        public double Sum(double b)
        {
            return a + b;
        }
        /// Substruction
        public double Sub(double b)
        {
            return a - b;
        }
        /// sin operation
        public double cos()
        {
            return Math.Cos(a);
        }
        /// sqrt method
        public double Sqrt()
        {
            return Math.Sqrt(a);
        }
        /// 1/x operation
        public double point()
        {
            return 1 / a;
        }
        /// memory return
        public double MemoryShow()
        {
            return memory;
        }
        /// clean memory
        public void Memory_Clear()
        {
            memory = 0.0;
        }
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";
        }
        /// Check what buttons are able to be pressed
        private bool CanPress()
        {
            //+
            if (!button4.Enabled)
                return false;
            // -
            if (!button9.Enabled)
                return false;
            // *
            if (!button10.Enabled)
                return false;
            // sqrt
            if (!button18.Enabled)
                return false;
            // /
            if (!button5.Enabled)
                return false;
            // cos
            if (!button17.Enabled)
                return false;
            //1/x
            if (!button16.Enabled)
                return false;
            return true;
        }
        /// Check what button are free to be press
        private void FreeButtons()
        {
            button4.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button18.Enabled = true;
            button17.Enabled = true;
            button16.Enabled = true;
            button5.Enabled = true;
        }
        /// Main window where numbers are placed
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CorrectNumber()

        {
            if (textBox1.TextLength == textBox1.MaxLength)
                textBox1.Text = textBox1.Text.Remove(0, 1);

            //ситуация: слева ноль, а после него НЕ точка, тогда ноль можно удалить
            if (textBox1.TextLength >= 2)
            {
                if (textBox1.Text[0] == '0' && (textBox1.Text.IndexOf(".") != 1))
                    textBox1.Text = textBox1.Text.Remove(0, 1);
            }

            //аналогично предыдущему, только для отрицательного числа
            if (textBox1.Text[0] == '-')
                if (textBox1.Text[1] == '0' && (textBox1.Text.IndexOf(".") != 2))
                    textBox1.Text = textBox1.Text.Remove(1, 1);
        }
        /// clear one element button
        private void button14_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));
                if (textBox1.TextLength == 1)
                {
                    textBox1.Text = "0";
                }
                else if (textBox1.TextLength == 2)
                {
                    if (textBox1.Text[0] == '-')
                    {
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                }
            }
        }
        /// .
        private void button19_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.IndexOf(".") == -1) && (textBox1.Text.IndexOf("∞") == -1))
                textBox1.Text += ",";
        }
        /// - operation
        private void button9_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));
                textBox2.Text = "";

                button9.Enabled = false;

                textBox1.Text = "0";
            }
        }
        /// cos() operation
        private void button17_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));

                button17.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// +/-
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }
        /// 1
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }
        /// 2
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// 3
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// 4
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// 5
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// 6
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// 7
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// 8
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// 9
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// 0
        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox2.Text = "";
            textBox2.Visible = false;
            CorrectNumber();
        }
        /// =
        private void button21_Click(object sender, EventArgs e)
        {
            if (!button4.Enabled)
                textBox1.Text = Sum(Convert.ToDouble(textBox1.Text)).ToString();
            if (!button9.Enabled)
                textBox1.Text = Sub(Convert.ToDouble(textBox1.Text)).ToString();
            if (!button10.Enabled)
                textBox1.Text = Mul(Convert.ToDouble(textBox1.Text)).ToString();
            if (!button17.Enabled)
            {
                textBox1.Text = cos().ToString();
            }
            if (!button18.Enabled)
                textBox1.Text = Sqrt().ToString();
            if (!button16.Enabled)
                textBox1.Text = point().ToString();
            if (!button5.Enabled)
            {
                double result = Div(Convert.ToDouble(textBox1.Text));
                if (result == 0)
                    MessageBox.Show("Zero division");
                else
                    textBox1.Text = result.ToString();
            }
            textBox2.Visible = true;
            textBox2.Text = "RESULT";
            Clear_A();
            FreeButtons();
            k = 0;
        }
        /// C
        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            textBox2.Visible = false;

            Clear_A();
        }
        /// + operator
        private void button4_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                textBox2.Text = "";
                Put_A(Convert.ToDouble(textBox1.Text));
                button4.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// Division button
        private void button5_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));

                button5.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// * operation
        private void button10_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                textBox2.Text = "";
                Put_A(Convert.ToDouble(textBox1.Text));
                button10.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// Sqrt button
        private void button18_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));

                button18.Enabled = false;
                textBox1.Text = "0";
            }
        }
        /// point button
        private void button16_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Put_A(Convert.ToDouble(textBox1.Text));

                button16.Enabled = false;
                textBox1.Text = "0";
            }
        }
    }
}
