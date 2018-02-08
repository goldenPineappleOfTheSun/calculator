using ItUniver.Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    public class Calculator
    {
        private List<IOperation> operations = new List<IOperation>();

        public Calculator()
        {
            // загружаем наши операции
            LoadOperations(Assembly.GetExecutingAssembly());

            // загружаем сторонние операции
            var extensionsDir = Path.Combine(Environment.CurrentDirectory, "Extensions");

            if (!Directory.Exists(extensionsDir))
                return;

            var files = Directory.GetFiles(extensionsDir, "*.dll");

            foreach (var file in files)
            {
                LoadOperations(Assembly.LoadFile(file));
            }
        }

        public List<IOperation> GetOperations()
        {
            return operations;
        }

        public string[] GetOperaionNames()
        {
            return operations.Select(o => o.Name).ToArray<string>();
        }

        public double Exec(String oper, double[] args)
        {
            // переменные
            var result = double.NaN;
            var operation = operations
                .Where(o => o.Name == oper)
                .FirstOrDefault();

            if (operation == null)
                return double.NaN;

            // выполнить операцию
            result = operation.Exec(args);

            return result;
        }

        private void LoadOperations(Assembly assembly)
        {
            var types = assembly.GetTypes();
            var typeOperation = typeof(IOperation);

            foreach (var item in types.Where(t => !t.IsAbstract && !t.IsInterface))
            {
                var interfaces = item.GetInterfaces();

                var isOperation = interfaces.Any(it => it == typeOperation);

                if (isOperation)
                {
                    // создаем эксземпляр объекта
                    var obj = Activator.CreateInstance(item);
                    // пытаемся превратить его в операцию
                    var operation = obj as IOperation;

                    if (operation != null)
                    {
                        // добавляем в список операций
                        operations.Add(operation);
                    }
                }
            }
        }
    }
}
