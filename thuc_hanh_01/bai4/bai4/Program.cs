using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 0, y = 0;
            int chon;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                chon = Convert.ToInt32(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap x: ");
                        x = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Nhap y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("x^y = " + Math.Pow(x, y));
                        break;

                    case 3:
                        if (x >= 0 && y >= 0)
                        {
                            Console.WriteLine("Can bac 2 cua x = " + Math.Sqrt(x));
                            Console.WriteLine("Can bac 2 cua y = " + Math.Sqrt(y));
                        }
                        else
                        {
                            Console.WriteLine("Khong the tinh can bac 2 cua so am!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thoat chuong trinh!");
                        break;

                    default:
                        Console.WriteLine("Chuc nang khong hop le!");
                        break;
                }

                Console.WriteLine();

            } while (chon != 4);
        }
    }
}
