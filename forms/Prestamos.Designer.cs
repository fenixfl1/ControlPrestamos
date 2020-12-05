namespace ControlPrestamos.forms
{
    partial class Prestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.panelMain = new System.Windows.Forms.Panel();
            this.comboBoxClintes = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxTipoPago = new System.Windows.Forms.ComboBox();
            this.labelNota = new System.Windows.Forms.Label();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.labelTitilePrestamo = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelTipoPago = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.comboBoxClintes);
            this.panelMain.Controls.Add(this.maskedTextBoxFechaInicio);
            this.panelMain.Controls.Add(this.buttonSubmit);
            this.panelMain.Controls.Add(this.comboBoxTipoPago);
            this.panelMain.Controls.Add(this.labelNota);
            this.panelMain.Controls.Add(this.textBoxNota);
            this.panelMain.Controls.Add(this.labelTitilePrestamo);
            this.panelMain.Controls.Add(this.labelFechaInicio);
            this.panelMain.Controls.Add(this.labelTipoPago);
            this.panelMain.Controls.Add(this.labelMonto);
            this.panelMain.Controls.Add(this.textBoxMonto);
            this.panelMain.Controls.Add(this.labelClient);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // comboBoxClintes
            // 
            this.comboBoxClintes.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxClintes, "comboBoxClintes");
            this.comboBoxClintes.Name = "comboBoxClintes";
            this.comboBoxClintes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClintes_SelectedIndexChanged);
            // 
            // maskedTextBoxFechaInicio
            // 
            resources.ApplyResources(this.maskedTextBoxFechaInicio, "maskedTextBoxFechaInicio");
            this.maskedTextBoxFechaInicio.Name = "maskedTextBoxFechaInicio";
            this.maskedTextBoxFechaInicio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxFechaInicio_MaskInputRejected);
            this.maskedTextBoxFechaInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxFechaInicio_KeyDown);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonSubmit, "buttonSubmit");
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxTipoPago
            // 
            this.comboBoxTipoPago.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxTipoPago, "comboBoxTipoPago");
            this.comboBoxTipoPago.Name = "comboBoxTipoPago";
            // 
            // labelNota
            // 
            resources.ApplyResources(this.labelNota, "labelNota");
            this.labelNota.Name = "labelNota";
            // 
            // textBoxNota
            // 
            this.textBoxNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxNota, "textBoxNota");
            this.textBoxNota.Name = "textBoxNota";
            // 
            // labelTitilePrestamo
            // 
            resources.ApplyResources(this.labelTitilePrestamo, "labelTitilePrestamo");
            this.labelTitilePrestamo.Name = "labelTitilePrestamo";
            // 
            // labelFechaInicio
            // 
            resources.ApplyResources(this.labelFechaInicio, "labelFechaInicio");
            this.labelFechaInicio.Name = "labelFechaInicio";
            // 
            // labelTipoPago
            // 
            resources.ApplyResources(this.labelTipoPago, "labelTipoPago");
            this.labelTipoPago.Name = "labelTipoPago";
            this.labelTipoPago.Click += new System.EventHandler(this.labelTipoPago_Click);
            // 
            // labelMonto
            // 
            resources.ApplyResources(this.labelMonto, "labelMonto");
            this.labelMonto.Name = "labelMonto";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxMonto, "textBoxMonto");
            this.textBoxMonto.Name = "textBoxMonto";
            // 
            // labelClient
            // 
            resources.ApplyResources(this.labelClient, "labelClient");
            this.labelClient.Name = "labelClient";
            // 
            // Prestamos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Name = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitilePrestamo;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelTipoPago;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.ComboBox comboBoxTipoPago;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboBoxClintes;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaInicio;
    }
}