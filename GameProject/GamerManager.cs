using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        public List<int> count = new List<int>();
        public void Add(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                ValidationManager validationManager = new ValidationManager();
                bool result = validationManager.Validate(gamer);
                if (result == true)
                {
                    Console.WriteLine("Sn. " + gamer.Name + " " + gamer.Surname + " sisteme kaydınız başarı ile oluşturuldu.");
                    count.Add(1);
                    
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
