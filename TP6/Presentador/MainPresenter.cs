using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TP6.Modelo;
using TP6.Vista;

namespace TP6.Presentador
{
    public class MainPresenter
    {
        private IMainView _mainView;
        //private PersistenciaDatos _persistenciaDatos;
        //private BindingSource _productosListSource;
        IListaProductosView _view;
        IProductoRepositorio _repo;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
            _mainView.ShowProductList += ShowProductsListView;
            _repo = new PersistenciaDatos();
        }

        private void ShowProductsListView(object sender, EventArgs e)
        {
            _view = new ProductListView((MainView)_mainView);
            new ProductoPresenter(_view, _repo);
        }
    }
}
