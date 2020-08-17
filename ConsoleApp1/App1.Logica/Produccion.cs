namespace App1.Logica
{
    public class Produccion  : ICantidadProduccion
    {
        public Produccion() : base()
        {
        }
        public TipoMercaderia TipoMercaderia { get; set; }
        public string Material { get; set; }
        public float calcularCantidad;
        public Produccion(float calcularCantidad)
        {
            this.calcularCantidad= calcularCantidad;
        }
        public float calcularCantidadProduccion()
        {
            return calcularCantidad/100*300;
        }
    }
}