using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izveleties uzdevumu- 1 vai 2 ai 3 ");
            string choice = Console.ReadLine();
            int ch = Convert.ToInt16(choice);

            Praktiskie prak = new Praktiskie(); //Klases objekts
            Piemeri piem = new Piemeri();

            switch (ch)
            {
                case 1:
                    prak.Pirmais();
                    break;
                case 2:
                    prak.Otrais();
                    break;
                case 3:
                    piem.Kamer();
                    break;
                    
                default:
                    Console.WriteLine("Nepareiza ievade!");
                    break;
            }

            Console.ReadLine();

        }
    }
}
