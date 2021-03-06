﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double[] getrow(double[,] m, int len, int n)
        {
            double[] foo = new double[len];
            for (int i = 0; i < len; i++)
                foo[i] = m[n, i];

            return foo;
        }

        static void Main(string[] args)
        {
            int data_size = 30;
            double[,] input = { 
                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 0, 0, 1, 0, 0,
                    0, 1, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 1, 1, 0 }, 

                  { 0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0}, 

                  { 0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0 }, 

                  { 0, 0, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 1,
                    0, 0, 0, 1, 0 }, 

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0 }, 

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0 }, 

                  { 1, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 1, 0, 0 }, 

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0 }, 

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  //////////////////////////
                  { 0, 1, 1, 1, 1,
                    0, 1, 0, 0, 1,
                    0, 1, 0, 0, 1,
                    0, 1, 0, 0, 1,
                    0, 1, 1, 1, 1 },

                  { 0, 0, 1, 0, 0,
                    0, 1, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 1, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0},

                  { 1, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    1, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    1, 1, 1, 1, 0 },

                  { 0, 1, 0, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 1,
                    0, 0, 0, 1, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 0, 1, 0, 0, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 1, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 1, 0, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 0, 1, 0 },
                  ///////////////////
                  { 1, 1, 1, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 0 },

                  { 0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 1, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0},

                  { 0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 0, 1, 0, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 1,
                    0, 0, 0, 1, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 0, 1, 0, 0, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 1, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 1, 0, 0 },

                  { 0, 0, 1, 1, 1,
                    0, 0, 1, 0, 1,
                    0, 0, 1, 1, 1,
                    0, 0, 1, 0, 1,
                    0, 0, 1, 1, 1 },

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 0, 1, 0 }
            };
            double[,] res = { 
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, 
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, 
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 }, 
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },

                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },

                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }
            };


            int test_size = 10;
            double[,] test =
            {
                  { 1, 1, 1, 0, 0,
                    1, 0, 1, 0, 0,
                    1, 0, 1, 0, 0,
                    1, 0, 1, 0, 0,
                    1, 1, 1, 0, 0 },

                  { 0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 1, 1, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 1, 0, 0,
                    0, 1, 1, 1, 0},

                  { 0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 0, 0, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    1, 0, 0, 1, 0,
                    1, 1, 1, 1, 1,
                    0, 0, 0, 1, 0 },

                  { 0, 1, 1, 0, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 1, 0 },

                  { 0, 1, 1, 0, 0,
                    0, 1, 0, 0, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 1, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 0, 0,
                    0, 1, 1, 0, 0,
                    0, 0, 1, 0, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0 },

                  { 0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 0, 1, 1, 0 },
            }; 

            Perceptron p = new Perceptron(25, 100, 10);
            p.train(input, res);

            //p.printR();


            double[] my_res;
            for (int i=0; i<test_size; i++)
            {
                my_res = p.calculate(getrow(test, 25, i));
                foreach(double d in my_res)
                    Console.Write("{0} ", d);
                Console.WriteLine();
            }

            Console.WriteLine("testc");
            double[] testc = {
                    0, 1, 1, 1, 0,
                    0, 1, 0, 1, 0,
                    0, 1, 1, 1, 0,
                    0, 0, 0, 1, 0,
                    0, 1, 1, 1, 0 };

            double[] sres = p.calculate(testc);
            for (int i = 0; i < 10; i++)
            {
                    Console.Write("{0} ", sres[i]);
            }

            Console.Write("\nмертвые {0} ", p.count_dead(input, data_size));

            Console.ReadKey();
        }
    }
}
