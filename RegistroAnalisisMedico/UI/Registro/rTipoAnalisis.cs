using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAnalisisMedico.Entidades;
using RegistroAnalisisMedico.BLL;

namespace RegistroAnalisisMedico.UI.Registro
{
    public partial class rTipoAnalisis : Form
    {
        public rTipoAnalisis()
        {
            InitializeComponent();
        }

       

        //Limpia
        //UsuarioId, Nombres, Email, NivelUsuario, Usuario, Clave, FechaIngreso
        private void Limpiar()
        {
            TipoId.Value = 0;
            Descripcion.Text = string.Empty;
   
        }

        //Eventos de los botones
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            ErrorProvider.Clear();
            int id;
            int.TryParse(TipoId.Text, out id);
            Limpiar();
            if (TipoAnalisisBLL.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                ErrorProvider.SetError(TipoId, "No se puede eliminar un usuario que no existe");

        }

        //UsuarioId, Nombres, Email, NivelUsuario, Usuario, Clave, FechaIngreso

        private TipoAnalisis LlenarClase()
        {
            TipoAnalisis us = new TipoAnalisis();
            us.TipoId = Convert.ToInt32(TipoId.Value);
            us.Descripcion = Descripcion.Text;
            
            return us;
        }
        private void LlenaCampo(TipoAnalisis tipoAnalisi)
        {
            TipoId.Value = tipoAnalisi.TipoId;
            Descripcion.Text = tipoAnalisi.Descripcion;
           
        }

        private bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();

            if (Descripcion.Text == string.Empty)
            {
                ErrorProvider.SetError(Descripcion, "El campo Nombre no puede estar vacio");
                Descripcion.Focus();
                paso = false;
            }
            return paso;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            TipoAnalisis tipo;
            bool paso = false;

            if (!Validar())
                return;

            tipo = LlenarClase();
            Limpiar();

            //Determinar si es guardar o modificar
            if (TipoId.Value == 0)
                paso = TipoAnalisisBLL.Guardar(tipo);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = TipoAnalisisBLL.Modificar(tipo);
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            TipoAnalisis tipo =TipoAnalisisBLL.Buscar((int)TipoId.Value);

            return (tipo != null);


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            TipoAnalisis tipo = new TipoAnalisis();
            int.TryParse(TipoId.Text, out id);

            Limpiar();

            tipo = TipoAnalisisBLL.Buscar(id);

            if (tipo != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(tipo);
            }
            else
            {
                MessageBox.Show("Persona no Encontada");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            TipoAnalisis tipo = new TipoAnalisis();
            TipoAnalisisBLL.Modificar(tipo);
        }
    }
}
