using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BillDomain.Entity;

namespace BillDomain.Context
{
    public class LazyAccountContext: DbContext
    {
        public DbSet<BillMain> BillMains { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<LazyAccountContext>(null);
            modelBuilder.Entity<BillMain>().ToTable("trBillMain", "");
            modelBuilder.Entity<BillDetail>().ToTable("trBillDetail", "");
            modelBuilder.Entity<Item>().ToTable("tbItem", "");
        }
    } 
}
