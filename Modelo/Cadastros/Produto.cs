using System;
using Modelo.Tabelas;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Produto
    {
        [DisplayName("Código")]
        public long? ProdutoId { get; set; }

        [StringLength(100, ErrorMessage = "O nome do produto precisa ter no mínimo 10 caracteres", MinimumLength = 10)]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data de Cadastro")]
        [Required(ErrorMessage = "Informe a data de cadastro do produto")]
        public DateTime? DataCadastro { get; set; }

        [DisplayName("Categoria")]
        public long? CategoriaId { get; set; }

        [DisplayName("Fabricante")]
        public long? FabricanteId { get; set; }

        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}