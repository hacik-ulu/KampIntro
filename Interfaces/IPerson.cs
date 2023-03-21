using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //Soyut Nesne
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
