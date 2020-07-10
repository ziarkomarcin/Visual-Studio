using System;
using System.Collections.Generic;
using Logika;
using Tablice;

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

                Tablice.Tables.TableMenu();

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

                Tablice.Tables.TableExit();

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
