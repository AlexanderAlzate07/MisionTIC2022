namespace TorneoDepartamental.App.Dominio
{
    public class DirectorTecnico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Documento { get; set; }
        public Equipo Equipo { get; set; }
    }
}