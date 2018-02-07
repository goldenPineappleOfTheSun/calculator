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
    public class Calc
    {
        private List<IOperation> operations = new List<IOperation>();

        public Calc()
        {
            /*// reflection
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();*/

            /* foreach (var item in types)
             {
                 // check for IOperation
                 var interfaces = item.GetInterfaces();
                 var isOperation = interfaces.Any(it => it == typeof(IOperation));

                 // add op in the list
                 if (isOperation)
                 {
                     var obj = Activator.CreateInstance(item);
                     var operation = obj as IOperation;

                     if (operation != null)
                         operations.Add(operation);
                 }
             }*/

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

        public string[] GetOperaionNames()
        {
            return operations.Select(o => o.Name).ToArray<string>();
        }

        public double Exec(String oper, double[] args)
        {
            // variables
            var result = double.NaN;
            var operation = operations
                .Where(o => o.Name == oper)
                .FirstOrDefault();

            // no operation
            if (operation == null)
                return double.NaN;

            // execute
            result = operation.Exec(args);

            return result;
        }
        
        /*private void AddOperation(IOperation operation)
        {
            operations.Add(operation);
        }*/

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

                    if (operation == null)
                        return;

                    // добавляем в список операций
                    operations.Add(operation);
                }
            }
        }
    }
}
