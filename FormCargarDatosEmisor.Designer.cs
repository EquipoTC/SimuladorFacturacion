namespace SimuladorFacturacion
{
    partial class FormCargarDatosEmisor
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.cbxCondicionIVA_Emisor = new System.Windows.Forms.ComboBox();
            this.txtDomicilioComercial_Emisor = new System.Windows.Forms.TextBox();
            this.txtRazonSocial_Emisor = new System.Windows.Forms.TextBox();
            this.txtCuit_Emisor = new System.Windows.Forms.TextBox();
            this.lblTituloCargarDatosEmisor = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDomicilioComercial = new System.Windows.Forms.Label();
            this.lblCondicionIVA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicioActividades = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContinuar.Location = new System.Drawing.Point(519, 286);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.Text = "Siguiente >";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // cbxCondicionIVA_Emisor
            // 
            this.cbxCondicionIVA_Emisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCondicionIVA_Emisor.FormattingEnabled = true;
            this.cbxCondicionIVA_Emisor.Items.AddRange(new object[] {
            "IVA Responsable Inscripto",
            "Responsable Monotributo",
            "Monotributista Social",
            "Monotributista Trabajador Independiente Promovido"});
            this.cbxCondicionIVA_Emisor.Location = new System.Drawing.Point(83, 216);
            this.cbxCondicionIVA_Emisor.Name = "cbxCondicionIVA_Emisor";
            this.cbxCondicionIVA_Emisor.Size = new System.Drawing.Size(202, 21);
            this.cbxCondicionIVA_Emisor.TabIndex = 3;
            // 
            // txtDomicilioComercial_Emisor
            // 
            this.txtDomicilioComercial_Emisor.Location = new System.Drawing.Point(175, 139);
            this.txtDomicilioComercial_Emisor.Name = "txtDomicilioComercial_Emisor";
            this.txtDomicilioComercial_Emisor.Size = new System.Drawing.Size(286, 20);
            this.txtDomicilioComercial_Emisor.TabIndex = 2;
            // 
            // txtRazonSocial_Emisor
            // 
            this.txtRazonSocial_Emisor.Location = new System.Drawing.Point(177, 56);
            this.txtRazonSocial_Emisor.Name = "txtRazonSocial_Emisor";
            this.txtRazonSocial_Emisor.Size = new System.Drawing.Size(286, 20);
            this.txtRazonSocial_Emisor.TabIndex = 0;
            // 
            // txtCuit_Emisor
            // 
            this.txtCuit_Emisor.Location = new System.Drawing.Point(175, 97);
            this.txtCuit_Emisor.Name = "txtCuit_Emisor";
            this.txtCuit_Emisor.Size = new System.Drawing.Size(286, 20);
            this.txtCuit_Emisor.TabIndex = 1;
            // 
            // lblTituloCargarDatosEmisor
            // 
            this.lblTituloCargarDatosEmisor.AutoSize = true;
            this.lblTituloCargarDatosEmisor.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCargarDatosEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCargarDatosEmisor.Location = new System.Drawing.Point(196, 14);
            this.lblTituloCargarDatosEmisor.Name = "lblTituloCargarDatosEmisor";
            this.lblTituloCargarDatosEmisor.Size = new System.Drawing.Size(237, 20);
            this.lblTituloCargarDatosEmisor.TabIndex = 13;
            this.lblTituloCargarDatosEmisor.Text = "Ingreso de Datos del Emisor";
            // 
            // lblCuit
            // 
            this.lblCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(114, 98);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCuit.Size = new System.Drawing.Size(54, 23);
            this.lblCuit.TabIndex = 15;
            this.lblCuit.Text = "CUIT";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(68, 57);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRazonSocial.Size = new System.Drawing.Size(100, 23);
            this.lblRazonSocial.TabIndex = 16;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblDomicilioComercial
            // 
            this.lblDomicilioComercial.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilioComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioComercial.Location = new System.Drawing.Point(32, 140);
            this.lblDomicilioComercial.Name = "lblDomicilioComercial";
            this.lblDomicilioComercial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDomicilioComercial.Size = new System.Drawing.Size(136, 23);
            this.lblDomicilioComercial.TabIndex = 17;
            this.lblDomicilioComercial.Text = "Domicilio Comercial";
            // 
            // lblCondicionIVA
            // 
            this.lblCondicionIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblCondicionIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionIVA.Location = new System.Drawing.Point(113, 190);
            this.lblCondicionIVA.Name = "lblCondicionIVA";
            this.lblCondicionIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCondicionIVA.Size = new System.Drawing.Size(143, 23);
            this.lblCondicionIVA.TabIndex = 14;
            this.lblCondicionIVA.Text = "Condición frente al IVA";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 190);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha de inicio de actividades";
            // 
            // dtpFechaInicioActividades
            // 
            this.dtpFechaInicioActividades.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioActividades.Location = new System.Drawing.Point(339, 217);
            this.dtpFechaInicioActividades.Name = "dtpFechaInicioActividades";
            this.dtpFechaInicioActividades.Size = new System.Drawing.Size(188, 20);
            this.dtpFechaInicioActividades.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(-465, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1550, 2);
            this.panel2.TabIndex = 121;
            // 
            // FormCargarDatosEmisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimuladorFacturacion.Properties.Resources.Degradado_blanco_azul;
            this.ClientSize = new System.Drawing.Size(606, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpFechaInicioActividades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblDomicilioComercial);
            this.Controls.Add(this.lblCondicionIVA);
            this.Controls.Add(this.lblTituloCargarDatosEmisor);
            this.Controls.Add(this.txtDomicilioComercial_Emisor);
            this.Controls.Add(this.txtRazonSocial_Emisor);
            this.Controls.Add(this.txtCuit_Emisor);
            this.Controls.Add(this.cbxCondicionIVA_Emisor);
            this.Controls.Add(this.btnContinuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCargarDatosEmisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Datos Del Emisor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCargarDatosEmisor_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormCargarDatosEmisor_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.ComboBox cbxCondicionIVA_Emisor;
        private System.Windows.Forms.TextBox txtDomicilioComercial_Emisor;
        private System.Windows.Forms.TextBox txtRazonSocial_Emisor;
        private System.Windows.Forms.TextBox txtCuit_Emisor;
        private System.Windows.Forms.Label lblTituloCargarDatosEmisor;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblDomicilioComercial;
        private System.Windows.Forms.Label lblCondicionIVA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioActividades;
        private System.Windows.Forms.Panel panel2;
    }
}