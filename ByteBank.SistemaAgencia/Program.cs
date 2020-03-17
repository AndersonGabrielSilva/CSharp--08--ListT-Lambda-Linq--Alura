using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaListExtencoes();

            Console.ReadLine();
        }

        static  void TestaListExtencoes()
        {
            /*O proprio dotNet já possui uma classe list, para crir uma lista.´Por serbastante ultilizada pelos desenvolvedores.
             Ela possui alguns metodos como por exemplo:
             ".Add" = Que adiciona itens a lista..
             ".AddRange" = Adicionaos elementos de um array ao final de nossa lista.
             ".Remove" = Que remove os itens da lista.
             ".RemoveAll" = Que remove todos itens da lista.
             ".Count" = Retorna a quantidadedos itens presentesna lista(Tamanho).
             ".Contains" = Verifica se alguem item esta na lista.
             ".ToArray" = Copia todos os elementos de uma listapara outra 
             */
            List<int> idades = new List<int>();

            idades.Add(5);
            idades.Add(10);
            idades.Add(15);
            idades.Add(55);
            idades.AddRange(new int[] { 1, 2, 3, 4, 5, 10 });
            
            idades.AdicionarVarios(15, 20, 14, 78, 55555);
            //ListExtensoes.AdicionarVarios(idades,45,47,10,23,94,100);

            idades.Remove(10);
            // idades.AdicionarVarios(1, 5, 78);
            for (int i = 0; i < idades.Count; i++)
            {

                Console.WriteLine(idades[i]);

            }
        }
              
    }
}
