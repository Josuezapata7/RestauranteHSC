using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloHoteleria
{
    public class ClaseModelo
    {
        public string idSalon = "";
        public string estadoSalon = "";

        Panel pnlBienvenida;
        FlowLayoutPanel pnlMesas;
        FlowLayoutPanel salon;
        FlowLayoutPanel productos;
        Panel datos;
        Panel pnlfecha;
        DataGridView table;
        Label totales;

        public string idMesa = "";
        public string nombreMesa = "";
        public string codigoProducto = "";

        /*Funcion para llenar salones de la BD - 9959-18-4829 Josue Zapata*/
        public void dibujandoSalones(FlowLayoutPanel flow, TextBox stringBuscar, Panel bienvenida, FlowLayoutPanel mesas)
        {
            flow.Controls.Clear();
            Conexion con = new Conexion();
            OdbcDataReader leer = null;

            pnlBienvenida = bienvenida;
            pnlMesas = mesas;
            salon = flow;

            string sql = "SELECT * FROM Salon WHERE nombre LIKE '%" + stringBuscar.Text + "%'" + " " + "AND" + " " + "estatus" + "= 'A' ";
            OdbcConnection conect = con.conexion();
            //sql = "SELECT * FROM cliente WHERE idCliente LIKE '%" + dato + "%'";

            try
            {

                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Button b = new Button();
                    Panel pb = new Panel();

                    b.Name = leer.GetString(0);
                    b.Text = leer.GetString(1);
                    b.Dock = DockStyle.Fill;
                    b.BackColor = Color.Transparent;
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 190, 160);
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 226, 210);
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Tag = leer.GetString(3);

                    pb.Size = new System.Drawing.Size(364, 64);
                    pb.Name = leer.GetString(0);

                    pb.Controls.Add(b);
                    flow.Controls.Add(pb);

                    b.Click += new EventHandler(colorSeleccionadoBotonEvento);


                }

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                con.desconexion(conect);
            }
        }

        /*Funcion para agregar un hover a mis botones y tambien background estatico - 9959-18-4829 Josue Zapata*/
        private void colorSeleccionadoBotonEvento(System.Object sender, EventArgs e)
        {
            idSalon = ((Button)sender).Name;
            estadoSalon = Convert.ToString(((Button)sender).Tag);
            pnlBienvenida.Visible = false;
            pnlBienvenida.Dock = DockStyle.None;
            pnlMesas.Visible = true;
            pnlMesas.Dock = DockStyle.Fill;

            dibujarMesas(pnlMesas);

            string nombre = ((Button)sender).Name;

            foreach (Panel panel in salon.Controls)
            {
                if (panel is Panel)
                {
                    foreach (Button btn in panel.Controls)
                    {
                        if (btn is Button)
                        {
                            btn.BackColor = Color.Transparent;
                            break;
                        }
                    }
                }
            }

            foreach (Panel panel in salon.Controls)
            {
                if (panel is Panel)
                {
                    foreach (Button btn in panel.Controls)
                    {
                        if (btn is Button)
                        {
                            if (btn.Name == nombre)
                            {
                                btn.BackColor = Color.FromArgb(202, 190, 160);
                                break;
                            }
                        }
                    }
                }
            }


        }

        /*public string obtenerCantidadMesas(string idSalon)
        {
            Conexion con = new Conexion();
            OdbcDataReader leer = null;
            string cantidadMesas = "";

            string sql = "SELECT count(*) FROM mesa WHERE estado" + "= 'A'" + "AND idSalon= '"+idSalon+"'";
            OdbcConnection conect = con.conexion();

            try
            {

                //MySqlCommand buscarColumna = new MySqlCommand(sqlQ, conexionBD);
                OdbcCommand buscar = new OdbcCommand(sql, conect);
                cantidadMesas = buscar.ExecuteScalar().ToString();

               
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.Message);
            }
            finally
            {
                con.desconexion(conect);
            }

            return cantidadMesas;
        }*/

        public void dibujarMesas(FlowLayoutPanel pnlMesas)
        {
            pnlMesas.Controls.Clear();


            Conexion con = new Conexion();
            OdbcDataReader leer = null;
            string sql = "SELECT * FROM mesa WHERE idSalon=" + idSalon;
            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {

                    Button b = new Button();
                    Panel panel = new Panel();
                    Point tamanio = new Point(92, 77);
                    panel.BackgroundImage = Properties.Resources.mesa_vacia;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    panel.Cursor = Cursors.Hand;
                    panel.Tag = leer.GetString(0);
                    panel.Size = new System.Drawing.Size(tamanio);

                    b.Text = leer.GetString(1);
                    b.Name = leer.GetString(0);
                    b.Cursor = Cursors.Hand;

                    if (leer.GetString(5) == "O")
                    {

                        b.Size = new System.Drawing.Size(tamanio);
                        b.BackColor = Color.FromArgb(200, 79, 60);
                        b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9);
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderSize = 0;
                        b.ForeColor = Color.White;
                        pnlMesas.Controls.Add(b);
                    }
                    else
                    {
                        pnlMesas.Controls.Add(panel);
                    }

                    b.Click += new EventHandler(enventoBotonMesa);
                    panel.Click += new EventHandler(eventoPanelMesa);

                }


            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.Message);
            }
            finally
            {
                con.desconexion(conect);
            }
        }

        /*Obtener nombre mesa y id mesa*/
        private void enventoBotonMesa(System.Object sender, EventArgs e)
        {
            nombreMesa = ((Button)sender).Text;
            idMesa = ((Button)sender).Name;
        }

        private void eventoPanelMesa(System.Object sender, EventArgs e)
        {
            idMesa = Convert.ToString(((Panel)sender).Tag);
        }

        /*Funcion para poder dibujar cada producto en programa que tenga stock y este activo en estado bodega y producto*/
        public void dibujarProductos(FlowLayoutPanel flowProductos, Panel da, Panel fe, DataGridView tabla, Label total)
        {
            Conexion con = new Conexion();
            productos = flowProductos;
            datos = da;
            pnlfecha = fe;
            table = tabla;
            totales = total;

            OdbcDataReader leer = null;
            string sql = "Select * from recetaencabezado WHERE estado='A'";

            OdbcConnection conect = con.conexion();

            flowProductos.Controls.Clear();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Label lbl = new Label();
                    Panel pnl = new Panel();

                    lbl.Text = leer.GetString(1);
                    lbl.Name = leer.GetString(0);
                    lbl.Size = new System.Drawing.Size(119, 25);
                    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.White;
                    lbl.Dock = DockStyle.Fill;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Cursor = Cursors.Hand;

                    pnl.Size = new System.Drawing.Size(90, 75);
                    pnl.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    pnl.BackColor = Color.FromArgb(168, 191, 161);
                    pnl.Name = leer.GetString(0);


                    pnl.Controls.Add(lbl);
                    flowProductos.Controls.Add(pnl);
                    lbl.Click += new EventHandler(seleccionarLabelProducto);
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                con.desconexion(conect);
            }
        }

        /*Evento que me sirve para seleccionar y deseleccionar un producto*/
        private void seleccionarLabelProducto(System.Object sender, EventArgs e)
        {
            string idEncabezado = "";
            string idActivi = "";
            string fecha = "";

            try
            {
                codigoProducto = ((Label)sender).Name;
                seleccionarDeseleccionarProducto();

                foreach (System.Windows.Forms.Control txt in datos.Controls)
                {
                    if (txt is System.Windows.Forms.TextBox)
                    {
                        if (txt.Name == "txtIDPedidoEnc")
                        {

                            idEncabezado = txt.Text;

                        }

                    }
                    else if (txt is System.Windows.Forms.ComboBox)
                    {
                        if (txt.Name == "cbxActividad")
                        {
                            idActivi = ((ComboBox)txt).ValueMember;
                        }
                    }


                }

                foreach (System.Windows.Forms.Control date in pnlfecha.Controls)
                {
                    if (date is System.Windows.Forms.DateTimePicker)
                    {
                        if (date.Name == "dtpFecha")
                        {
                            fecha = ((DateTimePicker)date).Value.ToString("yyyy-MM-dd");
                        }
                    }


                }

                string encontrado = buscarEncabezado(idEncabezado);
                string subtotal = "";
                string sumaSubs = "";

                if (string.IsNullOrEmpty(encontrado))
                {
                    if (string.IsNullOrEmpty(idEncabezado) || string.IsNullOrEmpty(idActivi))
                    {
                        MessageBox.Show("Ingrese los datos correctamente");
                    }
                    else
                    {
                        insertarPedidoEnc(idEncabezado, idActivi, fecha);
                        subtotal = buscarSubtotalDet(codigoProducto);
                        insertarPedidoDet(idEncabezado, idActivi, codigoProducto, subtotal);
                        llenadoTablaRecetas(idEncabezado, totales);
                        sumaSubs = ObtenerSumaSubtotales(idEncabezado);
                        totales.Text = sumaSubs;

                    }

                }
                else
                {
                    subtotal = buscarSubtotalDet(codigoProducto);
                    insertarPedidoDet(idEncabezado, idActivi, codigoProducto, subtotal);
                    llenadoTablaRecetas(idEncabezado, totales);
                    sumaSubs = ObtenerSumaSubtotales(idEncabezado);
                    totales.Text = sumaSubs;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        public void seleccionarDeseleccionarProducto()
        {
            try
            {
                foreach (System.Windows.Forms.Control pnl in productos.Controls)
                {
                    if (pnl is System.Windows.Forms.Panel)
                    {
                        foreach (var pnlBtn in pnl.Controls)
                        {
                            pnl.BackColor = Color.FromArgb(168, 191, 161);
                            break;
                        }
                    }
                }

                foreach (System.Windows.Forms.Control pnlfuera in productos.Controls)
                {
                    if (pnlfuera is System.Windows.Forms.Panel)
                    {
                        if (pnlfuera.Name == codigoProducto)
                        {
                            pnlfuera.BackColor = Color.FromArgb(159, 212, 143);
                        }

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /*Forma para llenar tabla*/
        public DataTable llenarTbl(string id, Label lbl)
        {
            Conexion cn = new Conexion();
            string sumaSubs = "";

            string sql = "SELECT idPedidoE,idOrdenPedido,recetaencabezado.precio,actividadreservacion.nombre as nombreActividad,recetaencabezado.nombre as nombreReceta FROM pedidodetallehoteleria" +
            " " + "inner join actividadreservacion on pedidodetallehoteleria.idActividad = actividadreservacion.idActividad" +
            " " + "inner join recetaencabezado on  pedidodetallehoteleria.idRecetaE = recetaencabezado.idRecetaE" +
            " " + "Group by actividadreservacion.nombre,recetaencabezado.nombre,recetaencabezado.precio,idOrdenPedido" +
            " " + "Having idPedidoE LIKE '%" + id + "%'" + " " + "order by idOrdenPedido ASC";

            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);

            sumaSubs = ObtenerSumaSubtotales(id);
            lbl.Text = sumaSubs;

            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }

        public void llenadoTablaRecetas(string idPedido, Label lbl)
        {
            DataTable dt = llenarTbl(idPedido, lbl);
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.DataSource = dt;
        }

        public string buscarEncabezado(string id)
        {
            Conexion con = new Conexion();
            string idEncontrado = "";
            OdbcDataReader leer = null;

            string sql = "SELECT * FROM pedidoencabezadohoteleria WHERE idPedidoE='" + id + "'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    if (leer == null)
                    {
                        idEncontrado = "";
                    }
                    else
                    {
                        idEncontrado = leer.GetString(0);
                    }
                }

            }
            catch (Exception)
            {


            }


            return idEncontrado;
        }

        public void funLlenarCombo(ComboBox cbx)
        {
            Conexion con = new Conexion();
            OdbcDataReader leer = null;

            string psql = "SELECT * FROM actividadreservacion WHERE estatus='A'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cbx.Items.Add(leer.GetString(1));
                    cbx.ValueMember = leer.GetString(0);
                }

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                con.desconexion(conect);
            }
        }


        public void insertarPedidoEnc(string idPedido, string idAC, string time)
        {
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string sql = "INSERT INTO pedidoencabezadohoteleria (idPedidoE, idActividad, fecha,total) " +
            " VALUES ('" + idPedido + "', '" + idAC + "', '" + time + "', 0 )";

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conn);
                insertar.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
        }

        public void insertarPedidoDet(string idPedidoDet, string idActividadDet, string idRecetaDet, string subtotalDet)
        {
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string sql = "INSERT INTO pedidodetallehoteleria (idPedidoE,idOrdenPedido,idActividad,idRecetaE,subtotal,cantidad) " +
            " VALUES ('" + idPedidoDet + "', '0', '" + idActividadDet + "', '" + idRecetaDet + "', '" + subtotalDet + "',1 )";

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conn);
                insertar.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("el error es : " + ex);

            }
        }

        public string buscarSubtotalDet(string idReceta)
        {
            Conexion con = new Conexion();
            string idEncontrado = "";
            OdbcDataReader leer = null;

            string sql = "SELECT precio FROM recetaencabezado WHERE idRecetaE='" + idReceta + "'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    if (leer == null)
                    {
                        idEncontrado = "";
                    }
                    else
                    {
                        idEncontrado = leer.GetString(0);
                    }
                }

            }
            catch (Exception)
            {


            }


            return idEncontrado;
        }


        public string ObtenerSumaSubtotales(string id)
        {
            Conexion con = new Conexion();
            string sumaSubs = "";
            OdbcDataReader leer = null;

            string sql = "select sum(subtotal) as total from pedidodetallehoteleria WHERE idPedidoE='" + id + "'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    if (leer == null)
                    {
                        sumaSubs = "";
                    }
                    else
                    {
                        sumaSubs = leer.GetString(0);
                    }
                }

            }
            catch (Exception)
            {


            }


            return sumaSubs;
        }

        public void ActualizarTotal(string total, string id)
        {
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string sql = "update pedidoencabezadohoteleria set total=" + total + " " + "WHERE idPedidoE=" + id;

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conn);
                insertar.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al actualizar " + ex);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }

        public void obtenerTotalActividad(string id, Label lbltotal)
        {
            Conexion con = new Conexion();
            string totalActividad = "";
            float totalfloat = 0;
            OdbcDataReader leer = null;

            string sql = "select costoActividad from actividadreservacion WHERE idActividad='" + id + "'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    if (leer == null)
                    {
                        totalActividad = "";
                    }
                    else
                    {
                        totalActividad = leer.GetString(0);
                        totalfloat = float.Parse(totalActividad) + float.Parse(lbltotal.Text);
                    }
                }

            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al actualizar " + ex);
            }
            finally
            {
                con.desconexion(conect);
            }

            ActualizarActividad(totalfloat, id);

        }

        public void ActualizarActividad(float totalAc, string id)
        {
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string sql = "update actividadreservacion set costoActividad=" + totalAc + " " + "WHERE idActividad=" + id;

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conn);
                insertar.ExecuteNonQuery();


            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al actualizar " + ex);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }

        public void eliminarDet(DataGridView data, string id)
        {
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();

            string valor = data.Rows[data.CurrentRow.Index].Cells[1].Value.ToString();

            String sql = "delete from pedidodetallehoteleria WHERE idOrdenPedido='" + valor + "'";

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conn);
                insertar.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al actualizar " + ex);
            }
            finally
            {
                cn.desconexion(conn);
            }

            llenadoTablaRecetas(id, totales);
        }
    }

}
