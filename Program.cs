using System;

namespace KolkoKrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()                                          //MENU PODSTAWOWE GRY
        {
            Console.WriteLine();
            Console.WriteLine("|   KÓŁKO I KRZYŻYK   |");
            Console.WriteLine(" _____________________");
            Console.WriteLine("|       START(1)      |");
            Console.WriteLine("|        EXIT(2)      |");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("By rozpocząć grę musisz wprowadzić liczbę odpowiadającą pozycji w Menu Głównym gry...");

            ChooseMenu();
        }
        


    }
}