using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Data
    {
        public Color background { get; set; }
        public Color hourhand { get; set; }
        public Color minutehand { get; set; }
        public Color secondhand { get; set; }
        public List<Color> colors
        {
            get { return new[] { background, hourhand, minutehand, secondhand }.ToList(); }
        }
        public Data(Color BackGroundColor, Color HourHandColor, Color MinuteHandColor, Color SecondHandColor)
        {
            background = BackGroundColor;
            hourhand = HourHandColor;
            minutehand = MinuteHandColor;
            secondhand = SecondHandColor;
        }
        public Data() { }
    }
}
