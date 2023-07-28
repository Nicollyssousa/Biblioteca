using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class BibliotecaContex: DbContext
    {
        public BibliotecaContex(DbContextOptions<BibliotecaContex> options): base(options)
        { 
        
        }

    }
}
