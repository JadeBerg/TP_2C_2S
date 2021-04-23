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
        Tmas MyMatrix = new Tmas();
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
            try
            {
                int n = int.Parse(N1.Text);
                int a = int.Parse(A1.Text);
                int b = int.Parse(B1.Text);
                MyMatrix.GenerateMatrix(n, a, b);
                Matrix.RowCount = n;
                Matrix.ColumnCount = n;
                int i, j;
                for (i = 0; i < n; ++i)
                {
                    Matrix.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    for (j = 0; j < n; ++j)
                        Matrix.Rows[i].Cells[j].Value = MyMatrix.GetMatrix()[i, j];
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Нет данных для генерации!");
            }
        }
        private void Save_Matrix_Click(object sender, EventArgs e) // Кнопка сохранение массива в файл
        {
            try
            {
                int n = int.Parse(N1.Text);
                MyMatrix.Write_Matrix(MyMatrix.GetMatrix(), n);
                MessageBox.Show("Файл сохранен");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Массив не сгенерирован!");
            }
        }
        private void Read_Matrix_Click(object sender, EventArgs e) // Кнопка, чтобы считать размерность и сам массив из файла
        {
            string N_1 = MyMatrix.Read_Matrix();
            N1.Text = N_1;
            int n = int.Parse(N_1);
            Matrix.RowCount = n;
            Matrix.ColumnCount = n;
            int i, j;
            for (i = 0; i < n; ++i)
            {
                Matrix.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                for (j = 0; j < n; ++j)
                    Matrix.Rows[i].Cells[j].Value = MyMatrix.GetMatrix()[i, j];
            }
        }
        private void Operations_Click(object sender, EventArgs e) // Кнопка операций
        {
            try
            {
                if (op_num == 1)
                {
                    int n = int.Parse(N1.Text);
                    MyMatrix.SortRow(MyMatrix.GetMatrix());
                    for (int i = 0; i < n; ++i)
                    {
                        Matrix.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int j = 0; j < n; ++j)
                            Matrix.Rows[i].Cells[j].Value = MyMatrix.GetRes()[i, j];
                    }
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
                    int n = int.Parse(N1.Text);
                    MyMatrix.Center(MyMatrix.GetMatrix(), n);
                    for (int i = 0; i < n; ++i)
                    {
                        Matrix.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int j = 0; j < n; ++j)
                            Matrix.Rows[i].Cells[j].Value = MyMatrix.GetRes()[i, j];
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Массив не сгенерирован!");
            }
        }
        private void Write_Res_Click(object sender, EventArgs e) // Кнопка сохранения результата
        {
            try
            {
                if (op_num == 1)
                {
                    int n = int.Parse(N1.Text);
                    MyMatrix.SortRow(MyMatrix.GetMatrix());
                    MyMatrix.Write_Matrix(MyMatrix.GetRes(), n);
                    MessageBox.Show("Файл сохранен");
                }
                if (op_num == 2)
                {
                    int n = int.Parse(N1.Text);
                    int res = MyMatrix.MinMat(MyMatrix.GetMatrix(), n);
                    MyMatrix.Write_Res(res);
                    MessageBox.Show("Файл сохранен");
                }
                if (op_num == 3)
                {
                    int n = int.Parse(N1.Text);
                    MyMatrix.Center(MyMatrix.GetMatrix(), n);
                    MyMatrix.Write_Matrix(MyMatrix.GetRes(), n);
                    MessageBox.Show("Файл сохранен");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Еще не было выполнения оперции для определения результата!");
            }
        }
        public class Tmas // Класс для выполнения действия с массивом
        {
            public int[,] arr;
            public int[,] res;
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
            public int[,] GetRes() // Возвращение результирующего массива
            {
                return res;
            }
            public int MinMat(int[,] array, int n) // Определить минимальный элемент среди элементов с четной суммой индексов массива

            {
                int min = array[0, 0];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((i + j) % 2 == 0 && min > array[i, j])
                            min = array[i, j];
                    }
                }
                return min;
            }
            public void SortRow(int[,] arr) // Отсортировать элементы массива по возрастанию в строках, представить их в квадратном массиве

            {
                int size = arr.GetLength(0);
                int[,] tmp = new int[size, size];
                Array.Copy(arr, tmp, arr.Length);
                for (int k = 0; k < size; k++)
                {
                    for (int j = 0; j <= size - 2; j++)
                    {
                        for (int i = 0; i <= size - 2; i++)
                        {
                            if (tmp[k, i] > tmp[k, i + 1])
                            {
                                int t = tmp[k, i + 1];
                                tmp[k, i + 1] = tmp[k, i];
                                tmp[k, i] = t;
                            }
                        }
                    }
                }
                res = new int[size, size];
                Array.Copy(tmp, res, tmp.Length);
            }
            public void Write_Matrix(int[,] arr, int n) // Сохранение массива в файл
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.WriteLine(n);
                    for (int i = 0; i < n; i++)
                    {
                        string temp = "";
                        for (int j = 0; j < n; j++)
                        {
                            temp += $"{arr[i, j]} ";
                        }
                        temp = temp.Trim();
                        streamWriter.WriteLine(temp);
                    }
                    streamWriter.Close();
                }
            }
            public void Write_Res(int res) // Сохранение результата в файл
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    sw.WriteLine(res);
                    sw.Close();
                }
            }
            public string Read_Matrix() // Считывание массива из файла 
            {
                string[] mat;
                string N1="";
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mat = File.ReadAllLines(openFileDialog.FileName);
                    N1 = mat[0];
                    int n = int.Parse(N1);
                    arr = new int[n, n];
                    for (int i = 1; i <= n; i++)
                    {
                        string[] temp = mat[i].Split(' ');
                        for (int j = 0; j < n; j++)
                        {
                            arr[i - 1, j] = int.Parse(temp[j]);
                        }
                    }
                }
                return N1;
            }
            public int Middle(int[,] arr, int n) // Определения центра массива
            {
                int sred = 0;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        sred += arr[i, j];
                    }
                sred = sred / (n * n);
                return sred;
            }
            public int[,] Center(int[,] arr, int n) // Отцентровка массива
            {
                res = new int[n, n];
                int sred = Middle(arr, n);
                for (byte i = 0; i < n; i++)
                    for (byte j = 0; j < n; j++)
                    {
                        res[i, j] = arr[i, j] - sred;
                    }
                return res;
            }
        }
    }
}
