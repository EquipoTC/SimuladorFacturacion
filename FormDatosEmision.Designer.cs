/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 6/5/2024
 * Time: 20:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimuladorFacturacion
{
	partial class FormDatosEmision
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dtpFechaComprobante;
		private System.Windows.Forms.Label lblFechaComprobante;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cbxConceptos;
		private System.Windows.Forms.Label lblConceptos;
		private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.Button btnAnterior;
		
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
            this.dtpFechaComprobante = new System.Windows.Forms.DateTimePicker();
            this.lblFechaComprobante = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxConceptos = new System.Windows.Forms.ComboBox();
            this.lblConceptos = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblDatosEmision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFechaComprobante
            // 
            this.dtpFechaComprobante.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaComprobante.Location = new System.Drawing.Point(194, 60);
            this.dtpFechaComprobante.Name = "dtpFechaComprobante";
            this.dtpFechaComprobante.Size = new System.Drawing.Size(177, 20);
            this.dtpFechaComprobante.TabIndex = 0;
            // 
            // lblFechaComprobante
            // 
            this.lblFechaComprobante.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaComprobante.Location = new System.Drawing.Point(19, 62);
            this.lblFechaComprobante.Name = "lblFechaComprobante";
            this.lblFechaComprobante.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFechaComprobante.Size = new System.Drawing.Size(164, 23);
            this.lblFechaComprobante.TabIndex = 1;
            this.lblFechaComprobante.Text = "Fecha del Comprobante";
            this.lblFechaComprobante.Click += new System.EventHandler(this.Label1Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbxConceptos
            // 
            this.cbxConceptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConceptos.FormattingEnabled = true;
            this.cbxConceptos.Items.AddRange(new object[] {
            "Productos",
            "Servicios",
            "Productos y Servicios"});
            this.cbxConceptos.Location = new System.Drawing.Point(194, 96);
            this.cbxConceptos.Name = "cbxConceptos";
            this.cbxConceptos.Size = new System.Drawing.Size(208, 21);
            this.cbxConceptos.TabIndex = 3;
            this.cbxConceptos.SelectedIndexChanged += new System.EventHandler(this.CbxConceptosSelectedIndexChanged);
            // 
            // lblConceptos
            // 
            this.lblConceptos.BackColor = System.Drawing.Color.Transparent;
            this.lblConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceptos.Location = new System.Drawing.Point(55, 97);
            this.lblConceptos.Name = "lblConceptos";
            this.lblConceptos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblConceptos.Size = new System.Drawing.Size(127, 23);
            this.lblConceptos.TabIndex = 4;
            this.lblConceptos.Text = "Conceptos a Incluír";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Location = new System.Drawing.Point(481, 176);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.Location = new System.Drawing.Point(22, 176);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnteriorClick);
            // 
            // lblDatosEmision
            // 
            this.lblDatosEmision.AutoSize = true;
            this.lblDatosEmision.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEmision.Location = new System.Drawing.Point(162, 19);
            this.lblDatosEmision.Name = "lblDatosEmision";
            this.lblDatosEmision.Size = new System.Drawing.Size(237, 20);
            this.lblDatosEmision.TabIndex = 13;
            this.lblDatosEmision.Text = "Datos de Emisión (Paso 2/4)";
            // 
            // FormDatosEmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimuladorFacturacion.Properties.Resources.Degradado_blanco_azul;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.lblDatosEmision);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblConceptos);
            this.Controls.Add(this.cbxConceptos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFechaComprobante);
            this.Controls.Add(this.dtpFechaComprobante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatosEmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos De Emision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatosEmision_FormClosing);
            this.Load += new System.EventHandler(this.FormDatosEmision_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDatosEmision_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label lblDatosEmision;
    }
}
