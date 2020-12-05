using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using System.Data.SqlClient;

namespace ControlPrestamos.forms
{
    public partial class ListaPrestamos : Form
    {
        CN_Prestamos prestamos = new CN_Prestamos();
        public ListaPrestamos()
        {
            InitializeComponent();
        }

        private void ListaPrestamos_Load(object sender, EventArgs e)
        {
            ShowPrestamos();
        }

        private void ShowPrestamos()
        {
            dataGridViewPrestamos.DataSource = prestamos.ShowPrestamos();
        }

        private void dataGridViewPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
