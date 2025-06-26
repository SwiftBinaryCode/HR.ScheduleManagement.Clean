using HR.ScheduleManagement.Ident.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ScheduleManagement.Ident.DbContext
{
    public class HRScheduleManagementIdentDbContext : IdentityDbContext<ApplicationUser>
    {
        public HRScheduleManagementIdentDbContext(DbContextOptions<HRScheduleManagementIdentDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(HRScheduleManagementIdentDbContext).Assembly);
        }

    }
}
