using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CorteDeSucursales.DAL;
using CorteDeSucursales.Modelos;
using ModelosDeConfiguracion;

namespace CorteDeSucursales.GUIs
{
    public partial class FrmCaptura : DevExpress.XtraEditors.XtraForm
    {
        private List<Total> lstTotales;
        private DateTime hoy;
        public Usuario user;
        FrmChequesTransferencias frmChequesTransferencias;

        public FrmCaptura()
        {
            InitializeComponent();
        }

        private void FrmCaptura_Load(object sender, EventArgs e)
        {
            Inicializar();
            frmChequesTransferencias = new FrmChequesTransferencias();
        }
        private void Inicializar()
        {
            hoy = DateTime.Today;
            lblFecha.Text = hoy.ToString("dd-MMM-yyyy").ToUpper();
            gridMasEfectivos.DataSource = new List<DoctosPV>();
            lstTotales = new List<Total>();
        }

        private void btnPV_Click(object sender, EventArgs e)
        {
            CargarPV();
        }
        private void CargarPV()
        {            
            FBDAL dal = new FBDAL();
            List<Cajas> lstCajas = dal.ObtenerCajas();
            List<DoctosPV> lstDoctosPV = dal.ObtenerDocumentosDePuntoDeVenta(hoy);
            List<PuntoDeVenta> lstVentas = new List<PuntoDeVenta>();

            PuntoDeVenta venta;

            foreach (Cajas caja in lstCajas)
            {
                venta = new PuntoDeVenta();
                List<DoctosPV> lstVentasPorCaja = lstDoctosPV.FindAll(o => o.CajaID == caja.ID);
                if (lstVentasPorCaja.Count != 0)
                {
                    //La caja si tiene movimientos
                    decimal importe = lstVentasPorCaja.Sum(o => o.Total);
                    venta.Caja = caja.Nombre;
                    venta.Importe = importe;

                    lstVentas.Add(venta);
                }
            }

            gridPV.DataSource=lstVentas;
            gvPV.BestFitColumns();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            CargarFacturacion();
        }
        private void CargarFacturacion()
        {
            FBDAL dal = new FBDAL();
            List<DoctosVE> lstDoctosVE = dal.ObtenerDocumentosDeFacturacion(hoy);
            List<DoctosVE> lstSource = new List<DoctosVE>();

            DoctosVE ResultadosFacturacion = new DoctosVE();
            ResultadosFacturacion.Folio = "Documentos Facturados";
            ResultadosFacturacion.dNeto = lstDoctosVE.Sum(o => o.dNeto);
            ResultadosFacturacion.dImpuestos = lstDoctosVE.Sum(o => o.dImpuestos);

            lstSource.Add(ResultadosFacturacion);

            gridFacturacion.DataSource = lstSource;
            gvFacturacion.BestFitColumns();
        }

        private void btnCobranza_Click(object sender, EventArgs e)
        {
            CargarCobranza();
        }
        private void CargarCobranza()
        {
            FBDAL dal = new FBDAL();
            List<ConceptosCC> lstConceptosCC = dal.ObtenerConceptosCC();
            List<DoctosCC> lstDoctosCC = dal.ObtenerDocumentosDeCobranza(hoy);
            List<DoctosCC> lstSource = new List<DoctosCC>();

            DoctosCC ResultadosCobranza;         

            foreach (ConceptosCC concepto in lstConceptosCC)
            {
                List<DoctosCC> lstAux = lstDoctosCC.FindAll(o => o.iIDConcepto == concepto.iID);
                if (Properties.Settings.Default.ConceptosEfectivo.Contains(concepto.iID.ToString()) == true ||
                    Properties.Settings.Default.ConceptosCheques.Contains(concepto.iID.ToString()) == true)
                {
                    ResultadosCobranza = new DoctosCC();
                    ResultadosCobranza.iIDConcepto = concepto.iID;
                    ResultadosCobranza.sConcepto = concepto.sConcepto;
                    ResultadosCobranza.dNeto = lstAux.Sum(o => o.dNeto);
                    ResultadosCobranza.dImpuestos = lstAux.Sum(o => o.dImpuestos);

                    lstSource.Add(ResultadosCobranza);
                }
            }

            gridCobranza.DataSource = lstSource;
            gvCobranza.BestFitColumns();
        }

        private void btnRetiruos_Click(object sender, EventArgs e)
        {
            CargarRetiros();
        }
        private void CargarRetiros()
        {
            FBDAL dal = new FBDAL();
            
            List<DoctosPV> lstDoctosPV = dal.ObtenerRetirosDeCajas(hoy);
            
            GridCajaFuerte.DataSource = lstDoctosPV;
            gvCajaFuerte.BestFitColumns();
        }

