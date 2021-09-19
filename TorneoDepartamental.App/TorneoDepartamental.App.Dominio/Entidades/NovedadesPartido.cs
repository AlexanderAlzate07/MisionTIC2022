namespace TorneoDepartamental.App.Dominio
{
    public class NovedadesPartido
    {
        public int Id { get; set;}
        public Partido Partido { get; set;}
        public Equipo Equipo{ get; set;} //Para saber el jugador del equipo
        public string MinutoPartido { get; set;}
        public string Tarjeta { get; set;}
        public int Gol{ get; set;}

    }
}
