using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Models;

namespace Project.Configuration_Classes
{
    internal class ProjectConfigurations : IEntityTypeConfiguration<Project.Models.Project>
    {
        public void Configure(EntityTypeBuilder<Project.Models.Project> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                   .UseIdentityColumn(10, 10);

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .HasDefaultValue("OurProject");

            builder.Property(p => p.Cost)
                   .HasColumnType("money");

            builder.HasCheckConstraint("CK_Project_Cost", "Cost BETWEEN 500000 AND 3500000");
        }
    }
}
