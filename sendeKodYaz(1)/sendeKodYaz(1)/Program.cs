using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sendeKodYaz_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Boyunuzu Yazin");
            Double uzunluq =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cekinizi Yazin");
            Double ceki =Convert.ToDouble(Console.ReadLine());
            double indeks = ceki / (uzunluq * uzunluq);
            Console.WriteLine("sizin indeksiniz {0}",indeks);
            Body beden = new Body(uzunluq,ceki,indeks);
            Console.ReadKey();
        }
    }
    
}
