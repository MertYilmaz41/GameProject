using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Customer : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public int CustomerId { get; set; }

    }
}
