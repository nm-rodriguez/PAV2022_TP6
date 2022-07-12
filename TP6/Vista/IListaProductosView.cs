using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TP6.Vista
{
    public interface IListaProductosView
    {
        public string Codigo { get; set; }

        event EventHandler BuscarCodigo;
        event EventHandler AgregarProducto;
        event EventHandler EditarProducto;
        event EventHandler EliminarProducto;

        void SetProductListBindingSource(BindingSource productList);
        void Show();
        void Dispose();
    }
}
