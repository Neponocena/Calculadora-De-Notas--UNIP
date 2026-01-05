using System;
namespace CalculadoraUnip
{
     public static class Operacao
    {
        public static void Resultado()
        {
            Console.Clear();

            Console.WriteLine(@"
█▀▀ ▄▀█ █░░ █▀▀ █░█ █░░ ▄▀█ █▀▄ █▀█ █▀█ ▄▀█   █▀▄ █▀▀   █▄░█ █▀█ ▀█▀ ▄▀█ █▀   ▄▄   █░█ █▄░█ █ █▀█
█▄▄ █▀█ █▄▄ █▄▄ █▄█ █▄▄ █▀█ █▄▀ █▄█ █▀▄ █▀█   █▄▀ ██▄   █░▀█ █▄█ ░█░ █▀█ ▄█   ░░   █▄█ █░▀█ █ █▀▀");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Console.Write("NOTA DA NP1:");
            float np1;
            if(!float.TryParse(Console.ReadLine(), out np1))
            {
                Console.WriteLine("Digite uma nota valída");
                Console.ReadKey();
                return;
            }
            if(np1 < 0 || np1 > 10)
            {
                Console.WriteLine("A nota deve estar entre 0 e 10");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine();

            Console.Write("NOTA DA NP2:");
            float np2;
            if(!float.TryParse(Console.ReadLine(), out np2))
            {
                Console.WriteLine("Digite uma nota válida");
                Console.ReadKey();
                return;
            }

            if(np2 < 0 || np1 > 10)
            {
                Console.WriteLine("A nota deve estar entre 0 e 10");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("");

            Console.Write("NOTA DO PIM:");
            float pim;
            if(!float.TryParse(Console.ReadLine(), out pim))
            {
                Console.WriteLine("Digite uma nota válida");
                Console.ReadKey();
                return;
            }
            
            if(pim < 0 || pim > 10)
            {
                Console.WriteLine("A nota deve estar entre 0 e 10");
                Console.ReadKey();
                return;
            }
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
                Console.Write("Digite a nota do exame:");
                int exame;
                if(!int.TryParse(Console.ReadLine(), out exame))
                {
                    Console.WriteLine("Digite uma nota valída");
                    Console.ReadKey();
                    return;
                }

                if(exame < 0 || exame > 10)
                {
                    Console.WriteLine("A nota deve estar entre 0 e 10");
                }

                if( resultado + exame >= 10)
                {
                    Console.WriteLine("Você esta aprovado!");
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