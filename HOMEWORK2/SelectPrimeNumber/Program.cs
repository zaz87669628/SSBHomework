using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectPrimeNumber
{
    class Program
    {
        public void selectNumber(int[] ar)
        {
            
            for (int i = 2; i <= 100; i++)
            {
                int j = i;
                ar[i-2] = selectPrime(j);
                if (ar[i-2] != 0)
                {
                    Console.WriteLine(ar[i-2] + "");
                }
            }
        }

        public int selectPrime(int x)
        {   
            for(int k = 2; k <x; k++)
            {

                if (x % k == 0)
                {
                    x = 0;
                }
            }
            return x;

        }


        static void Main(string[] args)
        {
            Program spn = new Program();
            int[] a = new int[99];
            spn.selectNumber(a);
            Console.ReadKey();
        }
    }
}
