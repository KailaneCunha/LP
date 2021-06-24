using  System ;
usando o  sistema . Coleções . Genérico ;

 classe  pública Fornecedor
{

     string  privada _nome ;
     string  privada _cpf ;
     Estoque  privado _estoque ;

    public  string  Nome
    {
        obter
        {
            devolver isso . _nome ;
        }
    }

    public  string  Cpf
    {
        obter
        {
            devolver  isso . _cpf ;
        }
    }

     string  público Estoque
    {
        obter
        {
            devolver  isso . _estoque ;
        }
    }
     Fornecedor público ( string  nome , string  cpf , Estoque  estoque )
    {
        isso . _cpf  =  cpf ;
        isso . _nome  =  nome ;
        isso . _estoque  =  estoque ;
    }

    public  void  Fornecer ( Produto  produto , int  quantidade )
    {

        isso . _estoque . Adicionar ( produto , quantidade );
        
    }
    public  void  Fornecer ( Lista < Produto > produtos , int  quantidade )
    {
        foreach ( Produto  produto  em  produtos )
        {
            isso . _estoque . Adicionar ( produto , quantidade );
        }
    }




}
