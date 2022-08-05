using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Concrete;
using GameProject.Entities;
using GameProject.Adapters;



namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game(){Id = 1,Name = "Valorant",Price = 75};
            Game game2 = new Game(){Id = 2,Name = "CS:GO",Price = 30};
            Game game3 = new Game(){Id = 3,Name = "Giysi Giydirme",Price = 25};
            
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.List();
            gameManager.Remove(game3);
            gameManager.List();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");


            Campaign campaign1 = new Campaign() { Id = 1, Name = "Yaz Ayları Kampanyası", Discount = 15 };
            Campaign campaign2 = new Campaign() { Id = 2, Name = "Kış Ayları Kampanyası", Discount = 12 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.List();
            campaignManager.Remove(campaign1);
            campaignManager.List();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");


            Gamer gamer1 = new Gamer
            {
                Id = 1,
                FirstName = "Sude Nur",
                LastName = "Can",
                DateOfBirth = new DateTime(1234,5,6),
                NationalityId = "12345678901"
            };

            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                FirstName = "Ömer",
                LastName = "Adıgüzel",
                DateOfBirth = new DateTime(6543,2,1),
                NationalityId = "10987654321"
            };

            GamerManager gamerManager = new GamerManager(new Adapters.MernisServiceReference());
            gamerManager.Add(gamer1);
            gamerManager.Remove(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Add(gamer1);
            gamerManager.List();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");



            SaleManager saleManager = new SaleManager();
            saleManager.Sales(game1,gamer1,campaign1);

        }
    }
}