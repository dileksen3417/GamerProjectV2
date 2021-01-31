using System;
using System.Collections.Generic;
using System.Text;

namespace GameV2
{
    class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " kullanıcısı kampanyasız alışveriş yapmıştır.");
        }

        public void Sell(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " kullanıcısı " + campaign.CampaignName + 
                " kampanyası ile alışveriş yapmıştır.");
        }
    }
}
