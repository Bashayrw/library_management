using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Book : Base
{
    public string Title;

    public Book(string title, DateTime? createdAt = null) : base(createdAt)
    {
        Title = title;
    }
}

//
