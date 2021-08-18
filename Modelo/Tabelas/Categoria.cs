using System;
using Modelo.Cadastros;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Tabelas
{
    public class Categoria
    {
        public long CategoriaID { get; set; }
        public String Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}