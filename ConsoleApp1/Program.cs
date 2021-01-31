using GameV2;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserValidationService userValidationService = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationService);
            //veya GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Dilek",
                LastName="Atmaca",
                BirthYear=1995,
                IdentityNumber=5562
            }) ;
            //gamerManager.Update(...);
            //gamerManager.Delete(...);


            //kampanya işlemleri
            ICampaignService campaignService = new CampaignManager();
            Campaign campaign = new Campaign           
                {
                    Id = 1,
                    CampaignName = "Yeni Yıl Kampanyası",
                    DiscountAmount = 9.99,
                    ValidityDate = new DateTime(2021, 01, 31),
                };
            campaignService.Add(campaign);
            campaignService.Update(campaign);
            campaignService.Delete(campaign);


            //satış işlemleri....
            Gamer gamer2 = new Gamer {Id=2, FirstName="Altuğ", LastName="Atmaca", BirthYear=1993, IdentityNumber=6255 };
            ISalesService salesService = new SalesManager();
            salesService.Sell(gamer2);
            salesService.Sell(gamer2, campaign);
        }
    }
}
