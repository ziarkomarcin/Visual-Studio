using System;
using Logika;

namespace KolkoKrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()                                          /*   MENU PODSTAWOWE GRY     */
        {
            bool ok = false;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("|   KÓŁKO I KRZYŻYK   |");
                Console.WriteLine(" _____________________");
                Console.WriteLine("|       START(1)      |");
                Console.WriteLine("|        EXIT(2)      |");
                Console.WriteLine();
                Console.WriteLine();

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
                        //Logika.Class1.GamePlayerVsPlayer();
                        break;
                    case 2:
                        ExitMenu();
                        break;

                }

            }
            while (!ok);
        }
        public static void ExitMenu()
        {
            bool exitOk = false;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Czy na pewno chcesz wyjść z gry?");
                Console.WriteLine("       TAK(1)   NIE(0)       ");
                int choose;
                try
                {
                    choose = int.Parse(Console.ReadLine().Trim());
                }
                catch (FormatException)
                {
                    continue;
                }
                switch (choose)
                {
                    case 1:
                        Environment.Exit(0);
                        break;
                    case 0:
                        Menu();
                        break;
                }
            }
            while (!exitOk);
        }

    }
}
