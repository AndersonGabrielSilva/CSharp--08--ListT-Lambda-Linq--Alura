using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
   public static class ListExtensoes
    {
        /*A criação de um metodo generico é bem semelhante com a criação de uma classe generica,
         é somentecolocaro "<T>" indicando parao compilador que setrata deum metodo genereico.
         apartir deste momento o metodo que antes já era uma extenção da "List" por conta da palavra reservada "this" 
         começa tambemser generico.*/
        public static void AdicionarVarios<T>(this List<T> listaItens,params T[] itens)
        {
            foreach (T item in itens)
            {
                listaItens.Add(item);
            }
        }
















        static void teste()
        {
            /*Quando criamos uma lista, generica precisamosinformar o tipo dela. entre <Tipo> para poder retornar valor
             * e tambem adicionar os itens.
             Podemos criar listas do tipo "int"assim como do tipo "string". */
            List<int> idades = new List<int>();
            idades.Add(5);
            idades.Add(15);
            idades.Add(25);
            idades.AdicionarVarios(7,4,5,10);
            /*Para chamar um metodo de estensão, do tipo generico precisamos. Informar o tipo que tambem dalista. */
            //ListExtensoes<int>.AdicionarVarios(idades,7,4,5,10);
                        
            List<string> nomes = new List<string>();
            nomes.Add("Anderson Gabriel");
            nomes.AdicionarVarios("Livia","Dulce","Jean");
           // ListExtensoes<string>.AdicionarVarios(nomes,"Livia","Dulce","Jean");
        
        }

    }
}
