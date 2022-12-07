using Microsoft.EntityFrameworkCore;
using RazorOduncTakip.Model;

namespace RazorOduncTakip.Data

{
    public class OduncDbContext :DbContext
    {
        public DbSet<OduncIslem> OduncIslemler { get; set; }
        public OduncDbContext(DbContextOptions<OduncDbContext> options) : base(options)
        {

        }
    }
}
