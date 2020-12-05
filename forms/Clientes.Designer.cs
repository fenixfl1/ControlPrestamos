namespace ControlPrestamos.forms
{
    partial class Clientes
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListaCientes = new FontAwesome.Sharp.IconButton();
            this.labelOcupacion = new System.Windows.Forms.Label();
            this.textBoxOcupacion = new System.Windows.Forms.TextBox();
            this.labelNacionalidad = new System.Windows.Forms.Label();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.labelDirecion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.textBoxNombes = new System.Windows.Forms.TextBox();
            this.labelDocIdentidad = new System.Windows.Forms.Label();
            this.textBoxDocIdentidad = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelTitilePrestamo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.buttonSubmit);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.labelOcupacion);
            this.panelMain.Controls.Add(this.textBoxOcupacion);
            this.panelMain.Controls.Add(this.labelNacionalidad);
            this.panelMain.Controls.Add(this.textBoxNacionalidad);
            this.panelMain.Controls.Add(this.labelDirecion);
            this.panelMain.Controls.Add(this.textBoxDireccion);
            this.panelMain.Controls.Add(this.labelNombres);
            this.panelMain.Controls.Add(this.textBoxNombes);
            this.panelMain.Controls.Add(this.labelDocIdentidad);
            this.panelMain.Controls.Add(this.textBoxDocIdentidad);
            this.panelMain.Controls.Add(this.labelEmail);
            this.panelMain.Controls.Add(this.textBoxEmail);
            this.panelMain.Controls.Add(this.labelTelefono);
            this.panelMain.Controls.Add(this.textBoxTelefono);
            this.panelMain.Controls.Add(this.labelApellidos);
            this.panelMain.Controls.Add(this.textBoxApellidos);
            this.panelMain.Controls.Add(this.labelTitilePrestamo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelMain.Size = new System.Drawing.Size(800, 450);
            this.panelMain.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSubmit.Location = new System.Drawing.Point(502, 386);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(244, 39);
            this.buttonSubmit.TabIndex = 36;
            this.buttonSubmit.Text = "Realizar";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.btnListaCientes);
            this.panel1.Location = new System.Drawing.Point(13, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 35);
            this.panel1.TabIndex = 35;
            // 
            // btnListaCientes
            // 
            this.btnListaCientes.FlatAppearance.BorderSize = 0;
            this.btnListaCientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnListaCientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnListaCientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListaCientes.IconSize = 35;
            this.btnListaCientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaCientes.Location = new System.Drawing.Point(-1, 0);
            this.btnListaCientes.Name = "btnListaCientes";
            this.btnListaCientes.Size = new System.Drawing.Size(177, 35);
            this.btnListaCientes.TabIndex = 0;
            this.btnListaCientes.Text = "Lista De Clientes";
            this.btnListaCientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaCientes.UseVisualStyleBackColor = true;
            this.btnListaCientes.Click += new System.EventHandler(this.btnListaCientes_Click);
            // 
            // labelOcupacion
            // 
            this.labelOcupacion.AutoSize = true;
            this.labelOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOcupacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelOcupacion.Location = new System.Drawing.Point(29, 256);
            this.labelOcupacion.Name = "labelOcupacion";
            this.labelOcupacion.Size = new System.Drawing.Size(80, 17);
            this.labelOcupacion.TabIndex = 34;
            this.labelOcupacion.Text = "Ocupacion:";
            // 
            // textBoxOcupacion
            // 
            this.textBoxOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOcupacion.Location = new System.Drawing.Point(115, 253);
            this.textBoxOcupacion.Name = "textBoxOcupacion";
            this.textBoxOcupacion.Size = new System.Drawing.Size(244, 20);
            this.textBoxOcupacion.TabIndex = 33;
            // 
            // labelNacionalidad
            // 
            this.labelNacionalidad.AutoSize = true;
            this.labelNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNacionalidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNacionalidad.Location = new System.Drawing.Point(402, 130);
            this.labelNacionalidad.Name = "labelNacionalidad";
            this.labelNacionalidad.Size = new System.Drawing.Size(94, 17);
            this.labelNacionalidad.TabIndex = 32;
            this.labelNacionalidad.Text = "Nacionalidad:";
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNacionalidad.Location = new System.Drawing.Point(502, 127);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(244, 20);
            this.textBoxNacionalidad.TabIndex = 31;
            // 
            // labelDirecion
            // 
            this.labelDirecion.AutoSize = true;
            this.labelDirecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDirecion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDirecion.Location = new System.Drawing.Point(38, 296);
            this.labelDirecion.Name = "labelDirecion";
            this.labelDirecion.Size = new System.Drawing.Size(71, 17);
            this.labelDirecion.TabIndex = 30;
            this.labelDirecion.Text = "Direccion:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDireccion.Location = new System.Drawing.Point(115, 296);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(631, 71);
            this.textBoxDireccion.TabIndex = 29;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNombres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombres.Location = new System.Drawing.Point(40, 130);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(69, 17);
            this.labelNombres.TabIndex = 28;
            this.labelNombres.Text = "Nombres:";
            // 
            // textBoxNombes
            // 
            this.textBoxNombes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombes.Location = new System.Drawing.Point(115, 130);
            this.textBoxNombes.Multiline = true;
            this.textBoxNombes.Name = "textBoxNombes";
            this.textBoxNombes.Size = new System.Drawing.Size(244, 20);
            this.textBoxNombes.TabIndex = 27;
            // 
            // labelDocIdentidad
            // 
            this.labelDocIdentidad.AutoSize = true;
            this.labelDocIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDocIdentidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDocIdentidad.Location = new System.Drawing.Point(393, 172);
            this.labelDocIdentidad.Name = "labelDocIdentidad";
            this.labelDocIdentidad.Size = new System.Drawing.Size(103, 17);
            this.labelDocIdentidad.TabIndex = 26;
            this.labelDocIdentidad.Text = "Doc. Identidad:";
            // 
            // textBoxDocIdentidad
            // 
            this.textBoxDocIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDocIdentidad.Location = new System.Drawing.Point(502, 169);
            this.textBoxDocIdentidad.Name = "textBoxDocIdentidad";
            this.textBoxDocIdentidad.Size = new System.Drawing.Size(244, 20);
            this.textBoxDocIdentidad.TabIndex = 25;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEmail.Location = new System.Drawing.Point(450, 213);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(502, 210);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(244, 20);
            this.textBoxEmail.TabIndex = 23;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTelefono.Location = new System.Drawing.Point(41, 213);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(68, 17);
            this.labelTelefono.TabIndex = 22;
            this.labelTelefono.Text = "Telefono:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTelefono.Location = new System.Drawing.Point(115, 213);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(244, 20);
            this.textBoxTelefono.TabIndex = 21;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelApellidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelApellidos.Location = new System.Drawing.Point(40, 172);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(69, 17);
            this.labelApellidos.TabIndex = 20;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxApellidos.Location = new System.Drawing.Point(115, 172);
            this.textBoxApellidos.Multiline = true;
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(244, 20);
            this.textBoxApellidos.TabIndex = 19;
            // 
            // labelTitilePrestamo
            // 
            this.labelTitilePrestamo.AutoSize = true;
            this.labelTitilePrestamo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTitilePrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitilePrestamo.Location = new System.Drawing.Point(354, 9);
            this.labelTitilePrestamo.Name = "labelTitilePrestamo";
            this.labelTitilePrestamo.Size = new System.Drawing.Size(79, 23);
            this.labelTitilePrestamo.TabIndex = 17;
            this.labelTitilePrestamo.Text = "Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitilePrestamo;
        private System.Windows.Forms.Label labelNacionalidad;
        private System.Windows.Forms.TextBox textBoxNacionalidad;
        private System.Windows.Forms.Label labelDirecion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.TextBox textBoxNombes;
        private System.Windows.Forms.Label labelDocIdentidad;
        private System.Windows.Forms.TextBox textBoxDocIdentidad;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelOcupacion;
        private System.Windows.Forms.TextBox textBoxOcupacion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnListaCientes;
        private System.Windows.Forms.Button buttonSubmit;
    }
}