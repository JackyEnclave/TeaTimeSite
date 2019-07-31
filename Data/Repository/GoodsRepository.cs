using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaTimeSite.Data.Interfaces;
using TeaTimeSite.Data.Models;

namespace TeaTimeSite.Data.Repository
{
    public class GoodsRepository : IGoods
    {
        private readonly DBContent dBContent;
        public GoodsRepository(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }
        public IEnumerable<Goods> Goods => dBContent.Goods.Include(cond => cond.Category);

        public IEnumerable<Goods> FavoriteGoods => dBContent.Goods.Where(cond => cond.isFavorite).Include(cond => cond.Category);

        public Goods GetOneGood(int id) => dBContent.Goods.FirstOrDefault(cond => cond.id == id);
    }
}
