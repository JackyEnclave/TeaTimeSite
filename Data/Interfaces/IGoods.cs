using TeaTimeSite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaTimeSite.Data.Interfaces
{
    public interface IGoods
    {
        IEnumerable<Goods> Goods { get; }
        IEnumerable<Goods> FavoriteGoods { get; set; }
        Goods GetOneGood(int id);
    }
}
