using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Color BackGround { get; set; }
        public Color HourHand { get; set; }
        public Color MinuteHand { get; set; }
        public Color SecondHand { get; set; }
        Data info;
        ColorDialog colorDialog1 = new ColorDialog();
        public Form1()
        {
            InitializeComponent();
            BackGround = Color.Blue;
            HourHand= Color.White;
            MinuteHand = Color.Green;
            SecondHand = Color.Pink;
            info = new Data(BackGround, HourHand, MinuteHand, SecondHand);
        }

        private void Dig_clock_Click(object sender, EventArgs e)
        {
            Dig_clock fm = new Dig_clock();
            fm.ShowDialog();
        }

        private void Face_clock_Click(object sender, EventArgs e)
        {
            Face_clock fm = new Face_clock(BackGround, HourHand, MinuteHand, SecondHand);
            fm.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.ShowDialog();

            BackGround = colorDialog1.Color;
            info.background = colorDialog1.Color;
        }
        private void Hour_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.ShowDialog();

            HourHand = colorDialog1.Color;
            info.hourhand = colorDialog1.Color;
        }
        private void Minute_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.ShowDialog();

            MinuteHand = colorDialog1.Color;
            info.minutehand = colorDialog1.Color;
        }
        private void Second_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.ShowDialog();

            SecondHand = colorDialog1.Color;
            info.secondhand = colorDialog1.Color;
        }
        private void Author_Click(object sender, EventArgs e)
        {
            Author fm = new Author();
            fm.ShowDialog();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSet();
                MessageBox.Show("Файл сохранен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SaveSet()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "json files (*.json)|*.json";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    Data d = new Data(info.background, info.hourhand, info.minutehand, info.secondhand);
                    string jsonString = JsonSerializer.Serialize(d);
                    myStream.Close();
                    File.WriteAllText(saveFileDialog1.FileName, jsonString);
                }
            }
        }
    }
}
