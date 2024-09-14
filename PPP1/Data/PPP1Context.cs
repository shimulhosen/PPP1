using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PPP1.Model;

namespace PPP1.Data
{
    public class PPP1Context(DbContextOptions<PPP1Context> options) : DbContext(options)
    {
        public DbSet<PPP1.Model.Department> Department { get; set; } = default!;
    }
}
