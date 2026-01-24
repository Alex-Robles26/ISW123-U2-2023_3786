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
        //  Evento
        public event Action<string> PizzaLista;

        //  Método async
        public async Task PrepararPizzaAsync(string tipo)
        {
            await Task.Delay(4300);
            PizzaLista?.Invoke($" Pizza {tipo} lista para delivery");
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Nombre: Manaury Roble");
            Console.WriteLine("Matrícula: 2023-3786");

            Cocina cocina = new Cocina();

            //Suscripción al evento
            cocina.PizzaLista += mensaje =>
            {
                Console.WriteLine(mensaje);
            };

            await cocina.PrepararPizzaAsync("Pepperoni");
        }
    }
}
