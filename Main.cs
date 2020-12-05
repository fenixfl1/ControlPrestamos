using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaNegocio;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using ControlPrestamos.forms;
using System.Windows.Media.Effects;

namespace ControlPrestamos
{
    public partial class Main : Form
    {
        private IconButton currentButton;
        private Panel headerPanel;
        private Form currentFormChild;

        public Main()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            headerPanel = new Panel();
            panelHeader.Controls.Add(headerPanel);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
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

                //panels;
                headerPanel.Location = new Point(0, 0);
                headerPanel.Size = new Size(256, 0);
                headerPanel.Visible = true;
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
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void setingLabel_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 128, 255));
            OpenFormChild(new Prestamos());
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 128, 255));
            OpenFormChild(new ListaPrestamos());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 128, 255));
            OpenFormChild(new Clientes());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 128, 255));
        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisabledButton();
            OpenFormChild(new About());
        }

        private void btnListaCientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 128, 255));
            OpenFormChild(new ListClients());
        }
    }
}
