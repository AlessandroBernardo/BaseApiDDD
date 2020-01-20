using System.ComponentModel.DataAnnotations;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            var b = builder;
            b.ToTable("Usuario");
            b.HasKey(u => u.Id);

            //b.Property(u => u.IdUser).UseSqlServerIdentityColumn();

            b.HasIndex(u => u.Email).IsUnique();
            b.Property(u => u.Name).IsRequired().HasMaxLength(60);
            b.Property(u => u.Email).HasMaxLength(100);
        }
    }
}
