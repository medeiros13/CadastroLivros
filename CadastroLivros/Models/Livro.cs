using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroLivros.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Livro(int id, string nome, double preco, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            DataCadastro = dataCadastro;
        }
    }
}