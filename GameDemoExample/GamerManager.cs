using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoExample
{
    class GamerManager:IGamerService
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
                Console.WriteLine("KAYIT BAŞARILI");
            }
            else
            {
                Console.WriteLine("KAYIT BAŞARISIZ");
            }

        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("KAYIT SİLİNDİ");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("KAYIT GÜNCELLENDİ");
        }
    }
}
