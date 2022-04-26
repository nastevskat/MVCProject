#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Data
{
    public class MVCProjectContext : DbContext
    {
        public MVCProjectContext (DbContextOptions<MVCProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MVCProject.Models.Student> Student { get; set; }

        public DbSet<MVCProject.Models.Course> Course { get; set; }

        public DbSet<MVCProject.Models.Teacher> Teacher { get; set; }
    }
}
