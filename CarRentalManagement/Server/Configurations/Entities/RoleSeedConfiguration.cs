using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
               (
                   new IdentityRole
                   {
                       Id = "92045038 - 7b66 - 4dfd - 9ba9 - 66dc23cd805c",
                       Name = "User",
                       NormalizedName = "USER"
                   },
                   new IdentityRole
                   {
                       Id = "2ee65e55 - da0c - 405c - bbd6 - de6805ba6696",
                       Name = "Administrator",
                       NormalizedName = "ADMINISTRATOR"
                   }

               );
        }
    }
}
