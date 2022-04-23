using DataLayer.Documents.Models;
using DataLayer.EF.Configs;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DocumentEntity> Documents { get; private set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DocumentsConfiguration());
        }
    }
}