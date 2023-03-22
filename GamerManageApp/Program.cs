using GamerManageApp.Abstract;
using GamerManageApp.Concrete;
using GamerManageApp.Entities;
using System;

namespace GamerManageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşteri ekleme , çıkarma gibi operasyonlar.
            GamerManager gamer1 = new GamerManager(new GamerCheckManager());
            gamer1.Add(new Gamer
            {
                FirstName = "Haçik",
                LastName = "Ulu",
                Adress = "İstanbul"

            });
            gamer1.Delete(new Gamer
            {
                FirstName = "Haçik",
                LastName = "Ulu",
                Adress = "İstanbul"

            });
            Console.WriteLine();

            //Kampanya ekle çıkar
            CampaignManager campaign1 = new CampaignManager();
            campaign1.Add(new Campaign
            {
                CampaignName = "Yarıyıl Kampanyası",
                GameName = "Last Of Us",
                DiscountRate = 20
            });
        }
    }
}
