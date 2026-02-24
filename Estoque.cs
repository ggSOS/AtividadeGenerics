using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeGenerics
{
    public class Estoque<T>
    {
        private List<T> list = new List<T>();

        // Adicionando elementos a uma lista generica, mas de mesmo tipo
        public void Adicionar(T item)
        {
            Console.WriteLine("> Elemento {0} adicionado com sucesso.", item);
            list.Add(item);
            return;
        }

        // Removendo um elemento de uma lista por meio de seu idice/id apos verificar se este e valido, printando o resultado
        public void RemoverPorID(int index)
        {
            if(index < 0 || index >= list.Count())
            {
                Console.WriteLine("> Indice {0} invalido.", index);
            }
            else
            {
                Console.WriteLine("> Elemento {0} de indice/id {1} removido com sucesso.", list[index], index); 
                list.RemoveAt(index);
            }
            return;
        }

        // Checando o elemento de uma lista que corresponde a um idice/id apos verificar se este e valido, printando o resultado
        public void BuscarPorID(int index)
        {
            if (index < 0 || index >= list.Count())
            {
                Console.WriteLine("> Indice {0} invalido.", index);
            }
            else
            {
                Console.WriteLine("> Elemento {0} encontrado no indice/id {1}.", list[index], index);
            }
            return;
        }

        // Printando todos os elementos de uma lista caso não esteja vazia
        public void ListarTodos()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("> Lista vazia.");
            }
            else
            {
                Console.WriteLine("> Elementos da Lista:");
                for (int index = 0; index < list.Count; index++)
                {
                    Console.WriteLine("\t- {0}", list[index]);
                }
            }
        }
    }
}
