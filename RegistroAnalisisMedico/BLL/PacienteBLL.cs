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
    public class PacienteBLL
    {

        public static bool Guardar(Pacientes pacientes)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                if (db.Pacientes.Add(pacientes) != null)
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

        public static bool Modificar(Pacientes pacientes)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                //buscar las entidades que no estan para removerlas
                var Anterior = db.Pacientes.Find(pacientes.IdPaciente);

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
                var eliminar = db.Pacientes.Find(id);
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
        public static Pacientes Buscar(int id)
        {
            Contexto db = new Contexto();
            Pacientes pacientes = new Pacientes();
            try
            {
                pacientes = db.Pacientes.Find(id);
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
            return pacientes;
        }

        //Este es el metodo para listar o consultar lo que tenemos en la base de datos
        public static List<Pacientes> GetList(Expression<Func<Pacientes, bool>> pacientes)
        {
            List<Pacientes> Lista = new List<Pacientes>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Pacientes.Where(pacientes).ToList();
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
