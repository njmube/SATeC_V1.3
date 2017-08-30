using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SATeC.Modelos
{
    public class PolizasDTO
    {
        public string ID_Poliza { get; set; }
        public string Numero_Poliza { get; set; }
        public string Fecha_Poliza { get; set; }
        public string Concepto { get; set; }
        public List<TransaccionesDTO> Transacciones { get; set; }
    }
}