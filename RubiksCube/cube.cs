using System;
using System.Collections.Generic;
//using RubiksCube.CubeLogger;

namespace RubiksCube
{
    public class cube
    {
        public cube()
        {
            List<String> lista = new List<string>();
            List<char[,]> cubeSides = new List<char[,]>();

            ResetCube(cubeSides);

            char[,,] cubeArray = new char[6, 3, 3] {{{'O','O','O'},
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
        }

        private void ResetCube(List<char[,]> cubeSides)
        {
            throw new NotImplementedException();
        }

        static void printCube(char[,,] matrix)
        {
            for (int index = 0; index < 3; index++)
            {
                char[] currentRow = new char[3] { matrix[0,index,0], matrix[0,index,1], matrix[0,index,2] };
                printSingleEdge();
                printSingleSide(currentRow);
                printSingleEdge();
            }


        }
        static void printSingleEdge()
        {
            Console.WriteLine("                                      -     -     -                     ");
        }
        static void printSingleSide(char[] array)
        {
            Console.WriteLine("                                    | {0} | | {1} | | {2} |                   ",
                              array[0],
                              array[1],
                              array[2]);
        }
        static void printFourSides(char[,] array)
        {
            Console.WriteLine("| {0} | | {1} | | {2} | | {3} | | {4} | | {5} | | {6} | | {7} | | {8} | | {9} | | {10} | | {11} | ",
                              array[0, 0],
                              array[0, 1],
                              array[0, 2],
                              array[1, 0],
                              array[1, 1],
                              array[1, 2],
                              array[2, 0],
                              array[2, 1],
                              array[2, 2],
                              array[3, 2],
                              array[3, 2],
                              array[3, 2]);
        }
        static void printFourEdges()
        {
            Console.WriteLine("  -     -     -     -     -     -     -     -     -     -     -     -   ");
        }
    }
}
