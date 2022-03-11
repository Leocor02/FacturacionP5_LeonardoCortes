using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionP5_LeonardoCortes.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        //Al igual que con cualquier otra clase se pueden escribir atributos para la misma

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
            


        }

        private void FrmUsuariosGestion_Load_1(object sender, EventArgs e)
        {
            ListarUsuariosActivos();

            CargarRolesDeUsuarioEnCombo();
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //en la secuencia nos explica, pero se debe realizar una serie de validaciones de
            //datos mínimos y de tipos y extenciones correctas a cada campo

            //TO DO: Agregar funcionalidad de validación

            //Temporal: se agregan los valores de los atributos del objeto local

            MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
            MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
            MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
            MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
            MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim(); 
            MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
            MiUsuarioLocal.MiRol.IDUsurioRol = Convert.ToInt32(CBoxTipoUsuario.SelectedValue);


            //solo en este caso vamos a seguir la numeración de la secuencia que "SeqUsuarioAgregar"

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

             
                
            }
        }
    }
}
