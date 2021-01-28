using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    class CampaignManager
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi.");
        }
        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
        public void CampaignDeleted(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }
    }
}
