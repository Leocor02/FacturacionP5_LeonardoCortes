using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {
        public int IDFactura {  get; set; } 
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuentos { get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public string Anotaciones { get; set; }

        //composiciones simples
        public FacturaTipo MiTipo { get; set; }
        public Empresa MiEmpresa { get; set; }
        public Cliente MiCliente {  get; set; }
        public Usuario MiUsuario {  get; set;}

        //composiciones multiples
        public List<FacturaDetalle> DetalleItems { get; set; }

        public Factura()
        {
            MiTipo = new FacturaTipo();
            MiEmpresa = new Empresa();
            MiCliente = new Cliente();
            MiUsuario = new Usuario();
            DetalleItems = new List<FacturaDetalle>();  
        }

        public bool Agregar()
        {
            bool R = false;

            //cuando se agrega un objrto tipo encabezado detalle se hace en dos partes
            //primero el encabezado y obtenemos el ID recién creado.
            //luego con iteración por detaalle se guardan los detalles

            Conexion MyCnnEncabezado = new Conexion();

            Totalizar();

            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@numero", this.Numero));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@fecha", this.Fecha));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@subtotal", this.SubTotal));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@descuentos", this.Descuentos));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@subtotal2", this.SubTotal2));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@Impuestos", this.Impuestos));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@total", this.Total));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@notas", this.Anotaciones));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@idtipo", this.MiTipo.IDFacturaTipo));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@idcliente", this.MiCliente.IDCliente));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@idusuario", this.MiUsuario.IDUsuario));
            MyCnnEncabezado.ListaParametros.Add(new SqlParameter("@idempresa", this.MiEmpresa.IDEmpresa));

            Object Retorno = MyCnnEncabezado.EjecutarConRetornoEscalar("SpFacturaAgregarEncabezado");

            int IdFacturaRecienCreada = 0;

            if (Retorno != null)
            {
                IdFacturaRecienCreada = Convert.ToInt32(Retorno.ToString());

                //una vez que se tiene el ID de la factura se pueden agregar los detalles

                foreach (FacturaDetalle item in this.DetalleItems)
                {
                    //se hace un insert por cada iteración en detalles

                    Conexion MyCnnDetalle = new Conexion();

                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@idfactura", IdFacturaRecienCreada));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@idproducto", item.Miproducto.IDProducto));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@descripcion", item.DescripcionItem));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@cantidad", item.CantidadFacturada));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@precio", item.PrecioUnitario));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@porcentajedescuento", item.PorcentajeDescuento));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@subtotallinea", item.SubTotalLinea));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@impuestoslinea", item.ImpuestoLinea));
                    MyCnnDetalle.ListaParametros.Add(new SqlParameter("@total", item.TotalLinea));

                    MyCnnDetalle.EjecutarUpdateDeleteInsert("SpFacturaAgregarDetalle");
                }

                R = true;
            }

            return R;
        }

        public DataTable ConsultarNumero(int pNumeroFactura)
        {
            DataTable R = new DataTable();
        
            return R;
        }

        public DataTable ListarPorRangoDeFechas(DateTime pFechaInicial, DateTime pFechaFinal)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarPorCliente(int pIDCliente)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarPorUsuario(int pIDUsuario)
        {
            DataTable R = new DataTable();

            return R;
        }

        private void Totalizar()
        {
            this.Numero = 10; //TO DO: aumentar este número de forma que no queden huecos en consecutivo
            this.SubTotal = 0;
            this.SubTotal2 = 0;
            this.Impuestos = 0;
            this.Total = 0;

        }

        public DataTable AsignarEsquemaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpFacturaDetalleEsquema", true);

            R.PrimaryKey = null;
            return R;
        }

    }
}
