using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Haçik",
                LastName = "Ulu",
                BirthDate = 2002,
                IdentityNumber = 123456
            });
        }
    }
}
