using HR.ScheduleManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.ScheduleManagement.Persistence.Configurations
{
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<EmployeeType>
    {
        public void Configure(EntityTypeBuilder<EmployeeType> builder)
        {
            builder.HasData(
               new EmployeeType
               {
                   Id = 1,
                   Name = "Test1",
                   Position = "O/E",
                   Task = "Shipping",
                   secondTask = "Scanning"
                 

               }
           );

            builder.Property(q => q.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
