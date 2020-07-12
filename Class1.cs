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

        public static void BoardDefinition(char[,] plansza)         //definicja tablicy
        {
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    plansza[a, b] = '-';       
                }
            }
        }

        public static void GamePlayerVsPlayer()
        {
            int test = 0;
            char gracz = 'X';

            char[,] plansza = new char[3, 3];

            BoardDefinition(plansza);

            bool gra = false;
            while (gra == false)
            {
                Console.Clear();
                Console.WriteLine($"RUNDA GRACZA {gracz}!");
                Console.WriteLine();

                ShowGame(plansza);
                int wiersz = 0;
                int kolumna = 0;
                Console.WriteLine();

                //obsługa zmiennych
                do
                {
                    Console.Write("Wprowadź wiersz: ");
                    ConsoleKeyInfo wierszz = Console.ReadKey();
                    if (wierszz.KeyChar == '0')
                    {
                        test = 0;
                        wiersz = 0;
                        Console.WriteLine();
                    }
                    else if (wierszz.KeyChar == '1')
                    {
                        test = 0;
                        wiersz = 1;
                        Console.WriteLine();
                    }
                    else if (wierszz.KeyChar == '2')
                    {
                        test = 0;
                        wiersz = 2;
                        Console.WriteLine();
                    }
                    else
                    {
                        test++;
                        Console.WriteLine();
                    }
                } while (test > 0);

                do
                {
                    Console.Write("Wprowadź kolumnę: ");
                    ConsoleKeyInfo kolumnaa = Console.ReadKey();
                    if (kolumnaa.KeyChar == '0')
                    {
                        test = 0;
                        kolumna = 0;
                        Console.WriteLine();
                    }
                    else if (kolumnaa.KeyChar == '1')
                    {
                        test = 0;
                        kolumna = 1;
                        Console.WriteLine();
                    }
                    else if (kolumnaa.KeyChar == '2')
                    {
                        test = 0;
                        kolumna = 2;
                        Console.WriteLine();
                    }
                    else
                    {
                        test++;
                        Console.WriteLine();
                    }
                } while (test > 0);
                //koniec obsługi zmiennych
                if (plansza[wiersz, kolumna] != '-') //sprawdzanie dostepności współrzędnych
                {

                    Console.WriteLine("Pole zostało już zajęte!");
                    Console.WriteLine("Wciśnij ENTER by kontynuować.");
                    Console.ReadKey();

                }
                else if (plansza[wiersz, kolumna] == '-')
                {
                    plansza[wiersz, kolumna] = gracz;
                    gracz = NextPlayer(gracz);
                }


            }
        }
        public static char NextPlayer(char gracz)
        {
            if (gracz == 'X')
            {
                return 'O';
            }
            else return 'X';
        }
    }
}
