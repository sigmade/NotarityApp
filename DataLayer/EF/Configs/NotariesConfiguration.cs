using DataLayer.Users.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.EF.Configs
{
    public class NotariesConfiguration : IEntityTypeConfiguration<NotaryEntity>
    {
        public void Configure(EntityTypeBuilder<NotaryEntity> builder)
        {
        }
    }
}