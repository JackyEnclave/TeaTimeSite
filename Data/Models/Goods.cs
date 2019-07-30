using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaTimeSite.Data.Models
{
    public class Goods
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public decimal price { get; set; }
        public bool isFavorite { get; set; }
        public bool isAvailable { get; set; }
        public int catId { get; set; }
        public virtual Category Category { get; set; }
    }
}
