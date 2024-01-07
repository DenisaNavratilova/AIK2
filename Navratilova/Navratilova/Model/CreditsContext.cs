using Microsoft.EntityFrameworkCore;
using Navratilova.Model;
using System.Collections.Generic;

namespace Navratilova.Model
{
    public class CreditsContext : DbContext
    {
        public DbSet<Credits> Credits { get; set; }

        public CreditsContext(DbContextOptions options) : base(options)
        {

        }
    }
}
