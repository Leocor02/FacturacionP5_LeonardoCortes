﻿namespace FacturacionP5_LeonardoCortes.Formularios
{
    partial class FrmFacturacionItemGestion
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DgvListaItems = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboSumarCantidades = new System.Windows.Forms.CheckBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadEnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigoDeBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPrecioFinal = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Brown;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Location = new System.Drawing.Point(422, 414);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(144, 32);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Green;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAceptar.Location = new System.Drawing.Point(22, 414);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(144, 32);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 6;
            // 
            // DgvListaItems
            // 
            this.DgvListaItems.AllowUserToAddRows = false;
            this.DgvListaItems.AllowUserToDeleteRows = false;
            this.DgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CDescripcionProducto,
            this.CCantidadEnStock,
            this.CPrecioUnitario,
            this.CCodigoDeBarras});
            this.DgvListaItems.Location = new System.Drawing.Point(13, 57);
            this.DgvListaItems.MultiSelect = false;
            this.DgvListaItems.Name = "DgvListaItems";
            this.DgvListaItems.ReadOnly = true;
            this.DgvListaItems.RowHeadersVisible = false;
            this.DgvListaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaItems.Size = new System.Drawing.Size(567, 206);
            this.DgvListaItems.TabIndex = 7;
            this.DgvListaItems.VirtualMode = true;
            this.DgvListaItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaItems_CellClick);
            this.DgvListaItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaItems_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPrecioFinal);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtIVA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPrecioUnitario);
            this.groupBox1.Controls.Add(this.CboSumarCantidades);
            this.groupBox1.Controls.Add(this.TxtDescuento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // CboSumarCantidades
            // 
            this.CboSumarCantidades.AutoSize = true;
            this.CboSumarCantidades.Location = new System.Drawing.Point(10, 82);
            this.CboSumarCantidades.Name = "CboSumarCantidades";
            this.CboSumarCantidades.Size = new System.Drawing.Size(240, 17);
            this.CboSumarCantidades.TabIndex = 4;
            this.CboSumarCantidades.Text = "Sumar Cantidad si producto ya está en la lista";
            this.CboSumarCantidades.UseVisualStyleBackColor = true;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.Location = new System.Drawing.Point(97, 36);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(80, 26);
            this.TxtDescuento.TabIndex = 3;
            this.TxtDescuento.Text = "0";
            this.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDescuento.TextChanged += new System.EventHandler(this.TxtDescuento_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "% Descuento";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(10, 37);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(66, 26);
            this.TxtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(202, 37);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.ReadOnly = true;
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(95, 26);
            this.TxtPrecioUnitario.TabIndex = 5;
            this.TxtPrecioUnitario.Text = "0";
            this.TxtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio Unitario";
            // 
            // TxtIVA
            // 
            this.TxtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIVA.Location = new System.Drawing.Point(316, 37);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.ReadOnly = true;
            this.TxtIVA.Size = new System.Drawing.Size(80, 26);
            this.TxtIVA.TabIndex = 7;
            this.TxtIVA.Text = "0";
            this.TxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "% IVA";
            // 
            // CIDProducto
            // 
            this.CIDProducto.DataPropertyName = "IDProducto";
            this.CIDProducto.HeaderText = "Código";
            this.CIDProducto.Name = "CIDProducto";
            this.CIDProducto.ReadOnly = true;
            // 
            // CDescripcionProducto
            // 
            this.CDescripcionProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcionProducto.DataPropertyName = "DescripcionProducto";
            this.CDescripcionProducto.HeaderText = "Descripción";
            this.CDescripcionProducto.Name = "CDescripcionProducto";
            this.CDescripcionProducto.ReadOnly = true;
            // 
            // CCantidadEnStock
            // 
            this.CCantidadEnStock.DataPropertyName = "CantidadEnStock";
            this.CCantidadEnStock.HeaderText = "Stock";
            this.CCantidadEnStock.Name = "CCantidadEnStock";
            this.CCantidadEnStock.ReadOnly = true;
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CPrecioUnitario.HeaderText = "Precio Unitario";
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            this.CPrecioUnitario.ReadOnly = true;
            // 
            // CCodigoDeBarras
            // 
            this.CCodigoDeBarras.DataPropertyName = "CodigoDeBarras";
            this.CCodigoDeBarras.HeaderText = "Código de barras";
            this.CCodigoDeBarras.Name = "CCodigoDeBarras";
            this.CCodigoDeBarras.ReadOnly = true;
            // 
            // TxtPrecioFinal
            // 
            this.TxtPrecioFinal.AutoSize = true;
            this.TxtPrecioFinal.Location = new System.Drawing.Point(426, 20);
            this.TxtPrecioFinal.Name = "TxtPrecioFinal";
            this.TxtPrecioFinal.Size = new System.Drawing.Size(62, 13);
            this.TxtPrecioFinal.TabIndex = 10;
            this.TxtPrecioFinal.Text = "Precio Final";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(422, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(95, 26);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmFacturacionItemGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 459);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaItems);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmFacturacionItemGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Producto";
            this.Load += new System.EventHandler(this.FrmFacturacionItemGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DgvListaItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CboSumarCantidades;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadEnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoDeBarras;
        private System.Windows.Forms.Label TxtPrecioFinal;
        private System.Windows.Forms.TextBox textBox3;
    }
}