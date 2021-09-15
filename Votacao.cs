using System;

namespace Program_02
{
    class Program
    {
        static void Main(string[] args)
	    {
            int chapa1 = 0, chapa2 = 0, votototal = 0, voto = 0;

            while (voto != 0)
            {
                Console.WriteLine("Informe o número da Matricula:");
                Console.WriteLine("\nInforme seu voto:");
                Console.WriteLine("Digite 1 para chapa SITUAÇÃO");
                Console.WriteLine("Digite 2 para chapa OPOSIÇÃO");
                Console.WriteLine("Digite 0 para sair");
                voto = Convert.ToChar(Console.ReadLine());

                if (voto == 1)
                {
                    chapa1++;
                } else if (voto == 2)
                {
                    chapa2++;
                }

            }

            votototal = chapa1 + chapa2;

            Console.WriteLine("\nA chapa 1(SITUAÇÃO) TEVE " + chapa1 + " votos.");
            Console.WriteLine("\nA chapa 2(OPOSIÇÃO) TEVE " + chapa2 + " votos.");
            Console.WriteLine("\nTiveram " + votototal + " votos no total.");

            if (chapa1 > chapa2)
            {
                Console.WriteLine("\nA chapa 1(SITUAÇÃO) venceu");
            } else
            {
                Console.WriteLine("\nA chapa 2(OPOSIÇÃO) venceu");
            }


		}
	}
}
