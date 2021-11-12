using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVistaReporte;
using CapaVista;

namespace CapaVistaHoteleria
{
    public partial class frmMDIHoteleria : Form
    {
        public frmMDIHoteleria()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void frmMDIHoteleria_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            { 
                this.Close(); 
            }
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad seguridad = new frmMIDSeguridad();
            seguridad.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteadorAdmin repo = new ReporteadorAdmin();
            repo.Show();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas consultas = new menuconsultas();
            consultas.Show();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void restauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restaurante.frmConfigurarMesas mesa = new Restaurante.frmConfigurarMesas();
            mesa.Show();
        }
    }
}
