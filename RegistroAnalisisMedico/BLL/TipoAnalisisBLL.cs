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
    public class TipoAnalisisBLL
    {
       

            public static bool Guardar(TipoAnalisis analisis)
            {
                bool paso = false;

                Contexto db = new Contexto();
                try
                {
                    if (db.TipoAnalisis.Add(analisis) != null)
                        paso = db.SaveChanges() > 0;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    db.Dispose();
                }

                return paso;
            }

            public static bool Modificar(TipoAnalisis analisis)
            {
                bool paso = false;
                Contexto db = new Contexto();

                try
                {
                    //buscar las entidades que no estan para removerlas
                    var Anterior = db.TipoAnalisis.Find(analisis.TipoId);

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    db.Dispose();
                }
                return paso;
            }

            //Este es el metodo para eliminar en la base de datos
            public static bool Eliminar(int id)
            {
                bool paso = false;
                Contexto db = new Contexto();
                try
                {
                    var eliminar = db.TipoAnalisis.Find(id);
                    db.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                    paso = (db.SaveChanges() > 0);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    db.Dispose();
                }

                return paso;
            }

            //Este es el metodo para buscar en la base de datos
            public static TipoAnalisis Buscar(int id)
            {
                Contexto db = new Contexto();
                TipoAnalisis analisis = new TipoAnalisis();
                try
                {
                    analisis = db.TipoAnalisis.Find(id);
                    // El Count() lo que hace es engañar al lazyloading y obligarlo a cargar los detalles 


                    //persona = db.Personas
                    //     .Include(x => x.Telefonos.Select(c => c.PersonaId))
                    //             .Where(p => p.PersonaId == id)
                    //             .FirstOrDefault();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    db.Dispose();
                }
                return analisis;
            }

            //Este es el metodo para listar o consultar lo que tenemos en la base de datos
            public static List<TipoAnalisis> GetList(Expression<Func<TipoAnalisis, bool>> tipoAnalisi)
            {
                List<TipoAnalisis> Lista = new List<TipoAnalisis>();
                Contexto db = new Contexto();
                try
                {
                    Lista = db.TipoAnalisis.Where(tipoAnalisi).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    db.Dispose();
                }
                return Lista;
            }
        
    }
}
