﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            bool paramsAreGiven = (args.Length >= 3 ? true : false);
            string operation = "none";
            double[] operands = new double[2];
            double result = double.NaN;

            Console.WriteLine("░▒▓~Калькулятор~▓▒░");

            // obtain operands
            if (paramsAreGiven)
            {
                operation = args[0];
                operands[0] = Convert.ToDouble(args[1]);
                operands[1] = Convert.ToDouble(args[2]);
                Console.WriteLine($"Переданные параметры: operation={operation} x={operands[0]} y={operands[1]}");
            }
            else
            {
                // TODO: check inputs
                Console.WriteLine("Достопочтенный сударь, соблаговолите ввести название операции:");
                Console.Write("► ");
                operation = Console.ReadLine();
                Console.WriteLine("Ваша операция, уважаемый, безупречна как всегда.");
                Console.WriteLine("Теперь введите операнды через запятую:");
                Console.Write("► ");
                Console.WriteLine("Теперь введите первый операнд:");
                Console.Write("► ");
                operands[0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Теперь введите второй операнд:");
                Console.Write("► ");
                operands[1] = Convert.ToDouble(Console.ReadLine());
            }

            // calculate result
            result = calc.Exec(operation, operands);

            // out
            Console.WriteLine($"Вот ваш ответ, сударь: {result}!");

            Console.ReadKey();
        }
    }
}