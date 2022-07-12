using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TP6.Modelo;
using TP6.Vista;

namespace TP6.Presentador
{
    public class ProductoPresenter
    {
        private IListaProductosView _view;
        private IProductoView _viewProducto;
        private IProductoRepositorio _repositorio;
        private BindingSource _listaBinding;
        private IEnumerable<Producto> _lista;

        public ProductoPresenter(IListaProductosView producto, IProductoRepositorio persistencia)
        {
            _listaBinding = new BindingSource();
            _view = producto;
            _view.SetProductListBindingSource(_listaBinding);
            _view.BuscarCodigo += BuscarProducto;
            _view.EditarProducto += MostrarVistaModificar;
            _view.EditarProducto += CargarProducto;
            _view.AgregarProducto+= MostrarVistaAgregar;
            _view.EliminarProducto+= EliminarProducto;
           

            _repositorio = persistencia;
            CargarTodosLosProductos();
            _view.Show();
        }
        public void RecargarLista()
        {
            _listaBinding.DataSource = null;
            _listaBinding.DataSource = _repositorio.GetAll();
        }
        private void AgregarProducto(object sender, EventArgs e)
        {
            string codigo = _viewProducto.Codigo;
            string descripcion = _viewProducto.Descripcion;
            double porcentajeIVA = Convert.ToDouble(_viewProducto.PorcentajeIVA);
            double costoSinIva = Convert.ToDouble(_viewProducto.CostoSinIva);
            double margenGanancia = Convert.ToDouble(_viewProducto.MargenGanancia);
            var p = new Producto(codigo, descripcion, porcentajeIVA, costoSinIva, margenGanancia);
            _repositorio.Add(p);
            _viewProducto.Dispose();
            RecargarLista();

        }

        private void MostrarVistaAgregar(object sender, EventArgs e)
        {
            _viewProducto = new ProductoView(true);
            _viewProducto.AgregarProducto += AgregarProducto;
            _viewProducto.Show();
        }


        private void EliminarProducto(object sender, EventArgs e)
        {
            var producto = (Producto)_listaBinding.Current;
            _repositorio.Delete(producto.Codigo);
            RecargarLista();

        }

        private void MostrarVistaModificar(object sender, EventArgs e)
        {
            _viewProducto = new ProductoView(false);
            _viewProducto.Show();
        }

        private void CargarProducto(object sender, EventArgs e)
        {
            var p = (Producto)_listaBinding.Current;
            _viewProducto.Codigo = p.Codigo;
            _viewProducto.Descripcion = p.Descripcion;
            _viewProducto.PorcentajeIVA = p.PorcentajeIVA.ToString();
            _viewProducto.CostoConIVA= p.CostoConIVA.ToString();
            _viewProducto.CostoSinIva= p.CostoSinIva.ToString();
            _viewProducto.MargenGanancia = p.MargenGanancia.ToString();
            _viewProducto.PrecioFinalVenta = p.PrecioFinalVenta.ToString();
            _viewProducto.Estado = p.Estado.ToString();
            _viewProducto.ModificarProducto += ModificarProducto;
        }

        private void ModificarProducto(object sender, EventArgs e)
        {
            string codigo = _viewProducto.Codigo;
            string descripcion = _viewProducto.Descripcion;
            double porcentajeIVA = Convert.ToDouble(_viewProducto.PorcentajeIVA);
            double costoSinIva = Convert.ToDouble(_viewProducto.CostoSinIva);
            double margenGanancia = Convert.ToDouble(_viewProducto.MargenGanancia);
            var p = new Producto(codigo, descripcion, porcentajeIVA, costoSinIva, margenGanancia);
            _repositorio.Edit(p);
            _viewProducto.Dispose();
            RecargarLista();
        }

        private void BuscarProducto(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(_view.Codigo);
            if (!emptyValue)
                _lista = _repositorio.GetByValue(_view.Codigo);
            else _lista = _repositorio.GetAll();
            _listaBinding.DataSource = _lista;
        }

        private void CargarTodosLosProductos()
        {
            _lista = _repositorio.GetAll();
            _listaBinding.DataSource = _lista;
        }
    }
}
