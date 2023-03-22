using GamerManageApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManageApp.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
