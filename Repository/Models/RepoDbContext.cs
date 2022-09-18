using Microsoft.EntityFrameworkCore;

namespace ASP.Net6Repository.Models
{
    public class RepoDbContext : DbContext
    {
        public RepoDbContext() { }
        public RepoDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Repository> repositorys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=AY1KPKYG2U1G;Database=RepoDb;User Id=sa; Password=!Morning1;MultipleActiveResultSets=true");
            }
        }
    }
}
