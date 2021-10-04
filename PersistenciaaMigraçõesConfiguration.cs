namespace  Persistenciaa . Migrações
{
    using  System ;
    usando o  sistema . Dados . Entidade ;
    usando o  sistema . Dados . Entidade . Migrações ;
    usando o  sistema . Linq ;

     classe lacrada  interna Configuração : DbMigrationsConfiguration < Persistencia . Contexto . EFContext > 
    {
         configuração pública ()
        {
            AutomaticMigrationsEnabled  =  true ;
            AutomaticMigrationDataLossAllowed  =  true ;
            ContextKey  =  " Persistencia.Contexts.EFContext " ;
        }

        protected  override  void  Seed (Persistencia.Context. EFContext  context )
        {
            //   Este método será chamado após a migração para a versão mais recente.

            //   Você pode usar o método de extensão auxiliar DbSet <T> .AddOrUpdate ()
            //   para evitar a criação de dados iniciais duplicados.
        }
    }
}