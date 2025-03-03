using Laboratorio1_DPWA.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio1_DPWA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Alumnos> Alumnos { get; set; }
    }
}
