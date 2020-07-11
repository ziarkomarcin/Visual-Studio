using System;

namespace Logika
{
    public class Class1
    {
        public static void ShowGame(char[,] plansza) //wyświetlenie planszy
        {
            for (int wiersz = 0; wiersz < 3; wiersz++)
            {
                Console.Write("| ");
                for (int kolumna = 0; kolumna < 3; kolumna++)
                {
                    Console.Write(plansza[wiersz, kolumna]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        public static void GamePlayerVsPlayer()
        {

            char[,] plansza = new char[3, 3];
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    plansza[a, b] = '-';        //definicja tablicy
                }
            }
        }
    }
}
