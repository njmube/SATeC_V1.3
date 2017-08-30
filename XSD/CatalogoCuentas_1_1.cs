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
namespace SATeC.CatalogoDeCuentas {
    using System.Xml.Serialization;
    
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.sat.gob.mx/esquemas/ContabilidadE/1_1/CatalogoCuentas")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="www.sat.gob.mx/esquemas/ContabilidadE/1_1/CatalogoCuentas", IsNullable=false)]
    public partial class Catalogo {
        
        private CatalogoCtas[] ctasField;
        
        private string versionField;
        
        private string rFCField;
        
        private string mesField;
        
        private int anioField;
        
        private string selloField;
        
        private string noCertificadoField;
        
        private string certificadoField;
        
        public Catalogo() {
            this.versionField = "1.1";
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Ctas")]
        public CatalogoCtas[] Ctas {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.sat.gob.mx/esquemas/ContabilidadE/1_1/CatalogoCuentas")]
    public partial class CatalogoCtas {
        
        private string codAgrupField;
        
        private string numCtaField;
        
        private string descField;
        
        private string subCtaDeField;
        
        private int nivelField;
        
        private string naturField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodAgrup {
            get {
                return this.codAgrupField;
            }
            set {
                this.codAgrupField = value;
            }
        }
        
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
        public string Desc {
            get {
                return this.descField;
            }
            set {
                this.descField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubCtaDe {
            get {
                return this.subCtaDeField;
            }
            set {
                this.subCtaDeField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Nivel {
            get {
                return this.nivelField;
            }
            set {
                this.nivelField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Natur {
            get {
                return this.naturField;
            }
            set {
                this.naturField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="www.sat.gob.mx/esquemas/ContabilidadE/1_1/CatalogoCuentas")]
    public enum CatalogoMes {
        
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
    }
}
