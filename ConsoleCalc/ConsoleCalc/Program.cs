using System;
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

            var ops = calc.GetOperaionNames();
            foreach (var o in ops)
            {
                Console.WriteLine(o);
            }

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
                operands = ParseOperands(Console.ReadLine());
            }

            // calculate result
            result = calc.Exec(operation, operands);

            // out
            Console.WriteLine($"Вот ваш ответ, сударь: {result}!");

            Console.ReadKey();
        }

        private static double[] ParseOperands(string input)
        {
            string[] strings = null;
            List<double> result = new List<double>();

            input = input.Replace(" ", "");
            strings = input.Split(',');

            foreach (string item in strings)
                result.Add(Convert.ToDouble(item));

            return result.ToArray<double>();
        }
    }
}