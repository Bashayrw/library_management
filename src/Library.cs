using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


public class Library
{
    private IEnumerable<User> _users;
    private IEnumerable<Book> _books;

    public Library()
    {
        _users = [];
        _books = [];
    }

    public void AddBook(Book book)
    {
        _books = _books.Append(book);
        // with IEnumerable : when you add new item, it will give back a new array with latest update
        // 3 items in _users, after add one users, it gives you back a new array with 4 users: newArray 
        // assign newArray with updated values to the old array : 
        //Console.WriteLine($"{_users.Count()}");
    }
    public void AddUser(User user)
    {
        _users = _users.Append(user);
        // with IEnumerable : when you add new item, it will give back a new array with latest update
        // 3 items in _users, after add one users, it gives you back a new array with 4 users: newArray 
        // assign newArray with updated values to the old array : 
        //Console.WriteLine($"{_users.Count()}");
    }
    //  for remove method, user Where to filter items , 
    // and then re-assign to the _users 
    public IEnumerable<User> GetUser()
    {

        return _users;
    }
    public IEnumerable<User> GetUser(int page)
    {
        var itemsPerPage = 2;
        var offSet = (page - 1) * itemsPerPage;
        var paginated = _users.Skip(offSet).Take(itemsPerPage);
        return paginated;
    }
    public IEnumerable<Book> GetBook()
    {

        return _books;
    }
    public IEnumerable<Book> GetBook(int page)
    {
        var itemsPerPage = 2;
        var offSet = (page - 1) * itemsPerPage;
        var paginated = _books.Skip(offSet).Take(itemsPerPage);
        return paginated;
    }
    // remove user, always check whether the user existed in the list or not by checking id, if yes, remove it : FirstOrDefault 

    public IEnumerable<User> DeleteUserById(Guid id)
    {
        _users = _users.Where((u) => u.Id != id);
        return _users;
    }
    public IEnumerable<Book> DeleteBookById(Guid id)
    {
        _books = _books.Where((b) => b.Id != id);
        return _books;
    }
    public void PrintUsers()
    {
        foreach (var user in _users)
        {
            Console.Write(user.ToString());
        }
    }

    public User? FindUsersByName(string name)
    {
        return _users.FirstOrDefault((user) => user.Name == name);


    }
    public Book? FindBooksByTitle(string title)
    {
        return _books.FirstOrDefault((book) => book.Title == title);
    }
    public IEnumerable<User> SortUserByDate()
    {
        return _users.OrderBy((user) => user.CreatedAt);
    }
    public IEnumerable<Book> SortBookByDate()
    {
        return _books.OrderBy((book) => book.CreatedAt);
    }

}
