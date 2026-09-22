using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    class Chuoi
    {
        public string DaoChuoi(string s)
        {
            string kq = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                kq += s[i];
            }

            return kq;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Chuoi c = new Chuoi();

            string kq = c.DaoChuoi(s);

            Console.WriteLine("Chuoi sau khi dao: " + kq);

            Console.ReadLine();
        }
    }
}