﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    public class MyMathClass
    {
        public int Area(int num1, int num2)
        {
            int b = num1;
            int h = num2;
            Console.WriteLine("If your numbers were the base and height of a square, the area would be:");
            return b * h;

        }
        public static int Plus(int numPlus)
        {
            int numUsed = 7;
            Console.WriteLine("Your number plus 7 is:");
            return numPlus + numUsed;
        }
        public static int Minus(int numMinus)
        {
            int numUsed = 5;
            Console.WriteLine("Your number minus five is:");
            return numMinus - numUsed;
        }
    }
}
