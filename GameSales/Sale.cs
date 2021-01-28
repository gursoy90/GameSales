using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    class Sale : ISale
    {
        public void CreateSale(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(game.GameName +" " +gamer.FirstName + " 'a " + campaign.CampaignName + 
                " Kampanyası ile " + campaign.CampaignPriceCut + " TL indirimli Satılmıştır" );
        }
    }
}
