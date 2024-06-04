using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Buyuk_Sayi_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyukSayiBul bs = new BuyukSayiBul();
            int a = 100;
            int b = 25;
            int sonuc = bs.BuyukOlanibul(a, b);
            Console.WriteLine("Büyük olan sayı: {0}", sonuc);
            Console.ReadLine();
        }
    }
}
