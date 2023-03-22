using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        //MicroService

        //Yapı içinde yapı kullanılması
        //class içinde başka bir class benzeri bir yapı kullanılırken newlemek yerine constructoru oluşturulur.

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            //girilen bilgiler uyuşuyor mu diye kontrol edilir.

            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu kaydedildi:" + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.Kayıt yapılamadı.");
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
