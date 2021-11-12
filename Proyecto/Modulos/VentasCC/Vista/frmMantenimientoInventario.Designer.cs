
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoInventario));
            this.cbxTipoinventario = new System.Windows.Forms.ComboBox();
            this.labelprecioinventario = new System.Windows.Forms.Label();
            this.labelcostoinventario = new System.Windows.Forms.Label();
            this.labelstockinventario = new System.Windows.Forms.Label();
            this.labelInventario = new System.Windows.Forms.Label();
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.labelestadoinventario = new System.Windows.Forms.Label();
            this.labeltipoinventario = new System.Windows.Forms.Label();
            this.labelnombreinventario = new System.Windows.Forms.Label();
            this.labelidinventario = new System.Windows.Forms.Label();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFktipoinventario = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.navegador1 = new DLL.nav.navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipoinventario
            // 
            this.cbxTipoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoinventario.FormattingEnabled = true;
            this.cbxTipoinventario.Location = new System.Drawing.Point(151, 202);
            this.cbxTipoinventario.Name = "cbxTipoinventario";
            this.cbxTipoinventario.Size = new System.Drawing.Size(157, 28);
            this.cbxTipoinventario.TabIndex = 83;
            this.cbxTipoinventario.SelectedIndexChanged += new System.EventHandler(this.cbxTipoinventario_SelectedIndexChanged);
            // 
            // labelprecioinventario
            // 
            this.labelprecioinventario.AutoSize = true;
            this.labelprecioinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelprecioinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprecioinventario.Location = new System.Drawing.Point(32, 315);
            this.labelprecioinventario.Name = "labelprecioinventario";
            this.labelprecioinventario.Size = new System.Drawing.Size(57, 20);
            this.labelprecioinventario.TabIndex = 81;
            this.labelprecioinventario.Text = "Precio:";
            // 
            // labelcostoinventario
            // 
            this.labelcostoinventario.AutoSize = true;
            this.labelcostoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelcostoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcostoinventario.Location = new System.Drawing.Point(32, 277);
            this.labelcostoinventario.Name = "labelcostoinventario";
            this.labelcostoinventario.Size = new System.Drawing.Size(55, 20);
            this.labelcostoinventario.TabIndex = 79;
            this.labelcostoinventario.Text = "Costo:";
            // 
            // labelstockinventario
            // 
            this.labelstockinventario.AutoSize = true;
            this.labelstockinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelstockinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockinventario.Location = new System.Drawing.Point(32, 245);
            this.labelstockinventario.Name = "labelstockinventario";
            this.labelstockinventario.Size = new System.Drawing.Size(54, 20);
            this.labelstockinventario.TabIndex = 77;
            this.labelstockinventario.Text = "Stock:";
            // 
            // labelInventario
            // 
            this.labelInventario.AutoSize = true;
            this.labelInventario.BackColor = System.Drawing.Color.Transparent;
            this.labelInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventario.Location = new System.Drawing.Point(362, 105);
            this.labelInventario.Name = "labelInventario";
            this.labelInventario.Size = new System.Drawing.Size(177, 20);
            this.labelInventario.TabIndex = 76;
            this.labelInventario.Text = "Inventarios Registrados";
            // 
            // dtgInventario
            // 
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventario.Location = new System.Drawing.Point(365, 126);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.Size = new System.Drawing.Size(790, 295);
            this.dtgInventario.TabIndex = 75;
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(169, 382);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 74;
            this.rbnInhabilitado.TabStop = true;
            this.rbnInhabilitado.Text = "Inhabilitado";
            this.rbnInhabilitado.UseVisualStyleBackColor = false;
            this.rbnInhabilitado.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(65, 382);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 73;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            this.rbnHabilitado.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // labelestadoinventario
            // 
            this.labelestadoinventario.AutoSize = true;
            this.labelestadoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelestadoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadoinventario.Location = new System.Drawing.Point(32, 348);
            this.labelestadoinventario.Name = "labelestadoinventario";
            this.labelestadoinventario.Size = new System.Drawing.Size(64, 20);
            this.labelestadoinventario.TabIndex = 66;
            this.labelestadoinventario.Text = "Estado:";
            // 
            // labeltipoinventario
            // 
            this.labeltipoinventario.AutoSize = true;
            this.labeltipoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labeltipoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipoinventario.Location = new System.Drawing.Point(32, 210);
            this.labeltipoinventario.Name = "labeltipoinventario";
            this.labeltipoinventario.Size = new System.Drawing.Size(117, 20);
            this.labeltipoinventario.TabIndex = 65;
            this.labeltipoinventario.Text = "Tipo Inventario:";
            // 
            // labelnombreinventario
            // 
            this.labelnombreinventario.AutoSize = true;
            this.labelnombreinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelnombreinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombreinventario.Location = new System.Drawing.Point(32, 170);
            this.labelnombreinventario.Name = "labelnombreinventario";
            this.labelnombreinventario.Size = new System.Drawing.Size(69, 20);
            this.labelnombreinventario.TabIndex = 64;
            this.labelnombreinventario.Text = "Nombre:";
            // 
            // labelidinventario
            // 
            this.labelidinventario.AutoSize = true;
            this.labelidinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelidinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidinventario.Location = new System.Drawing.Point(32, 141);
            this.labelidinventario.Name = "labelidinventario";
            this.labelidinventario.Size = new System.Drawing.Size(30, 20);
            this.labelidinventario.TabIndex = 63;
            this.labelidinventario.Text = "ID:";
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(151, 135);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(157, 26);
            this.txtPkid.TabIndex = 84;
            this.txtPkid.Tag = "Pkid";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(151, 167);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 26);
            this.txtNombre.TabIndex = 84;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtFktipoinventario
            // 
            this.txtFktipoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFktipoinventario.Location = new System.Drawing.Point(314, 204);
            this.txtFktipoinventario.Name = "txtFktipoinventario";
            this.txtFktipoinventario.Size = new System.Drawing.Size(45, 26);
            this.txtFktipoinventario.TabIndex = 84;
            this.txtFktipoinventario.Tag = "Fktipoinventario";
            this.txtFktipoinventario.Visible = false;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(151, 239);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(157, 26);
            this.txtStock.TabIndex = 84;
            this.txtStock.Tag = "Stock";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(151, 274);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(157, 26);
            this.txtCosto.TabIndex = 84;
            this.txtCosto.Tag = "Costo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(151, 309);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 26);
            this.txtPrecio.TabIndex = 84;
            this.txtPrecio.Tag = "Precio";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(314, 380);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(45, 26);
            this.txtEstatus.TabIndex = 84;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 85;
            // 
            // frmMantenimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtFktipoinventario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.cbxTipoinventario);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.labelprecioinventario);
            this.Controls.Add(this.labelcostoinventario);
            this.Controls.Add(this.labelstockinventario);
            this.Controls.Add(this.labelInventario);
            this.Controls.Add(this.dtgInventario);
            this.Controls.Add(this.labelestadoinventario);
            this.Controls.Add(this.labeltipoinventario);
            this.Controls.Add(this.labelnombreinventario);
            this.Controls.Add(this.labelidinventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoinventario;
        private System.Windows.Forms.Label labelprecioinventario;
        private System.Windows.Forms.Label labelcostoinventario;
        private System.Windows.Forms.Label labelstockinventario;
        private System.Windows.Forms.Label labelInventario;
        private System.Windows.Forms.DataGridView dtgInventario;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.Label labelestadoinventario;
        private System.Windows.Forms.Label labeltipoinventario;
        private System.Windows.Forms.Label labelnombreinventario;
        private System.Windows.Forms.Label labelidinventario;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFktipoinventario;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtEstatus;
        private DLL.nav.navegador navegador1;
    }
}