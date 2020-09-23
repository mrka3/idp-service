using IDP.DataLayer.Entities.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IDP.DataLayer
{
    public class IDPContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=idp;Username=postgres;Password=1");
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PeopleParameter> PeopleParameters { get; set; }
        public DbSet<ParameterType> ParametersTypes { get; set; }

    }
}