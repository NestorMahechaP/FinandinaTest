using BancoFinandina.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFinandina.Persistence.Database.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(p => p.Id);
            entityTypeBuilder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            entityTypeBuilder.Property(p => p.Nationality).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(15);
        }
    }
}
