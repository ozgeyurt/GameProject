using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerValidationManager : IGamerValidationService
    {
        public void Validate(Gamer gamer)
        {
            if (gamer.IdentityNumber==1245967896 && gamer.FirstName== "ÖZGE" && gamer.LastName=="İNAN" && gamer.BirthYear==1993)
            {
                Console.WriteLine("DOĞRULAMA BAŞARILI");
            }
            else
            {
                Console.WriteLine("DOĞRULAMA BAŞARISIZ!");
            }
        }
    }
}
