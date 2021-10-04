using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;
usando o  sistema . Web . Mvc ;
usando o  sistema . Web . Roteamento ;

namespace  a
{
     classe  pública RouteConfig
    {
        public  static  void  RegisterRoutes ( rotas RouteCollection  )
        {
            rotas . IgnoreRoute ( " {resource} .axd / {* pathInfo} " );

            rotas . MapRoute (
                nome : " Padrão " ,
                url : " {controlador} / {ação} / {id} " ,
                padrões : novo { controlador  =  " Categorias " , ação  =  " Índice " , id  =  UrlParameter . Opcional }
            );
        }
    }
}