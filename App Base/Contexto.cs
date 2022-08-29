using Microsoft.EntityFrameworkCore;
using ERPTeste.Models;

namespace ERPTeste.App_Base
{
    public class Contexto : DbContext
    {      
        public Contexto _db = new Contexto();
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
    }
}
