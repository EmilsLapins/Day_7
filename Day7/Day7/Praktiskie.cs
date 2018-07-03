using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Praktiskie
    {
        public void Pirmais()
        {
            //Izvadit summu skaitlu reizinajumam * 2 (skaitli no 1-9)
            //t.i. (1*2) + (2*2) + (3*2) +...
            Console.WriteLine("Ludzu ievadiet skaitli no 1 lidz 9");
            int sakums = Convert.ToInt16(Console.ReadLine());

            int Rez = 0;
            for (int i = 1; i < sakums +1; i++)
            {

                Rez =  Rez + (i * 2);

                Console.WriteLine("Test   " + Rez);
            }
            Console.WriteLine("...Done   " + Rez);
            
        }

        

        public void Otrais()
        {
            //Likt cilvekam meginat uzminet skaitli. Ja skaitlis sakrit ar 11, tad pareizi
            //Max meginajumu skaits - 5.
            //Ja 5 reizes nesanak, tad izvadit pazinojumu. 

            

            for (int i = 0; i < 5; i++)
            {
                int reizes = 5 - i;
                Console.WriteLine("Palikusi {0} meiginajumi!", reizes);

                Console.WriteLine("Ludzu miniet skaitli!");
                int sakums = Convert.ToInt16(Console.ReadLine());


                if (sakums == 11)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Pareizi!");
                    break;
                }
                else 
                {
                    if (i == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Game Over!");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("<< Insert coin here >>");
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Meiginiet velreiz!");
                    Console.ResetColor();
                    
                }
                
            }
        }
        public void Tresais() // parveidot pirmo, ta lai izmantotu while ciklu 
        {
            //Izvadit summu skaitlu reizinajumam * 2 (skaitli no 1-9)
            //t.i. (1*2) + (2*2) + (3*2) +...
            Console.WriteLine("Ludzu ievadiet skaitli no 1 lidz 9");
            int sakums = Convert.ToInt16(Console.ReadLine());

            int iteracija = 1;

            int Rez = 0;
            while (iteracija < sakums +1)
            {

                Rez = Rez + (iteracija * 2);
                iteracija++;
                

                Console.WriteLine("Test   "  + Rez);
            }
            Console.WriteLine("...Done   " + Rez );

        }
       

    }
}

