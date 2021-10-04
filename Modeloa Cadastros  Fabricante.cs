using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;
usando  Modeloa . Tabelas ;

namespace  Modeloa . Cadastros
{
     classe  pública fabricante
    {
        public  long  FabricanteId { get ; definir ; }
         string  pública Nome { get ; definir ; }
         ICollection virtual  pública < Produto > Produtos { get ; definir ; }
    }
}