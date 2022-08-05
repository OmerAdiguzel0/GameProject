using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager:ICampaignService
    {
        List<Campaign> campaigns=new List<Campaign>();
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi!: " + campaign.Name);
            campaigns.Add(campaign);
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi!: " + campaign.Name);
            campaigns.Remove(campaign);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi!: " + campaign.Name);
        }

        public void List()
        {
            Console.WriteLine("Kampanyalar Listelendi");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("-" + campaign.Name);
            }
        }
    }
}
