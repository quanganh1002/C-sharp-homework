using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class SoNguyen
    {
        public bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            SoNguyen sn = new SoNguyen();

            if (sn.LaSoNguyenTo(n))
                Console.WriteLine(n + " la so nguyen to");
            else
                Console.WriteLine(n + " khong phai la so nguyen to");

            Console.ReadLine();
        }
    }
}