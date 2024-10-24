using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         Subtracao();
        }
        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            
            float.TryParse(Console.ReadLine(), out float v1);   
            Console.Write("Segundo valor: ");
            float.TryParse(Console.ReadLine(), out float v2);   

            Console.WriteLine("");  

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da: {resultado}"); 
            Console.ReadKey();

        }
        static void Subtracao() 
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float.TryParse(Console.ReadLine(), out float v1);   
            
            Console.WriteLine("Segundo valor: ");
            float.TryParse(Console.ReadLine(), out float v2);

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
        }
    }
}

