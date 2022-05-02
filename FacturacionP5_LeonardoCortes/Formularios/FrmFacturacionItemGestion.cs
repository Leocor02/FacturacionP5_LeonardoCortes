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
    public partial class FrmFacturacionItemGestion : Form
    {

        DataTable ListaItems { get; set; }

        Logica.Models.Producto MiProducto { get; set; }

        public FrmFacturacionItemGestion()
        {
            InitializeComponent();

            ListaItems = new DataTable();
            MiProducto = new Logica.Models.Producto();
        }

        private void FrmFacturacionItemGestion_Load(object sender, EventArgs e)
        {
            LlenarListItems();
        }

        private void LlenarListItems()
        {
            ListaItems = new DataTable();

            ListaItems = MiProducto.Listar();

            DgvListaItems.DataSource = ListaItems;

            DgvListaItems.ClearSelection();
        }

        private void DgvListaItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaItems.ClearSelection();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //primero se valida que no pase el item en cero
            if (ValidarItem())
            {
                //procedemos con la carga del item en el detalle del formulario de facturación

                //como el formulario de la facturación es global y dentro de él tenemos un datatable con la estructura
                //del detalle, entonces vamos a crear una nueva fila de ese datatable y la llenamos con información
                //de la fila la selecionamos

                DataRow NuevaLineaDetalleEnFacturacion = ObjetosGlobales.MiFormFacturador.ListaDetallesLocal.NewRow();

                NuevaLineaDetalleEnFacturacion["IDProducto"] = MiProducto.IDProducto;

                NuevaLineaDetalleEnFacturacion["DescripcionItem"] = MiProducto.DescripcionProducto;

                NuevaLineaDetalleEnFacturacion["CantidadFacturada"] = TxtCantidad.Value;

                NuevaLineaDetalleEnFacturacion["PorcentajeDescuento"] = Convert.ToDecimal(TxtDescuento.Text.Trim());

                NuevaLineaDetalleEnFacturacion["PrecioUnitario"] = MiProducto.PrecioUnitario;

                //calculo del impuesto por línea
                decimal PorcentajeDescuento = Convert.ToDecimal(TxtDescuento.Text.Trim());

                decimal PrecioMenosDescuento = MiProducto.PrecioUnitario - ((MiProducto.PrecioUnitario * PorcentajeDescuento) / 100);
                decimal Impuestos = ((PrecioMenosDescuento * MiProducto.MiImpuesto.MontoImpuesto) / 100) * TxtCantidad.Value;
                NuevaLineaDetalleEnFacturacion["ImpuestosLinea"] = Impuestos;

                decimal TotalLinea = PrecioMenosDescuento * TxtCantidad.Value + Impuestos;
                NuevaLineaDetalleEnFacturacion["TotalLinea"] = TotalLinea;

                NuevaLineaDetalleEnFacturacion["SubTotalLinea"] = TxtCantidad.Value * PrecioMenosDescuento;

                //una vez que se han alimentado los datos para la línea, se procede a adjuntar al datatable en detalles
                //del form de facturación
                ObjetosGlobales.MiFormFacturador.ListaDetallesLocal.Rows.Add(NuevaLineaDetalleEnFacturacion);

                //Retornamos ok como respuesta al form de facturación
                DialogResult = DialogResult.OK;   
            }

            
            
        }

        private bool ValidarItem()
        {
            bool R = false;

            if (DgvListaItems.SelectedRows.Count == 1 && TxtCantidad.Value > 0)
            {
                //validación correcta
                R = true;
            }
            else
            {
                if (DgvListaItems.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un item de la lista", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                if (TxtCantidad.Value == 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero", "Error de validación", MessageBoxButtons.OK);
                    return false;
                } 
            }
            return R;

        }

        private void CalcularPrecioFinal(Logica.Models.Producto pProducto, decimal PorcentajeDescuento)
        {
            decimal PrecioConDescuento = pProducto.PrecioUnitario - ((pProducto.PrecioUnitario * PorcentajeDescuento) / 100);

            decimal PrecioConImpuesto = PrecioConDescuento + ((PrecioConDescuento * pProducto.MiImpuesto.MontoImpuesto) / 100);

            TxtPrecioFinal.Text = PrecioConImpuesto.ToString();
        }




        private void DgvListaItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaItems.SelectedRows.Count == 1)
            {
                DataGridViewRow FilaSelecciona = DgvListaItems.SelectedRows[0];

                int IdProductoSeleccionado = Convert.ToInt32(FilaSelecciona.Cells["CIDProducto"].Value);

                MiProducto = MiProducto.ConsultarPorID(IdProductoSeleccionado);

                if (MiProducto.IDProducto > 0)
                {
                    TxtIVA.Text = MiProducto.MiImpuesto.MontoImpuesto.ToString();
                    TxtPrecioUnitario.Text = MiProducto.PrecioUnitario.ToString();

                    //calcular el monto del precio final (tomando en cuenta el % de descuento)
                    CalcularPrecioFinal(MiProducto, Convert.ToDecimal(TxtDescuento.Text.Trim()));
                }
            
            }
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDescuento.Text.Trim()))
            {
                TxtDescuento.Text = "0";
                TxtDescuento.SelectAll();
            }
            else
            {
                CalcularPrecioFinal(MiProducto, Convert.ToDecimal(TxtDescuento.Text.Trim()));
            }
            
        }

        private void TxtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
