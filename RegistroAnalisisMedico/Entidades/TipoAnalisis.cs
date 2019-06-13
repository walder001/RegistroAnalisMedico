using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnalisisMedico.Entidades
{
    public class TipoAnalisis
    { 
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public TipoAnalisis()
        {
            TipoId = 0;
            Descripcion = string.Empty;
        }
        public TipoAnalisis(int tipoId, string descripcion)
        {
            TipoId = tipoId;
            Descripcion = descripcion;
        }
    }
}
