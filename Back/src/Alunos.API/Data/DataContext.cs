using Alunos.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Alunos.API.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Aluno> Alunos { get; set; }        
    }
}