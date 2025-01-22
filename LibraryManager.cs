using System;

public class LibraryManager
{
    private static LibraryManager instance;
    private Library library;

    private LibraryManager()
    {
        library = new Library();
    }

    public static LibraryManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LibraryManager();
            }
            return instance;
        }
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. List All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    RemoveBook();
                    break;
                case 3:
                    SearchBook();
                    break;
                case 4:
                    library.ListBooks();
                    break;
                case 5:
                    Console.WriteLine("Exiting the system...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void AddBook()
    {
        Console.Write("Enter book type (Book/EBook): ");
        string type = Console.ReadLine();
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author: ");
        string author = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Is the book available? (true/false): ");
        bool available = bool.Parse(Console.ReadLine());

        if (type == "EBook")
        {
            Console.Write("Enter file size (MB): ");
            int fileSize = int.Parse(Console.ReadLine());
            library.AddBook(BookFactory.CreateBook(type, title, author, isbn, available, fileSize));
        }
        else
        {
            library.AddBook(BookFactory.CreateBook(type, title, author, isbn, available));
        }
    }

    private void RemoveBook()
    {
        Console.Write("Enter ISBN to remove: ");
        string isbn = Console.ReadLine();
        library.RemoveBook(isbn);
    }

    private void SearchBook()
    {
        Console.Write("Enter title to search: ");
        string title = Console.ReadLine();
        library.SearchBook(title);
    }
}
