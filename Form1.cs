using LMP.Formularios;
using LMP.Informes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void equiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEquipos x = new frmEquipos();
            x.Show();
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJugadores x = new frmJugadores();
            x.Show();
        }

        private void estadiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadios x = new frmEstadios();
            x.Show();
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartidos x = new frmPartidos();
            x.Show();
        }

        private void estadísticasDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticasDeEquipos x = new frmEstadisticasDeEquipos();
            x.Show();
        }

        private void bateadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBateadores x = new frmBateadores();
            x.Show();
        }

        private void pitchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPitchers x = new frmPitchers();
            x.Show();
        }

        private void clasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClasificacion x = new frmClasificacion();
            x.Show();
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHorarios x = new frmHorarios();
            x.Show();
        }

        private void plataformasDeDistribuciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlataformasDeDistribucion x = new frmPlataformasDeDistribucion();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmREquipos x = new frmREquipos();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmREClasificacion x = new frmREClasificacion();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRE_EstadisticasEquipos x = new frmRE_EstadisticasEquipos();
            x.Show();
        }
    }
}
