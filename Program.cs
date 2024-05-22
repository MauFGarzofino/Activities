using Activities.Delegates;
using Activities.Generics;
using Activities.Generics.LibraryAndBook;

namespace Activities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ExecuteFirstActivity();
             ExecuteSecondActivity();
        }

        private static void ExecuteSecondActivity()
        {
            var mathOperations = new MathOperations();
            mathOperations.ExecuteOperations();

            var eventManager = new EventManager();
            eventManager.SubscribeEvents();
            eventManager.NotifySubscribers(5, 1);
        }

        private static void ExecuteFirstActivity()
        {
            NumberList numberList = new NumberList();
            numberList.ProcessNumbers();

            StudentDictionary studentDictionary = new StudentDictionary();
            studentDictionary.ProcessStudents();

            CustomerQueue customerQueue = new CustomerQueue();
            customerQueue.ProcessCustomers();

            BookStack bookStack = new BookStack();
            bookStack.ProcessBooks();

            Library library = new Library();
            library.AddSampleBooks();
            Console.WriteLine("Listing all books in Fiction genre:");
            library.ListBooksByGenre("Fiction");

            Console.WriteLine("\nListing all books in the library, grouped by genre:");
            library.ListAllBooks();
        }
    }
}
