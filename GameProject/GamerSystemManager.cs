using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerSystemManager
    {
        //özellikle sadece oyuncuların bu sistemi kullanabilmesi için yaptım.
        public void SignUp(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+ " " + gamer.LastName + " " + "adlı oyuncu başarıyla sisteme kayıt edildi.");
        }

        public void UpdateAcc(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "adlı oyuncunun hesabı başarıyla güncellendi.");
        }

        public void DeleteAcc(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "adlı oyuncunun kaydı başarıyla silindi.");
        }
    }
}
