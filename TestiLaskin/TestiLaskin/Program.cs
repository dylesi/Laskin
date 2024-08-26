using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestiLaskin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("|  _______        _   _ _           _    _          |");
            Console.WriteLine("| |__   __|      | | (_) |         | |  (_)         |");
            Console.WriteLine("|    | | ___  ___| |_ _| | __ _ ___| | ___ _ __     |");
            Console.WriteLine("|    | |/ _ \\/ __| __| | |/ _` / __| |/ / | '_ \\    |");
            Console.WriteLine("|    | |  __/\\__ \\ |_| | | (_| \\__ \\   <| | | | |   |");
            Console.WriteLine("|    |_|\\___||___/\\__|_|_|\\__,_|___/_|\\_\\_|_| |_|   |");
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("         Valittavissa olevat operaatiot:");
            Console.WriteLine("   Yhteenlasku  Miinuslasku  Kertolasku  Jakolasku");

            bool eivalmis = true;

            while (eivalmis == true)
            {
                string[] operaatiot = { "Yhteenlasku", "Miinuslasku", "Kertolasku", "Jakolasku" };
                string valitse_operaatio = Console.ReadLine();

                if (operaatiot.Contains(valitse_operaatio) == false)
                {
                    Console.WriteLine("Ei valittavissa oleva vaihtoehto.");
                }
                else if (valitse_operaatio == "Yhteenlasku")
                {
                  
                    Console.WriteLine("Anna kaksi numeroa jotka lasketaan yhteen");
                    Console.WriteLine("Anna ensimmäinen numero:");
                    var numero_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Anna toinen numero");
                    var numero_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yhteenlaskun tulos on: " + numero_1 + numero_2);

                }
                else if (valitse_operaatio == "Miinuslasku")
                {
                    Console.WriteLine("Anna kaksi numeroa jotka vähennetään");
                    Console.WriteLine("Anna ensimmäinen numero josta vähennetään:");
                    var numero_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Anna toinen numer millä vähennetään");
                    var numero_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Vähennyslaskun tulos on: " + (numero_1 - numero_2));
                }
                else if (valitse_operaatio == "Kertolasku")
                {
                    Console.WriteLine("Anna kaksi numeroa jotka kerrotaan yhteen");
                    Console.WriteLine("Anna ensimmäinen numero:");
                    var numero_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Anna toinen numero");
                    var numero_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yhteenlaskun tulos on: " + numero_1 * numero_2);
                }
                else if (valitse_operaatio == "Jakolasku")
                {
                    Console.WriteLine("Anna kaksi numeroa joilla jaetaan");
                    Console.WriteLine("Anna ensimmäinen numero:");
                    var numero_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Anna toinen numero");
                    var numero_2 = Convert.ToInt32(Console.ReadLine());

                    if (numero_1 == 0 || numero_2 == 0)
                    {
                        Console.WriteLine("Et voi jakaa nollalla!");
                    }
                    else
                    {
                        Console.WriteLine("Jakolaskun tulos on: " + numero_1 / numero_2);
                    }
                    
                }
            }

            

        }
    }
}
