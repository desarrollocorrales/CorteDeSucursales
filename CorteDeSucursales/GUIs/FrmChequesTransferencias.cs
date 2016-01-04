using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CorteDeSucursales.Modelos;

namespace CorteDeSucursales.GUIs
{
    public partial class FrmChequesTransferencias : DevExpress.XtraEditors.XtraForm
    {
        public List<ChequeTransferencia> lstCheques;
        public List<ChequeTransferencia> lstTransferencias;
        public DialogResult Respuesta;
        public FrmChequesTransferencias()
        {
            InitializeComponent();
        }

        private void FrmChequesTransferencias_Load(object sender, EventArgs e)
        {
            if (lstCheques == null) 
            { 
                lstCheques = new List<ChequeTransferencia>();
                gridCheques.DataSource = lstCheques;
            }
            if (lstTransferencias == null) 
            { 
                lstTransferencias = new List<ChequeTransferencia>();
                gridTransferencias.DataSource = lstTransferencias;
            }
            Respuesta = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Respuesta = DialogResult.OK;
            this.Close();
        }

        private void AgregarRenglonAlGrid(DevExpress.XtraGrid.GridControl Grid, DevExpress.XtraGrid.Views.Grid.GridView GV)
        {
            var lstRegistros = (List<ChequeTransferencia>)Grid.DataSource;

            if (lstRegistros.Count >= 0)
            {
                ChequeTransferencia registro = new ChequeTransferencia();
                registro.Identificador = string.Empty;
                registro.Cliente = string.Empty;
                registro.Banco = string.Empty;
                registro.Importe = 0;

                lstRegistros.Add(registro);

                Grid.DataSource = lstRegistros;
                GV.RefreshData();
                GV.BestFitColumns();
            }
        }
        private void RemoverRenglonDelGrid(DevExpress.XtraGrid.GridControl Grid, DevExpress.XtraGrid.Views.Grid.GridView GV)
        {
            var lstRegistros = (List<ChequeTransferencia>)(Grid.DataSource);

            if (lstRegistros.Count > 0)
            {
                int i = GV.GetSelectedRows()[0];
                ChequeTransferencia registro = (ChequeTransferencia)GV.GetRow(i);

                lstRegistros.Remove(registro);

                Grid.DataSource = lstRegistros;
                GV.RefreshData();
            }
        }

        private void btnAgregarCheque_Click(object sender, EventArgs e)
        {
            AgregarRenglonAlGrid(gridCheques, gvCheques);
        }

        private void btnEliminarCheque_Click(object sender, EventArgs e)
        {
            RemoverRenglonDelGrid(gridCheques, gvCheques);
        }

        private void btnAgregarTransfer_Click(object sender, EventArgs e)
        {
            AgregarRenglonAlGrid(gridTransferencias, gvTransferencias);
        }

        private void btnEliminarTransfer_Click(object sender, EventArgs e)
        {
            RemoverRenglonDelGrid(gridTransferencias, gvTransferencias);
        }
    }
}