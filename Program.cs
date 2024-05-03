using programa3._1.Class;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Calculadora.Calcular(numero1, numero2);

        Console.ReadLine();
    }
}