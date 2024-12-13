using System;

namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            while (restart)
            {
                Console.WriteLine("Voer uw eerste getal in:");
                double getal1 = double.Parse(Console.ReadLine().Replace('.', ','));
                Console.WriteLine("Voer nu de functie in die (+, :, -, x, % and Squareroot):");
                Console.WriteLine("Bij squareroot, functie volledig over typen.");
                string Input2 = Console.ReadLine().ToLower();

                double getal2 = 0;

                if (Input2 != "squareroot")
                {
                    Console.WriteLine("Voer nu uw tweede getal in:");
                    getal2 = double.Parse(Console.ReadLine().Replace('.', ','));
                }

                if (Input2 == "+")
                {
                    Console.WriteLine("Resultaat: " + (getal1 + getal2));
                }
                else if (Input2 == ":")
                {
                    Console.WriteLine("Resultaat: " + (getal1 / getal2));
                }
                else if (Input2 == "-")
                {
                    Console.WriteLine("Resultaat: " + (getal1 - getal2));
                }
                else if (Input2 == "x")
                {
                    Console.WriteLine("Resultaat: " + (getal1 * getal2));
                }
                else if (Input2 == "%")
                {
                    Console.WriteLine("Resultaat: " + (getal1 / getal2 * 100));
                }
                else if (Input2 == "squareroot")
                {
                    if (getal1 >= 0)
                    {
                        Console.WriteLine("Resultaat: " + Math.Sqrt(getal1));
                    }
                }

                Console.WriteLine("Wilt u nog een berekening maken? (ja/nee)");
                if (Console.ReadLine().ToLower() != "ja")
                {
                    restart = false;
                    Console.WriteLine("Het programma wordt afgesloten.");
                }
            }
        }
    }
}
