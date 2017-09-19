namespace Ubl.V2.Pe.common
{


    /// <summary>
    ///  Information about the relationship between two items.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RelatedItemType
    {

        private IdentifierType idField;

        private QuantityType quantityField;

        private TextType[] descriptionField;

        /// <summary>
        ///  An identifier for the related item.
        ///  Example: "First", "Second"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The quantity that applies to the relationship.
        ///  Example: "6", "10mg per Kilo"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <summary>
        ///  A description for the relationship.
        ///  Example: "If used in wet conditions or extreme environments"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a contactable person or organization department.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ContactType
    {


        private IdentifierType idField;

        private NameType nameField;

        private TextType telephoneField;

        private TextType telefaxField;

        private TextType electronicMailField;

        private TextType noteField;

        private CommunicationType[] otherCommunicationField;

        /// <summary>
        ///  An identifier for the Contact.
        ///  Example: "Receivals Clerk"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The name of the Contact.
        ///  Example: "Delivery Dock"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  The telephone number of the Contact.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Telephone
        {
            get
            {
                return this.telephoneField;
            }
            set
            {
                this.telephoneField = value;
            }
        }

        /// <summary>
        ///  The fax number of the Contact.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Telefax
        {
            get
            {
                return this.telefaxField;
            }
            set
            {
                this.telefaxField = value;
            }
        }

        /// <summary>
        ///  The email address of the Contact.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType ElectronicMail
        {
            get
            {
                return this.electronicMailField;
            }
            set
            {
                this.electronicMailField = value;
            }
        }

        /// <summary>
        ///  A note such as 'Emergency' or 'After Hours' describing the circumstances in which the Contact can be used.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  An association to Other Communication.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OtherCommunication")]
        public CommunicationType[] OtherCommunication
        {
            get
            {
                return this.otherCommunicationField;
            }
            set
            {
                this.otherCommunicationField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a means of communication.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CommunicationType
    {

        private ChannelCodeType channelCodeField;

        private TextType channelField;

        private TextType valueField;

        /// <summary>
        ///  The method of communication, expressed as a code.
        ///  Example: Phone Fax Email
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChannelCodeType ChannelCode
        {
            get
            {
                return this.channelCodeField;
            }
            set
            {
                this.channelCodeField = value;
            }
        }

        /// <summary>
        ///  The method of communication, expressed as text.
        ///  Example: Skype
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        /// <summary>
        ///  The communication value, such as phone number or email address.
        ///  Example: "+44 1 2345 6789" "president@whitehouse.com"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    ///  Information about the Customer Party.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CustomerPartyType
    {

        private IdentifierType customerAssignedAccountIDField;

        private IdentifierType supplierAssignedAccountIDField;

        private IdentifierType[] additionalAccountIDField;

        private PartyType partyField;

        private ContactType deliveryContactField;

        private ContactType accountingContactField;

        private ContactType buyerContactField;

        /// <summary>
        ///  An identifier for the Customer's account, assigned by the Customer itself.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CustomerAssignedAccountID
        {
            get
            {
                return this.customerAssignedAccountIDField;
            }
            set
            {
                this.customerAssignedAccountIDField = value;
            }
        }

        /// <summary>
        ///  An identifier for the Customer's account, assigned by the Supplier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SupplierAssignedAccountID
        {
            get
            {
                return this.supplierAssignedAccountIDField;
            }
            set
            {
                this.supplierAssignedAccountIDField = value;
            }
        }

        /// <summary>
        ///  An identifier for the Customer's account, assigned by a third party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType[] AdditionalAccountID
        {
            get
            {
                return this.additionalAccountIDField;
            }
            set
            {
                this.additionalAccountIDField = value;
            }
        }

        /// <summary>
        ///  An association to Party.
        /// </summary>
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery Contact.
        /// </summary>
        public ContactType DeliveryContact
        {
            get
            {
                return this.deliveryContactField;
            }
            set
            {
                this.deliveryContactField = value;
            }
        }

        /// <summary>
        ///  An association to Accounting Contact (Customer).
        /// </summary>
        public ContactType AccountingContact
        {
            get
            {
                return this.accountingContactField;
            }
            set
            {
                this.accountingContactField = value;
            }
        }

        /// <summary>
        ///  An association to Buyer Contact.
        /// </summary>
        public ContactType BuyerContact
        {
            get
            {
                return this.buyerContactField;
            }
            set
            {
                this.buyerContactField = value;
            }
        }
    }

    /// <summary>
    ///  Information about an organization, sub-organization, or individual fulfilling a role in a business process.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyType
    {

        private IndicatorType markCareIndicatorField;

        private IndicatorType markAttentionIndicatorField;

        private IdentifierType websiteURIField;

        private IdentifierType logoReferenceIDField;

        private IdentifierType endpointIDField;

        private PartyIdentificationType[] partyIdentificationField;

        private PartyNameType[] partyNameField;

        private LanguageType languageField;

        private AddressType postalAddressField;

        private LocationType1 physicalLocationField;

        private PartyTaxSchemeType[] partyTaxSchemeField;

        private PartyLegalEntityType[] partyLegalEntityField;

        private ContactType contactField;

        private PersonType personField;

        private PartyType agentPartyField;

        /// <summary>
        ///  Indicates whether a party is C/O (care of).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType MarkCareIndicator
        {
            get
            {
                return this.markCareIndicatorField;
            }
            set
            {
                this.markCareIndicatorField = value;
            }
        }

        /// <summary>
        ///  Indicates whether a party is 'FAO' (for the attention of).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType MarkAttentionIndicator
        {
            get
            {
                return this.markAttentionIndicatorField;
            }
            set
            {
                this.markAttentionIndicatorField = value;
            }
        }

        /// <summary>
        ///  The Uniform Resource Identifier (URI) of the party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType WebsiteURI
        {
            get
            {
                return this.websiteURIField;
            }
            set
            {
                this.websiteURIField = value;
            }
        }

        /// <summary>
        ///  A party's logo.
        ///  Example: http://www2.coca-cola.com/images/logo.gif
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LogoReferenceID
        {
            get
            {
                return this.logoReferenceIDField;
            }
            set
            {
                this.logoReferenceIDField = value;
            }
        }

        /// <summary>
        ///  Identifies the end point of the routing service, e.g., EAN Location Number, GLN.
        ///  Example: 5790002221134
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType EndpointID
        {
            get
            {
                return this.endpointIDField;
            }
            set
            {
                this.endpointIDField = value;
            }
        }

        /// <summary>
        ///  An association to Party Identification.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
        public PartyIdentificationType[] PartyIdentification
        {
            get
            {
                return this.partyIdentificationField;
            }
            set
            {
                this.partyIdentificationField = value;
            }
        }

        /// <summary>
        ///  An association to Party Name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PartyName")]
        public PartyNameType[] PartyName
        {
            get
            {
                return this.partyNameField;
            }
            set
            {
                this.partyNameField = value;
            }
        }

        /// <summary>
        ///  An association to Language.
        /// </summary>
        public LanguageType Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <summary>
        ///  The party's postal address.
        /// </summary>
        public AddressType PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }

        /// <summary>
        ///  The party's physical location.
        /// </summary>
        public LocationType1 PhysicalLocation
        {
            get
            {
                return this.physicalLocationField;
            }
            set
            {
                this.physicalLocationField = value;
            }
        }

        /// <summary>
        ///  An association to Party Tax Scheme.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PartyTaxScheme")]
        public PartyTaxSchemeType[] PartyTaxScheme
        {
            get
            {
                return this.partyTaxSchemeField;
            }
            set
            {
                this.partyTaxSchemeField = value;
            }
        }

        /// <summary>
        ///  An association to Party Legal Entity.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PartyLegalEntity")]
        public PartyLegalEntityType[] PartyLegalEntity
        {
            get
            {
                return this.partyLegalEntityField;
            }
            set
            {
                this.partyLegalEntityField = value;
            }
        }

        /// <summary>
        ///  An association to Contact.
        /// </summary>
        public ContactType Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <summary>
        ///  An association to a person.
        /// </summary>
        public PersonType Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }

        /// <summary>
        ///  An association to another party who acts as an agent for this party.
        /// </summary>
        public PartyType AgentParty
        {
            get
            {
                return this.agentPartyField;
            }
            set
            {
                this.agentPartyField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a party's identification.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyIdentificationType
    {

        private IdentifierType idField;

        /// <summary>
        /// Convierte texto al Id de PArtyIdentification
        /// </summary>
        /// <param name="value">texto que contiene el ID</param>
        public static implicit operator PartyIdentificationType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new PartyIdentificationType { ID = value };
        }

        /// <summary>
        ///  Identifies a party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
    }

    /// <summary>
    ///  Information about a party's name.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyNameType
    {

        private NameType nameField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="PartyNameType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PartyNameType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new PartyNameType { Name = value };
        }

        /// <summary>
        ///  The name of the party.
        ///  Example: "Microsoft"
        /// </summary>
        [System.Xml.Serialization.XmlElement("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Language.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LanguageType
    {

        private IdentifierType idField;

        private NameType nameField;

        private CodeType localeCodeField;

        /// <summary>
        ///  An identifier for a language, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The name of the language.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  The locale where the language is used, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType LocaleCode
        {
            get
            {
                return this.localeCodeField;
            }
            set
            {
                this.localeCodeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a structured address.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AddressType
    {

        private IdentifierType idField;

        private CodeType addressTypeCodeField;

        private CodeType addressFormatCodeField;

        private TextType postboxField;

        private TextType floorField;

        private TextType roomField;

        private NameType streetNameField;

        private NameType additionalStreetNameField;

        private NameType blockNameField;

        private NameType buildingNameField;

        private TextType buildingNumberField;

        private TextType inhouseMailField;

        private TextType departmentField;

        private TextType markAttentionField;

        private TextType markCareField;

        private TextType plotIdentificationField;

        private NameType citySubdivisionNameField;

        private NameType cityNameField;

        private TextType postalZoneField;

        private TextType countrySubentityField;

        private CodeType countrySubentityCodeField;

        private TextType regionField;

        private TextType districtField;

        private TextType timezoneOffsetField;

        private AddressLineType[] addressLineField;

        private CountryType countryField;

        private LocationCoordinateType locationCoordinateField;

        /// <summary>
        ///  An identifier for a specific address within a scheme of registered addresses.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A code specifying the type of this address, such as business address or home address.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType AddressTypeCode
        {
            get
            {
                return this.addressTypeCodeField;
            }
            set
            {
                this.addressTypeCodeField = value;
            }
        }

        /// <summary>
        ///  A code specifying the format of this address.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType AddressFormatCode
        {
            get
            {
                return this.addressFormatCodeField;
            }
            set
            {
                this.addressFormatCodeField = value;
            }
        }

        /// <summary>
        ///  A post office box number.
        ///  Example: "123"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Postbox
        {
            get
            {
                return this.postboxField;
            }
            set
            {
                this.postboxField = value;
            }
        }

        /// <summary>
        ///  An addressable floor of a building.
        ///  Example: "30"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Floor
        {
            get
            {
                return this.floorField;
            }
            set
            {
                this.floorField = value;
            }
        }

        /// <summary>
        ///  A room, suite, or apartment of a building.
        ///  Example: "Reception"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Room
        {
            get
            {
                return this.roomField;
            }
            set
            {
                this.roomField = value;
            }
        }

        /// <summary>
        ///  The name of a street.
        ///  Example: "Kwun Tong Road"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType StreetName
        {
            get
            {
                return this.streetNameField;
            }
            set
            {
                this.streetNameField = value;
            }
        }

        /// <summary>
        ///  An additional name of a street used to further specify the street name.
        ///  Example: "Cnr Aberdeen Road"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType AdditionalStreetName
        {
            get
            {
                return this.additionalStreetNameField;
            }
            set
            {
                this.additionalStreetNameField = value;
            }
        }

        /// <summary>
        ///  The block name, expressed as text, for an area surrounded by streets and usually containing several buildings for this address.
        ///  Example: Seabird
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType BlockName
        {
            get
            {
                return this.blockNameField;
            }
            set
            {
                this.blockNameField = value;
            }
        }

        /// <summary>
        ///  The name of a building.
        ///  Example: "Plot 421"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType BuildingName
        {
            get
            {
                return this.buildingNameField;
            }
            set
            {
                this.buildingNameField = value;
            }
        }

        /// <summary>
        ///  The number of a building.
        ///  Example: "388"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType BuildingNumber
        {
            get
            {
                return this.buildingNumberField;
            }
            set
            {
                this.buildingNumberField = value;
            }
        }

        /// <summary>
        ///  A specific location within a building.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType InhouseMail
        {
            get
            {
                return this.inhouseMailField;
            }
            set
            {
                this.inhouseMailField = value;
            }
        }

        /// <summary>
        ///  An addressable department of an organization.
        ///  Example: "Accounts Payable"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }

        /// <summary>
        ///  The name, expressed as text, of a person or department in the organization to whom incoming mail is marked with words such as 'for the attention of' or 'FAO' or 'ATTN' for this address.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType MarkAttention
        {
            get
            {
                return this.markAttentionField;
            }
            set
            {
                this.markAttentionField = value;
            }
        }

        /// <summary>
        ///  The name, expressed as text, of a person or organization at this address to whom incoming mail is marked with words such as 'care of' or 'C/O'.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType MarkCare
        {
            get
            {
                return this.markCareField;
            }
            set
            {
                this.markCareField = value;
            }
        }

        /// <summary>
        ///  The textual expression of the unique identifier for the piece of land on which this address is located such as a plot number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PlotIdentification
        {
            get
            {
                return this.plotIdentificationField;
            }
            set
            {
                this.plotIdentificationField = value;
            }
        }

        /// <summary>
        ///  A name, expressed as text, of a subdivision of a city for this address, for example, a district or borough.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType CitySubdivisionName
        {
            get
            {
                return this.citySubdivisionNameField;
            }
            set
            {
                this.citySubdivisionNameField = value;
            }
        }

        /// <summary>
        ///  The name of a city, town, or village.
        ///  Example: "Hong Kong"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <summary>
        ///  The identifier for an addressable group of properties according to the relevant national postal service, such as a ZIP code or Post Code.
        ///  Example: "SW11 4EW" "2500 GG"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PostalZone
        {
            get
            {
                return this.postalZoneField;
            }
            set
            {
                this.postalZoneField = value;
            }
        }

        /// <summary>
        ///  A territorial division of a country, such as a county or state.
        ///  Example: "Florida","Tamilnadu"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType CountrySubentity
        {
            get
            {
                return this.countrySubentityField;
            }
            set
            {
                this.countrySubentityField = value;
            }
        }

        /// <summary>
        ///  A territorial division of a country, such as a county or state, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType CountrySubentityCode
        {
            get
            {
                return this.countrySubentityCodeField;
            }
            set
            {
                this.countrySubentityCodeField = value;
            }
        }

        /// <summary>
        ///  An addressable region or group of countries.
        ///  Example: "European Union"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <summary>
        ///  A geographical division of a country.
        ///  Example: "East Coast"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType District
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }

        /// <summary>
        ///  For the time zone in which the address is situated, the measure of time offset from Universal Coordinated Time (UTC).
        ///  Example: "+8:00" "-3:00"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType TimezoneOffset
        {
            get
            {
                return this.timezoneOffsetField;
            }
            set
            {
                this.timezoneOffsetField = value;
            }
        }

        /// <summary>
        ///  An association to Address Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AddressLine")]
        public AddressLineType[] AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <summary>
        ///  An association to Country.
        /// </summary>
        public CountryType Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <summary>
        ///  An association to Location Coordinate.
        /// </summary>
        public LocationCoordinateType LocationCoordinate
        {
            get
            {
                return this.locationCoordinateField;
            }
            set
            {
                this.locationCoordinateField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a line of address expressed as unstructured text.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AddressLineType
    {

        private TextType lineField;
        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="AddressLineType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator AddressLineType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new AddressLineType { Line = value };
        }

        /// <summary>
        ///  A line of address expressed as unstructured text.
        ///  Example: "123 Standard Chartered Tower"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Line
        {
            get
            {
                return this.lineField;
            }
            set
            {
                this.lineField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a geopolitical country.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CountryType
    {

        private CountryIdentificationCodeType identificationCodeField;

        private NameType nameField;

        /// <summary>
        ///  An identifier for the Country.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountryIdentificationCodeType IdentificationCode
        {
            get
            {
                return this.identificationCodeField;
            }
            set
            {
                this.identificationCodeField = value;
            }
        }

        /// <summary>
        ///  The name of the Country.
        ///  Example: “SOUTH AFRICA”
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <summary>
    ///  Information about physical (geographical) location.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LocationCoordinateType
    {

        private CodeType coordinateSystemCodeField;

        private MeasureType latitudeDegreesMeasureField;

        private MeasureType latitudeMinutesMeasureField;

        private LatitudeDirectionCodeType latitudeDirectionCodeField;

        private MeasureType longitudeDegreesMeasureField;

        private MeasureType longitudeMinutesMeasureField;

        private LongitudeDirectionCodeType longitudeDirectionCodeField;

        /// <summary>
        ///  An identifier for the location system used.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType CoordinateSystemCode
        {
            get
            {
                return this.coordinateSystemCodeField;
            }
            set
            {
                this.coordinateSystemCodeField = value;
            }
        }

        /// <summary>
        ///  The measure of latitude in degrees.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType LatitudeDegreesMeasure
        {
            get
            {
                return this.latitudeDegreesMeasureField;
            }
            set
            {
                this.latitudeDegreesMeasureField = value;
            }
        }

        /// <summary>
        ///  The measure of latitude in minutes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType LatitudeMinutesMeasure
        {
            get
            {
                return this.latitudeMinutesMeasureField;
            }
            set
            {
                this.latitudeMinutesMeasureField = value;
            }
        }

        /// <summary>
        ///  The direction of latitude measurement from the equator.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatitudeDirectionCodeType LatitudeDirectionCode
        {
            get
            {
                return this.latitudeDirectionCodeField;
            }
            set
            {
                this.latitudeDirectionCodeField = value;
            }
        }

        /// <summary>
        ///  The measure of longitude in degrees.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType LongitudeDegreesMeasure
        {
            get
            {
                return this.longitudeDegreesMeasureField;
            }
            set
            {
                this.longitudeDegreesMeasureField = value;
            }
        }

        /// <summary>
        ///  The measure of longitude in minutes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType LongitudeMinutesMeasure
        {
            get
            {
                return this.longitudeMinutesMeasureField;
            }
            set
            {
                this.longitudeMinutesMeasureField = value;
            }
        }

        /// <summary>
        ///  The direction of longitude measurement from the meridian.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LongitudeDirectionCodeType LongitudeDirectionCode
        {
            get
            {
                return this.longitudeDirectionCodeField;
            }
            set
            {
                this.longitudeDirectionCodeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a location.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DeliveryLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class LocationType1
    {

        private IdentifierType idField;

        private TextType descriptionField;

        private TextType conditionsField;

        private TextType countrySubentityField;

        private CodeType countrySubentityCodeField;

        private PeriodType[] validityPeriodField;

        private AddressType addressField;

        /// <summary>
        ///  The unique identifier for the location, e.g., the EAN Location Number, GLN.
        ///  Example: 5790002221134
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The description or name of the location.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  Conditions describing the location.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Conditions
        {
            get
            {
                return this.conditionsField;
            }
            set
            {
                this.conditionsField = value;
            }
        }

        /// <summary>
        ///  A territorial division of a country, such as a county or state.
        ///  Example: "Florida","Tamilnadu"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType CountrySubentity
        {
            get
            {
                return this.countrySubentityField;
            }
            set
            {
                this.countrySubentityField = value;
            }
        }

        /// <summary>
        ///  The territorial division of a country, such as a county or state, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType CountrySubentityCode
        {
            get
            {
                return this.countrySubentityCodeField;
            }
            set
            {
                this.countrySubentityCodeField = value;
            }
        }

        /// <summary>
        ///  Period(s) in which the location can be used, e.g., for delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return this.validityPeriodField;
            }
            set
            {
                this.validityPeriodField = value;
            }
        }

        /// <summary>
        ///  Association to the address of the location.
        /// </summary>
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a period of time.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PeriodType
    {

        private DateType startDateField;

        private TimeType startTimeField;

        private DateType endDateField;

        private TimeType endTimeField;

        private MeasureType durationMeasureField;

        private CodeType[] descriptionCodeField;

        private TextType[] descriptionField;

        /// <summary>
        ///  The start date of the period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <summary>
        ///  The start time of the period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <summary>
        ///  The end date of the period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <summary>
        ///  The end time of the period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <summary>
        ///  The duration of a period, expressed as a code; ISO 8601.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType DurationMeasure
        {
            get
            {
                return this.durationMeasureField;
            }
            set
            {
                this.durationMeasureField = value;
            }
        }

        /// <summary>
        ///  A description of the period, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DescriptionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType[] DescriptionCode
        {
            get
            {
                return this.descriptionCodeField;
            }
            set
            {
                this.descriptionCodeField = value;
            }
        }

        /// <summary>
        ///  A description of the period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a party's Tax Scheme.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyTaxSchemeType
    {

        private NameType registrationNameField;

        private IdentifierType companyIDField;

        private CodeType taxLevelCodeField;

        private CodeType exemptionReasonCodeField;

        private TextType exemptionReasonField;

        private AddressType registrationAddressField;

        private TaxSchemeType taxSchemeField;

        /// <summary>
        ///  The official name of the party as registered with the relevant fiscal authority.
        ///  Example: "Microsoft Corporation"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType RegistrationName
        {
            get
            {
                return this.registrationNameField;
            }
            set
            {
                this.registrationNameField = value;
            }
        }

        /// <summary>
        ///  The identifier assigned for tax purposes to a party by the taxation authority.
        ///  Example: "3556625"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }

        /// <summary>
        ///  The section or role within the tax scheme that applies to the party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TaxLevelCode
        {
            get
            {
                return this.taxLevelCodeField;
            }
            set
            {
                this.taxLevelCodeField = value;
            }
        }

        /// <summary>
        ///  A reason for a party's exemption from tax, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ExemptionReasonCode
        {
            get
            {
                return this.exemptionReasonCodeField;
            }
            set
            {
                this.exemptionReasonCodeField = value;
            }
        }

        /// <summary>
        ///  A reason for a party's exemption from tax, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType ExemptionReason
        {
            get
            {
                return this.exemptionReasonField;
            }
            set
            {
                this.exemptionReasonField = value;
            }
        }

        /// <summary>
        ///  An association to Registered Address (for tax purposes).
        /// </summary>
        public AddressType RegistrationAddress
        {
            get
            {
                return this.registrationAddressField;
            }
            set
            {
                this.registrationAddressField = value;
            }
        }

        /// <summary>
        ///  An association to Tax Scheme.
        /// </summary>
        public TaxSchemeType TaxScheme
        {
            get
            {
                return this.taxSchemeField;
            }
            set
            {
                this.taxSchemeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a tax scheme.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxSchemeType
    {

        private IdentifierType idField;

        private NameType nameField;

        private CodeType taxTypeCodeField;

        private CurrencyCodeType currencyCodeField;

        private AddressType[] jurisdictionRegionAddressField;

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="TaxSchemeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator TaxSchemeType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new TaxSchemeType { ID = value };
        }

        /// <summary>
        ///  Identifies the tax scheme.
        ///  Example: "VAT", "GST"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The name of the tax scheme.
        ///  Example: "Value Added Tax", "Wholesale Tax", "Sales Tax", "State Tax"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  An identifier for the tax type.
        ///  Example: "Consumption", "Sales"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TaxTypeCode
        {
            get
            {
                return this.taxTypeCodeField;
            }
            set
            {
                this.taxTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The currency in which the tax is collected and reported, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <summary>
        ///  An association with Address (of taxation jurisdiction).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("JurisdictionRegionAddress")]
        public AddressType[] JurisdictionRegionAddress
        {
            get
            {
                return this.jurisdictionRegionAddressField;
            }
            set
            {
                this.jurisdictionRegionAddressField = value;
            }
        }
    }

    /// <summary>
    ///  Information directly relating to the legal registration that is applicable to a party.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyLegalEntityType
    {

        private NameType registrationNameField;

        private IdentifierType companyIDField;

        private AddressType registrationAddressField;

        private CorporateRegistrationSchemeType corporateRegistrationSchemeField;

        /// <summary>
        ///  The name of a party as registered with the legal authority.
        ///  Example: "Microsoft Corporation"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType RegistrationName
        {
            get
            {
                return this.registrationNameField;
            }
            set
            {
                this.registrationNameField = value;
            }
        }

        /// <summary>
        ///  Identifies a company as registered with the company registration scheme.
        ///  Example: "3556625"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }

        /// <summary>
        ///  Associates with the registered address of the party within a Corporate Registration Scheme.
        /// </summary>
        public AddressType RegistrationAddress
        {
            get
            {
                return this.registrationAddressField;
            }
            set
            {
                this.registrationAddressField = value;
            }
        }

        /// <summary>
        ///  Associates the party with a Corporate Registration Scheme.
        /// </summary>
        public CorporateRegistrationSchemeType CorporateRegistrationScheme
        {
            get
            {
                return this.corporateRegistrationSchemeField;
            }
            set
            {
                this.corporateRegistrationSchemeField = value;
            }
        }
    }

    /// <summary>
    ///  Information directly relating a scheme for corporate registration of businesses.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CorporateRegistrationSchemeType
    {

        private IdentifierType idField;

        private NameType nameField;

        private CodeType corporateRegistrationTypeCodeField;

        private AddressType[] jurisdictionRegionAddressField;

        /// <summary>
        ///  Identifies the scheme.
        ///  Example: "ASIC" in Australia
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Identifies the scheme by name.
        ///  Example: "Australian Securities and Investment Commission" in Australia
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  Identifies the type of scheme.
        ///  Example: "ACN"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType CorporateRegistrationTypeCode
        {
            get
            {
                return this.corporateRegistrationTypeCodeField;
            }
            set
            {
                this.corporateRegistrationTypeCodeField = value;
            }
        }

        /// <summary>
        ///  Associates the registration scheme with particulars that identify and locate the geographic area to which the scheme applies.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("JurisdictionRegionAddress")]
        public AddressType[] JurisdictionRegionAddress
        {
            get
            {
                return this.jurisdictionRegionAddressField;
            }
            set
            {
                this.jurisdictionRegionAddressField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a person.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PersonType
    {

        private NameType firstNameField;

        private NameType familyNameField;

        private TextType titleField;

        private NameType middleNameField;

        private TextType nameSuffixField;

        private TextType jobTitleField;

        private TextType organizationDepartmentField;

        /// <summary>
        ///  A person's forename or first name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <summary>
        ///  A person's surname or family name.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <summary>
        ///  A person's title of address, e.g., Mr, Ms, Dr, Sir.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <summary>
        ///  A person's middle name(s) and/or initial(s).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <summary>
        ///  A suffix to a person's name, e.g., PhD, OBE, Jnr.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType NameSuffix
        {
            get
            {
                return this.nameSuffixField;
            }
            set
            {
                this.nameSuffixField = value;
            }
        }

        /// <summary>
        ///  A person's job title within an organization (for a particular role).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType JobTitle
        {
            get
            {
                return this.jobTitleField;
            }
            set
            {
                this.jobTitleField = value;
            }
        }

        /// <summary>
        ///  The department or subdivision of an organization that the person belongs to (for a particular role).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType OrganizationDepartment
        {
            get
            {
                return this.organizationDepartmentField;
            }
            set
            {
                this.organizationDepartmentField = value;
            }
        }
    }

    /// <summary>
    ///  Information about the Supplier Party.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SupplierPartyType
    {

        private IdentifierType customerAssignedAccountIDField;

        private IdentifierType[] additionalAccountIDField;

        private TextType dataSendingCapabilityField;

        private PartyType partyField;

        private ContactType despatchContactField;

        private ContactType accountingContactField;

        private ContactType sellerContactField;

        /// <summary>
        ///  The customer's internal identifier for the supplier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CustomerAssignedAccountID
        {
            get
            {
                return this.customerAssignedAccountIDField;
            }
            set
            {
                this.customerAssignedAccountIDField = value;
            }
        }

        /// <summary>
        ///  The customer's internal identifier for the supplier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType[] AdditionalAccountID
        {
            get
            {
                return this.additionalAccountIDField;
            }
            set
            {
                this.additionalAccountIDField = value;
            }
        }

        /// <summary>
        ///  Capability to send invoice data via the purchase card provider (VISA/MasterCard/American Express).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType DataSendingCapability
        {
            get
            {
                return this.dataSendingCapabilityField;
            }
            set
            {
                this.dataSendingCapabilityField = value;
            }
        }

        /// <summary>
        ///  An association to Party.
        /// </summary>
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <summary>
        ///  An association to Despatch Contact.
        /// </summary>
        public ContactType DespatchContact
        {
            get
            {
                return this.despatchContactField;
            }
            set
            {
                this.despatchContactField = value;
            }
        }

        /// <summary>
        ///  An association to Supplier Accounting Contact.
        /// </summary>
        public ContactType AccountingContact
        {
            get
            {
                return this.accountingContactField;
            }
            set
            {
                this.accountingContactField = value;
            }
        }

        /// <summary>
        ///  An association to Seller Contact.
        /// </summary>
        public ContactType SellerContact
        {
            get
            {
                return this.sellerContactField;
            }
            set
            {
                this.sellerContactField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a package.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PackageType
    {

        private IdentifierType idField;

        private QuantityType quantityField;

        private IndicatorType returnableMaterialIndicatorField;

        private CodeType packageLevelCodeField;

        private PackagingTypeCodeType packagingTypeCodeField;

        private TextType[] packingMaterialField;

        private PackageType[] containedPackageField;

        private GoodsItemType[] goodsItemField;

        private DimensionType[] measurementDimensionField;

        private DeliveryUnitType[] deliveryUnitField;

        /// <summary>
        ///  Identifies the package.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The quantity (of items) contained in the package.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the packaging material is returnable (true) or not (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType ReturnableMaterialIndicator
        {
            get
            {
                return this.returnableMaterialIndicatorField;
            }
            set
            {
                this.returnableMaterialIndicatorField = value;
            }
        }

        /// <summary>
        ///  Code specifying a level of packaging.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PackageLevelCode
        {
            get
            {
                return this.packageLevelCodeField;
            }
            set
            {
                this.packageLevelCodeField = value;
            }
        }

        /// <summary>
        ///  Code specifying the type of packaging of an item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackagingTypeCodeType PackagingTypeCode
        {
            get
            {
                return this.packagingTypeCodeField;
            }
            set
            {
                this.packagingTypeCodeField = value;
            }
        }

        /// <summary>
        ///  Description of the type of packaging of an item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] PackingMaterial
        {
            get
            {
                return this.packingMaterialField;
            }
            set
            {
                this.packingMaterialField = value;
            }
        }

        /// <summary>
        ///  An association to Contained Package; used to describe a package within a package.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ContainedPackage")]
        public PackageType[] ContainedPackage
        {
            get
            {
                return this.containedPackageField;
            }
            set
            {
                this.containedPackageField = value;
            }
        }

        /// <summary>
        ///  An association to Goods Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return this.goodsItemField;
            }
            set
            {
                this.goodsItemField = value;
            }
        }

        /// <summary>
        ///  An association to describe the measurement dimensions of the package.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return this.measurementDimensionField;
            }
            set
            {
                this.measurementDimensionField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery Units in the package.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit
        {
            get
            {
                return this.deliveryUnitField;
            }
            set
            {
                this.deliveryUnitField = value;
            }
        }
    }

    /// <summary>
    ///  A separately identifiable quantity of products of a single product type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class GoodsItemType
    {

        private IdentifierType idField;

        private IdentifierType sequenceNumberIDField;

        private TextType[] descriptionField;

        private IndicatorType hazardousRiskIndicatorField;

        private AmountType declaredCustomsValueAmountField;

        private AmountType declaredForCarriageValueAmountField;

        private AmountType declaredStatisticsValueAmountField;

        private AmountType freeOnBoardValueAmountField;

        private AmountType insuranceValueAmountField;

        private AmountType valueAmountField;

        private MeasureType grossWeightMeasureField;

        private MeasureType netWeightMeasureField;

        private MeasureType netNetWeightMeasureField;

        private MeasureType chargeableWeightMeasureField;

        private MeasureType grossVolumeMeasureField;

        private MeasureType netVolumeMeasureField;

        private QuantityType quantityField;

        private CodeType preferenceCriterionCodeField;

        private IdentifierType requiredCustomsIDField;

        private CodeType customsStatusCodeField;

        private QuantityType customsTariffQuantityField;

        private IndicatorType customsImportClassifiedIndicatorField;

        private ItemType[] itemField;

        private GoodsItemContainerType[] goodsItemContainerField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        private InvoiceLineType[] invoiceLineField;

        private TemperatureType[] temperatureField;

        private GoodsItemType[] containedGoodsItemField;

        private AddressType originAddressField;

        /// <summary>
        ///  An identifier for the goods item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Sequence number differentiating a specific goods item within a consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SequenceNumberID
        {
            get
            {
                return this.sequenceNumberIDField;
            }
            set
            {
                this.sequenceNumberIDField = value;
            }
        }

        /// <summary>
        ///  Plain language description of a goods item sufficient to identify it for customs, statistical, or transport purposes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the goods item includes hazardous items (dangerous goods).
        ///  Example: default is negative
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
            }
        }

        /// <summary>
        ///  Amount declared for Customs purposes of those goods in a consignment which are subject to the same Customs procedure and have the same tariff/statistical heading, country information, and duty regime.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DeclaredCustomsValueAmount
        {
            get
            {
                return this.declaredCustomsValueAmountField;
            }
            set
            {
                this.declaredCustomsValueAmountField = value;
            }
        }

        /// <summary>
        ///  Value declared by the shipper or his agent solely for the purpose of varying the carrier's level of liability from that provided in the contract of carriage in case of loss or damage to goods or delayed delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return this.declaredForCarriageValueAmountField;
            }
            set
            {
                this.declaredForCarriageValueAmountField = value;
            }
        }

        /// <summary>
        ///  Value declared for statistical purposes of those goods in a consignment which have the same statistical heading.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return this.declaredStatisticsValueAmountField;
            }
            set
            {
                this.declaredStatisticsValueAmountField = value;
            }
        }

        /// <summary>
        ///  Monetary amount that has to be or has been paid as calculated under the applicable trade delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType FreeOnBoardValueAmount
        {
            get
            {
                return this.freeOnBoardValueAmountField;
            }
            set
            {
                this.freeOnBoardValueAmountField = value;
            }
        }

        /// <summary>
        ///  The amount covered by an insurance for a particular goods item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType InsuranceValueAmount
        {
            get
            {
                return this.insuranceValueAmountField;
            }
            set
            {
                this.insuranceValueAmountField = value;
            }
        }

        /// <summary>
        ///  Specifies the amount on which a duty, tax, or fee will be assessed.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType ValueAmount
        {
            get
            {
                return this.valueAmountField;
            }
            set
            {
                this.valueAmountField = value;
            }
        }

        /// <summary>
        ///  Weight (mass) of goods, including packaging but excluding the carrier's equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossWeightMeasure
        {
            get
            {
                return this.grossWeightMeasureField;
            }
            set
            {
                this.grossWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  Weight (mass) of goods item, excluding all packing but including any packaging that normally goes with the goods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetWeightMeasure
        {
            get
            {
                return this.netWeightMeasureField;
            }
            set
            {
                this.netWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  Weight (mass) of goods without any packaging.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetNetWeightMeasure
        {
            get
            {
                return this.netNetWeightMeasureField;
            }
            set
            {
                this.netNetWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  Gross weight (mass) on which a charge is to be based.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType ChargeableWeightMeasure
        {
            get
            {
                return this.chargeableWeightMeasureField;
            }
            set
            {
                this.chargeableWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  Measurement normally arrived at by multiplying the maximum length, width, and height of the goods item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossVolumeMeasure
        {
            get
            {
                return this.grossVolumeMeasureField;
            }
            set
            {
                this.grossVolumeMeasureField = value;
            }
        }

        /// <summary>
        ///  The volume contained by a goods item, excluding the volume of any packaging material.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetVolumeMeasure
        {
            get
            {
                return this.netVolumeMeasureField;
            }
            set
            {
                this.netVolumeMeasureField = value;
            }
        }

        /// <summary>
        ///  Number of goods items.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <summary>
        ///  Specifies the treatment preference for this good according to international trading agreements.
        ///  Example: "Preference Criterion" is used in the following manner in the paper CO of another country (e.g.):
        ///  	 "A" - The good is "wholly obtained or produced entirely" in the territory of one or more of the NAFTA countries as reference in Article 415. Note: The purchase of a good in the territory does not necessarily render it "wholly obtained or produced".  If the good is an agricultural good, see also criterion F and Annex 703.2. (Reference: Article 401(a), 415).
        ///  	 "B" - ...
        ///  	 "C" - ...
        ///  	 "D" - ...
        ///  	 "E" - ...
        ///  	 "F" - The good is an originating agricultural good under preference criterion A,B, or C above and is not subjected to quantitative restriction in the importing NAFTA country because....
        ///  	 Thus, the column "Preference Criterion" will indicate either A, B, C,...
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PreferenceCriterionCode
        {
            get
            {
                return this.preferenceCriterionCodeField;
            }
            set
            {
                this.preferenceCriterionCodeField = value;
            }
        }

        /// <summary>
        ///  Additional tariff codes required to specify a type of goods for Customs, transport, statistical, or other regulatory purposes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType RequiredCustomsID
        {
            get
            {
                return this.requiredCustomsIDField;
            }
            set
            {
                this.requiredCustomsIDField = value;
            }
        }

        /// <summary>
        ///  Status of goods as identified by customs for regulation purposes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType CustomsStatusCode
        {
            get
            {
                return this.customsStatusCodeField;
            }
            set
            {
                this.customsStatusCodeField = value;
            }
        }

        /// <summary>
        ///  Quantity of the goods in the unit as required by Customs for tariff, statistical, or fiscal purposes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType CustomsTariffQuantity
        {
            get
            {
                return this.customsTariffQuantityField;
            }
            set
            {
                this.customsTariffQuantityField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the goods have been customs classified for import.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CustomsImportClassifiedIndicator
        {
            get
            {
                return this.customsImportClassifiedIndicatorField;
            }
            set
            {
                this.customsImportClassifiedIndicatorField = value;
            }
        }

        /// <summary>
        ///  Association to a description of the good or service.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public ItemType[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        ///  Association to describe the transporting of a goods item in a unit of transport equipment (e.g., container).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItemContainer")]
        public GoodsItemContainerType[] GoodsItemContainer
        {
            get
            {
                return this.goodsItemContainerField;
            }
            set
            {
                this.goodsItemContainerField = value;
            }
        }

        /// <summary>
        ///  Costs incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance (to the extent that they relate to the freight costs).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return this.freightAllowanceChargeField;
            }
            set
            {
                this.freightAllowanceChargeField = value;
            }
        }

        /// <summary>
        ///  Association to information directly relating to a line item of an invoice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine")]
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

        /// <summary>
        ///  Any temperatures associated with the goods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Temperature")]
        public TemperatureType[] Temperature
        {
            get
            {
                return this.temperatureField;
            }
            set
            {
                this.temperatureField = value;
            }
        }

        /// <summary>
        ///  Associates with any other goods items contained in this goods item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ContainedGoodsItem")]
        public GoodsItemType[] ContainedGoodsItem
        {
            get
            {
                return this.containedGoodsItemField;
            }
            set
            {
                this.containedGoodsItemField = value;
            }
        }

        /// <summary>
        ///  Region in which the goods have been produced or manufactured, according to criteria laid down for the purposes of application of the Customs tariff, or quantitative restrictions, or any other measure related to trade.
        /// </summary>
        public AddressType OriginAddress
        {
            get
            {
                return this.originAddressField;
            }
            set
            {
                this.originAddressField = value;
            }
        }
    }

    /// <summary>
    ///  Information directly relating to an item.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemType
    {

        private TextType[] descriptionField;

        private QuantityType packQuantityField;

        private NumericType packSizeNumericField;

        private IndicatorType catalogueIndicatorField;

        private NameType nameField;

        private IndicatorType hazardousRiskIndicatorField;

        private TextType additionalInformationField;

        private TextType[] keywordField;

        private NameType[] brandNameField;

        private NameType[] modelNameField;

        private ItemIdentificationType buyersItemIdentificationField;

        private ItemIdentificationType sellersItemIdentificationField;

        private ItemIdentificationType[] manufacturersItemIdentificationField;

        private ItemIdentificationType standardItemIdentificationField;

        private ItemIdentificationType catalogueItemIdentificationField;

        private ItemIdentificationType[] additionalItemIdentificationField;

        private DocumentReferenceType catalogueDocumentReferenceField;

        private DocumentReferenceType[] itemSpecificationDocumentReferenceField;

        private CountryType originCountryField;

        private CommodityClassificationType[] commodityClassificationField;

        private TransactionConditionsType[] transactionConditionsField;

        private HazardousItemType[] hazardousItemField;

        private TaxCategoryType[] classifiedTaxCategoryField;

        private ItemPropertyType[] additionalItemPropertyField;

        private PartyType[] manufacturerPartyField;

        private PartyType informationContentProviderPartyField;

        private AddressType[] originAddressField;

        private ItemInstanceType[] itemInstanceField;

        /// <summary>
        ///  Free-form field that can be used to give a text description of the item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  The unit packaging quantity.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType PackQuantity
        {
            get
            {
                return this.packQuantityField;
            }
            set
            {
                this.packQuantityField = value;
            }
        }

        /// <summary>
        ///  The number of items in a pack.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType PackSizeNumeric
        {
            get
            {
                return this.packSizeNumericField;
            }
            set
            {
                this.packSizeNumericField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the item was ordered from a Catalogue (true) or not (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CatalogueIndicator
        {
            get
            {
                return this.catalogueIndicatorField;
            }
            set
            {
                this.catalogueIndicatorField = value;
            }
        }

        /// <summary>
        ///  A short name optionally given to an item, such as a name from a Catalogue, as distinct from a description.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the item as delivered is hazardous.
        ///  Example: Default is negative
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
            }
        }

        /// <summary>
        ///  Provides more details of the item (e.g., the URL of a relevant web page).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AdditionalInformation
        {
            get
            {
                return this.additionalInformationField;
            }
            set
            {
                this.additionalInformationField = value;
            }
        }

        /// <summary>
        ///  A Seller Party-defined search string for the item. Also could be synonyms for identifying the item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Keyword", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }

        /// <summary>
        ///  Brand name for the item.
        ///  Example: Coca-Cola
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BrandName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType[] BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }

        /// <summary>
        ///  Model name for the item.
        ///  Example: "VW Beetle"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ModelName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType[] ModelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its identification according to the buyer's system.
        /// </summary>
        public ItemIdentificationType BuyersItemIdentification
        {
            get
            {
                return this.buyersItemIdentificationField;
            }
            set
            {
                this.buyersItemIdentificationField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its identification according to the seller's system.
        /// </summary>
        public ItemIdentificationType SellersItemIdentification
        {
            get
            {
                return this.sellersItemIdentificationField;
            }
            set
            {
                this.sellersItemIdentificationField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its identification according to the manufacturer's system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturersItemIdentification")]
        public ItemIdentificationType[] ManufacturersItemIdentification
        {
            get
            {
                return this.manufacturersItemIdentificationField;
            }
            set
            {
                this.manufacturersItemIdentificationField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its identification according to a standard system.
        /// </summary>
        public ItemIdentificationType StandardItemIdentification
        {
            get
            {
                return this.standardItemIdentificationField;
            }
            set
            {
                this.standardItemIdentificationField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its identification according to a cataloguing system.
        /// </summary>
        public ItemIdentificationType CatalogueItemIdentification
        {
            get
            {
                return this.catalogueItemIdentificationField;
            }
            set
            {
                this.catalogueItemIdentificationField = value;
            }
        }

        /// <summary>
        ///  Associates the item with other identification means.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemIdentification")]
        public ItemIdentificationType[] AdditionalItemIdentification
        {
            get
            {
                return this.additionalItemIdentificationField;
            }
            set
            {
                this.additionalItemIdentificationField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Catalogue.
        /// </summary>
        public DocumentReferenceType CatalogueDocumentReference
        {
            get
            {
                return this.catalogueDocumentReferenceField;
            }
            set
            {
                this.catalogueDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to a document providing Item specification.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemSpecificationDocumentReference")]
        public DocumentReferenceType[] ItemSpecificationDocumentReference
        {
            get
            {
                return this.itemSpecificationDocumentReferenceField;
            }
            set
            {
                this.itemSpecificationDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its country of origin.
        /// </summary>
        public CountryType OriginCountry
        {
            get
            {
                return this.originCountryField;
            }
            set
            {
                this.originCountryField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its classification(s) according to a commodity classifying system.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
        public CommodityClassificationType[] CommodityClassification
        {
            get
            {
                return this.commodityClassificationField;
            }
            set
            {
                this.commodityClassificationField = value;
            }
        }

        /// <summary>
        ///  Associates the item with sales conditions appertaining to it.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransactionConditions")]
        public TransactionConditionsType[] TransactionConditions
        {
            get
            {
                return this.transactionConditionsField;
            }
            set
            {
                this.transactionConditionsField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its hazardous item information.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("HazardousItem")]
        public HazardousItemType[] HazardousItem
        {
            get
            {
                return this.hazardousItemField;
            }
            set
            {
                this.hazardousItemField = value;
            }
        }

        /// <summary>
        ///  Classifies the item using one or more categories of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ClassifiedTaxCategory")]
        public TaxCategoryType[] ClassifiedTaxCategory
        {
            get
            {
                return this.classifiedTaxCategoryField;
            }
            set
            {
                this.classifiedTaxCategoryField = value;
            }
        }

        /// <summary>
        ///  Associates the item with a set of additional properties.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return this.additionalItemPropertyField;
            }
            set
            {
                this.additionalItemPropertyField = value;
            }
        }

        /// <summary>
        ///  Associates the item with its manufacturer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturerParty")]
        public PartyType[] ManufacturerParty
        {
            get
            {
                return this.manufacturerPartyField;
            }
            set
            {
                this.manufacturerPartyField = value;
            }
        }

        /// <summary>
        ///  Associates the item with the party responsible for the its specification.
        /// </summary>
        public PartyType InformationContentProviderParty
        {
            get
            {
                return this.informationContentProviderPartyField;
            }
            set
            {
                this.informationContentProviderPartyField = value;
            }
        }

        /// <summary>
        ///  Associates the item with the region of origin (not the country).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OriginAddress")]
        public AddressType[] OriginAddress
        {
            get
            {
                return this.originAddressField;
            }
            set
            {
                this.originAddressField = value;
            }
        }

        /// <summary>
        ///  An association to Item Instance.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemInstance")]
        public ItemInstanceType[] ItemInstance
        {
            get
            {
                return this.itemInstanceField;
            }
            set
            {
                this.itemInstanceField = value;
            }
        }
    }

    /// <summary>
    ///  Information about item identification.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemIdentificationType
    {

        private IdentifierType idField;

        private IdentifierType extendedIDField;

        private PhysicalAttributeType[] physicalAttributeField;

        private DimensionType[] measurementDimensionField;

        private PartyType issuerPartyField;

        /// <summary>
        ///  An identifier for an item.
        ///  Example: "CUST001" "3333-44-123"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  An extended identifier for the item that identifies the item with specific properties, e.g., Item 123 = Chair / Item 123 Ext 45 = brown chair.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ExtendedID
        {
            get
            {
                return this.extendedIDField;
            }
            set
            {
                this.extendedIDField = value;
            }
        }

        /// <summary>
        ///  An association to Physical Attribute.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAttribute")]
        public PhysicalAttributeType[] PhysicalAttribute
        {
            get
            {
                return this.physicalAttributeField;
            }
            set
            {
                this.physicalAttributeField = value;
            }
        }

        /// <summary>
        ///  An association to Measurement Dimension.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return this.measurementDimensionField;
            }
            set
            {
                this.measurementDimensionField = value;
            }
        }

        /// <summary>
        ///  An association to Issuer Party i.e. the Party that issued the Item Identification.
        /// </summary>
        public PartyType IssuerParty
        {
            get
            {
                return this.issuerPartyField;
            }
            set
            {
                this.issuerPartyField = value;
            }
        }
    }

    /// <summary>
    ///  Information about physical attributes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PhysicalAttributeType
    {

        private IdentifierType attributeIDField;

        private CodeType positionCodeField;

        private CodeType descriptionCodeField;

        private TextType[] descriptionField;

        /// <summary>
        ///  Identifies the physical attribute.
        ///  Example: "colour" "style"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <summary>
        ///  The position of the physical attribute, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PositionCode
        {
            get
            {
                return this.positionCodeField;
            }
            set
            {
                this.positionCodeField = value;
            }
        }

        /// <summary>
        ///  The description of the physical attribute, expressed as a code.
        ///  Example: "XXL","Small"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DescriptionCode
        {
            get
            {
                return this.descriptionCodeField;
            }
            set
            {
                this.descriptionCodeField = value;
            }
        }

        /// <summary>
        ///  The description of the physical attribute, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a measurable dimension of an item.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DimensionType
    {

        private IdentifierType attributeIDField;

        private MeasureType measureField;

        private TextType[] descriptionField;

        private MeasureType minimumMeasureField;

        private MeasureType maximumMeasureField;

        /// <summary>
        ///  An identifier for the attribute to which the measure applies.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <summary>
        ///  The measurement value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType Measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        /// <summary>
        ///  A description of the measurement attribute.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  The minimum value in a range of measurement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType MinimumMeasure
        {
            get
            {
                return this.minimumMeasureField;
            }
            set
            {
                this.minimumMeasureField = value;
            }
        }

        /// <summary>
        ///  The maximum value in a range of measurement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType MaximumMeasure
        {
            get
            {
                return this.maximumMeasureField;
            }
            set
            {
                this.maximumMeasureField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a document referred to in another document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DocumentReferenceType
    {

        private IdentifierType idField;

        private IndicatorType copyIndicatorField;

        private IdentifierType uUIDField;

        private DateType issueDateField;

        private CodeType documentTypeCodeField;

        private TextType documentTypeField;

        private TextType[] xPathField;

        private AttachmentType attachmentField;

        /// <summary>
        ///  Identifies the document being referred to.
        ///  Example: "PO-001" "3333-44-123"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Indicates whether the referenced document is a copy (true) or the original (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The date, assigned by the sender of the referenced document, on which the referenced document was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The document type, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentTypeCode
        {
            get
            {
                return this.documentTypeCodeField;
            }
            set
            {
                this.documentTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The document type, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType DocumentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <summary>
        ///  Refers to another part of the same document instance.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("XPath", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] XPath
        {
            get
            {
                return this.xPathField;
            }
            set
            {
                this.xPathField = value;
            }
        }

        /// <summary>
        ///  An attached document, externally referred to, referred to in the MIME location, or embedded.
        /// </summary>
        public AttachmentType Attachment
        {
            get
            {
                return this.attachmentField;
            }
            set
            {
                this.attachmentField = value;
            }
        }
    }

    /// <summary>
    ///  Information about an attached document. An attachment can be referred to externally (with the URI element) or internally (with the MIME reference element) or contained within the document itself (with the EmbeddedDocument element).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AttachmentType
    {

        private BinaryObjectType embeddedDocumentBinaryObjectField;

        private ExternalReferenceType externalReferenceField;

        /// <summary>
        ///  Contains an embedded document as a BLOB (binary large object).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BinaryObjectType EmbeddedDocumentBinaryObject
        {
            get
            {
                return this.embeddedDocumentBinaryObjectField;
            }
            set
            {
                this.embeddedDocumentBinaryObjectField = value;
            }
        }

        /// <summary>
        ///  An attached document, externally referred to, referred to in the MIME location, or embedded.
        /// </summary>
        public ExternalReferenceType ExternalReference
        {
            get
            {
                return this.externalReferenceField;
            }
            set
            {
                this.externalReferenceField = value;
            }
        }
    }

    /// <summary>
    ///  Information directly relating to an external reference i.e. a document stored at a remote location.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ExternalReferenceType
    {

        private IdentifierType uRIField;

        private TextType documentHashField;

        private DateType expiryDateField;

        private TimeType expiryTimeField;

        /// <summary>
        ///  The Uniform Resource Identifier (URI) that identifies where the external document is located.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <summary>
        ///  Specifies the hash code for the externally stored document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType DocumentHash
        {
            get
            {
                return this.documentHashField;
            }
            set
            {
                this.documentHashField = value;
            }
        }

        /// <summary>
        ///  The date on which the document can no longer be found on the URI.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }

        /// <summary>
        ///  The time on which the document can no longer be found on the URI.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType ExpiryTime
        {
            get
            {
                return this.expiryTimeField;
            }
            set
            {
                this.expiryTimeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Commodity Classification.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CommodityClassificationType
    {

        private CodeType natureCodeField;

        private CodeType cargoTypeCodeField;

        private CodeType commodityCodeField;

        private CodeType itemClassificationCodeField;

        /// <summary>
        ///  The high-level nature of the Classification issued by a specific maintenance agency, expressed as a code.
        ///  Example: "wooden products"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType NatureCode
        {
            get
            {
                return this.natureCodeField;
            }
            set
            {
                this.natureCodeField = value;
            }
        }

        /// <summary>
        ///  The type of cargo, expressed as a code.
        ///  Example: "Refrigerated"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType CargoTypeCode
        {
            get
            {
                return this.cargoTypeCodeField;
            }
            set
            {
                this.cargoTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The harmonized international commodity code for regulatory (customs and trade statistics) purposes.
        ///  Example: "1102222883"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType CommodityCode
        {
            get
            {
                return this.commodityCodeField;
            }
            set
            {
                this.commodityCodeField = value;
            }
        }

        /// <summary>
        ///  The trade commodity classification, expressed as a code.
        ///  Example: "3440234"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ItemClassificationCode
        {
            get
            {
                return this.itemClassificationCodeField;
            }
            set
            {
                this.itemClassificationCodeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about purchasing, sales, or payment conditions.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransactionConditionsType
    {

        private IdentifierType idField;

        private CodeType actionCodeField;

        private TextType[] descriptionField;

        private DocumentReferenceType[] documentReferenceField;

        /// <summary>
        ///  Identifies conditions of the transaction, typically Purchase/Sales Conditions.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  An action relating to sales or payment conditions, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ActionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                this.actionCodeField = value;
            }
        }

        /// <summary>
        ///  The description of the transaction conditions.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Hazardous Item.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class HazardousItemType
    {

        private IdentifierType idField;

        private TextType placardNotationField;

        private TextType placardEndorsementField;

        private TextType additionalInformationField;

        private CodeType uNDGCodeField;

        private CodeType emergencyProceduresCodeField;

        private CodeType medicalFirstAidGuideCodeField;

        private NameType technicalNameField;

        private NameType categoryNameField;

        private CodeType hazardousCategoryCodeField;

        private IdentifierType upperOrangeHazardPlacardIDField;

        private IdentifierType lowerOrangeHazardPlacardIDField;

        private IdentifierType markingIDField;

        private IdentifierType hazardClassIDField;

        private MeasureType netWeightMeasureField;

        private MeasureType netVolumeMeasureField;

        private QuantityType quantityField;

        private PartyType contactPartyField;

        private SecondaryHazardType[] secondaryHazardField;

        private HazardousGoodsTransitType[] hazardousGoodsTransitField;

        private TemperatureType emergencyTemperatureField;

        private TemperatureType flashpointTemperatureField;

        private TemperatureType[] additionalTemperatureField;

        /// <summary>
        ///  The identifier for a Hazardous Item.
        ///  Example: "Round Up"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The placard notation corresponding to the hazard class of the hazardous commodity. Can also be the hazard identification number of the orange placard (upper part) required on the means of transport.
        ///  Example: "5.1"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PlacardNotation
        {
            get
            {
                return this.placardNotationField;
            }
            set
            {
                this.placardNotationField = value;
            }
        }

        /// <summary>
        ///  The placard endorsement that is to be shown on the shipping papers for the hazardous commodity. Can also be used for the number of the orange placard (lower part) required on the means of transport.
        ///  Example: "2"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PlacardEndorsement
        {
            get
            {
                return this.placardEndorsementField;
            }
            set
            {
                this.placardEndorsementField = value;
            }
        }

        /// <summary>
        ///  Additional information about the hazardous substance. Can be used to specify information such as the type of regulatory requirements that apply to a description.
        ///  Example: "Must be stored away from flammable materials" "N.O.S. or a Waste Characteristics Code in conjunction with an EPA Waste Stream code"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AdditionalInformation
        {
            get
            {
                return this.additionalInformationField;
            }
            set
            {
                this.additionalInformationField = value;
            }
        }

        /// <summary>
        ///  The identifier assigned to transportable hazardous goods by the United Nations, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType UNDGCode
        {
            get
            {
                return this.uNDGCodeField;
            }
            set
            {
                this.uNDGCodeField = value;
            }
        }

        /// <summary>
        ///  The emergency procedures for the Hazardous Item, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType EmergencyProceduresCode
        {
            get
            {
                return this.emergencyProceduresCodeField;
            }
            set
            {
                this.emergencyProceduresCodeField = value;
            }
        }

        /// <summary>
        ///  The identifier of a medical first aid guide that is relevant to specific hazardous goods, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType MedicalFirstAidGuideCode
        {
            get
            {
                return this.medicalFirstAidGuideCodeField;
            }
            set
            {
                this.medicalFirstAidGuideCodeField = value;
            }
        }

        /// <summary>
        ///  The full technical name of the specific hazardous substance.
        ///  Example: "Granular Sodium Chlorate WeedKiller"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType TechnicalName
        {
            get
            {
                return this.technicalNameField;
            }
            set
            {
                this.technicalNameField = value;
            }
        }

        /// <summary>
        ///  The name of the category of hazard that applies to the Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType CategoryName
        {
            get
            {
                return this.categoryNameField;
            }
            set
            {
                this.categoryNameField = value;
            }
        }

        /// <summary>
        ///  Code specifying a kind of hazard for a material.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType HazardousCategoryCode
        {
            get
            {
                return this.hazardousCategoryCodeField;
            }
            set
            {
                this.hazardousCategoryCodeField = value;
            }
        }

        /// <summary>
        ///  Specifies the identity number for the upper part of the orange hazard placard required on the means of transport.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UpperOrangeHazardPlacardID
        {
            get
            {
                return this.upperOrangeHazardPlacardIDField;
            }
            set
            {
                this.upperOrangeHazardPlacardIDField = value;
            }
        }

        /// <summary>
        ///  Specifies the identity number for the lower part of the orange hazard placard required on the means of transport.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LowerOrangeHazardPlacardID
        {
            get
            {
                return this.lowerOrangeHazardPlacardIDField;
            }
            set
            {
                this.lowerOrangeHazardPlacardIDField = value;
            }
        }

        /// <summary>
        ///  Identifies the marking of dangerous goods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType MarkingID
        {
            get
            {
                return this.markingIDField;
            }
            set
            {
                this.markingIDField = value;
            }
        }

        /// <summary>
        ///  Identifies a hazard class applicable to dangerous goods as defined by the relevant regulation authority, such as the IMDG Class Number of the SOLAS Convention of IMO and the ADR/RID Class Number for the road/rail environment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType HazardClassID
        {
            get
            {
                return this.hazardClassIDField;
            }
            set
            {
                this.hazardClassIDField = value;
            }
        }

        /// <summary>
        ///  The total net weight of hazardous goods; the weight of the goods plus packaging.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetWeightMeasure
        {
            get
            {
                return this.netWeightMeasureField;
            }
            set
            {
                this.netWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  The volume of hazardous goods net of packaging and transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetVolumeMeasure
        {
            get
            {
                return this.netVolumeMeasureField;
            }
            set
            {
                this.netVolumeMeasureField = value;
            }
        }

        /// <summary>
        ///  The quantity of goods that are hazardous.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <summary>
        ///  Associates the Hazardous Item with details of an individual, group, or body that is the contact in case of hazard incident.
        /// </summary>
        public PartyType ContactParty
        {
            get
            {
                return this.contactPartyField;
            }
            set
            {
                this.contactPartyField = value;
            }
        }

        /// <summary>
        ///  Associates the Hazardous Item with information about secondary hazards.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SecondaryHazard")]
        public SecondaryHazardType[] SecondaryHazard
        {
            get
            {
                return this.secondaryHazardField;
            }
            set
            {
                this.secondaryHazardField = value;
            }
        }

        /// <summary>
        ///  Associates the Hazardous Item with information about the transportation of hazardous goods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return this.hazardousGoodsTransitField;
            }
            set
            {
                this.hazardousGoodsTransitField = value;
            }
        }

        /// <summary>
        ///  Associates the Hazardous Item with the temperature at which emergency procedures apply during the handling of temperature-controlled hazardous goods.
        /// </summary>
        public TemperatureType EmergencyTemperature
        {
            get
            {
                return this.emergencyTemperatureField;
            }
            set
            {
                this.emergencyTemperatureField = value;
            }
        }

        /// <summary>
        ///  Associates the Hazardous Item with the lowest temperature at which the vapor of a combustible liquid can be made to ignite momentarily in air, known in hazardous goods procedures as the flashpoint.
        /// </summary>
        public TemperatureType FlashpointTemperature
        {
            get
            {
                return this.flashpointTemperatureField;
            }
            set
            {
                this.flashpointTemperatureField = value;
            }
        }

        /// <summary>
        ///  Information providing details of temperatures relevant to the handling of hazardous goods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalTemperature")]
        public TemperatureType[] AdditionalTemperature
        {
            get
            {
                return this.additionalTemperatureField;
            }
            set
            {
                this.additionalTemperatureField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Secondary Hazard (related to a Hazardous Item).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SecondaryHazardType
    {

        private IdentifierType idField;

        private TextType placardNotationField;

        private TextType placardEndorsementField;

        private CodeType emergencyProceduresCodeField;

        private TextType extensionField;

        /// <summary>
        ///  Identifies the Secondary Hazard.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The placard notation corresponding to the hazard class of the hazardous commodity. Can also be the hazard identification number of the orange placard (upper part) required on the means of transport.
        ///  Example: "5.1"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PlacardNotation
        {
            get
            {
                return this.placardNotationField;
            }
            set
            {
                this.placardNotationField = value;
            }
        }

        /// <summary>
        ///  The placard endorsement that is to be shown on the shipping papers for the hazardous commodity. Can also be used for the number of the orange placard (lower part) required on the means of transport.
        ///  Example: "2"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PlacardEndorsement
        {
            get
            {
                return this.placardEndorsementField;
            }
            set
            {
                this.placardEndorsementField = value;
            }
        }

        /// <summary>
        ///  Emergency procedures for hazardous goods, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType EmergencyProceduresCode
        {
            get
            {
                return this.emergencyProceduresCodeField;
            }
            set
            {
                this.emergencyProceduresCodeField = value;
            }
        }

        /// <summary>
        ///  Additional information about the hazardous substance. Can be used to specify information such as the type of regulatory requirements that apply to a description.
        ///  Example: "N.O.S. or a Waste Characteristics Code in conjunction with an EPA Waste Stream code"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Hazardous Goods Transit.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class HazardousGoodsTransitType
    {

        private CodeType transportEmergencyCardCodeField;

        private CodeType packingCriteriaCodeField;

        private CodeType hazardousRegulationCodeField;

        private CodeType inhalationToxicityZoneCodeField;

        private CodeType transportAuthorizationCodeField;

        private TemperatureType maximumTemperatureField;

        private TemperatureType minimumTemperatureField;

        /// <summary>
        ///  The identifier for a transport emergency card, describing the actions to be taken in an emergency in transporting the Hazardous Goods. May be the identity number of a hazardous emergency response plan assigned by the appropriate authority.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportEmergencyCardCode
        {
            get
            {
                return this.transportEmergencyCardCodeField;
            }
            set
            {
                this.transportEmergencyCardCodeField = value;
            }
        }

        /// <summary>
        ///  A code identifying the packaging requirement for the transportation of the Hazardous Goods as assigned by IATA/IMDB/ADR/RID etc.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PackingCriteriaCode
        {
            get
            {
                return this.packingCriteriaCodeField;
            }
            set
            {
                this.packingCriteriaCodeField = value;
            }
        }

        /// <summary>
        ///  The identifier for a set of legal regulations that govern the transportation of the Hazardous Goods, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType HazardousRegulationCode
        {
            get
            {
                return this.hazardousRegulationCodeField;
            }
            set
            {
                this.hazardousRegulationCodeField = value;
            }
        }

        /// <summary>
        ///  An identifier for the Inhalation Toxicity Hazard Zone for the Hazardous Goods, as defined by the US Department of Transportation, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType InhalationToxicityZoneCode
        {
            get
            {
                return this.inhalationToxicityZoneCodeField;
            }
            set
            {
                this.inhalationToxicityZoneCodeField = value;
            }
        }

        /// <summary>
        ///  Code specifying the authorization for the transportation of hazardous cargo.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportAuthorizationCode
        {
            get
            {
                return this.transportAuthorizationCodeField;
            }
            set
            {
                this.transportAuthorizationCodeField = value;
            }
        }

        /// <summary>
        ///  An association to Maximum Temperature (at which the Hazardous Goods can be safely transported).
        /// </summary>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
            }
        }

        /// <summary>
        ///  An association to Minimum Temperature (at which the Hazardous Goods can be safely transported).
        /// </summary>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
            }
        }
    }

    /// <summary>
    ///  Information about temperature.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TemperatureType
    {

        private IdentifierType attributeIDField;

        private MeasureType measureField;

        private TextType[] descriptionField;

        /// <summary>
        ///  An identifier for temperature.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }

        /// <summary>
        ///  The temperature measurement value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType Measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        /// <summary>
        ///  A description of the temperature measurement.
        ///  Example: "at sea level"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a tax category.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxCategoryType
    {

        private IdentifierType idField;

        private NameType nameField;

        private PercentType percentField;

        private MeasureType baseUnitMeasureField;

        private AmountType perUnitAmountField;

        private CodeType taxExemptionReasonCodeField;

        private TextType taxExemptionReasonField;

        private TextType tierRangeField;

        private PercentType tierRatePercentField;

        private TaxSchemeType taxSchemeField;

        /// <summary>
        ///  Identifies the tax category.
        ///  Example: "ZeroRatedGoods" "NotTaxable" "Standard Rate"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The name of the tax category.
        ///  Example: "Luxury Goods","Wine Equalization", "Exempt"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  The tax rate for the category, expressed as a percentage.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <summary>
        ///  Where a tax is applied at a certain rate per unit, the measure of units on which the tax calculation is based.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType BaseUnitMeasure
        {
            get
            {
                return this.baseUnitMeasureField;
            }
            set
            {
                this.baseUnitMeasureField = value;
            }
        }

        /// <summary>
        ///  Where a tax is applied at a certain rate per unit, the rate per unit applied.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PerUnitAmount
        {
            get
            {
                return this.perUnitAmountField;
            }
            set
            {
                this.perUnitAmountField = value;
            }
        }

        /// <summary>
        ///  The reason for tax being exempted expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TaxExemptionReasonCode
        {
            get
            {
                return this.taxExemptionReasonCodeField;
            }
            set
            {
                this.taxExemptionReasonCodeField = value;
            }
        }

        /// <summary>
        ///  The reason for tax being exempted.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType TaxExemptionReason
        {
            get
            {
                return this.taxExemptionReasonField;
            }
            set
            {
                this.taxExemptionReasonField = value;
            }
        }

        /// <summary>
        ///  Where a tax is tiered, the range of tiers applied in the calculation of the tax subtotal for the tax category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType TierRange
        {
            get
            {
                return this.tierRangeField;
            }
            set
            {
                this.tierRangeField = value;
            }
        }

        /// <summary>
        ///  Where a tax is tiered, the rate of tax applied to the range of tiers in the calculation of the tax subtotal for the tax category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType TierRatePercent
        {
            get
            {
                return this.tierRatePercentField;
            }
            set
            {
                this.tierRatePercentField = value;
            }
        }

        /// <summary>
        ///  An association to Tax Scheme.
        /// </summary>
        public TaxSchemeType TaxScheme
        {
            get
            {
                return this.taxSchemeField;
            }
            set
            {
                this.taxSchemeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about specific Item Properties.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemPropertyType
    {

        private NameType nameField;

        private TextType valueField;

        private PeriodType usabilityPeriodField;

        private ItemPropertyGroupType[] itemPropertyGroupField;

        /// <summary>
        ///  The name of the Item Property.
        ///  Example: "Energy Rating", "Collar Size", "Fat Content"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  The Item Property value.
        ///  Example: "100 watts", "15 European", "20% +/- 5%"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <summary>
        ///  The period for which the Item Property is valid.
        /// </summary>
        public PeriodType UsabilityPeriod
        {
            get
            {
                return this.usabilityPeriodField;
            }
            set
            {
                this.usabilityPeriodField = value;
            }
        }

        /// <summary>
        ///  An association to Item Property Group.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemPropertyGroup")]
        public ItemPropertyGroupType[] ItemPropertyGroup
        {
            get
            {
                return this.itemPropertyGroupField;
            }
            set
            {
                this.itemPropertyGroupField = value;
            }
        }
    }

    /// <summary>
    ///  Information about sets of classifications (or groups) of Item Properties.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemPropertyGroupType
    {

        private IdentifierType idField;

        private NameType nameField;

        /// <summary>
        ///  An identifier for the Item Property Group.
        ///  Example: "233-004"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The name of the Item Property Group.
        ///  Example: "Electrical Specifications", "Dietary Content"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a specific instance of an item.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemInstanceType
    {

        private IdentifierType productTraceIDField;

        private DateType manufactureDateField;

        private TimeType manufactureTimeField;

        private IdentifierType registrationIDField;

        private IdentifierType serialIDField;

        private ItemPropertyType[] additionalItemPropertyField;

        private LotIdentificationType lotIdentificationField;

        /// <summary>
        ///  An identifier used for tracing the item, such as the EPC number used in RFID.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ProductTraceID
        {
            get
            {
                return this.productTraceIDField;
            }
            set
            {
                this.productTraceIDField = value;
            }
        }

        /// <summary>
        ///  The date of manufacture of the Item Instance.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ManufactureDate
        {
            get
            {
                return this.manufactureDateField;
            }
            set
            {
                this.manufactureDateField = value;
            }
        }

        /// <summary>
        ///  The time of manufacture of the Item Instance.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType ManufactureTime
        {
            get
            {
                return this.manufactureTimeField;
            }
            set
            {
                this.manufactureTimeField = value;
            }
        }

        /// <summary>
        ///  The registration identifier of the Item Instance.
        ///  Example: car registration or licensing number
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType RegistrationID
        {
            get
            {
                return this.registrationIDField;
            }
            set
            {
                this.registrationIDField = value;
            }
        }

        /// <summary>
        ///  The serial number of the Item Instance.
        ///  Example: chassis number of a car
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SerialID
        {
            get
            {
                return this.serialIDField;
            }
            set
            {
                this.serialIDField = value;
            }
        }

        /// <summary>
        ///  An association to Additional Item Property.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return this.additionalItemPropertyField;
            }
            set
            {
                this.additionalItemPropertyField = value;
            }
        }

        /// <summary>
        ///  Associates the item instance with its lot identification (the identification that allows recall of the item if necessary).
        /// </summary>
        public LotIdentificationType LotIdentification
        {
            get
            {
                return this.lotIdentificationField;
            }
            set
            {
                this.lotIdentificationField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a lot (of Item Instances).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LotIdentificationType
    {

        private IdentifierType lotNumberIDField;

        private DateType expiryDateField;

        private ItemPropertyType[] additionalItemPropertyField;

        /// <summary>
        ///  Identifies the lot.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LotNumberID
        {
            get
            {
                return this.lotNumberIDField;
            }
            set
            {
                this.lotNumberIDField = value;
            }
        }

        /// <summary>
        ///  The expiry date of the lot.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }

        /// <summary>
        ///  An association to Additional Item Property.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return this.additionalItemPropertyField;
            }
            set
            {
                this.additionalItemPropertyField = value;
            }
        }
    }

    /// <summary>
    ///  How goods items are split across transport equipment.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class GoodsItemContainerType
    {

        private IdentifierType idField;

        private QuantityType quantityField;

        private TransportEquipmentType[] transportEquipmentField;

        /// <summary>
        ///  Identifies goods items split across transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Number of goods items loaded into or onto one piece of transport equipment as a total consignment or part of a consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <summary>
        ///  Associates the containers for a single goods item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment
        {
            get
            {
                return this.transportEquipmentField;
            }
            set
            {
                this.transportEquipmentField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Transport Equipment; a piece of equipment used to transport goods.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportEquipmentType
    {

        private IdentifierType idField;

        private TransportEquipmentTypeCodeType transportEquipmentTypeCodeField;

        private CodeType providerTypeCodeField;

        private CodeType ownerTypeCodeField;

        private CodeType sizeTypeCodeField;

        private CodeType dispositionCodeField;

        private CodeType fullnessIndicationCodeField;

        private IndicatorType refrigerationOnIndicatorField;

        private TextType informationField;

        private IndicatorType returnabilityIndicatorField;

        private IndicatorType legalStatusIndicatorField;

        private DimensionType[] measurementDimensionField;

        private TransportEquipmentSealType[] transportEquipmentSealField;

        private TemperatureType minimumTemperatureField;

        private TemperatureType maximumTemperatureField;

        private PartyType providerPartyField;

        private PartyType loadingProofPartyField;

        private LocationType1 loadingLocationField;

        /// <summary>
        ///  Identifies the transport equipment.
        ///  Example: "OCLU 1234567"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Identifies the type of the transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportEquipmentTypeCodeType TransportEquipmentTypeCode
        {
            get
            {
                return this.transportEquipmentTypeCodeField;
            }
            set
            {
                this.transportEquipmentTypeCodeField = value;
            }
        }

        /// <summary>
        ///  Identifies the type of provider of the transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ProviderTypeCode
        {
            get
            {
                return this.providerTypeCodeField;
            }
            set
            {
                this.providerTypeCodeField = value;
            }
        }

        /// <summary>
        ///  Identifies the type of owner of a piece of transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType OwnerTypeCode
        {
            get
            {
                return this.ownerTypeCodeField;
            }
            set
            {
                this.ownerTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The size and type of a piece of transport equipment, expressed as a code. When the transport equipment is a shipping container, it is recommended to use ContainerSizeTypeCode for validation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType SizeTypeCode
        {
            get
            {
                return this.sizeTypeCodeField;
            }
            set
            {
                this.sizeTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The current disposition of the transport equipment, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DispositionCode
        {
            get
            {
                return this.dispositionCodeField;
            }
            set
            {
                this.dispositionCodeField = value;
            }
        }

        /// <summary>
        ///  A code indicating whether a piece of transport equipment is full, partially full, or empty.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType FullnessIndicationCode
        {
            get
            {
                return this.fullnessIndicationCodeField;
            }
            set
            {
                this.fullnessIndicationCodeField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the transport equipment's refrigeration is on (true) or off (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType RefrigerationOnIndicator
        {
            get
            {
                return this.refrigerationOnIndicatorField;
            }
            set
            {
                this.refrigerationOnIndicatorField = value;
            }
        }

        /// <summary>
        ///  Additional information about the transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
            }
        }

        /// <summary>
        ///  Indicates whether a particular item of transport equipment is returnable.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType ReturnabilityIndicator
        {
            get
            {
                return this.returnabilityIndicatorField;
            }
            set
            {
                this.returnabilityIndicatorField = value;
            }
        }

        /// <summary>
        ///  Legal status of the transport equipment with respect to the Container Convention code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType LegalStatusIndicator
        {
            get
            {
                return this.legalStatusIndicatorField;
            }
            set
            {
                this.legalStatusIndicatorField = value;
            }
        }

        /// <summary>
        ///  An association to Dimension.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return this.measurementDimensionField;
            }
            set
            {
                this.measurementDimensionField = value;
            }
        }

        /// <summary>
        ///  An association to Transport Equipment Seal.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipmentSeal")]
        public TransportEquipmentSealType[] TransportEquipmentSeal
        {
            get
            {
                return this.transportEquipmentSealField;
            }
            set
            {
                this.transportEquipmentSealField = value;
            }
        }

        /// <summary>
        ///  The minimum required operating temperature for the container (reefer).
        /// </summary>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
            }
        }

        /// <summary>
        ///  The maximum required operating temperature for the container (reefer).
        /// </summary>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
            }
        }

        /// <summary>
        ///  The party that provides the transport equipment.
        /// </summary>
        public PartyType ProviderParty
        {
            get
            {
                return this.providerPartyField;
            }
            set
            {
                this.providerPartyField = value;
            }
        }

        /// <summary>
        ///  The authorized party responsible for certifying that the goods were loaded into the transport equipment.
        /// </summary>
        public PartyType LoadingProofParty
        {
            get
            {
                return this.loadingProofPartyField;
            }
            set
            {
                this.loadingProofPartyField = value;
            }
        }

        /// <summary>
        ///  Identifies the location where the goods are loaded into the transport equipment.
        /// </summary>
        public LocationType1 LoadingLocation
        {
            get
            {
                return this.loadingLocationField;
            }
            set
            {
                this.loadingLocationField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a transport equipment seal (a security device attached to the doors of a shipping container).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportEquipmentSealType
    {

        private IdentifierType idField;

        private CodeType sealIssuerTypeCodeField;

        private TextType conditionField;

        private CodeType sealStatusCodeField;

        private TextType sealingPartyTypeField;

        /// <summary>
        ///  Identifies the seal.
        ///  Example: "ACS1234"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The type of party that issues and is responsible for a seal, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType SealIssuerTypeCode
        {
            get
            {
                return this.sealIssuerTypeCodeField;
            }
            set
            {
                this.sealIssuerTypeCodeField = value;
            }
        }

        /// <summary>
        ///  Information about the condition of a seal.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <summary>
        ///  The status of a seal, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType SealStatusCode
        {
            get
            {
                return this.sealStatusCodeField;
            }
            set
            {
                this.sealStatusCodeField = value;
            }
        }

        /// <summary>
        ///  Textual description of the role of a sealing party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType SealingPartyType
        {
            get
            {
                return this.sealingPartyTypeField;
            }
            set
            {
                this.sealingPartyTypeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a charge or discount price component.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AllowanceChargeType
    {

        private IdentifierType idField;

        private IndicatorType chargeIndicatorField;

        private AllowanceChargeReasonCodeType allowanceChargeReasonCodeField;

        private TextType allowanceChargeReasonField;

        private NumericType multiplierFactorNumericField;

        private IndicatorType prepaidIndicatorField;

        private NumericType sequenceNumericField;

        private AmountType amountField;

        private AmountType baseAmountField;

        private CodeType accountingCostCodeField;

        private TextType accountingCostField;

        private TaxCategoryType[] taxCategoryField;

        private TaxTotalType taxTotalField;

        private PaymentMeansType[] paymentMeansField;

        /// <summary>
        ///  Identifies an Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Indicates whether the Allowance Charge is a charge (true) or a discount (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType ChargeIndicator
        {
            get
            {
                return this.chargeIndicatorField;
            }
            set
            {
                this.chargeIndicatorField = value;
            }
        }

        /// <summary>
        ///  The reason for the Allowance Charge, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceChargeReasonCodeType AllowanceChargeReasonCode
        {
            get
            {
                return this.allowanceChargeReasonCodeField;
            }
            set
            {
                this.allowanceChargeReasonCodeField = value;
            }
        }

        /// <summary>
        ///  The reason for the Allowance Charge, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AllowanceChargeReason
        {
            get
            {
                return this.allowanceChargeReasonField;
            }
            set
            {
                this.allowanceChargeReasonField = value;
            }
        }

        /// <summary>
        ///  The factor applied to the Base Amount to calculate the Allowance Charge.
        ///  Example: 0.20
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType MultiplierFactorNumeric
        {
            get
            {
                return this.multiplierFactorNumericField;
            }
            set
            {
                this.multiplierFactorNumericField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the Allowance Charge is prepaid (true) or not (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType PrepaidIndicator
        {
            get
            {
                return this.prepaidIndicatorField;
            }
            set
            {
                this.prepaidIndicatorField = value;
            }
        }

        /// <summary>
        ///  Identifies the numerical order sequence in which Allowance Charges are calculated when multiple Allowance Charges apply. If all Allowance Charges apply to the same Base Amount, SequenceNumeric will be '1' for all Allowance Charges.
        ///  Example: 1, 2, 3, 4, etc.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType SequenceNumeric
        {
            get
            {
                return this.sequenceNumericField;
            }
            set
            {
                this.sequenceNumericField = value;
            }
        }

        /// <summary>
        ///  The Allowance Charge amount.
        ///  Example: 35,23
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <summary>
        ///  The amount to which the MultiplierFactorNumeric is applied to calculate the Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType BaseAmount
        {
            get
            {
                return this.baseAmountField;
            }
            set
            {
                this.baseAmountField = value;
            }
        }

        /// <summary>
        ///  The buyer's accounting code as applied to the Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting cost centre as applied to the Allowance Charge expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  An association to Tax Category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxCategory")]
        public TaxCategoryType[] TaxCategory
        {
            get
            {
                return this.taxCategoryField;
            }
            set
            {
                this.taxCategoryField = value;
            }
        }

        /// <summary>
        ///  An association to Tax Total.
        /// </summary>
        public TaxTotalType TaxTotal
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
        ///  An association to Payment Means.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans")]
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
    }

    /// <summary>
    ///  Information about a total amount of a particular type of tax.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxTotalType
    {

        private AmountType taxAmountField;

        private AmountType roundingAmountField;

        private IndicatorType taxEvidenceIndicatorField;

        private TaxSubtotalType[] taxSubtotalField;

        /// <summary>
        ///  The total tax amount for particular tax scheme e.g. VAT;  the sum of each of the tax subtotals for each tax category within the tax scheme.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }

        /// <summary>
        ///  The rounding amount (positive or negative) added to the calculated tax total to produce the rounded TotalTaxAmount.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType RoundingAmount
        {
            get
            {
                return this.roundingAmountField;
            }
            set
            {
                this.roundingAmountField = value;
            }
        }

        /// <summary>
        ///  An indicator as to whether these totals are recognized as legal evidence for taxation purposes.
        ///  Example: default is negative
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType TaxEvidenceIndicator
        {
            get
            {
                return this.taxEvidenceIndicatorField;
            }
            set
            {
                this.taxEvidenceIndicatorField = value;
            }
        }

        /// <summary>
        ///  An association to Tax Subtotal.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxSubtotal")]
        public TaxSubtotalType[] TaxSubtotal
        {
            get
            {
                return this.taxSubtotalField;
            }
            set
            {
                this.taxSubtotalField = value;
            }
        }
    }

    /// <summary>
    ///  Information about the subtotal for a particular tax category within a tax scheme, such as standard rate within VAT.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxSubtotalType
    {

        private AmountType taxableAmountField;

        private AmountType taxAmountField;

        private NumericType calculationSequenceNumericField;

        private AmountType transactionCurrencyTaxAmountField;

        private PercentType percentField;

        private MeasureType baseUnitMeasureField;

        private AmountType perUnitAmountField;

        private TextType tierRangeField;

        private PercentType tierRatePercentField;

        private TaxCategoryType taxCategoryField;

        /// <summary>
        ///  The net amount to which the tax percent (rate) is applied to calculate the tax amount.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TaxableAmount
        {
            get
            {
                return this.taxableAmountField;
            }
            set
            {
                this.taxableAmountField = value;
            }
        }

        /// <summary>
        ///  The amount of tax stated explicitly.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }

        /// <summary>
        ///  Identifies the numerical order sequence in which taxes are applied when multiple taxes are attracted. If all taxes apply to the same taxable amount, CalculationSequenceNumeric will be '1' for all taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType CalculationSequenceNumeric
        {
            get
            {
                return this.calculationSequenceNumericField;
            }
            set
            {
                this.calculationSequenceNumericField = value;
            }
        }

        /// <summary>
        ///  The tax amount, expressed in the currency used for invoicing.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TransactionCurrencyTaxAmount
        {
            get
            {
                return this.transactionCurrencyTaxAmountField;
            }
            set
            {
                this.transactionCurrencyTaxAmountField = value;
            }
        }

        /// <summary>
        ///  The tax rate for the category, expressed as a percentage.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <summary>
        ///  Where a tax is applied at a certain rate per unit, the measure of units on which the tax calculation is based.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType BaseUnitMeasure
        {
            get
            {
                return this.baseUnitMeasureField;
            }
            set
            {
                this.baseUnitMeasureField = value;
            }
        }

        /// <summary>
        ///  Where a tax is applied at a certain rate per unit, the rate per unit applied.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PerUnitAmount
        {
            get
            {
                return this.perUnitAmountField;
            }
            set
            {
                this.perUnitAmountField = value;
            }
        }

        /// <summary>
        ///  Where a tax is tiered, the range of tiers applied in the calculation of the tax subtotal for the tax category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType TierRange
        {
            get
            {
                return this.tierRangeField;
            }
            set
            {
                this.tierRangeField = value;
            }
        }

        /// <summary>
        ///  Where a tax is tiered, the rate of tax applied to the range of tiers in the calculation of the tax subtotal for the tax category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType TierRatePercent
        {
            get
            {
                return this.tierRatePercentField;
            }
            set
            {
                this.tierRatePercentField = value;
            }
        }

        /// <summary>
        ///  An association to Tax Category.
        /// </summary>
        public TaxCategoryType TaxCategory
        {
            get
            {
                return this.taxCategoryField;
            }
            set
            {
                this.taxCategoryField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Payment Means.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PaymentMeansType
    {

        private IdentifierType idField;

        private PaymentMeansCodeType paymentMeansCodeField;

        private DateType paymentDueDateField;

        private CodeType paymentChannelCodeField;

        private IdentifierType instructionIDField;

        private TextType[] instructionNoteField;

        private IdentifierType[] paymentIDField;

        private CardAccountType cardAccountField;

        private FinancialAccountType payerFinancialAccountField;

        private FinancialAccountType payeeFinancialAccountField;

        private CreditAccountType creditAccountField;

        /// <summary>
        ///  Identifies the Payment Means.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The Payment Means expressed as a code
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentMeansCodeType PaymentMeansCode
        {
            get
            {
                return this.paymentMeansCodeField;
            }
            set
            {
                this.paymentMeansCodeField = value;
            }
        }

        /// <summary>
        ///  The date on which payment is due for the Payment Means.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType PaymentDueDate
        {
            get
            {
                return this.paymentDueDateField;
            }
            set
            {
                this.paymentDueDateField = value;
            }
        }

        /// <summary>
        ///  The Payment Channel, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PaymentChannelCode
        {
            get
            {
                return this.paymentChannelCodeField;
            }
            set
            {
                this.paymentChannelCodeField = value;
            }
        }

        /// <summary>
        ///  Identifies the Payment Instruction.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType InstructionID
        {
            get
            {
                return this.instructionIDField;
            }
            set
            {
                this.instructionIDField = value;
            }
        }

        /// <summary>
        ///  Free-form text applying to the Payment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] InstructionNote
        {
            get
            {
                return this.instructionNoteField;
            }
            set
            {
                this.instructionNoteField = value;
            }
        }

        /// <summary>
        ///  Identifies the Payment(s).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType[] PaymentID
        {
            get
            {
                return this.paymentIDField;
            }
            set
            {
                this.paymentIDField = value;
            }
        }

        /// <summary>
        ///  An association to Card Account.
        /// </summary>
        public CardAccountType CardAccount
        {
            get
            {
                return this.cardAccountField;
            }
            set
            {
                this.cardAccountField = value;
            }
        }

        /// <summary>
        ///  An association to the payer's Financial Account.
        /// </summary>
        public FinancialAccountType PayerFinancialAccount
        {
            get
            {
                return this.payerFinancialAccountField;
            }
            set
            {
                this.payerFinancialAccountField = value;
            }
        }

        /// <summary>
        ///  An association to the payee's Financial Account.
        /// </summary>
        public FinancialAccountType PayeeFinancialAccount
        {
            get
            {
                return this.payeeFinancialAccountField;
            }
            set
            {
                this.payeeFinancialAccountField = value;
            }
        }

        /// <summary>
        ///  An association to Credit Account.
        /// </summary>
        public CreditAccountType CreditAccount
        {
            get
            {
                return this.creditAccountField;
            }
            set
            {
                this.creditAccountField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a credit card, debit card, or charge card.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CardAccountType
    {

        private IdentifierType primaryAccountNumberIDField;

        private IdentifierType networkIDField;

        private CodeType cardTypeCodeField;

        private DateType validityStartDateField;

        private DateType expiryDateField;

        private IdentifierType issuerIDField;

        private IdentifierType issueNumberIDField;

        private IdentifierType cV2IDField;

        private ChipCodeType cardChipCodeField;

        private IdentifierType chipApplicationIDField;

        private NameType holderNameField;

        /// <summary>
        ///  The card number; the Primary Account Number (PAN).
        ///  Example: 4558 XXXX XXXX XXXX (a real card number)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType PrimaryAccountNumberID
        {
            get
            {
                return this.primaryAccountNumberIDField;
            }
            set
            {
                this.primaryAccountNumberIDField = value;
            }
        }

        /// <summary>
        ///  The card network provider.
        ///  Example: “VISA”, “MasterCard”, “American Express”
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType NetworkID
        {
            get
            {
                return this.networkIDField;
            }
            set
            {
                this.networkIDField = value;
            }
        }

        /// <summary>
        ///  The type of card.
        ///  Example: “Debit Card”, “Credit Card”, “Procurement Card”
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType CardTypeCode
        {
            get
            {
                return this.cardTypeCodeField;
            }
            set
            {
                this.cardTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The date from which the card is valid.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ValidityStartDate
        {
            get
            {
                return this.validityStartDateField;
            }
            set
            {
                this.validityStartDateField = value;
            }
        }

        /// <summary>
        ///  The date up to which the card is valid.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }

        /// <summary>
        ///  The identifier for the card issuer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType IssuerID
        {
            get
            {
                return this.issuerIDField;
            }
            set
            {
                this.issuerIDField = value;
            }
        }

        /// <summary>
        ///  The card issue number.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType IssueNumberID
        {
            get
            {
                return this.issueNumberIDField;
            }
            set
            {
                this.issueNumberIDField = value;
            }
        }

        /// <summary>
        ///  The Card Verification Value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType CV2ID
        {
            get
            {
                return this.cV2IDField;
            }
            set
            {
                this.cV2IDField = value;
            }
        }

        /// <summary>
        ///  The distinction between CHIP and MAG STRIPE cards.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChipCodeType CardChipCode
        {
            get
            {
                return this.cardChipCodeField;
            }
            set
            {
                this.cardChipCodeField = value;
            }
        }

        /// <summary>
        ///  An identifier for the application (AID) on a chip card that provides the information quoted.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ChipApplicationID
        {
            get
            {
                return this.chipApplicationIDField;
            }
            set
            {
                this.chipApplicationIDField = value;
            }
        }

        /// <summary>
        ///  The name of the cardholder.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType HolderName
        {
            get
            {
                return this.holderNameField;
            }
            set
            {
                this.holderNameField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Financial Account.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class FinancialAccountType
    {

        private IdentifierType idField;

        private NameType nameField;

        private CodeType accountTypeCodeField;

        private CurrencyCodeType currencyCodeField;

        private TextType[] paymentNoteField;

        private BranchType financialInstitutionBranchField;

        private CountryType countryField;

        /// <summary>
        ///  The identifier for the Financial Account; the Bank Account Number.
        ///  Example: SWIFT(BIC) and IBAN are defined in ISO 9362 and ISO 13616.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The name of the Financial Account.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  The type of Financial Account, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType AccountTypeCode
        {
            get
            {
                return this.accountTypeCodeField;
            }
            set
            {
                this.accountTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The currency in which the Financial Account is held, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <summary>
        ///  Free-form text applying to the Payment to the owner of this account.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] PaymentNote
        {
            get
            {
                return this.paymentNoteField;
            }
            set
            {
                this.paymentNoteField = value;
            }
        }

        /// <summary>
        ///  An association to Financial Institution Branch.
        /// </summary>
        public BranchType FinancialInstitutionBranch
        {
            get
            {
                return this.financialInstitutionBranchField;
            }
            set
            {
                this.financialInstitutionBranchField = value;
            }
        }

        /// <summary>
        ///  An association to Country.
        /// </summary>
        public CountryType Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a branch or division of an organization.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BranchType
    {

        private IdentifierType idField;

        private NameType nameField;

        private FinancialInstitutionType financialInstitutionField;

        private AddressType addressField;

        /// <summary>
        ///  An identifier for a branch or division of an organization.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The name of a branch or division of an organization.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  An association to Financial Institution.
        /// </summary>
        public FinancialInstitutionType FinancialInstitution
        {
            get
            {
                return this.financialInstitutionField;
            }
            set
            {
                this.financialInstitutionField = value;
            }
        }

        /// <summary>
        ///  An association to Address.
        /// </summary>
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Financial Institution.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class FinancialInstitutionType
    {

        private IdentifierType idField;

        private NameType nameField;

        private AddressType addressField;

        /// <summary>
        ///  The identifier for the Financial Institution expressed as a code; ISO 9362 BIC (Bank Identification Code) is recommended.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The name of the Financial Institution.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  An association to Address.
        /// </summary>
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Credit Account (for sales on account).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CreditAccountType
    {

        private IdentifierType accountIDField;
        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="CreditAccountType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator CreditAccountType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new CreditAccountType { AccountID = value };
        }

        /// <summary>
        ///  Identifies the Credit Account.
        ///  Example: "Customer Code 29"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType AccountID
        {
            get
            {
                return this.accountIDField;
            }
            set
            {
                this.accountIDField = value;
            }
        }
    }

    /// <summary>
    ///  Information about an Invoice Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private TextType noteField;

        private QuantityType invoicedQuantityField;

        private AmountType lineExtensionAmountField;

        private DateType taxPointDateField;

        private CodeType accountingCostCodeField;

        private TextType accountingCostField;

        private IndicatorType freeOfChargeIndicatorField;

        private OrderLineReferenceType[] orderLineReferenceField;

        private LineReferenceType[] despatchLineReferenceField;

        private LineReferenceType[] receiptLineReferenceField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private PricingReferenceType pricingReferenceField;

        private PartyType originatorPartyField;

        private DeliveryType[] deliveryField;

        private PaymentTermsType[] paymentTermsField;

        private AllowanceChargeType[] allowanceChargeField;

        private TaxTotalType[] taxTotalField;

        private ItemType itemField;

        private PriceType priceField;

        private DeliveryTermsType deliveryTermsField;

        /// <summary>
        ///  Identifies the Invoice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Invoice Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  The quantity (of Items) on the Invoice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType InvoicedQuantity
        {
            get
            {
                return this.invoicedQuantityField;
            }
            set
            {
                this.invoicedQuantityField = value;
            }
        }

        /// <summary>
        ///  The total amount for the Invoice Line, including Allowance Charges but net of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
            }
        }

        /// <summary>
        ///  The date of the Invoice Line, used to indicate the point at which tax becomes applicable.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting code applied to the Invoice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting cost centre applied to the Invoice Line, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Indicates whether the Invoice Line is Free Of Charge (default = false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType FreeOfChargeIndicator
        {
            get
            {
                return this.freeOfChargeIndicatorField;
            }
            set
            {
                this.freeOfChargeIndicatorField = value;
            }
        }

        /// <summary>
        ///  An association to Order Line Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference
        {
            get
            {
                return this.orderLineReferenceField;
            }
            set
            {
                this.orderLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Despatch Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return this.despatchLineReferenceField;
            }
            set
            {
                this.despatchLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Receipt Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference")]
        public LineReferenceType[] ReceiptLineReference
        {
            get
            {
                return this.receiptLineReferenceField;
            }
            set
            {
                this.receiptLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Billing Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
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
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Pricing Reference.
        /// </summary>
        public PricingReferenceType PricingReference
        {
            get
            {
                return this.pricingReferenceField;
            }
            set
            {
                this.pricingReferenceField = value;
            }
        }

        /// <summary>
        ///  The party who originated the Order to which the Invoice is related.
        /// </summary>
        public PartyType OriginatorParty
        {
            get
            {
                return this.originatorPartyField;
            }
            set
            {
                this.originatorPartyField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Delivery")]
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
        ///  An association to Payment Terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
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
        ///  An association to Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
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
        ///  An association to Tax Total.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
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
        ///  An association to Item.
        /// </summary>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        ///  An association to Price.
        /// </summary>
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery Terms.
        /// </summary>
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
    }

    /// <summary>
    ///  Information about an Order Line Reference.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderLineReferenceType
    {

        private IdentifierType lineIDField;

        private IdentifierType salesOrderLineIDField;

        private IdentifierType uUIDField;

        private LineStatusCodeType lineStatusCodeField;

        private OrderReferenceType orderReferenceField;

        /// <summary>
        ///  Identifies the referenced Order Line assigned by the buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LineID
        {
            get
            {
                return this.lineIDField;
            }
            set
            {
                this.lineIDField = value;
            }
        }

        /// <summary>
        ///  Identifies the referenced Order Line assigned by the seller.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SalesOrderLineID
        {
            get
            {
                return this.salesOrderLineIDField;
            }
            set
            {
                this.salesOrderLineIDField = value;
            }
        }

        /// <summary>
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Identifies the status of the referenced Order Line with respect to its original state.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return this.lineStatusCodeField;
            }
            set
            {
                this.lineStatusCodeField = value;
            }
        }

        /// <summary>
        ///  An association to Order Reference.
        /// </summary>
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
    }

    /// <summary>
    ///  Information about an Order Reference.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderReferenceType
    {

        private IdentifierType idField;

        private IdentifierType salesOrderIDField;

        private IndicatorType copyIndicatorField;

        private IdentifierType uUIDField;

        private DateType issueDateField;

        private TimeType issueTimeField;

        private TextType customerReferenceField;

        private DocumentReferenceType documentReferenceField;

        private CodeType _orderTypeCode;
        /// <summary>
        ///  Identifies the referenced Order assigned by the buyer.
        ///  Example: "PO-001" "3333-44-123"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Identifies the referenced Order assigned by the seller.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SalesOrderID
        {
            get
            {
                return this.salesOrderIDField;
            }
            set
            {
                this.salesOrderIDField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the referenced Order is a copy (true) or the original (false).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The date on which the referenced Order was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The time at which the referenced Order was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A reference used (CRI) for tagging purchasing card transactions.
        ///  Example: Customer Reference Identifier (CRI) when using a puchasing card
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType CustomerReference
        {
            get
            {
                return this.customerReferenceField;
            }
            set
            {
                this.customerReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }
        /// <summary>
        ///  Código del tipo de documento
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType OrderTypeCode
        {
            get { return _orderTypeCode; }
            set { _orderTypeCode = value; }
        }
    }

    /// <summary>
    ///  Reference to a Line on a document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LineReferenceType
    {

        private IdentifierType lineIDField;

        private IdentifierType uUIDField;

        private LineStatusCodeType lineStatusCodeField;

        private DocumentReferenceType documentReferenceField;

        /// <summary>
        ///  Identifies the Line on the referenced document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LineID
        {
            get
            {
                return this.lineIDField;
            }
            set
            {
                this.lineIDField = value;
            }
        }

        /// <summary>
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Identifies the status of the referenced Line with respect to its original state.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return this.lineStatusCodeField;
            }
            set
            {
                this.lineStatusCodeField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }
    }

    /// <summary>
    ///  Information directly relating to a related document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BillingReferenceType
    {

        private DocumentReferenceType invoiceDocumentReferenceField;

        private DocumentReferenceType selfBilledInvoiceDocumentReferenceField;

        private DocumentReferenceType creditNoteDocumentReferenceField;

        private DocumentReferenceType selfBilledCreditNoteDocumentReferenceField;

        private DocumentReferenceType debitNoteDocumentReferenceField;

        private DocumentReferenceType reminderDocumentReferenceField;

        private DocumentReferenceType additionalDocumentReferenceField;

        private BillingReferenceLineType[] billingReferenceLineField;

        /// <summary>
        ///  An associative reference to Invoice.
        /// </summary>
        public DocumentReferenceType InvoiceDocumentReference
        {
            get
            {
                return this.invoiceDocumentReferenceField;
            }
            set
            {
                this.invoiceDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Self Billed Invoice.
        /// </summary>
        public DocumentReferenceType SelfBilledInvoiceDocumentReference
        {
            get
            {
                return this.selfBilledInvoiceDocumentReferenceField;
            }
            set
            {
                this.selfBilledInvoiceDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Credit Note.
        /// </summary>
        public DocumentReferenceType CreditNoteDocumentReference
        {
            get
            {
                return this.creditNoteDocumentReferenceField;
            }
            set
            {
                this.creditNoteDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Self Billed Credit Note.
        /// </summary>
        public DocumentReferenceType SelfBilledCreditNoteDocumentReference
        {
            get
            {
                return this.selfBilledCreditNoteDocumentReferenceField;
            }
            set
            {
                this.selfBilledCreditNoteDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Debit Note.
        /// </summary>
        public DocumentReferenceType DebitNoteDocumentReference
        {
            get
            {
                return this.debitNoteDocumentReferenceField;
            }
            set
            {
                this.debitNoteDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Reminder Document Reference
        /// </summary>
        public DocumentReferenceType ReminderDocumentReference
        {
            get
            {
                return this.reminderDocumentReferenceField;
            }
            set
            {
                this.reminderDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Additional Document.
        /// </summary>
        public DocumentReferenceType AdditionalDocumentReference
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
        ///  An association to Billing Reference Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReferenceLine")]
        public BillingReferenceLineType[] BillingReferenceLine
        {
            get
            {
                return this.billingReferenceLineField;
            }
            set
            {
                this.billingReferenceLineField = value;
            }
        }
    }

    /// <summary>
    ///  Information about the reference to a Billing line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BillingReferenceLineType
    {

        private IdentifierType idField;

        private AmountType amountField;

        private AllowanceChargeType[] allowanceChargeField;

        /// <summary>
        ///  An identifier for the Billing Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The amount of the Billing Line, including Allowance Charges but net of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <summary>
        ///  An association to Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
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
    }

    /// <summary>
    ///  A reference to Pricing Information.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PricingReferenceType
    {

        private ItemLocationQuantityType originalItemLocationQuantityField;

        private PriceType[] alternativeConditionPriceField;

        /// <summary>
        ///  An association to the original Item Location Quantity.
        /// </summary>
        public ItemLocationQuantityType OriginalItemLocationQuantity
        {
            get
            {
                return this.originalItemLocationQuantityField;
            }
            set
            {
                this.originalItemLocationQuantityField = value;
            }
        }

        /// <summary>
        ///  The price expressed in terms other than the actual price, e.g., the list price v. the contracted price, or the price in bags v. the price in kilos, or the list price in bags v. the contracted price in kilos.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AlternativeConditionPrice")]
        public PriceType[] AlternativeConditionPrice
        {
            get
            {
                return this.alternativeConditionPriceField;
            }
            set
            {
                this.alternativeConditionPriceField = value;
            }
        }
    }

    /// <summary>
    ///  Information about the properties of an item as they relate to specific quantities and/or specific locations.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemLocationQuantityType
    {

        private MeasureType leadTimeMeasureField;

        private QuantityType minimumQuantityField;

        private QuantityType maximumQuantityField;

        private IndicatorType hazardousRiskIndicatorField;

        private TextType[] tradingRestrictionsField;

        private AddressType[] applicableTerritoryAddressField;

        private PriceType priceField;

        private DeliveryUnitType[] deliveryUnitField;

        private TaxCategoryType[] applicableTaxCategoryField;

        /// <summary>
        ///  The time taken from the time of order to the time of delivery for an item.
        ///  Example: "2 days", "24 hours"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType LeadTimeMeasure
        {
            get
            {
                return this.leadTimeMeasureField;
            }
            set
            {
                this.leadTimeMeasureField = value;
            }
        }

        /// <summary>
        ///  The minimum quantity that can be ordered to qualify for a specific price.
        ///  Example: "10 boxes", "1 carton", "1000 sheets"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MinimumQuantity
        {
            get
            {
                return this.minimumQuantityField;
            }
            set
            {
                this.minimumQuantityField = value;
            }
        }

        /// <summary>
        ///  The maximum quantity that can be ordered to qualify for a specific price.
        ///  Example: "10 boxes", "1 carton", "1000 sheets"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the item as delivered, in the stated quantity to the stated location, is hazardous.
        ///  Example: Default is negative
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
            }
        }

        /// <summary>
        ///  A description of trade restrictions that apply to the item or quantities of the item.
        ///  Example: "not for export"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] TradingRestrictions
        {
            get
            {
                return this.tradingRestrictionsField;
            }
            set
            {
                this.tradingRestrictionsField = value;
            }
        }

        /// <summary>
        ///  An association to Territory (Address).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTerritoryAddress")]
        public AddressType[] ApplicableTerritoryAddress
        {
            get
            {
                return this.applicableTerritoryAddressField;
            }
            set
            {
                this.applicableTerritoryAddressField = value;
            }
        }

        /// <summary>
        ///  An association to Price.
        /// </summary>
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery Unit.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit
        {
            get
            {
                return this.deliveryUnitField;
            }
            set
            {
                this.deliveryUnitField = value;
            }
        }

        /// <summary>
        ///  An association to Tax Category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory")]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return this.applicableTaxCategoryField;
            }
            set
            {
                this.applicableTaxCategoryField = value;
            }
        }
    }

    /// <summary>
    ///  Information about the price.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PriceType
    {

        private AmountType priceAmountField;

        private QuantityType baseQuantityField;

        private TextType[] priceChangeReasonField;

        private CodeType priceTypeCodeField;

        private TextType priceType1Field;

        private RateType orderableUnitFactorRateField;

        private PeriodType[] validityPeriodField;

        private PriceListType priceListField;

        private AllowanceChargeType[] allowanceChargeField;
        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Decimal"/> to <see cref="PriceType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PriceType(System.Decimal value)
        {
            return new PriceType { PriceAmount = value };
        }

        /// <summary>
        ///  The price amount.
        ///  Example: 23.45
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PriceAmount
        {
            get
            {
                return this.priceAmountField;
            }
            set
            {
                this.priceAmountField = value;
            }
        }

        /// <summary>
        ///  The actual quantity to which the price applies.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType BaseQuantity
        {
            get
            {
                return this.baseQuantityField;
            }
            set
            {
                this.baseQuantityField = value;
            }
        }

        /// <summary>
        ///  The reason for the price change, expressed as text.
        ///  Example: "Clearance of old stock", "New contract applies"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PriceChangeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] PriceChangeReason
        {
            get
            {
                return this.priceChangeReasonField;
            }
            set
            {
                this.priceChangeReasonField = value;
            }
        }

        /// <summary>
        ///  The price type, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PriceTypeCode
        {
            get
            {
                return this.priceTypeCodeField;
            }
            set
            {
                this.priceTypeCodeField = value;
            }
        }

        /// <summary>
        /// Gets or sets the price type1.
        /// </summary>
        /// <value>The price type1.</value>
        [System.Xml.Serialization.XmlElementAttribute("PriceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PriceType1
        {
            get
            {
                return this.priceType1Field;
            }
            set
            {
                this.priceType1Field = value;
            }
        }

        /// <summary>
        ///  The factor by which the base price unit can be converted to the orderable unit.
        ///  Example: Nails are priced by weight but ordered by quantity.  So this would say how many nails per kilo
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RateType OrderableUnitFactorRate
        {
            get
            {
                return this.orderableUnitFactorRateField;
            }
            set
            {
                this.orderableUnitFactorRateField = value;
            }
        }

        /// <summary>
        ///  An association to Validity Period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return this.validityPeriodField;
            }
            set
            {
                this.validityPeriodField = value;
            }
        }

        /// <summary>
        ///  A reference to a Price List.
        /// </summary>
        public PriceListType PriceList
        {
            get
            {
                return this.priceListField;
            }
            set
            {
                this.priceListField = value;
            }
        }

        /// <summary>
        ///  An association to Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
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
    }

    /// <summary>
    ///  Information about a Price List.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PriceListType
    {

        private IdentifierType idField;

        private CodeType statusCodeField;

        private PeriodType[] validityPeriodField;

        private PriceListType previousPriceListField;

        /// <summary>
        ///  Identifies the Price List.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Identifies whether the price list is an 'original', 'copy', 'revision', or 'cancellation'.
        ///  Example: "new - announcement only", "new and available", "deleted - announcement only"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <summary>
        ///  An association to Validity Period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return this.validityPeriodField;
            }
            set
            {
                this.validityPeriodField = value;
            }
        }

        /// <summary>
        ///  An association to Previous Price List.
        /// </summary>
        public PriceListType PreviousPriceList
        {
            get
            {
                return this.previousPriceListField;
            }
            set
            {
                this.previousPriceListField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Delivery Unit.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DeliveryUnitType
    {

        private QuantityType batchQuantityField;

        private QuantityType consumerUnitQuantityField;

        private IndicatorType hazardousRiskIndicatorField;

        /// <summary>
        ///  The quantity of ordered Items that constitutes a batch for delivery purposes.
        ///  Example: "100 units", "by the dozen"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType BatchQuantity
        {
            get
            {
                return this.batchQuantityField;
            }
            set
            {
                this.batchQuantityField = value;
            }
        }

        /// <summary>
        ///  The quantity of consumer units in the Delivery Unit.
        ///  Example: "packs of 10"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType ConsumerUnitQuantity
        {
            get
            {
                return this.consumerUnitQuantityField;
            }
            set
            {
                this.consumerUnitQuantityField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the Item as delivered is hazardous.
        ///  Example: Default is negative
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Delivery.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DeliveryType
    {

        private IdentifierType idField;

        private QuantityType quantityField;

        private QuantityType minimumQuantityField;

        private QuantityType maximumQuantityField;

        private DateType actualDeliveryDateField;

        private TimeType actualDeliveryTimeField;

        private DateType latestDeliveryDateField;

        private TimeType latestDeliveryTimeField;

        private IdentifierType trackingIDField;

        private AddressType deliveryAddressField;

        private LocationType1 deliveryLocationField;

        private PeriodType requestedDeliveryPeriodField;

        private PeriodType promisedDeliveryPeriodField;

        private PeriodType estimatedDeliveryPeriodField;

        private PartyType deliveryPartyField;

        private DespatchType despatchField;

        /// <summary>
        ///  Identifies the Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The quantity in a Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <summary>
        ///  The minimum quantity in a Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MinimumQuantity
        {
            get
            {
                return this.minimumQuantityField;
            }
            set
            {
                this.minimumQuantityField = value;
            }
        }

        /// <summary>
        ///  The maximum quantity in a Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
            }
        }

        /// <summary>
        ///  The actual Delivery date.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ActualDeliveryDate
        {
            get
            {
                return this.actualDeliveryDateField;
            }
            set
            {
                this.actualDeliveryDateField = value;
            }
        }

        /// <summary>
        ///  The actual Delivery time.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType ActualDeliveryTime
        {
            get
            {
                return this.actualDeliveryTimeField;
            }
            set
            {
                this.actualDeliveryTimeField = value;
            }
        }

        /// <summary>
        ///  The latest delivery date allowed by the buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType LatestDeliveryDate
        {
            get
            {
                return this.latestDeliveryDateField;
            }
            set
            {
                this.latestDeliveryDateField = value;
            }
        }

        /// <summary>
        ///  The latest delivery time allowed by the buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType LatestDeliveryTime
        {
            get
            {
                return this.latestDeliveryTimeField;
            }
            set
            {
                this.latestDeliveryTimeField = value;
            }
        }

        /// <summary>
        ///  The delivery Tracking ID (for transport tracking).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType TrackingID
        {
            get
            {
                return this.trackingIDField;
            }
            set
            {
                this.trackingIDField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery Address.
        /// </summary>
        public AddressType DeliveryAddress
        {
            get
            {
                return this.deliveryAddressField;
            }
            set
            {
                this.deliveryAddressField = value;
            }
        }

        /// <summary>
        ///  An association to Location.
        /// </summary>
        public LocationType1 DeliveryLocation
        {
            get
            {
                return this.deliveryLocationField;
            }
            set
            {
                this.deliveryLocationField = value;
            }
        }

        /// <summary>
        ///  The requested Period for Delivery.
        /// </summary>
        public PeriodType RequestedDeliveryPeriod
        {
            get
            {
                return this.requestedDeliveryPeriodField;
            }
            set
            {
                this.requestedDeliveryPeriodField = value;
            }
        }

        /// <summary>
        ///  The promised Period for Delivery.
        /// </summary>
        public PeriodType PromisedDeliveryPeriod
        {
            get
            {
                return this.promisedDeliveryPeriodField;
            }
            set
            {
                this.promisedDeliveryPeriodField = value;
            }
        }

        /// <summary>
        ///  The estimated Period for Delivery.
        /// </summary>
        public PeriodType EstimatedDeliveryPeriod
        {
            get
            {
                return this.estimatedDeliveryPeriodField;
            }
            set
            {
                this.estimatedDeliveryPeriodField = value;
            }
        }

        /// <summary>
        ///  The party to whom the goods/services are delivered.
        /// </summary>
        public PartyType DeliveryParty
        {
            get
            {
                return this.deliveryPartyField;
            }
            set
            {
                this.deliveryPartyField = value;
            }
        }

        /// <summary>
        ///  An association to the Despatch.
        /// </summary>
        public DespatchType Despatch
        {
            get
            {
                return this.despatchField;
            }
            set
            {
                this.despatchField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Despatch.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DespatchType
    {

        private IdentifierType idField;

        private DateType requestedDespatchDateField;

        private TimeType requestedDespatchTimeField;

        private DateType estimatedDespatchDateField;

        private TimeType estimatedDespatchTimeField;

        private DateType actualDespatchDateField;

        private TimeType actualDespatchTimeField;

        private AddressType despatchAddressField;

        private PartyType despatchPartyField;

        private ContactType contactField;

        /// <summary>
        ///  The identifier for the Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The despatch (pick-up) date requested by the buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType RequestedDespatchDate
        {
            get
            {
                return this.requestedDespatchDateField;
            }
            set
            {
                this.requestedDespatchDateField = value;
            }
        }

        /// <summary>
        ///  The despatch (pick-up) time requested by the buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType RequestedDespatchTime
        {
            get
            {
                return this.requestedDespatchTimeField;
            }
            set
            {
                this.requestedDespatchTimeField = value;
            }
        }

        /// <summary>
        ///  The despatch (pick-up) date estimated by the seller or Despatch.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType EstimatedDespatchDate
        {
            get
            {
                return this.estimatedDespatchDateField;
            }
            set
            {
                this.estimatedDespatchDateField = value;
            }
        }

        /// <summary>
        ///  The despatch (pick-up) time estimated by the seller or Despatch.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType EstimatedDespatchTime
        {
            get
            {
                return this.estimatedDespatchTimeField;
            }
            set
            {
                this.estimatedDespatchTimeField = value;
            }
        }

        /// <summary>
        ///  The actual despatch (pick-up) date.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ActualDespatchDate
        {
            get
            {
                return this.actualDespatchDateField;
            }
            set
            {
                this.actualDespatchDateField = value;
            }
        }

        /// <summary>
        ///  The actual despatch (pick-up) time.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType ActualDespatchTime
        {
            get
            {
                return this.actualDespatchTimeField;
            }
            set
            {
                this.actualDespatchTimeField = value;
            }
        }

        /// <summary>
        ///  An association to Despatch Address.
        /// </summary>
        public AddressType DespatchAddress
        {
            get
            {
                return this.despatchAddressField;
            }
            set
            {
                this.despatchAddressField = value;
            }
        }

        /// <summary>
        ///  The party who despatched the delivery.
        /// </summary>
        public PartyType DespatchParty
        {
            get
            {
                return this.despatchPartyField;
            }
            set
            {
                this.despatchPartyField = value;
            }
        }

        /// <summary>
        ///  An association to Contact.
        /// </summary>
        public ContactType Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Payment Terms.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PaymentTermsType
    {

        private IdentifierType idField;

        private IdentifierType paymentMeansIDField;

        private IdentifierType prepaidPaymentReferenceIDField;

        private TextType[] noteField;

        private CodeType referenceEventCodeField;

        private PercentType settlementDiscountPercentField;

        private PercentType penaltySurchargePercentField;

        private AmountType amountField;

        private PeriodType settlementPeriodField;

        private PeriodType penaltyPeriodField;

        /// <summary>
        ///  Identifies the Payment Terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Identifies the applicable Payment Means.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType PaymentMeansID
        {
            get
            {
                return this.paymentMeansIDField;
            }
            set
            {
                this.paymentMeansIDField = value;
            }
        }

        /// <summary>
        ///  Identifies a reference to a prepaid payment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType PrepaidPaymentReferenceID
        {
            get
            {
                return this.prepaidPaymentReferenceIDField;
            }
            set
            {
                this.prepaidPaymentReferenceIDField = value;
            }
        }

        /// <summary>
        ///  Free-form text applying to the Payment Terms. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The event from which terms are offered for a length of time, identified by a standard code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ReferenceEventCode
        {
            get
            {
                return this.referenceEventCodeField;
            }
            set
            {
                this.referenceEventCodeField = value;
            }
        }

        /// <summary>
        ///  The settlement discount rate (percentage) offered for payment within the settlement period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType SettlementDiscountPercent
        {
            get
            {
                return this.settlementDiscountPercentField;
            }
            set
            {
                this.settlementDiscountPercentField = value;
            }
        }

        /// <summary>
        ///  The penalty rate (percentage) charged for late payment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType PenaltySurchargePercent
        {
            get
            {
                return this.penaltySurchargePercentField;
            }
            set
            {
                this.penaltySurchargePercentField = value;
            }
        }

        /// <summary>
        ///  The payment amount for the Payment Terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <summary>
        ///  An association to Settlement Period.
        /// </summary>
        public PeriodType SettlementPeriod
        {
            get
            {
                return this.settlementPeriodField;
            }
            set
            {
                this.settlementPeriodField = value;
            }
        }

        /// <summary>
        ///  An association to Penalty Period.
        /// </summary>
        public PeriodType PenaltyPeriod
        {
            get
            {
                return this.penaltyPeriodField;
            }
            set
            {
                this.penaltyPeriodField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Delivery Terms.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DeliveryTermsType
    {

        private IdentifierType idField;

        private TextType specialTermsField;

        private CodeType lossRiskResponsibilityCodeField;

        private TextType lossRiskField;

        private LocationType1 deliveryLocationField;

        private AllowanceChargeType allowanceChargeField;

        /// <summary>
        ///  Identifies the Delivery Terms.
        ///  Example: CIF, FOB, or EXW from the INCOTERMS Terms of Delivery. (2000 version preferred.)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A description of special conditions relating to the Delivery Terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType SpecialTerms
        {
            get
            {
                return this.specialTermsField;
            }
            set
            {
                this.specialTermsField = value;
            }
        }

        /// <summary>
        ///  An identifier for the responsibility for loss risk in the context of the Delivery Terms, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType LossRiskResponsibilityCode
        {
            get
            {
                return this.lossRiskResponsibilityCodeField;
            }
            set
            {
                this.lossRiskResponsibilityCodeField = value;
            }
        }

        /// <summary>
        ///  A description of the loss risk in the context of the Delivery Terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType LossRisk
        {
            get
            {
                return this.lossRiskField;
            }
            set
            {
                this.lossRiskField = value;
            }
        }

        /// <summary>
        ///  An association to Location, e.g., a port.
        /// </summary>
        public LocationType1 DeliveryLocation
        {
            get
            {
                return this.deliveryLocationField;
            }
            set
            {
                this.deliveryLocationField = value;
            }
        }

        /// <summary>
        ///  An association to Allowance Charge.
        /// </summary>
        public AllowanceChargeType AllowanceCharge
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
    }

    /// <summary>
    ///  Information related to an aircraft.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AirTransportType
    {

        private IdentifierType aircraftIDField;
        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="AirTransportType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator AirTransportType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new AirTransportType { AircraftID = value };
        }

        /// <summary>
        ///  Identifies a specific aircraft.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType AircraftID
        {
            get
            {
                return this.aircraftIDField;
            }
            set
            {
                this.aircraftIDField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Monetary Totals.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MonetaryTotalType
    {

        private AmountType lineExtensionAmountField;

        private AmountType taxExclusiveAmountField;

        private AmountType taxInclusiveAmountField;

        private AmountType allowanceTotalAmountField;

        private AmountType chargeTotalAmountField;

        private AmountType prepaidAmountField;

        private AmountType payableRoundingAmountField;

        private AmountType payableAmountField;

        /// <summary>
        ///  The total of Line Extension Amounts net of tax and settlement discounts, but inclusive of any applicable rounding amount.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
            }
        }

        /// <summary>
        ///  The total amount exclusive of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TaxExclusiveAmount
        {
            get
            {
                return this.taxExclusiveAmountField;
            }
            set
            {
                this.taxExclusiveAmountField = value;
            }
        }

        /// <summary>
        ///  The total amount inclusive of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TaxInclusiveAmount
        {
            get
            {
                return this.taxInclusiveAmountField;
            }
            set
            {
                this.taxInclusiveAmountField = value;
            }
        }

        /// <summary>
        ///  The total amount of all allowances.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType AllowanceTotalAmount
        {
            get
            {
                return this.allowanceTotalAmountField;
            }
            set
            {
                this.allowanceTotalAmountField = value;
            }
        }

        /// <summary>
        ///  The total amount of all charges.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType ChargeTotalAmount
        {
            get
            {
                return this.chargeTotalAmountField;
            }
            set
            {
                this.chargeTotalAmountField = value;
            }
        }

        /// <summary>
        ///  The total prepaid amount.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PrepaidAmount
        {
            get
            {
                return this.prepaidAmountField;
            }
            set
            {
                this.prepaidAmountField = value;
            }
        }

        /// <summary>
        ///  The rounding amount (positive or negative) added to the calculated Line Extension Total Amount to produce the rounded Line Extension Total Amount.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PayableRoundingAmount
        {
            get
            {
                return this.payableRoundingAmountField;
            }
            set
            {
                this.payableRoundingAmountField = value;
            }
        }

        /// <summary>
        ///  The total amount to be paid.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PayableAmount
        {
            get
            {
                return this.payableAmountField;
            }
            set
            {
                this.payableAmountField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Line Item.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LineItemType
    {

        private IdentifierType idField;

        private IdentifierType salesOrderIDField;

        private IdentifierType uUIDField;

        private TextType noteField;

        private LineStatusCodeType lineStatusCodeField;

        private QuantityType quantityField;

        private AmountType lineExtensionAmountField;

        private AmountType totalTaxAmountField;

        private QuantityType minimumQuantityField;

        private QuantityType maximumQuantityField;

        private QuantityType minimumBackorderQuantityField;

        private QuantityType maximumBackorderQuantityField;

        private CodeType inspectionMethodCodeField;

        private IndicatorType partialDeliveryIndicatorField;

        private IndicatorType backOrderAllowedIndicatorField;

        private CodeType accountingCostCodeField;

        private TextType accountingCostField;

        private DeliveryType[] deliveryField;

        private DeliveryTermsType deliveryTermsField;

        private PartyType originatorPartyField;

        private OrderedShipmentType[] orderedShipmentField;

        private PricingReferenceType pricingReferenceField;

        private AllowanceChargeType[] allowanceChargeField;

        private PriceType priceField;

        private ItemType itemField;

        /// <summary>
        ///  Identifies the Line Item assigned by the buyer.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The identification given to a Line by the seller.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SalesOrderID
        {
            get
            {
                return this.salesOrderIDField;
            }
            set
            {
                this.salesOrderIDField = value;
            }
        }

        /// <summary>
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Line Item. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  Identifies the status of the Line with respect to its original state.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return this.lineStatusCodeField;
            }
            set
            {
                this.lineStatusCodeField = value;
            }
        }

        /// <summary>
        ///  The quantity of Items for the Line Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <summary>
        ///  The total amount for the Line Item, including Allowance Charges but net of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
            }
        }

        /// <summary>
        ///  The total tax amount for the Line Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TotalTaxAmount
        {
            get
            {
                return this.totalTaxAmountField;
            }
            set
            {
                this.totalTaxAmountField = value;
            }
        }

        /// <summary>
        ///  The minimum quantity for the Item on the Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MinimumQuantity
        {
            get
            {
                return this.minimumQuantityField;
            }
            set
            {
                this.minimumQuantityField = value;
            }
        }

        /// <summary>
        ///  The maximum quantity for the Item on the Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
            }
        }

        /// <summary>
        ///  The minimum back order quantity (where back order is allowed).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MinimumBackorderQuantity
        {
            get
            {
                return this.minimumBackorderQuantityField;
            }
            set
            {
                this.minimumBackorderQuantityField = value;
            }
        }

        /// <summary>
        ///  The maximum back order quantity (where back order is allowed).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MaximumBackorderQuantity
        {
            get
            {
                return this.maximumBackorderQuantityField;
            }
            set
            {
                this.maximumBackorderQuantityField = value;
            }
        }

        /// <summary>
        ///  Inspection requirements for a Line Item, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType InspectionMethodCode
        {
            get
            {
                return this.inspectionMethodCodeField;
            }
            set
            {
                this.inspectionMethodCodeField = value;
            }
        }

        /// <summary>
        ///  Indicates whether a partial delivery is allowed.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType PartialDeliveryIndicator
        {
            get
            {
                return this.partialDeliveryIndicatorField;
            }
            set
            {
                this.partialDeliveryIndicatorField = value;
            }
        }

        /// <summary>
        ///  Indicates whether back order is allowed.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType BackOrderAllowedIndicator
        {
            get
            {
                return this.backOrderAllowedIndicatorField;
            }
            set
            {
                this.backOrderAllowedIndicatorField = value;
            }
        }

        /// <summary>
        ///  The buyer's accounting code applied to the Line Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting cost centre applied to the Line Item, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  An association to Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Delivery")]
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
        ///  The party who originated Order.
        /// </summary>
        public PartyType OriginatorParty
        {
            get
            {
                return this.originatorPartyField;
            }
            set
            {
                this.originatorPartyField = value;
            }
        }

        /// <summary>
        ///  An association to Ordered Shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderedShipment")]
        public OrderedShipmentType[] OrderedShipment
        {
            get
            {
                return this.orderedShipmentField;
            }
            set
            {
                this.orderedShipmentField = value;
            }
        }

        /// <summary>
        ///  An association to Pricing Reference.
        /// </summary>
        public PricingReferenceType PricingReference
        {
            get
            {
                return this.pricingReferenceField;
            }
            set
            {
                this.pricingReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Allowance Charge.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
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
        ///  An association to Price.
        /// </summary>
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <summary>
        ///  An association to Item.
        /// </summary>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <summary>
    ///  Information about an Ordered Shipment.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderedShipmentType
    {

        private ShipmentType shipmentField;

        private PackageType[] packageField;

        /// <summary>
        ///  An association to Shipment.
        /// </summary>
        public ShipmentType Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }

        /// <summary>
        ///  An association to Package.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Package")]
        public PackageType[] Package
        {
            get
            {
                return this.packageField;
            }
            set
            {
                this.packageField = value;
            }
        }
    }

    /// <summary>
    ///  An identifiable collection of one or more goods items to be transported between the seller party and the buyer party. This information may be defined within a commercial contract. A shipment can be transported in different consignments (e.g., split for logistical purposes).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ShipmentType
    {

        private IdentifierType idField;

        private CodeType shippingPriorityLevelCodeField;

        private CodeType handlingCodeField;

        private TextType handlingInstructionsField;

        private TextType informationField;

        private MeasureType grossWeightMeasureField;

        private MeasureType netWeightMeasureField;

        private MeasureType netNetWeightMeasureField;

        private MeasureType grossVolumeMeasureField;

        private MeasureType netVolumeMeasureField;

        private QuantityType totalGoodsItemQuantityField;

        private QuantityType totalTransportHandlingUnitQuantityField;

        private AmountType insuranceValueAmountField;

        private AmountType declaredCustomsValueAmountField;

        private AmountType declaredForCarriageValueAmountField;

        private AmountType declaredStatisticsValueAmountField;

        private AmountType freeOnBoardValueAmountField;

        private TextType[] specialInstructionsField;

        private TextType[] deliveryInstructionsField;

        private IndicatorType splitConsignmentIndicatorField;

        private ConsignmentType consignmentField;

        private GoodsItemType[] goodsItemField;

        private ShipmentStageType[] shipmentStageField;

        private DeliveryType deliveryField;

        private TransportHandlingUnitType[] transportHandlingUnitField;

        private AddressType originAddressField;

        private LocationType1 firstArrivalPortLocationField;

        private LocationType1 lastExitPortLocationField;

        private CountryType exportCountryField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        /// <summary>
        ///  Identifies a shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The priority or level of service required for a shipment, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ShippingPriorityLevelCode
        {
            get
            {
                return this.shippingPriorityLevelCodeField;
            }
            set
            {
                this.shippingPriorityLevelCodeField = value;
            }
        }

        /// <summary>
        ///  The handling required for a shipment, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType HandlingCode
        {
            get
            {
                return this.handlingCodeField;
            }
            set
            {
                this.handlingCodeField = value;
            }
        }

        /// <summary>
        ///  Free-form text describing Handling Instructions for a shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType HandlingInstructions
        {
            get
            {
                return this.handlingInstructionsField;
            }
            set
            {
                this.handlingInstructionsField = value;
            }
        }

        /// <summary>
        ///  Free-form text applying to a shipment. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
            }
        }

        /// <summary>
        ///  The total gross weight of a shipment; the weight of the goods plus packaging plus transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossWeightMeasure
        {
            get
            {
                return this.grossWeightMeasureField;
            }
            set
            {
                this.grossWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  The total net weight of a shipment; the weight of the goods plus packaging.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetWeightMeasure
        {
            get
            {
                return this.netWeightMeasureField;
            }
            set
            {
                this.netWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  The weight of the goods net of packaging and transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetNetWeightMeasure
        {
            get
            {
                return this.netNetWeightMeasureField;
            }
            set
            {
                this.netNetWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  The total volume of the goods in a shipment plus packaging.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossVolumeMeasure
        {
            get
            {
                return this.grossVolumeMeasureField;
            }
            set
            {
                this.grossVolumeMeasureField = value;
            }
        }

        /// <summary>
        ///  The volume of a shipment net of packaging and transport equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetVolumeMeasure
        {
            get
            {
                return this.netVolumeMeasureField;
            }
            set
            {
                this.netVolumeMeasureField = value;
            }
        }

        /// <summary>
        ///  Count of the total number of goods items within a shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType TotalGoodsItemQuantity
        {
            get
            {
                return this.totalGoodsItemQuantityField;
            }
            set
            {
                this.totalGoodsItemQuantityField = value;
            }
        }

        /// <summary>
        ///  Count of the number of pieces of transport handling equipment in a shipment, such as pallets, boxes, and cases.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType TotalTransportHandlingUnitQuantity
        {
            get
            {
                return this.totalTransportHandlingUnitQuantityField;
            }
            set
            {
                this.totalTransportHandlingUnitQuantityField = value;
            }
        }

        /// <summary>
        ///  The total sum covered by an insurance for the shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType InsuranceValueAmount
        {
            get
            {
                return this.insuranceValueAmountField;
            }
            set
            {
                this.insuranceValueAmountField = value;
            }
        }

        /// <summary>
        ///  Amount declared for customs purposes of those goods in a shipment which are subject to the same customs procedure, and have the same tariff/statistical heading, country information, and duty regime.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DeclaredCustomsValueAmount
        {
            get
            {
                return this.declaredCustomsValueAmountField;
            }
            set
            {
                this.declaredCustomsValueAmountField = value;
            }
        }

        /// <summary>
        ///  Value, declared by the shipper or his agent solely for the purpose of varying the carrier's level of liability from that provided in the contract of carriage, in case of loss or damage to goods or delayed delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return this.declaredForCarriageValueAmountField;
            }
            set
            {
                this.declaredForCarriageValueAmountField = value;
            }
        }

        /// <summary>
        ///  Value declared for statistical purposes of those goods in a consignment which have the same statistical heading.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return this.declaredStatisticsValueAmountField;
            }
            set
            {
                this.declaredStatisticsValueAmountField = value;
            }
        }

        /// <summary>
        ///  Monetary amount that has to be or has been paid as calculated under the applicable trade delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType FreeOnBoardValueAmount
        {
            get
            {
                return this.freeOnBoardValueAmountField;
            }
            set
            {
                this.freeOnBoardValueAmountField = value;
            }
        }

        /// <summary>
        ///  Special instructions relating to a shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] SpecialInstructions
        {
            get
            {
                return this.specialInstructionsField;
            }
            set
            {
                this.specialInstructionsField = value;
            }
        }

        /// <summary>
        ///  Delivery instructions relating to a shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] DeliveryInstructions
        {
            get
            {
                return this.deliveryInstructionsField;
            }
            set
            {
                this.deliveryInstructionsField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the consignment has been split in transit.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType SplitConsignmentIndicator
        {
            get
            {
                return this.splitConsignmentIndicatorField;
            }
            set
            {
                this.splitConsignmentIndicatorField = value;
            }
        }

        /// <summary>
        ///  An association to Consignment covering the shipment.
        /// </summary>
        public ConsignmentType Consignment
        {
            get
            {
                return this.consignmentField;
            }
            set
            {
                this.consignmentField = value;
            }
        }

        /// <summary>
        ///  An association to Goods Item (for Bulk Goods).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return this.goodsItemField;
            }
            set
            {
                this.goodsItemField = value;
            }
        }

        /// <summary>
        ///  An association to Shipment Stage.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage
        {
            get
            {
                return this.shipmentStageField;
            }
            set
            {
                this.shipmentStageField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery.
        /// </summary>
        public DeliveryType Delivery
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
        ///  An association to Transport Handling Unit used for loose and containerized goods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
        public TransportHandlingUnitType[] TransportHandlingUnit
        {
            get
            {
                return this.transportHandlingUnitField;
            }
            set
            {
                this.transportHandlingUnitField = value;
            }
        }

        /// <summary>
        ///  An association to the region in which the goods have been produced or manufactured, according to criteria laid down for the purposes of application of the Customs tariff, or quantitative restrictions, or of any other measure related to trade.
        /// </summary>
        public AddressType OriginAddress
        {
            get
            {
                return this.originAddressField;
            }
            set
            {
                this.originAddressField = value;
            }
        }

        /// <summary>
        ///  Identifies the first arrival location. This would be a port for sea, airport for air, and border post for land crossing.
        /// </summary>
        public LocationType1 FirstArrivalPortLocation
        {
            get
            {
                return this.firstArrivalPortLocationField;
            }
            set
            {
                this.firstArrivalPortLocationField = value;
            }
        }

        /// <summary>
        ///  Identifies the final exporting location. This would be a port for sea, airport for air, and border post for land crossing.
        /// </summary>
        public LocationType1 LastExitPortLocation
        {
            get
            {
                return this.lastExitPortLocationField;
            }
            set
            {
                this.lastExitPortLocationField = value;
            }
        }

        /// <summary>
        ///  Identifies the country from which the goods are originally exported without any commercial transaction taking place in intermediate countries.
        /// </summary>
        public CountryType ExportCountry
        {
            get
            {
                return this.exportCountryField;
            }
            set
            {
                this.exportCountryField = value;
            }
        }

        /// <summary>
        ///  Costs incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance (to the extent that they relate to the freight costs).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return this.freightAllowanceChargeField;
            }
            set
            {
                this.freightAllowanceChargeField = value;
            }
        }
    }

    /// <summary>
    ///  An identifiable collection of one or more goods items to be transported between the consignor and the consignee. This information may be defined within a transport contract. A consignment may comprise more than one shipment (e.g., when consolidated by a freight forwarder).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ConsignmentType
    {

        private IdentifierType idField;

        private TextType[] summaryDescriptionField;

        private AmountType totalInvoiceAmountField;

        private AmountType declaredCustomsValueAmountField;

        private TextType[] tariffDescriptionField;

        private CodeType tariffCodeField;

        private AmountType insurancePremiumAmountField;

        private MeasureType grossWeightMeasureField;

        private MeasureType netWeightMeasureField;

        private MeasureType netNetWeightMeasureField;

        private MeasureType chargeableWeightMeasureField;

        private MeasureType grossVolumeMeasureField;

        private MeasureType netVolumeMeasureField;

        private MeasureType loadingLengthMeasureField;

        private TextType[] remarksField;

        private IndicatorType hazardousRiskIndicatorField;

        private PartyType consigneePartyField;

        private PartyType exporterPartyField;

        private PartyType consignorPartyField;

        private PartyType importerPartyField;

        private PartyType carrierPartyField;

        private PartyType freightForwarderPartyField;

        private PartyType notifyPartyField;

        private PartyType originalDespatchPartyField;

        private PartyType finalDeliveryPartyField;

        private CountryType originalDepartureCountryField;

        private CountryType finalDestinationCountryField;

        private CountryType[] transitCountryField;

        private ContractType transportContractField;

        private TransportationServiceType originalDespatchTransportationServiceField;

        private TransportationServiceType finalDeliveryTransportationServiceField;

        private DeliveryTermsType deliveryTermsField;

        private PaymentTermsType paymentTermsField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        /// <summary>
        ///  Unique number assigned to goods, both for import and export.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  General descriptive text that is not part of any remarks.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SummaryDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] SummaryDescription
        {
            get
            {
                return this.summaryDescriptionField;
            }
            set
            {
                this.summaryDescriptionField = value;
            }
        }

        /// <summary>
        ///  Total of all invoice amounts declared in a single consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TotalInvoiceAmount
        {
            get
            {
                return this.totalInvoiceAmountField;
            }
            set
            {
                this.totalInvoiceAmountField = value;
            }
        }

        /// <summary>
        ///  Amount declared for customs purposes of those goods in a consignment, whether or not they are subject to the same customs procedure, tariff/statistical heading, country information, and duty regime.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DeclaredCustomsValueAmount
        {
            get
            {
                return this.declaredCustomsValueAmountField;
            }
            set
            {
                this.declaredCustomsValueAmountField = value;
            }
        }

        /// <summary>
        ///  A description of the tariff applied to a consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TariffDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] TariffDescription
        {
            get
            {
                return this.tariffDescriptionField;
            }
            set
            {
                this.tariffDescriptionField = value;
            }
        }

        /// <summary>
        ///  Code specifying a tariff applied to a consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TariffCode
        {
            get
            {
                return this.tariffCodeField;
            }
            set
            {
                this.tariffCodeField = value;
            }
        }

        /// <summary>
        ///  Amount of premium payable to the insurance company for insuring the goods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType InsurancePremiumAmount
        {
            get
            {
                return this.insurancePremiumAmountField;
            }
            set
            {
                this.insurancePremiumAmountField = value;
            }
        }

        /// <summary>
        ///  Total weight (mass) of goods for a declaration, including packaging but excluding the carrier's equipment.
        ///  Example: Total cube of all goods items referred to as one consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossWeightMeasure
        {
            get
            {
                return this.grossWeightMeasureField;
            }
            set
            {
                this.grossWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  Total net weight (mass) of all the goods items referred to as one consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetWeightMeasure
        {
            get
            {
                return this.netWeightMeasureField;
            }
            set
            {
                this.netWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  Weight (mass) of the goods themselves without any packing.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetNetWeightMeasure
        {
            get
            {
                return this.netNetWeightMeasureField;
            }
            set
            {
                this.netNetWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  Gross weight (mass) on which a charge is to be based.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType ChargeableWeightMeasure
        {
            get
            {
                return this.chargeableWeightMeasureField;
            }
            set
            {
                this.chargeableWeightMeasureField = value;
            }
        }

        /// <summary>
        ///  Total volume of all goods items referred to as one consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossVolumeMeasure
        {
            get
            {
                return this.grossVolumeMeasureField;
            }
            set
            {
                this.grossVolumeMeasureField = value;
            }
        }

        /// <summary>
        ///  Net volume of all goods items referred to as one consignment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetVolumeMeasure
        {
            get
            {
                return this.netVolumeMeasureField;
            }
            set
            {
                this.netVolumeMeasureField = value;
            }
        }

        /// <summary>
        ///  Total length in a means of transport or a piece of transport equipment whereby the complete width and height over that length is needed for loading all the consignments referred to as one consolidation.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType LoadingLengthMeasure
        {
            get
            {
                return this.loadingLengthMeasureField;
            }
            set
            {
                this.loadingLengthMeasureField = value;
            }
        }

        /// <summary>
        ///  Remarks concerning the complete consignment to be printed on the transport document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <summary>
        ///  Indication that the transport is or is not subject to an international regulation concerning the carriage of dangerous goods.
        ///  Example: default is negative
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
            }
        }

        /// <summary>
        ///  Party to which goods are consigned.
        /// </summary>
        public PartyType ConsigneeParty
        {
            get
            {
                return this.consigneePartyField;
            }
            set
            {
                this.consigneePartyField = value;
            }
        }

        /// <summary>
        ///  The party who makes the export declaration, or on whose behalf the export declaration is made, and who is the owner of the goods or has similar right of disposal over them at the time when the declaration is accepted.
        /// </summary>
        public PartyType ExporterParty
        {
            get
            {
                return this.exporterPartyField;
            }
            set
            {
                this.exporterPartyField = value;
            }
        }

        /// <summary>
        ///  The party consigning goods, as stipulated in the transport contract by the party ordering transport.
        /// </summary>
        public PartyType ConsignorParty
        {
            get
            {
                return this.consignorPartyField;
            }
            set
            {
                this.consignorPartyField = value;
            }
        }

        /// <summary>
        ///  The party who makes an import declaration, or on whose behalf a Customs clearing agent or other authorized person makes an import declaration. This may include a person who has possession of the goods or to whom the goods are consigned.
        /// </summary>
        public PartyType ImporterParty
        {
            get
            {
                return this.importerPartyField;
            }
            set
            {
                this.importerPartyField = value;
            }
        }

        /// <summary>
        ///  The party providing the transport of goods between named points.
        /// </summary>
        public PartyType CarrierParty
        {
            get
            {
                return this.carrierPartyField;
            }
            set
            {
                this.carrierPartyField = value;
            }
        }

        /// <summary>
        ///  The party combining individual smaller consignments into a single larger shipment (so called consolidated shipment) that is sent to a counterpart who mirrors the consolidator's activity by dividing the consolidated consignment into its original components.
        /// </summary>
        public PartyType FreightForwarderParty
        {
            get
            {
                return this.freightForwarderPartyField;
            }
            set
            {
                this.freightForwarderPartyField = value;
            }
        }

        /// <summary>
        ///  The party to be notified.
        /// </summary>
        public PartyType NotifyParty
        {
            get
            {
                return this.notifyPartyField;
            }
            set
            {
                this.notifyPartyField = value;
            }
        }

        /// <summary>
        ///  The original despatch party.
        /// </summary>
        public PartyType OriginalDespatchParty
        {
            get
            {
                return this.originalDespatchPartyField;
            }
            set
            {
                this.originalDespatchPartyField = value;
            }
        }

        /// <summary>
        ///  The final delivery party.
        /// </summary>
        public PartyType FinalDeliveryParty
        {
            get
            {
                return this.finalDeliveryPartyField;
            }
            set
            {
                this.finalDeliveryPartyField = value;
            }
        }

        /// <summary>
        ///  The country from which the goods are originally exported, without any commercial transaction taking place in intermediate countries.
        /// </summary>
        public CountryType OriginalDepartureCountry
        {
            get
            {
                return this.originalDepartureCountryField;
            }
            set
            {
                this.originalDepartureCountryField = value;
            }
        }

        /// <summary>
        ///  Name of the country to which the goods are to be delivered to the final consignee or buyer.
        /// </summary>
        public CountryType FinalDestinationCountry
        {
            get
            {
                return this.finalDestinationCountryField;
            }
            set
            {
                this.finalDestinationCountryField = value;
            }
        }

        /// <summary>
        ///  The countries through which goods or passengers are routed between the country of original departure and the country of final destination.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransitCountry")]
        public CountryType[] TransitCountry
        {
            get
            {
                return this.transitCountryField;
            }
            set
            {
                this.transitCountryField = value;
            }
        }

        /// <summary>
        ///  An association to Transport Contract.
        /// </summary>
        public ContractType TransportContract
        {
            get
            {
                return this.transportContractField;
            }
            set
            {
                this.transportContractField = value;
            }
        }

        /// <summary>
        ///  The service for pick-up from the consignor under the transport contract.
        /// </summary>
        public TransportationServiceType OriginalDespatchTransportationService
        {
            get
            {
                return this.originalDespatchTransportationServiceField;
            }
            set
            {
                this.originalDespatchTransportationServiceField = value;
            }
        }

        /// <summary>
        ///  The service for delivery to the consignee under the transport contract.
        /// </summary>
        public TransportationServiceType FinalDeliveryTransportationService
        {
            get
            {
                return this.finalDeliveryTransportationServiceField;
            }
            set
            {
                this.finalDeliveryTransportationServiceField = value;
            }
        }

        /// <summary>
        ///  All the conditions agreed upon between a seller and a buyer with regard to the delivery of goods and/or services, e.g., CIF, FOB, or EXW from the INCOTERMS Terms of Delivery.
        /// </summary>
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
        ///  The conditions of payment between the parties in a transaction.
        /// </summary>
        public PaymentTermsType PaymentTerms
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
        ///  Costs incurred by the shipper in moving goods, by whatever means, from one place to another under the terms of the contract of carriage. In addition to transport costs, this may include such elements as packing, documentation, loading, unloading, and insurance (to the extent that they relate to the freight costs).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return this.freightAllowanceChargeField;
            }
            set
            {
                this.freightAllowanceChargeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Contract.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ContractType
    {

        private IdentifierType idField;

        private DateType issueDateField;

        private TimeType issueTimeField;

        private CodeType contractTypeCodeField;

        private TextType contractType1Field;

        private PeriodType validityPeriodField;

        private DocumentReferenceType[] contractDocumentReferenceField;

        /// <summary>
        ///  Identifies the Contract.
        ///  Example: "CC23"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The date on which the Contract was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The time at which the Contract was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The type of Contract, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ContractTypeCode
        {
            get
            {
                return this.contractTypeCodeField;
            }
            set
            {
                this.contractTypeCodeField = value;
            }
        }
        /// <summary>
        /// Gets or sets the contract type1.
        /// </summary>
        /// <value>The contract type1.</value>
        [System.Xml.Serialization.XmlElementAttribute("ContractType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType ContractType1
        {
            get
            {
                return this.contractType1Field;
            }
            set
            {
                this.contractType1Field = value;
            }
        }

        /// <summary>
        ///  An association to Validity Period.
        /// </summary>
        public PeriodType ValidityPeriod
        {
            get
            {
                return this.validityPeriodField;
            }
            set
            {
                this.validityPeriodField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Contract Document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference")]
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
    }

    /// <summary>
    ///  Transport service details.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportationServiceType
    {

        private CodeType transportServiceCodeField;

        private CodeType tariffClassCodeField;

        private TextType priorityField;

        private CodeType freightRateClassCodeField;

        /// <summary>
        ///  A code which describes the general type of service required for the transportation of goods. Specifically, it identifies the extent of the transportation service, e.g., door-to-door, port-to-port.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportServiceCode
        {
            get
            {
                return this.transportServiceCodeField;
            }
            set
            {
                this.transportServiceCodeField = value;
            }
        }

        /// <summary>
        ///  Specification of a tariff class applicable to a transportation service.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TariffClassCode
        {
            get
            {
                return this.tariffClassCodeField;
            }
            set
            {
                this.tariffClassCodeField = value;
            }
        }

        /// <summary>
        ///  Statement indicating priority of requested transportation service.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <summary>
        ///  Code to indicate applicable rate class for freight.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType FreightRateClassCode
        {
            get
            {
                return this.freightRateClassCodeField;
            }
            set
            {
                this.freightRateClassCodeField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a shipment stage.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ShipmentStageType
    {

        private IdentifierType idField;

        private TransportModeCodeType transportModeCodeField;

        private CodeType transportMeansTypeCodeField;

        private CodeType transitDirectionCodeField;

        private IndicatorType preCarriageIndicatorField;

        private IndicatorType onCarriageIndicatorField;

        private PeriodType transitPeriodField;

        private PartyType[] carrierPartyField;

        private TransportMeansType transportMeansField;

        private LocationType1 loadingPortLocationField;

        private LocationType1 unloadingPortLocationField;

        private LocationType1 transshipPortLocationField;

        private PartyIdentificationType driverPerson;
        /// <summary>
        ///  Identifies a shipment stage.
        ///  Example: "1","2", etc..
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The method of transport used for a shipment stage.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportModeCodeType TransportModeCode
        {
            get
            {
                return this.transportModeCodeField;
            }
            set
            {
                this.transportModeCodeField = value;
            }
        }

        /// <summary>
        ///  The type of vehicle used for a shipment stage.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportMeansTypeCode
        {
            get
            {
                return this.transportMeansTypeCodeField;
            }
            set
            {
                this.transportMeansTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The direction of transit for a shipment stage.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransitDirectionCode
        {
            get
            {
                return this.transitDirectionCodeField;
            }
            set
            {
                this.transitDirectionCodeField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the stage is before the main carriage of the shipment.
        ///  Example: Truck delivery to wharf
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType PreCarriageIndicator
        {
            get
            {
                return this.preCarriageIndicatorField;
            }
            set
            {
                this.preCarriageIndicatorField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the stage is after the main carriage of the shipment.
        ///  Example: Truck delivery from wharf
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType OnCarriageIndicator
        {
            get
            {
                return this.onCarriageIndicatorField;
            }
            set
            {
                this.onCarriageIndicatorField = value;
            }
        }

        /// <summary>
        ///  An association to Transit Period.
        /// </summary>
        public PeriodType TransitPeriod
        {
            get
            {
                return this.transitPeriodField;
            }
            set
            {
                this.transitPeriodField = value;
            }
        }

        /// <summary>
        ///  An association to Carrier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CarrierParty")]
        public PartyType[] CarrierParty
        {
            get
            {
                return this.carrierPartyField;
            }
            set
            {
                this.carrierPartyField = value;
            }
        }

        /// <summary>
        ///  An association to the means of transport.
        /// </summary>
        public TransportMeansType TransportMeans
        {
            get
            {
                return this.transportMeansField;
            }
            set
            {
                this.transportMeansField = value;
            }
        }

        /// <summary>
        ///  An association to the port location of loading.
        /// </summary>
        public LocationType1 LoadingPortLocation
        {
            get
            {
                return this.loadingPortLocationField;
            }
            set
            {
                this.loadingPortLocationField = value;
            }
        }

        /// <summary>
        ///  An association to the port location of unloading.
        /// </summary>
        public LocationType1 UnloadingPortLocation
        {
            get
            {
                return this.unloadingPortLocationField;
            }
            set
            {
                this.unloadingPortLocationField = value;
            }
        }

        /// <summary>
        ///  An association to the port location of transshipment.
        /// </summary>
        public LocationType1 TransshipPortLocation
        {
            get
            {
                return this.transshipPortLocationField;
            }
            set
            {
                this.transshipPortLocationField = value;
            }
        }

        /// <summary>
        /// Gets or sets the driver person.
        /// </summary>
        /// <value>The driver person.</value>
        public PartyIdentificationType DriverPerson
        {
            get
            {
                return driverPerson;
            }
            set
            {
                driverPerson = value;
            }
        }
    }

    /// <summary>
    ///  The particular vehicle used for the transport of goods or persons.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportMeansType
    {

        private IdentifierType journeyIDField;

        private IdentifierType registrationNationalityIDField;

        private TextType[] registrationNationalityField;

        private CodeType directionCodeField;

        private StowageType stowageField;

        private AirTransportType airTransportField;

        private RoadTransportType roadTransportField;

        private RailTransportType railTransportField;

        private MaritimeTransportType maritimeTransportField;

        private PartyType ownerPartyField;

        /// <summary>
        ///  An identifier assigned to a regularly scheduled service of a means of transport.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType JourneyID
        {
            get
            {
                return this.journeyIDField;
            }
            set
            {
                this.journeyIDField = value;
            }
        }

        /// <summary>
        ///  Formal identification of the country in which a means of transport is registered.
        ///  Example: "LIB"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType RegistrationNationalityID
        {
            get
            {
                return this.registrationNationalityIDField;
            }
            set
            {
                this.registrationNationalityIDField = value;
            }
        }

        /// <summary>
        ///  Name of the country in which a means of transport is registered.
        ///  Example: Liberia
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] RegistrationNationality
        {
            get
            {
                return this.registrationNationalityField;
            }
            set
            {
                this.registrationNationalityField = value;
            }
        }

        /// <summary>
        ///  The direction of the transport means.
        ///  Example: "North","East"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DirectionCode
        {
            get
            {
                return this.directionCodeField;
            }
            set
            {
                this.directionCodeField = value;
            }
        }

        /// <summary>
        ///  Association to a location on board a means of transport where specified goods or transport equipment have been or are to be stowed.
        /// </summary>
        public StowageType Stowage
        {
            get
            {
                return this.stowageField;
            }
            set
            {
                this.stowageField = value;
            }
        }

        /// <summary>
        ///  Association to identify an aircraft.
        /// </summary>
        public AirTransportType AirTransport
        {
            get
            {
                return this.airTransportField;
            }
            set
            {
                this.airTransportField = value;
            }
        }

        /// <summary>
        ///  Association to identify a road vehicle.
        /// </summary>
        public RoadTransportType RoadTransport
        {
            get
            {
                return this.roadTransportField;
            }
            set
            {
                this.roadTransportField = value;
            }
        }

        /// <summary>
        ///  Association to identify a train.
        /// </summary>
        public RailTransportType RailTransport
        {
            get
            {
                return this.railTransportField;
            }
            set
            {
                this.railTransportField = value;
            }
        }

        /// <summary>
        ///  Association to identify a ship.
        /// </summary>
        public MaritimeTransportType MaritimeTransport
        {
            get
            {
                return this.maritimeTransportField;
            }
            set
            {
                this.maritimeTransportField = value;
            }
        }

        /// <summary>
        ///  Association to the party owning the means of transport.
        /// </summary>
        public PartyType OwnerParty
        {
            get
            {
                return this.ownerPartyField;
            }
            set
            {
                this.ownerPartyField = value;
            }
        }
    }

    /// <summary>
    ///  A location on board a means of transport where specified goods or transport equipment have been or are to be stowed.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class StowageType
    {

        private IdentifierType locationIDField;

        private TextType[] locationField;

        private DimensionType[] measurementDimensionField;

        /// <summary>
        ///  Identifies a location on board a means of transport where specified goods or transport equipment have been or are to be stowed.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LocationID
        {
            get
            {
                return this.locationIDField;
            }
            set
            {
                this.locationIDField = value;
            }
        }

        /// <summary>
        ///  Describes a location on board a means of transport where specified goods or transport equipment have been or are to be stowed.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Location", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <summary>
        ///  Associates any measurements (including lengths, mass, and volume) for this stowage.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return this.measurementDimensionField;
            }
            set
            {
                this.measurementDimensionField = value;
            }
        }
    }

    /// <summary>
    ///  Describes a road transport vehicle.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RoadTransportType
    {

        private IdentifierType licensePlateIDField;
        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="RoadTransportType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator RoadTransportType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new RoadTransportType { LicensePlateID = value };
        }

        /// <summary>
        ///  Identifies a specific vehicle.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LicensePlateID
        {
            get
            {
                return this.licensePlateIDField;
            }
            set
            {
                this.licensePlateIDField = value;
            }
        }
    }

    /// <summary>
    ///  Describes a train.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RailTransportType
    {

        private IdentifierType trainIDField;

        private IdentifierType railCarIDField;

        /// <summary>
        ///  Identifies a train.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType TrainID
        {
            get
            {
                return this.trainIDField;
            }
            set
            {
                this.trainIDField = value;
            }
        }

        /// <summary>
        ///  Identifies the rail car on the train used for the means of transport.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType RailCarID
        {
            get
            {
                return this.railCarIDField;
            }
            set
            {
                this.railCarIDField = value;
            }
        }
    }

    /// <summary>
    ///  Describes a water (including sea, river, and canal) transport vessel.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MaritimeTransportType
    {

        private IdentifierType vesselIDField;

        private NameType vesselNameField;

        /// <summary>
        ///  Identifies a specific vessel.
        ///  Example: International Maritime Organisation number of a vessel
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType VesselID
        {
            get
            {
                return this.vesselIDField;
            }
            set
            {
                this.vesselIDField = value;
            }
        }

        /// <summary>
        ///  The name of the vessel.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType VesselName
        {
            get
            {
                return this.vesselNameField;
            }
            set
            {
                this.vesselNameField = value;
            }
        }
    }

    /// <summary>
    ///  A uniquely identifiable physical unit consisting of one or more packages (not necessarily containing the same articles) for enabling physical handling during the transport process.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportHandlingUnitType
    {

        private IdentifierType idField;

        private CodeType transportHandlingUnitTypeCodeField;

        private CodeType handlingCodeField;

        private TextType handlingInstructionsField;

        private IndicatorType hazardousRiskIndicatorField;

        private QuantityType totalGoodsItemQuantityField;

        private QuantityType totalPackageQuantityField;

        private TextType[] damageRemarksField;

        private TextType[] shippingMarksField;

        private DespatchLineType[] handlingUnitDespatchLineField;

        private PackageType[] actualPackageField;

        private ReceiptLineType[] receivedHandlingUnitReceiptLineField;

        private TransportEquipmentType[] transportEquipmentField;

        private HazardousGoodsTransitType[] hazardousGoodsTransitField;

        private DimensionType[] measurementDimensionField;

        private TemperatureType minimumTemperatureField;

        private TemperatureType maximumTemperatureField;

        /// <summary>
        ///  Identifies the transport handling unit.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The type of transport handling unit, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportHandlingUnitTypeCode
        {
            get
            {
                return this.transportHandlingUnitTypeCodeField;
            }
            set
            {
                this.transportHandlingUnitTypeCodeField = value;
            }
        }

        /// <summary>
        ///  The handling required for a shipment, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType HandlingCode
        {
            get
            {
                return this.handlingCodeField;
            }
            set
            {
                this.handlingCodeField = value;
            }
        }

        /// <summary>
        ///  Free-form text describing handling instructions for a shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType HandlingInstructions
        {
            get
            {
                return this.handlingInstructionsField;
            }
            set
            {
                this.handlingInstructionsField = value;
            }
        }

        /// <summary>
        ///  Indicates whether the shipment contains hazardous materials.
        ///  Example: Default is negative
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
            }
        }

        /// <summary>
        ///  The total number of goods items in the transport handling unit.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType TotalGoodsItemQuantity
        {
            get
            {
                return this.totalGoodsItemQuantityField;
            }
            set
            {
                this.totalGoodsItemQuantityField = value;
            }
        }

        /// <summary>
        ///  The total number of packages in the transport handling unit.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType TotalPackageQuantity
        {
            get
            {
                return this.totalPackageQuantityField;
            }
            set
            {
                this.totalPackageQuantityField = value;
            }
        }

        /// <summary>
        ///  Description of a type of damage.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] DamageRemarks
        {
            get
            {
                return this.damageRemarksField;
            }
            set
            {
                this.damageRemarksField = value;
            }
        }

        /// <summary>
        ///  Free-form description of the marks and numbers on a transport unit or package.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ShippingMarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] ShippingMarks
        {
            get
            {
                return this.shippingMarksField;
            }
            set
            {
                this.shippingMarksField = value;
            }
        }

        /// <summary>
        ///  An association to Handling Unit Despatch Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("HandlingUnitDespatchLine")]
        public DespatchLineType[] HandlingUnitDespatchLine
        {
            get
            {
                return this.handlingUnitDespatchLineField;
            }
            set
            {
                this.handlingUnitDespatchLineField = value;
            }
        }

        /// <summary>
        ///  An association to Actual Package.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ActualPackage")]
        public PackageType[] ActualPackage
        {
            get
            {
                return this.actualPackageField;
            }
            set
            {
                this.actualPackageField = value;
            }
        }

        /// <summary>
        ///  An association to Receipt Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReceivedHandlingUnitReceiptLine")]
        public ReceiptLineType[] ReceivedHandlingUnitReceiptLine
        {
            get
            {
                return this.receivedHandlingUnitReceiptLineField;
            }
            set
            {
                this.receivedHandlingUnitReceiptLineField = value;
            }
        }

        /// <summary>
        ///  An association to Transport Equipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment
        {
            get
            {
                return this.transportEquipmentField;
            }
            set
            {
                this.transportEquipmentField = value;
            }
        }

        /// <summary>
        ///  An association to information about the transportation of hazardous goods.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return this.hazardousGoodsTransitField;
            }
            set
            {
                this.hazardousGoodsTransitField = value;
            }
        }

        /// <summary>
        ///  An association to Dimension.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return this.measurementDimensionField;
            }
            set
            {
                this.measurementDimensionField = value;
            }
        }

        /// <summary>
        ///  The minimum required operating temperature.
        /// </summary>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
            }
        }

        /// <summary>
        ///  The maximum required operating temperature.
        /// </summary>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Despatch Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DespatchLineType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private TextType noteField;

        private LineStatusCodeType lineStatusCodeField;

        private QuantityType deliveredQuantityField;

        private QuantityType backorderQuantityField;

        private TextType backorderReasonField;

        private QuantityType outstandingQuantityField;

        private TextType outstandingReasonField;

        private QuantityType oversupplyQuantityField;

        private OrderLineReferenceType[] orderLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType itemField;

        private ShipmentType[] shipmentField;

        /// <summary>
        ///  Identifies the Despatch Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Despatch Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  Identifies the status of the Despatch Line with respect to its original state.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return this.lineStatusCodeField;
            }
            set
            {
                this.lineStatusCodeField = value;
            }
        }

        /// <summary>
        ///  The quantity despatched.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType DeliveredQuantity
        {
            get
            {
                return this.deliveredQuantityField;
            }
            set
            {
                this.deliveredQuantityField = value;
            }
        }

        /// <summary>
        ///  The quantity on Back Order at the Supplier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType BackorderQuantity
        {
            get
            {
                return this.backorderQuantityField;
            }
            set
            {
                this.backorderQuantityField = value;
            }
        }

        /// <summary>
        ///  The reason for the Back Order.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType BackorderReason
        {
            get
            {
                return this.backorderReasonField;
            }
            set
            {
                this.backorderReasonField = value;
            }
        }

        /// <summary>
        ///  The quantity outstanding (which will follow in a later despatch).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType OutstandingQuantity
        {
            get
            {
                return this.outstandingQuantityField;
            }
            set
            {
                this.outstandingQuantityField = value;
            }
        }

        /// <summary>
        ///  The reason for the Outstanding Quantity.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType OutstandingReason
        {
            get
            {
                return this.outstandingReasonField;
            }
            set
            {
                this.outstandingReasonField = value;
            }
        }

        /// <summary>
        ///  The quantity over-supplied.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType OversupplyQuantity
        {
            get
            {
                return this.oversupplyQuantityField;
            }
            set
            {
                this.oversupplyQuantityField = value;
            }
        }

        /// <summary>
        ///  An association to Order Line Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference
        {
            get
            {
                return this.orderLineReferenceField;
            }
            set
            {
                this.orderLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Item.
        /// </summary>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        ///  An association to Shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Shipment")]
        public ShipmentType[] Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Receipt Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ReceiptLineType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private TextType noteField;

        private QuantityType receivedQuantityField;

        private QuantityType shortQuantityField;

        private CodeType shortageActionCodeField;

        private QuantityType rejectedQuantityField;

        private CodeType rejectReasonCodeField;

        private TextType rejectReasonField;

        private CodeType rejectActionCodeField;

        private QuantityType oversupplyQuantityField;

        private DateType receivedDateField;

        private CodeType timingComplaintCodeField;

        private TextType timingComplaintField;

        private OrderLineReferenceType orderLineReferenceField;

        private LineReferenceType[] despatchLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType[] itemField;

        private ShipmentType[] shipmentField;

        /// <summary>
        ///  Identifies the Receipt Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Receipt Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  The quantity received.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType ReceivedQuantity
        {
            get
            {
                return this.receivedQuantityField;
            }
            set
            {
                this.receivedQuantityField = value;
            }
        }

        /// <summary>
        ///  The quantity received short; the difference between the quantity reported despatched and the quantity actually received.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType ShortQuantity
        {
            get
            {
                return this.shortQuantityField;
            }
            set
            {
                this.shortQuantityField = value;
            }
        }

        /// <summary>
        ///  The action that the Delivery Party wishes the Despatch Party to take as a result of the shortage, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ShortageActionCode
        {
            get
            {
                return this.shortageActionCodeField;
            }
            set
            {
                this.shortageActionCodeField = value;
            }
        }

        /// <summary>
        ///  The quantity rejected.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType RejectedQuantity
        {
            get
            {
                return this.rejectedQuantityField;
            }
            set
            {
                this.rejectedQuantityField = value;
            }
        }

        /// <summary>
        ///  The reason for rejection, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType RejectReasonCode
        {
            get
            {
                return this.rejectReasonCodeField;
            }
            set
            {
                this.rejectReasonCodeField = value;
            }
        }

        /// <summary>
        ///  The reason for rejection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType RejectReason
        {
            get
            {
                return this.rejectReasonField;
            }
            set
            {
                this.rejectReasonField = value;
            }
        }

        /// <summary>
        ///  The action that the Delivery Party wishes the Despatch Party to take as a result of the rejection, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType RejectActionCode
        {
            get
            {
                return this.rejectActionCodeField;
            }
            set
            {
                this.rejectActionCodeField = value;
            }
        }

        /// <summary>
        ///  The quantity over-supplied, i.e., the quantity over and above that ordered.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType OversupplyQuantity
        {
            get
            {
                return this.oversupplyQuantityField;
            }
            set
            {
                this.oversupplyQuantityField = value;
            }
        }

        /// <summary>
        ///  The date on which the good/services are received.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ReceivedDate
        {
            get
            {
                return this.receivedDateField;
            }
            set
            {
                this.receivedDateField = value;
            }
        }

        /// <summary>
        ///  A complaint about the timing of delivery, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TimingComplaintCode
        {
            get
            {
                return this.timingComplaintCodeField;
            }
            set
            {
                this.timingComplaintCodeField = value;
            }
        }

        /// <summary>
        ///  A complaint about the timing of delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType TimingComplaint
        {
            get
            {
                return this.timingComplaintField;
            }
            set
            {
                this.timingComplaintField = value;
            }
        }

        /// <summary>
        ///  An association to Order Line Reference.
        /// </summary>
        public OrderLineReferenceType OrderLineReference
        {
            get
            {
                return this.orderLineReferenceField;
            }
            set
            {
                this.orderLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Despatch Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return this.despatchLineReferenceField;
            }
            set
            {
                this.despatchLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public ItemType[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        ///  An association to Shipment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Shipment")]
        public ShipmentType[] Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }
    }

    /// <summary>
    ///  Details of Catalogue Line Item Specification.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CatalogueItemSpecificationUpdateLineType
    {

        private IdentifierType idField;

        private CustomerPartyType contractorCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private ItemType itemField;

        /// <summary>
        ///  A unique instance identifier for the line in this Catalogue document.
        ///  Example: "1"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The Customer Party responsible for the contract to which the Catalogue relates.
        /// </summary>
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                return this.contractorCustomerPartyField;
            }
            set
            {
                this.contractorCustomerPartyField = value;
            }
        }

        /// <summary>
        ///  An association to the Seller of the item.
        /// </summary>
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
        ///  An association to Item itself.
        /// </summary>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <summary>
    ///  The basic element of Catalogue; something that can be bought.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CatalogueLineType
    {

        private IdentifierType idField;

        private CodeType actionCodeField;

        private CodeType lifeCycleStatusCodeField;

        private TextType contractSubdivisionField;

        private TextType[] noteField;

        private IndicatorType orderableIndicatorField;

        private TextType orderableUnitField;

        private QuantityType contentUnitQuantityField;

        private NumericType orderQuantityIncrementNumericField;

        private QuantityType minimumOrderQuantityField;

        private QuantityType maximumOrderQuantityField;

        private TextType[] warrantyInformationField;

        private CodeType packLevelCodeField;

        private CustomerPartyType contractorCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private PartyType warrantyPartyField;

        private PeriodType warrantyValidityPeriodField;

        private PeriodType lineValidityPeriodField;

        private ItemComparisonType[] itemComparisonField;

        private RelatedItemType[] componentRelatedItemField;

        private RelatedItemType[] accessoryRelatedItemField;

        private RelatedItemType[] requiredRelatedItemField;

        private RelatedItemType[] replacementRelatedItemField;

        private RelatedItemType[] complementaryRelatedItemField;

        private ItemLocationQuantityType[] requiredItemLocationQuantityField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType itemField;

        /// <summary>
        ///  A unique instance identifier for the line in this Catalogue document.
        ///  Example: "1"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Code indicating the action required for this item to synchronize with external repositories.
        ///  Example: "Replace", "Update", "Delete","Add"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ActionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                this.actionCodeField = value;
            }
        }

        /// <summary>
        ///  Code indicating availability of this line.
        ///  Example: "new - announcement only", "new and available", "deleted - announcement only"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType LifeCycleStatusCode
        {
            get
            {
                return this.lifeCycleStatusCodeField;
            }
            set
            {
                this.lifeCycleStatusCodeField = value;
            }
        }

        /// <summary>
        ///  Identifies a subdivision of a contract or tender.
        ///  Example: "Installation", "Phase One", Support and Maintenance"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType ContractSubdivision
        {
            get
            {
                return this.contractSubdivisionField;
            }
            set
            {
                this.contractSubdivisionField = value;
            }
        }

        /// <summary>
        ///  Free-text note used for non-structured information about the line in the specific Catalogue document (intended to be human readable).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Indicates whether the line is orderable (that is, not just for information only).
        ///  Example: TRUE means orderable, FALSE means not orderable
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType OrderableIndicator
        {
            get
            {
                return this.orderableIndicatorField;
            }
            set
            {
                this.orderableIndicatorField = value;
            }
        }

        /// <summary>
        ///  The unit that can be ordered.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType OrderableUnit
        {
            get
            {
                return this.orderableUnitField;
            }
            set
            {
                this.orderableUnitField = value;
            }
        }

        /// <summary>
        ///  The quantity of the order unit of measure of the line.
        ///  Example: If order unit measure identifier is "each", then content unit quantity is "1".
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType ContentUnitQuantity
        {
            get
            {
                return this.contentUnitQuantityField;
            }
            set
            {
                this.contentUnitQuantityField = value;
            }
        }

        /// <summary>
        ///  The number of items that can set the order quantity increments.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType OrderQuantityIncrementNumeric
        {
            get
            {
                return this.orderQuantityIncrementNumericField;
            }
            set
            {
                this.orderQuantityIncrementNumericField = value;
            }
        }

        /// <summary>
        ///  The minimum amount of items that can be ordered.
        ///  Example: "10 boxes"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MinimumOrderQuantity
        {
            get
            {
                return this.minimumOrderQuantityField;
            }
            set
            {
                this.minimumOrderQuantityField = value;
            }
        }

        /// <summary>
        ///  The maximum amount of items that can be ordered.
        ///  Example: "1 tonne"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType MaximumOrderQuantity
        {
            get
            {
                return this.maximumOrderQuantityField;
            }
            set
            {
                this.maximumOrderQuantityField = value;
            }
        }

        /// <summary>
        ///  Information regarding the warranty for the good or service.  Warranty may be provided by any Party (can be described in the association to Warranty Party).
        ///  Example: "Unless specified otherwise and in addition to any rights the Customer may have under statute, Dell warrants to the Customer that Dell branded Products (excluding third party products and software), will be free from defects in materials and workmanship affecting normal use for a period of one year from invoice date ('Standard Warranty')."
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] WarrantyInformation
        {
            get
            {
                return this.warrantyInformationField;
            }
            set
            {
                this.warrantyInformationField = value;
            }
        }

        /// <summary>
        ///  The level of packaging involved.
        ///  Example: "level 2", "Group 4"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PackLevelCode
        {
            get
            {
                return this.packLevelCodeField;
            }
            set
            {
                this.packLevelCodeField = value;
            }
        }

        /// <summary>
        ///  The Customer Party responsible for the contract to which the Catalogue relates.
        /// </summary>
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                return this.contractorCustomerPartyField;
            }
            set
            {
                this.contractorCustomerPartyField = value;
            }
        }

        /// <summary>
        ///  An association to Seller of the item.
        /// </summary>
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
        ///  The party responsible for the Warranty.
        /// </summary>
        public PartyType WarrantyParty
        {
            get
            {
                return this.warrantyPartyField;
            }
            set
            {
                this.warrantyPartyField = value;
            }
        }

        /// <summary>
        ///  The period for which the Warranty is valid.
        /// </summary>
        public PeriodType WarrantyValidityPeriod
        {
            get
            {
                return this.warrantyValidityPeriodField;
            }
            set
            {
                this.warrantyValidityPeriodField = value;
            }
        }

        /// <summary>
        ///  The period for which the Catalogue Line is valid.
        /// </summary>
        public PeriodType LineValidityPeriod
        {
            get
            {
                return this.lineValidityPeriodField;
            }
            set
            {
                this.lineValidityPeriodField = value;
            }
        }

        /// <summary>
        ///  An association to comparative details for this Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemComparison")]
        public ItemComparisonType[] ItemComparison
        {
            get
            {
                return this.itemComparisonField;
            }
            set
            {
                this.itemComparisonField = value;
            }
        }

        /// <summary>
        ///  An association that describes any catalogue items that may be components of this Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ComponentRelatedItem")]
        public RelatedItemType[] ComponentRelatedItem
        {
            get
            {
                return this.componentRelatedItemField;
            }
            set
            {
                this.componentRelatedItemField = value;
            }
        }

        /// <summary>
        ///  An association that describes any catalogue items that may be optional accessories to this Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AccessoryRelatedItem")]
        public RelatedItemType[] AccessoryRelatedItem
        {
            get
            {
                return this.accessoryRelatedItemField;
            }
            set
            {
                this.accessoryRelatedItemField = value;
            }
        }

        /// <summary>
        ///  An association that describes any catalogue items that may be required for this Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("RequiredRelatedItem")]
        public RelatedItemType[] RequiredRelatedItem
        {
            get
            {
                return this.requiredRelatedItemField;
            }
            set
            {
                this.requiredRelatedItemField = value;
            }
        }

        /// <summary>
        ///  An association that describes any catalogue items that may be replacements for this Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem")]
        public RelatedItemType[] ReplacementRelatedItem
        {
            get
            {
                return this.replacementRelatedItemField;
            }
            set
            {
                this.replacementRelatedItemField = value;
            }
        }

        /// <summary>
        ///  An association that describes any catalogue items that may complement this Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ComplementaryRelatedItem")]
        public RelatedItemType[] ComplementaryRelatedItem
        {
            get
            {
                return this.complementaryRelatedItemField;
            }
            set
            {
                this.complementaryRelatedItemField = value;
            }
        }

        /// <summary>
        ///  An association to the description of properties related to locations and quantities of the Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return this.requiredItemLocationQuantityField;
            }
            set
            {
                this.requiredItemLocationQuantityField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to the Item itself.
        /// </summary>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <summary>
    ///  Used to compare different items based on cost, quantity, or measurements.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemComparisonType
    {

        private AmountType priceAmountField;

        private QuantityType quantityField;

        /// <summary>
        ///  The price for the comparison quantity of the item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PriceAmount
        {
            get
            {
                return this.priceAmountField;
            }
            set
            {
                this.priceAmountField = value;
            }
        }

        /// <summary>
        ///  The quantity used for price comparison with other items.
        ///  Example: "per unit"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <summary>
    ///  Details of Catalogue Line Pricing.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CataloguePricingUpdateLineType
    {

        private IdentifierType idField;

        private CustomerPartyType contractorCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private ItemLocationQuantityType[] requiredItemLocationQuantityField;

        /// <summary>
        ///  A unique instance identifier for the line in this Catalogue document.
        ///  Example: "1"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The Customer Party responsible for the contract to which the Catalogue relates.
        /// </summary>
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                return this.contractorCustomerPartyField;
            }
            set
            {
                this.contractorCustomerPartyField = value;
            }
        }

        /// <summary>
        ///  An association to the Seller of the Item.
        /// </summary>
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
        ///  An association to the description of properties related to locations and quantities of the item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return this.requiredItemLocationQuantityField;
            }
            set
            {
                this.requiredItemLocationQuantityField = value;
            }
        }
    }

    /// <summary>
    ///  A reference to a Catalogue.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CatalogueReferenceType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private DateType issueDateField;

        private TimeType issueTimeField;

        private DateType revisionDateField;

        private TimeType revisionTimeField;

        private TextType[] noteField;

        private TextType[] descriptionField;

        private IdentifierType versionIDField;

        private IdentifierType previousVersionIDField;

        /// <summary>
        ///  Identifies a reference to a Catalogue document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The date when the Catalogue was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The time when the Catalogue was issued.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The date on which the information in the Catalogue was revised.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType RevisionDate
        {
            get
            {
                return this.revisionDateField;
            }
            set
            {
                this.revisionDateField = value;
            }
        }

        /// <summary>
        ///  The time at which the information in the Catalogue was revised.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType RevisionTime
        {
            get
            {
                return this.revisionTimeField;
            }
            set
            {
                this.revisionTimeField = value;
            }
        }

        /// <summary>
        ///  A free-text note about the Catalogue. This is used for information which is only human readable.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A description of the Catalogue.
        ///  Example: "computer accessories for laptops"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  Indicates the current version of the Catalogue.
        ///  Example: "1.1"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType VersionID
        {
            get
            {
                return this.versionIDField;
            }
            set
            {
                this.versionIDField = value;
            }
        }

        /// <summary>
        ///  Indicates the previous version (the version superseded by this Catalogue).
        ///  Example: "1.0"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType PreviousVersionID
        {
            get
            {
                return this.previousVersionIDField;
            }
            set
            {
                this.previousVersionIDField = value;
            }
        }
    }

    /// <summary>
    ///  The basic element of Catalogue; something that can be bought.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CatalogueRequestLineType
    {

        private IdentifierType idField;

        private TextType contractSubdivisionField;

        private TextType[] noteField;

        private PeriodType lineValidityPeriodField;

        private ItemLocationQuantityType[] requiredItemLocationQuantityField;

        private ItemType itemField;

        /// <summary>
        ///  A unique instance identifier for the line in this Catalogue document.
        ///  Example: "1"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Identifies a subdivision of a contract or tender.
        ///  Example: "Installation", "Phase One", Support and Maintenance"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType ContractSubdivision
        {
            get
            {
                return this.contractSubdivisionField;
            }
            set
            {
                this.contractSubdivisionField = value;
            }
        }

        /// <summary>
        ///  Free-text note used for non-structured information about the line in the specific Catalogue document (intended to be human readable).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The period for which the Catalogue Line is valid.
        /// </summary>
        public PeriodType LineValidityPeriod
        {
            get
            {
                return this.lineValidityPeriodField;
            }
            set
            {
                this.lineValidityPeriodField = value;
            }
        }

        /// <summary>
        ///  An association to the description of properties related to locations and quantities of the item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return this.requiredItemLocationQuantityField;
            }
            set
            {
                this.requiredItemLocationQuantityField = value;
            }
        }

        /// <summary>
        ///  An association to the Item itself.
        /// </summary>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Classification Category; a subdivision of a Classification Scheme.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ClassificationCategoryType
    {

        private NameType nameField;

        private TextType codeValueField;

        private TextType[] descriptionField;

        private ClassificationCategoryType[] categorizesClassificationCategoryField;

        /// <summary>
        ///  The name of the Classification Category.
        ///  Example: "UNSPSC Class", "UNSPSC Segment", "UNSPSC Family"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  The Classification Category value.
        ///  Example: 3420001, 3273666, HSJJD-213
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType CodeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }

        /// <summary>
        ///  The description of the Classification Category.
        ///  Example: "Electrical Goods", "Wooden Toys"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  An association to subcategories within the Category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CategorizesClassificationCategory")]
        public ClassificationCategoryType[] CategorizesClassificationCategory
        {
            get
            {
                return this.categorizesClassificationCategoryField;
            }
            set
            {
                this.categorizesClassificationCategoryField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Certificate of Origin application.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CertificateOfOriginApplicationType
    {

        private IdentifierType referenceIDField;

        private TextType certificateTypeField;

        private CodeType applicationStatusCodeField;

        private IdentifierType originalJobIDField;

        private IdentifierType previousJobIDField;

        private TextType remarksField;

        private ShipmentType shipmentField;

        private EndorserPartyType[] endorserPartyField;

        private PartyType preparationPartyField;

        private PartyType issuerPartyField;

        private CountryType issuingCountryField;

        private DocumentDistributionType[] documentDistributionField;

        private DocumentReferenceType[] supportingDocumentReferenceField;

        private SignatureType[] signatureField;

        /// <summary>
        ///  Holds the unique number that identifies the Despatch Advice, typically according to the seller's system that generated the Despatch Advice.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ReferenceID
        {
            get
            {
                return this.referenceIDField;
            }
            set
            {
                this.referenceIDField = value;
            }
        }

        /// <summary>
        ///  Type of CO. Type could be Ordinary, Re-export, Commonwealth Preferential etc.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType CertificateType
        {
            get
            {
                return this.certificateTypeField;
            }
            set
            {
                this.certificateTypeField = value;
            }
        }

        /// <summary>
        ///  Indicates the status of the application (revision, replacement, etc.).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ApplicationStatusCode
        {
            get
            {
                return this.applicationStatusCodeField;
            }
            set
            {
                this.applicationStatusCodeField = value;
            }
        }

        /// <summary>
        ///  The latest Job Number given to the Origin application. This is used by the system to keep track of the amendments or cancellation of the origin application applied earlier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType OriginalJobID
        {
            get
            {
                return this.originalJobIDField;
            }
            set
            {
                this.originalJobIDField = value;
            }
        }

        /// <summary>
        ///  The previous Job Number assigned in case the application undergoes query or change. This is used by the system to keep track of the amendments or cancellation of the origin application applied earlier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType PreviousJobID
        {
            get
            {
                return this.previousJobIDField;
            }
            set
            {
                this.previousJobIDField = value;
            }
        }

        /// <summary>
        ///  Remarks by the applicant for the Certificate of Origin Application.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <summary>
        ///  An association to Shipment.
        /// </summary>
        public ShipmentType Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }

        /// <summary>
        ///  The party providing the endorsement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("EndorserParty")]
        public EndorserPartyType[] EndorserParty
        {
            get
            {
                return this.endorserPartyField;
            }
            set
            {
                this.endorserPartyField = value;
            }
        }

        /// <summary>
        ///  Details of an individual, a group, or a body that prepares the Certificate of Origin application.
        /// </summary>
        public PartyType PreparationParty
        {
            get
            {
                return this.preparationPartyField;
            }
            set
            {
                this.preparationPartyField = value;
            }
        }

        /// <summary>
        ///  Details of the authorized organization that issued the Certificate of Origin.
        /// </summary>
        public PartyType IssuerParty
        {
            get
            {
                return this.issuerPartyField;
            }
            set
            {
                this.issuerPartyField = value;
            }
        }

        /// <summary>
        ///  The country for which the Certificate of Origin is issued.
        /// </summary>
        public CountryType IssuingCountry
        {
            get
            {
                return this.issuingCountryField;
            }
            set
            {
                this.issuingCountryField = value;
            }
        }

        /// <summary>
        ///  The distribution of the Certificate of Origin to interested parties.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentDistribution")]
        public DocumentDistributionType[] DocumentDistribution
        {
            get
            {
                return this.documentDistributionField;
            }
            set
            {
                this.documentDistributionField = value;
            }
        }

        /// <summary>
        ///  An associative reference to a supporting document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SupportingDocumentReference")]
        public DocumentReferenceType[] SupportingDocumentReference
        {
            get
            {
                return this.supportingDocumentReferenceField;
            }
            set
            {
                this.supportingDocumentReferenceField = value;
            }
        }

        /// <summary>
        ///  One or more signatures applied to the document instance.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature")]
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
    }

    /// <summary>
    ///  The party endorsing a document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EndorserPartyType
    {

        private CodeType roleCodeField;

        private NumericType sequenceNumericField;

        private PartyType partyField;

        private ContactType signatoryContactField;

        /// <summary>
        ///  The role of the party providing the endorsement, e.g., Issuer, Embassy, Insurance, etc.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType RoleCode
        {
            get
            {
                return this.roleCodeField;
            }
            set
            {
                this.roleCodeField = value;
            }
        }

        /// <summary>
        ///  The sequence in which the endorsements are to be applied.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType SequenceNumeric
        {
            get
            {
                return this.sequenceNumericField;
            }
            set
            {
                this.sequenceNumericField = value;
            }
        }

        /// <summary>
        ///  Details of the party endorsing the application.
        /// </summary>
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <summary>
        ///  Details of the individual representing the exporter who signs the Certificate of Origin application before submitting it to the Issuer Party.
        /// </summary>
        public ContactType SignatoryContact
        {
            get
            {
                return this.signatoryContactField;
            }
            set
            {
                this.signatoryContactField = value;
            }
        }
    }

    /// <summary>
    ///  The details of the distribution of the document among business partners.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DocumentDistributionType
    {

        private TextType printQualifierField;

        private NumericType maximumCopiesNumericField;

        private PartyType partyField;

        /// <summary>
        ///  The access right for a Party to distribute the document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PrintQualifier
        {
            get
            {
                return this.printQualifierField;
            }
            set
            {
                this.printQualifierField = value;
            }
        }

        /// <summary>
        ///  Specifies the maximum number of copies of the document that the user can print.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType MaximumCopiesNumeric
        {
            get
            {
                return this.maximumCopiesNumericField;
            }
            set
            {
                this.maximumCopiesNumericField = value;
            }
        }

        /// <summary>
        ///  Details of the Party who can access the document.
        /// </summary>
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <summary>
    ///  Information about signature. A placeholder for signature.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SignatureType
    {

        private IdentifierType idField;

        private TextType noteField;

        private DateType validationDateField;

        private TimeType validationTimeField;

        private IdentifierType validatorIDField;

        private TextType canonicalizationMethodField;

        private TextType signatureMethodField;

        private PartyType signatoryPartyField;

        private AttachmentType digitalSignatureAttachmentField;

        private DocumentReferenceType originalDocumentReferenceField;

        /// <summary>
        ///  An identifier for the Signature.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free form text about the signature or the circumstances where the signature has been used.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  Specifies the date when the signature was approved.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ValidationDate
        {
            get
            {
                return this.validationDateField;
            }
            set
            {
                this.validationDateField = value;
            }
        }

        /// <summary>
        ///  Specifies the time when the signature was approved.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType ValidationTime
        {
            get
            {
                return this.validationTimeField;
            }
            set
            {
                this.validationTimeField = value;
            }
        }

        /// <summary>
        ///  Identifies the organization, person, service or server that has validated the signature.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ValidatorID
        {
            get
            {
                return this.validatorIDField;
            }
            set
            {
                this.validatorIDField = value;
            }
        }

        /// <summary>
        ///  The mathematical logic method used by the Signature.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <summary>
        ///  The method of signature.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <summary>
        ///  An association to the signing Party.
        /// </summary>
        public PartyType SignatoryParty
        {
            get
            {
                return this.signatoryPartyField;
            }
            set
            {
                this.signatoryPartyField = value;
            }
        }

        /// <summary>
        ///  Refers to the actual encoded signature (e.g., in XMLDSIG format).
        /// </summary>
        public AttachmentType DigitalSignatureAttachment
        {
            get
            {
                return this.digitalSignatureAttachmentField;
            }
            set
            {
                this.digitalSignatureAttachmentField = value;
            }
        }

        /// <summary>
        ///  A reference to the actual document that the signature applies to. For evidentiary purposes, this may be the document image that the signatory party saw when applying their signature.
        /// </summary>
        public DocumentReferenceType OriginalDocumentReference
        {
            get
            {
                return this.originalDocumentReferenceField;
            }
            set
            {
                this.originalDocumentReferenceField = value;
            }
        }
    }

    /// <summary>
    ///  Information about Classification Scheme; a scheme that defines a taxonomy for classifying goods or services.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ClassificationSchemeType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private DateType lastRevisionDateField;

        private TimeType lastRevisionTimeField;

        private TextType noteField;

        private NameType nameField;

        private TextType[] descriptionField;

        private IdentifierType agencyIDField;

        private TextType agencyNameField;

        private IdentifierType versionIDField;

        private IdentifierType uRIField;

        private IdentifierType schemeURIField;

        private IdentifierType languageIDField;

        private ClassificationCategoryType[] classificationCategoryField;

        /// <summary>
        ///  An identifier for the classification scheme.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The date at which the classification scheme was last revised.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType LastRevisionDate
        {
            get
            {
                return this.lastRevisionDateField;
            }
            set
            {
                this.lastRevisionDateField = value;
            }
        }

        /// <summary>
        ///  The time at which the classification scheme was last revised.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType LastRevisionTime
        {
            get
            {
                return this.lastRevisionTimeField;
            }
            set
            {
                this.lastRevisionTimeField = value;
            }
        }

        /// <summary>
        ///  Free-form text applying to the Classification Scheme. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  The name of the Classification Scheme.
        ///  Example: "UNSPSC"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        ///  A description of the Classification Scheme.
        ///  Example: "an open, global multi-sector standard for classification of products and services"
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  Identifies the agency that maintains the Classification Scheme.
        ///  Example: Defaults to the UN/EDIFACT data element 3055 code list.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType AgencyID
        {
            get
            {
                return this.agencyIDField;
            }
            set
            {
                this.agencyIDField = value;
            }
        }

        /// <summary>
        ///  The name of the agency that maintains the Classification Scheme.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AgencyName
        {
            get
            {
                return this.agencyNameField;
            }
            set
            {
                this.agencyNameField = value;
            }
        }

        /// <summary>
        ///  Identifies the version of the Classification Scheme.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType VersionID
        {
            get
            {
                return this.versionIDField;
            }
            set
            {
                this.versionIDField = value;
            }
        }

        /// <summary>
        ///  The Uniform Resource Identifier (URI) that identifies where the Classification is located.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <summary>
        ///  The Uniform Resource Identifier (URI) that identifies where the Classification Scheme is located.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SchemeURI
        {
            get
            {
                return this.schemeURIField;
            }
            set
            {
                this.schemeURIField = value;
            }
        }

        /// <summary>
        ///  Identifies the language of the Classification Scheme.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType LanguageID
        {
            get
            {
                return this.languageIDField;
            }
            set
            {
                this.languageIDField = value;
            }
        }

        /// <summary>
        ///  An association to Classification Category.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ClassificationCategory")]
        public ClassificationCategoryType[] ClassificationCategory
        {
            get
            {
                return this.classificationCategoryField;
            }
            set
            {
                this.classificationCategoryField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Credit Note Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CreditNoteLineType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private TextType noteField;

        private QuantityType creditedQuantityField;

        private AmountType lineExtensionAmountField;

        private DateType taxPointDateField;

        private CodeType accountingCostCodeField;

        private TextType accountingCostField;

        private ResponseType[] discrepancyResponseField;

        private LineReferenceType[] despatchLineReferenceField;

        private LineReferenceType[] receiptLineReferenceField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private PricingReferenceType pricingReferenceField;

        private DeliveryType[] deliveryField;

        private TaxTotalType[] taxTotalField;

        private ItemType itemField;

        private PriceType priceField;

        /// <summary>
        ///  Identifies the Credit Note Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Credit Note Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  The quantity of Items credited.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType CreditedQuantity
        {
            get
            {
                return this.creditedQuantityField;
            }
            set
            {
                this.creditedQuantityField = value;
            }
        }

        /// <summary>
        ///  The total amount for the Credit Note Line, including Allowance Charges but net of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
            }
        }

        /// <summary>
        ///  The date of the Credit Note Line, used to indicate the point at which tax becomes applicable.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting code applied to the Credit Note Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting cost centre applied to the Credit Note Line, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  An association to Discrepancy Response; the reason for the Credit.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse")]
        public ResponseType[] DiscrepancyResponse
        {
            get
            {
                return this.discrepancyResponseField;
            }
            set
            {
                this.discrepancyResponseField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Despatch Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return this.despatchLineReferenceField;
            }
            set
            {
                this.despatchLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Receipt Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference")]
        public LineReferenceType[] ReceiptLineReference
        {
            get
            {
                return this.receiptLineReferenceField;
            }
            set
            {
                this.receiptLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Billing Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
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
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Pricing Reference.
        /// </summary>
        public PricingReferenceType PricingReference
        {
            get
            {
                return this.pricingReferenceField;
            }
            set
            {
                this.pricingReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Delivery")]
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
        ///  An association to Tax Total.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
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
        ///  An association to Item
        /// </summary>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        ///  An association to Price.
        /// </summary>
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }

    /// <summary>
    ///  Information about responses to a document (at the application level).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ResponseType
    {

        private IdentifierType referenceIDField;

        private CodeType responseCodeField;

        private TextType[] descriptionField;

        /// <summary>
        ///  Identifies the section (or line) of the document to which the response applies.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ReferenceID
        {
            get
            {
                return this.referenceIDField;
            }
            set
            {
                this.referenceIDField = value;
            }
        }

        /// <summary>
        ///  A code for the description of the response to the transaction document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ResponseCode
        {
            get
            {
                return this.responseCodeField;
            }
            set
            {
                this.responseCodeField = value;
            }
        }

        /// <summary>
        ///  The description of the response to the transaction document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <summary>
    ///  The information relevant to a condition or a position of an object.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class StatusType
    {

        private TransportationStatusCodeType conditionCodeField;

        private DateType referenceDateField;

        private TimeType referenceTimeField;

        private TextType descriptionField;

        private CodeType statusReasonCodeField;

        private TextType statusReasonField;

        private IdentifierType sequenceIDField;

        private TextType textField;

        private IndicatorType indicationIndicatorField;

        private PercentType percentField;

        /// <summary>
        ///  A code specifying the status condition of the related object.
        ///  Example: UN/ECE Rec 24
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportationStatusCodeType ConditionCode
        {
            get
            {
                return this.conditionCodeField;
            }
            set
            {
                this.conditionCodeField = value;
            }
        }

        /// <summary>
        ///  A reference date value for this status.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ReferenceDate
        {
            get
            {
                return this.referenceDateField;
            }
            set
            {
                this.referenceDateField = value;
            }
        }

        /// <summary>
        ///  A reference time value for this status.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType ReferenceTime
        {
            get
            {
                return this.referenceTimeField;
            }
            set
            {
                this.referenceTimeField = value;
            }
        }

        /// <summary>
        ///  A textual description of this status.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  A code specifying a reason for a status condition.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType StatusReasonCode
        {
            get
            {
                return this.statusReasonCodeField;
            }
            set
            {
                this.statusReasonCodeField = value;
            }
        }

        /// <summary>
        ///  The reason, expressed as text, for this status condition or position.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType StatusReason
        {
            get
            {
                return this.statusReasonField;
            }
            set
            {
                this.statusReasonField = value;
            }
        }

        /// <summary>
        ///  A unique identifier of the sequence of this status.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SequenceID
        {
            get
            {
                return this.sequenceIDField;
            }
            set
            {
                this.sequenceIDField = value;
            }
        }

        /// <summary>
        ///  Provides any textual information related to this status.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <summary>
        ///  Specifies an indicator relevant to a specific status.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType IndicationIndicator
        {
            get
            {
                return this.indicationIndicatorField;
            }
            set
            {
                this.indicationIndicatorField = value;
            }
        }

        /// <summary>
        ///  Specifies a percentage relevant to a specific status.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Debit Note Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DebitNoteLineType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private TextType noteField;

        private QuantityType debitedQuantityField;

        private AmountType lineExtensionAmountField;

        private DateType taxPointDateField;

        private CodeType accountingCostCodeField;

        private TextType accountingCostField;

        private ResponseType[] discrepancyResponseField;

        private LineReferenceType[] despatchLineReferenceField;

        private LineReferenceType[] receiptLineReferenceField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private PricingReferenceType pricingReferenceField;

        private DeliveryType[] deliveryField;

        private TaxTotalType[] taxTotalField;

        private ItemType itemField;

        private PriceType priceField;

        /// <summary>
        ///  Identifies the Debit Note Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Debit Note Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  The quantity of Items debited.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType DebitedQuantity
        {
            get
            {
                return this.debitedQuantityField;
            }
            set
            {
                this.debitedQuantityField = value;
            }
        }

        /// <summary>
        ///  The total amount for the Debit Note Line, including Allowance Charges but net of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
            }
        }

        /// <summary>
        ///  The date of the Debit Note Line, used to indicate the point at which tax becomes applicable.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting code applied to the Debit Note Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting cost centre applied to the Debit Note Line, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  An association to Discrepancy Response; the reason for the Debit.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse")]
        public ResponseType[] DiscrepancyResponse
        {
            get
            {
                return this.discrepancyResponseField;
            }
            set
            {
                this.discrepancyResponseField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Despatch Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return this.despatchLineReferenceField;
            }
            set
            {
                this.despatchLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Receipt Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference")]
        public LineReferenceType[] ReceiptLineReference
        {
            get
            {
                return this.receiptLineReferenceField;
            }
            set
            {
                this.receiptLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Billing Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
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
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Pricing Reference.
        /// </summary>
        public PricingReferenceType PricingReference
        {
            get
            {
                return this.pricingReferenceField;
            }
            set
            {
                this.pricingReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Delivery.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Delivery")]
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
        ///  An association to Tax Total.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
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
        ///  An association to Item
        /// </summary>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        ///  An association to Price.
        /// </summary>
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }

    /// <summary>
    ///  Information about responses to a document (at the application level).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DocumentResponseType
    {

        private ResponseType responseField;

        private DocumentReferenceType documentReferenceField;

        private PartyType issuerPartyField;

        private PartyType recipientPartyField;

        private LineResponseType[] lineResponseField;

        /// <summary>
        ///  The response to the document.
        /// </summary>
        public ResponseType Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  The party who issued a document.
        /// </summary>
        public PartyType IssuerParty
        {
            get
            {
                return this.issuerPartyField;
            }
            set
            {
                this.issuerPartyField = value;
            }
        }

        /// <summary>
        ///  The party for whom the document is intended.
        /// </summary>
        public PartyType RecipientParty
        {
            get
            {
                return this.recipientPartyField;
            }
            set
            {
                this.recipientPartyField = value;
            }
        }

        /// <summary>
        ///  Response to various lines in the document.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("LineResponse")]
        public LineResponseType[] LineResponse
        {
            get
            {
                return this.lineResponseField;
            }
            set
            {
                this.lineResponseField = value;
            }
        }
    }

    /// <summary>
    ///  A response to a Line in a Document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LineResponseType
    {

        private LineReferenceType lineReferenceField;

        private ResponseType[] responseField;

        /// <summary>
        ///  An association to Line Reference.
        /// </summary>
        public LineReferenceType LineReference
        {
            get
            {
                return this.lineReferenceField;
            }
            set
            {
                this.lineReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Response.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Response")]
        public ResponseType[] Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }
    }

    /// <summary>
    ///  Details of an endorsement on the document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EndorsementType
    {

        private IdentifierType documentIDField;

        private TextType approvalStatusField;

        private TextType[] remarksField;

        private EndorserPartyType endorserPartyField;

        private SignatureType[] signatureField;

        /// <summary>
        ///  Identifies the endorsement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType DocumentID
        {
            get
            {
                return this.documentIDField;
            }
            set
            {
                this.documentIDField = value;
            }
        }

        /// <summary>
        ///  Specifies the status of the endorsement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType ApprovalStatus
        {
            get
            {
                return this.approvalStatusField;
            }
            set
            {
                this.approvalStatusField = value;
            }
        }

        /// <summary>
        ///  Remarks by the endorsing party.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <summary>
        ///  The type of party providing the endorsement.
        /// </summary>
        public EndorserPartyType EndorserParty
        {
            get
            {
                return this.endorserPartyField;
            }
            set
            {
                this.endorserPartyField = value;
            }
        }

        /// <summary>
        ///  One or more signatures applied to the endorsement.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature")]
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
    }

    /// <summary>
    ///  Information about Exchange Rate.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ExchangeRateType
    {

        private CurrencyCodeType sourceCurrencyCodeField;

        private RateType sourceCurrencyBaseRateField;

        private CurrencyCodeType targetCurrencyCodeField;

        private RateType targetCurrencyBaseRateField;

        private IdentifierType exchangeMarketIDField;

        private RateType calculationRateField;

        private OperatorCodeType mathematicOperatorCodeField;

        private DateType dateField;

        private ContractType foreignExchangeContractField;

        /// <summary>
        ///  The reference currency for the Exchange Rate; the currency from which the exchange is being made (CC Definition).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType SourceCurrencyCode
        {
            get
            {
                return this.sourceCurrencyCodeField;
            }
            set
            {
                this.sourceCurrencyCodeField = value;
            }
        }

        /// <summary>
        ///  The unit base of the source currency for currencies with small denominations.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RateType SourceCurrencyBaseRate
        {
            get
            {
                return this.sourceCurrencyBaseRateField;
            }
            set
            {
                this.sourceCurrencyBaseRateField = value;
            }
        }

        /// <summary>
        ///  The target currency for the Exchange Rate; the currency to which the exchange is being made (CC Definition).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType TargetCurrencyCode
        {
            get
            {
                return this.targetCurrencyCodeField;
            }
            set
            {
                this.targetCurrencyCodeField = value;
            }
        }

        /// <summary>
        ///  The unit base of the target currency for currencies with small denominations.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RateType TargetCurrencyBaseRate
        {
            get
            {
                return this.targetCurrencyBaseRateField;
            }
            set
            {
                this.targetCurrencyBaseRateField = value;
            }
        }

        /// <summary>
        ///  Identifies the currency exchange market used as the source of the Exchange Rate.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ExchangeMarketID
        {
            get
            {
                return this.exchangeMarketIDField;
            }
            set
            {
                this.exchangeMarketIDField = value;
            }
        }

        /// <summary>
        ///  The factor applied to the source currency to calculate the target currency.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RateType CalculationRate
        {
            get
            {
                return this.calculationRateField;
            }
            set
            {
                this.calculationRateField = value;
            }
        }

        /// <summary>
        ///  An identifier for whether the Calculation Rate should be used to multiply or to divide, expressed as a code.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OperatorCodeType MathematicOperatorCode
        {
            get
            {
                return this.mathematicOperatorCodeField;
            }
            set
            {
                this.mathematicOperatorCodeField = value;
            }
        }

        /// <summary>
        ///  The date of the Exchange.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <summary>
        ///  An association to Foreign Exchange Contract.
        /// </summary>
        public ContractType ForeignExchangeContract
        {
            get
            {
                return this.foreignExchangeContractField;
            }
            set
            {
                this.foreignExchangeContractField = value;
            }
        }
    }

    /// <summary>
    ///  Information about an Order Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderLineType
    {

        private SubstitutionStatusCodeType substitutionStatusCodeField;

        private TextType noteField;

        private LineItemType lineItemField;

        private LineItemType[] sellerProposedSubstituteLineItemField;

        private LineItemType[] sellerSubstitutedLineItemField;

        private LineItemType[] buyerProposedSubstituteLineItemField;

        private LineReferenceType catalogueLineReferenceField;

        private LineReferenceType quotationLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        /// <summary>
        ///  A code indicating the substitution status of the Order Line. Order Line may indicate that a substitute is proposed by the buyer or by the seller (in Order Response) or that a substitution has been made by the seller (in Order Response).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubstitutionStatusCodeType SubstitutionStatusCode
        {
            get
            {
                return this.substitutionStatusCodeField;
            }
            set
            {
                this.substitutionStatusCodeField = value;
            }
        }

        /// <summary>
        ///  Free-form text applying to the Order Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  An association to Line Item.
        /// </summary>
        public LineItemType LineItem
        {
            get
            {
                return this.lineItemField;
            }
            set
            {
                this.lineItemField = value;
            }
        }

        /// <summary>
        ///  Substitute Line Items proposed by the seller (in Order Response).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem")]
        public LineItemType[] SellerProposedSubstituteLineItem
        {
            get
            {
                return this.sellerProposedSubstituteLineItemField;
            }
            set
            {
                this.sellerProposedSubstituteLineItemField = value;
            }
        }

        /// <summary>
        ///  Item(s) replaced by the seller.  The original ordered quantity and pricing may be different from the substituted item. However, when an item is substituted by the seller, it is assumed that other information, such as shipment details, will be the same.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SellerSubstitutedLineItem")]
        public LineItemType[] SellerSubstitutedLineItem
        {
            get
            {
                return this.sellerSubstitutedLineItemField;
            }
            set
            {
                this.sellerSubstitutedLineItemField = value;
            }
        }

        /// <summary>
        ///  Possible alternatives, proposed by the buyer, to the Line Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BuyerProposedSubstituteLineItem")]
        public LineItemType[] BuyerProposedSubstituteLineItem
        {
            get
            {
                return this.buyerProposedSubstituteLineItemField;
            }
            set
            {
                this.buyerProposedSubstituteLineItemField = value;
            }
        }

        /// <summary>
        ///  An associative reference to Catalogue Line.
        /// </summary>
        public LineReferenceType CatalogueLineReference
        {
            get
            {
                return this.catalogueLineReferenceField;
            }
            set
            {
                this.catalogueLineReferenceField = value;
            }
        }

        /// <summary>
        ///  an associative reference to Quotation Line.
        /// </summary>
        public LineReferenceType QuotationLineReference
        {
            get
            {
                return this.quotationLineReferenceField;
            }
            set
            {
                this.quotationLineReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }
    }

    /// <summary>
    ///  Information directly relating to a specific payment.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PaymentType
    {

        private IdentifierType idField;

        private AmountType paidAmountField;

        private DateType receivedDateField;

        private DateType paidDateField;

        private TimeType paidTimeField;

        private IdentifierType instructionIDField;

        /// <summary>
        ///  Identifies the payment.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The amount paid.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType PaidAmount
        {
            get
            {
                return this.paidAmountField;
            }
            set
            {
                this.paidAmountField = value;
            }
        }

        /// <summary>
        ///  The date on which the payment was received.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ReceivedDate
        {
            get
            {
                return this.receivedDateField;
            }
            set
            {
                this.receivedDateField = value;
            }
        }

        /// <summary>
        ///  The date at which the payment was made.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType PaidDate
        {
            get
            {
                return this.paidDateField;
            }
            set
            {
                this.paidDateField = value;
            }
        }

        /// <summary>
        ///  The time at which the payment was made.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType PaidTime
        {
            get
            {
                return this.paidTimeField;
            }
            set
            {
                this.paidTimeField = value;
            }
        }

        /// <summary>
        ///  Identifies the Payment Instruction.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType InstructionID
        {
            get
            {
                return this.instructionIDField;
            }
            set
            {
                this.instructionIDField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Quotation Line.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class QuotationLineType
    {

        private IdentifierType idField;

        private TextType noteField;

        private QuantityType quantityField;

        private AmountType lineExtensionAmountField;

        private AmountType totalTaxAmountField;

        private DocumentReferenceType[] documentReferenceField;

        private LineItemType lineItemField;

        private LineItemType[] sellerProposedSubstituteLineItemField;

        /// <summary>
        ///  Identifies the Quotation Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Quotation Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  The quantity of the item quoted.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <summary>
        ///  The total amount for the Quotation Line, including Allowance Charges but net of taxes.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
            }
        }

        /// <summary>
        ///  The total tax amount for the Quotation Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TotalTaxAmount
        {
            get
            {
                return this.totalTaxAmountField;
            }
            set
            {
                this.totalTaxAmountField = value;
            }
        }

        /// <summary>
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Line Item.
        /// </summary>
        public LineItemType LineItem
        {
            get
            {
                return this.lineItemField;
            }
            set
            {
                this.lineItemField = value;
            }
        }

        /// <summary>
        ///  An association to a proposed substitute Line Item.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem")]
        public LineItemType[] SellerProposedSubstituteLineItem
        {
            get
            {
                return this.sellerProposedSubstituteLineItemField;
            }
            set
            {
                this.sellerProposedSubstituteLineItemField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Line on a Reminder document.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ReminderLineType
    {

        private IdentifierType idField;

        private TextType noteField;

        private IdentifierType uUIDField;

        private IndicatorType balanceBroughtForwardIndicatorField;

        private AmountType debitLineAmountField;

        private AmountType creditLineAmountField;

        private CodeType accountingCostCodeField;

        private TextType accountingCostField;

        private PeriodType[] reminderPeriodField;

        private BillingReferenceType[] billingReferenceField;

        private ExchangeRateType exchangeRateField;

        /// <summary>
        ///  Identifies the Reminder Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Reminder Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  If true, indicates that the Remonder Line contains a balance brought forward.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType BalanceBroughtForwardIndicator
        {
            get
            {
                return this.balanceBroughtForwardIndicatorField;
            }
            set
            {
                this.balanceBroughtForwardIndicatorField = value;
            }
        }

        /// <summary>
        ///  The amount debited on the Reminder Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DebitLineAmount
        {
            get
            {
                return this.debitLineAmountField;
            }
            set
            {
                this.debitLineAmountField = value;
            }
        }

        /// <summary>
        ///  The amount credited on the Reminder Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType CreditLineAmount
        {
            get
            {
                return this.creditLineAmountField;
            }
            set
            {
                this.creditLineAmountField = value;
            }
        }

        /// <summary>
        ///  The buyer's accounting code applied to the Reminder Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The buyer's accounting cost centre applied to the Reminder Line, expressed as text.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  An association to Period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReminderPeriod")]
        public PeriodType[] ReminderPeriod
        {
            get
            {
                return this.reminderPeriodField;
            }
            set
            {
                this.reminderPeriodField = value;
            }
        }

        /// <summary>
        ///  An association to Billing Reference
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
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
        ///  An association to Exchange Rate (between the Reminder Line Currency and the Related Document currency).
        /// </summary>
        public ExchangeRateType ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Line on a Remittance Advice.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RemittanceAdviceLineType
    {

        private IdentifierType idField;

        private TextType noteField;

        private IdentifierType uUIDField;

        private AmountType debitLineAmountField;

        private AmountType creditLineAmountField;

        private AmountType balanceAmountField;

        private SupplierPartyType accountingSupplierPartyField;

        private CustomerPartyType accountingCustomerPartyField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private CustomerPartyType originatorCustomerPartyField;

        private PartyType payeePartyField;

        private PeriodType[] invoicePeriodField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ExchangeRateType exchangeRateField;

        /// <summary>
        ///  Identifies the Remittance Advice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Remittance Advice Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  The amount debited on the Remittance Advice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DebitLineAmount
        {
            get
            {
                return this.debitLineAmountField;
            }
            set
            {
                this.debitLineAmountField = value;
            }
        }

        /// <summary>
        ///  The amount credited on the Remittance Advice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType CreditLineAmount
        {
            get
            {
                return this.creditLineAmountField;
            }
            set
            {
                this.creditLineAmountField = value;
            }
        }

        /// <summary>
        ///  The balance amount on the Remittance Advice Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType BalanceAmount
        {
            get
            {
                return this.balanceAmountField;
            }
            set
            {
                this.balanceAmountField = value;
            }
        }

        /// <summary>
        ///  An association to Supplier Accounting Party.
        /// </summary>
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
        ///  An association to Customer Accounting Party.
        /// </summary>
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
        ///  An association to Buyer.
        /// </summary>
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
        ///  An association to Seller.
        /// </summary>
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
        ///  An association to Originator.
        /// </summary>
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                return this.originatorCustomerPartyField;
            }
            set
            {
                this.originatorCustomerPartyField = value;
            }
        }

        /// <summary>
        ///  An association to Payee.
        /// </summary>
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
        ///  An association to Invoice Period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod")]
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
        ///  An association to Billing Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
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
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Exchange Rate (between the Remittance Advice Line currency and the Related Document currency).
        /// </summary>
        public ExchangeRateType ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Line on a Request For Quotation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RequestForQuotationLineType
    {

        private IdentifierType idField;

        private IdentifierType uUIDField;

        private TextType noteField;

        private DocumentReferenceType[] documentReferenceField;

        private LineItemType lineItemField;

        /// <summary>
        ///  Identifies the Request For Quotation Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Request For Quotation Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Line Item.
        /// </summary>
        public LineItemType LineItem
        {
            get
            {
                return this.lineItemField;
            }
            set
            {
                this.lineItemField = value;
            }
        }
    }

    /// <summary>
    ///  Information about a Line on a Statement of Account.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class StatementLineType
    {

        private IdentifierType idField;

        private TextType noteField;

        private IdentifierType uUIDField;

        private IndicatorType balanceBroughtForwardIndicatorField;

        private AmountType debitLineAmountField;

        private AmountType creditLineAmountField;

        private AmountType balanceAmountField;

        private PaymentMeansType paymentMeansField;

        private PaymentTermsType[] paymentTermsField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private CustomerPartyType originatorCustomerPartyField;

        private CustomerPartyType accountingCustomerPartyField;

        private SupplierPartyType accountingSupplierPartyField;

        private PartyType payeePartyField;

        private PeriodType[] invoicePeriodField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ExchangeRateType exchangeRateField;

        /// <summary>
        ///  Identifies the Statement Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  Free-form text applying to the Statement Line. This element may contain notes or any other similar information that is not contained explicitly in another structure.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Note
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
        ///  A universally unique identifier for an instance of this ABIE.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        ///  If true, indicates that the Statement Line contains a balance brought forward.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType BalanceBroughtForwardIndicator
        {
            get
            {
                return this.balanceBroughtForwardIndicatorField;
            }
            set
            {
                this.balanceBroughtForwardIndicatorField = value;
            }
        }

        /// <summary>
        ///  The amount debited on the Statement Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType DebitLineAmount
        {
            get
            {
                return this.debitLineAmountField;
            }
            set
            {
                this.debitLineAmountField = value;
            }
        }

        /// <summary>
        ///  The amount credited on the Statement Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType CreditLineAmount
        {
            get
            {
                return this.creditLineAmountField;
            }
            set
            {
                this.creditLineAmountField = value;
            }
        }

        /// <summary>
        ///  The balance amount on the Statement Line.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType BalanceAmount
        {
            get
            {
                return this.balanceAmountField;
            }
            set
            {
                this.balanceAmountField = value;
            }
        }

        /// <summary>
        ///  An association to Payment Means.
        /// </summary>
        public PaymentMeansType PaymentMeans
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
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
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
        ///  An association to Buyer.
        /// </summary>
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
        ///  An association to Seller.
        /// </summary>
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
        ///  An association to Originator.
        /// </summary>
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                return this.originatorCustomerPartyField;
            }
            set
            {
                this.originatorCustomerPartyField = value;
            }
        }

        /// <summary>
        ///  An association to Accounting Customer Party.
        /// </summary>
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
        ///  An association to Accounting Supplier Party.
        /// </summary>
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
        ///  An association to Payee.
        /// </summary>
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
        ///  An association to Invoice Period.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod")]
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
        ///  An association to Billing Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
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
        ///  An association to Document Reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <summary>
        ///  An association to Exchange Rate (between the Statement Line currency and the Related Document Currency).
        /// </summary>
        public ExchangeRateType ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }
    }

    /// <summary>
    ///  Information about the terms of a trade agreement.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TradingTermsType
    {

        private TextType[] informationField;

        private TextType referenceField;

        private AddressType applicableAddressField;

        /// <summary>
        ///  The terms in text.
        ///  Example: "Unless credit terms have been expressly agreed by Dell, payment for the products or services shall be made in full before physical delivery of products or services. Customer shall pay for all shipping and handling charges."
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
            }
        }

        /// <summary>
        ///  A reference to the terms.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <summary>
        ///  An association to the address at which the trading terms apply.
        /// </summary>
        public AddressType ApplicableAddress
        {
            get
            {
                return this.applicableAddressField;
            }
            set
            {
                this.applicableAddressField = value;
            }
        }
    }

    /// <summary>
    ///  A significant occurrence or happening related to the transportation of goods.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportEventType
    {

        private IdentifierType identificationIDField;

        private DateType occurrenceDateField;

        private TimeType occurrenceTimeField;

        private CodeType transportEventTypeCodeField;

        private TextType descriptionField;

        private IndicatorType completionIndicatorField;

        private ShipmentType reportedShipmentField;

        private StatusType[] currentStatusField;

        private ContactType[] contactField;

        /// <summary>
        ///  An identifier for the event.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
            }
        }

        /// <summary>
        ///  The date of an occurrence of the event.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType OccurrenceDate
        {
            get
            {
                return this.occurrenceDateField;
            }
            set
            {
                this.occurrenceDateField = value;
            }
        }

        /// <summary>
        ///  The time of an occurrence of the event.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType OccurrenceTime
        {
            get
            {
                return this.occurrenceTimeField;
            }
            set
            {
                this.occurrenceTimeField = value;
            }
        }

        /// <summary>
        ///  A code specifying the type of event.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TransportEventTypeCode
        {
            get
            {
                return this.transportEventTypeCodeField;
            }
            set
            {
                this.transportEventTypeCodeField = value;
            }
        }

        /// <summary>
        ///  A textual description of the event.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        ///  Indicates if this event is completed.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CompletionIndicator
        {
            get
            {
                return this.completionIndicatorField;
            }
            set
            {
                this.completionIndicatorField = value;
            }
        }

        /// <summary>
        ///  Information about the separately identifiable collection of goods items (available to be) transported from one consignor to one consignee via one or more modes of transport.
        /// </summary>
        public ShipmentType ReportedShipment
        {
            get
            {
                return this.reportedShipmentField;
            }
            set
            {
                this.reportedShipmentField = value;
            }
        }

        /// <summary>
        ///  The status of the event.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CurrentStatus")]
        public StatusType[] CurrentStatus
        {
            get
            {
                return this.currentStatusField;
            }
            set
            {
                this.currentStatusField = value;
            }
        }

        /// <summary>
        ///  Any contacts for the event.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public ContactType[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
    }
}
