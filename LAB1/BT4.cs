using System;
using System.ComponentModel;
using System.Globalization;

namespace MyProgram
{
    public class Program
    {
        public static void Main()
        {
            int month;
            do
            {
                month = ReadPositiveInt("Nhap thang: ");
                if (month > 12)
                {
                    Console.WriteLine("Thang khong hop le, moi nhap lai!");
                }
                else break;
            } while (true);

            int year;
            while (true)
            {
                year = ReadPositiveInt("Nhap nam: ");
                if (year < 0)
                {
                    Console.WriteLine("Nam khong hop le, moi nhap lai!");
                }
                else break;
            }



            Console.WriteLine("So ngay trong thang " + month + " nam " + year + " la: " + DateTime.DaysInMonth(year, month));
        }

        static int ReadPositiveInt(string message)
        {
            int n;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }

    }
}