using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoExample
{
    class NewE_StateUserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
