using System;

namespace Program_04
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = "dd/MM/yyyy";
            double temp, tempalta = 0, tempbaixa = 9999, soma = 0, media = 0, dif = 0;
            int x=0;

            Console.WriteLine("=== METEOROLOGIA ===\n");

            while (data != "00/00/0000"){

                Console.WriteLine("\nDigite a data:");
                Console.WriteLine("Use o formato dd/MM/yyyy");
                Console.WriteLine("Use data 00/00/0000 para sair");
                data = Console.ReadLine();
            
                if (data != "00/00/0000") {
    
                    Console.WriteLine("\nInforme a temperatura registrada hoje:");
                    temp = Convert.ToDouble(Console.ReadLine());

                    if (temp > tempalta) { //Letra A
                        tempalta = temp;
                    }

                    if (temp < tempbaixa) {//Letra B
                        tempbaixa = temp; 
                    }

                    soma +=temp; //Letra C pt.1
                }

                x++;
            }

            media = soma / x;//Letra C pt.2

            dif = tempalta - tempbaixa;//Letra D

            Console.WriteLine("\n\nA temperatura mais alta registrada durante o estudo é: " +tempalta+ "°");
            Console.WriteLine("\nA temperatura mais baixa registrada durante o estudo é: " +tempbaixa+ "°");
            Console.WriteLine("\nA temperatura média no período do estudo foi de: " +media+ "°");
            Console.WriteLine("\nA diferença da maior para menor temperatura é de: " +dif+ "°");

            Console.ReadKey();
        }
    }
}