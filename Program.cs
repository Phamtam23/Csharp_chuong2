using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong2
{
    enum PointColor_336
    {
        LightBlue_336, BloodRed_336, Gold_336
    }

    class Point_336
    {
        public int x_336 { get; set; }
        public int y_336 { get; set; }
        public PointColor_336 color_336 { get; set; }

        // Constructor
        public Point_336(int x_336, int y_336, PointColor_336 color_336)
        {
            this.x_336 = x_336;
            this.y_336 = y_336;
            this.color_336 = color_336;
        }

        // Hiển thị trạng thái điểm
        public void Display_336()
        {
            Console.WriteLine($"Point_336({x_336}, {y_336}) - Color: {color_336}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Định nghĩa kiểu điểm và màu
            Console.WriteLine("chuong2");
        }
    }
}
