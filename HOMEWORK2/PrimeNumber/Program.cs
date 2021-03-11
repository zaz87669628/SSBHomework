using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {

        static void Main(string[] args)
        {   Program pr = new Program();
            Console.WriteLine("请输入整数：");
            int intA = Convert.ToInt32(Console.ReadLine());
            pr.PrimeNumberSelect(intA);
            Console.ReadKey();
        }

        public void PrimeNumberSelect(int i)
        {
            if (IsPrimeNumber(i)==true)
            {
                Console.WriteLine("该数为质数");
                return;
            }
            
            for(int k = 2; k < i - 1; k++)
            {
                if (IsPrimeNumber(k) == true)
                {
                    int j = i / k;
                    if (i % k == 0)
                    {
                        Console.WriteLine("" + k);
                        
                    }
                    if (i % k != 0) { 
                        
                    }
                    
                }
            }

        }

        private Boolean IsPrimeNumber(int num)
        {
            for(int n = 2; n *n<num; n++)
            {
                if (num % n == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
