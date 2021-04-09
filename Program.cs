using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {



            double m, kg;
            double resul;

            Console.WriteLine();
            Console.WriteLine("--- IMC ---");
            Console.WriteLine("Cálculo do índice de massa corporal de uma pessoa.");
            Console.WriteLine();

            Console.WriteLine("Insira a Altura (em Metros, e com vírgula):");
            m = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Insira o Peso (kg):");
            kg = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine();

            resul = kg / Math.Pow(m,2);

            Console.Beep();
            Console.WriteLine("IMC:");
            Console.WriteLine($"{resul:N2} kg/m²");








        }
    }
}
