using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CorteDeSucursales.Modelos;
using FirebirdSql.Data.FirebirdClient;

namespace CorteDeSucursales.DAL
{
    public class FBDAL
    {
        private FbConnection Conexion = new FbConnection();
        private FbCommand Comando = new FbCommand();
        private FbDataAdapter Adapter = new FbDataAdapter();

        public string ObtenerStringDeConexion()
        {
            string sServidor = Properties.Settings.Default.ConfigMicrosip.sServidor;
            string sBaseDeDatos = Properties.Settings.Default.ConfigMicrosip.sBaseDeDatos;
            string sUsuario = Properties.Settings.Default.ConfigMicrosip.sUsuario;
            string sContraseña = Properties.Settings.Default.ConfigMicrosip.sContraseña;
            int iPuerto = Properties.Settings.Default.ConfigMicrosip.iPuerto;

            FbConnectionStringBuilder fbsc = new FbConnectionStringBuilder();
            fbsc.DataSource = sServidor;
            fbsc.Database = sBaseDeDatos;
            fbsc.UserID = sUsuario;
            fbsc.Password = sContraseña;
            fbsc.Port = iPuerto;

            return fbsc.ConnectionString;
        }

        public List<DoctosPV> ObtenerDocumentosDePuntoDeVenta(DateTime fecha)
        {
            List<DoctosPV> lstDoctosPV = null;

            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText = 
                    string.Format(@"SELECT 
                                      CAJAS.CAJA_ID,
                                      CAJAS.NOMBRE,
                                      DOCTOS_PV.IMPORTE_NETO,
                                      DOCTOS_PV.TOTAL_IMPUESTOS,
                                      DOCTOS_PV.FECHA,
                                      DOCTOS_PV.HORA
                                    FROM
                                      CAJAS
                                      INNER JOIN DOCTOS_PV ON (CAJAS.CAJA_ID = DOCTOS_PV.CAJA_ID)
                                    WHERE
                                      DOCTOS_PV.FECHA = '{0}' AND 
                                      DOCTOS_PV.TIPO_DOCTO = 'V'", fecha.ToString("yyyy-MM-dd"));
                Adapter.SelectCommand = Comando;
                DataTable resultado = new DataTable();

                Adapter.Fill(resultado);

                DoctosPV DoctoPV;
                lstDoctosPV = new List<DoctosPV>();
                foreach (DataRow fila in resultado.Rows)
                {
                    DoctoPV = new DoctosPV();
                    DoctoPV.CajaID = Convert.ToInt32(fila["CAJA_ID"]);
                    DoctoPV.NombreCaja = Convert.ToString(fila["NOMBRE"]);
                    DoctoPV.Fecha = Convert.ToDateTime(fila["FECHA"]);
                    DoctoPV.Hora = (TimeSpan)fila["HORA"];
                    DoctoPV.Neto = Convert.ToDecimal(fila["IMPORTE_NETO"]);
                    DoctoPV.Impuesto = Convert.ToDecimal(fila["TOTAL_IMPUESTOS"]);

                    lstDoctosPV.Add(DoctoPV);
                }

                lstDoctosPV.AddRange(ObtenerDevolucionesDePuntoDeVenta(fecha));
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }

            return lstDoctosPV;
        }

