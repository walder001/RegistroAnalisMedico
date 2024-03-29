﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnalisisMedico.Entidades
{
    public class Analisis
    {


        [Key]
        public int AnalisisId { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }
        public virtual List<AnalisisDetalle> AnalisisDetalle { get; set; }
        public Analisis()
        {
            AnalisisId = 0;
            Fecha = DateTime.Now;
            UsuarioId = 0;
            AnalisisDetalle = new List<AnalisisDetalle>();
        }
       
        public void Agregar(int analisisId, int tipoId,string descripcion, string resulatdo)
        {
            this.AnalisisDetalle.Add(new AnalisisDetalle(analisisId, tipoId,descripcion, resulatdo));

        }
    }
}
