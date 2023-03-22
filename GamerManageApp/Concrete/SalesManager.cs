using GamerManageApp.Abstract;
using GamerManageApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManageApp.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+" "+
                "adlı oyuncu"+" "+
                game.Name+" "+"adlı oyunu"+" "+
                campaign.CampaignName+" "+"kampanyası ile alındı");
        }

        public double Discount(int UnitPrice,double DiscountRate)
        {
            double newUnitPrice = UnitPrice - 100*(DiscountRate/100);
            return newUnitPrice;
        }
    }
}
