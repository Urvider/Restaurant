using Restaurant.Model;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            TodosProductos();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btModificar_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarProducto();
            TodosProductos();
            LimpiarCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TodosProductos()
        {
            using (var context = new AplicationDbContext())
            {
                var productos = context.Producto.ToList();
                dgvProductos.DataSource = productos;
            }
        }
        private void RegistrarProducto()
        {
            using (var context = new AplicationDbContext())
            {
                var producto = new Producto();

                producto.Nombre = txtNombre.Text.ToUpper();
                producto.Precio = int.Parse(txtPrecio.Text);
                producto.Cantidad = int.Parse(txtCantidad.Text);
                producto.Tipo = txtNombre.Text.ToUpper();

                context.Producto.Add(producto);
                context.SaveChanges();
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtTipo.Text = "";
        }
    }
}
