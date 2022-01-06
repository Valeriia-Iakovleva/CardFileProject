using CardFileProject.DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFileProject.DAL
{
    public class CardFileContext : IdentityDbContext<User>
    {
        public CardFileContext() : base("CardFileContext")
        {
        }

        public DbSet<CardFile> CardFiles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<GoodsWarehouse>()
            //    .HasKey(x => new { x.GoodId, x.WarehouseId });
        }

        public static CardFileContext Create()
        {
            return new CardFileContext();
        }
    }
}