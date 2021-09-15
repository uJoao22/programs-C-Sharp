using System;

namespace Program_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, numero = 0, soma = 0, ctpar = 0;

            while (x < 50)
            {
                Console.Write("Digite um número inteiro:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero%3==0)
                {
                    Console.WriteLine("Este número é divisível por 3");
                }  
                else if (numero%2==0)
                {
                    ctpar++;
                    soma+=numero;
                    Console.WriteLine("Este número é divisível por 2");
                } 
                x++;
            }
            Console.ReadKey();
        }
    }
}