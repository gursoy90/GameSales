using System;

namespace GameSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.NationaltyNo = 12345678910;
            gamer1.FirstName = "Ramazan";
            gamer1.LastName = "Gürsoy";
            gamer1.DateOfBirth = "1990";

            Game game1 = new Game();
            game1.GameName = "GTAV";
            game1.Gametype = "Action";
            game1.GamePrice = 15;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Black Friday";
            campaign1.CampaignPriceCut =50;

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);
            gameManager1.Update(game1);
            gameManager1.Delete(game1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(campaign1);
            campaignManager.CampaignUpdate(campaign1);
            campaignManager.CampaignDeleted(campaign1);

            SaleType saleType = new SaleType();
            saleType.CasheSale(campaign1);

            ISale sale = new Sale();
            sale.CreateSale(game1, campaign1, gamer1);
        }
    }
}
