using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi" +campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya kaldırıldı");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ "Kampanya güncellendi");        }
    }
}
