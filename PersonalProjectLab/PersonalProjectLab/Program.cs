﻿using System;
using System.IO;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculate calc = new Calculate();
            float answer;
            Console.WriteLine("Please input First Number: ");
            calc.Num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please input Second Number: ");
            calc.Num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("Please input the number that corresponds to the method you'd like to use: ");
            int methodSelector = int.Parse(Console.ReadLine());



            if (methodSelector == 1)
            {
                answer = calc.Add();
            }
            else if (methodSelector == 2)
            {
                answer = calc.Subtract();
            }
            else if (methodSelector == 3)
            {
                answer = calc.Multiply();
            }
            else
            {
                answer = calc.Divide();
            }

            Console.WriteLine("Answer:");
            Console.WriteLine(answer);

        }
    }
}
