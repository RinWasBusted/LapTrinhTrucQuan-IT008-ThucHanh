using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Nh?p n 
            int n = ReadPositiveInt("Nh?p n (>0): ");

            Console.Write("T?ng các s? nguyên t? bé h?n n là: ");
            Console.WriteLine(SumOfPrime(n));
        }

        // ??c s? nguyên d??ng
        static int ReadPositiveInt(string message)
        {
            int n;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }

        // Ki?m tra s? nguyên t?
        static bool IsPrime(int x)
        {
            if (x <= 1) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;

            int limit = (int)Math.Sqrt(x);
            for (int i = 3; i <= limit; i += 2)
                if (x % i == 0) return false;

            return true;
        }

        // Tính t?ng các s? nguyên t? bé h?n n
        static int SumOfPrime(int n)
        {
            int sum = 0;
            if (n >= 2) sum += 2;
            for (int i = 3; i < n; i += 2)
            {
                if (IsPrime(i)) sum += i;
            }
            return sum;
        }
    }
}