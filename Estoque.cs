using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Texto ;
usando o  sistema . Threading . Tarefas ;

namespace  Aula14
{
    classe  Estoque
    {
         Dicionário privado < Produto , int > _itens ;

         Dicionário público < Produto , int > Itens
        {
            get { return  this . _itens ; }
        }
                
         Estoque público ()
        {
            isso . _itens  =  novo  Dicionário < Produto , int > ();
        }

        public  void  Adicionar ( Produto  item , int  quantidade )
        {
            if ( this . _itens . ContainsKey ( item ))
                isso . _itens [ item ] =  isso . _itens [ item ] +  quantidade ;
            senão
                isso . _itens [ item ] =  quantidade ;
        }

        public  void  Adicionar ( item Produto  )
        {
            isso . Adicionar ( item , 1 );
        }

        public  void  Adicionar ( List < Produto > itens )
        {
            foreach ( item var  em itens )  
            {
                isso . Adicionar ( item );
            }
        }

        public  void  Adicionar ( Dicionário < Produto , int > itens )
        {
            foreach ( KeyValuePair < Produto , int > parOrdenado  em  itens )
            {
                isso . Adicionar ( parOrdenado . Key , parOrdenado . Value );
            }
        }

        public  void  ImprimirEstoque ()
        {
            Console . WriteLine ( " ======== Estoque ======== " );
            foreach ( KeyValuePair < PRODUTO , int > parOrdenado  no  presente . _itens )
            {
                parOrdenado . Chave . Imprimir ();
                Console . WriteLine ( " Quantidade: \ t {0} " , parOrdenado . Valor );
                Console . WriteLine ( " ============================ " );
            }
            
        }
    }
}
