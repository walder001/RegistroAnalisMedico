using RegistroAnalisisMedico.DAL;
using RegistroAnalisisMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnalisisMedico.BLL
{
    public class AnalisisBLL
    {
        /// <summary>
        /// Metodo para guardar en la en la base de datos
        /// </summary>
        /// <param name="analisis"></param>
        /// <returns></returns>
        public static bool Guardar(Analisis analisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Analisis.Add(analisis) != null)
                {
                    paso = contexto.SaveChanges() >0;
                }

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();

            }
            return paso;

        }
        /// <summary>
        /// Metodo para midificar en la base de datos
        /// </summary>
        /// <param name="analisis"></param>
        /// <returns></returns>
        public static bool Modificar(Analisis analisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var buscar = contexto.Analisis.Find(analisis.AnalisisId);
                foreach(var item in buscar.AnalisisDetalle){
                    if(!analisis.AnalisisDetalle.Exists (d => d.AnalisisId == item.AnalisisId))
                    {
                        contexto.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    }

                }
                contexto.Entry(analisis).State = System.Data.Entity.EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch(Exception)
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        public static bool Eliminiar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Analisis buscar = contexto.Analisis.Find(id);
                contexto.Analisis.Remove(buscar);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;

            }

            return paso;

        }

        public static Analisis Buscar(int id)
        {
            Analisis analisis = new Analisis();
            Contexto contexto = new Contexto();
            try
            {
                analisis = contexto.Analisis.Find(id);
                analisis.AnalisisDetalle.Count();
                

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return analisis;

        }

        public static List<Analisis> Getlist(Expression<Func<Analisis, bool>> expression)
        {
            List<Analisis> analisis = new List<Analisis>();
            Contexto contexto = new Contexto();
            try
            {
                analisis = contexto.Analisis.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;


            }
            finally
            {
                contexto.Dispose();
            }
            return analisis;
        }

    }

}
