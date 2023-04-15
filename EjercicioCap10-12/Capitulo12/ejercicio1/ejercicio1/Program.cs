using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 0;
            int r = 0;
            // Pedimos el dato al usuario
            Console.WriteLine("Dame el valor del divisor");
            a = Convert.ToInt32(Console.ReadLine());

            // Hacemos la división
            try
            {
                r = b / a;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("No es posible dividir entre cero");
            }

            // Mostramos el resultado
            Console.WriteLine("El resultado es {0}", r);

            // Mostramos el resultado 5 veces
            for (int n = 0; n < 5; n++)
            {
                Console.WriteLine("El resultado es {0}", r);
            }

            // Invocamos la función
            MuestraValor(a);

            // Ejemplo de depuración paso a paso
            Console.WriteLine("Inicio del programa");

            int[] numeros = { 1, 2, 3 };
            int indice = 3;

            // Buscamos las excepciones de los arreglos en MSDN
            try
            {
                int numero = numeros[indice];
                Console.WriteLine(numero);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: El índice está fuera del rango del arreglo");
            }

            // Buscamos las excepciones de los streams en MSDN
            try
            {
                using (FileStream archivo = File.Open("archivo.txt", FileMode.Open))
                {
                    using (StreamReader lector = new StreamReader(archivo))
                    {
                        Console.WriteLine(lector.ReadLine());
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error: El archivo no se encontró");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: Problema de lectura del archivo");
            }

            // Buscamos las excepciones del método WriteLine() en MSDN
            try
            {
                int resultado = 10 / 2;
                Console.WriteLine("El resultado es {0}", resultado);
                resultado = 10 / 0;
                Console.WriteLine("El resultado es {0}", resultado);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: No es posible dividir entre cero");
            }

            Console.WriteLine("Fin del programa");
        }

        static void MuestraValor(int n)
        {
            Console.WriteLine("El resultado es {0}", n);
        }
    }
}