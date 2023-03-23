using RecapDemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemoGameProject.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);

    }
}
