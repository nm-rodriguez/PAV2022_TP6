using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6
{
    public partial class ViewMain : Form
    {
        ViewProductList _viewProductsList;
        public ViewMain()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _viewProductsList = new ViewProductList(this);
            _viewProductsList.WindowState = FormWindowState.Maximized;
            _viewProductsList.FormBorderStyle = FormBorderStyle.Sizable;
            _viewProductsList.Show();
        }
    }
}
