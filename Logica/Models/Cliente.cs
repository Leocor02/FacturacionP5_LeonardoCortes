using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        //Atributos simples
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        //Atributos compuestos
        ClienteTipo MiTipo { get; set; }

        //Constructor de la clase para instanciar el atributo compueso simple
        public Cliente()
        {
            //Dentro de este constructor instanciamos los objetos compuestos
            MiTipo = new ClienteTipo();

        }

        //Operaciones de la clase
        //Esta función "agregar()" se usa acá con fines didácticos, ya que pasamos los valores
        //por medio de patrámetros.

        public bool Agregar(string pNombre, string pCedula, string pTelefono = "", string pEmail = "")
        {
            bool R = false;
            //Cuando se usa esta forma el paso de valores se realiza por acá
            Nombre = pNombre;
            Cedula = pCedula;   
            Telefono = pTelefono;
            Email = pEmail;

            //TO DO: ejecutar el SP para el insert en tabla cliente
            return R;
        }

        public bool Editar(int pIDCliente, string pNombre, string pCedula, string pTelefono = "", string pEmail = "")
        {
            bool R = false;

            return R;
        }

        public bool Eliminar(int pIDCliente)
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula(string pCedula)
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID(int pIDCliente)
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            return R;
        }

    }
}
