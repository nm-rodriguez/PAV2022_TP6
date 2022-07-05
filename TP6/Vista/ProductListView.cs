using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP6
{
    public partial class ProductListView : Form
    {
        ProductoView _viewProducto;
        public ProductListView(Form p)
        {
            InitializeComponent();
            this.MdiParent = p;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _viewProducto = new ProductoView();
            _viewProducto.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _viewProducto = new ProductoView();
            _viewProducto.ShowDialog();
        }

        
    }
}
