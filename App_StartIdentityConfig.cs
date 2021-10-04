using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;
usando a  Microsoft . AspNet . Identidade ;
usando a  Microsoft . Owin ;
usando a  Microsoft . Owin . Segurança . Cookies ;
using  Owin ;
usando  um . DAL ;
usando  um . Infraestrutura ;

namespace  a . App_Start
{
    public  class  IdentityConfig
    {
         Configuração de void  público ( aplicativo IAppBuilder ) 
        {
            app . CreatePerOwinContext < IdentityDbContextAplicacao > ( IdentityDbContextAplicacao . Create );
            app . CreatePerOwinContext < GerenciadorUsuario > ( GerenciadorUsuario . Create );
            app . CreatePerOwinContext < GerenciadorPapel > ( GerenciadorPapel . Criar );
            app . UseCookieAuthentication ( new  CookieAuthenticationOptions
            {
                AuthenticationType  =  DefaultAuthenticationTypes . ApplicationCookie ,
                LoginPath  =  new  PathString ( " / Seguranca / Account / Login " ),
            });
        }

    }
}