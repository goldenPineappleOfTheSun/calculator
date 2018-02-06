using ItUniver.Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
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
            // reflection
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            
            foreach (var item in types)
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
                        AddOperation(operation);
                }
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
        
        private void AddOperation(IOperation operation)
        {
            operations.Add(operation);
        }
    }
}
