using System;

namespace RubiksCube
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[,,] cubeArray = {{{'O','O','O'},
                                   {'O','O','O'},
                                   {'O','O','O'}},
                                  {{'Y','Y','Y'},
                                   {'Y','Y','Y'},
                                   {'Y','Y','Y'}},
                                  {{'G','G','G'},
                                   {'G','G','G'},
                                   {'G','G','G'}},
                                  {{'W','W','W'},
                                   {'W','W','W'},
                                   {'W','W','W'}},
                                  {{'B','B','B'},
                                   {'B','B','B'},
                                   {'B','B','B'}},
                                  {{'R','R','R'},
                                   {'R','R','R'},
                                   {'R','R','R'}}};

            Console.WriteLine("1st side, 3rd row, 2nd column: {0}", cubeArray[0, 2, 1]);


            /*
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                    | O | | O | | O |                   ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                    | O | | O | | O |                   ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                    | O | | O | | O |                   ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("  -     -     -     -     -     -     -     -     -     -     -     -   ");
            Console.WriteLine("| Y | | Y | | Y | | G | | G | | G | | W | | W | | W | | B | | B | | B | ");
            Console.WriteLine("  -     -     -     -     -     -     -     -     -     -     -     -   ");
            Console.WriteLine("  -     -     -     -     -     -     -     -     -     -     -     -   ");
            Console.WriteLine("| Y | | Y | | Y | | G | | G | | G | | W | | W | | W | | B | | B | | B | ");
            Console.WriteLine("  -     -     -     -     -     -     -     -     -     -     -     -   ");
            Console.WriteLine("  -     -     -     -     -     -     -     -     -     -     -     -   ");
            Console.WriteLine("| Y | | Y | | Y | | G | | G | | G | | W | | W | | W | | B | | B | | B | ");
            Console.WriteLine("  -     -     -     -     -     -     -     -     -     -     -     -   ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                    | R | | R | | R |                   ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                    | R | | R | | R |                   ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                      -     -     -                     ");
            Console.WriteLine("                                    | R | | R | | R |                   ");
            Console.WriteLine("                                      -     -     -                     ");
            */
            Console.ReadLine();
        }
    }
}
