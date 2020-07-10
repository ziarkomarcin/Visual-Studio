using System;
using System.Collections.Generic;
using Logika;

namespace KolkoKrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()                                          /*  MENU PODSTAWOWE GRY  */
        {
            bool ok = false;

            do
            {
                Console.Clear();
                Console.WriteLine("KÓŁKO I KRZYŻYK");
                Console.WriteLine();

                string[] menu = new string[2] { "START", "WYJŚCIE" };
                int counter = 1;
                foreach (string el in menu)
                {
                    if (el == "WYJŚCIE") {
                        Console.WriteLine($"[{0}] {el}");
                    }
                    else
                    {
                        Console.WriteLine($"[{counter}] {el}");
                        counter++;
                    }
                }

                int option;
                try
                {
                    option = int.Parse(Console.ReadLine().Trim());
                }
                catch (FormatException)
                {
                    continue;
                }
                switch (option)
                {
                    case 1:
                        Logika.Class1.GamePlayerVsPlayer();
                        break;
                    case 0:
                        ExitMenu();
                        break;

                }

            }
            while (!ok);
        }

        public static void ExitMenu()                                          /*  WYJŚCIE Z GRY  */
        {
            bool ok = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Czy chcesz zakończyć?");
                Console.WriteLine();

                string[] exit = new string[2] { "WRÓĆ", "WYJDŹ" };
                int counter = 1;
                foreach (string el in exit)
                {
                    if (el == "WYJDŹ")
                    {
                        Console.WriteLine($"[{0}] {el}");
                    }
                    else
                    {
                        Console.WriteLine($"[{counter}] {el}");
                        counter++;
                    }
                }
                    int option;
                    try
                    {
                        option = int.Parse(Console.ReadLine().Trim());
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                    switch (option)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            Menu();
                            break;

                    }

                
                
            } while (!ok);
        } 

    }
}
