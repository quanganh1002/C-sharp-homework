using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
{
    class MangSoNguyen
    {
        int[] a;
        int n;

        public void Nhap()
        {
            Console.Write("Nhap so phan tu n: ");
            n = Convert.ToInt32(Console.ReadLine());

            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap a[" + i + "]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void In()
        {
            Console.Write("Mang: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
        }

        public void TimMaxMin(out int max, out int min)
        {
            max = a[0];
            min = a[0];

            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];

                if (a[i] < min)
                    min = a[i];
            }
        }

        public bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }

        public int[] LaySoNguyenTo()
        {
            List<int> kq = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(a[i]))
                    kq.Add(a[i]);
            }

            return kq.ToArray();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MangSoNguyen m = new MangSoNguyen();

            m.Nhap();

            m.In();

            int max, min;
            m.TimMaxMin(out max, out min);

            Console.WriteLine("Phan tu lon nhat: " + max);
            Console.WriteLine("Phan tu nho nhat: " + min);

            int[] soNguyenTo = m.LaySoNguyenTo();

            Console.Write("Cac so nguyen to: ");

            for (int i = 0; i < soNguyenTo.Length; i++)
            {
                Console.Write(soNguyenTo[i] + " ");
            }

            Console.ReadLine();
        }
    }
}