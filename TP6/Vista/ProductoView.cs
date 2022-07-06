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
    public partial class ProductoView : Form, IProductoView
    {
        public ProductoView()
        {
            InitializeComponent();
        }

        public event EventHandler ShowProductsView;
        public void SetProductListBindingSource(BindingSource productList)
        {
            throw new NotImplementedException();
        }
    }
}
