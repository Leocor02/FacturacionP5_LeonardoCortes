namespace FacturacionP5_LeonardoCortes.Formularios
{
    partial class FrmUsuariosGestion
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
            this.components = new System.ComponentModel.Container();
            this.DgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.CIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEmailRespaldo = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtContrasennia = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiarForm = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaUsuarios
            // 
            this.DgvListaUsuarios.AllowUserToAddRows = false;
            this.DgvListaUsuarios.AllowUserToDeleteRows = false;
            this.DgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDUsuario,
            this.CNombre,
            this.CNombreUsuario,
            this.CCedula,
            this.CRol});
            this.DgvListaUsuarios.Location = new System.Drawing.Point(12, 43);
            this.DgvListaUsuarios.MultiSelect = false;
            this.DgvListaUsuarios.Name = "DgvListaUsuarios";
            this.DgvListaUsuarios.ReadOnly = true;
            this.DgvListaUsuarios.RowHeadersVisible = false;
            this.DgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaUsuarios.Size = new System.Drawing.Size(704, 202);
            this.DgvListaUsuarios.TabIndex = 0;
            this.DgvListaUsuarios.VirtualMode = true;
            this.DgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaUsuarios_CellClick);
            this.DgvListaUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaUsuarios_DataBindingComplete);
            // 
            // CIDUsuario
            // 
            this.CIDUsuario.DataPropertyName = "IDUsuario";
            this.CIDUsuario.HeaderText = "Código Usuario";
            this.CIDUsuario.Name = "CIDUsuario";
            this.CIDUsuario.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CNombreUsuario
            // 
            this.CNombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombreUsuario.DataPropertyName = "NombreUsuario";
            this.CNombreUsuario.HeaderText = "Email";
            this.CNombreUsuario.Name = "CNombreUsuario";
            this.CNombreUsuario.ReadOnly = true;
            this.CNombreUsuario.Width = 180;
            // 
            // CCedula
            // 
            this.CCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cédula";
            this.CCedula.Name = "CCedula";
            this.CCedula.ReadOnly = true;
            this.CCedula.Width = 150;
            // 
            // CRol
            // 
            this.CRol.DataPropertyName = "Rol";
            this.CRol.HeaderText = "Tipo Usuario";
            this.CRol.Name = "CRol";
            this.CRol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBoxTipoUsuario);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.TxtEmailRespaldo);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtContrasennia);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(325, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email Respaldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(345, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefono";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(58, 164);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(166, 20);
            this.TxtCedula.TabIndex = 18;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(337, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo Usuario";
            // 
            // CBoxTipoUsuario
            // 
            this.CBoxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTipoUsuario.FormattingEnabled = true;
            this.CBoxTipoUsuario.Location = new System.Drawing.Point(410, 159);
            this.CBoxTipoUsuario.Name = "CBoxTipoUsuario";
            this.CBoxTipoUsuario.Size = new System.Drawing.Size(152, 21);
            this.CBoxTipoUsuario.TabIndex = 15;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(410, 36);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(152, 20);
            this.TxtTelefono.TabIndex = 13;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtEmailRespaldo
            // 
            this.TxtEmailRespaldo.Location = new System.Drawing.Point(410, 81);
            this.TxtEmailRespaldo.Name = "TxtEmailRespaldo";
            this.TxtEmailRespaldo.Size = new System.Drawing.Size(152, 20);
            this.TxtEmailRespaldo.TabIndex = 11;
            this.TxtEmailRespaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailRespaldo_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(410, 120);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(152, 20);
            this.TxtPassword.TabIndex = 10;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // TxtContrasennia
            // 
            this.TxtContrasennia.AutoSize = true;
            this.TxtContrasennia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtContrasennia.Location = new System.Drawing.Point(342, 123);
            this.TxtContrasennia.Name = "TxtContrasennia";
            this.TxtContrasennia.Size = new System.Drawing.Size(61, 13);
            this.TxtContrasennia.TabIndex = 8;
            this.TxtContrasennia.Text = "Contraseña";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(62, 123);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(162, 20);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(62, 81);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(162, 20);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(62, 39);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(162, 20);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(41, 467);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(90, 45);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(173, 467);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 45);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(315, 467);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 45);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiarForm
            // 
            this.BtnLimpiarForm.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLimpiarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLimpiarForm.Location = new System.Drawing.Point(450, 467);
            this.BtnLimpiarForm.Name = "BtnLimpiarForm";
            this.BtnLimpiarForm.Size = new System.Drawing.Size(100, 45);
            this.BtnLimpiarForm.TabIndex = 5;
            this.BtnLimpiarForm.Text = "Limpiar Formulario";
            this.BtnLimpiarForm.UseVisualStyleBackColor = false;
            this.BtnLimpiarForm.Click += new System.EventHandler(this.BtnLimpiarForm_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCerrar.Location = new System.Drawing.Point(590, 467);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(90, 45);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(187, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.Green;
            this.TxtBuscar.Location = new System.Drawing.Point(242, 8);
            this.TxtBuscar.MaxLength = 20;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(175, 26);
            this.TxtBuscar.TabIndex = 8;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbVerActivos.Location = new System.Drawing.Point(565, 13);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(151, 20);
            this.CbVerActivos.TabIndex = 9;
            this.CbVerActivos.Text = "Ver Usuarios Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 539);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiarForm);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaUsuarios);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBoxTipoUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiarForm;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label TxtContrasennia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmailRespaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRol;
    }
}