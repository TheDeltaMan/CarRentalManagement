using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
                (
                new IdentityUserRole<string>
                {
                    RoleId = "2ee65e55 - da0c - 405c - bbd6 - de6805ba6696", // ID for administrator role
                    UserId = "07308287-b64a-458f-baaa-82c870e7ba69" // ID for the administrative application user
                },

                new IdentityUserRole<string>
                {
                    RoleId = "92045038 - 7b66 - 4dfd - 9ba9 - 66dc23cd805c",  // ID for user role
                    UserId = "8e795a5c-0ab5-4d3a-bba0-68b8e46ce73f" //ID for the regular application user
                }
                );
        }
    }
}
