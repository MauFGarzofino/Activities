using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Delegates
{
    public class EventManager
    {
        public Action<int, int> OnCalculate;

        public void SubscribeEvents()
        {
            this.OnCalculate += (a, b) => Console.WriteLine($" {a} + {b} = {a + b}");
            this.OnCalculate += (a, b) => Console.WriteLine($" {a} - {b} = {a - b}");
        }

        public void NotifySubscribers(int a, int b)
        {
            Console.WriteLine("Multicast Delegate: ");
            this.OnCalculate?.Invoke(a, b);
        }
    }
}
