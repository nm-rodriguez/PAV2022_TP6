using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP6.Vista;

namespace TP6
{
    public partial class ProductListView : Form, IListaProductosView
    {
        public ProductListView(Form p)
        {
            InitializeComponent();
            MdiParent = p;
            
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.Sizable;
            btnAdd.Click += delegate { MostrarVistaProductos?.Invoke(this, EventArgs.Empty); };
            btnEdit.Click += delegate { MostrarVistaProductos?.Invoke(this, EventArgs.Empty); };
            btnDelete.Click += delegate {
                var result = MessageBox.Show("Esta seguro que desea eliminar este producto?","Atencion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    EliminarProducto?.Invoke(this, EventArgs.Empty); 
                }
            };
            txtCodigo.TextChanged += (s, e) =>
            {
                    BuscarCodigo?.Invoke(this, EventArgs.Empty);
            };
        }

        public string Codigo { get => txtCodigo.Text; set => txtCodigo.Text = value.ToString(); }

        public event EventHandler BuscarCodigo;
        public event EventHandler MostrarVistaProductos;
        public event EventHandler EliminarProducto;

        
        public void SetProductListBindingSource(BindingSource productList)
        {
            dataGridView1.DataSource = productList;
        }
    }
}
