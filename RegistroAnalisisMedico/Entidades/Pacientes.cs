using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnalisisMedico.Entidades
{
    public class Pacientes
    {
        [Key]
        public int IdPaciente { get; set; }
        public string Nombres { get; set; }
   
        public string  EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email  { get; set; }
        public DateTime Fecha { get; set; }
        public Pacientes()
        {
            IdPaciente = 0;
            Nombres = string.Empty;
            EstadoCivil = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Fecha = DateTime.Now;
        }
        public Pacientes(int idPaceinte, string nombre, string estadoCivil, string direccion, string telefono, string email, DateTime fecha)
        {
            IdPaciente = idPaceinte;
            Nombres = nombre;
            EstadoCivil = estadoCivil;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Fecha = fecha;
        }
    }
}
