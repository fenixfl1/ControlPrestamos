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
    public partial class ListClients : Form
    {
        CN_Clients clients = new CN_Clients();
        public ListClients()
        {
            InitializeComponent();
        }

        private void ListClients_Load(object sender, EventArgs e)
        {
            ShowClients();
        }
        private void ShowClients()
        {
            dataGridView1.DataSource = clients.ShowClients();
        }
    }
}
