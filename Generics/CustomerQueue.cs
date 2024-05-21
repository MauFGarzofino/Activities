using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Generics
{
    public class CustomerQueue
    {
        public void ProcessCustomers()
        {
            Queue<string> customers = new Queue<string>();
            customers.Enqueue("Customer1");
            customers.Enqueue("Customer2");
            customers.Enqueue("Customer3");
            customers.Enqueue("Customer4");
            customers.Enqueue("Customer5");

            Console.WriteLine("Original Queue:");
            PrintQueue(customers);

            customers.Dequeue();
            customers.Dequeue();

            Console.WriteLine("Updated Queue:");
            PrintQueue(customers);
        }

        private void PrintQueue(Queue<string> queue)
        {
            foreach (var customer in queue)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
