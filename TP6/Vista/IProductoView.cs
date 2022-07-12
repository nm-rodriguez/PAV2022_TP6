using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TP6.Modelo;

namespace TP6.Vista
{
    public interface IProductoView
    {
        public bool EsNuevo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string PorcentajeIVA { get; set; }
        public string CostoSinIva { get; set; }
        public string CostoConIVA { get; set; }
        public string MargenGanancia { get; set; }
        public string PrecioFinalVenta { get; set; }
        public string Estado { get; set; }

        event EventHandler AgregarProducto;
        event EventHandler ModificarProducto;
        void SetProductListBindingSource(BindingSource productList);
        void Show();
        void Dispose();
    }
}
