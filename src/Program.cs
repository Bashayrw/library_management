using System.Security.Cryptography.X509Certificates;

namespace sda_onsite_2_csharp_library_management.src
{
    internal class Program
    {
        private static void Main()
        {
            var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
            Console.WriteLine(book1.Title);
            var book20 = new Book("Anna Karenina");
            Console.WriteLine(book20.Title);
            Library library = new Library();
            var book11 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
            var book2 = new Book("1984", new DateTime(2023, 2, 1));
            var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
            var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
            var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
            var book6 = new Book("Wuthering Heights");
            library.AddBook(book11);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            var books = library.GetBook(1);
            Console.WriteLine("Page One");
            System.Console.WriteLine("=======Before Removal======");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title} Id: {book.Id}...");

            }
            library.DeleteBookById(book2.Id);
            var booksAgain = library.GetBook(1);
            System.Console.WriteLine("=======After Removal======");
            foreach (var book in booksAgain)
            {
                Console.WriteLine($"Title: {book.Title} Id: {book.Id}...");

            }
            System.Console.WriteLine("======Find a Book=======");
            var findBook1 = library.FindBooksByTitle(book1.Title);
            if (findBook1 != null)
            {
                Console.WriteLine($"{findBook1.Title}{findBook1.CreatedAt}");

            }
            var booksSorted = library.SortBookByDate();
            System.Console.WriteLine("=======Sorting======");
            foreach (var book in booksSorted)
            {
                Console.WriteLine($"Title: {book.Title} Date: {book.CreatedAt}...");

            }

            // create a user to test for library 
            var user1 = new User("Alice", new DateTime(2023, 1, 1));
            var user2 = new User("Bob", new DateTime(2023, 2, 1));
            var user9 = new User("Ian");
            library.AddUser(user9);
            library.AddUser(user2);
            library.AddUser(user1);
            library.GetUser();

            var users = library.GetUser(1);
            System.Console.WriteLine("=======Before Removal======");

            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name} Id: {user.Id}...");

            }
            library.DeleteUserById(user9.Id);
            var usersAgain = library.GetUser(1);
            System.Console.WriteLine("=======After Removal======");
            foreach (var user in usersAgain)
            {
                Console.WriteLine($"Name: {user.Name} Id: {user.Id}...");

            }

            var usersSorted = library.SortUserByDate();
            System.Console.WriteLine("=======Sorting======");
            foreach (var user in usersSorted)
            {
                Console.WriteLine($"Name: {user.Name} Date: {user.CreatedAt}...");

            }

            System.Console.WriteLine("======Find a User=======");
            var findUser1 = library.FindUsersByName(user2.Name);
            if (findUser1 != null)
            {
                Console.WriteLine($"{findUser1.Name}{findUser1.CreatedAt}");

            }
            System.Console.WriteLine("++++++++++");
            library.PrintUsers();
            System.Console.WriteLine("++++++++++");


        }
    }
}
