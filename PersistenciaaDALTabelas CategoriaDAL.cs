usando  Modeloa . Cadastros ;
usando  Modeloa . Tabelas ;
usando  Persistencia . Contexto ;
using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Dados . Entidade ;
usando o  sistema . Linq ;
usando o  sistema . Texto ;
usando o  sistema . Threading . Tarefas ;

namespace  Persistenciaa . DAL . Tabelas
{
     classe  pública CategoriaDAL
    {
         contexto EFContext  privado = novo EFContext ();   
        public  IQueryable < Categoria > ObterCategoriasClassificadasPorNome ()
        {
             contexto de retorno . Categorias . OrderBy ( b  =>  b . Nome );
        }
        public  Categoria  ObterCategoriaPorId ( long  id )
        {
             contexto de retorno . Categorias . Onde ( c  =>  c . CategoriaId  ==  id ). Primeiro ();
        }
        public  void  GravarCategoria ( Categoria  categoria )
        {
            if ( categoria . CategoriaId  ==  0 )
            {
                contexto . Categorias . Adicionar ( categoria );
            }
            outro
            {
                contexto . Entrada ( categoria ). State  =  EntityState . Modificado ;
            }
            contexto . SaveChanges ();
        }
        public  Categoria  EliminarCategoriaPorId ( id longo  )
        {
            Categoria  categoria  =  ObterCategoriaPorId ( id );
            contexto . Categorias . Remover ( categoria );
            contexto . SaveChanges ();
            voltar  categoria ;
        }
    }
}