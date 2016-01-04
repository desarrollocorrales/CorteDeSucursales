using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetOffice;
using Excel = NetOffice.ExcelApi;
using NetOffice.ExcelApi.Enums;

namespace CorteDeSucursales.DAL
{
    public class ExcelDAL
    {
        private string columnas = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private Excel.Application AplicacionExcel;
        private Excel.Workbook Libro;
        private Excel.Worksheet Hoja;

        public void AbrirArchivo(string sNombrePlantilla)
        {
            AplicacionExcel = new Excel.Application();
            AplicacionExcel.DisplayAlerts = false;
            AplicacionExcel.Visible = false;

            Libro = AplicacionExcel.Workbooks.Open(Environment.CurrentDirectory + "\\Plantillas\\" + sNombrePlantilla);
            Hoja = (Excel.Worksheet)Libro.Sheets[1];
        }
        
        public void CambiarHoja(int indice)
        {
            Hoja = (Excel.Worksheet)Libro.Sheets[indice];
        }

        public void GuardarArchivo(string sNombrePlantilla)
        {
            Libro.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + sNombrePlantilla);
        }

        public void CerrarArchivo()
        {
            //Libro.Close();
            AplicacionExcel.Quit();
            AplicacionExcel.Dispose();
        }

        public void InsertarRenglon(int renglon, int columna)
        {
            //Insertar la linea
            string columnaInicial = string.Format("{0}{1}", columnas[columna], renglon);

            Excel.Range Line = Hoja.Range(columnaInicial);
            Line.Insert(XlInsertShiftDirection.xlShiftDown);
        }
        public void CargarInformacion(int renglon, int columna, string valor)
        {
            string celda = string.Format("{0}{1}", columnas[columna], renglon);
            Hoja.Range(celda).Cells.Font.Underline = false;
            Hoja.Range(celda).Cells.Font.Bold = false;
            Hoja.Range(celda).Value = valor;
            Hoja.Range(celda).HorizontalAlignment = XlHAlign.xlHAlignLeft;
        }
        public void CargarInformacion(int renglon, int columna, decimal valor)
        {
            string celda = string.Format("{0}{1}", columnas[columna], renglon);
            Hoja.Range(celda).NumberFormat = "#,#0.00";
            Hoja.Range(celda).Value = valor;
        }
        public void HacerCeldaNegrita(int renglon, int columna)
        {
            string celda = string.Format("{0}{1}", columnas[columna], renglon);
            Hoja.Range(celda).Font.Bold = true;
        }
        public void QuitarCeldaNegrita(int renglon, int columna)
        {
            string celda = string.Format("{0}{1}", columnas[columna], renglon);
            Hoja.Range(celda).Font.Bold = false;
        }
        public void BorrarFilas()
        {
            var usedRanage = Hoja.UsedRange;
            foreach (var r in usedRanage)
            {
                if (Convert.ToString(r.Value2) == "BORRAR")
                {
                    r.EntireRow.Delete(XlDeleteShiftDirection.xlShiftUp);
                }
            }
        }
    }
}
