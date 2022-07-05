using System;
using System.Collections.Generic;
using System.Text;

namespace TP6.Modelo
{
    public interface IProductoRepositorio
    {
        void Add(Producto productoModelo);
        void Edit(Producto productoModelo);
        void Edit(int id);
        IEnumerable<Producto> GetAll();
        IEnumerable<Producto> GetByValue(string id);
    }
}
