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
    public partial class FrmClienteSeleccionar : Form
    {
        DataTable ListaClientes = new DataTable();

        public Logica.Models.Cliente MiCliente { get; set; }

        public FrmClienteSeleccionar()
        {
            InitializeComponent();

            MiCliente = new Logica.Models.Cliente();
        }

        private void FrmClienteSeleccionar_Load(object sender, EventArgs e)
        {
            LLenarListaClientes();
        }

        private void LLenarListaClientes(string Filtro = "")
        {
            ListaClientes = new DataTable();

            ListaClientes = MiCliente.Listar(true, Filtro);

            DgvLista.DataSource = ListaClientes;

            DgvLista.ClearSelection();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count ==1)
            {
                DataGridViewRow Fila = DgvLista.SelectedRows[0];

                int IdCliente = Convert.ToInt32(Fila.Cells["CIDCliente"].Value);
                string Nombre = Convert.ToString(Fila.Cells["CNombre"].Value);
                string Telefono = Convert.ToString(Fila.Cells["CTelefono"].Value);

                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.IDCliente = IdCliente;
                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.Nombre = Nombre;
                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.Telefono = Telefono;

                DialogResult = DialogResult.OK;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            //Cada vez que se presiona una tecla el timer se apaga
            TmrBuscarCliente.Enabled = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            //Al liberar la tecla volvemos a encender el timer de búsqueda
            TmrBuscarCliente.Enabled = true;
        }

        private void TmrBuscarCliente_Tick(object sender, EventArgs e)
        {
            //como no queremos que le código se ejecute cada 800 milisegundos debemos apagar el timer
            TmrBuscarCliente.Enabled = false;

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                string Filtro = TxtBuscar.Text.Trim();
                
                LLenarListaClientes(Filtro);
            }
            else
            {
                LLenarListaClientes();
            }
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }
    }
}
