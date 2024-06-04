using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiel_uygulamasi
{
/* Field:Bir Nesnenin Özelliklerini Veya Veri Alanlarını(Elemanlarını) Temsil Eden Değişkenlerderdir. */
    class Ucgen
    {
        //Field
        public int a;
        public int b;
        public int c;
/* Get: Almak, elde etmek, getirmek anlamında gelir
 *  bir değer döndürmek için kullanılır(return ile).
 *  Get: Get özelliği Kullanılırsa bu özelliği değer ataması yapılamaz. Bu özellik sadece okunanilir(Readonly) özellil olur.
 *  Set: Düzenlemek, ayarlamak, anlamına gelir.
 *  Değişkene değer atamak için kullanılır.
 *  Set ifadesi değer döndürmez, sadece değer alabilir. */
        public int A
        {
            get 
            {
                return a;
            }
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    c = value;
                }
            }
        }
    }
}
