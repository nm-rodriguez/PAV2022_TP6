using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Modelo;

namespace TP6
{
    public class PersistenciaDatos
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
        }

        public Producto BuscarProducto(string codigo)
        {
            //hacer consulta con LinQ
            return ListaProductos.Find(p => p.Codigo == codigo);
        }

        public void AgregarProducto(Producto prod)
        {
            ListaProductos.Add(prod);
        }

        public void EliminarProducto(string cod)
        {
            foreach (Producto pViejo in ListaProductos)
            {
                if (pViejo.Codigo == cod)
                {
                    ListaProductos.Remove(pViejo);
                    return;
                }
            }
        }

        public void ModificarProducto(string cod, Producto productoModificado)
        {
            foreach (Producto pViejo in ListaProductos)
            {
                if (pViejo.Codigo == cod)
                {
                    pViejo.Codigo = productoModificado.Codigo;
                    pViejo.Descripcion = productoModificado.Descripcion;
                    pViejo.PorcentajeIVA = productoModificado.PorcentajeIVA;
                    pViejo.CostoSinIva = productoModificado.CostoSinIva;
                    pViejo.MargenGanancia = productoModificado.MargenGanancia;
                    return;
                }
            }
        }
    }
}