        private void btnAgregarRetiro_Click(object sender, EventArgs e)
        {
            AgregarRetiro();                        
        }
        private void AgregarRetiro()
        {
            try
            {
                var lstDoctosPV = (List<DoctosPV>)(GridCajaFuerte.DataSource);

                if (lstDoctosPV.Count > 0)
                {
                    DoctosPV doctos = new DoctosPV();
                    doctos.CajaID = 0;
                    doctos.NombreCaja = "Retiro " + (lstDoctosPV.Count + 1);
                    doctos.Neto = 0;
                    doctos.Impuesto = 0;

                    lstDoctosPV.Add(doctos);

                    GridCajaFuerte.DataSource = lstDoctosPV;
                    gvCajaFuerte.RefreshData();
                }
            }
            catch (InvalidCastException ex) 
            {
                Logger.AgregarLog(ex.Message);
                MessageBox.Show("Primero debe cargar los datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverRetiro_Click(object sender, EventArgs e)
        {
            RemoverRetiro();
        }
        private void RemoverRetiro()
        {
            var lstDoctosPV = (List<DoctosPV>)(GridCajaFuerte.DataSource);

            if (lstDoctosPV.Count > 0)
            {
                int i = gvCajaFuerte.GetSelectedRows()[0];
                DoctosPV retiro = (DoctosPV)gvCajaFuerte.GetRow(i);

                lstDoctosPV.Remove(retiro);

                GridCajaFuerte.DataSource = lstDoctosPV;
                gvCajaFuerte.RefreshData();
            }
        }

        private void btnAgregarImporteTarjeta_Click(object sender, EventArgs e)
        {
            AgregarImporteTarjeta();
        }
        private void AgregarImporteTarjeta()
        {
            var lstDoctosPV = (List<DoctosPV>)(gridTarjetas.DataSource);

            if (lstDoctosPV.Count >= 0)
            {
                DoctosPV doctos = new DoctosPV();
                doctos.CajaID = 0;
                doctos.NombreCaja = "Terminal " + (lstDoctosPV.Count + 1);
                doctos.Neto = 0;
                doctos.Impuesto = 0;

                lstDoctosPV.Add(doctos);

                gridTarjetas.DataSource = lstDoctosPV;
                gvTarjetas.RefreshData();
            }
        }

        private void btnRemoverImporteTarjeta_Click(object sender, EventArgs e)
        {
            RemoverImporteTarjeta();
        }
        private void RemoverImporteTarjeta()
        {
            var lstDoctosPV = (List<DoctosPV>)(GridCajaFuerte.DataSource);

            if (lstDoctosPV.Count > 0)
            {
                int i = gvTarjetas.GetSelectedRows()[0];
                DoctosPV retiro = (DoctosPV)gvTarjetas.GetRow(i);

                lstDoctosPV.Remove(retiro);

                gridTarjetas.DataSource = lstDoctosPV;
                gvTarjetas.RefreshData();
            }
        }

        private void btnAgregarMasEfectivos_Click(object sender, EventArgs e)
        {
            AgregarRenglonAlGrid(gridMasEfectivos, gvMasEfectivos);
        }
        private void btnRemoverMasEfectivos_Click(object sender, EventArgs e)
        {
            RemoverRenglonDelGrid(gridMasEfectivos, gvMasEfectivos);
        }
        
        private void btnAgregarFaltantesSobrantes_Click(object sender, EventArgs e)
        {
            AgregarRenglonAlGrid(gridFaltantesSobrantes, gvFaltantesSobrantes);
        }
        private void btnRemoverFaltantesSobrantes_Click(object sender, EventArgs e)
        {
            RemoverRenglonDelGrid(gridFaltantesSobrantes, gvFaltantesSobrantes);
        }

        private void AgregarRenglonAlGrid(DevExpress.XtraGrid.GridControl Grid, DevExpress.XtraGrid.Views.Grid.GridView GV)
        {
            var lstDoctosPV = (List<DoctosPV>)(Grid.DataSource);

            if (lstDoctosPV.Count >= 0)
            {
                DoctosPV doctos = new DoctosPV();
                doctos.CajaID = 0;
                doctos.NombreCaja = "Concepto " + (lstDoctosPV.Count + 1);
                doctos.Neto = 0;
                doctos.Impuesto = 0;

                lstDoctosPV.Add(doctos);

                Grid.DataSource = lstDoctosPV;
                GV.RefreshData();
            }
        }
        private void RemoverRenglonDelGrid(DevExpress.XtraGrid.GridControl Grid, DevExpress.XtraGrid.Views.Grid.GridView GV)
        {
            var lstDoctosPV = (List<DoctosPV>)(Grid.DataSource);

            if (lstDoctosPV.Count > 0)
            {
                int i = GV.GetSelectedRows()[0];
                DoctosPV retiro = (DoctosPV)GV.GetRow(i);

                lstDoctosPV.Remove(retiro);

                Grid.DataSource = lstDoctosPV;
                GV.RefreshData();
            }
        }

        private void ObtenerTotales()
        {
            lstTotales.Clear();

            var lstPuntoDeVenta = (List<PuntoDeVenta>)gridPV.DataSource;
            var lstFacturacion = (List<DoctosVE>)gridFacturacion.DataSource;
            var lstCobranza = (List<DoctosCC>)gridCobranza.DataSource;
            var lstCajaFuerte = (List<DoctosPV>)GridCajaFuerte.DataSource;
            var lstTarjetas = (List<DoctosPV>)gridTarjetas.DataSource;
            var lstMasEfectivos = (List<DoctosPV>) gridMasEfectivos.DataSource;
            var lstFaltantesSobrantes = (List<DoctosPV>)gridFaltantesSobrantes.DataSource;
            decimal dTotalCheques = new FBDAL().ObtenerTotalCheques(hoy);

            AgregarTotalALaLista(TipoDeTotal.PuntoDeVenta, lstPuntoDeVenta.Sum(o => o.Importe));
            AgregarTotalALaLista(TipoDeTotal.Facturacion, lstFacturacion.Sum(o => o.dTotal));
            AgregarTotalALaLista(TipoDeTotal.Cobranza, lstCobranza.Sum(o => o.dTotal));
            AgregarTotalALaLista(TipoDeTotal.CajaFuerte, lstCajaFuerte.Sum(o => o.Total));
            AgregarTotalALaLista(TipoDeTotal.Tarjetas, lstTarjetas.Sum(o => o.Total));
            AgregarTotalALaLista(TipoDeTotal.MasEfectivos, lstMasEfectivos.Sum(o => o.Total));
            AgregarTotalALaLista(TipoDeTotal.FaltanteSobrante, lstFaltantesSobrantes.Sum(o => o.Total));

            AgregarTotalALaLista(TipoDeTotal.Cheques, dTotalCheques);
            lstTotales = lstTotales.Distinct().ToList();
        }

        private void AgregarTotalALaLista(TipoDeTotal tipo, decimal total)
        {
            Total TotalGenerico = new Total();
            TotalGenerico.Tipo = tipo;
            TotalGenerico.dTotal = total;

            lstTotales.Add(TotalGenerico);
        }

        private void btnAnalizarCorte_Click(object sender, EventArgs e)
        {
            EnviarAExcel();
            ObtenerTotales();
            FrmAnalisisCorte frmAnalisisDeCorte = new FrmAnalisisCorte(lstTotales);
            frmAnalisisDeCorte.UsuarioCorte = this.user;
            frmAnalisisDeCorte.hoy = hoy;
            frmAnalisisDeCorte.sPathExcel = sPathExcel;
            frmAnalisisDeCorte.ShowDialog();
        }

        private void btnCargarTarjetas_Click(object sender, EventArgs e)
        {
            CargarTarjetas();
        }
        private void CargarTarjetas()
        {
            FBDAL dal = new FBDAL();
            var lstPagosConTarjeta = dal.ObtenerPagosConTarjetas(hoy);

            gridTarjetas.DataSource = lstPagosConTarjeta;
            gvTarjetas.BestFitColumns();
        }

        private void btnFaltantesSobrantes_Click(object sender, EventArgs e)
        {
            CargarFaltantesSobrantes();
        }
        private void CargarFaltantesSobrantes()
        {
            FBDAL dal = new FBDAL();
            List<Cajas> lstCajas = dal.ObtenerCajas();

            DoctosPV FaltanteSobrante;
            List<DoctosPV> lstFaltanteSobrante = new List<DoctosPV>();
            foreach (Cajas caja in lstCajas)
            {
                FaltanteSobrante = new DoctosPV();
                decimal dTotalEsperado = dal.ObtenerVentaTotalDeCajaEsperado(caja.ID, hoy);
                decimal dTotalReal = dal.ObtenerVentaTotalDeCajaReal(caja.ID, hoy);
                decimal dFaltanteSobrante = dTotalReal - dTotalEsperado;

                if (dTotalReal != 0)
                {
                    FaltanteSobrante.CajaID = caja.ID;
                    FaltanteSobrante.NombreCaja = caja.Nombre;
                    FaltanteSobrante.Neto = dFaltanteSobrante;
                    FaltanteSobrante.Impuesto = 0;
                    lstFaltanteSobrante.Add(FaltanteSobrante);
                }
            }

            gridFaltantesSobrantes.DataSource = lstFaltanteSobrante;
            gvFaltantesSobrantes.BestFitColumns();
        }

        #region ***** Excel *****

        private int renglon, columna;
        string sPathExcel;
        private void EnviarAExcel()
        {
            ExcelDAL excelDAL = new ExcelDAL();
            try
            {
                renglon = 6; columna = 1;
                
                excelDAL.AbrirArchivo("Plantilla.xlsx");

                //************************* Corte ****************************
                ExcelEncabezado(excelDAL);
                ExcelPuntoDeVenta(excelDAL);                
                renglon += 2;
                ExcelFacturacion(excelDAL);
                renglon += 2;
                ExcelCobranza(excelDAL);
                renglon += 5;
                ExcelSobrantesFaltantes(excelDAL);
                
                renglon = 2; columna = 4;
                ExcelCajaFuerte(excelDAL);
                renglon += 3;
                ExcelTarjetas(excelDAL);
                
                renglon = 2; columna = 8;
                ExcelTransferencias(excelDAL);
                //*************************************************************
                //***************** Cheques y Transferencias ******************
                excelDAL.CambiarHoja(2);
                
                //Cheques
                renglon = 9; columna = 1;
                ExcelCheques(excelDAL);
                //Transferencias 
                renglon += 6; columna = 1;
                ExcelTransferenciasInfo(excelDAL);
                excelDAL.BorrarFilas();
                //*************************************************************

                string sHoy = hoy.ToString("ddMMyyyy");
                excelDAL.GuardarArchivo("Corte"+sHoy+".xlsx");                
                excelDAL.CerrarArchivo();

                sPathExcel = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Corte" + sHoy + ".xlsx";
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
                excelDAL.CerrarArchivo();
            }
        }
        private void ExcelEncabezado(ExcelDAL excelDal)
        {
            excelDal.CargarInformacion(1, 2, Properties.Settings.Default.Sucursal.ToUpper());
            excelDal.CargarInformacion(2, 2, user.sNombreCompleto.ToUpper());
            excelDal.CargarInformacion(3, 2, hoy.ToString("dd-MMMM-yyyy").ToUpper());
        }
        private void ExcelPuntoDeVenta(ExcelDAL excelDal)
        {
            List<PuntoDeVenta> lstPV = (List<PuntoDeVenta>)gridPV.DataSource;
            foreach (PuntoDeVenta pv in lstPV)
            {
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, pv.Caja);
                excelDal.InsertarRenglon(renglon, columna + 1); 
                excelDal.CargarInformacion(renglon, columna + 1, pv.Importe);
                renglon++;
            }

            excelDal.CargarInformacion(renglon, columna + 1, lstPV.Sum(o => o.Importe));
        }
        private void ExcelFacturacion(ExcelDAL excelDal)
        {
            List<DoctosVE> lstVE = (List<DoctosVE>)gridFacturacion.DataSource;
            foreach (DoctosVE pv in lstVE)
            {
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, pv.Folio);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.CargarInformacion(renglon, columna + 1, pv.dTotal);
                renglon++;
            }

            excelDal.CargarInformacion(renglon, columna + 1, lstVE.Sum(o => o.dTotal));
        }
        private void ExcelCobranza(ExcelDAL excelDal)
        {
            List<DoctosCC> lstCC = (List<DoctosCC>)gridCobranza.DataSource;

            decimal TotalCheques = 0;
            foreach (string concepto in Properties.Settings.Default.ConceptosCheques)
            {
                DoctosCC docto = lstCC.Find(o => o.iIDConcepto == Convert.ToInt32(concepto));
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, docto.sConcepto);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.CargarInformacion(renglon, columna + 1, docto.dTotal);
                TotalCheques += docto.dTotal;
                renglon++;
            }
            excelDal.CargarInformacion(renglon, columna + 1, TotalCheques);
            excelDal.HacerCeldaNegrita(renglon, columna + 1);
            
            renglon++;
            
            decimal TotalEfectivo = 0;
            foreach (string concepto in Properties.Settings.Default.ConceptosEfectivo)
            {
                DoctosCC docto = lstCC.Find(o => o.iIDConcepto == Convert.ToInt32(concepto));
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, docto.sConcepto);
                excelDal.QuitarCeldaNegrita(renglon, columna + 1);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.CargarInformacion(renglon, columna + 1, docto.dTotal);
                excelDal.QuitarCeldaNegrita(renglon, columna + 1);
                TotalEfectivo += docto.dTotal;
                renglon++;
            }
            excelDal.CargarInformacion(renglon, columna + 1, TotalEfectivo);
            excelDal.HacerCeldaNegrita(renglon, columna + 1);
        }
        private void ExcelSobrantesFaltantes(ExcelDAL excelDal)
        {
            List<DoctosPV> lstPV = (List<DoctosPV>)gridFaltantesSobrantes.DataSource;
            foreach (DoctosPV pv in lstPV)
            {
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, pv.NombreCaja);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.CargarInformacion(renglon, columna + 1, pv.Total);
                renglon++;
            }

