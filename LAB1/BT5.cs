using System;
using System.Globalization;

namespace MyProgram
{
    public class Program
    {
        private static string[] DateFormats = { "dd-MM-yyyy", "d-M-yyyy" };

        public static void Main()
        {
            DateTime validDate;
            string dateInput;

            do
            {
                Console.Write("Nhap ngay thang nam (dd-MM-yyyy): ");

                dateInput = Console.ReadLine() ?? string.Empty;

            } while (!TryGetValidDate(dateInput, out validDate));

            string dayOfWeekVN = validDate.ToString("dddd", new CultureInfo("vi-VN"));

            Console.WriteLine($"Thứ trong tuần của ngày {dateInput} là: {dayOfWeekVN}");
        }

        static bool TryGetValidDate(string date, out DateTime validDate)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                validDate = default;
                return false;
            }

            if (DateTime.TryParseExact(date,
                 DateFormats,
                 CultureInfo.InvariantCulture,
                 DateTimeStyles.None,
                 out validDate))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ngày tháng năm không hợp lệ! Vui lòng nhập lại.");
                return false;
            }
        }
    }
}