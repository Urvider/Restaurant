using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();

            men.Show();
        }

        private void btPedido_Click(object sender, EventArgs e)
        {
            Pedido ped = new Pedido();
            ped.Show();
            this.Hide();
        }
    }
}
