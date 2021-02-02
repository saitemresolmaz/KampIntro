using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IValidationService _validationService;

        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public List<int> count = new List<int>();
        public void Add(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {         
                if (_validationService.Validate(gamer) == true)
                {
                    Console.WriteLine("Doğrulama Başarılı. Sn. " + gamer.Name + " " + gamer.Surname + " sisteme kaydınız başarı ile oluşturuldu.");
                    count.Add(1);
                    
                }
                else
                {
                    Console.WriteLine("Doğrulama başarısız, Kayıt gerçekleşmedi.");
                }

            }
        }

        public void Delete(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine(gamer.Name + " " + gamer.Surname + " silindi.");
            }
        }

        public void Update(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine(gamer.Name + " " + gamer.Surname + " güncellendi.");
            }

        }
    }
}
