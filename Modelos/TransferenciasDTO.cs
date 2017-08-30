using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SATeC.Modelos
{
    public class TransferenciasDTO
    {
        public string Numero_Poliza { get; set; }
        public string Numero_Cuenta { get; set; }
        public string CtaOri { get; set; }
        public string BancoOriNal { get; set; }
        public string BancoOriExt { get; set; }
        public string CtaDest { get; set; }
        public string BancoDestNal { get; set; }
        public string BancoDestExt { get; set; }
        public string Fecha { get; set; }
        public string Benef { get; set; }
        public string RFC { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }
        public string Clave { get; set; }
    }
}
