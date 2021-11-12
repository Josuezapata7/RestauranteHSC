using System;
using System.Collections;
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
    public partial class frmPuntoVenta : Form
    {
        ClaseControlador co = new ClaseControlador();

        public frmPuntoVenta()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowpnlProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            co.dibujarProductosControlador(flowpnlProductos,pnlDatos, pnlArribaIz,dgvDetallePedido, lbltotales);
            funLlenarComboControl();
        }

        private void txtIDPedidoEnc_TextChanged(object sender, EventArgs e)
        {
            llenarTabla();
        }

        public void llenarTabla()
        {
            DataTable dt = co.llenarTbl(txtIDPedidoEnc.Text,lbltotales);
            dgvDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallePedido.DataSource = dt;
        }

        public void funLlenarComboControl()
        {
            co.funLlenarComboControl(cbxActividad);
        }

        private void pnlAbajoIz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uI_ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDetallePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            //co.actualizarTotalControlador(lbltotales.Text,txtIDPedidoEnc.Text);
            co.totalActividad(cbxActividad.ValueMember.ToString(),lbltotales);
            MessageBox.Show("Cobro Agregado Correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            co.eliminarDet(dgvDetallePedido, txtIDPedidoEnc.Text);
        }
    }
}
