
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoCliente));
            this.labelcorreocliente = new System.Windows.Forms.Label();
            this.labeldireccioncliente = new System.Windows.Forms.Label();
            this.labeltelefonocliente = new System.Windows.Forms.Label();
            this.labelnitcliente = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.rbnInactivo = new System.Windows.Forms.RadioButton();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.labelestadocliente = new System.Windows.Forms.Label();
            this.labelapellidocliente = new System.Windows.Forms.Label();
            this.labelnombrecliente = new System.Windows.Forms.Label();
            this.labelidcliente = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcorreocliente
            // 
            this.labelcorreocliente.AutoSize = true;
            this.labelcorreocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelcorreocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcorreocliente.Location = new System.Drawing.Point(25, 373);
            this.labelcorreocliente.Name = "labelcorreocliente";
            this.labelcorreocliente.Size = new System.Drawing.Size(61, 20);
            this.labelcorreocliente.TabIndex = 60;
            this.labelcorreocliente.Text = "Correo:";
            // 
            // labeldireccioncliente
            // 
            this.labeldireccioncliente.AutoSize = true;
            this.labeldireccioncliente.BackColor = System.Drawing.Color.Transparent;
            this.labeldireccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccioncliente.Location = new System.Drawing.Point(25, 334);
            this.labeldireccioncliente.Name = "labeldireccioncliente";
            this.labeldireccioncliente.Size = new System.Drawing.Size(79, 20);
            this.labeldireccioncliente.TabIndex = 58;
            this.labeldireccioncliente.Text = "Dirección:";
            // 
            // labeltelefonocliente
            // 
            this.labeltelefonocliente.AutoSize = true;
            this.labeltelefonocliente.BackColor = System.Drawing.Color.Transparent;
            this.labeltelefonocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefonocliente.Location = new System.Drawing.Point(25, 300);
            this.labeltelefonocliente.Name = "labeltelefonocliente";
            this.labeltelefonocliente.Size = new System.Drawing.Size(75, 20);
            this.labeltelefonocliente.TabIndex = 56;
            this.labeltelefonocliente.Text = "Teléfono:";
            // 
            // labelnitcliente
            // 
            this.labelnitcliente.AutoSize = true;
            this.labelnitcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelnitcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnitcliente.Location = new System.Drawing.Point(26, 258);
            this.labelnitcliente.Name = "labelnitcliente";
            this.labelnitcliente.Size = new System.Drawing.Size(38, 20);
            this.labelnitcliente.TabIndex = 54;
            this.labelnitcliente.Text = "NIT:";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.BackColor = System.Drawing.Color.Transparent;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(365, 112);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(156, 20);
            this.labelClientes.TabIndex = 53;
            this.labelClientes.Text = "Clientes Registrados";
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(369, 135);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(794, 381);
            this.dtgClientes.TabIndex = 52;
            // 
            // rbnInactivo
            // 
            this.rbnInactivo.AutoSize = true;
            this.rbnInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInactivo.Location = new System.Drawing.Point(155, 441);
            this.rbnInactivo.Name = "rbnInactivo";
            this.rbnInactivo.Size = new System.Drawing.Size(109, 24);
            this.rbnInactivo.TabIndex = 51;
            this.rbnInactivo.TabStop = true;
            this.rbnInactivo.Text = "Inhabilitado";
            this.rbnInactivo.UseVisualStyleBackColor = false;
            this.rbnInactivo.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // rbnActivo
            // 
            this.rbnActivo.AutoSize = true;
            this.rbnActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnActivo.Location = new System.Drawing.Point(51, 440);
            this.rbnActivo.Name = "rbnActivo";
            this.rbnActivo.Size = new System.Drawing.Size(98, 24);
            this.rbnActivo.TabIndex = 50;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "Habilitado";
            this.rbnActivo.UseVisualStyleBackColor = false;
            this.rbnActivo.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // labelestadocliente
            // 
            this.labelestadocliente.AutoSize = true;
            this.labelestadocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelestadocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadocliente.Location = new System.Drawing.Point(31, 411);
            this.labelestadocliente.Name = "labelestadocliente";
            this.labelestadocliente.Size = new System.Drawing.Size(64, 20);
            this.labelestadocliente.TabIndex = 42;
            this.labelestadocliente.Text = "Estado:";
            // 
            // labelapellidocliente
            // 
            this.labelapellidocliente.AutoSize = true;
            this.labelapellidocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelapellidocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellidocliente.Location = new System.Drawing.Point(25, 221);
            this.labelapellidocliente.Name = "labelapellidocliente";
            this.labelapellidocliente.Size = new System.Drawing.Size(69, 20);
            this.labelapellidocliente.TabIndex = 41;
            this.labelapellidocliente.Text = "Apellido:";
            // 
            // labelnombrecliente
            // 
            this.labelnombrecliente.AutoSize = true;
            this.labelnombrecliente.BackColor = System.Drawing.Color.Transparent;
            this.labelnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombrecliente.Location = new System.Drawing.Point(26, 184);
            this.labelnombrecliente.Name = "labelnombrecliente";
            this.labelnombrecliente.Size = new System.Drawing.Size(69, 20);
            this.labelnombrecliente.TabIndex = 40;
            this.labelnombrecliente.Text = "Nombre:";
            // 
            // labelidcliente
            // 
            this.labelidcliente.AutoSize = true;
            this.labelidcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidcliente.Location = new System.Drawing.Point(26, 147);
            this.labelidcliente.Name = "labelidcliente";
            this.labelidcliente.Size = new System.Drawing.Size(30, 20);
            this.labelidcliente.TabIndex = 39;
            this.labelidcliente.Text = "ID:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 62;
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(111, 141);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(220, 26);
            this.txtPkid.TabIndex = 50;
            this.txtPkid.Tag = "Pkid";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(111, 178);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 26);
            this.txtNombre.TabIndex = 50;
            this.txtNombre.Tag = "Nombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(111, 215);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 26);
            this.txtApellido.TabIndex = 50;
            this.txtApellido.Tag = "Apellido";
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(111, 252);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(220, 26);
            this.txtNit.TabIndex = 50;
            this.txtNit.Tag = "Nit";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(111, 289);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(220, 26);
            this.txtTelefono.TabIndex = 50;
            this.txtTelefono.Tag = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(111, 328);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(220, 26);
            this.txtDireccion.TabIndex = 50;
            this.txtDireccion.Tag = "Direccion";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(111, 367);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(220, 26);
            this.txtCorreo.TabIndex = 50;
            this.txtCorreo.Tag = "Correo";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(279, 439);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(52, 26);
            this.txtEstatus.TabIndex = 50;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // frmMantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1190, 548);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.rbnActivo);
            this.Controls.Add(this.rbnInactivo);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.labelcorreocliente);
            this.Controls.Add(this.labeldireccioncliente);
            this.Controls.Add(this.labeltelefonocliente);
            this.Controls.Add(this.labelnitcliente);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.labelestadocliente);
            this.Controls.Add(this.labelapellidocliente);
            this.Controls.Add(this.labelnombrecliente);
            this.Controls.Add(this.labelidcliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelcorreocliente;
        private System.Windows.Forms.Label labeldireccioncliente;
        private System.Windows.Forms.Label labeltelefonocliente;
        private System.Windows.Forms.Label labelnitcliente;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.RadioButton rbnInactivo;
        private System.Windows.Forms.RadioButton rbnActivo;
        private System.Windows.Forms.Label labelestadocliente;
        private System.Windows.Forms.Label labelapellidocliente;
        private System.Windows.Forms.Label labelnombrecliente;
        private System.Windows.Forms.Label labelidcliente;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}