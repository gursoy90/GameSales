using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    class SaleType
    {
        public void CasheSale(Campaign campaign)
        {
            Console.WriteLine("Oyun "+campaign.CampaignName + " kampanyası ile Satılmıştır.");
        }
        public void CreditCartSale(Campaign campaign)
        {
            Console.WriteLine("Oyun " + campaign.CampaignName + " kampanyası ile Satılmıştır.");
        }
    }
}
