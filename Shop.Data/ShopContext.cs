using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;
using Store.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        public DbSet<Shop> Shops { get; set; }

        public DbSet<FileTodatabase> FilesToDatabase { get; set; }
    }
}
