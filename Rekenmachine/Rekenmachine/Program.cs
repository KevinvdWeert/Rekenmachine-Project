using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    Console.WriteLine("Voer nu de functie in die (+, :, -, x):");
                    string Input2 = Console.ReadLine().ToLower();

                    Console.WriteLine("Voer nu uw tweede getal in:");
                    double getal2 = double.Parse(Console.ReadLine().Replace('.', ','));

                    if (Input2 == "+")
                    {
                        Console.WriteLine("resultaat:" + (getal1 + getal2));
                    }
                    else if (Input2 == ":")
                    {
                        Console.WriteLine("resultaat:" + (getal1 / getal2));
                    }
                    else if (Input2 == "-")
                    {
                        Console.WriteLine("resultaat:" + (getal1 - getal2));
                    }
                    else if (Input2 == "x")
                    {
                        Console.WriteLine("resultaat:" + (getal1 * getal2));
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