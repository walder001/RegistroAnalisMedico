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
    public partial class rPacientes : Form
    {
        public rPacientes()
        {
            InitializeComponent();
        }

       

        //Limpia
        //UsuarioId, Nombres, Email, NivelUsuario, Usuario, Clave, FechaIngreso
        private void Limpiar()
        {
            PacienteId.Value = 0;
            Nombres.Text = string.Empty;
            EstadoCivil.Text = string.Empty;
            Direccion.Text = string.Empty;
            Telefono.Text = string.Empty;
            Email.Text = string.Empty;
            FechaNacimiento.Value = DateTime.Now;
        }

        //Eventos de los botones
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            int id;
            int.TryParse(PacienteId.Text, out id);
            Limpiar();
            if (PacienteBLL.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                ErrorProvider.SetError(PacienteId, "No se puede eliminar un usuario que no existe");

        }

        //UsuarioId, Nombres, Email, NivelUsuario, Usuario, Clave, FechaIngreso

        private Pacientes LlenarClase()
        {
            Pacientes us = new Pacientes();
            us.IdPaciente = Convert.ToInt32(PacienteId.Value);
            us.Nombres = Nombres.Text;
            us.EstadoCivil = EstadoCivil.Text;
            us.Direccion = Direccion.Text;
            us.Telefono = Telefono.Text;
            us.Email = Email.Text;
            us.Fecha = FechaNacimiento.Value;
            return us;
        }
        private void LlenaCampo(Pacientes usuarios)
        {
            PacienteId.Value = usuarios.IdPaciente;
            Nombres.Text = usuarios.Nombres;
            EstadoCivil.Text = usuarios.Email;
            Telefono.Text = string.Empty;
            Email.Text = string.Empty;
            FechaNacimiento.Value = DateTime.Now;
        }

        private bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();

            if (Nombres.Text == string.Empty)
            {
                ErrorProvider.SetError(Nombres, "El campo Nombre no puede estar vacio");
                Nombres.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EstadoCivil.Text))
            {
                ErrorProvider.SetError(EstadoCivil, "El campo Direccion no puede estar vacio");
                EstadoCivil.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(Direccion.Text))
            {
                ErrorProvider.SetError(Direccion, "El campo Direccion no puede estar vacio");
                Direccion.Focus();
                paso = false;
            }


            if (string.IsNullOrWhiteSpace(Telefono.Text))
            {
                ErrorProvider.SetError(Telefono, "El campo Direccion no puede estar vacio");
                Telefono.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                ErrorProvider.SetError(Email, "El campo Direccion no puede estar vacio");
                Email.Focus();
                paso = false;
            }
            
            return paso;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Pacientes pacientes;
            bool paso = false;

            if (!Validar())
                return;

            pacientes = LlenarClase();
            Limpiar();

            //Determinar si es guardar o modificar
            if (PacienteId.Value == 0)
                paso = PacienteBLL.Guardar(pacientes);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PacienteBLL.Modificar(pacientes);
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Pacientes persona = PacienteBLL.Buscar((int)PacienteId.Value);

            return (persona != null);


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            Pacientes persona = new Pacientes();
            int.TryParse(PacienteId.Text, out id);

            Limpiar();

            persona = PacienteBLL.Buscar(id);

            if (persona != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(persona);
            }
            else
            {
                MessageBox.Show("Persona no Encontada");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Pacientes usuario = new Pacientes();
            PacienteBLL.Modificar(usuario);
        }
    }
}
