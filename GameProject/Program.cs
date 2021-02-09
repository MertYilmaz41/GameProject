using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Mert";
            gamer1.LastName = "Akın";
            gamer1.TcNo = "123465";
            gamer1.GamerId = 1;

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Melih";
            gamer2.LastName = "Şirin";
            gamer2.TcNo = "987654";
            gamer2.GamerId = 2;

            Gamer gamer3 = new Gamer();
            gamer3.FirstName = "Başar";
            gamer3.LastName = "Abak";
            gamer3.TcNo = "456123";
            gamer3.GamerId = 3;

            Customer customer1 = new Customer();
            customer1.FirstName = "İlker";
            customer1.LastName = "Kaya";
            customer1.TcNo = "693654";
            customer1.CustomerId = 4;

            Customer customer2 = new Customer();
            customer2.FirstName = "Yalçın";
            customer2.LastName = "Sezgin";
            customer2.TcNo = "019274";
            customer2.CustomerId = 5;

            Gamer[] gamers = new Gamer[] { gamer1, gamer2, gamer3 };
            foreach (Gamer gamer in gamers)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName);

            }
            
            Console.WriteLine("Oyuncular geldi!!!");
            Console.WriteLine("--------------------------");

            //GamerSystemManager >> sadece oyuncuların kullanabileceği bir sistem olarak simule ettim. Yani müşteriler kullanamaz.

            ICampaignManager campaignManager1 = new GamerCampaign();
            campaignManager1.Entry();

            Console.WriteLine("-------------------------------");

            SellingService sellingService = new SellingService();
            sellingService.Sell(gamer1);
            sellingService.Sell(gamer2);
            sellingService.Sell(gamer3);

            Console.WriteLine("-------------------------------");

            GamerSystemManager gamerSystemManager = new GamerSystemManager();
            gamerSystemManager.SignUp(gamer1);
            gamerSystemManager.SignUp(gamer2);
            gamerSystemManager.SignUp(gamer3);
            gamerSystemManager.UpdateAcc(gamer2);
            gamerSystemManager.DeleteAcc(gamer3);

            Console.WriteLine("--------------------------------");

            sellingService.Return(gamer3);
            campaignManager1.Update();
            campaignManager1.Delete();

            Console.WriteLine("-----------------------------------");

            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName);
            }

            Console.WriteLine("Müşteriler geldi!!!");
            Console.WriteLine("---------------------------");

            ICampaignManager campaignManager2 = new CustomerCampaign();
            campaignManager2.Entry();
            Console.WriteLine("--------------------------------");

            sellingService.Sell(customer1);
            sellingService.Sell(customer2);
            Console.WriteLine("----------------------------------");
            campaignManager2.Update();
            campaignManager2.Delete();

        }
    }
}
