using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevSync
{
    internal class Program
    {

        static async Task<int> PassarCafe()  // Neste exemplo, o método PassarCafe é assíncrono e retorna um Task<int>, indicando que ele realizará uma operação assíncrona e, quando concluída, retornará um valor inteiro (a quantidade de café preparado). O método utiliza await para aguardar a conclusão da tarefa que simula o processo de preparação do café, permitindo que outras operações sejam executadas enquanto isso acontece.
        {
            int qtdCafe = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Preparando o café... {i}");
                    Thread.Sleep(1000);
                    qtdCafe++;
                }
                Console.WriteLine("O café está pronto!");
            });
            return qtdCafe;
        }

        
        static void TostarPao()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Preparando o pão... {i}");
                Thread.Sleep(1000);                
            }
            Console.WriteLine("O pão está pronto!");
        }

        static void Main(string[] args)
        {
            Task<int> tPassarCafe = PassarCafe();  // A chamada do método PassarCafe também precisa ser feita com o Task<tipo> para que possamos aguardar sua conclusão posteriormente. Isso permite que o programa continue executando outras tarefas, como tostar o pão, enquanto o café está sendo preparado. O método Main não é assíncrono, mas ao iniciar a tarefa de passar café, ele pode continuar com outras operações sem bloquear a execução.
            TostarPao();

            tPassarCafe.Wait();
            int qtdCafe = tPassarCafe.Result;

            Console.WriteLine($"O café da manhã está na mesa. Quantidade de cafés entregues no pedido: {qtdCafe}");
            Console.ReadKey();

        }
    }
}
