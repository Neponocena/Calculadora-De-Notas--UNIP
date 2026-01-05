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
            float np1 = float.Parse(Console.ReadLine());
            
            
            Console.WriteLine();

            Console.Write("NOTA DA NP2:");
            float np2 = float.Parse(Console.ReadLine());
            

            Console.WriteLine("");

            Console.Write("NOTA DO PIM:");
            float pim = float.Parse(Console.ReadLine());
            

            float resultado = (np1 * 0.4f) + (np2 * 0.4f) + (pim * 0.2f);


            if(resultado >= 7)
            {
                
                Console.WriteLine($"Sua media é {resultado}, Você está Aprovado!");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine($"Sua média é {resultado}, Você está de Exame!");
                Console.ReadKey();
                return;

            }


        }   
    }
}