
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoTipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoTipoDocumento));
            this.labelTipoDocumentos = new System.Windows.Forms.Label();
            this.dtgTipoDocumento = new System.Windows.Forms.DataGridView();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.labelestadotdocumento = new System.Windows.Forms.Label();
            this.labelnombretdocumento = new System.Windows.Forms.Label();
            this.labelidtdocumento = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTipoDocumentos
            // 
            this.labelTipoDocumentos.AutoSize = true;
            this.labelTipoDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDocumentos.Location = new System.Drawing.Point(362, 107);
            this.labelTipoDocumentos.Name = "labelTipoDocumentos";
            this.labelTipoDocumentos.Size = new System.Drawing.Size(246, 20);
            this.labelTipoDocumentos.TabIndex = 43;
            this.labelTipoDocumentos.Text = "Tipos de Documento Registrados";
            // 
            // dtgTipoDocumento
            // 
            this.dtgTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoDocumento.Location = new System.Drawing.Point(365, 128);
            this.dtgTipoDocumento.Name = "dtgTipoDocumento";
            this.dtgTipoDocumento.Size = new System.Drawing.Size(779, 273);
            this.dtgTipoDocumento.TabIndex = 42;
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(158, 272);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 41;
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
            this.rbnHabilitado.Location = new System.Drawing.Point(56, 272);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 40;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            this.rbnHabilitado.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // labelestadotdocumento
            // 
            this.labelestadotdocumento.AutoSize = true;
            this.labelestadotdocumento.BackColor = System.Drawing.Color.Transparent;
            this.labelestadotdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadotdocumento.Location = new System.Drawing.Point(21, 240);
            this.labelestadotdocumento.Name = "labelestadotdocumento";
            this.labelestadotdocumento.Size = new System.Drawing.Size(64, 20);
            this.labelestadotdocumento.TabIndex = 33;
            this.labelestadotdocumento.Text = "Estado:";
            // 
            // labelnombretdocumento
            // 
            this.labelnombretdocumento.AutoSize = true;
            this.labelnombretdocumento.BackColor = System.Drawing.Color.Transparent;
            this.labelnombretdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombretdocumento.Location = new System.Drawing.Point(21, 209);
            this.labelnombretdocumento.Name = "labelnombretdocumento";
            this.labelnombretdocumento.Size = new System.Drawing.Size(69, 20);
            this.labelnombretdocumento.TabIndex = 32;
            this.labelnombretdocumento.Text = "Nombre:";
            // 
            // labelidtdocumento
            // 
            this.labelidtdocumento.AutoSize = true;
            this.labelidtdocumento.BackColor = System.Drawing.Color.Transparent;
            this.labelidtdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidtdocumento.Location = new System.Drawing.Point(21, 170);
            this.labelidtdocumento.Name = "labelidtdocumento";
            this.labelidtdocumento.Size = new System.Drawing.Size(30, 20);
            this.labelidtdocumento.TabIndex = 31;
            this.labelidtdocumento.Text = "ID:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-2, 2);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 44;
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(89, 166);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(245, 26);
            this.txtPkid.TabIndex = 1;
            this.txtPkid.Tag = "Pkid";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(89, 203);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(273, 268);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(61, 26);
            this.txtEstatus.TabIndex = 45;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // frmMantenimientoTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1179, 438);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.labelTipoDocumentos);
            this.Controls.Add(this.dtgTipoDocumento);
            this.Controls.Add(this.labelestadotdocumento);
            this.Controls.Add(this.labelnombretdocumento);
            this.Controls.Add(this.labelidtdocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoTipoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoTipoDocumento";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoDocumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipoDocumentos;
        private System.Windows.Forms.DataGridView dtgTipoDocumento;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.Label labelestadotdocumento;
        private System.Windows.Forms.Label labelnombretdocumento;
        private System.Windows.Forms.Label labelidtdocumento;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}