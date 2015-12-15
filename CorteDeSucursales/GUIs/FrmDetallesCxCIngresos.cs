using System;
using System.Collections.Generic;
using System.Linq;
using CorteDeSucursales.DAL;
using CorteDeSucursales.Modelos;

namespace CorteDeSucursales.GUIs
{
    public partial class FrmDetallesCxCIngresos : DevExpress.XtraEditors.XtraForm
    {
        public DateTime hoy;

        public FrmDetallesCxCIngresos()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            FBDAL dal = new FBDAL();
            List<DoctosCC> lstCxC = dal.ObtenerDocumentosDeCobranza(hoy);
            List<DoctosCC> lstSource = new List<DoctosCC>();
            foreach (string concepto in Properties.Settings.Default.ConceptosEfectivo)
            {
                lstSource.AddRange(lstCxC.FindAll(o => o.iIDConcepto == Convert.ToInt32(concepto)));
            }

            gridCxC.DataSource = lstSource.OrderBy(o=>o.dTotal).ToList();
            gvCxC.BestFitColumns();

            var lstPV = dal.ObtenerIngresos(hoy);
            gridIngresos.DataSource = lstPV.OrderBy(o => o.Total).ToList();
            gvIngresos.BestFitColumns();

            decimal diferencia = lstSource.Sum(o => o.dTotal) - lstPV.Sum(o => o.Total);
            lblDiferencia.Text = string.Format("Diferencia: {0}", diferencia.ToString("c"));
        }

        private void FrmDetallesCxCIngresos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}