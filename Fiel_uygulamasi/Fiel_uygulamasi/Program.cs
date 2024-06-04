using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiel_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            Console.WriteLine("A değeri gir: ");
            ucgen.A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B değeri gir: ");
            ucgen.B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C değeri gir: ");
            ucgen.C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A kenarının Uzunluğu: " + ucgen.A);
            Console.WriteLine("B kenarının Uzunluğu: " + ucgen.B);+
            Console.WriteLine("C kenarının Uzunluğu: " + ucgen.C);
            Console.ReadLine();
        }
    }
}
