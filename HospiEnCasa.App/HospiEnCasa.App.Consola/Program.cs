using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioMedico _repoMedico = new RepositorioMedico(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EntityFramework!");
            //AddPaciente();
            // BuscarPaciente(1);
            // AddMedico();
            AsignarMedico(1,2);
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente{
                Nombre = "Nicolay",
                Apellidos = "Perez",
                NumeroTelefono = "2037483726",
                Genero = Genero.Masculino,
                Direccion = "Calle 30D # 50a - 48",
                Longitud = 5.070F,
                Latitud = -75.521234F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990,04,12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombre+"\nApellidos: "+paciente.Apellidos);
        }

        private static void AsignarMedico(int idPaciente,int idMedico)
        {
            var medico = _repoPaciente.AsignarMedico(idPaciente,idMedico);
            if(medico != null)
                Console.WriteLine("Nombre medico asignado: "+medico.Nombre+"\nApellido medico: "+medico.Apellidos);
            else
                System.Console.WriteLine("No se encontró medico para asignar al paciente");
        }

        private static void AddMedico(){
            var medico = new Medico{
                Nombre = "Susana María",
                Apellidos = "Contreras",
                NumeroTelefono = "3002587364",
                Genero = Genero.Femenino,
                Especialidad = "Ginecologa",
                Codigo = "codigoMed12355",
                RegistroRethus = "regRethus12355"
            };
            _repoMedico.AddMedico(medico);
        }
    }
}
