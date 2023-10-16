using ADMISSION_PROCESS.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Common;

namespace ADMISSION_PROCESS.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Admission_Form> Admission_Forms { get; set; }

        public DbSet<Registration> Registrations { get; set; }

        public DbSet<Fee_Structure> Fee_Structures { get; set; }

    }
}
