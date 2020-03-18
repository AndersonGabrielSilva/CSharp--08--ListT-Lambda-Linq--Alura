using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaSort();

            Console.ReadLine();
        }
        
        static void TestandoVar()
        {
            /*A variavel "var" é uma variavel do tipo generico ou seja ela se adequa de acordo com o tipo da instancia que é iniciada.
             O que estou informando ao compilador é que a no local do "var" eu quero que seja do tipo Ex:
             ContaCorrente, GerenciadorBonificaçãoe e etc.
             Ela funciona como se fosse o <T> das classes genericas. 

            Variaveis do tipo "var"devem ser inicialidas para o compilador ja definir o tipo. Depois de inicializada, ela não pode mais ser atribuida.
            Como por exemplo mais abaixo o "var idade" e o "var nome"   */
            var conta = new ContaCorrente(1245, 598745);
            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>();
            var idade = 25;
            var nome = "Anderson";

            conta.Depositar(50);
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

            //List<int> idades = new List<int>();
            var idades = new List<int>();

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

        static void TestaSort()
        {
            //----------------------------------------------------------------------------------------------------------------------
            //TESTE CONTA CORRENTE
            var contas = new List<ContaCorrente>()
            {

                new ContaCorrente(240,45875),
                new ContaCorrente(451,74575),
                new ContaCorrente(350,96545),
                new ContaCorrente(190,45125),
                new ContaCorrente(254,45585)
            };

            //contas.Sort(); ~~>Ultiliza ainterface ICompareble, por se tratar de objeto.
            contas.Sort(new ComparadorContaCorrentePorAgencia());
            foreach (var conta in contas)
            {
                Console.WriteLine($"Agencia: {conta.Agencia}/Numero: {conta.Numero}");
            }
            
//----------------------------------------------------------------------------------------------------------------------
            //TESTE STRING
            var nomes = new List<string>();
            nomes.Add("Anderson");
            nomes.AdicionarVarios("Gabriel","Daniel","Jean","Dulce");
            nomes.Sort();
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
//----------------------------------------------------------------------------------------------------------------------
            //TESTE IDADES
            var idades = new List<int>();
            idades.Add(5);
            idades.Add(10);
            idades.Add(15);
            idades.Add(55);
            idades.AddRange(new int[] { 1, 2, 3, 4, 5, 10 });
            idades.AdicionarVarios(15, 20, 14, 78);
            idades.Remove(10);
            idades.Sort();
            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

        }
    }     
}
