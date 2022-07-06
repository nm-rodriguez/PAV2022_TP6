using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP6.Vista;

namespace TP6
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            productosToolStripMenuItem.Click += delegate { ShowProductList?.Invoke(this, EventArgs.Empty);};
        }
        
        public event EventHandler ShowProductList;
    }
}
