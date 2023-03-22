using GamerManageApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManageApp.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckİfRealPerson(Gamer gamer);
    }
}
