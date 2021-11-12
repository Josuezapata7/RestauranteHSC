
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoMora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoMora));
            this.labelMoras = new System.Windows.Forms.Label();
            this.dtgMoras = new System.Windows.Forms.DataGridView();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.labelestadomora = new System.Windows.Forms.Label();
            this.labelcantidadmora = new System.Windows.Forms.Label();
            this.labelnombremora = new System.Windows.Forms.Label();
            this.labelidmora = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMoras)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMoras
            // 
            this.labelMoras.AutoSize = true;
            this.labelMoras.BackColor = System.Drawing.Color.Transparent;
            this.labelMoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoras.Location = new System.Drawing.Point(376, 110);
            this.labelMoras.Name = "labelMoras";
            this.labelMoras.Size = new System.Drawing.Size(143, 20);
            this.labelMoras.TabIndex = 30;
            this.labelMoras.Text = "Moras Registradas";
            // 
            // dtgMoras
            // 
            this.dtgMoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMoras.Location = new System.Drawing.Point(380, 139);
            this.dtgMoras.Name = "dtgMoras";
            this.dtgMoras.Size = new System.Drawing.Size(778, 236);
            this.dtgMoras.TabIndex = 29;
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(159, 298);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 28;
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
            this.rbnHabilitado.Location = new System.Drawing.Point(55, 298);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 27;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            this.rbnHabilitado.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // labelestadomora
            // 
            this.labelestadomora.AutoSize = true;
            this.labelestadomora.BackColor = System.Drawing.Color.Transparent;
            this.labelestadomora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadomora.Location = new System.Drawing.Point(34, 256);
            this.labelestadomora.Name = "labelestadomora";
            this.labelestadomora.Size = new System.Drawing.Size(64, 20);
            this.labelestadomora.TabIndex = 19;
            this.labelestadomora.Text = "Estado:";
            // 
            // labelcantidadmora
            // 
            this.labelcantidadmora.AutoSize = true;
            this.labelcantidadmora.BackColor = System.Drawing.Color.Transparent;
            this.labelcantidadmora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcantidadmora.Location = new System.Drawing.Point(34, 219);
            this.labelcantidadmora.Name = "labelcantidadmora";
            this.labelcantidadmora.Size = new System.Drawing.Size(77, 20);
            this.labelcantidadmora.TabIndex = 18;
            this.labelcantidadmora.Text = "Cantidad:";
            // 
            // labelnombremora
            // 
            this.labelnombremora.AutoSize = true;
            this.labelnombremora.BackColor = System.Drawing.Color.Transparent;
            this.labelnombremora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombremora.Location = new System.Drawing.Point(34, 184);
            this.labelnombremora.Name = "labelnombremora";
            this.labelnombremora.Size = new System.Drawing.Size(69, 20);
            this.labelnombremora.TabIndex = 17;
            this.labelnombremora.Text = "Nombre:";
            // 
            // labelidmora
            // 
            this.labelidmora.AutoSize = true;
            this.labelidmora.BackColor = System.Drawing.Color.Transparent;
            this.labelidmora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidmora.Location = new System.Drawing.Point(32, 144);
            this.labelidmora.Name = "labelidmora";
            this.labelidmora.Size = new System.Drawing.Size(30, 20);
            this.labelidmora.TabIndex = 16;
            this.labelidmora.Text = "ID:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 2);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 31;
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(112, 143);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(235, 26);
            this.txtPkid.TabIndex = 32;
            this.txtPkid.Tag = "Pkid";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(114, 178);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 26);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(114, 213);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(235, 26);
            this.txtCantidad.TabIndex = 32;
            this.txtCantidad.Tag = "Cantidad";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(274, 296);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(43, 26);
            this.txtEstatus.TabIndex = 32;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // frmMantenimientoMora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1184, 404);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.labelMoras);
            this.Controls.Add(this.dtgMoras);
            this.Controls.Add(this.labelestadomora);
            this.Controls.Add(this.labelcantidadmora);
            this.Controls.Add(this.labelnombremora);
            this.Controls.Add(this.labelidmora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoMora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoMora";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoras;
        private System.Windows.Forms.DataGridView dtgMoras;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.Label labelestadomora;
        private System.Windows.Forms.Label labelcantidadmora;
        private System.Windows.Forms.Label labelnombremora;
        private System.Windows.Forms.Label labelidmora;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}