using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroLivros.Models
{
    public class Livro
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Preco { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }
        public Livro()
        {

        }
        public Livro(int id, string nome, double preco, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            DataCadastro = dataCadastro;
        }
    }
}