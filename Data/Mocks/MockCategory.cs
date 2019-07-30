using TeaTimeSite.Data.Interfaces;
using TeaTimeSite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaTimeSite.Data.Mocks
{
    public class MockCategory : IGoodsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Пуэры", description = "Самый популярный чай в интернете" },
                    new Category { categoryName = "Улуны", description = "Мир вкусов и ароматов" },
                    new Category { categoryName = "Красный чай", description = "Он же черный (в наших широтах)" },
                };
            }
        }
    }
}
