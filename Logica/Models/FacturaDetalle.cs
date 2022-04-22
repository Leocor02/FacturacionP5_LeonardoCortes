using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaDetalle
    {
        public string DescripcionItem { get; set; }
        public decimal CantidadFacturada { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal SubTotalLinea { get; set; }
        public decimal ImpuestoLinea { get; set; }
        public decimal TotalLinea { get; set; }

        //Atributo compuesto
        Producto Miproducto { get; set; }

        public FacturaDetalle()
        {
            Miproducto = new Producto();    
        }

    }
}
