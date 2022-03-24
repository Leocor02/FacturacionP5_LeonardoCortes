using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace FacturacionP5_LeonardoCortes.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        //Al igual que con cualquier otra clase se pueden escribir atributos para el form

        //en este caso vamos a tener un atributo de tipo usuario de fondo
        //el cual me permite manipular los cambios que el usuario haga en todo momento

        public Logica.Models.Usuario MiUsuarioLocal { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();

            //paso 1.1 y 1.2
            MiUsuarioLocal = new Logica.Models.Usuario(); 
            

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            ListarUsuariosActivos();
        }

        private void ListarUsuariosActivos()
        {
            //en la medida de lo posible deberíamos encapsular código que
            //tienda a ser reutilizable

            //paso 1 y 1.1 de SdUsuariosListarActivos
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            //Paso 2 y 2.5
            DataTable dt = MiUsuario.ListarActivos();   

            //mostrar datos en el dgv
            DgvListaUsuarios.DataSource = dt; 

            DgvListaUsuarios.ClearSelection();
            


        }


        private void FrmUsuariosGestion_Load_1(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            ListarUsuariosActivos();

            CargarRolesDeUsuarioEnCombo();

            LimpiarForm();

            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            //Activa solo el boton de agregar
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false; 
        }

        private void ActivarEditarYEliminar()
        {
            //Activa solo el boton de agregar
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void LimpiarForm()
        {
            //este método elimina todos los datos de los controles del formulario 
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtEmailRespaldo.Clear();
            TxtPassword.Clear();
            CBoxTipoUsuario.SelectedIndex = -1;

        }

        private void CargarRolesDeUsuarioEnCombo()
        {
            
            //crear un objeto de tipo usuario rol

            Logica.Models.UsuarioRol ObjRolDeUsuario =  new Logica.Models.UsuarioRol();

            DataTable ListaRoles = new DataTable();

            ListaRoles = ObjRolDeUsuario.Listar();

            CBoxTipoUsuario.ValueMember = "id";
            CBoxTipoUsuario.DisplayMember = "d";

            CBoxTipoUsuario.DataSource = ListaRoles;

            CBoxTipoUsuario.SelectedIndex = -1;
        }


        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmailRespaldo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPassword.Text.Trim()) &&
                CBoxTipoUsuario.SelectedIndex > -1
               )
            {
                //TO DO: Validar la contraseña SOLO en Agregar y en caso que se digite
                //cuando estemos en modo de edición
                R = true;
            }
            else
            {
                //retroalimentar al usuario para indicarle en que está fallando
                //debemos reevaluar cada cuandro de texto para ver si no lo digitó
                //y dar el aviso correspondiente

                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    MessageBox.Show("El nombre del usuario es requerido", "Error de validación", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("El email del usuario es requerido", "Error de validación", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("La cedula del usuario es requerida", "Error de validación", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    MessageBox.Show("El telefono del usuario es requerido", "Error de validación", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtEmailRespaldo.Text.Trim()))
                {
                    MessageBox.Show("El email de respaldo del usuario es requerido", "Error de validación", MessageBoxButtons.OK);
                    TxtEmailRespaldo.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                {
                    MessageBox.Show("La contraseña del usuario es requerida", "Error de validación", MessageBoxButtons.OK);
                    TxtPassword.Focus();
                    return false;
                }

                if (CBoxTipoUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("El tipo de usuario es requerido, ", "Error de validación", MessageBoxButtons.OK);
                    CBoxTipoUsuario.Focus();
                    return false;
                }
            }


            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Validacion.ValidarEmail(TxtEmail.Text);

            Validacion.ContrasenniaSegura(TxtPassword.Text);

            //en la secuencia nos explica, pero se debe realizar una serie de validaciones de
            //datos mínimos y de tipos y extenciones correctas a cada campo

            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("¿Está seguro de agregar el nuevo usuario {0}?", TxtNombre.Text.Trim());

                DialogResult RespuestaDelUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDelUsuario == DialogResult.Yes)
                {
                    //Temporal: se agregan los valores de los atributos del objeto local
                    MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                    MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
                    MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
                    MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
                    MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim();
                    MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
                    MiUsuarioLocal.MiRol.IDUsurioRol = Convert.ToInt32(CBoxTipoUsuario.SelectedValue);

                    //solo en este caso vamos a seguir la numeración de la secuencia "SqUsuarioAgregar"

                    //paso 1.1 y 1.2 está en el constructor

                    //paso 1.3 y 1.3.6
                    bool A = MiUsuarioLocal.ConsultarPorCedula();

                    //paso 1.4 y 1.4.6
                    bool B = MiUsuarioLocal.ConsultarPorEmail();

                    //paso 1.5
                    if (!A && !B)
                    {
                        //paso 1.6 y 1.6.6 y 1.7
                        if (MiUsuarioLocal.Agregar())
                        {
                            //paso 1.8
                            MessageBox.Show("Usaurio agregado correctamente!", ":)", MessageBoxButtons.OK);
                        }
                        else
                        {
                            //paso 1.8
                            MessageBox.Show("Ha ocurrido un error y el usuario no se guardó", ":(", MessageBoxButtons.OK);
                        }


                        ListarUsuariosActivos();

                        LimpiarForm();


                    }
                    else
                    {
                        //En este caso tenemos que indicar al usuario que la validación falló
                        if (A)
                        {
                            MessageBox.Show("Ya existe un usuario con la cédula digitada", "Erroe de validación", MessageBoxButtons.OK);
                            TxtCedula.Focus();
                            TxtCedula.SelectAll();
                        }
                        if (B)
                        {
                            MessageBox.Show("Ya existe un usuario con el email digitado", "Erroe de validación", MessageBoxButtons.OK);
                            TxtEmail.Focus();
                            TxtEmail.SelectAll();
                        }
                    }
                }
            }
        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaUsuarios.ClearSelection();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);   
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);
        }

        private void TxtEmailRespaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e);
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //el siguiente código permite que al hacer clic sobre una línea del dgv
            //los datos de ese usuario se muestren en el formulario y además el objeto
            //de usuario local también se carga con dicha info

            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaUsuarios.SelectedRows[0];

                int IdUsuarioSeleccionado = Convert.ToInt32(Fila.Cells["CIDUsuario"].Value);    

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IdUsuarioSeleccionado);

                if (MiUsuarioLocal.IDUsuario > 0)
                {
                    //se representa la info en los controles respectivos usando el obj MiUsuarioLocal como
                    //fuente de datos

                    LimpiarForm();

                    TxtCodigo.Text = MiUsuarioLocal.IDUsuario.ToString();
                    TxtNombre.Text = MiUsuarioLocal.Nombre;
                    TxtEmail.Text = MiUsuarioLocal.NombreUsuario;
                    TxtCedula.Text = MiUsuarioLocal.Cedula;
                    TxtTelefono.Text = MiUsuarioLocal.Telefono;
                    TxtEmailRespaldo.Text = MiUsuarioLocal.CorreoDeRespaldo;

                    CBoxTipoUsuario.SelectedValue = MiUsuarioLocal.MiRol.IDUsurioRol;

                    ActivarEditarYEliminar();
                }
            }
        }

        private void BtnLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


