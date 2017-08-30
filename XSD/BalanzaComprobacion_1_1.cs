﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Este código fuente fue generado automáticamente por xsd, Versión=4.0.30319.18020.
// 
namespace SATeC.Balanza {
    using System.Xml.Serialization;
    
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion", IsNullable=false)]
    public partial class Balanza {
        
        private BalanzaCtas[] ctasField;
        
        private string versionField;
        
        private string rFCField;
        
        private string mesField;
        
        private int anioField;
        
        private string tipoEnvioField;
        
        private System.DateTime fechaModBalField;
        
        private bool fechaModBalFieldSpecified;
        
        private string selloField;
        
        private string noCertificadoField;
        
        private string certificadoField;
        
        public Balanza() {
            this.versionField = "1.1";
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Ctas")]
        public BalanzaCtas[] Ctas {
            get {
                return this.ctasField;
            }
            set {
                this.ctasField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFC {
            get {
                return this.rFCField;
            }
            set {
                this.rFCField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mes {
            get {
                return this.mesField;
            }
            set {
                this.mesField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Anio {
            get {
                return this.anioField;
            }
            set {
                this.anioField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoEnvio {
            get {
                return this.tipoEnvioField;
            }
            set {
                this.tipoEnvioField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime FechaModBal {
            get {
                return this.fechaModBalField;
            }
            set {
                this.fechaModBalField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaModBalSpecified {
            get {
                return this.fechaModBalFieldSpecified;
            }
            set {
                this.fechaModBalFieldSpecified = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sello {
            get {
                return this.selloField;
            }
            set {
                this.selloField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string noCertificado {
            get {
                return this.noCertificadoField;
            }
            set {
                this.noCertificadoField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Certificado {
            get {
                return this.certificadoField;
            }
            set {
                this.certificadoField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion")]
    public partial class BalanzaCtas {
        
        private string numCtaField;
        
        private decimal saldoIniField;
        
        private decimal debeField;
        
        private decimal haberField;
        
        private decimal saldoFinField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumCta {
            get {
                return this.numCtaField;
            }
            set {
                this.numCtaField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SaldoIni {
            get {
                return this.saldoIniField;
            }
            set {
                this.saldoIniField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Debe {
            get {
                return this.debeField;
            }
            set {
                this.debeField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Haber {
            get {
                return this.haberField;
            }
            set {
                this.haberField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SaldoFin {
            get {
                return this.saldoFinField;
            }
            set {
                this.saldoFinField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.sat.gob.mx/esquemas/ContabilidadE/1_1/BalanzaComprobacion")]
    public enum BalanzaMes {
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,
    }
}