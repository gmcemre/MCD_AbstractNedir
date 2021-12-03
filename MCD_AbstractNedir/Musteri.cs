using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractNedir
{
    public class Musteri : temelSinif // Aşağıdaki gibi Implement etmemiz gerekiyor.
        
    {
        public override void testAbstrack()
        {
            Console.WriteLine("musteri => testAbstract");
        }

        public int musteriID { get; set; }

        public Musteri()
        {
            musteriID = 1;
        }

            
    }
}