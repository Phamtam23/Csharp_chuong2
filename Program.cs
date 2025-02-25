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

    class Rectangle_336
    {
        public Point_336 upperLeft_336 { get; set; }
        public Point_336 bottomRight_336 { get; set; }

        // Constructor
        public Rectangle_336(Point_336 upperLeft_336, Point_336 bottomRight_336)
        {
            this.upperLeft_336 = upperLeft_336;
            this.bottomRight_336 = bottomRight_336;
        }

        // Hiển thị trạng thái hình chữ nhật
        public void Display_336()
        {
            Console.WriteLine("Rectangle_336:");
            Console.Write(" - Upper Left: ");
            upperLeft_336.Display_336();
            Console.Write(" - Bottom Right: ");
            bottomRight_336.Display_336();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Định nghĩa kiểu điểm và màu
            Console.WriteLine("Định nghĩa kiểu điểm và màu");
            // Tạo điểm
            Point_336 p1_336 = new Point_336(1, 4, PointColor_336.Gold_336);
            Point_336 p2_336 = new Point_336(6, 1, PointColor_336.BloodRed_336);

            // Tạo hình chữ nhật
            Rectangle_336 rect_336 = new Rectangle_336(p1_336, p2_336);
            // Hiển thị trạng thái hình chữ nhật
            rect_336.Display_336();
        }
    }
}
