using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace Piadas.Data
{
    public class PiadasDBContext : DbContext
    {
        public PiadasDBContext (DbContextOptions<PiadasDBContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Piada> Piada { get; set; } = default!;
    }
}
