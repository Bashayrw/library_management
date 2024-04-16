using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Base
{
    public Guid Id;
    public readonly DateTime? CreatedAt;

    public Base(DateTime? createdAt = default)
    {
        Id = new Guid();
        CreatedAt = createdAt == default ? DateTime.Now : createdAt;

    }
}








// 1.CreatedAt: because i used guid so the Id in the constrcutor should be Id = new Guid();
// Id in the constructor should not be passed in the paramater becaucse it is generaited automatically by the computer so we don't need to get the data
