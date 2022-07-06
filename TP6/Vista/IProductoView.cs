using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TP6.Vista
{
    public interface IProductoView
    {
        void SetProductListBindingSource(BindingSource productList);
        void Show();
    }
}
