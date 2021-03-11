using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int length = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("最大值为" + pr.ArrayMax(Array) + "；最小值为" + pr.ArrayMin(Array) + "；总和为" + pr.ArraySum(Array, length) + "；平均值为" + (pr.ArraySum(Array,length) / length) + "。");
            Console.ReadKey();
        }

        public int ArrayMax(int[] a)
        {
            int max = 0;
            foreach(int dates in a)
            {
                if(max<dates)
                {
                    max = dates;
                }
            }
            return max;
        }

        public int ArrayMin(int[] a)
        {
            int min = int.MaxValue;
            foreach (int dates in a)
            {
                if (min > dates)
                {
                    min = dates;
                }
            }
            return min;
        }

        public int ArraySum(int[] a,int l)
        {
            int sum = 0;
            for (int i = 0; i < l; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }
    }
}
