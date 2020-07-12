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

        public static void BoardDefinition(char [,] plansza)
        {
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    plansza[a, b] = '-';        //definicja tablicy
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

                    if (CheckWin(plansza, gracz, gra) == true)
                    {
                        gra = true;
                    }

                    gracz = NextPlayer(gracz);
                }


            }
        }
        public static bool CheckWin(char[,] plansza, char gracz, bool gra)      //sprawdzenie schematu wygranej
        {
            if (gracz == plansza[0, 0] && gracz == plansza[0, 1] && gracz == plansza[0, 2])             //(1) Pierwszy wiersz - OK
            {
                WinShow(plansza, gracz);
                return true;
            }
            else if (gracz == plansza[1, 0] && gracz == plansza[1, 1] && gracz == plansza[1, 2])        //(2) Drugi wiersz - OK
            {
                WinShow(plansza, gracz);
                return true;
            }
            else if (gracz == plansza[2, 0] && gracz == plansza[2, 1] && gracz == plansza[2, 2])        //(3) Trzeci wiersz - OK
            {
                WinShow(plansza, gracz);
                return true;
            }
            else if (gracz == plansza[0, 0] && gracz == plansza[1, 0] && gracz == plansza[2, 0])        //(4 )Pierwsza kolumna - OK
            {
                WinShow(plansza, gracz);
                return true;
            }
            else if (gracz == plansza[0, 1] && gracz == plansza[1, 1] && gracz == plansza[2, 1])        //(5) Druga kolumna - OK
            {
                WinShow(plansza, gracz);
                return true;
            }
            else if (gracz == plansza[0, 2] && gracz == plansza[1, 2] && gracz == plansza[2, 2])        //(6) Trzecia kolumna - OK
            {
                WinShow(plansza, gracz);
                return true;
            }
            else if (gracz == plansza[0, 0] && gracz == plansza[1, 1] && gracz == plansza[2, 2])        //(7) Ukos od lewej - OK
            {
                WinShow(plansza, gracz);
                return true;
            }
            else if (gracz == plansza[0, 2] && gracz == plansza[1, 1] && gracz == plansza[2, 0])        //(8) Ukos od prawej - OK
            {
                WinShow(plansza, gracz);
                return true;
            }
            return false;
        }
        //public static int Random()
        //{
        //    Random cos = new Random();
        //    int a = cos.Next(0, 2);
        //    return a;
        //}

        public static void WinShow(char[,] plansza, char gracz)        //tekst o wygranej
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"GRACZ {gracz} WYGRAŁ TĘ GRĘ!");
            Console.WriteLine();
            ShowGame(plansza);
            Console.WriteLine("Kliknij dowolny klawisz by przejść do menu...");
            Console.ReadKey();
        }

        public static void GamePlayerVSComputer()
        {
            int test = 0;
            char gracz = 'X';
            int check = 0;
            char[,] plansza = new char[3, 3];
            BoardDefinition(plansza);

            bool gra = false;
            while (gra == false)
            {
                Console.Clear();
                Console.WriteLine($"RUNDA GRACZA {gracz}!");
                Console.WriteLine();
                int flag = 0;
                int w;
                int k;
                ShowGame(plansza);
                int wiersz = 0;
                int kolumna = 0;
                Console.WriteLine();
                if (NextPlayer(gracz) == 'O')
                {
                    //obsługa zmiennych
                    do
                    {
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
                        if (plansza[wiersz, kolumna] != '-') //sprawdzanie dostepności współrzędnych
                        {

                            Console.WriteLine("Pole zostało już zajęte!");
                            Console.WriteLine("Wciśnij ENTER by kontynuować.");
                            Console.ReadKey();
                            check = 1;

                        }
                    } while (check == 1);
                    //koniec obsługi zmiennych
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
