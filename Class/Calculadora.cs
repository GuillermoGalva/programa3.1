
namespace programa3._1.Class
{
 
        using System;

    class Calculadora
    {
        public static void Calcular(double numero1, double numero2)
        {
            if (numero1 > numero2)
            {
                double suma = numero1 + numero2;
                double diferencia = numero1 - numero2;
                Console.WriteLine("La suma de los números es: " + suma);
                Console.WriteLine("La diferencia de los números es: " + diferencia);
            }
            else
            {
                double producto = numero1 * numero2;
                double division = numero1 / numero2;
                Console.WriteLine("El producto de los números es: " + producto);
                Console.WriteLine("La división del primer número respecto al segundo es: " + division);
            }
        }
    }
}

