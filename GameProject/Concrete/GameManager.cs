using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;
using Console = System.Console;

namespace GameProject.Concrete
{
    public class GameManager:IGameService
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi!: " + game.Name);
            games.Add(game);
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Oyun Silindi!: " + game.Name);
            games.Remove(game);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi!: " + game.Name);
        }

        public void List()
        {
            Console.WriteLine("Listelenen Oyunlar");
            foreach (var game in games)
            {
                Console.WriteLine("-" + game.Name);
                
            }
        }
    }
}
