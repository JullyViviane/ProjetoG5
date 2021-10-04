namespace  Persistenciaa . Migrações
{
    using  System ;
    usando o  sistema . Dados . Entidade . Migrações ;
    
     classe pública parcial  InitialCreate : DbMigration 
    {
        public  override  void  Up ()
        {
            CreateTable (
                " dbo.Categoria " ,
                c  =>  novo
                    {
                        CategoriaID  =  c . Longo ( anulável : falso , identidade : verdadeiro ),
                        Nome  =  c . String (),
                    })
                . PrimaryKey ( t  =>  t . CategoriaID );
            
            CreateTable (
                " dbo.Produto " ,
                c  =>  novo
                    {
                        ProdutoId  =  c . Longo ( anulável : falso , identidade : verdadeiro ),
                        Nome  =  c . String (),
                        CategoriaId  =  c . Longo (),
                        FabricanteId  =  c . Longo (),
                    })
                . PrimaryKey ( t  =>  t . ProdutoId )
                . ForeignKey ( " dbo.Categoria " , t  =>  t . CategoriaId )
                . ForeignKey ( " dbo.Fabricante " , t  =>  t . FabricanteId )
                . Índice ( t  =>  t . CategoriaId )
                . Índice ( t  =>  t . FabricanteId );
            
            CreateTable (
                " dbo.Fabricante " ,
                c  =>  novo
                    {
                        FabricanteId  =  c . Longo ( anulável : falso , identidade : verdadeiro ),
                        Nome  =  c . String (),
                    })
                . PrimaryKey ( t  =>  t . FabricanteId );
            
        }
        
        public  override  void  Down ()
        {
            DropForeignKey ( " dbo.Produto " , " FabricanteId " , " dbo.Fabricante " );
            DropForeignKey ( " dbo.Produto " , " CategoriaId " , " dbo.Categoria " );
            DropIndex ( " dbo.Produto " , new [] { " FabricanteId " });
            DropIndex ( " dbo.Produto " , novo [] { " CategoriaId " });
            DropTable ( " dbo.Fabricante " );
            DropTable ( " dbo.Produto " );
            DropTable ( " dbo.Categoria " );
        }
    }
}