using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;
usando o  sistema . Web . Mvc ;
usando o  sistema . Dados . Entidade ;
usando o  sistema . Rede ;
usando  Modeloa . Cadastros ;
usando o  Servi ç oa . Cadastros ;
usando o  Servi ç oa . Tabelas ;

namespace  a . Áreas . Cadastros . Controladores
{
    public  class  ProdutosController : Controller
    {
        // contexto EFContext privado = new EFContext ();
        privado  ProdutoServico  produtoServico  =  novo  ProdutoServico ();
        privado  CategoriaServico  categoriaServico  =  novo  CategoriaServico ();
        private  FabricanteServico  fabricanteServico  =  novo  FabricanteServico ();

        Private  ActionResult  ObterVisaoProdutoPorId ( long ? id )
        {
            if ( id  ==  null )
            {
                retornar  novo  HttpStatusCodeResult ( HttpStatusCode . BadRequest );
            }
            Produto  produto  =  produtoServico . ObterProdutoPorId (( longo ) id );
            if ( produto  ==  nulo )
            {
                return  HttpNotFound ();
            }
            voltar  Ver ( produto );
        }

        // Metodo Privado
        privado  void  PopularViewBag ( Produto  produto  =  nulo )
        {
            if ( produto  ==  nulo )
            {
                ViewBag . CategoriaId  =  novo  SelectList ( categoriaServico . ObterCategoriasClassificadasPorNome (),
                " CategoriaId " , " Nome " );
                ViewBag . FabricanteId  =  new  SelectList ( fabricanteServico . ObterFabricantesClassificadosPorNome (),
                " FabricanteId " , " Nome " );
            }
            outro
            {
                ViewBag . CategoriaId  =  novo  SelectList ( categoriaServico . ObterCategoriasClassificadasPorNome (),
                " CategoriaId " , " Nome " , produto . CategoriaId );
                ViewBag . FabricanteId  =  new  SelectList ( fabricanteServico . ObterFabricantesClassificadosPorNome (),
                " FabricanteId " , " Nome " , produto . FabricanteId );
            }
        }
        // Metodo Privado
        privado  ActionResult  GravarProduto ( Produto  produto )
        {
            Experimente
            {
                if ( ModelState . IsValid )
                {
                    produtoServico . GravarProduto ( produto );
                    return  RedirectToAction ( " Index " );
                }
                PopularViewBag ( produto );
                voltar  Ver ( produto );
            }
            pegar
            {
                voltar  Ver ( produto );
            }
        }

        // GET: Produtos
         Índice ActionResult  público ()
        {
            // var produtos =
            // context.Produtos.Include (c => c.Categoria) .Include (f => f.Fabricante).
             // OrderBy (n => n.Nome);
            return  View ( produtoServico . ObterProdutosClassificadosPorNome ());
        }

        // OBTER: Produtos / Detalhes / 5
         Detalhes public ActionResult  ( long ? id )
        {
            retornar  ObterVisaoProdutoPorId ( id );
        }

        // GET: Produtos / Create
        public  ActionResult  Create ()
        {
            PopularViewBag ();
            return  View ();
        }

        // POST: Produtos / Create
        [ HttpPost ]
         Criar ActionResult  público ( Produto produto ) 
        {
            devolver  GravarProduto ( produto );
        }

        // GET: Produtos / Edit / 5
        public  ActionResult  Edit ( long ? id )
        {
            PopularViewBag ( produtoServico . ObterProdutoPorId (( long ) id ));
            retornar  ObterVisaoProdutoPorId ( id );
        }

        // POST: Produtos / Edit / 5
        [ HttpPost ]
         Editar ActionResult  público ( Produto produto ) 
        {
            devolver  GravarProduto ( produto );
        }

        // OBTER: Produtos / Excluir / 5
        public  ActionResult  Delete ( long ? id )
        {
            retornar  ObterVisaoProdutoPorId ( id );
        }

        // POST: Produtos / Delete / 5
        [ HttpPost ]
        public  ActionResult  Delete ( int  id , coleção FormCollection  )
        {
            Experimente
            {
                Produto  produto  =  produtoServico . EliminarProdutoPorId ( id );
                TempData [ " Message " ] =  " Produto "  +  produto . Nome . ToUpper () +  " foi remotada " ;
                return  RedirectToAction ( " Index " );
            }
            pegar
            {
                return  View ();
            }
        }
    }
}
