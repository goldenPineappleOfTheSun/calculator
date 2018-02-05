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
            int[] operands = new int[2];
            int result = 0;

            Console.WriteLine("░▒▓~Калькулятор~▓▒░");

            if (paramsAreGiven) {
                operation = args[0];
                operands[0] = Convert.ToInt32(args[1]);
                operands[1] = Convert.ToInt32(args[2]);
                Console.WriteLine($"Переданные параметры: operation={operation} x={operands[0]} y={operands[1]}");
            }
            else
            {
                Console.WriteLine("Достопочтенный сударь, соблаговолите ввести название операции:");
                Console.Write("► ");
                operation = Console.ReadLine();
                Console.WriteLine("Ваша операция, уважаемый, безупречна как всегда.");
                Console.WriteLine("Теперь введите первый операнд:");
                Console.Write("► ");
                operands[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Теперь введите второй операнд:");
                Console.Write("► ");
                operands[1] = Convert.ToInt32(Console.ReadLine());
            }

            switch (operation)
            {
                case "sum": result = calc.Add(operands[0], operands[1]);break;
                case "sub": result = calc.Sub(operands[0], operands[1]);break;
            }

            Console.WriteLine($"Вот ваш ответ, сударь: {result}!");

            /*var oper = args[0];
            if (oper == "sum")
            {
                var x = Convert.ToInt32(args[1]);
                var y = Convert.ToInt32(args[2]);
                var result = x + y;

                Console.WriteLine($"SUM({x}, {y}) = {result}");
            }
            else
            {
                Console.WriteLine("null");
            }*/

            Console.ReadKey();
        }
    }
}