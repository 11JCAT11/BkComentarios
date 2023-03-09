using BAComentarios.Models;
using Microsoft.EntityFrameworkCore;

namespace BAComentarios
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Comentario> Comentario { get; set;}
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {
            
        }
    }
}
