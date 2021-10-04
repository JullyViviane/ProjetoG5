usando  Modeloa . Cadastros ;
usando  Persistencia . Contexto ;
using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Dados . Entidade ;
usando o  sistema . Linq ;
usando o  sistema . Texto ;
usando o  sistema . Threading . Tarefas ;

namespace  Persistenciaa . DAL . Cadastros
{
     classe  pública FabricanteDAL
    {
         contexto EFContext  privado = novo EFContext ();   
        public  IQueryable < Fabricante > ObterFabricantesClassificadosPorNome ()
        {
             contexto de retorno . Fabricantes . OrderBy ( b  =>  b . Nome );
        }

        public  Fabricante  ObterFabricantePorId ( long  id )
        {
             contexto de retorno . Fabricantes . Onde ( f  =>  f . FabricanteId  ==  id ). Primeiro ();
        }
        public  void  GravarFabricante ( Fabricante  fabricante )
        {
            if ( fabricante . FabricanteId  ==  0 )
            {
                contexto . Fabricantes . Adicionar ( fabricante );
            }
            outro
            {
                contexto . Entry ( fabricante ). State  =  EntityState . Modificado ;
            }
            contexto . SaveChanges ();
        }
        public  Fabricante  EliminarFabricantePorId ( long  id )
        {
            Fabricante  fabricante  =  ObterFabricantePorId ( id );
            contexto . Fabricantes . Remover ( fabricante );
            contexto . SaveChanges ();
            return  fabricante ;
        }
    }
}