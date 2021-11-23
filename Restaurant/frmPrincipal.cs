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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            frmMenu men = new frmMenu();

            men.Show();
        }

        private void btPedido_Click(object sender, EventArgs e)
        {
            frmPedido ped = new frmPedido();
            ped.Show();
            this.Hide();
        }

        private void btProductos_Click(object sender, EventArgs e)
        {
            frmProductos ob = new frmProductos();
            ob.Show();
            this.Hide();
        }
    }
}
