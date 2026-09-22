using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    class Chuoi
    {
        public string ChuyenThuong(string s)
        {
            return s.ToLower();
        }

        public string ChuyenHoa(string s)
        {
            return s.ToUpper();
        }

        public int DemSoTu(string s)
        {
            string[] tu = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return tu.Length;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Chuoi c = new Chuoi();

            Console.WriteLine("Chuoi thuong: " + c.ChuyenThuong(s));
            Console.WriteLine("Chuoi hoa: " + c.ChuyenHoa(s));
            Console.WriteLine("So tu trong chuoi: " + c.DemSoTu(s));

            Console.ReadLine();
        }
    }
}