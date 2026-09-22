using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class MaTran
    {
        int[,] a;
        int n, m;

        public void Nhap()
        {
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap m: ");
            m = Convert.ToInt32(Console.ReadLine());

            a = new int[n, m];

            Random rd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rd.Next(10, 101);
                }
            }
        }

        public void In()
        {
            Console.WriteLine("\nMa tran A:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        public void LayChanLe(out int[] chan, out int[] le)
        {
            List<int> dsChan = new List<int>();
            List<int> dsLe = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 == 0)
                        dsChan.Add(a[i, j]);
                    else
                        dsLe.Add(a[i, j]);
                }
            }

            chan = dsChan.ToArray();
            le = dsLe.ToArray();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MaTran mt = new MaTran();

            mt.Nhap();
            mt.In();

            int[] chan, le;

            mt.LayChanLe(out chan, out le);

            Console.Write("\nMang so chan: ");
            for (int i = 0; i < chan.Length; i++)
            {
                Console.Write(chan[i] + " ");
            }

            Console.Write("\nMang so le: ");
            for (int i = 0; i < le.Length; i++)
            {
                Console.Write(le[i] + " ");
            }

            Console.ReadLine();
        }
    }
}