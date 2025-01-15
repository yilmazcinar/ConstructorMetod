using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMetod
{
    internal class Baby
    {
        //Constructor metod.
        public Baby()
        {

            Console.WriteLine("Ingaaaaa");
            
            Isim = "Daha isim koyulmadı.";

            DogumTarihi = DateTime.Now;

        }


        public Baby(string isim, string soyIsim)
        {
            Isim = isim;
            
            Soyisim = soyIsim;
            
            Console.WriteLine("Ingaaaaa");

            DogumTarihi = DateTime.Now;

        }

        public string Isim {  get; set; }

        public string Soyisim {  get; set; }

        public DateTime DogumTarihi { get; set; }


    }
}
