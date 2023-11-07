using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Trabalho2WEBMVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Impressora> Impressoras { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
