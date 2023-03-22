using GamerManageApp.Abstract;
using GamerManageApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManageApp.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckİfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
