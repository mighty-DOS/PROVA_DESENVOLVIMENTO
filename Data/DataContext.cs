using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades que vão virar tabelas no banco
        public DbSet<Tarefa> Tarefas { get; set; }

    }
}