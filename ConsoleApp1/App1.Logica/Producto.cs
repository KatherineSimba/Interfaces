namespace App1.Logica
{
    public class Producto : GeneradorAutomaticoIdentificador
    {
        public Producto() : base()
        {
        }
        public string Nombre { get; set; }
        public Produccion Produccion { get; set; }
        public Empresa Productividad { get; set; }

        public string Producir()
        {
            return $"La empresa produce mercadería de {Produccion} con {Produccion.Material} biodegradables.";
        }
    }
}