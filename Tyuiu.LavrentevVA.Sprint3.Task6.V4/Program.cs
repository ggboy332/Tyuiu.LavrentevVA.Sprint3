﻿using Tyuiu.LavrentevVA.Sprint3.Task6.V4.Lib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint3.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

            int startValue1 = 14;
            int stopValue1 = 20;

            Console.WriteLine($"начало отрезка = {startValue1}");
            Console.WriteLine($"конец отрезка = {stopValue1}");


            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine($"Сумма всех делителей больше 9 на отрезке: {ds.GetSumTheDivisors(startValue1, stopValue1)}");

            Console.ReadKey();

        }
    }
}