            excelDal.CargarInformacion(renglon, columna + 1, lstPV.Sum(o => o.Total));
        }
        private void ExcelCajaFuerte(ExcelDAL excelDal)
        {
            List<DoctosPV> lstPV = (List<DoctosPV>)GridCajaFuerte.DataSource;
            foreach (DoctosPV pv in lstPV)
            {
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, pv.NombreCaja);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.InsertarRenglon(renglon, columna + 2);
                excelDal.CargarInformacion(renglon, columna + 2, pv.Total);
                renglon++;
            }

            excelDal.CargarInformacion(renglon, columna + 2, lstPV.Sum(o => o.Total));
        }
        private void ExcelTarjetas(ExcelDAL excelDal)
        {
            List<DoctosPV> lstPV = (List<DoctosPV>)gridTarjetas.DataSource;
            foreach (DoctosPV pv in lstPV)
            {
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, pv.NombreCaja);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.InsertarRenglon(renglon, columna + 2);
                excelDal.CargarInformacion(renglon, columna + 2, pv.Total);
                renglon++;
            }

            excelDal.CargarInformacion(renglon, columna + 2, lstPV.Sum(o => o.Total));
        }
        private void ExcelTransferencias(ExcelDAL excelDal)
        {
            List<DoctosPV> lstPV = (List<DoctosPV>)gridMasEfectivos.DataSource;
            foreach (DoctosPV pv in lstPV)
            {
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, pv.NombreCaja);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.CargarInformacion(renglon, columna + 1, pv.Total);
                renglon++;
            }

            excelDal.CargarInformacion(renglon, columna + 1, lstPV.Sum(o => o.Total));
        }

        private void ExcelCheques(ExcelDAL excelDal)
        {
            List<ChequeTransferencia> lstCheques = frmChequesTransferencias.lstCheques;
            foreach (ChequeTransferencia cheque in lstCheques)
            {
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, cheque.Identificador);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.CargarInformacion(renglon, columna + 1, cheque.Cliente);
                excelDal.InsertarRenglon(renglon, columna + 2);
                excelDal.CargarInformacion(renglon, columna + 2, cheque.Banco);
                excelDal.InsertarRenglon(renglon, columna + 3);
                excelDal.CargarInformacion(renglon, columna + 3, cheque.Importe);
                renglon++;
            }
        }
        private void ExcelTransferenciasInfo(ExcelDAL excelDal)
        {
            List<ChequeTransferencia> lstTransfers = frmChequesTransferencias.lstTransferencias;
            foreach (ChequeTransferencia transfer in lstTransfers)
            {
                excelDal.InsertarRenglon(renglon, columna);
                excelDal.CargarInformacion(renglon, columna, transfer.Identificador);
                excelDal.InsertarRenglon(renglon, columna + 1);
                excelDal.CargarInformacion(renglon, columna + 1, transfer.Cliente);
                excelDal.InsertarRenglon(renglon, columna + 2);
                excelDal.CargarInformacion(renglon, columna + 2, transfer.Banco);
                excelDal.InsertarRenglon(renglon, columna + 3);
                excelDal.CargarInformacion(renglon, columna + 3, transfer.Importe);
                renglon++;
            }
        }
        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            hoy = dateTimePicker1.Value;
            lblFecha.Text = hoy.ToString("dd-MMM-yyyy").ToUpper();
        }
        
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            frmChequesTransferencias.ShowDialog();

            if (frmChequesTransferencias.Respuesta == DialogResult.OK)
                btnAnalizarCorte.Enabled = true;
            else
                btnAnalizarCorte.Enabled = false;
        }
    }
};