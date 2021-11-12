
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoFraccionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoFraccionamiento));
            this.labelFraccionamiento = new System.Windows.Forms.Label();
            this.dtgFraccionamiento = new System.Windows.Forms.DataGridView();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.labelestadofraccionamiento = new System.Windows.Forms.Label();
            this.labelcuotasfraccionamiento = new System.Windows.Forms.Label();
            this.labelnombrefraccionamiento = new System.Windows.Forms.Label();
            this.labelidfraccionamiento = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFraccionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFraccionamiento
            // 
            this.labelFraccionamiento.AutoSize = true;
            this.labelFraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelFraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFraccionamiento.Location = new System.Drawing.Point(355, 105);
            this.labelFraccionamiento.Name = "labelFraccionamiento";
            this.labelFraccionamiento.Size = new System.Drawing.Size(225, 20);
            this.labelFraccionamiento.TabIndex = 45;
            this.labelFraccionamiento.Text = "Fraccionamientos Registrados";
            // 
            // dtgFraccionamiento
            // 
            this.dtgFraccionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFraccionamiento.Location = new System.Drawing.Point(359, 128);
            this.dtgFraccionamiento.Name = "dtgFraccionamiento";
            this.dtgFraccionamiento.Size = new System.Drawing.Size(799, 245);
            this.dtgFraccionamiento.TabIndex = 44;
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(146, 317);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 5;
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
            this.rbnHabilitado.Location = new System.Drawing.Point(42, 317);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 4;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            this.rbnHabilitado.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // labelestadofraccionamiento
            // 
            this.labelestadofraccionamiento.AutoSize = true;
            this.labelestadofraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelestadofraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadofraccionamiento.Location = new System.Drawing.Point(29, 287);
            this.labelestadofraccionamiento.Name = "labelestadofraccionamiento";
            this.labelestadofraccionamiento.Size = new System.Drawing.Size(64, 20);
            this.labelestadofraccionamiento.TabIndex = 34;
            this.labelestadofraccionamiento.Text = "Estado:";
            // 
            // labelcuotasfraccionamiento
            // 
            this.labelcuotasfraccionamiento.AutoSize = true;
            this.labelcuotasfraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelcuotasfraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcuotasfraccionamiento.Location = new System.Drawing.Point(28, 234);
            this.labelcuotasfraccionamiento.Name = "labelcuotasfraccionamiento";
            this.labelcuotasfraccionamiento.Size = new System.Drawing.Size(64, 20);
            this.labelcuotasfraccionamiento.TabIndex = 33;
            this.labelcuotasfraccionamiento.Text = "Cuotas:";
            // 
            // labelnombrefraccionamiento
            // 
            this.labelnombrefraccionamiento.AutoSize = true;
            this.labelnombrefraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelnombrefraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombrefraccionamiento.Location = new System.Drawing.Point(28, 194);
            this.labelnombrefraccionamiento.Name = "labelnombrefraccionamiento";
            this.labelnombrefraccionamiento.Size = new System.Drawing.Size(69, 20);
            this.labelnombrefraccionamiento.TabIndex = 32;
            this.labelnombrefraccionamiento.Text = "Nombre:";
            // 
            // labelidfraccionamiento
            // 
            this.labelidfraccionamiento.AutoSize = true;
            this.labelidfraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelidfraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidfraccionamiento.Location = new System.Drawing.Point(28, 155);
            this.labelidfraccionamiento.Name = "labelidfraccionamiento";
            this.labelidfraccionamiento.Size = new System.Drawing.Size(30, 20);
            this.labelidfraccionamiento.TabIndex = 31;
            this.labelidfraccionamiento.Text = "ID:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-2, -2);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 46;
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(104, 149);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(216, 26);
            this.txtPkid.TabIndex = 1;
            this.txtPkid.Tag = "Pkid";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(103, 188);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotas.Location = new System.Drawing.Point(104, 228);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(216, 26);
            this.txtCuotas.TabIndex = 3;
            this.txtCuotas.Tag = "Cuotas";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(259, 313);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(41, 26);
            this.txtEstatus.TabIndex = 47;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // frmMantenimientoFraccionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1183, 399);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.labelFraccionamiento);
            this.Controls.Add(this.dtgFraccionamiento);
            this.Controls.Add(this.labelestadofraccionamiento);
            this.Controls.Add(this.labelcuotasfraccionamiento);
            this.Controls.Add(this.labelnombrefraccionamiento);
            this.Controls.Add(this.labelidfraccionamiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoFraccionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoFraccionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFraccionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFraccionamiento;
        private System.Windows.Forms.DataGridView dtgFraccionamiento;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.Label labelestadofraccionamiento;
        private System.Windows.Forms.Label labelcuotasfraccionamiento;
        private System.Windows.Forms.Label labelnombrefraccionamiento;
        private System.Windows.Forms.Label labelidfraccionamiento;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}