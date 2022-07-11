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
            _view.MostrarVistaProductos += MostrarVistaProducto;
            _view.EliminarProducto+= EliminarProducto;
            
            _repositorio = persistencia;
            CargarTodosLosProductos();
            _view.Show();
        }

        private void EliminarProducto(object sender, EventArgs e)
        {
            var producto = (Producto)_listaBinding.Current;
            _repositorio.Delete(producto.Codigo);
            _listaBinding.DataSource = null;
            _listaBinding.DataSource = _repositorio.GetAll();

        }

        private void MostrarVistaProducto(object sender, EventArgs e)
        {
            _viewProducto = new ProductoView();
            _viewProducto.Show();
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
