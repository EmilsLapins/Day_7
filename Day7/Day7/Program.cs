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
            Console.WriteLine("Izveleties uzdevumu- 1 vai 2 vai 3 vai 4 vai 5 vai 6");
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
                case 4:
                    piem.Darit();
                    break;
                case 5:
                    prak.Tresais();
                    break;
                case 6:
                    prak.Ceturtais();
                    break;

                default:
                    Console.WriteLine("Nepareiza ievade!");
                    break;
            }

            Console.ReadLine();

        }
    }
}
