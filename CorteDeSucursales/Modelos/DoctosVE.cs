
namespace CorteDeSucursales.Modelos
{
    public class DoctosVE
    {
        public string Folio { set; get; }
        public decimal dNeto { set; get; }
        public decimal dImpuestos { set; get; }
        public decimal dTotal
        {
            get
            {
                return dNeto + dImpuestos;
            }
        }
    }
}
