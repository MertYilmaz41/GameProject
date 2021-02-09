using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
     class SellingService
    {
        public void Sell(IPerson person)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + "adlı kişiye oyun satışı gerçekleştirildi.");
        }

        public void Return(IPerson person)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + "adlı kişinin oyun iadesi gerçekleştirildi.");
        }
    }
}
