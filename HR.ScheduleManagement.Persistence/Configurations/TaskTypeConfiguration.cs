using HR.ScheduleManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.ScheduleManagement.Persistence.Configurations
{
    public class TaskTypeConfiguration : IEntityTypeConfiguration<TaskType>
    {
        public void Configure(EntityTypeBuilder<TaskType> builder)
        {
            builder.HasData(
               new TaskType
               {
                   Id = 1,
                   Title = "Shipping",
                   

               }
           );

            builder.Property(q => q.Title)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
