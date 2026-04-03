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

        static async Task PassarCafe() // Se é void, posso usar o Task. Se tivesse que retornar algo, usaria Task<TipoDoRetorno>. Mas nesse caso, como não tem retorno, é só Task mesmo.
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Preparando o café... {i}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("O café está pronto!");
            });
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
            Task tPassarCafe = PassarCafe();
            TostarPao();

            tPassarCafe.Wait(); // Espera a tarefa de passar o café terminar

            Console.WriteLine("O café da manhã está na mesa!");
            Console.ReadKey();

        }
    }
}
