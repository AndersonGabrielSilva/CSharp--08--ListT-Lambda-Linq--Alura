using ByteBank.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
            {
                return 0;
            }
            if (x == null)
            {
                return 1;//Manda o X para depois do Y   //   Mandando o X para o final.
            }

            if (y == null)
            {
                return -1;//Traz o X para frente do Y   //    mandando o Y para o final.
            }

    //-------------------------------------------------------------------------------------------------
            if (x.Agencia < y.Agencia)
            {
                return -1; // Traz o X para frente do Y.
            }

            if (x.Agencia == y.Agencia)
            {
                return 0; //São Equivalentes.
            }

                return 1; //Traz o Y para frente do X.
    //-------------------------------------------------------------------------------------------------
            /*Nossas comparaçoes de números inteiros é equivalente ao que ja existe no tipo INT.
                    return x.Agencia.CompareTo(y.Agencia);
            
            Este return a cima realiza a mesma função do bloco a cima com aqueles 3 IF.  

             */
        }


    }
}
