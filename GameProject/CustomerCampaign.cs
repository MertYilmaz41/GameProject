using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerCampaign : ICampaignManager
    {
        public void Entry()
        {
            Console.WriteLine("Müşteri kampyansı aktif edildi.");
            Console.WriteLine("Oyun alışverişlerinde oyunlar %10 indirimli!");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri kampanyası güncellendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Müşteri kampanyası iptal ediliyor.");
        }
    }
}
