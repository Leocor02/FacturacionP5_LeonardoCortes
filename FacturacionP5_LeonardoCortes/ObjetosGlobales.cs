using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionP5_LeonardoCortes
{
    public static class ObjetosGlobales
    {
        //esta clase se 'auto instancia' al momento de inicializar la aplicación
        //los atirbutos y funciones que sean públicas serán visibles en la
        //globalidad de la aplicación.

        public static Form MiFormularioPrincipal = new Formularios.FrmMDIPrincipal();   

        public static Formularios.FrmUsuariosGestion MiFormDeGestionDeUsuarios = new Formularios.FrmUsuariosGestion();



    }
}
