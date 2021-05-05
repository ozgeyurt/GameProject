using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(new Gamer { FirstName = "SELMAN", LastName = "İNAN", BirthYear = 1984, IdentityNumber = 852145963 });

            gamerManager.Add(new Gamer { IdentityNumber = 1245967896, FirstName = "ÖZGE", LastName = "İNAN", BirthYear = 1993 });

            Campaign campaign = new Campaign { Id=1, CampaignName = "İndirim", CampignDetail = "%50 indirim" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Sale saleGame = new Sale { GameName = "ZULA", UserName = "OZGE93", GamePrice = 325 };
           

            


        }
    }
}
