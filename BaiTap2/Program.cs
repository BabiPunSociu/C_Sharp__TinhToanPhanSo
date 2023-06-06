using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();

            ps1.nhapPS();
            ps2.nhapPS();

            PhanSo tong = ps1 + ps2;
            Console.WriteLine("\nTong 2 phan so:");
            ps1.inPhanSo(); Console.Write(" + "); ps2.inPhanSo(); Console.Write(" = "); tong.inPhanSo();

            PhanSo hieu = ps1 - ps2;
            Console.WriteLine("\nHieu 2 phan so:");
            ps1.inPhanSo(); Console.Write(" - "); ps2.inPhanSo(); Console.Write(" = "); hieu.inPhanSo();

            PhanSo tich = ps1 * ps2;
            Console.WriteLine("\nTich 2 phan so:");
            ps1.inPhanSo(); Console.Write(" * "); ps2.inPhanSo(); Console.Write(" = "); tich.inPhanSo();

            PhanSo thuong = ps1 / ps2;
            Console.WriteLine("\nThuong 2 phan so:");
            ps1.inPhanSo(); Console.Write(" / "); ps2.inPhanSo(); Console.Write(" = "); thuong.inPhanSo();



        }
    }
}
