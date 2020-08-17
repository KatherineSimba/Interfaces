using System;
using System.Collections.Generic;

namespace App1.Logica
{
    public class Empresa : GeneradorAutomaticoIdentificador
    {
        public Empresa() : base()
        {
        }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Persona Contador { get; set; }

        public List<Producto> Productos { get; set; }

        public Producto NewProducto()
        {
            var newProducto = new Producto
            {
                Nombre = "Recipientes",
                Produccion = new Produccion
                {
                    TipoMercaderia = TipoMercaderia.Contenedores,
                    Material = "Almidón de Maíz"
                },
                Productividad = this
            };
            Productos.Add(newProducto);

            return newProducto;
        }

    }
}