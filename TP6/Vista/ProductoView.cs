using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP6.Modelo;
using TP6.Presentador;
using TP6.Vista;

namespace TP6
{
    public partial class ProductoView : Form, IProductoView
    {
        public ProductoView(bool esnuevo)
        {
            EsNuevo = esnuevo;
            InitializeComponent();
            AgregarFuncionalidad();
        }

        private void AgregarFuncionalidad()
        {
            if (EsNuevo)
            {
                btnGuardar.Visible = true;
                btnModificar.Visible = false;
            }
            else
            {
                btnGuardar.Visible = false;
                btnModificar.Visible = true;
            }
                btnGuardar.Click += delegate {
                    var result = MessageBox.Show("Esta seguro que desea agregar este producto?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        AgregarProducto?.Invoke(this, EventArgs.Empty);
                    }
                };
                btnModificar.Click += delegate { ModificarProducto?.Invoke(this, EventArgs.Empty); };
        }

        public string Codigo { get => txtCodigo.Text; set => txtCodigo.Text = value; }
        public string Descripcion { get => txtDescripcion.Text; set => txtDescripcion.Text = value; }
        public string PorcentajeIVA { get => txtPorcentajeIva.Text; set => txtPorcentajeIva.Text = value; }
        public string CostoSinIva { get => txtPrecioSinIva.Text; set => txtPrecioSinIva.Text = value; }
        public string CostoConIVA { get => txtPrecioConIva.Text; set => txtPrecioConIva.Text = value; }
        public string MargenGanancia { get => txtMargenGanancia.Text; set => txtMargenGanancia.Text = value; }
        public string PrecioFinalVenta { get => txtPrecioFinal.Text; set => txtPrecioFinal.Text = value; }
        public string Estado { get => comboEstados.SelectedItem.ToString(); set => comboEstados.Text = value; }
        public bool EsNuevo { get; set; }

        public event EventHandler AgregarProducto;
        public event EventHandler ModificarProducto;

        public void SetProductListBindingSource(BindingSource productList)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
