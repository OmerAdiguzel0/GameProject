using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager:IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        private List<Gamer> gamers = new List<Gamer>();
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine("Oyuncu Eklendi!: " + gamer.FirstName + " " + gamer.LastName);
                gamers.Add(gamer);
            }
            else
            {
                throw new Exception("Hatalı Bilgi Girildi!");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi!: " + gamer.FirstName + " " + gamer.LastName);
            gamers.Remove(gamer);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi!: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void List()
        {
            Console.WriteLine("Oyuncular Listelendi!: ");
            foreach (var gamer in gamers)
            {
                Console.WriteLine("-" + gamer.FirstName + " " + gamer.LastName);
            }
        }
    }
}
