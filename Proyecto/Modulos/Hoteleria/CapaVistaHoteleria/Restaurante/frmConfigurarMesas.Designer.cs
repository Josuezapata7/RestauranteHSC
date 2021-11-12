
namespace CapaVistaHoteleria.Restaurante
{
    partial class frmConfigurarMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurarMesas));
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlflowSalones = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSalon = new System.Windows.Forms.Panel();
            this.btnSalon = new System.Windows.Forms.Button();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.btnAgregarMesas = new System.Windows.Forms.Button();
            this.pnlBusquedaSalon = new System.Windows.Forms.Panel();
            this.picBuscarSalon = new System.Windows.Forms.PictureBox();
            this.txtBuscarSalon = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlBienvenida = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pnlFlowMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlflowSalones.SuspendLayout();
            this.pnlSalon.SuspendLayout();
            this.pnlArriba.SuspendLayout();
            this.pnlBusquedaSalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarSalon)).BeginInit();
            this.pnlBienvenida.SuspendLayout();
            this.pnlFlowMesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.sidebar.Controls.Add(this.pnlContenido);
            this.sidebar.Controls.Add(this.pnlArriba);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(370, 558);
            this.sidebar.TabIndex = 0;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.pnlflowSalones);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 140);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(370, 418);
            this.pnlContenido.TabIndex = 1;
            // 
            // pnlflowSalones
            // 
            this.pnlflowSalones.Controls.Add(this.pnlSalon);
            this.pnlflowSalones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlflowSalones.Location = new System.Drawing.Point(0, 0);
            this.pnlflowSalones.Name = "pnlflowSalones";
            this.pnlflowSalones.Size = new System.Drawing.Size(370, 418);
            this.pnlflowSalones.TabIndex = 0;
            this.pnlflowSalones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlflowSalones_Paint);
            // 
            // pnlSalon
            // 
            this.pnlSalon.Controls.Add(this.btnSalon);
            this.pnlSalon.Location = new System.Drawing.Point(3, 3);
            this.pnlSalon.Name = "pnlSalon";
            this.pnlSalon.Size = new System.Drawing.Size(364, 64);
            this.pnlSalon.TabIndex = 0;
            // 
            // btnSalon
            // 
            this.btnSalon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(226)))), ((int)(((byte)(210)))));
            this.btnSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalon.FlatAppearance.BorderSize = 0;
            this.btnSalon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalon.ForeColor = System.Drawing.Color.White;
            this.btnSalon.Location = new System.Drawing.Point(0, 0);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Size = new System.Drawing.Size(364, 64);
            this.btnSalon.TabIndex = 0;
            this.btnSalon.Text = "button1";
            this.btnSalon.UseVisualStyleBackColor = false;
            this.btnSalon.Click += new System.EventHandler(this.btnSalon_Click);
            // 
            // pnlArriba
            // 
            this.pnlArriba.Controls.Add(this.btnPedido);
            this.pnlArriba.Controls.Add(this.btnAgregarMesas);
            this.pnlArriba.Controls.Add(this.pnlBusquedaSalon);
            this.pnlArriba.Controls.Add(this.btnActualizar);
            this.pnlArriba.Controls.Add(this.btnAgregar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(370, 140);
            this.pnlArriba.TabIndex = 0;
            // 
            // btnAgregarMesas
            // 
            this.btnAgregarMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.btnAgregarMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMesas.FlatAppearance.BorderSize = 0;
            this.btnAgregarMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMesas.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMesas.Location = new System.Drawing.Point(11, 52);
            this.btnAgregarMesas.Name = "btnAgregarMesas";
            this.btnAgregarMesas.Size = new System.Drawing.Size(190, 34);
            this.btnAgregarMesas.TabIndex = 3;
            this.btnAgregarMesas.Text = "Mantenimientos Mesa";
            this.btnAgregarMesas.UseVisualStyleBackColor = false;
            // 
            // pnlBusquedaSalon
            // 
            this.pnlBusquedaSalon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.pnlBusquedaSalon.Controls.Add(this.picBuscarSalon);
            this.pnlBusquedaSalon.Controls.Add(this.txtBuscarSalon);
            this.pnlBusquedaSalon.Location = new System.Drawing.Point(27, 102);
            this.pnlBusquedaSalon.Name = "pnlBusquedaSalon";
            this.pnlBusquedaSalon.Size = new System.Drawing.Size(316, 32);
            this.pnlBusquedaSalon.TabIndex = 2;
            // 
            // picBuscarSalon
            // 
            this.picBuscarSalon.Image = ((System.Drawing.Image)(resources.GetObject("picBuscarSalon.Image")));
            this.picBuscarSalon.Location = new System.Drawing.Point(264, 5);
            this.picBuscarSalon.Name = "picBuscarSalon";
            this.picBuscarSalon.Size = new System.Drawing.Size(33, 23);
            this.picBuscarSalon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuscarSalon.TabIndex = 1;
            this.picBuscarSalon.TabStop = false;
            // 
            // txtBuscarSalon
            // 
            this.txtBuscarSalon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(215)))));
            this.txtBuscarSalon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSalon.Location = new System.Drawing.Point(13, 8);
            this.txtBuscarSalon.Name = "txtBuscarSalon";
            this.txtBuscarSalon.Size = new System.Drawing.Size(237, 16);
            this.txtBuscarSalon.TabIndex = 0;
            this.txtBuscarSalon.TextChanged += new System.EventHandler(this.txtBuscarSalon_TextChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(205)))), ((int)(((byte)(127)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(213, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 34);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(11, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(190, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Mantenimientos Salon";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // pnlBienvenida
            // 
            this.pnlBienvenida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBienvenida.BackgroundImage")));
            this.pnlBienvenida.Controls.Add(this.lblBienvenida);
            this.pnlBienvenida.Location = new System.Drawing.Point(506, 140);
            this.pnlBienvenida.Name = "pnlBienvenida";
            this.pnlBienvenida.Size = new System.Drawing.Size(235, 129);
            this.pnlBienvenida.TabIndex = 1;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBienvenida.Location = new System.Drawing.Point(0, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(235, 129);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Elija un Salon Para Iniciar";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFlowMesas
            // 
            this.pnlFlowMesas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFlowMesas.BackgroundImage")));
            this.pnlFlowMesas.Controls.Add(this.button1);
            this.pnlFlowMesas.Location = new System.Drawing.Point(485, 300);
            this.pnlFlowMesas.Name = "pnlFlowMesas";
            this.pnlFlowMesas.Size = new System.Drawing.Size(290, 154);
            this.pnlFlowMesas.TabIndex = 2;
            this.pnlFlowMesas.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(90)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(197)))), ((int)(((byte)(120)))));
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.White;
            this.btnPedido.Location = new System.Drawing.Point(213, 52);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(140, 34);
            this.btnPedido.TabIndex = 4;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // frmConfigurarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.pnlFlowMesas);
            this.Controls.Add(this.pnlBienvenida);
            this.Controls.Add(this.sidebar);
            this.Name = "frmConfigurarMesas";
            this.Text = "1021- Configurar Mesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConfigurarMesas_Load);
            this.sidebar.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlflowSalones.ResumeLayout(false);
            this.pnlSalon.ResumeLayout(false);
            this.pnlArriba.ResumeLayout(false);
            this.pnlBusquedaSalon.ResumeLayout(false);
            this.pnlBusquedaSalon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarSalon)).EndInit();
            this.pnlBienvenida.ResumeLayout(false);
            this.pnlFlowMesas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlBusquedaSalon;
        private System.Windows.Forms.PictureBox picBuscarSalon;
        private System.Windows.Forms.TextBox txtBuscarSalon;
        private System.Windows.Forms.Panel pnlBienvenida;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.FlowLayoutPanel pnlFlowMesas;
        private System.Windows.Forms.FlowLayoutPanel pnlflowSalones;
        private System.Windows.Forms.Panel pnlSalon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarMesas;
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.Button btnPedido;
    }
}