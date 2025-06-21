/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 13/5/2024
 * Time: 20:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimuladorFacturacion
{
	partial class FormPuntosVenta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTituloPuntosventa;
		private System.Windows.Forms.Label lblTipoComprobante;
		private System.Windows.Forms.TextBox txtPuntosVenta;
		private System.Windows.Forms.ComboBox cbxTipoComprobante;
		private System.Windows.Forms.Label lblPuntosVenta;
		private System.Windows.Forms.Button btnContinuar;
		
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
            this.lblTituloPuntosventa = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.txtPuntosVenta = new System.Windows.Forms.TextBox();
            this.cbxTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblPuntosVenta = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloPuntosventa
            // 
            this.lblTituloPuntosventa.AutoSize = true;
            this.lblTituloPuntosventa.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloPuntosventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPuntosventa.Location = new System.Drawing.Point(76, 33);
            this.lblTituloPuntosventa.Name = "lblTituloPuntosventa";
            this.lblTituloPuntosventa.Size = new System.Drawing.Size(438, 20);
            this.lblTituloPuntosventa.TabIndex = 12;
            this.lblTituloPuntosventa.Text = "Puntos de Venta y Tipos de Comprobantes (Paso 1/4)";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoComprobante.Location = new System.Drawing.Point(46, 128);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTipoComprobante.Size = new System.Drawing.Size(140, 23);
            this.lblTipoComprobante.TabIndex = 11;
            this.lblTipoComprobante.Text = "Tipo de Comprobante";
            // 
            // txtPuntosVenta
            // 
            this.txtPuntosVenta.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPuntosVenta.Location = new System.Drawing.Point(192, 86);
            this.txtPuntosVenta.Name = "txtPuntosVenta";
            this.txtPuntosVenta.Size = new System.Drawing.Size(256, 20);
            this.txtPuntosVenta.TabIndex = 0;
            // 
            // cbxTipoComprobante
            // 
            this.cbxTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoComprobante.FormattingEnabled = true;
            this.cbxTipoComprobante.Items.AddRange(new object[] {
            "Factura A",
            "Nota de Débito A",
            "Nota de Crédito A",
            "Recibo A",
            "Factura B",
            "Nota de Débito B",
            "Nota de Crédito B",
            "Recibo B",
            "Factura T",
            "Nota de Débito T",
            "Nota de Crédito T",
            "Factura de Crédito Electrónica MiPyMEs (FCE) A",
            "Nota de Débito Electrónica MiPyMEs (FCE) A",
            "Nota de Crédito Electrónica MiPyMEs (FCE) A",
            "Factura de Crédito Electrónica MiPyMEs (FCE) B",
            "Nota de Débito Electrónica MiPyMEs (FCE) B",
            "Nota de Crédito Electrónica MiPyMEs (FCE) B"});
            this.cbxTipoComprobante.Location = new System.Drawing.Point(192, 127);
            this.cbxTipoComprobante.Name = "cbxTipoComprobante";
            this.cbxTipoComprobante.Size = new System.Drawing.Size(256, 21);
            this.cbxTipoComprobante.TabIndex = 1;
            // 
            // lblPuntosVenta
            // 
            this.lblPuntosVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosVenta.Location = new System.Drawing.Point(19, 87);
            this.lblPuntosVenta.Name = "lblPuntosVenta";
            this.lblPuntosVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPuntosVenta.Size = new System.Drawing.Size(167, 23);
            this.lblPuntosVenta.TabIndex = 8;
            this.lblPuntosVenta.Text = "Puntos de Venta a Utilizar";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContinuar.Location = new System.Drawing.Point(506, 201);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.Text = "Siguiente >";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.BtnContinuarClick);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.Location = new System.Drawing.Point(12, 201);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // FromPuntosVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimuladorFacturacion.Properties.Resources.Degradado_blanco_azul;
            this.ClientSize = new System.Drawing.Size(593, 236);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblTituloPuntosventa);
            this.Controls.Add(this.lblTipoComprobante);
            this.Controls.Add(this.txtPuntosVenta);
            this.Controls.Add(this.cbxTipoComprobante);
            this.Controls.Add(this.lblPuntosVenta);
            this.Controls.Add(this.btnContinuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromPuntosVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntos de Venta y Tipos de Comprobantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromPuntosVenta_FormClosing);
            this.Load += new System.EventHandler(this.FromPuntosVenta_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FromPuntosVenta_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnAnterior;
    }
}
