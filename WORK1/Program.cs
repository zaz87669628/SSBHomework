﻿using System;
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
            Console.WriteLine("输入第一个数字");
            string strA = Console.ReadLine();
            if (strA != "")
            {
                Console.WriteLine("输入第二个数字");
                string strB = Console.ReadLine();
                if (strB != "")
                {
                    Console.WriteLine("请输入运算符");
                    string strX = Console.ReadLine();
                    int intA = int.Parse(strA);
                    int intB = int.Parse(strB);
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
                            Console.WriteLine("不支持的运算符");
                            break;
                    }
                    Console.WriteLine("计算的结果是" + intC);
                }
                else
                {
                    Console.WriteLine("您输入的是空值");
                }
            }
            else
            {
                Console.WriteLine("您输入的是空值");
            }
            Console.ReadKey();
        }
    }
}
