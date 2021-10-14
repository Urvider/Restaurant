namespace Restaurant
{
    partial class Principal
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.Button();
            this.btPedido = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlPrincipal.Controls.Add(this.Salir);
            this.pnlPrincipal.Controls.Add(this.btPedido);
            this.pnlPrincipal.Controls.Add(this.btMenu);
            this.pnlPrincipal.Location = new System.Drawing.Point(47, 36);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(611, 377);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Salir.BackgroundImage = global::Restaurant.Properties.Resources.salir_de_la_variante_de_simbolo_de_interfaz_dibujada_a_mano;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Salir.Location = new System.Drawing.Point(408, 142);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(104, 82);
            this.Salir.TabIndex = 2;
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btPedido
            // 
            this.btPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btPedido.BackgroundImage = global::Restaurant.Properties.Resources.restaurant_1_;
            this.btPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPedido.FlatAppearance.BorderSize = 0;
            this.btPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPedido.Location = new System.Drawing.Point(240, 142);
            this.btPedido.Name = "btPedido";
            this.btPedido.Size = new System.Drawing.Size(112, 80);
            this.btPedido.TabIndex = 1;
            this.btPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPedido.UseVisualStyleBackColor = false;
            this.btPedido.Click += new System.EventHandler(this.btPedido_Click);
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btMenu.BackgroundImage = global::Restaurant.Properties.Resources.restaurant_menu;
            this.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMenu.Location = new System.Drawing.Point(85, 140);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(117, 84);
            this.btMenu.TabIndex = 0;
            this.btMenu.UseVisualStyleBackColor = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant.Properties.Resources.Comida;
            this.ClientSize = new System.Drawing.Size(701, 446);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "Principal";
            this.Text = "Principal";
            this.pnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btPedido;
        private System.Windows.Forms.Button btMenu;
    }
}