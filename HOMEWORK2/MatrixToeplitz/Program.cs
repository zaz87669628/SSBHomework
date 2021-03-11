using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixToeplitz
{
    class Program
    {
        static void Main(string[] args)
        {   Program mt = new Program();
            Console.WriteLine("请问有几行");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请问有几列");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[m, n];
            for (int i = 0; i < m; i++)
            {
               
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("请输入第" + (i+1) + "行第" + (j+1) + "个数字");
                    matrix[i, j] = int.Parse(Console.ReadLine());  
                }
            } 
            Console.WriteLine(mt.isToepliz(matrix, m, n));
            Console.ReadKey();
        }

        private Boolean isToepliz(double[,] m,int p,int q)
        {
            int i;
            int j;
            bool t=true;
            for(i = 1; i < p; i++) 
            { 
                for(j = 0; j < q-1; j++)
                {
                    if (m[i-1 , j] != m[i , j +1])
                    { 
                        t = false;
                    }
                }
            }
            return t;
        }
    }
}
