using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double peso, altura, IMC;
            int i = 0;

            while(i<120) {
                Console.WriteLine("\nInforme o seu nome:");
                nome = Console.ReadLine();

                Console.WriteLine("\nInforme seu peso:");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nInforme sua altura");
                altura = Convert.ToDouble(Console.ReadLine());

                IMC = peso / (altura * altura);

                Console.WriteLine("\nSeu IMC é:" +IMC);

                if (IMC < 20)
                {
                    Console.WriteLine("\nABAIXO DO PESO IDEAL");
                } else if (IMC >= 20 && IMC <= 25)
                    {
                        Console.WriteLine("\nNO PESO IDEAL");
                    } else 
                        {
                            Console.WriteLine("\nACIMA DO PESO IDEAL");
                        }

                i++;
            }


        }
    }
}