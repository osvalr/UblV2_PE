//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.8670
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

using Ubl.V2.Pe.common;

namespace Ubl.V2.Pe.maindoc {
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1")]
    [System.Xml.Serialization.XmlRootAttribute("VoidedDocuments", Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1", IsNullable=false)]
    public partial class VoidedDocumentsType : UblBaseDocumentType {

        private IdentifierType idField;
        
        private DateType referenceDateField;
        
        private DateType issueDateField;
        
        private TextType[] noteField;
        
        private SignatureType[] signatureField;

        private SupplierPartyType accountingSupplierPartyField;
        
        private VoidedDocumentsLineType[] voidedDocumentsLineField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ReferenceDate
        {
            get {
                return this.referenceDateField;
            }
            set {
                this.referenceDateField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate
        {
            get {
                return this.issueDateField;
            }
            set {
                this.issueDateField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note
        {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty
        {
            get {
                return this.accountingSupplierPartyField;
            }
            set {
                this.accountingSupplierPartyField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("VoidedDocumentsLine", Namespace="urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1")]
        public VoidedDocumentsLineType[] VoidedDocumentsLine {
            get {
                return this.voidedDocumentsLineField;
            }
            set {
                this.voidedDocumentsLineField = value;
            }
        }
    }
    
}
