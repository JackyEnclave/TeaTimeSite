using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaTimeSite.Data.Interfaces;
using TeaTimeSite.Data.Models;

namespace TeaTimeSite.Data.Repository
{
    public class CategoryRepository : IGoodsCategory
    {
        private readonly DBContent dBContent;
        public CategoryRepository(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }
        public IEnumerable<Category> AllCategories => dBContent.Category;
    }
}
