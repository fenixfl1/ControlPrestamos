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
using FontAwesome.Sharp;

namespace ControlPrestamos.forms
{
    public partial class Clientes : Form
    {
        CN_Clients objectCN = new CN_Clients();
        private IconButton currentButton;
        private Form currentFormChild;
        public Clientes()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            objectCN.InsertClient(
                textBoxNombes.Text,
                textBoxApellidos.Text,
                textBoxEmail.Text,
                textBoxTelefono.Text,
                textBoxOcupacion.Text,
                textBoxDocIdentidad.Text,
                textBoxDireccion.Text
            );
            try
            {
                ActivateButton(sender, Color.FromArgb(0, 128, 255));
                OpenFormChild(new ListClients());
            }
            catch (Exception) {}
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisabledButton();
                // botones
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(255, 255, 255);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisabledButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(242, 242, 242);
                currentButton.ForeColor = Color.Black;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.FromArgb(0, 128, 255);
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenFormChild(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnListaCientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 128, 255));
            OpenFormChild(new ListClients());
        }
    }
}
