using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchoolsWebAPI.Models;

namespace RainbowSchoolsWebAPI.Data
{
    public class RainbowSchoolsWebAPIDbContext : DbContext
    {
        public RainbowSchoolsWebAPIDbContext (DbContextOptions<RainbowSchoolsWebAPIDbContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchoolsWebAPI.Models.Marks> Marks { get; set; } = default!;
    }
}
