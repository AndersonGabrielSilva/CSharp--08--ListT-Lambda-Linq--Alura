using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class IComparer
    {

        /*ICOMPARER:
         Compare: Ultilizamos este metodo da interface Icomparer para poder comparar itens de 2 objetos do mesmo tipo.
         Sintaxe:

                                  public int Compare(ContaCorrente x, ContaCorrente y)
                                  {


                                  }

        Recebe os dois objetos da lista [x,y] e aplica a logica do bloco para ordenar a lista. 
        Seguindo a mesma logica do CompareTo returnando (Negativo, Zero ou Positivo), para chamar 
        este metodo no "Sort".
        A diferença fica que no CompareTo são comparados duas instancias e aqui no IComparer são
        comparados dois objetos.

                                    nomeVariavel.Sort(new NomedaClassequeCompara());

        Passo a Passo:

        1º → Cria uma classe.
        2º → Assino o contrato com a Interface Icompare ->(Fazendo herdar dela) que é uma interface generica. E informando o tipo que ela 
        devera ser. Ex: 
                        public class ComparadorContaCorrentePorAgencia: IComparer<ContaCorrente>
        3º → Monto o metodo que a interface pede para implementar.
        4º → Escrevo no metodo a logica da minha ordenação.
        5º → 
         
         */

    }
}
