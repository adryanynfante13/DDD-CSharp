using Microsoft.EntityFrameworkCore;
using person.DDD.Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace person.DDD.Infrastructure
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(o => { 
                o.HasKey(x => x.Id); 
            });

            modelBuilder.Entity<Domain.Entities.Person>().OwnsOne(o => o.Name, add =>
            {
                add.Property(x => x.Value).HasColumnName("Name");
            });
             modelBuilder.Entity<Domain.Entities.Address>().OwnsOne(o => o.AddressLinel, add =>
             {
                 add.Property(x => x.Value).HasColumnName("linel");
             });
            modelBuilder.Entity<Domain.Entities.Address>().OwnsOne(o => o.AddressPostalCode, add =>
              {
                  add.Property(x => x.Value).HasColumnName("postalCode");
              });

            modelBuilder.Entity<Person>().HasMany(o => o.Addresses)
                .WithOne(o=>o.Person).HasForeignKey(o => o.PersonId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
