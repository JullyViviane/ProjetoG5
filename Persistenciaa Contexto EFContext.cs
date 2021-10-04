using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Web ;
usando o  sistema . Dados . Entidade ;
usando  Modeloa . Cadastros ;
usando  Modeloa . Tabelas ;
usando o  sistema . Dados . Entidade . ModelConfiguration . Convenções ;
usando  Persistenciaa . Migrações ;

namespace  Persistencia . Contexto
{
    público  classe  EFContext : DbContext
    {
        public  EFContext (): base ( " Asp_Net_MVC_CS " )
        {
            Banco de dados . SetInitializer < EFContext > ( nova  MigrateDatabaseToLatestVersion < EFContext , Configuração > ());
        }
        public  DbSet < Categoria > Categorias { get ; definir ; }
        public  DbSet < Fabricante > Fabricantes { get ; definir ; }
        public  DbSet < Produto > Produtos { get ; definir ; }
        protected  override  void  OnModelCreating ( DbModelBuilder  modelBuilder )
        {
            base . OnModelCreating ( modelBuilder );
            modelBuilder . Convenções . Remova < PluralizingTableNameConvention > ();
        }
    }
}