using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUygulama
{
    class Dikdortgen
    {
        private int a, b;
        
        public Dikdortgen(int a, int b)//Parametreli Metot.
        {
            this.a = a;
            this.b = b;
        }

        public int AlanHesapla()
        {
            return a * b;
        }

        public int CevreHesapla()
        {
            return 2 * (a + b);
        }
    }
}
