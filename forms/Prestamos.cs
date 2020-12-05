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
    public partial class Prestamos : Form
    {
        CN_Clients clientes = new CN_Clients();
        CN_Tipo_Pago tipo_pago = new CN_Tipo_Pago();
        CN_Prestamos prestamos = new CN_Prestamos();
        private IconButton currentButton;
        private Form currentFormChild;
        public Prestamos()
        {
            InitializeComponent();
            clientes.FillCombobox(comboBoxClintes);
            tipo_pago.FillCombobox(comboBoxTipoPago);

            maskedTextBoxFechaInicio.Mask = "00/00/0000";
            maskedTextBoxFechaInicio.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBoxFechaInicio_MaskInputRejected);
            maskedTextBoxFechaInicio.KeyDown += new KeyEventHandler(maskedTextBoxFechaInicio_KeyDown);
        }

        private void labelClient_Click(object sender, EventArgs e)
        {

        }

        private void labelTipoPago_Click(object sender, EventArgs e)
        {

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxClintes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int id_cliente = Int32.Parse(comboBoxClintes.DisplayMember);
            int tipo_pago = Int32.Parse(comboBoxTipoPago.DisplayMember);
            int monto = int.Parse(textBoxMonto.Text);

            MessageBox.Show($"{id_cliente}");

            prestamos.InsertPrestamos(
                id_cliente,
                tipo_pago,
                monto,
                maskedTextBoxFechaInicio.Text
                );
            try
            {
                ActivateButton(sender, Color.FromArgb(0, 128, 255));
                OpenFormChild(new ListaPrestamos());
            } catch (Exception) { }
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


        private void maskedTextBoxFechaInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBoxFechaInicio_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
