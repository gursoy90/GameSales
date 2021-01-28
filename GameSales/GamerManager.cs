using System;
using System.Collections.Generic;
using System.Text;

namespace GameSales
{
    class GamerManager
    {
        public void Add(Gamer gamer)
        {
            MernisCheckAdapter mernisCheck = new MernisCheckAdapter();
            

            if (mernisCheck.checkNationalityNo(gamer))
            {
                Console.WriteLine("Gamer Added");
            }
            else
            {
                Console.WriteLine("Kullanıcı Geçerli Değil");
            }
            
        }
        public void Update(Gamer gamer)
        {
            
            Console.WriteLine("Gamer Updated");
        }
        public void Delete(Gamer gamer)
        {
            
            Console.WriteLine("Gamer Deleted");
        }
    }
}
