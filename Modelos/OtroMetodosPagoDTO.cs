using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SATeC.Modelos
{
    public class OtroMetodosPagoDTO
    {
        public string Numero_Poliza { get; set; }
        public string Numero_Cuenta { get; set; }
        public string MetPagoPol { get; set; }
        public string Fecha { get; set; }
        public string Benef { get; set; }
        public string RFC { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }
        public string Clave { get; set; }
    }
}