        private List<DoctosPV> ObtenerDevolucionesDePuntoDeVenta(DateTime fecha)
        {
            List<DoctosPV> lstDoctosPV = null;

            try
            {
                // La conexion ya debe estar abierta
                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      CAJAS.CAJA_ID,
                                      CAJAS.NOMBRE,
                                      - DOCTOS_PV.IMPORTE_NETO AS IMPORTE_NETO,
                                      - DOCTOS_PV.TOTAL_IMPUESTOS AS TOTAL_IMPUESTOS,
                                      DOCTOS_PV.FECHA,
                                      DOCTOS_PV.HORA
                                    FROM
                                      CAJAS
                                      INNER JOIN DOCTOS_PV ON (CAJAS.CAJA_ID = DOCTOS_PV.CAJA_ID)
                                    WHERE
                                      DOCTOS_PV.FECHA = '{0}' AND 
                                      DOCTOS_PV.ESTATUS = 'N' AND 
                                      DOCTOS_PV.TIPO_DOCTO = 'D'", fecha.ToString("yyyy-MM-dd"));
                Adapter.SelectCommand = Comando;
                DataTable resultado = new DataTable();

                Adapter.Fill(resultado);

                DoctosPV DoctoPV;
                lstDoctosPV = new List<DoctosPV>();
                foreach (DataRow fila in resultado.Rows)
                {
                    DoctoPV = new DoctosPV();
                    DoctoPV.CajaID = Convert.ToInt32(fila["CAJA_ID"]);
                    DoctoPV.NombreCaja = Convert.ToString(fila["NOMBRE"]);
                    DoctoPV.Fecha = Convert.ToDateTime(fila["FECHA"]);
                    DoctoPV.Hora = (TimeSpan)fila["HORA"];
                    DoctoPV.Neto = Convert.ToDecimal(fila["IMPORTE_NETO"]);
                    DoctoPV.Impuesto = Convert.ToDecimal(fila["TOTAL_IMPUESTOS"]);

                    lstDoctosPV.Add(DoctoPV);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }

            return lstDoctosPV;
        }

        public List<DoctosPV> ObtenerIngresos(DateTime fecha)
        {
            List<DoctosPV> lstDoctosPV = null;

            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      PV.DOCTO_PV_ID,
                                      PV.TIPO_DOCTO,
                                      PV.FOLIO,
                                      PV.IMPORTE_NETO,
                                      PV.TOTAL_IMPUESTOS
                                    FROM
                                      DOCTOS_PV PV
                                    WHERE
                                      PV.FECHA = '{0}' AND 
                                      PV.TIPO_DOCTO LIKE 'I' AND
                                      PV.ESTATUS LIKE 'N'", fecha.ToString("yyyy-MM-dd"));
                Adapter.SelectCommand = Comando;
                DataTable resultado = new DataTable();

                Adapter.Fill(resultado);

                DoctosPV DoctoPV;
                lstDoctosPV = new List<DoctosPV>();
                foreach (DataRow fila in resultado.Rows)
                {
                    DoctoPV = new DoctosPV();
                    DoctoPV.NombreCaja = Convert.ToString(fila["FOLIO"]);
                    DoctoPV.Neto = Convert.ToDecimal(fila["IMPORTE_NETO"]);
                    DoctoPV.Impuesto = Convert.ToDecimal(fila["TOTAL_IMPUESTOS"]);

                    lstDoctosPV.Add(DoctoPV);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }

            return lstDoctosPV;
        }

        public List<DoctosVE> ObtenerDocumentosDeFacturacion(DateTime fecha)
        {
            List<DoctosVE> lstDoctosVE = null;
            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      DOCTOS_VE.FOLIO,
                                      DOCTOS_VE.IMPORTE_NETO,
                                      DOCTOS_VE.TOTAL_IMPUESTOS
                                    FROM
                                      DOCTOS_VE
                                   WHERE
                                      FECHA = '{0}' AND 
                                      TIPO_DOCTO = 'F' AND 
                                      ESTATUS = 'N'", fecha.ToString("yyyy-MM-dd"));

                DataTable resultado = new DataTable();
                Adapter.SelectCommand = Comando;                
                Adapter.Fill(resultado);

                DoctosVE docto;
                lstDoctosVE = new List<DoctosVE>();
                foreach(DataRow fila in resultado.Rows)
                {
                    docto = new DoctosVE();
                    docto.Folio = fila["FOLIO"].ToString();
                    docto.dNeto = Convert.ToDecimal(fila["IMPORTE_NETO"]);
                    docto.dImpuestos = Convert.ToDecimal(fila["TOTAL_IMPUESTOS"]);

                    lstDoctosVE.Add(docto);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }
            return lstDoctosVE;
        }

        public List<DoctosCC> ObtenerDocumentosDeCobranza(DateTime fecha)
        {
            List<DoctosCC> lstDoctosCC = null;
            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      DCC.FOLIO,
                                      DCC.CONCEPTO_CC_ID,
                                      CCC.NOMBRE,
                                      IDCC.IMPORTE,
                                      IDCC.IMPUESTO
                                    FROM
                                      CONCEPTOS_CC CCC
                                      INNER JOIN DOCTOS_CC DCC ON (CCC.CONCEPTO_CC_ID = DCC.CONCEPTO_CC_ID)
                                      INNER JOIN IMPORTES_DOCTOS_CC IDCC ON (DCC.DOCTO_CC_ID = IDCC.DOCTO_CC_ID)
                                    WHERE
                                      DCC.FECHA = '{0}'", fecha.ToString("yyyy-MM-dd"));

                DataTable resultado = new DataTable();
                Adapter.SelectCommand = Comando;
                Adapter.Fill(resultado);

                DoctosCC docto;
                lstDoctosCC = new List<DoctosCC>();
                foreach (DataRow fila in resultado.Rows)
                {
                    docto = new DoctosCC();
                    docto.sFolio = fila["FOLIO"].ToString();
                    docto.iIDConcepto = Convert.ToInt32(fila["CONCEPTO_CC_ID"]);
                    docto.sConcepto = fila["NOMBRE"].ToString();
                    docto.dNeto = Convert.ToDecimal(fila["IMPORTE"]);
                    docto.dImpuestos = Convert.ToDecimal(fila["IMPUESTO"]);

                    lstDoctosCC.Add(docto);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }
            return lstDoctosCC;
        }

        public List<DoctosPV> ObtenerRetirosDeCajas(DateTime fecha)
        {
            List<DoctosPV> lstDoctosPV = null;
            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      MC.CAJA_ID,
                                      C.NOMBRE,
                                      MCF.IMPORTE AS IMPORTE_NETO,
                                      0 AS TOTAL_IMPUESTOS
                                    FROM
                                      MOVTOS_CAJAS_FONDO MCF
                                      INNER JOIN MOVTOS_CAJAS MC ON (MCF.MOVTO_CAJA_ID = MC.MOVTO_CAJA_ID)
                                      INNER JOIN FORMAS_COBRO FC ON (MCF.FORMA_COBRO_ID = FC.FORMA_COBRO_ID)
                                      INNER JOIN CAJAS C ON (MC.CAJA_ID = C.CAJA_ID)
                                    WHERE
                                      MC.FECHA = '{0}' AND 
                                      FC.TIPO = 'E'

                                    UNION

                                    SELECT 
                                      C.CAJA_ID,
                                      C.NOMBRE,
                                      PV.IMPORTE_NETO,
                                      PV.TOTAL_IMPUESTOS
                                    FROM
                                      CAJAS C
                                      INNER JOIN DOCTOS_PV PV ON (C.CAJA_ID = PV.CAJA_ID)
                                    WHERE
                                      FECHA = '{0}' AND 
                                      TIPO_DOCTO = 'R' AND 
                                      ESTATUS = 'N'", fecha.ToString("yyyy-MM-dd"));

                DataTable resultado = new DataTable();
                Adapter.SelectCommand = Comando;
                Adapter.Fill(resultado);

                DoctosPV docto;
                lstDoctosPV = new List<DoctosPV>();
                foreach (DataRow fila in resultado.Rows)
                {
                    docto = new DoctosPV();
                    docto.CajaID = Convert.ToInt32(fila["CAJA_ID"]);
                    docto.NombreCaja = fila["NOMBRE"].ToString();
                    docto.Neto = Convert.ToDecimal(fila["IMPORTE_NETO"]);
                    docto.Impuesto = Convert.ToDecimal(fila["TOTAL_IMPUESTOS"]);

                    lstDoctosPV.Add(docto);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }
            return lstDoctosPV;
        }

        public List<DoctosPV> ObtenerPagosConTarjetas(DateTime fecha)
        {
            List<DoctosPV> lstPagoConTarjeta = null;

            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      MC.CAJA_ID, C.NOMBRE, MCF.IMPORTE, 0 AS IMPUESTO
                                    FROM
                                      MOVTOS_CAJAS_FONDO MCF
                                      INNER JOIN MOVTOS_CAJAS MC ON (MCF.MOVTO_CAJA_ID = MC.MOVTO_CAJA_ID)
                                      INNER JOIN FORMAS_COBRO FC ON (MCF.FORMA_COBRO_ID = FC.FORMA_COBRO_ID)
                                      INNER JOIN CAJAS C ON (MC.CAJA_ID = C.CAJA_ID)
                                    WHERE
                                      MC.FECHA = '{0}' AND 
                                      FC.TIPO = 'T'", fecha.ToString("yyyy-MM-dd"));
                Adapter.SelectCommand = Comando;
                DataTable resultado = new DataTable();

                Adapter.Fill(resultado);

                DoctosPV PagoConTarjeta;
                lstPagoConTarjeta = new List<DoctosPV>();
                foreach (DataRow fila in resultado.Rows)
                {
                    PagoConTarjeta = new DoctosPV();
                    PagoConTarjeta.CajaID = Convert.ToInt32(fila["CAJA_ID"]);
                    PagoConTarjeta.NombreCaja = fila["NOMBRE"].ToString();
                    PagoConTarjeta.Neto = Convert.ToDecimal(fila["IMPORTE"]);
                    PagoConTarjeta.Impuesto = 0;
                    lstPagoConTarjeta.Add(PagoConTarjeta);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }

            return lstPagoConTarjeta;
        }

        public List<Cajas> ObtenerCajas()
        {
            List<Cajas> lstCajas = null;

            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                       CAJA_ID, 
                                       NOMBRE
                                    FROM
                                       CAJAS");
                Adapter.SelectCommand = Comando;
                DataTable resultado = new DataTable();

                Adapter.Fill(resultado);

                Cajas caja;
                lstCajas = new List<Cajas>();
                foreach (DataRow fila in resultado.Rows)
                {
                    caja = new Cajas();
                    caja.ID = Convert.ToInt32(fila["CAJA_ID"]);
                    caja.Nombre = fila["NOMBRE"].ToString();
                    lstCajas.Add(caja);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }

            return lstCajas;
        }

        public List<ConceptosCC> ObtenerConceptosCC()
        {
            List<ConceptosCC> lstConceptosCC = null;

            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      CONCEPTO_CC_ID,
                                      NOMBRE
                                    FROM
                                      CONCEPTOS_CC");
                Adapter.SelectCommand = Comando;
                DataTable resultado = new DataTable();

                Adapter.Fill(resultado);

                ConceptosCC concepto;
                lstConceptosCC = new List<ConceptosCC>();
                foreach (DataRow fila in resultado.Rows)
                {
                    concepto = new ConceptosCC();
                    concepto.iID = Convert.ToInt32(fila["CONCEPTO_CC_ID"]);
                    concepto.sConcepto = fila["NOMBRE"].ToString();
                    lstConceptosCC.Add(concepto);
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }

            return lstConceptosCC;
        }

        public decimal ObtenerTotalCheques(DateTime fecha)
        {
            decimal dTotalCheques = 0;

            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (string concepto in Properties.Settings.Default.ConceptosCheques)
                {
                    sb.Append(string.Format("{0}, ",concepto));
                }
                sb.Append("0");

                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      SUM(IDCC.IMPORTE) AS Importe
                                    FROM
                                      DOCTOS_CC DCC 
                                      INNER JOIN IMPORTES_DOCTOS_CC IDCC ON (DCC.DOCTO_CC_ID = IDCC.DOCTO_CC_ID)
                                    WHERE
                                      DCC.FECHA = '{0}' AND 
                                      DCC.CONCEPTO_CC_ID IN ({1})", fecha.ToString("yyyy-MM-dd"), sb.ToString());

                dTotalCheques = Convert.ToDecimal(Comando.ExecuteScalar());

            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }

            return dTotalCheques;
        }

