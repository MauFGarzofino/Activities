using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Generics
{
    public class StudentDictionary
    {
        public void ProcessStudents()
        {
            Dictionary<string, int> students = new Dictionary<string, int>
            {
                { "Student A", 100 },
                { "Student B", 20 },
                { "Student C", 80 },
                { "Student D", 58 },
                { "Student E", 76 }
            };

            Console.WriteLine("Original Dictionary:");
            PrintDictionary(students);

            students["Student D"] = 100;
            students.Remove("Student B");

            Console.WriteLine("Updated Dictionary:");
            PrintDictionary(students);
        }

        private void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Name: {item.Key}, Calification: {item.Value}");
            }
        }
    }
}
