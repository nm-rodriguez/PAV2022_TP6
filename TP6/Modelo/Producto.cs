using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Modelo
{
    public class Producto: IComerciable
    {
        private string _codigo;
        private string _descripcion;
        private double _porcentajeIVA;//PI
        private double _costoSinIva;//CSI
        private double _margenGanancia;//MG => SE PUEDE CALCULAR
        private double _precioFinalVenta;//PF => SE CALCULA
        private EstadosProducto _estado;


        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double PorcentajeIVA { get => _porcentajeIVA; set => _porcentajeIVA = value; }
        public double CostoSinIva { get => _costoSinIva; set => _costoSinIva = value; }
        public double CostoConIVA { get => GetCostoConIVA();}
        public double MargenGanancia { get => _margenGanancia; set => _margenGanancia = value; }
        public double PrecioFinalVenta { get => GetPrecioFinal(); set =>  PrecioFinalVenta = value;  }
        public EstadosProducto Estado { get => _estado; set => _estado = value; }

        
        public Producto(string codigo, string descripcion, double porcentajeIVA, double costoSinIva, double margenGanancia)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            PorcentajeIVA = porcentajeIVA;
            CostoSinIva = costoSinIva;
            MargenGanancia = margenGanancia;
            Estado = EstadosProducto.Activo;
        }

        public double GetCostoConIVA()
        {
            return CostoSinIva + (CostoSinIva * PorcentajeIVA);
        }

        public double GetPrecioFinal()
        {
            return CostoConIVA + (CostoConIVA * MargenGanancia);
        }

        public double GetMargenGanancia()
        {
            return (PrecioFinalVenta - CostoConIVA) / CostoConIVA;
        }
    }
}
