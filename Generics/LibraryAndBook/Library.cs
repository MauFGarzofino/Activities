using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Generics.LibraryAndBook
{
    public class Library
    {
        private Dictionary<string, List<Book>> library = new Dictionary<string, List<Book>>();

        public void AddNewBook(Book book)
        {
            if (!library.ContainsKey(book.Genre))
            {
                library[book.Genre] = new List<Book>();
            }
            library[book.Genre].Add(book);
        }

        public void RemoveBook(string title, string genre)
        {
            if (library.ContainsKey(genre))
            {
                library[genre].RemoveAll(book => book.Title == title);
            }
        }

        public void ListBooksByGenre(string genre)
        {
            if (library.ContainsKey(genre))
            {
                Console.WriteLine($"Books in genre: {genre}");
                foreach (var book in library[genre])
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine($"No books found in genre: {genre}");
            }
        }

        public void ListAllBooks()
        {
            foreach (var genre in library.Keys)
            {
                Console.WriteLine($"Genre: {genre}");
                ListBooksByGenre(genre);
                Console.WriteLine();
            }
        }

        public void AddSampleBooks()
        {
            AddNewBook(new Book { Title = "Book A", Genre = "Fiction" });
            AddNewBook(new Book { Title = "Book B", Genre = "Non-Fiction" });
            AddNewBook(new Book { Title = "Book C", Genre = "Fiction" });
        }
    }
}
