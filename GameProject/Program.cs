using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                Name = "Koray",
                Surname = "Bıçak",
                BirthOfDay = "27.05.1996",
                TcNo = "26118673466",
                NickName = "Naru"
            };
            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                Name = "Meltem",
                Surname = "Sucu",
                BirthOfDay = "03.01.1990",
                TcNo = "26118673466",
                NickName = "Mermaid"
            };

            List<Gamer> gamers = new List<Gamer>() { gamer1, gamer2 };
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamers);

            Game game1 = new Game() { Id = 1, Name = "PubG", Platform = "XBOX", Price = 90.6 };
            Game game2 = new Game() { Id = 2, Name = "Lol", Platform = "PC", Price = 67.3 };

            List<Game> games = new List<Game>() { game1, game2 };

            Campaign campaign = new Campaign() { Id = 1, Name = "Black Friday", DiscountRate = 50, CampaignDetails = "Ocak Sonuna Kadar" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            Sales sales = new Sales();
            sales.Sell(games, gamer1, campaign);
            //sales.Sell(games, gamer2, campaign);
        }
    }
}
