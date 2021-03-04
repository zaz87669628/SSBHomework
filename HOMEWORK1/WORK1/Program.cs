using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORK1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数");
            string strA = Console.ReadLine();

            Console.WriteLine("请输入第二个数");
            string strB = Console.ReadLine();

            Console.WriteLine("请输入运算符");
            String strX = Console.ReadLine();

            if (strA != "" && strB != "")
            {
                int intA = Convert.ToInt32(strA);
                int intB = Convert.ToInt32(strB);
                int intC = new int();
                switch (strX)
                {
                    case "+":
                        intC = intA + intB;
                        break;

                    case "-":
                        intC = intA - intB;
                        break;

                    case "*":
                        intC = intA * intB;
                        break;

                    case "/":
                        intC = intA / intB;
                        break;

                    default:
                        Console.WriteLine("不支持该运算符");
                        break;
                }
                Console.WriteLine("计算的结果是" + intC);
            }
            else
            {
                Console.WriteLine("您输入了空值");
            }
           
            Console.ReadKey();
        }
    }
}
