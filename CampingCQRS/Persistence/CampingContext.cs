using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class CampingContext : DbContext
    {
        public CampingContext(DbContextOptions<CampingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}