using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.EntityFrameworkCore;

namespace SenacAlimentacao;
// banco de dados representado no cSharp

public class ComandaDBContext:DbContext//banco de dados representado no cSharp
{
    public ComandaDBContext()  : base()
    { 
    }
    // construtor que recebe o DbContextOptions
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // string de conexão com o banco de dados
        var conexao = "Server=localhost;Database=SenacAlimentacao;User=root;Password=";
        //configuração do banco de dados MySQL, conf do provedor de banco de dados
        optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        //configuração do banco de dados
        base.OnConfiguring(optionsBuilder);

    }
    public DbSet<Usuario> Usuarios { get; set; } //tabela usuarios
    public DbSet<CardapioItem> CardapioItens { get; set; } //tabela cardápio
    public DbSet<Mesa> Mesas { get; set; } //tabela mesas
    public DbSet<Comanda> Comandas { get; set; } //tabela comandas
    public DbSet<ComandaItem> ComandaItens { get; set; } //tabela itens da comanda
    public DbSet<PedidoCozinha> PedidosCozinha { get; set; } //tabela pedidos de cozinha
    public DbSet<PedidoCozinhaItem> PedidosCozinhaItens { get; set; } //tabela itens dos pedidos de cozinha
}
//comandos sempre ficam no plural | palavras em branco o dev pode alterar  