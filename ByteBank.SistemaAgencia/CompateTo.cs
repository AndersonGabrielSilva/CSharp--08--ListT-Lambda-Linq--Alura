using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class CompateTo
    {
        /*ICOMPARE TO:
         * Quem chama este metodo, quer saber se minha instancia fica na frente ou atraz do objeto recebido como
         * Argumento.
         * 
         IcompareTo: É um metodo que está continono contrato da Interface (Icompareble).
         è obrigadoa implemtação dele quando queremos ordenar uma lista deobjetos por exemplo.
         Sintaxe:

                     public int CompareTo(object obj)
                     {
                        return .....
                     }

        Esta interface retorna um numero inteiro de acordo com as comparaçoes.
        →Retornar um numero negativo quando a intância precede o "obj".
        →Retornar zero quando a instância e obj forem equivalentes;
        →Retornar posito diferente de zero quando a precedencia for de obj;
        Todos os return, é referente a Minha instancia, se eu quero que ela fique na frente ou atraz do objeto.

        Ou seja a logicade comparação fica a cargo do desenvolvedor, e de acordo com o que eu definir, eu retorno algum 
        dos falores expecificados a cima. (Negativo, Zero ou Positivo).

        Se temos a instância de ContaCorrente, e ela deve ficar na frente do objeto que recebemos por argumento,
        retornaremos um número negativo. Quando a instância é equivalente ao objeto, o retorno será 0. 
        E, quando o objeto possuir precedência maior que a instância, ou seja, quando o object ficar na frente 
        da instância, teremos retorno de um número positivo.

       __________________________________________________________
       | Valor de retorno |          Descrição                  | 
       | Menor que zero	  |   Esta instância é menor que value. | A minha instancia fica na frentedo objeto.
       | Zero	          |   Esta instância é igual a value.   |
       | Maior que zero	  |   Esta instância é maior que value. | O objeto fica na fente daminha instancia.
         
         */


    }
}
