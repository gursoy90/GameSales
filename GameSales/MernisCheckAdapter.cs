using System;
using System.Collections.Generic;
using System.Text;


namespace GameSales
{
    class MernisCheckAdapter
    {
        public bool checkNationalityNo(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(MernisServiceReference.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //return client.TCKimlikNoDogrulaAsync(gamer.NationaltyNo, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(),Convert.ToInt32(gamer.DateOfBirth));
            return true;
        }
    }
}
