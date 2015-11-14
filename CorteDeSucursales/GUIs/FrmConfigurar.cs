using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace CorteDeSucursales.GUIs
{
    public partial class FrmConfigurar : DevExpress.XtraEditors.XtraForm
    {
        ModelosDeConfiguracion.Usuario usuarioSeleccionado;
        bool ModificarUsuario;

        public FrmConfigurar()
        {
            InitializeComponent();
        }

        private void FrmConfigurar_Load(object sender, EventArgs e)
        {
            InicializarConfiguraciones();            
        }
        private void InicializarConfiguraciones()
        {
            // Inicializar Configuración Microsip
            if (Properties.Settings.Default.ConfigMicrosip == null)
            {
                Properties.Settings.Default.ConfigMicrosip = new ModelosDeConfiguracion.Microsip();
            }
            else
            {
                var Microsip = Properties.Settings.Default.ConfigMicrosip;
                txbServidor.Text = Microsip.sServidor;
                txbBaseDeDatos.Text = Microsip.sBaseDeDatos;
                txbUsuario.Text = Microsip.sUsuario;
                txbContraseña.Text = Microsip.sContraseña;
                txbPuerto.Text = Microsip.iPuerto.ToString();
            }
            
            // Inicializar Usuarios
            
            if (Properties.Settings.Default.ConfigUsuarios== null)
            {
                Properties.Settings.Default.ConfigUsuarios = new ModelosDeConfiguracion.ListaDeUsuarios();
                Properties.Settings.Default.ConfigUsuarios.lUsuarios = new List<ModelosDeConfiguracion.Usuario>();
            }
            else
            {
                var Usuarios = Properties.Settings.Default.ConfigUsuarios.lUsuarios.OrderBy(o => o.sNombreUsuario).ToList();

                lbUsuarios.DataSource = Usuarios;
                lbUsuarios.DisplayMember = "sNombreUsuario";
            }
        }

        private void btnGuardarMicrosip_Click(object sender, EventArgs e)
        {
            GuardarDatosMicrosip();
        }
        private void GuardarDatosMicrosip()
        {
            var Microsip = Properties.Settings.Default.ConfigMicrosip;

            Microsip.sServidor = txbServidor.Text.ToUpper();
            Microsip.sBaseDeDatos = txbBaseDeDatos.Text.ToUpper();
            Microsip.sUsuario = txbUsuario.Text.ToUpper();
            Microsip.sContraseña = txbContraseña.Text;
            Microsip.iPuerto = Convert.ToInt32(txbPuerto.Text);

            Properties.Settings.Default.Save();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (ModificarUsuario == false)
            {
                GuardarDatosDeUsuario();
            }
            else
            {
                ModificarUsuarios();
            }
        }
        private void GuardarDatosDeUsuario()
        {
            if (ValidarDatosUsuario() == true)
            {
                ModelosDeConfiguracion.Usuario nuevoUsuario = new ModelosDeConfiguracion.Usuario();

                nuevoUsuario.sNombreCompleto = txbNombreCompleto.Text.ToUpper();
                nuevoUsuario.sNombreUsuario = txbNombreUsuario.Text.ToUpper();
                nuevoUsuario.sContraseña = txbContraseña1.Text.ToUpper();

                Properties.Settings.Default.ConfigUsuarios.lUsuarios.Add(nuevoUsuario);

                Properties.Settings.Default.Save();

                MessageBox.Show("El usuario ha sido dado de alta con exito!!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                lbUsuarios.Items.Clear();
                InicializarConfiguraciones();

                HabilitarDeshabilitarControles(false);
                btnGuardarUsuario.Enabled = false;
            }
        }
        private void ModificarUsuarios()
        {
            if (ValidarDatosUsuario() == true)
            {
                var usuario = Properties.Settings.Default.ConfigUsuarios.lUsuarios.Find(o => o.sNombreUsuario == usuarioSeleccionado.sNombreUsuario);
                usuario.sNombreCompleto = txbNombreCompleto.Text.ToUpper();
                usuario.sContraseña = txbContraseña1.Text.ToUpper();

                Properties.Settings.Default.Save();
                MessageBox.Show("El usuario ha sido modificado con exito!!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarDeshabilitarControles(false);
                btnGuardarUsuario.Enabled = false;
            }
        }

        private bool ValidarDatosUsuario()
        {
            if (txbNombreCompleto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor introduzca su nombre completo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbNombreUsuario.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor introduzca su nombre de usuario para usar la aplicacación...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbContraseña1.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe ser de al menos 6 caracteres...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (txbContraseña1.Text.ToUpper() != txbContraseña2.Text.ToUpper())
                {
                    MessageBox.Show("Las contraseñas no coinciden...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void HabilitarDeshabilitarControles(bool accion)
        {
            foreach (Control ctrl in pnlUsuarios.Controls)
            {
                if (ctrl.GetType() == typeof(TextEdit))
                {
                    ctrl.Text = string.Empty;
                    ctrl.Enabled = accion;
                }
            }
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario();
        }
        private void NuevoUsuario()
        {
            ModificarUsuario = false;

            HabilitarDeshabilitarControles(true);
            btnGuardarUsuario.Enabled = true;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario = true;

            usuarioSeleccionado = (ModelosDeConfiguracion.Usuario)lbUsuarios.SelectedItem;

            HabilitarDeshabilitarControles(true);

            txbNombreCompleto.Text = usuarioSeleccionado.sNombreCompleto;
            txbNombreUsuario.Text = usuarioSeleccionado.sNombreUsuario;           
            txbContraseña1.Text = usuarioSeleccionado.sContraseña;
            txbContraseña2.Text = usuarioSeleccionado.sContraseña;

            btnEliminarUsuario.Visible = true;
            btnGuardarUsuario.Enabled = true;
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }
        private void EliminarUsuario()
        {
            DialogResult dr = MessageBox.Show(string.Format("¿Desea eliminar al usuario '{0}'?" , usuarioSeleccionado.sNombreCompleto), "Eliminar",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Properties.Settings.Default.ConfigUsuarios.lUsuarios.Remove(usuarioSeleccionado);
                Properties.Settings.Default.Save();

                lbUsuarios.Items.Clear();
                InicializarConfiguraciones();

                NuevoUsuario();
                HabilitarDeshabilitarControles(false);
                btnGuardarUsuario.Enabled = false;
                btnEliminarUsuario.Visible = false;
            }
        }
    }
}