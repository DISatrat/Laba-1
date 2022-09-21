//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Text;

//namespace Laba_1.Level_3
//{
//    class Num_6
//    {
//        static void Main(string[] args)
//        {
//            double lim = 0.0001;
//            double sum = 0;
//            double s = 0;

//            double y = 0;
//            for (double x = 0.1; x <= 1; x += 0.1)
//            {
//                for (int i = 1; i < 10; i++)
//                {

//                    while (y <= 0.0001)
//                    {

//                        s = (Math.Pow(-1, i + 1)) * (Math.Pow(x, 2 * i + 1)) / (4 * i * i - 1);

//                        y = ((1 + x * x) * Math.Atan(x)) / 2 - (x / 2);

//                        sum += s;
//                        Console.WriteLine("при x=" + x + " sum=" + sum + " y=" + y);

//                    }

//                }
//            }


//        }
//    }
//}
