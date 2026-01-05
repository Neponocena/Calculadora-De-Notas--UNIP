using System;
namespace CalculadoraUnip
{
     public static class Operacao
    {
        private static float LerNota(string descricao)
        {
            Console.Write("descrição");
            float nota;

            if(!float.TryParse(Console.ReadLine(), out nota))
            {
                Console.WriteLine("Digite uma nota válida");
                Console.ReadKey();
                Environment.Exit(0);

            }

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("A nota deve estar entre 0 e 10");
                Console.ReadKey();
                Environment.Exit(0);
            }

            return nota;
        }
        public static void Resultado()
        {
            Console.Clear();

            Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   █▀▄ █▀▀   █▄░█ █▀█ ▀█▀ ▄▀█ █▀   ▄▄   █░█ █▄░█ █ █▀█
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   █▄▀ ██▄   █░▀█ █▄█ ░█░ █▀█ ▄█   ░░   █▄█ █░▀█ █ █▀▀");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            float np1 = LerNota("NOTA DA NP1:");

            Console.WriteLine();

            float np2 = LerNota("NOTA DA NP2:");

            Console.WriteLine("");

            float pim = LerNota ("NOTA DO PIM:");

            Console.WriteLine("");

            float resultado = (np1 * 0.4f) + (np2 * 0.4f) + (pim * 0.2f);


            if(resultado >= 7)
            {
                
                Console.WriteLine($"Sua média é {resultado} , Você está Aprovado!");
                Console.ReadKey();
                return;
            }
            
            else
            {
                Console.WriteLine($"Sua média é {resultado} , Você está de Exame!");
                Console.ReadKey();
                Console.WriteLine("");
                float exame = LerNota("Digite a nota do exame:");

                if( resultado + exame >= 10)
                {
                    Console.WriteLine("Você está aprovado!");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Você está de DP!");
                    Console.ReadKey();
                    return;
                }
                
            }


        }   
    }
}