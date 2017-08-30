using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SATeC.Modelos
{
    public class TransaccionesDTO
    {
        public string Numero_Poliza { get; set; }
        public string Cuenta { get; set; }
        public string DesCta { get; set; }
        public string Concepto { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }

        public List<ComprobantesNacionalesDTO> ComprobantesNacionales { get; set; }
        public List<ComprobantesNacionalesOtrosDTO> ComprobantesNacionalesOtrosDTO { get; set; }
        public List<ComprobantesExtranjerosDTO> ComprobantesExtranjerosDTO { get; set; }
    }
}