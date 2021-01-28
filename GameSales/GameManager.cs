using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Added");
        }
        public void Update(Game game)
        {
            Console.WriteLine("Game Updated");
        }
        public void Delete(Game game)
        {
            Console.WriteLine("Game Deleted");
        }
    }
}
