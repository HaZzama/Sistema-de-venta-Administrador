namespace Sistema_de_venta_Administrador
{
    partial class MenuAdministrador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCliente,
            this.mnuProducto,
            this.mnuProveedor,
            this.mnuCategoria});
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gestionarToolStripMenuItem.Text = "Gestionar ";
            // 
            // mnuCliente
            // 
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(128, 22);
            this.mnuCliente.Text = "Cliente";
            this.mnuCliente.Click += new System.EventHandler(this.mnuCliente_Click);
            // 
            // mnuProducto
            // 
            this.mnuProducto.Name = "mnuProducto";
            this.mnuProducto.Size = new System.Drawing.Size(128, 22);
            this.mnuProducto.Text = "Producto";
            this.mnuProducto.Click += new System.EventHandler(this.mnuProducto_Click);
            // 
            // mnuProveedor
            // 
            this.mnuProveedor.Name = "mnuProveedor";
            this.mnuProveedor.Size = new System.Drawing.Size(128, 22);
            this.mnuProveedor.Text = "Proveedor";
            this.mnuProveedor.Click += new System.EventHandler(this.mnuProveedor_Click);
            // 
            // mnuCategoria
            // 
            this.mnuCategoria.Name = "mnuCategoria";
            this.mnuCategoria.Size = new System.Drawing.Size(128, 22);
            this.mnuCategoria.Text = "Categoria";
            this.mnuCategoria.Click += new System.EventHandler(this.mnuCategoria_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = global::Sistema_de_venta_Administrador.Properties.Resources._300px_Hazama__Story_Mode_Artwork__Pre_Battle_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 395);
            this.panel1.TabIndex = 1;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuProducto;
        private System.Windows.Forms.ToolStripMenuItem mnuProveedor;
        private System.Windows.Forms.ToolStripMenuItem mnuCategoria;
        private System.Windows.Forms.Panel panel1;
    }
}

