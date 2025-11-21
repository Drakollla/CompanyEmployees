using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "c2d29786-3c88-430d-8575-e6f5f6037952",
                Name = "Manager",
                NormalizedName = "MANAGER"
            },
            new IdentityRole
            {
                Id = "f620031e-f23d-466c-97f4-953674c63128",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            }
            );
        }

    }
}
