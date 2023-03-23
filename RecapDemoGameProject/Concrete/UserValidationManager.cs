using RecapDemoGameProject.Abstract;
using RecapDemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemoGameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2002 && gamer.FirstName == "HAÇİK"
                && gamer.LastName == "ULU" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
