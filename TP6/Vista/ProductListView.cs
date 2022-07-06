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
        ProductoView _viewProducto;
        public ProductListView(Form p)
        {
            InitializeComponent();
            this.MdiParent = p;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.btnAdd.Click += delegate { ShowPrudctsView?.Invoke(this, EventArgs.Empty); };
            this.btnEdit.Click += delegate { ShowPrudctsView?.Invoke(this, EventArgs.Empty); };

        }
        public event EventHandler ShowPrudctsView;

        public void SetProductListBindingSource(BindingSource productList)
        {
            throw new NotImplementedException();
        }
    }
}
