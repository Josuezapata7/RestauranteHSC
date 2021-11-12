using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloHoteleria;

namespace CapaControladorHoteleria
{
    public class ClaseControlador
    {
        ClaseModelo mo = new ClaseModelo();
        public string idPedido;


        /*Funcion para agregar los salones - 9959-18-4829 Josue Zapata*/
        public void dibujandoSalonesControlador(FlowLayoutPanel flow, TextBox stringBuscar, Panel bienvenida, FlowLayoutPanel mesas)
        {
            mo.dibujandoSalones(flow,stringBuscar,bienvenida,mesas);
        }

        public void dibujarProductosControlador(FlowLayoutPanel flowProductos, Panel da,Panel fe,DataGridView data,Label total)
        {
            mo.dibujarProductos(flowProductos,da,fe,data,total);
        }

        public string mostrarBusqueda(string id)
        {
            string idEnc = mo.buscarEncabezado(id);

            return idEnc;
        }

        public DataTable llenarTbl(string id,Label lbl)
        {
            return mo.llenarTbl(id,lbl);
        }

        public void funLlenarComboControl(ComboBox cbx)
        {
            mo.funLlenarCombo(cbx);
        }

        public void actualizarTotalControlador(string total,string id)
        {
            mo.ActualizarTotal(total,id);
        }

        public void totalActividad(string id, Label lbltotal)
        {
            mo.obtenerTotalActividad(id, lbltotal);
        }

        public void eliminarDet(DataGridView data, string id)
        {
            mo.eliminarDet(data,id);
        }
    }
}
