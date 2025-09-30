using System;
using System.ComponentModel;
using System.Globalization;

namespace MyProgram
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Nhap ngay thang nam (dd-MM-yyyy): ");
            string date = Console.ReadLine();
            if (DateTime.TryParseExact(date,
             "dd-MM-yyyy",
              CultureInfo.InvariantCulture,
              DateTimeStyles.None,
               out DateTime validDate))
            {
                Console.WriteLine("Ngay hop le: " + date);
            }
            else
            {
                Console.WriteLine("Ngay thang nam nhap khong hop le!");
            }

        }
    }
}