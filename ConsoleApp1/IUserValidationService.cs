using System;
using System.Collections.Generic;
using System.Text;

namespace GameV2
{
    interface IUserValidationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
