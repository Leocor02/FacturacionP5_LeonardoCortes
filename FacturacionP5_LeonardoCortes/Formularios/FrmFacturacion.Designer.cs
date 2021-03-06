namespace FacturacionP5_LeonardoCortes.Formularios
{
    partial class FrmFacturacion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.PanEncabezado = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboxTipoFactura = new System.Windows.Forms.ComboBox();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboxUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CboxEmpresa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvListaItems = new System.Windows.Forms.DataGridView();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcionItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadFacturada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImpuestosLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnItemAgregar = new System.Windows.Forms.Button();
            this.BtnItemModificar = new System.Windows.Forms.Button();
            this.BtnItemEliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LblDescuentos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.LblImpuestos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.29386F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.70614F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PanEncabezado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvListaItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 572);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnFacturar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(815, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 95);
            this.panel1.TabIndex = 0;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Location = new System.Drawing.Point(12, 57);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(103, 29);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFacturar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFacturar.BackColor = System.Drawing.Color.Green;
            this.BtnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFacturar.Location = new System.Drawing.Point(12, 3);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(103, 30);
            this.BtnFacturar.TabIndex = 0;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = false;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // PanEncabezado
            // 
            this.PanEncabezado.BackColor = System.Drawing.Color.DarkGray;
            this.PanEncabezado.Controls.Add(this.label6);
            this.PanEncabezado.Controls.Add(this.TxtNotas);
            this.PanEncabezado.Controls.Add(this.label5);
            this.PanEncabezado.Controls.Add(this.CboxTipoFactura);
            this.PanEncabezado.Controls.Add(this.LblNombreCliente);
            this.PanEncabezado.Controls.Add(this.TxtIdCliente);
            this.PanEncabezado.Controls.Add(this.label4);
            this.PanEncabezado.Controls.Add(this.CboxUsuario);
            this.PanEncabezado.Controls.Add(this.label3);
            this.PanEncabezado.Controls.Add(this.label2);
            this.PanEncabezado.Controls.Add(this.DtpFechaFactura);
            this.PanEncabezado.Controls.Add(this.label1);
            this.PanEncabezado.Controls.Add(this.CboxEmpresa);
            this.PanEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanEncabezado.Location = new System.Drawing.Point(3, 3);
            this.PanEncabezado.Name = "PanEncabezado";
            this.PanEncabezado.Size = new System.Drawing.Size(806, 120);
            this.PanEncabezado.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Notas:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNotas.Location = new System.Drawing.Point(442, 35);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(349, 79);
            this.TxtNotas.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo Factura:";
            // 
            // CboxTipoFactura
            // 
            this.CboxTipoFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboxTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoFactura.FormattingEnabled = true;
            this.CboxTipoFactura.Location = new System.Drawing.Point(85, 88);
            this.CboxTipoFactura.MaximumSize = new System.Drawing.Size(304, 0);
            this.CboxTipoFactura.Name = "CboxTipoFactura";
            this.CboxTipoFactura.Size = new System.Drawing.Size(285, 21);
            this.CboxTipoFactura.TabIndex = 9;
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(204, 69);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(93, 13);
            this.LblNombreCliente.TabIndex = 8;
            this.LblNombreCliente.Text = "Nombre de cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtIdCliente.Location = new System.Drawing.Point(85, 62);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(113, 20);
            this.TxtIdCliente.TabIndex = 7;
            this.TxtIdCliente.DoubleClick += new System.EventHandler(this.TxtIdCliente_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // CboxUsuario
            // 
            this.CboxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxUsuario.FormattingEnabled = true;
            this.CboxUsuario.Location = new System.Drawing.Point(86, 30);
            this.CboxUsuario.MaxDropDownItems = 12;
            this.CboxUsuario.MaximumSize = new System.Drawing.Size(304, 0);
            this.CboxUsuario.Name = "CboxUsuario";
            this.CboxUsuario.Size = new System.Drawing.Size(284, 21);
            this.CboxUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // DtpFechaFactura
            // 
            this.DtpFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaFactura.Location = new System.Drawing.Point(442, 3);
            this.DtpFechaFactura.Name = "DtpFechaFactura";
            this.DtpFechaFactura.Size = new System.Drawing.Size(349, 20);
            this.DtpFechaFactura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa:";
            // 
            // CboxEmpresa
            // 
            this.CboxEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxEmpresa.FormattingEnabled = true;
            this.CboxEmpresa.Location = new System.Drawing.Point(86, 3);
            this.CboxEmpresa.MaximumSize = new System.Drawing.Size(304, 0);
            this.CboxEmpresa.Name = "CboxEmpresa";
            this.CboxEmpresa.Size = new System.Drawing.Size(284, 21);
            this.CboxEmpresa.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FacturacionP5_LeonardoCortes.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(815, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DgvListaItems
            // 
            this.DgvListaItems.AllowUserToAddRows = false;
            this.DgvListaItems.AllowUserToDeleteRows = false;
            this.DgvListaItems.AllowUserToOrderColumns = true;
            this.DgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CDescripcionItem,
            this.CCantidadFacturada,
            this.CPrecioUnitario,
            this.CPorcentajeDescuento,
            this.CSubTotalLinea,
            this.CImpuestosLinea,
            this.CTotalLinea});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaItems.Location = new System.Drawing.Point(3, 129);
            this.DgvListaItems.Name = "DgvListaItems";
            this.DgvListaItems.ReadOnly = true;
            this.DgvListaItems.RowHeadersVisible = false;
            this.DgvListaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaItems.Size = new System.Drawing.Size(806, 339);
            this.DgvListaItems.TabIndex = 4;
            this.DgvListaItems.VirtualMode = true;
            // 
            // CIDProducto
            // 
            this.CIDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDProducto.DataPropertyName = "IDProducto";
            this.CIDProducto.HeaderText = "Código item";
            this.CIDProducto.Name = "CIDProducto";
            this.CIDProducto.ReadOnly = true;
            this.CIDProducto.Width = 75;
            // 
            // CDescripcionItem
            // 
            this.CDescripcionItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcionItem.DataPropertyName = "DescripcionItem";
            this.CDescripcionItem.HeaderText = "Descripción";
            this.CDescripcionItem.Name = "CDescripcionItem";
            this.CDescripcionItem.ReadOnly = true;
            // 
            // CCantidadFacturada
            // 
            this.CCantidadFacturada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidadFacturada.DataPropertyName = "CantidadFacturada";
            this.CCantidadFacturada.HeaderText = "Cantidad";
            this.CCantidadFacturada.Name = "CCantidadFacturada";
            this.CCantidadFacturada.ReadOnly = true;
            this.CCantidadFacturada.Width = 70;
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CPrecioUnitario.HeaderText = "Precio unit";
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            this.CPrecioUnitario.ReadOnly = true;
            // 
            // CPorcentajeDescuento
            // 
            this.CPorcentajeDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPorcentajeDescuento.DataPropertyName = "PorcentajeDescuento";
            this.CPorcentajeDescuento.HeaderText = "% Desc";
            this.CPorcentajeDescuento.Name = "CPorcentajeDescuento";
            this.CPorcentajeDescuento.ReadOnly = true;
            this.CPorcentajeDescuento.Width = 50;
            // 
            // CSubTotalLinea
            // 
            this.CSubTotalLinea.DataPropertyName = "SubTotalLinea";
            this.CSubTotalLinea.HeaderText = "Sub Total";
            this.CSubTotalLinea.Name = "CSubTotalLinea";
            this.CSubTotalLinea.ReadOnly = true;
            // 
            // CImpuestosLinea
            // 
            this.CImpuestosLinea.DataPropertyName = "ImpuestosLinea";
            this.CImpuestosLinea.HeaderText = "Impuestos";
            this.CImpuestosLinea.Name = "CImpuestosLinea";
            this.CImpuestosLinea.ReadOnly = true;
            // 
            // CTotalLinea
            // 
            this.CTotalLinea.DataPropertyName = "TotalLinea";
            this.CTotalLinea.HeaderText = "TOTAL";
            this.CTotalLinea.Name = "CTotalLinea";
            this.CTotalLinea.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BtnItemAgregar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnItemModificar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnItemEliminar, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(815, 129);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(124, 339);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // BtnItemAgregar
            // 
            this.BtnItemAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnItemAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnItemAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItemAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItemAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnItemAgregar.Image = global::FacturacionP5_LeonardoCortes.Properties.Resources.add_item_icon_png_7_removebg_preview2;
            this.BtnItemAgregar.Location = new System.Drawing.Point(3, 3);
            this.BtnItemAgregar.Name = "BtnItemAgregar";
            this.BtnItemAgregar.Size = new System.Drawing.Size(118, 78);
            this.BtnItemAgregar.TabIndex = 0;
            this.BtnItemAgregar.Text = "Agregar";
            this.BtnItemAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnItemAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnItemAgregar.UseVisualStyleBackColor = false;
            this.BtnItemAgregar.Click += new System.EventHandler(this.BtnItemAgregar_Click);
            // 
            // BtnItemModificar
            // 
            this.BtnItemModificar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnItemModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnItemModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItemModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItemModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnItemModificar.Location = new System.Drawing.Point(3, 87);
            this.BtnItemModificar.Name = "BtnItemModificar";
            this.BtnItemModificar.Size = new System.Drawing.Size(118, 78);
            this.BtnItemModificar.TabIndex = 1;
            this.BtnItemModificar.Text = "Modificar";
            this.BtnItemModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnItemModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnItemModificar.UseVisualStyleBackColor = false;
            this.BtnItemModificar.Click += new System.EventHandler(this.BtnItemModificar_Click);
            // 
            // BtnItemEliminar
            // 
            this.BtnItemEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnItemEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnItemEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItemEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItemEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnItemEliminar.Location = new System.Drawing.Point(3, 171);
            this.BtnItemEliminar.Name = "BtnItemEliminar";
            this.BtnItemEliminar.Size = new System.Drawing.Size(118, 78);
            this.BtnItemEliminar.TabIndex = 2;
            this.BtnItemEliminar.Text = "Eliminar";
            this.BtnItemEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnItemEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnItemEliminar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 474);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(806, 95);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.LblSubTotal, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.95506F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.04494F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(155, 89);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "SUB TOTAL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSubTotal.Location = new System.Drawing.Point(3, 32);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(149, 57);
            this.LblSubTotal.TabIndex = 1;
            this.LblSubTotal.Text = "0";
            this.LblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.LblDescuentos, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(164, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.95506F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.04494F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(155, 89);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // LblDescuentos
            // 
            this.LblDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescuentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDescuentos.Location = new System.Drawing.Point(3, 32);
            this.LblDescuentos.Name = "LblDescuentos";
            this.LblDescuentos.Size = new System.Drawing.Size(149, 57);
            this.LblDescuentos.TabIndex = 2;
            this.LblDescuentos.Text = "0";
            this.LblDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "DESCUENTOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.LblImpuestos, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(325, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.95506F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.04494F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(155, 89);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // LblImpuestos
            // 
            this.LblImpuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImpuestos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblImpuestos.Location = new System.Drawing.Point(3, 32);
            this.LblImpuestos.Name = "LblImpuestos";
            this.LblImpuestos.Size = new System.Drawing.Size(149, 57);
            this.LblImpuestos.TabIndex = 3;
            this.LblImpuestos.Text = "0";
            this.LblImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "IMPUESTOS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.LblTotal, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(486, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.95506F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.04494F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(317, 89);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // LblTotal
            // 
            this.LblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Gold;
            this.LblTotal.Location = new System.Drawing.Point(3, 32);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(311, 57);
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "TOTAL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(942, 572);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(915, 457);
            this.Name = "FrmFacturacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURACION";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanEncabezado.ResumeLayout(false);
            this.PanEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Panel PanEncabezado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboxTipoFactura;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvListaItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnItemAgregar;
        private System.Windows.Forms.Button BtnItemModificar;
        private System.Windows.Forms.Button BtnItemEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblDescuentos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblImpuestos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcionItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadFacturada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotalLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImpuestosLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLinea;
    }
}