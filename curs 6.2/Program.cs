using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs_6._2
{
    class Program
    {
        static void back(int k,int n, int[] sol,bool[] vis)
        {
            if(k>=n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(sol[i] + " ");
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i;
                        back(k + 1, n, sol, vis);
                        vis[i] = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 3;
            int[] sol = new int[n];
            bool[] visited = new bool[n];
            back(0, n, sol, visited);
            Console.ReadKey();
        }
    }
}
