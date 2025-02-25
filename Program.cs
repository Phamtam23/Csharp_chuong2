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
            //Hiển thị danh sách học sinh
            Console.WriteLine("Hiển thị danh sách học sinh");
            // Tạo mảng chứa danh sách sinh viên
            Student_336[] students_336 = new Student_336[]
            {
            new Student_336(101, "Nguyễn Văn A", 3.5),
            new Student_336(102, "Trần Thị B", 3.8),
            new Student_336(103, "Lê Văn C", 3.2)
            };

            // Duyệt mảng và hiển thị thông tin sinh viên bằng foreach
            Console.WriteLine("Danh sách sinh viên:");
            foreach (Student_336 student_336 in students_336)
            {
                student_336.Display_336();
            }
        }
    }
}
