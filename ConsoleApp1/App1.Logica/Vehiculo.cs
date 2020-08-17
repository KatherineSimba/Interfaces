namespace App1.Logica
{
    public class Vehiculo : GeneradorAutomaticoIdentificador
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Consumo { get; set; }
        public Persona Propietario { get; set; }
        public Vehiculo() : base()
        {
        }
    }
}