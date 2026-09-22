using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so nguyen x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so nguyen y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ket qua " + x + " mu " + y + " la: " + Math.Pow(x,y));
            Console.ReadLine();
        }
    }
}
