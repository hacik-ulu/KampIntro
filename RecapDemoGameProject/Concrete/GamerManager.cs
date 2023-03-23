using RecapDemoGameProject.Abstract;
using RecapDemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemoGameProject.Concrete
{
    //MicroService -> GamerManager servisinin içinde başka bir servis kullanma
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu kaydedildi:" + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Oyuncu doğrulanamadığından oyuncunun kaydı gerçekleştirilmedi.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi:" + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi:" + gamer.FirstName);
        }
    }
}
