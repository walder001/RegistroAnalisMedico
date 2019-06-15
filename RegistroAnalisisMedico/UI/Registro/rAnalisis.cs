using RegistroAnalisisMedico.BLL;
using RegistroAnalisisMedico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAnalisisMedico.UI.Registro
{
    public partial class rAnalisis : Form
    {
        public List<AnalisisDetalle> AnalisisDetalles { get; set; }
        public rAnalisis()
        {
            InitializeComponent(); 
            this.AnalisisDetalles = new List<AnalisisDetalle>();
            CargarPacientes();
            CargarTipos();
        }


        private void RAnalisis_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            AnalisiIdnumericUpDown1.Value = 0;
            FechadateTimePicker1.Value = DateTime.Now;
             UsuarioscomboBox2.Text = string.Empty;
            TipoAnalisicomboBox1.Text = string.Empty;
            ResultadotextBox2.Text = string.Empty;
            this.AnalisisDetalles = new List<AnalisisDetalle>();
            CargarGrid();
            
        }


            public Analisis LLenaClase()
            {
                Analisis analisis = new Analisis();
                analisis.AnalisisId = (int)AnalisiIdnumericUpDown1.Value;
                analisis.Fecha = FechadateTimePicker1.Value;
            analisis.AnalisisDetalle = 
this.AnalisisDetalles;
            foreach (DataGridViewRow item in DetalledataGridView1.Rows)//Agregar cada linea del Grid al detalle
            {
                analisis.Agregar(
                    Convert.ToInt32(item.Cells["AnalisisId"].Value),
                    Convert.ToInt32(item.Cells["TipoId"].Value),
                    Convert.ToString(item.Cells["Descripcion"]),
                    Convert.ToString(item.Cells["Resultado"])
                );
            }


            return analisis;
            }

       

        public void LLenaCampo(Analisis analisis)
        {
            
            AnalisiIdnumericUpDown1.Value = (int)analisis.AnalisisId;
            FechadateTimePicker1.Value = analisis.Fecha;
            this.AnalisisDetalles = analisis.AnalisisDetalle;
            CargarGrid();

        }
        private void CargarGrid()
        {
            DetalledataGridView1.DataSource = null;
            DetalledataGridView1.DataSource = this.AnalisisDetalles;
        }
       
        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private bool Existe()
        {
            Analisis pro = AnalisisBLL.Buscar((int)AnalisiIdnumericUpDown1.Value);
            return (pro != null);
        }

        private bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();


            if (string.IsNullOrWhiteSpace(UsuarioscomboBox2.Text))
            {
                ErrorProvider.SetError(UsuarioscomboBox2, "El campo no puede estar vacio");
                UsuarioscomboBox2.Focus();
                paso = false;

            }
           
            return paso;

        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Analisis analisis = new Analisis() ;
            bool paso = false;
            if (!Validar())
                return;
            analisis = LLenaClase();
            Limpiar();

            if (AnalisiIdnumericUpDown1.Value == 0)
            {
                paso = AnalisisBLL.Guardar(analisis);

            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Desea modificar", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                paso = AnalisisBLL.Modificar(analisis);

            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void FechadateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView1.DataSource != null)
                this.AnalisisDetalles = (List<AnalisisDetalle>)DetalledataGridView1.DataSource;

            this.AnalisisDetalles.Add(new AnalisisDetalle(analisisId: (int)AnalisiIdnumericUpDown1.Value,
                tipoId: 0, descripcion: TipoAnalisicomboBox1.Text,
resultado: ResultadotextBox2.Text));
            CargarGrid();
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            if(DetalledataGridView1.Rows.Count > 0 && DetalledataGridView1.CurrentRow != null)
            {
                AnalisisDetalles.RemoveAt(DetalledataGridView1.CurrentRow.Index);
                CargarGrid();
            }


        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
                AnalisisBLL.Eliminiar(Convert.ToInt32(AnalisiIdnumericUpDown1.Value));
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Analisis analisis = new Analisis();
            int id;
            id = Convert.ToInt32(AnalisiIdnumericUpDown1.Value);
            Limpiar();
            analisis = AnalisisBLL.Buscar(id);
            if (analisis != null)
            {
                MessageBox.Show("Persona encontrada");
                LLenaCampo(analisis);
            }
            else
            {
                MessageBox.Show("Persona no enctrada");
            }
        }

       

        private void DetalledataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void TipoAnalisicomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarTipos();
        }

        private void CargarTipos()
        {
            try
            {
                List<TipoAnalisis> tipo = new List<TipoAnalisis>();
                tipo = TipoAnalisisBLL.GetList(p => true);
                TipoAnalisicomboBox1.DataSource = null;
                TipoAnalisicomboBox1.DataSource = tipo;
                TipoAnalisicomboBox1.ValueMember = "TipoId";
                TipoAnalisicomboBox1.DisplayMember = "Descripcion";
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar cargar los Tipo");
            }

        }
      

        private void UsuarioscomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPacientes();

        }

        private void CargarPacientes()
        {
            try
            {
                List<Pacientes> pacientes = new List<Pacientes>();
                pacientes = PacienteBLL.GetList(p => true);
                UsuarioscomboBox2.DataSource = null;
                UsuarioscomboBox2.DataSource = pacientes;
                UsuarioscomboBox2.ValueMember = "IdPaciente";
                UsuarioscomboBox2.DisplayMember = "Nombres";
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar cargar los Paciente");
            }

        }
    }
}
