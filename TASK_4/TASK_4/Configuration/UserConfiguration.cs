using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TASK_4.Models;
namespace TASK_4.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
                builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("ID");
                builder.Property(x => x.Name).HasMaxLength(100).HasColumnType("varchar").HasColumnName("Name");
                builder.Property(x => x.Email).HasColumnType("varchar").HasColumnName("Email");
                builder.Property(x => x.LastSeen).HasColumnName("LastSeen");
                builder.Property(x => x.IsActive).HasColumnName("Block");
                builder.Property(x => x.Password).HasColumnName("Password");
                builder.HasIndex(x => x.Email).IsUnique();
        }
        
    }
}
