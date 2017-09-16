using Ubl.V2.Pe.common;

namespace Ubl.V2.Pe.maindoc
{
    /// <summary>
    ///  The document used to request payment.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    [System.Xml.Serialization.XmlRootAttribute("Invoice", Namespace="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable=false)]
    public partial class InvoiceType : UblBaseDocumentType
    {
        
        private IdentifierType idField;
        
        private IndicatorType copyIndicatorField;
        
        private IdentifierType uUIDField;
        
        private DateType issueDateField;
        
        private TimeType issueTimeField;
        
        private CodeType invoiceTypeCodeField;
        
        private TextType[] noteField;
        
        private DateType taxPointDateField;
        
        private CurrencyCodeType documentCurrencyCodeField;
        
        private CurrencyCodeType taxCurrencyCodeField;
        
        private CurrencyCodeType pricingCurrencyCodeField;
        
        private CurrencyCodeType paymentCurrencyCodeField;
        
        private CurrencyCodeType paymentAlternativeCurrencyCodeField;
        
        private CodeType accountingCostCodeField;
        
        private TextType accountingCostField;
        
        private NumericType lineCountNumericField;
        
        private PeriodType[] invoicePeriodField;
        
        private OrderReferenceType orderReferenceField;
        
        private BillingReferenceType[] billingReferenceField;
        
        private DocumentReferenceType[] despatchDocumentReferenceField;
        
        private DocumentReferenceType[] receiptDocumentReferenceField;
        
        private DocumentReferenceType[] originatorDocumentReferenceField;
        
        private DocumentReferenceType[] contractDocumentReferenceField;
        
        private DocumentReferenceType[] additionalDocumentReferenceField;
        
        private SignatureType[] signatureField;
        
        private SupplierPartyType accountingSupplierPartyField;
        
        private CustomerPartyType accountingCustomerPartyField;
        
        private PartyType payeePartyField;
        
        private CustomerPartyType buyerCustomerPartyField;
        
        private SupplierPartyType sellerSupplierPartyField;
        
        private PartyType taxRepresentativePartyField;
        
        private DeliveryType[] deliveryField;
        
        private DeliveryTermsType deliveryTermsField;
        
        private PaymentMeansType[] paymentMeansField;
        
        private PaymentTermsType[] paymentTermsField;
        
        private PaymentType[] prepaidPaymentField;
        
        private AllowanceChargeType[] allowanceChargeField;
        
        private ExchangeRateType taxExchangeRateField;
        
        private ExchangeRateType pricingExchangeRateField;
        
        private ExchangeRateType paymentExchangeRateField;
        
        private ExchangeRateType paymentAlternativeExchangeRateField;
        
        private TaxTotalType[] taxTotalField;
        
        private MonetaryTotalType legalMonetaryTotalField;
        
        private InvoiceLineType[] invoiceLineField;
        
        /// <summary>
        ///  An identifier for the Invoice assigned by the Creditor.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <summary>
        ///  Indicates whether a document is a copy (true) or not (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator
        {
            get
            {
                return this.copyIndicatorField;
            }
            set
            {
                this.copyIndicatorField = value;
            }
        }
        
        /// <summary>
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }
        
        /// <summary>
        ///  The date assigned by the Creditor on which the Invoice was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }
        
