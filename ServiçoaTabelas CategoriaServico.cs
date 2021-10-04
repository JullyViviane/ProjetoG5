usando  Modeloa . Tabelas ;
usando  Persistenciaa . DAL . Tabelas ;
using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Texto ;
usando o  sistema . Threading . Tarefas ;

namespace  Servi ç oa . Tabelas
{
    public  class  CategoriaServico
    {
        privado  CategoriaDAL  categoriaDAL  =  novo  CategoriaDAL ();
        public  IQueryable < Categoria > ObterCategoriasClassificadasPorNome ()
        {
            retornar  categoriaDAL . ObterCategoriasClassificadasPorNome ();
        }
        public  Categoria  ObterCategoriaPorId ( long  id )
        {
            retornar  categoriaDAL . ObterCategoriaPorId ( id );
        }
        public  void  GravarCategoria ( Categoria  categoria )
        {
            categoriaDAL . GravarCategoria ( categoria );
        }
        public  Categoria  EliminarCategoriaPorId ( id longo  )
        {
            retornar  categoriaDAL . EliminarCategoriaPorId ( id );
        }
    }
}
