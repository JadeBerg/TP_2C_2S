using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Roots(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                try
                {
                    double x1_res = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 5);
                    double x2_res = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 5);
                    X1.Text = x1_res.ToString();
                    X2.Text = x2_res.ToString();
                }
                catch { }
            }
            if (D == 0)
            {
                try
                {
                    double x1_res = Math.Round(-b / (2 * a), 5);
                    X1.Text = x1_res.ToString();
                }
                catch { }
                X2.Text = "";
            }
            if (D < 0)
            {
                X1.Text = "D = 0!!";
            }

        }
        private void CheckInput(TextBox textBox, object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar == '-')
                {
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('-'))
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar == '+')
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('+'))
                        e.KeyChar = (char)Keys.None;
                if (e.KeyChar == ',')
                {
                    if (textBox.Text.Contains(',') || textBox.Text.Length == 0)
                        e.KeyChar = (char)Keys.None;
                }
                if (e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != ',')
                    e.KeyChar = (char)Keys.None;
            }
        }
        private void A_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(A, sender, e);
        }
        private void B_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(B, sender, e);
        }
        private void C_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInput(C, sender, e);
        }

        private void Solution_Click(object sender, EventArgs e)
        {
            if (Method_1.Checked)
            {
                try
                {
                    double a = Convert.ToDouble(A.Text);
                    double b = Convert.ToDouble(B.Text);
                    double c = Convert.ToDouble(C.Text);
                    double D = b * b - 4 * a * c;
                    if (D > 0)
                    {
                        double x1_res = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 5);
                        double x2_res = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 5);
                        X1.Text = x1_res.ToString();
                        X2.Text = x2_res.ToString();
                    }
                    if (D == 0)
                    {
                        double x1_res = Math.Round(-b / (2 * a), 5);
                        X1.Text = x1_res.ToString();
                        X2.Text = "";
                    }
                    if (D < 0)
                    {
                        X1.Text = "D = 0!!";
                    }
                }
                catch (OverflowException of)
                {

                }

            }
            if (Method_2.Checked)
            {
                try
                {
                    double a = Convert.ToDouble(A.Text);
                    double b = Convert.ToDouble(B.Text);
                    double c = Convert.ToDouble(C.Text);
                    Roots(a, b, c);

                }
                catch
                {

                }
            }
            if (Method_3.Checked)
            {
                try
                {
                    double a = Convert.ToDouble(A.Text);
                    double b = Convert.ToDouble(B.Text);
                    double c = Convert.ToDouble(C.Text);
                    Solution s = new Solution();
                    double?[] res = s.ShowRoots(a, b, c);
                    if (res[0] != null && res[1] != null)
                    {
                        X1.Text = res[0].ToString();
                        X2.Text = res[1].ToString();
                    }
                    if (res[0] != null && res[1] == null)
                    {
                        X1.Text = res[0].ToString();
                        X2.Text = "";
                    }
                    if (res[0] == null && res[1] == null)
                    {
                        X1.Text = "D = 0!!";
                    }
                }
                catch
                {

                }
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            A.Text = "";
            B.Text = "";
            C.Text = "";
            X1.Text = "";
            X2.Text = "";
        }
        private void End_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class Solution
        {
            public double?[] ShowRoots(double a, double b, double c)
            {
                double?[] results = new double?[2];
                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    try
                    {
                        double x1_res = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 5);
                        double x2_res = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 5);
                        results[0] = x1_res;
                        results[1] = x2_res;
                    }
                    catch { }
                }
                if (D == 0)
                {
                    try
                    {
                        double x1_res = Math.Round(-b / (2 * a), 5);
                        results[0] = x1_res;
                    }
                    catch { }
                    results[1] = null;
                }
                if (D < 0)
                {
                    results[0] = null;
                    results[1] = null;
                }
                return results;
            }
        }
    }
}
