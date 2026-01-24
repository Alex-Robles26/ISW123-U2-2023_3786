using System;
using System.Threading.Tasks;

namespace ISW123_2023_3786
{
    public class PizzaNoDisponibleException_3786 : Exception
    {
        public PizzaNoDisponibleException_3786(string mensaje) : base(mensaje)
        {
        }
    }

    class Cocina
    {
        public event Action<string> PizzaLista;

        public async Task PrepararPizzaAsync(string tipo)
        {
            if (string.IsNullOrEmpty(tipo))
            {
                throw new PizzaNoDisponibleException_3786("La pizza solicitada no está disponible.");
            }

            await Task.Delay(4300);
            PizzaLista?.Invoke($" Pizza {tipo} lista para delivery");
        }
    }
    //hola
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Nombre: Manaury Roble");
            Console.WriteLine("Matrícula: 2023-3786");
            Console.WriteLine("---------------------------");

            Cocina cocina = new Cocina();

            cocina.PizzaLista += mensaje =>
            {
                Console.WriteLine(mensaje);
            };

            try
            {
                Task p1 = cocina.PrepararPizzaAsync("Pepperoni");
                Task p2 = cocina.PrepararPizzaAsync("Hawaiana");
                Task p3 = cocina.PrepararPizzaAsync("Suprema");

                await Task.WhenAll(p1, p2, p3);
            }
            catch (PizzaNoDisponibleException_3786 ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }

            Console.WriteLine("Todas las pizzas están listas.");
            Console.ReadKey();
        }
    }
}
