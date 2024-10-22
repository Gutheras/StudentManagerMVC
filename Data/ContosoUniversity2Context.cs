using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity2.Data
{
    public class ContosoUniversity2Context : DbContext
    {
        public ContosoUniversity2Context(DbContextOptions<ContosoUniversity2Context> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Students { get; set; } = default!;
        public DbSet<ContosoUniversity.Models.Course> Courses { get; set; } = default!;
        public object Course { get; internal set; }
    }
}
