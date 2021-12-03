using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractNedir
{
    public abstract class temelSinif
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temelSinif()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void test()
        {
            Console.WriteLine("Temel sınıf => Test");
        }

        public abstract void testAbstrack(); // metot imzası
        // {} Çengelli parantez kullanılmaz.


        
    }
}
