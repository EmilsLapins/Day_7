using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Piemeri
    {
        public void Kamer()
        {
            // while  and do..while
            string ievade = "";
            int skaititajs = 0;
            while(ievade != "iziet")
            {
                Console.WriteLine("Uzraksti kaut ko!");
                ievade = Console.ReadLine();
                Console.WriteLine("Mes esam iteracija nr " + skaititajs);
                skaititajs++;
                Console.WriteLine("Vel esam cikla!");

            }
            Console.WriteLine("Jau izgajam ara!");

        }

        public void Darit()
        {
            string ievade = "";
            int skaititajs = 0;
            
            do
            {
                Console.WriteLine("Uzraksti kaut ko!");
                ievade = Console.ReadLine();
                Console.WriteLine("Mes esam iteracija nr " + skaititajs);
                skaititajs++;
                Console.WriteLine("Vel esam cikla!");
                
            } while (ievade != ""); 
            Console.WriteLine("Jau izgajam ara!");
            
        }

    }
}
