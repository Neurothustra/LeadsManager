using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeadsManager.Models;
using Microsoft.EntityFrameworkCore;

namespace LeadsManager.Data
{
    public class TalismaContext : DbContext
    {
        public TalismaContext (DbContextOptions<TalismaContext> options)
            : base(options)
        {
        }

        public DbSet<Talisma> Talisma { get; set; }
    }
}
