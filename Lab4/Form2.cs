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
        public Form2(string n, string a, string b, string op, int num) // Конструктор с входынми данными
        {
            InitializeComponent();
            N1.Text = n;
            A1.Text = a;
            B1.Text = b;
            Op_number.Text = op;
            op_num = num;
        }
        private void Generate_Matrix_Click(object sender, EventArgs e) // Кнопка генерации массива
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
        private void Save_Matrix_Click(object sender, EventArgs e) // Кнопка сохранение массива в файл
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
                        string temp = "";
                        for (int j = 0; j < Matrix.ColumnCount; j++) {
                            temp += $"{MyMatrix.GetMatrix()[i, j]} ";
                        }
                        temp = temp.Trim();
                        streamWriter.WriteLine(temp);
                    }
                    streamWriter.Close();
                }
            }
            catch (Exception)
            {

            }
            MessageBox.Show("Файл сохранен");
        }
        private void Read_Matrix_Click(object sender, EventArgs e) // Кнопка, чтобы считать массив из файла
        {
            string[] mat;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mat = File.ReadAllLines(openFileDialog.FileName);
                N1.Text = mat[0];
                int n = int.Parse(N1.Text);
                MyMatrix.arr = new int[n,n];
                for(int i=1; i<=n; i++)
                {
                    string[] temp = mat[i].Split(' ');
                    for(int j=0; j<n; j++)
                    {
                        MyMatrix.arr[i - 1, j] = int.Parse(temp[j]);
                    }
                }
                Matrix.RowCount = n;
                Matrix.ColumnCount = n;
                for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                        Matrix.Rows[i].Cells[j].Value = MyMatrix.GetMatrix()[i, j];
            }
        }
        private void Operations_Click(object sender, EventArgs e) // Кнопка операций
        {
            if (op_num == 1)
            {

            }
            if (op_num == 2)
            {
                int n = int.Parse(N1.Text);
                Matrix.ColumnCount = 1;
                Matrix.RowCount = 2;
                int res = MyMatrix.MinMat(MyMatrix.GetMatrix(), n);
                Matrix[0, 0].Value = "Результат:";
                Matrix[0, 1].Value = res;
            }
            if (op_num == 3)
            {

            }
        }
        public class CustomMatrix // Класс для выполнения действия с массивом
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
            public int MinMat(int [,] array, int n) // Определить минимальный элемент среди элементов с четной суммой индексов массива

            {
                int min = array[0,0];
                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < n; j++)
                    {
                        if ((i + j) % 2 == 0 && min > array[i, j])
                            min = array[i, j];
                    }
                }
                return min;
            }
        }
    }
}
