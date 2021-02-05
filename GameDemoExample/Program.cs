using System;

namespace GameDemoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewE_StateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                Name = "Sefa",
                SurName = "Korkmaz",
                IdentityNumber ="5555"
            }
            );

            Console.WriteLine("****************************************************");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                CampaignId = 1,
                CampaignName = "Bu ürünü alana İkincisi %55 indirimli",
                CampaignDetail = "Bu Kampanya 2021 Aralık sonuna kadar devam edecektir."
            });
            Console.WriteLine("****************************************************");

            OrderManager orderManager = new OrderManager();
            orderManager.SaleProduct(new Products
            {
                ProductId = 1,
                ProductName = "Football Manager 2021",
                UnitPrice = 300,
                Stock = 15
            });
        }
    }
}
