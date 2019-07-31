using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeaTimeSite.Data.Models;

namespace TeaTimeSite.Data
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {
            
        }

        public DbSet<Goods> Goods { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
