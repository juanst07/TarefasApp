using Microsoft.EntityFrameworkCore;
using TarefasApp.Models;

namespace TarefasApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}