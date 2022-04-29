using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int IDProducto {  get; set; }
        public string CodigoBarras { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal CantidadEnStock { get; set; }
        public decimal PrecioUnitario { get; set; }

        //Atributos compuestos
        public UnidadMedida MiunidadMedida { get;}
        public ProductoCategoria MiCategoria { get; set; }
        public Impuesto MiImpuesto { get; set; }

        //Constructor

        public Producto()
        {
            MiunidadMedida = new UnidadMedida();
            MiCategoria = new ProductoCategoria();  
            MiImpuesto = new Impuesto();
        }

        //Funciones  y métodos
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
        public bool ConsultarPorCodigoDeBarras()
        {
            bool R = false;

            return R;
        }
        public Producto ConsultarPorID(int pIdProducto)
        {
            Producto R = new Producto();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@id", pIdProducto));

            DataTable Datos = new DataTable();

            Datos = MyCnn.EjecutarSelect("SpProductosConsultarPorId");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                DataRow MisDatos = Datos.Rows[0];

                R.IDProducto = Convert.ToInt32(MisDatos["IDProducto"]);
                R.DescripcionProducto = Convert.ToString(MisDatos["DescripcionProducto"]);
                R.CantidadEnStock = Convert.ToDecimal(MisDatos["CantidadEnStock"]);
                R.PrecioUnitario = Convert.ToDecimal(MisDatos["PrecioUnitario"]);
                R.MiImpuesto.IDImpuesto = Convert.ToInt32(MisDatos["IDImpuesto"]);
                R.MiCategoria.IDProductoCategoria = Convert.ToInt32(MisDatos["IDProductoCategoria"]);
                R.MiunidadMedida.IDUnidad = Convert.ToInt32(MisDatos["IDUnidad"]);

                R.CodigoBarras = Convert.ToString(MisDatos["CodigoBarras"]);

                R.MiunidadMedida.Unidad = Convert.ToString(MisDatos["MiunidadMedida"]);
                R.MiCategoria.Categoria = Convert.ToString(MisDatos["Categoria"]);
                
                R.MiImpuesto.CodigoImpuesto = Convert.ToString(MisDatos["CodigoImpuesto"]);
                R.MiImpuesto.ImpuestoNombre = Convert.ToString(MisDatos["ImpuestoNombre"]);
                R.MiImpuesto.MontoImpuesto = Convert.ToDecimal(MisDatos["MontoImpuesto"]);
            }

            return R;
        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpProductosListar");

            return R;
        }


    }
}
