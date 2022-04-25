using DataLayer.Clients.Models;
using DataLayer.Documents.Models;
using DataLayer.EF.Configs;
using DataLayer.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DocumentEntity> Documents { get; private set; }
        public DbSet<ClientEntity> Clients { get; private set; }
        public DbSet<NotaryEntity> Notaries { get; private set; }
        public DbSet<UserEntity> Users { get; private set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DocumentsConfiguration());
            builder.ApplyConfiguration(new NotariesConfiguration());
            builder.ApplyConfiguration(new ClientsConfiguration());
            builder.ApplyConfiguration(new UsersConfiguration());
        }
    }
}