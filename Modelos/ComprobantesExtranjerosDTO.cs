﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SATeC.Modelos
{
    public class ComprobantesExtranjerosDTO
    {
        public string Numero_Poliza { get; set; }
        public string Numero_Cuenta { get; set; }
        public string NumFactExt { get; set; }
        public string TaxID { get; set; }
        public decimal MontoTotal { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }
        public string Clave { get; set; }
    }
}
