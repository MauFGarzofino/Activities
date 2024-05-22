using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Delegates
{
    public class MathOperations
    {
        public delegate int MathOperation(int a, int b);

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public void ExecuteOperations()
        {
            MathOperation operation = Add;
            Console.WriteLine("Resultado de Add(2, 2): " + operation(2, 2));

            operation = Subtract;
            Console.WriteLine("Resultado de Subtract(2, 2): " + operation(2, 2));
        }
    }
}
