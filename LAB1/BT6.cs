using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Program
    {

        public static void Main()
        {
            int n = ReadPositiveInt("Nhập n (>0): ");
            int m = ReadPositiveInt("Nhập m (>0): ");
            int[,] a = CreateRandom2DArray(n, m, -100, 100);

            Console.WriteLine("Ma tran " + n + " x " + m + " : ");
            XuatMaTran(a, n, m);
            Console.WriteLine("Phan tu lon nhat la: " + PhanTuLonNhat(a, n, m));
            Console.WriteLine("Phan tu nho nhat la: " + PhanTuNhoNhat(a, n, m));
            Console.WriteLine("Dong co tong lon nhat la: " + DongCoTongLonNhat(a, n, m));
            Console.WriteLine("Tong cac so khong phai so nguyen to la: " + TongCacSoKhongPhaiNguyenTo(a, n, m));
            int k = ReadPositiveInt("Nhập k (>0): ");
            XoaDongThuK(ref a, ref n, m, k);
            Console.WriteLine("Ma tran sau khi da xoa dong thu k la: ");
            XuatMaTran(a, n, m);
            XoaCotCoPhanTuLonNhat(ref a, n, ref m);
            Console.WriteLine("Ma tran sau khi xa xoa cot co phan tu lon nhat la:");
            XuatMaTran(a, n, m);

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

        static int[,] CreateRandom2DArray(int n, int m, int minVal, int maxVal)
        {
            var rnd = new Random();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(minVal, maxVal + 1);
                }
            }
            return a;
        }

        static void XuatMaTran(int[,] a, int n, int m)
        {
            if (n == 0 || m == 0)
            {
                Console.WriteLine("Ma tran rong.");
                return;
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static int PhanTuLonNhat(int[,] a, int n, int m)
        {
            int max = a[0, 0];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] > max) max = a[i, j];
                }
            }
            return max;
        }

        static int PhanTuNhoNhat(int[,] a, int n, int m)
        {
            int min = a[0, 0];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] < min) min = a[i, j];
                }
            }
            return min;
        }

        static int DongCoTongLonNhat(int[,] a, int n, int m)
        {
            int max = 0;
            int max_sum = 0;
            for (int j = 0; j < m; ++j)
            {
                max_sum += a[0, j];
            }

            for (int i = 0; i < n; ++i)
            {
                int sum = 0;
                for (int j = 0; j < m; ++j)
                {
                    sum += a[i, j];
                }
                if (sum > max_sum)
                {
                    max = i;
                    max_sum = sum;
                }
            }
            return max;
        }

        static bool IsPrime(int x)
        {
            if (x < 2) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            for (int i = 3; i * i <= x; i += 2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        static int TongCacSoKhongPhaiNguyenTo(int[,] a, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (!IsPrime(a[i, j])) sum += a[i, j];
                }
            }
            return sum;
        }

        static void XoaDongThuK(ref int[,] a, ref int n, int m, int k)
        {
            if (k < 1 || k > n)
            {
                Console.WriteLine("So K khong hop le!");
                return;
            }
            int[,] new_a = new int[n - 1, m];
            for (int i = 0; i < n - 1; ++i)
            {
                if (i < k - 1)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        new_a[i, j] = a[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < m; ++j)
                    {
                        new_a[i, j] = a[i + 1, j];
                    }
                }

            }
            a = new_a;
            n--;
        }

        static void XoaCotCoPhanTuLonNhat(ref int[,] a, int n, ref int m)
        {
            if (n == 0 || m == 0)
            {
                Console.WriteLine("Ma tran rong, khong the xoa cot.");
                return;
            }

            int max = 0;
            int max_value = a[0, 0];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] > max_value)
                    {
                        max = j;
                        max_value = a[i, j];
                    }
                }
            }

            if (m == 1)
            {
                a = new int[n, 0];
                m = 0;
                Console.WriteLine("Cot duy nhat da bi xoa. Mang rong.");
                return;
            }

            int new_m = m - 1;
            int[,] new_a = new int[n, new_m];

            for (int i = 0; i < n; i++)
            {
                int new_col = 0;

                for (int j = 0; j < m; j++)
                {
                    if (j == max)
                    {
                        continue;
                    }
                    new_a[i, new_col] = a[i, j];
                    new_col++;
                }
            }
            a = new_a;
            m--;
        }
    }
}