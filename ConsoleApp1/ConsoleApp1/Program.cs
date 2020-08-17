using System;
using App1.Logica;

namespace ConsoleApp1
{
    class Program
    {
        static readonly Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var persona = new Persona
            {
                Id = random.Next(),
                Nombre = "José",
                Apellido = "Mendoza",
                Cargo = "Contador",
                Empresa = new Empresa
                {
                    Nombre = "Marshilla",
                    Direccion = "José Tamayo &, Quito 170143",
                }
            };
            var producto = new Producto
            {
                Nombre = "Utencillos Basicos",
            };

            Console.WriteLine(persona.Saludar());
            Console.WriteLine(persona.Trasladar());
            Console.WriteLine(persona.Producir());

            Console.ReadKey();
        }
    }
}