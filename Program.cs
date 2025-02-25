using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong2
{
    class Program
    {
        // Hàm tính tổng với tham số b là optional (mặc định là 10)
        static int TinhTong_336(int a_336, int b_336 = 10)
        {
            return a_336 + b_336;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Hàm tính tổng với tham số b là optional (mặc định là 10)");
            Console.WriteLine("Nhập số thứ nhất: ");
            int num1_336 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tổng (mặc định b_336=10): {TinhTong_336(num1_336)}");
            Console.WriteLine("Nhập số thứ hai (nếu không nhập, sẽ lấy mặc định là 10): ");
            string input_336 = Console.ReadLine();
            // Nếu người dùng nhập số thứ hai, dùng giá trị đó, ngược lại dùng mặc định
            if (int.TryParse(input_336, out int num2_336))
            {
                Console.WriteLine($"Tổng với giá trị nhập vào: {TinhTong_336(num1_336, num2_336)}");
            }
            else
            {
                Console.WriteLine($"Tổng (mặc định b_336=10): {TinhTong_336(num1_336)}");
            }

        }
    }
}
