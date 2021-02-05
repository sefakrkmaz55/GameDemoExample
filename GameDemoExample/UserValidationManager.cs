using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoExample
{
    class UserValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.Name == "Sefa" && gamer.SurName == "Korkmaz" && gamer.IdentityNumber == "5555")
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
