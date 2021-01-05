using LojaCet50.Models.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LojaCet50.Dados
{
    public class DataContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Clientes> Clientes { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
           
        }
    }
}
