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
                        Zasady();
                        Logika.Class1.GamePlayerVsPlayer();
                        break;
                    case 2:
                        Zasady();
                        Logika.Class1.GamePlayerVSComputer();
                        break;
                    case 0:
                        ExitMenu();
                        break;

                }

            }
            while (!ok);
        }
        
        public static void ExitMenu()                                          /*  MENU WYJŚCIA  */
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

        public static void Zasady()
        {
            Console.Clear();
            Console.WriteLine("PAMIĘTAJ!!!");
            Console.WriteLine("Wiersze oraz kolumny numerowane są od 0.");
            Console.WriteLine("Jeśli będziesz chciał wybrać pierwszy wiersz - wprowadź 0, drugi - 1, a trzeci - 2.");
            Console.WriteLine("Identycznie działa wybór kolumn.");
            Console.WriteLine();
            Console.WriteLine("Kliknij dowolny przycisk by przejść dalej...");
            Console.ReadKey();
        }
    }
}
