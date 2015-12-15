using System;
using System.Collections.Generic;
using System.Drawing;
using CorteDeSucursales.Modelos;

namespace CorteDeSucursales.GUIs
{
    public partial class FrmAnalisisCorte : DevExpress.XtraEditors.XtraForm
    {
        public DateTime hoy;
        private decimal dTotalVentas = 0, dTotalDepositos = 0, dTotalCuadre;

        public List<Total> lstTotales;

        public FrmAnalisisCorte(List<Total> lstTotales)
        {
            InitializeComponent();
            this.lstTotales = lstTotales;
        }

        private void FrmAnalisisCorte_Load(object sender, EventArgs e)
        {
            CargarDatosVentas();
            CargarDatosDepositos();
            CargarResultados();
        }
        private void CargarDatosVentas()
        {
            decimal dTotalPV, dTotalFacturacion, dTotalCobranza, dTotalFaltantesSobrantes;

            dTotalPV = (lstTotales.Find(o => o.Tipo == TipoDeTotal.PuntoDeVenta)).dTotal;
            dTotalFacturacion = (lstTotales.Find(o => o.Tipo == TipoDeTotal.Facturacion)).dTotal;
            dTotalCobranza = (lstTotales.Find(o => o.Tipo == TipoDeTotal.Cobranza)).dTotal;
            dTotalFaltantesSobrantes = (lstTotales.Find(o => o.Tipo == TipoDeTotal.FaltanteSobrante)).dTotal;

            lblTotalPV.Text = dTotalPV.ToString("c");
            lblTotalPV2.Text = lblTotalPV.Text;
            lblTotalFacturacion.Text = dTotalFacturacion.ToString("c");
            lblTotalCobranza.Text = dTotalCobranza.ToString("c");
            lblTotalFaltantesSobrantes.Text = dTotalFaltantesSobrantes.ToString("c");

            lblTotalVentaDelDia.Text = (dTotalPV + dTotalFacturacion).ToString("c");
            lblTotalADepositar.Text = (dTotalPV + dTotalCobranza + dTotalFaltantesSobrantes).ToString("c");
            dTotalVentas = dTotalPV + dTotalCobranza + dTotalFaltantesSobrantes;
        }
        private void CargarDatosDepositos()
        {
            decimal dTotalCajaFuerte, dTotalTarjetas, dTotalMasEfectivos, dTotalCheques;
            dTotalCajaFuerte = (lstTotales.Find(o => o.Tipo == TipoDeTotal.CajaFuerte)).dTotal;
            dTotalTarjetas = (lstTotales.Find(o => o.Tipo == TipoDeTotal.Tarjetas)).dTotal;
            dTotalMasEfectivos = (lstTotales.Find(o => o.Tipo == TipoDeTotal.MasEfectivos)).dTotal;
            dTotalCheques = (lstTotales.Find(o => o.Tipo == TipoDeTotal.Cheques)).dTotal;

            lblTotalCajaFuerte.Text = dTotalCajaFuerte.ToString("c");
            lblTotalTarjetas.Text = dTotalTarjetas.ToString("c");
            lblTotalMasEfectivos.Text = dTotalMasEfectivos.ToString("c");
            lblTotalEfectivo.Text = (dTotalCajaFuerte + dTotalMasEfectivos + dTotalTarjetas).ToString("c");
            
            lblTotalCheques.Text = dTotalCheques.ToString("c");
            lblTotalEfectivo2.Text = lblTotalEfectivo.Text;
            lblDepositoyRetenidos.Text = (dTotalCajaFuerte + dTotalMasEfectivos + dTotalTarjetas + dTotalCheques).ToString("c");
            dTotalDepositos = dTotalCajaFuerte + dTotalMasEfectivos + dTotalTarjetas + dTotalCheques;
        }
        private void CargarResultados()
        {
            decimal dTotalDiferencia = dTotalVentas - dTotalDepositos;

            if ((dTotalDiferencia >= 0 && dTotalDiferencia <= 1) || (dTotalDiferencia <= 0 && dTotalDiferencia >= -1))
            {
                lblAdvertencia.Text = "¡ FELICIDADES !";
                lblAdvertencia.ForeColor = Color.Green;
                lblResultado.Text = "¡¡¡ CORTE CORRECTO !!!";
                lblResultado.ForeColor = Color.Orange;
                lblDiferncia.Text = dTotalDiferencia.ToString("c");
            }
            else if (dTotalDiferencia > 1)
            {
                lblAdvertencia.Text = "¡¡¡ ADVERTENCIA !!!";
                lblAdvertencia.ForeColor = Color.Red;
                lblResultado.Text = "¡¡¡ CORTE INCORRECTO !!!";
                lblResultado.ForeColor = Color.Red;
                lblDiferncia.Text = dTotalDiferencia.ToString("c");
                lblDiferncia.ForeColor = Color.Red;
            }
            else
            {
                lblAdvertencia.Text = "¡¡¡ ADVERTENCIA !!!";
                lblAdvertencia.ForeColor = Color.Red;
                lblResultado.Text = "¡¡¡ CORTE INCORRECTO !!!";
                lblResultado.ForeColor = Color.Red;
                lblDiferncia.Text = dTotalDiferencia.ToString("c");
                lblDiferncia.ForeColor = Color.Black;
            }
        }

        private void btnDetallesCxC_Click(object sender, EventArgs e)
        {
            FrmDetallesCxCIngresos frmDetalles = new FrmDetallesCxCIngresos();
            frmDetalles.hoy = hoy;

            frmDetalles.ShowDialog();
        }

        private void btnCuadrar_Click(object sender, EventArgs e)
        {
            Cuadrar();
        }
        private void Cuadrar()
        {
            dTotalCuadre = - (dTotalVentas - dTotalDepositos);
            lblDiferncia.Text = 0.ToString("c");
            lblDiferncia.ForeColor = Color.Black;

            lblCuadre.Text = dTotalCuadre.ToString("c");
        }
    }
}