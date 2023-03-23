using RecapDemoGameProject.Abstract;
using RecapDemoGameProject.Concrete;
using RecapDemoGameProject.Entities;
using System;

namespace RecapDemoGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                FirstName = "HAÇİK",
                LastName = "ULU",
                BirthYear = 2002,
                IdentityNumber = 123456,
            };


            Campaign campaign = new Campaign
            {
                CampaignName = "Yaza Giriş Kampanyası ",
                CampaignDiscountRate = 25,

            };

            Game game = new Game
            {
                GameName = "FİFA 23",
                GamePrice = 650,
            };

            GamerManager gameManager = new GamerManager(new UserValidationManager());
            gameManager.Add(gamer);

            //Kampanyanın satışlara entegre edilmesi.
            GameSaleManager gameSaleManager = new GameSaleManager(new CampaignManager());
            gameSaleManager.Sale(game, gamer, campaign);
            Console.WriteLine();

            //Kampanyanın satışlara entegre edilmediği durum.
            gameSaleManager.Sale(game, gamer);

            //Kampanyanın Sistemden silindiği durum.
            CampaignManager campaignManager2 = new CampaignManager();
            campaignManager2.Delete(campaign);
        }
    }
}
