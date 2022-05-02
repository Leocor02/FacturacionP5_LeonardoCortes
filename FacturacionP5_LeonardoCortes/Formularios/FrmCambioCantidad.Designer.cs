namespace FacturacionP5_LeonardoCortes.Formularios
{
    partial class FrmCambioCantidad
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
            this.TxtModificarCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnAceptarCantidad = new System.Windows.Forms.Button();
            this.BtnCancelarCantidad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificarCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtModificarCantidad
            // 
            this.TxtModificarCantidad.Location = new System.Drawing.Point(61, 68);
            this.TxtModificarCantidad.Name = "TxtModificarCantidad";
            this.TxtModificarCantidad.Size = new System.Drawing.Size(120, 20);
            this.TxtModificarCantidad.TabIndex = 3;
            // 
            // BtnAceptarCantidad
            // 
            this.BtnAceptarCantidad.BackColor = System.Drawing.Color.Green;
            this.BtnAceptarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptarCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptarCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAceptarCantidad.Location = new System.Drawing.Point(49, 127);
            this.BtnAceptarCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptarCantidad.Name = "BtnAceptarCantidad";
            this.BtnAceptarCantidad.Size = new System.Drawing.Size(144, 32);
            this.BtnAceptarCantidad.TabIndex = 5;
            this.BtnAceptarCantidad.Text = "Aceptar";
            this.BtnAceptarCantidad.UseVisualStyleBackColor = false;
            this.BtnAceptarCantidad.Click += new System.EventHandler(this.BtnAceptarCantidad_Click);
            // 
            // BtnCancelarCantidad
            // 
            this.BtnCancelarCantidad.BackColor = System.Drawing.Color.Maroon;
            this.BtnCancelarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelarCantidad.Location = new System.Drawing.Point(49, 185);
            this.BtnCancelarCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelarCantidad.Name = "BtnCancelarCantidad";
            this.BtnCancelarCantidad.Size = new System.Drawing.Size(144, 32);
            this.BtnCancelarCantidad.TabIndex = 6;
            this.BtnCancelarCantidad.Text = "Cancelar";
            this.BtnCancelarCantidad.UseVisualStyleBackColor = false;
            this.BtnCancelarCantidad.Click += new System.EventHandler(this.BtnCancelarCantidad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad";
            // 
            // FrmCambioCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(234, 283);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelarCantidad);
            this.Controls.Add(this.BtnAceptarCantidad);
            this.Controls.Add(this.TxtModificarCantidad);
            this.Name = "FrmCambioCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio Cantidad";
            this.Load += new System.EventHandler(this.FrmCambioCantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificarCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown TxtModificarCantidad;
        private System.Windows.Forms.Button BtnAceptarCantidad;
        private System.Windows.Forms.Button BtnCancelarCantidad;
        private System.Windows.Forms.Label label1;
    }
}