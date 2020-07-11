using System;

namespace Tablice
{
    public class Tables
    {
        public static void TableMenu()
        {
            string[] menu = new string[3] { "GRACZ VS GRACZ", "GRACZ VS KOMPUTER", "WYJŚCIE" };
            int counter = 1;
            foreach (string el in menu)
            {
                if (el == "WYJŚCIE")
                {
                    Console.WriteLine($"[{0}] {el}");
                }
                else
                {
                    Console.WriteLine($"[{counter}] {el}");
                    counter++;
                }
            }
        }

        public static void TableExit()
        {
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
        }
    }
}
