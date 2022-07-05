using System;
using System.Collections.Generic;
using System.Text;
using TP6.Vista;

namespace TP6.Presentador
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private PersistenciaDatos _persistenciaDatos;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
            _mainView.ShowProductList += ShowProductsView;
            _persistenciaDatos = new PersistenciaDatos();
        }

        private void ShowProductsView(object sender, EventArgs e)
        {
            ProductListView view = new ProductListView();
        }
    }
}
