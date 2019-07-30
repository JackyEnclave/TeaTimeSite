using TeaTimeSite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaTimeSite.ViewModels
{
    public class GoodsListViewModel
    {
        public IEnumerable<Goods> AllGoods { get; set; }
        public string currentCategory { get; set; }
    }
}
