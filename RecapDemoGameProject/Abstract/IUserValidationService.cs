using RecapDemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecapDemoGameProject.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
