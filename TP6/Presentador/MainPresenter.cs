using System;
using System.Collections.Generic;
using System.Text;
using TP6.Vista;

namespace TP6.Presentador
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private IProductoView _productoView;
        private PersistenciaDatos _persistenciaDatos;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
            _mainView.ShowProductList += ShowProductsListView;
            _productoView = new ProductoView();
            _persistenciaDatos = new PersistenciaDatos();

        }

        private void ShowProductsListView(object sender, EventArgs e)
        {
            ProductListView view = new ProductListView((MainView)_mainView);
            view.Show();
        }
    }
}
