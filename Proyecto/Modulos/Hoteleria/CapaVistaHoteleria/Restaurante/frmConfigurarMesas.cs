using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHoteleria;

namespace CapaVistaHoteleria.Restaurante
{
    public partial class frmConfigurarMesas : Form
    {
        ClaseControlador con = new ClaseControlador();

        public frmConfigurarMesas()
        {
            InitializeComponent();
        }

        private void frmConfigurarMesas_Load(object sender, EventArgs e)
        {
            pnlBienvenida.Dock = DockStyle.Fill;
            /*Llenado salones de la BD -  9959-18- 4829 Josue Zapata*/
            con.dibujandoSalonesControlador(pnlflowSalones, txtBuscarSalon,pnlBienvenida,pnlFlowMesas);
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {

        }

        private void pnlflowSalones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /*Llenado salones de la BD -  9959-18- 4829 Josue Zapata*/
            con.dibujandoSalonesControlador(pnlflowSalones, txtBuscarSalon, pnlBienvenida, pnlFlowMesas);
        }

        private void txtBuscarSalon_TextChanged(object sender, EventArgs e)
        {
            /*Llenado salones de la BD -  9959-18- 4829 Josue Zapata*/
            con.dibujandoSalonesControlador(pnlflowSalones, txtBuscarSalon, pnlBienvenida, pnlFlowMesas);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmPuntoVenta venta = new frmPuntoVenta();
            venta.Show();
        }
    }
}
