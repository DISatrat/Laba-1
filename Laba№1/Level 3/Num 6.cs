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

//            for (double k = 1; k <= 10; k += 1)
//            {
//                double x = k / 10;
//                double sum = 0;
//                double i = 1;

//                while (true)
//                {
//                    double s = 0;
//                    s = (Math.Pow(-1, i + 1)) * (Math.Pow(x, 2 * i + 1)) / (4 * Math.Pow(i, 2) - 1);

//                    if (Math.Abs(s) < 0.0001)
//                    {
//                        break;
//                    }
//                    sum += s;
//                    i++;
//                }

//                double y = (1 + Math.Pow(x, 2)) * Math.Atan(x) / 2 - (x / 2);
//                Console.WriteLine("При x = " + x + "; sum = " + sum + "; y = " + y);
//            }


//        }
//    }
//}
