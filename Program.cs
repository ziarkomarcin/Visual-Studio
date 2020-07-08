using System;

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
                        Logika.Class1.GamePlayerVsPlayer();
                        break;
                    case 2:
                        //ExitMenu();
                        break;

                }

            }
            while (!ok);
        }
    }
}
