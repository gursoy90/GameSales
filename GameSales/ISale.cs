using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    interface ISale
    {
        void CreateSale(Game game,Campaign campaign, Gamer gamer);
    }
}
