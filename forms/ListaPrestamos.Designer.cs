namespace ControlPrestamos.forms
{
    partial class ListaPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelListaPrestamo = new System.Windows.Forms.Label();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.dataGridViewPrestamos);
            this.panelMain.Controls.Add(this.labelListaPrestamo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 450);
            this.panelMain.TabIndex = 0;
            // 
            // labelListaPrestamo
            // 
            this.labelListaPrestamo.AutoSize = true;
            this.labelListaPrestamo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelListaPrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelListaPrestamo.Location = new System.Drawing.Point(307, 9);
            this.labelListaPrestamo.Name = "labelListaPrestamo";
            this.labelListaPrestamo.Size = new System.Drawing.Size(168, 23);
            this.labelListaPrestamo.TabIndex = 17;
            this.labelListaPrestamo.Text = "Lista De Prestamo";
            // 
            // dataGridViewPrestamos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(59, 93);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(673, 288);
            this.dataGridViewPrestamos.TabIndex = 18;
            this.dataGridViewPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrestamos_CellContentClick);
            // 
            // ListaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "ListaPrestamos";
            this.Text = "ListaPrestamos";
            this.Load += new System.EventHandler(this.ListaPrestamos_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelListaPrestamo;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
    }
}