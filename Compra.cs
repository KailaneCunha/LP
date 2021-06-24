using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Linq ;
usando o  sistema . Texto ;
usando o  sistema . Threading . Tarefas ;

namespace  Aula14
{
    classe  Compra
    {
        Carrinho  _produtos ;
        Estoque  _estoque ;
        público  Carrinho  Produtos
        {

            obter
            {
                return  _produtos ;
            }

        }
         Estoque  público Estoque
        {

            obter
            {
                return  _estoque ;
            }

        }
         Compra pública ( Carrinho  produtos , Estoque  estoque )
        {

            isso . _estoque  =  estoque ;
            isso . _produtos  =  produtos ;
            
        }
        public  void  F_Dinero ()
        {
        
            foreach ( KeyValuePair < PRODUTO , int > par  no  presente . _produtos . Itens )
            {

                if ( this . _estoque . Itens . ContainsKey ( pair . Key ) &&  this . _estoque . Itens [ pair . Key ] > =  this . _produtos . Itens [ pair . Key ])
                {
                    
                    isso . _estoque . Itens [ pair . Chave ] - =  par . Valor ;
                    Console . WriteLine ( " Comprado "  +  par . Key . Nome );
                
                }

            }
        
        }

    }
}
