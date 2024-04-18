using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class User : Base
{
    public string Name { get; }

    public User(string name, DateTime? createdAt = null) : base(createdAt)
    {
        Name = name;
    }
    public override string ToString()
    {
        return Name + " " + base.Id + " " + base.CreatedAt;
    }

}











//2.CreatedAt: i have a problem which says: there is no argument given that corresponds to the required parameter 'createdAt'
//3.CreatedAt: so the solve is: a. writing beside the constructor : base(createdAt), a. passing in the parameter the (Datetime createdAt)
