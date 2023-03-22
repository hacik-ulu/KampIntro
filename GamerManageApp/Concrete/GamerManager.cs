using GamerManageApp.Abstract;
using GamerManageApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerManageApp.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _checkService;

        public GamerManager(IGamerCheckService checkService)
        {
            _checkService = checkService;
        }

        public void Add(Gamer gamer)
        {
            if (_checkService.CheckİfRealPerson(gamer) == true)
            {
                Console.WriteLine("Oyuncu Eklendi:"+gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi" + " " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi" + " " + gamer.FirstName);
        }
    }
}
