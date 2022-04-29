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
    public partial class FrmFacturacion : Form
    {

        public Logica.Models.Factura FacturaLocal { get; set; }

        //Para administrar los detalles de forma local, podríamos usar la composición del obj
        //factura local, sin embrago aquí usamos datagridview es más versatil implementar un
        //datatable local para almacenar la info de detalles. Posteriormente la data contenida en el datatable
        //de detalles pasará al obj compuesto para agregar esos detalles
        //en la tabla de muchos a muchos

        public  DataTable ListaDetallesLocal { get; set; }

        public FrmFacturacion()
        {
            InitializeComponent();

            FacturaLocal = new Logica.Models.Factura(); 
            
            ListaDetallesLocal = new DataTable();   
        }

        private void Totalizar()
        {
            if (ListaDetallesLocal != null && ListaDetallesLocal.Rows.Count > 0)
            {
                //se recorre cada linea del detalle y se sumarizan los montos correspondientes
                decimal Subt = 0;
                decimal Descuentos = 0;
                decimal Impuestos = 0;
                decimal Total = 0;


                foreach (DataRow item in ListaDetallesLocal.Rows)
                {
                    //se acumulan los datos en las variables de totalización
                    Subt += Convert.ToDecimal(item["CantidadFacturada"]) * Convert.ToDecimal(item["PrecioUnitario"]);

                    Descuentos += Subt * Convert.ToDecimal(item["PoecentajeDescuento"]) / 100;

                    Impuestos += Convert.ToDecimal(item["ImpuestosLinea"]);

                    Total += Convert.ToDecimal(item["TotalLinea"]);
                }

                //una vez tenemos las sumas se presentan en los txt correspondientes usando un formato fácil de leer para el usuario 

                LblSubTotal.Text = string.Format("{0:N2}", Subt);
                LblDescuentos.Text = string.Format("{0:N2}", Descuentos);
                LblImpuestos.Text = string.Format("{0:N2}", Impuestos);
                LblTotal.Text = string.Format("{0:N2}", Total);

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            CargarComboEmpresas();
            CargarComboFacturaTipos();  
            CargarComboUsuarios();

            Limpiar();
        }

        private void Limpiar()
        {
            CboxUsuario.SelectedValue = ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

            CboxTipoFactura.SelectedIndex = -1;

            DtpFechaFactura.Value = DateTime.Now.Date;

            TxtNotas.Clear();

            LblSubTotal.Text = "0";
            LblDescuentos.Text = "0";
            LblImpuestos.Text = "0";
            LblTotal.Text = "0";

            FacturaLocal = new Logica.Models.Factura();

            //el datagridview espera tener de fondo un datatable para mostrar datos.   
            //El formulario al iniciar no muestra datos y debería tener de fondo un dt
            //con la estructura necesaria y datos en blanco, para luego poder agregar líneas.

            ListaDetallesLocal = new DataTable();
            ListaDetallesLocal = FacturaLocal.AsignarEsquemaDetalle();

            DgvListaItems.DataSource = ListaDetallesLocal;

            TxtIdCliente.Clear();   
            LblNombreCliente.Text = "";
        }

        private void CargarComboUsuarios()
        {
            CboxUsuario.DisplayMember = "Nombre";
            CboxUsuario.ValueMember = "IDUsuario";
            CboxUsuario.DataSource = FacturaLocal.MiUsuario.ListarActivos();
            CboxUsuario.SelectedIndex = -1;
        }

        private void CargarComboEmpresas()
        {
            CboxEmpresa.DisplayMember = "desc";
            CboxEmpresa.ValueMember = "id";
            CboxEmpresa.DataSource = FacturaLocal.MiEmpresa.Listar();
            CboxEmpresa.SelectedIndex = -1;
        }

        private void CargarComboFacturaTipos()
        {
            CboxTipoFactura.DisplayMember = "desc";
            CboxTipoFactura.ValueMember = "id";
            CboxTipoFactura.DataSource = FacturaLocal.MiTipo.Listar();
            CboxTipoFactura.SelectedIndex = -1;
        }

        private void TxtIdCliente_DoubleClick(object sender, EventArgs e)
        {
            //Al dar doble clicken el cuadro de texto se abre la ventana de búsqueda de clientes
            Form MiFormBuscarCliente = new Formularios.FrmClienteSeleccionar();   

            DialogResult respuesta = MiFormBuscarCliente.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                LblNombreCliente.Text = FacturaLocal.MiCliente.Nombre;
                TxtIdCliente.Text = FacturaLocal.MiCliente.IDCliente.ToString();    
            }
            else 
            {
                LblNombreCliente.Text = "";
            }
        }

        private void BtnItemAgregar_Click(object sender, EventArgs e)
        {
            Form FormSeleccionDeItem = new FrmFacturacionItemGestion();

            DialogResult resp = FormSeleccionDeItem.ShowDialog();

            if (resp == DialogResult.OK)
            {
                //se ha seleccionado correctamente un item

                DgvListaItems.DataSource = ListaDetallesLocal;

                Totalizar();
            }
        }

        private void CargarDetalleDeFactura()
        {
            //cragar en la composición los detalles a partir del datatable de detalles local

            foreach (DataRow item in ListaDetallesLocal.Rows)
            {
                Logica.Models.FacturaDetalle detalle = new Logica.Models.FacturaDetalle();

                detalle.CantidadFacturada = Convert.ToDecimal(item["CantidadFacturada"]);
                detalle.DescripcionItem = Convert.ToString(item["DescripcionItem"]);
                detalle.ImpuestoLinea = Convert.ToDecimal(item["ImpuestosLinea"]);
                detalle.Miproducto.IDProducto = Convert.ToInt32(item["ImpuestosLinea"]);
                detalle.PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"]);
                detalle.SubTotalLinea = Convert.ToDecimal(item["SubTotalLinea"]);
                detalle.TotalLinea = Convert.ToDecimal(item["TotalLinea"]);

                FacturaLocal.DetalleItems.Add(detalle);
            }
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            //TO DO: efectuar las validaciones correpondientes ej, que la fecha no sea mayor a la actual y que
            //se haya seleccionado datos mínimos como cliente, usuario etc
            if (ListaDetallesLocal != null && ListaDetallesLocal.Rows.Count > 0)
            {
                //datos del encabezado
                FacturaLocal.MiCliente.IDCliente = Convert.ToInt32(TxtIdCliente.Text.Trim());
                FacturaLocal.MiTipo.IDFacturaTipo = Convert.ToInt32(CboxTipoFactura.SelectedValue);
                FacturaLocal.MiUsuario.IDUsuario = Convert.ToInt32(CboxUsuario.SelectedValue);
                FacturaLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(CboxEmpresa.SelectedValue);
                FacturaLocal.Fecha = DtpFechaFactura.Value.Date;
                FacturaLocal.Anotaciones = TxtNotas.Text.Trim();

                //datos del detalle
                CargarDetalleDeFactura();

                if (FacturaLocal.Agregar())
                {
                    MessageBox.Show("Factura guardad correctamente", ":)", MessageBoxButtons.OK);

                    //TO DO: llamado a reporte

                    Limpiar();
                }
            }
        }
    }   
}
