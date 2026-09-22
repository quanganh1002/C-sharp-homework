using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    class SoThuc
    {
        public void HoanVi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thuc a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap so thuc b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            SoThuc st = new SoThuc();

            Console.WriteLine("Truoc khi hoan vi: a = " + a + ", b = " + b);

            st.HoanVi(ref a, ref b);

            Console.WriteLine("Sau khi hoan vi: a = " + a + ", b = " + b);

            Console.ReadLine();
        }
    }
}