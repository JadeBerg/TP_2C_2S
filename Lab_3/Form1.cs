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
using System.Xml;
using System.Xml.Serialization;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        CustomArray MyArray = new CustomArray();
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
                    if (textBox.Text.Length > 0 || textBox.Text.Contains('+'))
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
        private void K_KeyPress(object sender, KeyPressEventArgs e) // ввод К
        {
            try
            {
                Input(K, sender, e);
            }
            catch (System.FormatException)
            {
            }
        }
        private void Operations_Click(object sender, EventArgs e) // Кнопка операций 
        {
            try
            {
                Tabl.ReadOnly = true;
                if (Op_1.Checked) // Первая операция
                {
                    Tabl.ColumnCount = 2;
                    int[] res = MyArray.ReverseArray(MyArray.GetArray());
                    Tabl.RowCount = res.Length + 1;
                    Tabl[0, 0].Value = "i";
                    Tabl[1, 0].Value = "a[i]";
                    for (int i = 0; i < res.Length; i++)
                    {
                        Tabl[0, i + 1].Value = i;
                        Tabl[1, i + 1].Value = res[i];
                    }
                }
                if (Op_2.Checked) // Вторая операция 
                {
                    int k = int.Parse(K.Text);
                    Tabl.RowCount = k + 1;
                    Tabl.ColumnCount = 2;
                    Tabl[0, 0].Value = "Количество";
                    Tabl[1, 0].Value = "Проценты";
                    int[] res = MyArray.Sub_intervals(MyArray.GetArray(),k, int.Parse(A.Text), int.Parse(B.Text));
                    for(int i = 0; i < k; i++)
                    {
                        Tabl[0, i + 1].Value = res[i];
                        Tabl[1, i + 1].Value = Math.Round(((double) res[i]/ MyArray.GetArray().Length) * 100, 2);
                    }
                }
                if (Op_3.Checked) // Третья операция
                {
                    Tabl.ColumnCount = 2;
                    Tabl.RowCount = 2;
                    Tabl[0, 0].Value = "Количество";
                    Tabl[0, 1].Value = "Сумма";
                    int[] res = MyArray.Sum_3(MyArray.GetArray());
                    Tabl[1, 0].Value = res[1];
                    Tabl[1, 1].Value = res[0];
                }
                if (Op_4.Checked) // Четвертая операция
                {
                    Tabl.ColumnCount = 1;
                    Tabl.RowCount = 2;
                    int res = MyArray.CountPrimes(MyArray.GetArray());
                    Tabl[0, 0].Value = "Количество";
                    Tabl[0, 1].Value = res;
                }
            }
            catch (System.FormatException exception)
            {
                MessageBox.Show("Введены некорректные данные");
            } 
        }
        private void Generate_Click(object sender, EventArgs e) // Кнопка генерация массива
        {
            try
            {
                MyArray.GenerateArray(int.Parse(N.Text), int.Parse(A.Text), int.Parse(B.Text));
                Arr.Text = string.Join(" ", MyArray.GetArray());
            }
            catch (System.FormatException exception)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }
        private void Close_Click(object sender, EventArgs e) // Кнопка закрытие программы
        {
            this.Close();
        }

        private void Write_F1_Click(object sender, EventArgs e) // Кнопка сохранения массива в файл
        {
            CustomArray.Save_Array(MyArray.GetArray());
            MessageBox.Show("Файл сохранен");
        }

        private void Write_F2_Click(object sender, EventArgs e) // Кнопка сохранение результата в файл
        {
            if (Op_1.Checked)
            {
                CustomArray.Save_Array(MyArray.ReverseArray(MyArray.GetArray()));
                MessageBox.Show("Файл сохранен");
            }
            if (Op_2.Checked)
            {
                CustomArray.Save_Array(MyArray.Sub_intervals(MyArray.GetArray(), int.Parse(K.Text), int.Parse(A.Text), int.Parse(B.Text)));
                MessageBox.Show("Файл сохранен");
            }
            if (Op_3.Checked)
            {
                CustomArray.Save_Array(MyArray.Sum_3(MyArray.GetArray()));
                MessageBox.Show("Файл сохранен");
            }
            if (Op_4.Checked)
            {
                CustomArray.Save_Res(MyArray.CountPrimes(MyArray.GetArray()));
                MessageBox.Show("Файл сохранен");
            }
        }
        private void Read_F1_Click(object sender, EventArgs e) // Кнопка считывающая массив
        {
            CustomArray.Read_Array(ref MyArray.arr);
            Arr.Text = string.Join(" ", MyArray.GetArray());
        }
        public class CustomArray // Действия с массивом
        {
            public int[] arr;
            public void GenerateArray(int size, int min, int max) // Генерация массива
            {
                arr = new int[size];
                Random r = new Random();
                for (int i = 0; i < size; i++)
                    arr[i] = r.Next(min, max);
            }
            public int[] GetArray() // Возвращение массива
            {
                return arr;
            }
            public int[] ReverseArray(int[] array) // Сортировка по убыванию
            {
                int[] res = new int[array.Length];
                Array.Copy(array, res, array.Length);
                Array.Sort(res);
                Array.Reverse(res);
                return res;
            }
            private bool IsPrimeNumber(uint n) // Определение простых чисел
            {
                var result = true;

                if (n > 1)
                {
                    for (var i = 2u; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            result = false;
                            break;
                        }
                    }
                }
                else
                {
                    result = false;
                }

                return result;
            }
            public int CountPrimes(int[] array) // Счетчик простых чисел
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        if (IsPrimeNumber((uint)array[i]))
                            count++;
                }
                return count;
            }
            public int[] Sum_3(int[] array) // Сумма и количество чисел элементов массива a, у которых число,составленное из двух последних цифр числа a, делится на 3.
            {
                int[] res = new int[2];
                int sum = 0;
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if ((Convert.ToInt32(array[i].ToString()[0]) + Convert.ToInt32(array[i].ToString()[1])) % 3 == 0)
                    {
                        sum += array[i];
                        count++;
                    }
                }
                res[0] = sum;
                res[1] = count;
                return res;
            }
            public int[] Sub_intervals(int[] array, int k, int min, int max) // Диапазон определения чисел массива [А, В] разбить на k равных подинтервалов. Определить количество чисел и процент чисел, попадающих в каждый подинтервал.
            {
                int[] res = new int[k];
                int count = 0;
                int step = (max-min)/k;
                int for_step = min + step;
                int[] sorted = new int[array.Length];
                Array.Copy(array, sorted, array.Length);
                Array.Sort(sorted);
                for(int i = 0; i< sorted.Length; i++)
                {
                    if (sorted[i] < for_step)
                        res[count]++;
                    else
                    {
                        count++;
                        res[count]++;
                        for_step += step;
                    }
                }
                return res;
            }
            public static void Save_Array(int[] array) // Сохранения массива в файл
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "XML-документ (*.xml)|*.xml";
                    if (sfd.ShowDialog() == DialogResult.Cancel)
                        return;
                    string filename = sfd.FileName;

                    XmlSerializer xmlFormatter = new XmlSerializer(typeof(int[]));
                    using (FileStream fs = new FileStream(filename, FileMode.Create))
                    {
                        xmlFormatter.Serialize(fs, array);
                    }
                }

                catch (Exception)
                {

                }
            }
            public static void Read_Array(ref int[] array) // Считать массив из файла
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "XML-документ (*.xml)|*.xml";
                if (ofd.ShowDialog() != DialogResult.Cancel)
                {
                    string filename = ofd.FileName;
                    XmlSerializer xmlFormatter = new XmlSerializer(typeof(int[]));
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        array = (int[])xmlFormatter.Deserialize(fs);
                    }
                }
            }
            public static void Save_Res(int res) // Сохранения результата в файл
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "XML-документ (*.xml)|*.xml";
                    if (sfd.ShowDialog() == DialogResult.Cancel)
                        return;
                    string filename = sfd.FileName;

                    XmlSerializer xmlFormatter = new XmlSerializer(typeof(int));
                    using (FileStream fs = new FileStream(filename, FileMode.Create))
                    {
                        xmlFormatter.Serialize(fs, res);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
}
}