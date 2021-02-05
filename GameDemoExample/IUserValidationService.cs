using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoExample
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
