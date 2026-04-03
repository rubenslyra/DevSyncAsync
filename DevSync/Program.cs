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
               
        static void PassarCafe()
        {
            Task.Run(() =>
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
            PassarCafe();
            TostarPao();

            Console.WriteLine("O café da manhã está na mesa!");
            Console.ReadKey();

        }
    }
}
