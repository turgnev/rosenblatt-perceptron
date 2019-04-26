using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Perceptron
    {
        int ns;
        double[,] aweights;

        int na;

        int nr;
        double[,] rweights;

        double nu = 0.001;

        double eps = 0.000001;

        public double[] calculate(double[] input)
        {
            double[] a = transferAss(input);
            double[] res = transferRes(a);
            return res;
        }

        public Perceptron(int ns, int na, int nr)
        {
            Random rand = new Random();

            this.ns = ns;
            this.na = na;
            aweights = new double[ns, na];
            for (int i = 0; i < ns; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    aweights[i, j] = rand.Next(-1, 2);
                }
            }

            this.nr = nr;
            rweights = new double[na, nr];
            for (int i = 0; i < na; i++)
                for (int j = 0; j < nr; j++)
                    rweights[i, j] = 0;// rand.NextDouble() * (Convert.ToBoolean(rand.Next(-1, 1)) ? 1 : -1);
        }


        public void train(double[,] trainx, double[,] trainy)
        {
            /*   for (int i=0; i<ns; i++)
               {
                   Console.Write("{0} ", trainx[0, i]);
               }
               Console.WriteLine();
               double[] assss = transferAss(getrow(trainx, ns, 0));
               for (int i = 0; i < na; i++)
               {
                   Console.Write("{0} ", assss[i]);
               }
               Console.WriteLine();
               double[] rss = transferRes(assss);
               for (int i = 0; i < nr; i++)
               {
                   Console.Write("{0} ", rss[i]);
               }
               Console.WriteLine();*/

            int e = 1;
            for (int i = 0; i < 1000 && e != 0; i++)
            {
                //Console.WriteLine("{0} interation", i);
                e = 0;
                for (int j = 0; j < 20; j++)
                {
                    double[] a = transferAss(getrow(trainx, ns, j));
                    double[] r = transferRes(a);
                    e += change_weight(a, r, getrow(trainy, nr, j));
                }
            }

            /*
            for (int i = 0; i < ns; i++)
            {
                Console.Write("{0} ", trainx[0, i]);
            }
            Console.WriteLine();
            assss = transferAss(getrow(trainx, ns, 0));
            for (int i = 0; i < na; i++)
            {
                Console.Write("{0} ", assss[i]);
            }
            Console.WriteLine();
            rss = transferRes(assss);
            for (int i = 0; i < nr; i++)
            {
                Console.Write("{0} ", rss[i]);
            }
            Console.WriteLine();*/
        }

        private double transfer_function(double x, double t)
        {
            if (x >= t)
                return 1;
            else
                return 0;
        }


        private double[] transferAss(double[] input)
        {
            double[] exits = new double[this.na];
            for (int i = 0; i < na; i++)
            {
                exits[i] = 0;
                for (int j = 0; j < ns; j++)
                    exits[i] += aweights[j, i] * input[j];
                exits[i] = transfer_function(exits[i], 0);
            }
            return exits;
        }

   
        private double[] transferRes(double[] input)
        {
            double[] exits = new double[nr];
            for (int i = 0; i < nr; i++)
            {
                exits[i] = 0;
                for (int j = 0; j < na; j++)
                    exits[i] += rweights[j, i] * input[j];
                exits[i] = transfer_function(exits[i], 0);
            }
            return exits;
        }

        public void printA()
        {
            for (int i = 0; i < ns; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    Console.Write($"{aweights[i, j]:+0.00;-0.00} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void printR()
        {
            for (int i = 0; i < na; i++)
            {
                for (int j = 0; j < nr; j++)
                {
                    Console.Write($"{rweights[i, j]:+0.00;-0.00} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static double[] getrow(double[,] m, int len, int n)
        {
            double[] foo = new double[len];
            for (int i = 0; i < len; i++)
                foo[i] = m[n, i];

            return foo;
        }


        private int change_weight(double[] a, double[] r, double[] exp)
        {
            int e = 0;

            for (int i=0; i< nr; i++)
            {
                if (Math.Abs(r[i]-exp[i])>eps)
                {
                    if (r[i] > exp[i])
                    {
                        for (int j = 0; j < na; j++)
                        {
                            //Console.WriteLine("old - {0}, new - {1}",rweights[j, i], rweights[j, i] - nu * a[j]);
                            rweights[j, i] -= nu * a[j];
                        }
                        e++;
                    }
                    else 
                    {
                        for (int j = 0; j < na; j++)
                        {
                            //Console.WriteLine("old - {0}, new - {1}", rweights[j, i], rweights[j, i] + nu * a[j]);
                            rweights[j, i] += nu * a[j];
                        }
                        e++;
                    }
                }
                
            }

            return e;
        }

        public int count_dead(double[,] data , int datasize)
        {
            int[] dead0 = new int[na];
            int[] dead1 = new int[na];
            for (int i=0; i<na; i++)
            {
                dead0[i] = 0;
                dead1[i] = 0;
            }

            int count = 0;
            for (int j = 0; j < datasize; j++)
            {
                double[] a = transferAss(getrow(data, ns, j));
                double[] r = transferRes(a);
                for (int i=0; i<na; i++)
                {
                    if (a[i] == 0)
                        dead0[i]++;
                    if (a[i] == 1)
                        dead1[i]++;
                }
            }

            foreach (int n in dead0)
                if (n == 20)
                    count++;

            foreach (int n in dead1)
                if (n == 20)
                    count++;

            return count;
        }
    }
}
