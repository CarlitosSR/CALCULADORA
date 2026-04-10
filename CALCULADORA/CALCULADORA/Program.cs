using System;

namespace CalculadoraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ CALCULADORA ===");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine() ?? string.Empty;

                if (opcion == "5")
                {
                    salir = true;
                    Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
                    break;
                }

                Console.Write("Ingrese el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Entrada inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Ingrese el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Entrada inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    double resultado = opcion switch
                    {
                        "1" => calculadora.Sumar(a, b),
                        "2" => calculadora.Restar(a, b),
                        "3" => calculadora.Multiplicar(a, b),
                        "4" => calculadora.Dividir(a, b),
                        _ => throw new InvalidOperationException("Opción no válida")
                    };

                    Console.WriteLine($"Resultado: {resultado}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    public class Calculadora
    {
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;
        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return a / b;
        }
    }
}