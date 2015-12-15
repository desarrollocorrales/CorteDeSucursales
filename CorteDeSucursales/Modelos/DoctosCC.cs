
namespace CorteDeSucursales.Modelos
{
    public class DoctosCC
    {
        public string sFolio { set; get; } 
        public int iIDConcepto { set; get; }
        public string sConcepto { set; get; }
        public decimal dNeto { set; get; }
        public decimal dImpuestos {set; get;}
        public decimal dTotal
        {
            get
            {
                return dNeto + dImpuestos;
            }
        }
    }
}
