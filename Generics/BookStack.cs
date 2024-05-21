using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Generics
{
    public class BookStack
    {
        public void ProcessBooks()
        {
            Stack<string> books = new Stack<string>();
            books.Push("Book1");
            books.Push("Book2");
            books.Push("Book3");
            books.Push("Book4");
            books.Push("Book5");

            Console.WriteLine("Original Stack:");
            PrintStack(books);

            books.Pop();
            books.Pop();

            Console.WriteLine("Updated Stack:");
            PrintStack(books);
        }

        private void PrintStack(Stack<string> stack)
        {
            foreach (var book in stack)
            {
                Console.WriteLine(book);
            }
        }
    }
}
