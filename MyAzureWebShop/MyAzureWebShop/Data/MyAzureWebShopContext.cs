using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAzureWebShop.Models;

namespace MyAzureWebShop.Data
{
    public class MyAzureWebShopContext : DbContext
    {
        public MyAzureWebShopContext (DbContextOptions<MyAzureWebShopContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer().en
        //}
        public DbSet<MyAzureWebShop.Models.Product> Product { get; set; }
    }
}
