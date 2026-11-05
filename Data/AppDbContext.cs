using Microsoft.EntityFrameworkCore;

namespace ProjetoAlunoTurma.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }
        public DbSet
    }
}
