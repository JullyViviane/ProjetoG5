usando  Modeloa . Cadastros ;
usando  Modeloa . Tabelas ;
usando  Persistencia . Contexto ;
using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Dados . Entidade ;
usando o  sistema . Linq ;
usando o  sistema . Texto ;
usando o  sistema . Threading . Tarefas ;

namespace  Persistenciaa . DAL . Cadastros
{
    public  class  ProdutoDAL
    {
         contexto EFContext  privado = novo EFContext ();   
        public  IQueryable < Produto > ObterProdutosClassificadosPorNome ()
        {
             contexto de retorno . Produtos . Incluir ( c  =>  c . Categoria ). Inclui ( f  =>  f . Fabricante ).
            OrderBy ( n  =>  n . Nome );
        }
        public  Produto  ObterProdutoPorId ( long  id )
        {
             contexto de retorno . Produtos . Onde ( p  =>  p . ProdutoId  ==  id ). Incluir ( c  =>  c . Categoria ).
            Inclui ( f  =>  f . Fabricante ). Primeiro ();
        }
        public  void  GravarProduto ( Produto  produto )
        {
            if ( produto . ProdutoId  ==  null )
            {
                contexto . Produtos . Adicionar ( produto );
            }
            outro
            {
                contexto . Entrada ( produto ). State  =  EntityState . Modificado ;
            }
            contexto . SaveChanges ();
        }
        public  Produto  EliminarProdutoPorId ( id longo  )
        {
            Produto  produto  =  ObterProdutoPorId ( id );
            contexto . Produtos . Remover ( produto );
            contexto . SaveChanges ();
            return  produto ;
        }
    }

}
    

