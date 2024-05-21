using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Generics
{
    public class NumberList
    {
        public void ProcessNumbers()
        {
            List<int> nums = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                nums.Add(i);
            }

            Console.WriteLine("Original List:");
            PrintList(nums);

            nums.Remove(nums.First());
            nums.Remove(nums.Last());

            Console.WriteLine("Updated List:");
            PrintList(nums);
        }

        private void PrintList(List<int> nums)
        {
            foreach (int num in nums)
            {
                Console.Write(num + " - ");
            }
            Console.WriteLine();
        }
    }
}
