﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathObject = new MathOperation();
            Console.WriteLine("Input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you want, please enter a second number, though this is not necessary.");
            int num2;
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                num2 = 0;
            }
            Console.WriteLine(mathObject.MathOp(num1, num2));
            Console.ReadLine();




            
            
        }
    }
}