        public decimal ObtenerVentaTotalDeCajaEsperado(int CajaID, DateTime fecha)
        {
            decimal dTotalCaja = 0;

            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT
                                      SUM(IMPORTE) AS IMPORTE
                                    FROM
                                      (
                                      SELECT 
                                        PV.CAJA_ID,
                                        PV.TIPO_DOCTO,
                                        SUM(PV.IMPORTE_NETO) + SUM(PV.TOTAL_IMPUESTOS) AS IMPORTE
                                      FROM
                                        DOCTOS_PV PV
                                      WHERE
                                        PV.FECHA = '{0}' AND 
                                        PV.ESTATUS IN ('N','D') AND
                                        PV.TIPO_DOCTO IN ('V','I')
                                      GROUP BY
                                        PV.CAJA_ID,
                                        PV.TIPO_DOCTO
                                      UNION
                                      SELECT 
                                        PV.CAJA_ID,
                                        PV.TIPO_DOCTO,
                                        - (SUM(PV.IMPORTE_NETO) + SUM(PV.TOTAL_IMPUESTOS)) AS IMPORTE
                                      FROM
                                        DOCTOS_PV PV
                                      WHERE
                                        PV.FECHA = '{0}' AND 
                                        PV.ESTATUS IN ('N') AND
                                        PV.TIPO_DOCTO IN ('R','D')
                                      GROUP BY
                                        PV.CAJA_ID,
                                        PV.TIPO_DOCTO
                                    )
                                    WHERE
                                      CAJA_ID = {1}", 
                                    fecha.ToString("yyyy-MM-dd"),
                                    CajaID);

