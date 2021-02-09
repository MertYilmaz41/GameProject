using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamer : IPerson
    {
        public string FirstName  { get;  set; } 
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public int GamerId { get; set; }
    }
}
