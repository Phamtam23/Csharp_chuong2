using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong2
{
    class Program
    {
        class Student_336
        {
            public int ID_336 { get; set; }
            public string Name_336 { get; set; }
            public double GPA_336 { get; set; }

            // Constructor
            public Student_336(int id_336, string name_336, double gpa_336)
            {
                ID_336 = id_336;
                Name_336 = name_336;
                GPA_336 = gpa_336;
            }

            // Hiển thị thông tin sinh viên
            public void Display_336()
            {
                Console.WriteLine($"ID: {ID_336} - Name: {Name_336} - GPA: {GPA_336:F2}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("chuong2");
        }
    }
}
