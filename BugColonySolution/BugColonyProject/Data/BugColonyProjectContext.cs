using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BugColonyProject.Models;

namespace BugColonyProject.Data
{
    public class BugColonyProjectContext : DbContext
    {
        public BugColonyProjectContext (DbContextOptions<BugColonyProjectContext> options)
            : base(options)
        {
        }

        public DbSet<BugColonyProject.Models.Group> Group { get; set; } = default!;
    }
}
