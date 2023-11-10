using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapUsingHud
{

    class Program

    {

        static void Main(string[] args)

        {



            String[,] grid = { { "```", "~~~", "```" },

                               { "~~~", "```", "~~~" },

                               { "~~~", "```", "```" }

                                                 };






            void displaymap()
            {
                for (int i = 0; i < grid.GetLength(0); i++)

                {

                    for (int j = 0; j < grid.GetLength(1); j++)

                    {

                        Console.Write(grid[i, j] + " ");



                    }

                    Console.WriteLine();
                }
            }


            void displaymapscale2()
            {
                for (int i = 0; i < grid.GetLength(0); i++)

                {

                    for (int j = 0; j < grid.GetLength(1); j++)

                    {

                        Console.Write(grid[i, j] + " ");
                        Console.Write(grid[i, j] + " ");


                    }

                    Console.WriteLine();
                }
            }

            void displaymapscale3()
            {
                for (int i = 0; i < grid.GetLength(0); i++)

                {

                    for (int j = 0; j < grid.GetLength(1); j++)

                    {

                        Console.Write(grid[i, j] + " ");
                        Console.Write(grid[i, j] + " ");
                        Console.Write(grid[i, j] + " ");

                    }

                    Console.WriteLine();
                }
            }

            displaymap();
            Console.WriteLine();

            Console.ReadKey();

            displaymapscale2();
            Console.WriteLine();

            Console.ReadKey();

            displaymapscale3();
            Console.WriteLine();

            Console.ReadKey();

            Console.ReadKey();

        }

    }

}

