using RecapDemoGameProject.Abstract;
using RecapDemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemoGameProject.Concrete
{

    class GameSaleManager : IGameSaleService
    {
        ICampaignService _campaignService;

        public GameSaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            double newPrice = (game.GamePrice) - ((game.GamePrice * campaign.CampaignDiscountRate) / 100);
            Console.WriteLine(game.GameName + " " + "adlı oyun" + " " +
                campaign.CampaignName + " " + "kampanyasıyla" + " " + newPrice + " " + "değerinde" +
                " " + gamer.FirstName + " " + "kullanıcısına satıldı.");
        }

        //Method override
        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " " + "adlı oyun" + " " + game.GamePrice + " " + " değerinde kampanya tanımlanmadan satıldı.");
        }
    }
}
