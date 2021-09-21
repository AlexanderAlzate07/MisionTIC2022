namespace TorneoDepartamental.App.Dominio
{
    public class EstadisticaTorneo
    {
        public int Id { get; set; }
        public int CantidadPartidosJugados { get; set; }
        public int CantidadPartidosGanados { get; set; }
        public int CantidadPartidosEmpatados { get; set; }
        public int GolesAfavor { get; set; }
        public int GolesEnContra { get; set; }
        public int Puntos { get; set; }
        public Equipo Equipo { get; set; }
         
    }
}