using Microsoft.EntityFrameworkCore;
using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Context
{
    public class InLockContext : DbContext
    {
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TiposDeUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        /// <summary>
        /// define as opcoes de construcao do banco(String Conexao)
        /// </summary>
        /// <param name="optionsBuilder">objeto com as configuracoes definidas</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2KJISQH\\SENAI; Database= inlock.codeFirst.manha; User Id= sa; Pwd= Senai@134; TrustServerCertificate= True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
