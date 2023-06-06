using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class PhanSo
    {
        protected int tuSo, mauSo;

        public PhanSo() { tuSo = 0; mauSo = 1; }
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public void nhapPS()
        {
            try
            {
                Console.Write("Nhap phan so a/b: ");
                string input = Console.ReadLine().Trim();
                string[] strings = input.Split('/');
                tuSo = int.Parse(strings[0]);
                mauSo= int.Parse(strings[1]);
                if (mauSo == 0)
                {
                    throw new DivideByZeroException("Loi chia cho 0");
                }
                else if(mauSo < 0)
                {
                    tuSo *= -1; mauSo *= -1;
                }    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void rutGon()
        {
            if(tuSo != 0)   // tuSo!=0 && mauSo!=0
            {
                int a = Math.Abs(tuSo);
                int b = Math.Abs(mauSo);
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    b -= a;
                }

                // khi a==b thì a==b==UCLN
                tuSo /= a;
                mauSo /= a;
            }    
        }

        public void inPhanSo()
        {
            if(tuSo == 0)
                Console.Write(tuSo);
            else if(mauSo == 1)
                Console.Write(tuSo);
            else
                Console.Write(tuSo + "/" + mauSo);
        }

        public static PhanSo operator+(PhanSo PS1, PhanSo PS2)  // result = PS1 + PS2
        {
            PhanSo result = new PhanSo();
            result.mauSo = PS1.mauSo * PS2.mauSo;
            result.tuSo = PS1.tuSo * PS2.mauSo + PS1.mauSo * PS2.tuSo;
            result.rutGon();
            return result;
        }

        public static PhanSo operator- (PhanSo PS1, PhanSo PS2)  // result = PS1 - PS2
        {
            PhanSo result = new PhanSo();
            result.mauSo = PS1.mauSo * PS2.mauSo;
            result.tuSo = PS1.tuSo * PS2.mauSo - PS1.mauSo * PS2.tuSo;
            result.rutGon();
            return result;
        }

        public static PhanSo operator* (PhanSo PS1, PhanSo PS2)  // result = PS1 * PS2
        {
            PhanSo result = new PhanSo();
            result.mauSo = PS1.mauSo * PS2.mauSo;
            result.tuSo = PS1.tuSo * PS2.tuSo;
            result.rutGon();
            return result;
        }

        public static PhanSo operator/ (PhanSo PS1, PhanSo PS2)  // result = PS1 / PS2
        {
            if (PS2.tuSo != 0)
            {
                PhanSo result = new PhanSo();
                result.tuSo = PS1.tuSo * PS2.mauSo;
                result.mauSo = PS1.mauSo * PS2.tuSo;
                result.rutGon();
                return result;
            }
            throw new DivideByZeroException("Loi chia cho 0");
        }
    }
}
