using System;
using System.Linq;
using System.Windows.Forms;
using CorteDeSucursales.Modelos;

namespace CorteDeSucursales.GUIs
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            new FrmConfigurar().ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            IniciarSecion();
        }
        private void IniciarSecion()
        {
            string sUser = txbUsuario.Text.ToUpper();
            string sPass = txbContraseña.Text.ToUpper();

            var usuario = Properties.Settings.Default.ConfigUsuarios.lUsuarios.FirstOrDefault(o=>o.sNombreUsuario == sUser && o.sContraseña == sPass);

            if (usuario != null)
            {
                this.Hide();

                bool cerrar=false;
                FrmCaptura frmCaptura = new FrmCaptura();

                while (cerrar == false)
                {
                    try
                    {
                        frmCaptura.ShowDialog();
                        cerrar = true;
                    }
                    catch (Exception ex)
                    {
                        Logger.AgregarLog(ex.Message);
                        MessageBox.Show("Por favor, cargue toda la información del corte...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Error de Nombre de usuario o contraseña...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}