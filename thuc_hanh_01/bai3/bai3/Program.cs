using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen x: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Loi: x khong phai so nguyen!");
                return;
            }

            Console.WriteLine("Nhap so nguyen y: ");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Loi: y khong phai so nguyen!");
                return;
            }

            Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + Math.Pow(x, y));
            Console.ReadLine();
        }
    }
}
