using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class SoNguyen
    {
        public int TimMax(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            return max;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            int c = Convert.ToInt32(Console.ReadLine());

            SoNguyen sn = new SoNguyen();

            int max = sn.TimMax(a, b, c);

            Console.WriteLine("Gia tri lon nhat la: " + max);

            Console.ReadLine();
        }
    }
}