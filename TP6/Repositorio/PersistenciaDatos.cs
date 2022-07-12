using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Modelo;

namespace TP6
{
    public class PersistenciaDatos: IProductoRepositorio
    {
        public List<Producto> ListaProductos { get; set; }
        public Producto producto { get; set; }
       
        public PersistenciaDatos()
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            ListaProductos = new List<Producto>();
            ListaProductos.Add(new Producto("1","CocaCola 2,25l ",0.21,150,0.50));
            ListaProductos.Add(new Producto("2","Queso Finlandia",0.21,180,0.50));
            ListaProductos.Add(new Producto("3","Cafe Dolca",0.21,250,0.50));
            ListaProductos.Add(new Producto("4","Azucar 1kg",0.21,35,0.50));
            ListaProductos.Add(new Producto("5","Pollo 1kg",0.21,650,0.50));
            ListaProductos.Add(new Producto("6","Pan 1kg",0.21,300,0.50));
            ListaProductos.Add(new Producto("7","Oreos",0.21,120,0.50));
        }

        public void Add(Producto producto)
        {
            ListaProductos.Add(producto);
        }

        public void Edit(Producto productoModelo)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            Producto prod = null;
            foreach (var producto in ListaProductos)
            {
                if (producto.Codigo == id)
                {
                    prod = producto;
                }
            }
            ListaProductos.Remove(prod);
        }

        public IEnumerable<Producto> GetAll()
        {
            return ListaProductos;
        }

        public IEnumerable<Producto> GetByValue(string id)
        {
            return ListaProductos.Where(x => x.Codigo == id);
        }
    }
}
