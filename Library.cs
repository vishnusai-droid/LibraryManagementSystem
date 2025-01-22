using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully!");
    }

    public void RemoveBook(string isbn)
    {
        var book = books.FirstOrDefault(b => b.ISBN == isbn);
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book removed successfully!");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    public void SearchBook(string title)
    {
        var results = books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        if (results.Any())
        {
            Console.WriteLine("Books found:");
            results.ForEach(b => Console.WriteLine(b));
        }
        else
        {
            Console.WriteLine("No books found with the given title.");
        }
    }

    public void ListBooks()
    {
        if (books.Any())
        {
            Console.WriteLine("Books in the library:");
            books.ForEach(b => Console.WriteLine(b));
        }
        else
        {
            Console.WriteLine("No books available in the library.");
        }
    }
}
