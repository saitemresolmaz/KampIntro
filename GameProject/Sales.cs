using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Sales
    {
        public void Sell(List<Game> games, Gamer gamer, Campaign campaign)
        {
            foreach (var game in games)
            {
                game.Price = game.Price - game.Price * campaign.DiscountRate / 100;
                Console.WriteLine(gamer.Name + " " + gamer.Surname + " " + game.Name + " oyununu " + campaign.Name + " Kampanyası ile " + game.Price + " TL'ye satın almıştır.");
            }
        }
    }
}
