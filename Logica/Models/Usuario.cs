using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        //Atributos simples
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }    
        public string NombreUsuario { get; set; }
        public string Telefono { get; set; }
        public string CorreoDeRespaldo { get; set; }
        public string Contrasennia { get; set; }
        public string Cedula { get; set; }
        public bool Activo { get; set; }

        //Atributos compuestos
        UsuarioRol MiRol { get; set; }

        public Usuario()
        {
            MiRol = new UsuarioRol();
        }

        public bool Agregar()
        {
            bool R = false;
           
            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();
            
            //Paso 2.1 y 2.2
            Conexion MiCnn = new Conexion();    

            //Paso 2.3 y 2.4
            R = MiCnn.EjecutarSelect("SpUsuariosListarActivos"); 

            return R;
        }

        public DataTable ListarInctivos()
        {
            DataTable R = new DataTable();

            return R;
        }

    }
}
