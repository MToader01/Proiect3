using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proiect3.Models
{
    public class BuyedProductModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }

    public class BuyedProductModelDbContext : DbContext
    {
        public DbSet<BuyedProductModel> BuyedProducts { get; set;}
    }
}