using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_tp
{
    public partial class Form2 : Form
    {
        CustomMatrix MyMatrix = new CustomMatrix();
        private int op_num;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string n, string a, string b, string op, int num)
        {
            InitializeComponent();
            N1.Text = n;
            A1.Text = a;
            B1.Text = b;
            Op_number.Text = op;
            op_num = num;
        }
        private void Generate_Matrix_Click(object sender, EventArgs e)
        {
            int n = int.Parse(N1.Text);
            int a = int.Parse(A1.Text);
            int b = int.Parse(B1.Text);
            MyMatrix.GenerateMatrix(n, a, b);
            Matrix.RowCount = n;
            Matrix.ColumnCount = n;
            int i, j;
            for (i = 0; i < n; ++i)
                for (j = 0; j < n; ++j)
                    Matrix.Rows[i].Cells[j].Value = MyMatrix.GetMatrix()[i, j];
        }
        private void Save_Matrix_Click(object sender, EventArgs e)
        {
            try 
            {
                int n = int.Parse(N1.Text);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.WriteLine(n);
                    for (int i = 0; i < Matrix.RowCount; i++)
                    {
                        for (int j = 0; j < Matrix.ColumnCount; j++) { 
                            streamWriter.Write(MyMatrix.GetMatrix()[i, j] + " ");}
                        streamWriter.WriteLine();
                    }
                    streamWriter.Close();
                }
            }
            catch (Exception)
            {

            }
            MessageBox.Show("Файл сохранен");
        }
        private void Read_Matrix_Click(object sender, EventArgs e)
        {

        }
        private void Operations_Click(object sender, EventArgs e)
        {
            if (op_num == 1)
            {

            }
            if (op_num == 2)
            {

            }
            if (op_num == 3)
            {

            }
        }
        public class CustomMatrix
        {
            public int[,] arr;
            public void GenerateMatrix(int size, int min, int max) // Генерация массива
            {
                arr = new int[size, size];
                Random r = new Random();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        arr[i, j] = r.Next(min, max);
                }
            }
            public int[,] GetMatrix() // Возвращение массива
            {
                return arr;
            }
        }
    }
}
