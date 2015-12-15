using System;

namespace CorteDeSucursales.Modelos
{
    public class DoctosPV
    {
        public int CajaID { set; get; }
        public string NombreCaja { set; get; }
        public DateTime? Fecha { set; get; }
        public TimeSpan? Hora { set; get; }
        public decimal Neto { set; get; }
        public decimal Impuesto { set; get; }
        public decimal Total 
        {
            get
            {
                return Neto + Impuesto;
            }
        }
    }
}
