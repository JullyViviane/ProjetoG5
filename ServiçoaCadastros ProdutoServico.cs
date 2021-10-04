usando  Modeloa . Cadastros ;
usando  Persistenciaa . DAL . Cadastros ;
using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Texto ;
usando o  sistema . Threading . Tarefas ;

namespace  Servi ç oa . Cadastros
{
    public  class  ProdutoServico
    {
        Produto  privadoDAL  produtoDAL  =  novo  ProdutoDAL ();
        public  IQueryable < Produto > ObterProdutosClassificadosPorNome ()
        {
            retornar  produtoDAL . ObterProdutosClassificadosPorNome ();
        }
        public  Produto  ObterProdutoPorId ( long  id )
        {
            retornar  produtoDAL . ObterProdutoPorId ( id );
        }
        public  void  GravarProduto ( Produto  produto )
        {
            produtoDAL . GravarProduto ( produto );
        }
        public  Produto  EliminarProdutoPorId ( id longo  )
        {
            retornar  produtoDAL . EliminarProdutoPorId ( id );
        }
    }
}