using System;
namespace CalculadoraUnip
{
     public static class Operacao
    {
        public static void Resultado()
        {
            Console.Clear();

            Console.WriteLine("CALCULADORA DE NOTAS - UNIP");
            Console.WriteLine("------------------------------");

            Console.Write("NOTA DA NP1:");
            float np1;
            if(!float.TryParse(Console.ReadLine(), out np1))
            {
                Console.WriteLine("Digite uma nota valída");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine();

            Console.Write("NOTA DA NP2:");
            float np2;
            if(!float.TryParse(Console.ReadLine(), out np2))
            {
                Console.WriteLine("Digite uma nota valída");
                Console.ReadKey();
                return;
            }

            

            Console.WriteLine("");

            Console.Write("NOTA DO PIM:");
            float pim;
            if(!float.TryParse(Console.ReadLine(), out pim))
            {
                Console.WriteLine("Digite uma nota valída");
                Console.ReadKey();
                return;
            }
            

            float resultado = (np1 * 0.4f) + (np2 * 0.4f) + (pim * 0.2f);


            if(resultado >= 7)
            {
                
                Console.WriteLine($"Sua media é {resultado} , Você está Aprovado!");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine($"Sua média é {resultado} , Você está de Exame!");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("Digite a nota do exame");
                int exame;
                if(!int.TryParse(Console.ReadLine(), out exame))
                {
                    Console.WriteLine("Digite uma nota valída");
                    Console.ReadKey();
                    return;
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