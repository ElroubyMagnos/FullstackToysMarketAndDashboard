using Microsoft.EntityFrameworkCore;
using ToysCore.Models;

namespace ToysCore
{
    public class tcore: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            base.OnConfiguring(ob);
            ob.UseSqlServer("Data Source=192.168.1.150,1433;Initial Catalog=ToysCore;User ID=sa;Password=Magnos0182163958;Integrated Security=True;MultiSubnetFailover=True;Encrypt=true;TrustServerCertificate=True;Trusted_Connection=false;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Category>()
                .HasMany(x => x.LinkedProducts)
                .WithOne(x => x.LinkedCategory)
                .HasForeignKey(x => new
                {
                    x.CategoryID,
                    x.CategoryName
                });

            mb.Entity<Category>()
                .HasKey(x => new
                {
                    x.ID,
                    x.Name
                });

            mb.Entity<Bill>()
                .HasMany(x => x.LinkedPaidProducts)
                .WithOne(x => x.LinkedBill)
                .HasForeignKey(x => x.BillID);

            mb.Entity<Product>()
                .HasMany(x => x.LinkedProductsSon)
                .WithOne(x => x.LinkedProduct)
                .HasForeignKey(x => x.ParentProductID);

            mb.Entity<Category>()
                .HasIndex(x => x.Name)
                .IsUnique(true);

            mb.Entity<Bill>()
            .HasIndex(x => x.BillNumber)
            .IsUnique(true);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PaidProduct> PaidProducts { get; set; }
        public DbSet<BasicInfo> BasicInfo { get; set; }
        public DbSet<EmailMsg> Emails { get; set; }
    }
}
