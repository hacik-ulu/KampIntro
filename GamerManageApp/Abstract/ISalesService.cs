using GamerManageApp.Concrete;
using GamerManageApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManageApp.Abstract
{
    public interface ISalesService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
    }
}
