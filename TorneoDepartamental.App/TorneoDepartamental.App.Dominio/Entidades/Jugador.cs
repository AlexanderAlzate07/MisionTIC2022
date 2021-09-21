namespace TorneoDepartamental.App.Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroCamiseta {get; set;}
        public string Posicion {get; set;}
        public Equipo Equipo { get; set; }
    }
}