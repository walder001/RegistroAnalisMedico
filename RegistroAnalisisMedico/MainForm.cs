using RegistroAnalisisMedico.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAnalisisMedico
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAnalisis analisis = new rAnalisis();
            analisis.Show();
        }

        private void TipoAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTipoAnalisis r = new rTipoAnalisis();
            r.Show();
        }

        private void PaceintesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPacientes r = new rPacientes();
            r.Show();
        }
    }
}
