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
        public FrmUsuariosGestion()
        {
            InitializeComponent();
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
        }
    }
}
