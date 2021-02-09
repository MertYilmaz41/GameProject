using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerCampaign : ICampaignManager
    {

        public void Entry()
        {
            Console.WriteLine("Oyuncu kampanyası aktif edildi.");
            Console.WriteLine("Oyunculara özel tüm oyunlar %50 indirimli!");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu kampanyası güncellendi.");
        }


        public void Delete()
        {
            Console.WriteLine("Oyuncu kampanyası iptal ediliyor" );
        }
    }
}
