using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong2
{
    class WeatherInfo_336
    {
        // Định nghĩa Enum bên trong lớp
        public enum WeatherCondition_336
        {
            Sunny_336, Cloudy_336, Rainy_336, Stormy_336
        }

        // Phương thức hiển thị trạng thái thời tiết với Optional Parameter
        public void DisplayWeather_336(WeatherCondition_336 condition_336 = WeatherCondition_336.Sunny_336)
        {
            Console.WriteLine($"Thời tiết hiện tại: {condition_336}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Tạo lớp WeatherInfo_336 chứa Enum WeatherCondition_336 và hàm DisplayWeather_336 có sử dụng optional parameter
            Console.WriteLine("Tạo lớp WeatherInfo_336 chứa Enum WeatherCondition_336 và hàm DisplayWeather_336 có sử dụng optional parameter");
            WeatherInfo_336 report_336 = new WeatherInfo_336();

            // Gọi phương thức mà không truyền tham số (sẽ dùng giá trị mặc định)
            report_336.DisplayWeather_336();

            // Gọi phương thức với một giá trị Enum cụ thể
            report_336.DisplayWeather_336(WeatherInfo_336.WeatherCondition_336.Rainy_336);
        }
    }
}
