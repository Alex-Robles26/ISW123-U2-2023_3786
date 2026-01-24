using System;

namespace ISW123_2023_3786
{
    // Excepción personalizada
    public class PizzaNoDisponibleException_3786 : Exception
    {
        public PizzaNoDisponibleException_3786(string mensaje) : base(mensaje)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: Manaury Roble");
            Console.WriteLine("Matrícula: 2023-3786");
            Console.ReadKey();
        }
    }
}