        /// <summary>
        ///  The time assigned by the Creditor at which the Invoice was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
            }
        }
        
        /// <summary>
        ///  Code specifying the type of the Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType InvoiceTypeCode
        {
            get
            {
                return this.invoiceTypeCodeField;
            }
            set
            {
                this.invoiceTypeCodeField = value;
            }
        }
        
        /// <summary>
        ///  Free-form text applying to the Invoice. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
        
        /// <summary>
        ///  The date of the Invoice, used to indicate the point at which tax becomes applicable.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType TaxPointDate
        {
            get
            {
                return this.taxPointDateField;
            }
            set
            {
                this.taxPointDateField = value;
            }
        }
        
        /// <summary>
        ///  The currency in which the Document is presented. This may be the same currency as the pricing or as the tax.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType DocumentCurrencyCode
        {
            get
            {
                return this.documentCurrencyCodeField;
            }
            set
            {
                this.documentCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The currency used for tax amounts in the Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType TaxCurrencyCode
        {
            get
            {
                return this.taxCurrencyCodeField;
            }
            set
            {
                this.taxCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The currency used for prices in the Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType PricingCurrencyCode
        {
            get
            {
                return this.pricingCurrencyCodeField;
            }
            set
            {
                this.pricingCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The currency used for payment in the Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType PaymentCurrencyCode
        {
            get
            {
                return this.paymentCurrencyCodeField;
            }
            set
            {
                this.paymentCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The alternative currency used for payment in the Invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType PaymentAlternativeCurrencyCode
        {
            get
            {
                return this.paymentAlternativeCurrencyCodeField;
            }
            set
            {
                this.paymentAlternativeCurrencyCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Buyer's accounting code applied to the Invoice as a whole.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType AccountingCostCode
        {
            get
            {
                return this.accountingCostCodeField;
            }
            set
            {
                this.accountingCostCodeField = value;
            }
        }
        
        /// <summary>
        ///  The Buyer's accounting cost centre applied to the Invoice as a whole, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AccountingCost
        {
            get
            {
                return this.accountingCostField;
            }
            set
            {
                this.accountingCostField = value;
            }
        }
        
        /// <summary>
        ///  The number of lines in the document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric
        {
            get
            {
                return this.lineCountNumericField;
            }
            set
            {
                this.lineCountNumericField = value;
            }
        }
        
        /// <summary>
        ///  An association to period(s) to which the Invoice applies.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] InvoicePeriod
        {
            get
            {
                return this.invoicePeriodField;
            }
            set
            {
                this.invoicePeriodField = value;
            }
        }
        
        /// <summary>
        ///  An association to Order Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType OrderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An association to Billing Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return this.billingReferenceField;
            }
            set
            {
                this.billingReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Despatch Advice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DespatchDocumentReference
        {
            get
            {
                return this.despatchDocumentReferenceField;
            }
            set
            {
                this.despatchDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Receipt Advice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ReceiptDocumentReference
        {
            get
            {
                return this.receiptDocumentReferenceField;
            }
            set
            {
                this.receiptDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Originator Document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OriginatorDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] OriginatorDocumentReference
        {
            get
            {
                return this.originatorDocumentReferenceField;
            }
            set
            {
                this.originatorDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Contract.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ContractDocumentReference
        {
            get
            {
                return this.contractDocumentReferenceField;
            }
            set
            {
                this.contractDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An associative reference to Additional Document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return this.additionalDocumentReferenceField;
            }
            set
            {
                this.additionalDocumentReferenceField = value;
            }
        }
        
        /// <summary>
        ///  An association to Signature.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Accounting Supplier Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty
        {
            get
            {
                return this.accountingSupplierPartyField;
            }
            set
            {
                this.accountingSupplierPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Accounting Customer Party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                return this.accountingCustomerPartyField;
            }
            set
            {
                this.accountingCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Payee.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty
        {
            get
            {
                return this.payeePartyField;
            }
            set
            {
                this.payeePartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return this.buyerCustomerPartyField;
            }
            set
            {
                this.buyerCustomerPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Seller.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to the Tax Representative.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TaxRepresentativeParty
        {
            get
            {
                return this.taxRepresentativePartyField;
            }
            set
            {
                this.taxRepresentativePartyField = value;
            }
        }
        
        /// <summary>
        ///  An association to Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryType[] Delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
            }
        }
        
        /// <summary>
        ///  An association to Delivery Terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryTermsType DeliveryTerms
        {
            get
            {
                return this.deliveryTermsField;
            }
            set
            {
                this.deliveryTermsField = value;
            }
        }
        
        /// <summary>
        ///  An association to Payment Means.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType[] PaymentMeans
        {
            get
            {
                return this.paymentMeansField;
            }
            set
            {
                this.paymentMeansField = value;
            }
        }
        
        /// <summary>
        ///  An association to Payment Terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return this.paymentTermsField;
            }
            set
            {
                this.paymentTermsField = value;
            }
        }
        
        /// <summary>
        ///  An association to prepaid payment(s).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PrepaidPayment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentType[] PrepaidPayment
        {
            get
            {
                return this.prepaidPaymentField;
            }
            set
            {
                this.prepaidPaymentField = value;
            }
        }
        
        /// <summary>
        ///  An association to Allowances and Charges that apply to the Invoice as a whole.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
            }
        }
        
        /// <summary>
        ///  An association to Exchange Rate between the Document Currency and the Tax Currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType TaxExchangeRate
        {
            get
            {
                return this.taxExchangeRateField;
            }
            set
            {
                this.taxExchangeRateField = value;
            }
        }
        
        /// <summary>
        ///  An association to Exchange Rate between the Document Currency and the Pricing Currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate
        {
            get
            {
                return this.pricingExchangeRateField;
            }
            set
            {
                this.pricingExchangeRateField = value;
            }
        }
        
        /// <summary>
        ///  An association to Exchange Rate between the Document Currency and the Payment Currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentExchangeRate
        {
            get
            {
                return this.paymentExchangeRateField;
            }
            set
            {
                this.paymentExchangeRateField = value;
            }
        }
        
        /// <summary>
        ///  An association to Exchange Rate between the Document Currency and the Payment Alternative Currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentAlternativeExchangeRate
        {
            get
            {
                return this.paymentAlternativeExchangeRateField;
            }
            set
            {
                this.paymentAlternativeExchangeRateField = value;
            }
        }
        
        /// <summary>
        ///  An association to tax total for specific tax types/rates.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
            }
        }
        
        /// <summary>
        ///  An association to the legally binding total amount payable on the Invoice, including Allowances, Charges, and Taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return this.legalMonetaryTotalField;
            }
            set
            {
                this.legalMonetaryTotalField = value;
            }
        }
        
        /// <summary>
        ///  An association to one or more Invoice Lines.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public InvoiceLineType[] InvoiceLine
        {
            get
            {
                return this.invoiceLineField;
            }
            set
            {
                this.invoiceLineField = value;
            }
        }
    }
}