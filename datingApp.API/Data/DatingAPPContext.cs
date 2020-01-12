using datingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace datingApp.API.Data
{
    public class DatingAPPContext :DbContext
    {
        public DatingAPPContext(DbContextOptions<DatingAPPContext> options) : base (options){}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //     => optionsBuilder.UseNpgsql("Host=localhost;Database=datingappdb;Username=postgres;Password=root");     
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}