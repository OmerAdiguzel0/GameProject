using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Campaign:IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
    }
}
