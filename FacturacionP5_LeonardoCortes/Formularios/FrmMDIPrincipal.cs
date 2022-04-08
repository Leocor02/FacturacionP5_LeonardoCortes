﻿using System;
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
    public partial class FrmMDIPrincipal : Form
    {
        public FrmMDIPrincipal()
        {
            InitializeComponent();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormDeGestionDeUsuarios.Visible)
            {
                ObjetosGlobales.MiFormDeGestionDeUsuarios = new FrmUsuariosGestion();
                ObjetosGlobales.MiFormDeGestionDeUsuarios.Show();
            }
        }

        private void FrmMDIPrincipal_Load(object sender, EventArgs e)
        {
            //muestra en la barra inferior el usuario que se ha logueado
            string UsuarioLogueado = string.Format("{0}({1};{2})",
                ObjetosGlobales.MiUsuarioGlobal.Nombre,
                ObjetosGlobales.MiUsuarioGlobal.NombreUsuario,
                ObjetosGlobales.MiUsuarioGlobal.MiRol.Rol);    

            LblUsuarioLogueado.Text = UsuarioLogueado;

            //ahora revisamos el tipo de rol y si es facturador ocultamos ciertas opciones

            switch (ObjetosGlobales.MiUsuarioGlobal.MiRol.IDUsurioRol)
            {
                case 1:
                    //Es un admin no se debe hacer bloqueo por el momento
                    break;
                case 2:
                    //Es un facturador y se debe ocultar opciones del menú
                    MnuUsuariosGestion.Enabled = false; 
                    MnuProveedoresGestion.Enabled = false;
                    MnuProductosGestion.Enabled = false;
                    MnuEmpresaGestion.Enabled = false;
                    break;
            }

            //Activamos el timer
            TmrEstablecerFechaHora.Enabled = true; 
        }

        private void FrmMDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TmrEstablecerFechaHora_Tick(object sender, EventArgs e)
        {
            LblFechaHora.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();  
        }

        private void MnuFacturar_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormFacturador.Visible)
            {
                ObjetosGlobales.MiFormFacturador = new FrmFacturacion();
                ObjetosGlobales.MiFormFacturador.Show();
            }
        }
    }
}
