using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SaleManager:ISaleService
    {
        public void Sales(Game game, Gamer gamer, Campaign campaign)
        {
            double sumPrice= game.Price-((game.Price*campaign.Discount)/100) ;

            Console.WriteLine(
                "Satın Alınan Oyun: " + game.Name + "\nSatın Alan Oyuncu: " + gamer.FirstName + "\nÜrün Fiyatı: " + game.Price + 
                "\nÜrünün İndirimli Fiyatı: " + sumPrice + "\nİndirim Oranı: %" + campaign.Discount
                );
            Console.WriteLine("Satın Alma İşlemi Başarılı");
        }
    }
}
