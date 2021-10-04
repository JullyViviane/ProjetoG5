usando o  sistema . Web . Mvc ;

namespace  a . Áreas . Cadastro
{
    public  class  CadastroAreaRegistration : AreaRegistration 
    {
        public  override  string  AreaName 
        {
            pegue 
            {
                retornar  " Cadastro " ;
            }
        }

        public  override  void  RegisterArea ( AreaRegistrationContext  context )
        {
            contexto . MapRoute (
                " Cadastro_default " ,
                " Cadastro / {controlador} / {ação} / {id} " ,
                novo { action  =  " Índice " , id  =  UrlParameter . Opcional }
            );
        }
    }
}
