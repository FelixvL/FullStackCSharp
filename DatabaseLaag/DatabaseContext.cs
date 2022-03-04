using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLaag
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions op) : base(op) { }
        public DbSet<Film>  films { get; set; }
    }
}
