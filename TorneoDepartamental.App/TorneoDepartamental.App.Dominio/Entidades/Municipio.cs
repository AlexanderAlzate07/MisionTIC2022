namespace TorneoDepartamental.App.Dominio
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Estadio Estadio { get; set; }

        public Equipo Equipo { get; set; }
    }
}