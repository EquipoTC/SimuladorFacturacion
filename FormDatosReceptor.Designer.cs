/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 6/5/2024
 * Time: 20:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimuladorFacturacion
{
	partial class FormDatosReceptor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cbxCondicionIVA;
		private System.Windows.Forms.Label lblCondicionIVA;
		private System.Windows.Forms.Label lblCuit;
		private System.Windows.Forms.Label lblRazonSocial;
		private System.Windows.Forms.Label lblDomicilioComercial;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtCuit;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.TextBox txtDomicilioComercial;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Label lblCondicionVenta;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.cbxCondicionIVA = new System.Windows.Forms.ComboBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDomicilioComercial = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblCondicionVenta = new System.Windows.Forms.Label();
            this.ckbCondicionesVenta = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblDatosReceptor = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDomicilioComercial = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCondicionIVA = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCondicionIVA
            // 
            this.cbxCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCondicionIVA.FormattingEnabled = true;
            this.cbxCondicionIVA.Items.AddRange(new object[] {
            "IVA Responsable Inscripto",
            "Responsable Monotributo",
            "Monotributista Social",
            "Monotributista Trabajador Independiente Promovido"});
            this.cbxCondicionIVA.Location = new System.Drawing.Point(159, 66);
            this.cbxCondicionIVA.Name = "cbxCondicionIVA";
            this.cbxCondicionIVA.Size = new System.Drawing.Size(286, 21);
            this.cbxCondicionIVA.TabIndex = 0;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(159, 102);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(286, 20);
            this.txtCuit.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(159, 137);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(286, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtDomicilioComercial
            // 
            this.txtDomicilioComercial.Location = new System.Drawing.Point(159, 174);
            this.txtDomicilioComercial.Name = "txtDomicilioComercial";
            this.txtDomicilioComercial.Size = new System.Drawing.Size(286, 20);
            this.txtDomicilioComercial.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Location = new System.Drawing.Point(447, 212);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.Location = new System.Drawing.Point(19, 212);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblCondicionVenta
            // 
            this.lblCondicionVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblCondicionVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionVenta.Location = new System.Drawing.Point(14, 12);
            this.lblCondicionVenta.Name = "lblCondicionVenta";
            this.lblCondicionVenta.Size = new System.Drawing.Size(185, 23);
            this.lblCondicionVenta.TabIndex = 12;
            this.lblCondicionVenta.Text = "Condiciones de Venta";
            // 
            // ckbCondicionesVenta
            // 
            this.ckbCondicionesVenta.BackColor = System.Drawing.Color.White;
            this.ckbCondicionesVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ckbCondicionesVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCondicionesVenta.FormattingEnabled = true;
            this.ckbCondicionesVenta.Items.AddRange(new object[] {
            "Contado",
            "Tarjeta de Débito",
            "Tarjeta de Crédito",
            "Cuenta Corriente",
            "Cheque",
            "Ticket",
            "Otra"});
            this.ckbCondicionesVenta.Location = new System.Drawing.Point(15, 287);
            this.ckbCondicionesVenta.Name = "ckbCondicionesVenta";
            this.ckbCondicionesVenta.Size = new System.Drawing.Size(155, 147);
            this.ckbCondicionesVenta.TabIndex = 5;
            this.ckbCondicionesVenta.SelectedIndexChanged += new System.EventHandler(this.ckbCondicionesVenta_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(-983, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1550, 2);
            this.panel2.TabIndex = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCuit);
            this.panel1.Controls.Add(this.lblDatosReceptor);
            this.panel1.Controls.Add(this.lblRazonSocial);
            this.panel1.Controls.Add(this.lblDomicilioComercial);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblCondicionIVA);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 247);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCuit
            // 
            this.lblCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(55, 103);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCuit.Size = new System.Drawing.Size(100, 23);
            this.lblCuit.TabIndex = 2;
            this.lblCuit.Text = "CUIT";
            // 
            // lblDatosReceptor
            // 
            this.lblDatosReceptor.AutoSize = true;
            this.lblDatosReceptor.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosReceptor.Location = new System.Drawing.Point(157, 22);
            this.lblDatosReceptor.Name = "lblDatosReceptor";
            this.lblDatosReceptor.Size = new System.Drawing.Size(252, 20);
            this.lblDatosReceptor.TabIndex = 20;
            this.lblDatosReceptor.Text = "Datos del Receptor (Paso 3/4)";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(55, 138);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRazonSocial.Size = new System.Drawing.Size(100, 23);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblDomicilioComercial
            // 
            this.lblDomicilioComercial.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilioComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioComercial.Location = new System.Drawing.Point(19, 175);
            this.lblDomicilioComercial.Name = "lblDomicilioComercial";
            this.lblDomicilioComercial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDomicilioComercial.Size = new System.Drawing.Size(136, 23);
            this.lblDomicilioComercial.TabIndex = 4;
            this.lblDomicilioComercial.Text = "Domicilio Comercial";
            this.lblDomicilioComercial.Click += new System.EventHandler(this.lblDomicilioComercial_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(55, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblCondicionIVA
            // 
            this.lblCondicionIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblCondicionIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionIVA.Location = new System.Drawing.Point(12, 67);
            this.lblCondicionIVA.Name = "lblCondicionIVA";
            this.lblCondicionIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCondicionIVA.Size = new System.Drawing.Size(143, 23);
            this.lblCondicionIVA.TabIndex = 1;
            this.lblCondicionIVA.Text = "Condición frente al IVA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAnterior);
            this.panel3.Controls.Add(this.btnSiguiente);
            this.panel3.Controls.Add(this.lblCondicionVenta);
            this.panel3.Location = new System.Drawing.Point(-2, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 247);
            this.panel3.TabIndex = 121;
            // 
            // FormDatosReceptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ckbCondicionesVenta);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDomicilioComercial);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.cbxCondicionIVA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatosReceptor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Del Receptor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatosReceptor_FormClosing);
            this.Load += new System.EventHandler(this.FormDatosReceptorLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDatosReceptor_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label lblDatosReceptor;
        private System.Windows.Forms.CheckedListBox ckbCondicionesVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
