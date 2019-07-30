using TeaTimeSite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaTimeSite.Data.Interfaces
{
    public interface IGoodsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
