using System;
using System.Collections.Generic;
using System.Text;

namespace GameV2
{
    class UserValidationManager : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "Dilek" && gamer.LastName == "Atmaca" && gamer.IdentityNumber == 5562)
            {
                return true;
            }
            else return false;
        }
    }
}
