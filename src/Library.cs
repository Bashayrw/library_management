using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


public class Library
{
    public IEnumerable<User> Users { get; }


    public Library()
    {
        Users = [];

    }

    public IEnumerable<User> AddUser(User user)
    {
        Console.WriteLine($"Add user to user list");

        return Users.Append(user);
    }
    public IEnumerable<User> GetUserList()
    {
        var userList = Users.ToList();
        var lengthOfUserList = userList.Count;
        Console.WriteLine($"{lengthOfUserList}");

        return Users;
    }
    // remove user, always check whether the user existed in the list or not by checking id, if yes, remove it : FirstOrDefault 

}
