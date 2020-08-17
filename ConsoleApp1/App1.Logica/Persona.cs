using System;

namespace App1.Logica
{
    public class Persona : GeneradorAutomaticoIdentificador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }

        private Empresa empresa;
        public Empresa Empresa
        {
            get { return empresa; }
            set
            {
                empresa = value;
                empresa.Contador = this;
            }
        }

        private Vehiculo vehiculo;
        public Vehiculo Vehiculo
        {
            get { return vehiculo; }
            set
            {
                vehiculo = value;
                vehiculo.Propietario = this;
            }
        }

        public string Saludar()
        {
            return $"Hola, mucho gusto mi nombre es {Nombre} {Apellido} es un gusto conocerte";
        }

        public bool Producir()
        {
            throw new NotImplementedException();
        }

        public string Trasladar()
        {
            return $"Me traslado en un {Vehiculo.Marca}, a la empresa {Empresa.Nombre}";
        }

    }
}