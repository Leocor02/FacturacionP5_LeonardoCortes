using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica.Models
{
    public class FacturaTipo
    {
        //En una estructura estandar de clase, primero se escriben los atributos simples.
        //Luego los atributos compuestos, después las operaciones (métodos y funciones)
        //normalmente, además se puede escribir en constructor si es necesario.

        //1. Atributos

        //Esta sería la forma estándar de escribir un atributo con su respectivo set y get
        //siguiendo la norma que dice que los privados inician con letra minúscula y
        // los respectivos get y set se expresan con la primera letra en mayúscula
        //NOTA: Esta forma forma cada vez se usa menos.
        private int iDFacturaTipo;
        public int IDFacturaTipo
        {
            get { return iDFacturaTipo; }
            set { iDFacturaTipo = value; }
        }

        //Otra opción para escribir una propiedad es por medio de la forma simplificada de c#
        public string Tipo { get; set; }

        //ahora escribimos las operaciones

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpFacturasTipoListar");
           
            return R;  
        
        }


    }
}
