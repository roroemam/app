using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
     class Class1:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) =>
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SectionDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FirstTask.Properties.Resources.covn
            modelBuilder.Entity<Payment>()
                .Property(p => p.paymentDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Donor>()
                .HasMany(p => p.Organizations)
                .WithMany(s => s.Donors)
                .UsingEntity<Relation>(
                j => j.HasOne(p => p.Organization).WithMany(p => p.Relations).HasForeignKey(p => p.Organizationid),
                j => j.HasOne(p => p.Donor).WithMany(p => p.Relations).HasForeignKey(p => p.Donorid),
                j => j.HasKey(i => new { i.Organizationid, i.Donorid })
                );
        }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Organization> Organizations { get; set; }
    }
}

