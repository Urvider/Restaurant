namespace Restaurant
{
    partial class frmPrincipal
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
            this.btMenu = new System.Windows.Forms.Button();
            this.btPedido = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(73, 205);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(75, 23);
            this.btMenu.TabIndex = 0;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // btPedido
            // 
            this.btPedido.Location = new System.Drawing.Point(247, 205);
            this.btPedido.Name = "btPedido";
            this.btPedido.Size = new System.Drawing.Size(75, 23);
            this.btPedido.TabIndex = 2;
            this.btPedido.Text = "Pedido";
            this.btPedido.UseVisualStyleBackColor = true;
            this.btPedido.Click += new System.EventHandler(this.btPedido_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(391, 205);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btProductos
            // 
            this.btProductos.Location = new System.Drawing.Point(221, 125);
            this.btProductos.Name = "btProductos";
            this.btProductos.Size = new System.Drawing.Size(75, 23);
            this.btProductos.TabIndex = 4;
            this.btProductos.Text = "Productos";
            this.btProductos.UseVisualStyleBackColor = true;
            this.btProductos.Click += new System.EventHandler(this.btProductos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant.Properties.Resources.Comida;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btProductos);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btPedido);
            this.Controls.Add(this.btMenu);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btPedido;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btProductos;
    }
}