using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<DbContext> options)
            : base(options)
        { }

        public DbSet<DbContext> Contatos { get; set; }
    }
}