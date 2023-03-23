using RecapDemoGameProject.Abstract;
using RecapDemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemoGameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi:"+campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi:" + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi:" + campaign.CampaignName);
        }
    }
}
