using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP6
{
    public partial class ViewProductList : Form
    {
        ViewProducto _viewProducto;
        public ViewProductList(Form p)
        {
            InitializeComponent();
            this.MdiParent = p;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _viewProducto = new ViewProducto();
            _viewProducto.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _viewProducto = new ViewProducto();
            _viewProducto.ShowDialog();
        }
    }
}
