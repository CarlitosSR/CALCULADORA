namespace CALCULADORA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new();

            Console.WriteLine($"2 + 3 = {c.Sumar(2, 3)}");
            Console.WriteLine($"5 - 2 = {c.Restar(5, 2)}");
            Console.WriteLine($"4 * 3 = {c.Multiplicar(4, 3)}");
            Console.WriteLine($"6 / 3 = {c.Dividir(6, 3)}");

        }
        public class Calculadora
        {
            public double Sumar(double a, double b) => a + b;
            public double Restar(double a, double b) => a - b;
            public double Multiplicar(double a, double b) => a * b;
            public double Dividir(double a, double b) => a / b;
        }
    }
}
