﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnalisisMedico.Entidades
{
    public class AnalisisDetalle
    {

        [Key]
        public int AnalisisId { get; set; }
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public string Resultado { get; set; }
        public virtual List<TipoAnalisis> TipoAnalisis { get; set; }
      
        public AnalisisDetalle()
        {
            AnalisisId = 0;
            TipoId = 0;
            Descripcion = string.Empty;
            Resultado = string.Empty;

        }
        public AnalisisDetalle(int analisisId, int tipoId, string descripcion, string resultado)
        {
            AnalisisId = analisisId;
            TipoId = tipoId;
            Descripcion = descripcion;
            Resultado = resultado;
        }
    }
}
