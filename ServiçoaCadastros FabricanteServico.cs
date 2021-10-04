usando  Modeloa . Cadastros ;
usando  Persistenciaa . DAL . Cadastros ;
using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Dados . Entidade ;
usando o  sistema . Linq ;
usando o  sistema . Texto ;
usando o  sistema . Threading . Tarefas ;

namespace  Servi ç oa . Cadastros
{
    public  class  FabricanteServico
    {
        private  FabricanteDAL  fabricanteDAL  =  novo  FabricanteDAL ();
        public  IQueryable < Fabricante > ObterFabricantesClassificadosPorNome ()
        {
            return  fabricanteDAL . ObterFabricantesClassificadosPorNome ();
        }
        public  Fabricante  ObterFabricantePorId ( long  id )
        {
            return  fabricanteDAL . ObterFabricantePorId ( id );
        }
        public  void  GravarFabricante ( Fabricante  fabricante )
        {
            fabricanteDAL . GravarFabricante ( fabricante );
        }
        public  Fabricante  EliminarFabricantePorId ( long  id )
        {
            return  fabricanteDAL . EliminarFabricantePorId ( id );
        }
    }
}