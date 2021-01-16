using CadastroLivros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroLivros.BancoDados
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
        public DbSet<Livro> Livros { get; set; }
    }
}
