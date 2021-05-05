using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (gamer.IdentityNumber == 1245967896 && gamer.FirstName == "ÖZGE" && gamer.LastName == "İNAN" && gamer.BirthYear == 1993)
            {
                Console.WriteLine("Doğrulama başarılı. Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız! Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");        }
    }
}