                dTotalCaja = Convert.ToDecimal(Comando.ExecuteScalar());

            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }

            return dTotalCaja;
        }

        public decimal ObtenerVentaTotalDeCajaReal(int CajaID, DateTime fecha)
        {
            decimal dTotalCaja = 0;

            try
            {
                Conexion.ConnectionString = ObtenerStringDeConexion();
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText =
                    string.Format(@"SELECT 
                                      SUM(MCF.IMPORTE) AS IMPORTE
                                    FROM
                                      MOVTOS_CAJAS_FONDO MCF
                                      INNER JOIN MOVTOS_CAJAS MC ON (MCF.MOVTO_CAJA_ID = MC.MOVTO_CAJA_ID)
                                      INNER JOIN FORMAS_COBRO FC ON (MCF.FORMA_COBRO_ID = FC.FORMA_COBRO_ID)
                                      INNER JOIN CAJAS C ON (MC.CAJA_ID = C.CAJA_ID)
                                    WHERE
                                      MC.FECHA = '{0}' 
                                      AND C.CAJA_ID = {1}",
                                    fecha.ToString("yyyy-MM-dd"),
                                    CajaID);

                dTotalCaja = Convert.ToDecimal(Comando.ExecuteScalar());

            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
            }
            finally
            {
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
            }
            return dTotalCaja;
        }
    }
}
