using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    class DanhSach
    {
        string[] a;
        int n;

        public void Nhap()
        {
            Console.Write("Nhap so nguoi n: ");
            n = Convert.ToInt32(Console.ReadLine());

            a = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ho ten nguoi thu " + (i + 1) + ": ");
                a[i] = Console.ReadLine();
            }
        }

        public void SapXep()
        {
            Array.Sort(a);
        }

        public void In()
        {
            Console.WriteLine("\nDanh sach sau khi sap xep:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach ds = new DanhSach();

            ds.Nhap();
            ds.SapXep();
            ds.In();

            Console.ReadLine();
        }
    }
}