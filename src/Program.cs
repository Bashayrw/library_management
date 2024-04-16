namespace sda_onsite_2_csharp_library_management.src
{
    internal class Program
    {
        private static void Main()
        {
            var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
            //  Console.WriteLine(book1.Title);
            var book20 = new Book("Anna Karenina");
            //Console.WriteLine(book20);
            Library library = new Library();

            // create a user to test for library 
            var user1 = new User("Alice", new DateTime(2023, 1, 1));
            var user2 = new User("Bob", new DateTime(2023, 2, 1));

            library.AddUser(user1);
            library.AddUser(user2);
            // to run for loop to print the user inside the users of library 
            foreach (var user in library.Users)
            {
                Console.WriteLine($"{user.Name}");
                Console.WriteLine($"user");

            }
            Console.WriteLine($"{library.Users.Count()}");








        }
    }
}

//new DateTime(1959, 02, 03)