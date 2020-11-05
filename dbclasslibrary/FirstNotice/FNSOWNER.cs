﻿// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from FNSOWNER on 2010-07-24 09:05:36Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace DbClassLibrary.FirstNotice
{
  using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	using Oracle.DataAccess.Client;

#pragma warning disable 1591

// ReSharper disable InconsistentNaming
    public partial class FNSOWNER : DataContext

	{

		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion


		public FNSOWNER(string connectionString) :
			base(new OracleConnection(connectionString), new DbLinq.Oracle.OracleVendor())
		{
			this.OnCreated();
		}

		public FNSOWNER(string connection, MappingSource mappingSource) :
			base(connection, mappingSource)
		{
			this.OnCreated();
		}

		public FNSOWNER(IDbConnection connection, MappingSource mappingSource) :
			base(connection, mappingSource)
		{
			this.OnCreated();
		}

		public Table<Accesspermissions> Accesspermissions
		{
			get
			{
				return this.GetTable<Accesspermissions>();
			}
		}

		public Table<Accesstype> Accesstype
		{
			get
			{
				return this.GetTable<Accesstype>();
			}
		}

		public Table<AccountCallflow> Accountcallflow
		{
			get
			{
				return this.GetTable<AccountCallflow>();
			}
		}

        public Table<PerfData> Perfdata
        {
            get
            {
                return this.GetTable<PerfData>();
            }
        }
		public Table<AccountHierarchyStep> Accounthierarchystep
		{
			get
			{
				return this.GetTable<AccountHierarchyStep>();
			}
		}

		public Table<AccountUser> Accountuser
		{
			get
			{
				return this.GetTable<AccountUser>();
			}
		}

		public Table<AccountVendor> Accountvendor
		{
			get
			{
				return this.GetTable<AccountVendor>();
			}
		}

		public Table<Acknowledgement> Acknowledgement
		{
			get
			{
				return this.GetTable<Acknowledgement>();
			}
		}

		public Table<ActiveDestination> Activedestination
		{
			get
			{
				return this.GetTable<ActiveDestination>();
			}
		}

		public Table<AddressBookEntry> Addressbookentry
		{
			get
			{
				return this.GetTable<AddressBookEntry>();
			}
		}

		public Table<Adjuster> Adjuster
		{
			get
			{
				return this.GetTable<Adjuster>();
			}
		}

		public Table<Agent> Agent
		{
			get
			{
				return this.GetTable<Agent>();
			}
		}

		public Table<AhsAud> Ahsaud
		{
			get
			{
				return this.GetTable<AhsAud>();
			}
		}

		public Table<AhsContact> Ahscontact
		{
			get
			{
				return this.GetTable<AhsContact>();
			}
		}

		public Table<AhsCoverageCisg> Ahscoveragecisg
		{
			get
			{
				return this.GetTable<AhsCoverageCisg>();
			}
		}

		public Table<AhsearchPolicyView> Ahsearchpolicyview
		{
			get
			{
				return this.GetTable<AhsearchPolicyView>();
			}
		}

		public Table<AhsException> Ahsexception
		{
			get
			{
				return this.GetTable<AhsException>();
			}
		}

		public Table<AhsExtension> Ahsextension
		{
			get
			{
				return this.GetTable<AhsExtension>();
			}
		}

		public Table<AhsOwner> Ahsowner
		{
			get
			{
				return this.GetTable<AhsOwner>();
			}
		}

		public Table<AhsPolicy> Ahspolicy
		{
			get
			{
				return this.GetTable<AhsPolicy>();
			}
		}

		public Table<AhsValidRules> Ahsvalidrules
		{
			get
			{
				return this.GetTable<AhsValidRules>();
			}
		}

		public Table<AlternateContactName> Alternatecontactname
		{
			get
			{
				return this.GetTable<AlternateContactName>();
			}
		}

		public Table<AlternateDestination> Alternatedestination
		{
			get
			{
				return this.GetTable<AlternateDestination>();
			}
		}

		public Table<AlternateName> Alternatename
		{
			get
			{
				return this.GetTable<AlternateName>();
			}
		}

		public Table<AlternateOwnerName> Alternateownername
		{
			get
			{
				return this.GetTable<AlternateOwnerName>();
			}
		}

		public Table<ApplicationLog> Applicationlog
		{
			get
			{
				return this.GetTable<ApplicationLog>();
			}
		}

		public Table<Attribute> Attribute
		{
			get
			{
				return this.GetTable<Attribute>();
			}
		}

		public Table<AttributeLuView> Attributeluview
		{
			get
			{
				return this.GetTable<AttributeLuView>();
			}
		}

		public Table<AttributeOverride> Attributeoverride
		{
			get
			{
				return this.GetTable<AttributeOverride>();
			}
		}

		public Table<AttributeOverrideView> Attributeoverrideview
		{
			get
			{
				return this.GetTable<AttributeOverrideView>();
			}
		}

		public Table<AttributeView> Attributeview
		{
			get
			{
				return this.GetTable<AttributeView>();
			}
		}

		public Table<AttrInstance> Attrinstance
		{
			get
			{
				return this.GetTable<AttrInstance>();
			}
		}

		public Table<Branch> Branch
		{
			get
			{
				return this.GetTable<Branch>();
			}
		}

		public Table<BranchassignmentRule> Branchassignmentrule
		{
			get
			{
				return this.GetTable<BranchassignmentRule>();
			}
		}

		public Table<Branchassignmenttype> Branchassignmenttype
		{
			get
			{
				return this.GetTable<Branchassignmenttype>();
			}
		}

		public Table<Calendar> Calendar
		{
			get
			{
				return this.GetTable<Calendar>();
			}
		}

		public Table<Call> Call
		{
			get
			{
				return this.GetTable<Call>();
			}
		}

		public Table<Callflow> Callflow
		{
			get
			{
				return this.GetTable<Callflow>();
			}
		}

		public Table<CallflowView> Callflowview
		{
			get
			{
				return this.GetTable<CallflowView>();
			}
		}

		public Table<CallRouting> Callrouting
		{
			get
			{
				return this.GetTable<CallRouting>();
			}
		}

		public Table<CallXml> Callxml
		{
			get
			{
				return this.GetTable<CallXml>();
			}
		}

		public Table<Carrier> Carrier
		{
			get
			{
				return this.GetTable<Carrier>();
			}
		}

		public Table<ClaimClassAssignment> Claimclassassignment
		{
			get
			{
				return this.GetTable<ClaimClassAssignment>();
			}
		}

		public Table<ClaimKocAssignment> Claimkocassignment
		{
			get
			{
				return this.GetTable<ClaimKocAssignment>();
			}
		}

		public Table<ClaimnumberassignmentRule> Claimnumberassignmentrule
		{
			get
			{
				return this.GetTable<ClaimnumberassignmentRule>();
			}
		}

		public Table<Claimnumberreuse> Claimnumberreuse
		{
			get
			{
				return this.GetTable<Claimnumberreuse>();
			}
		}

		public Table<ClaimSubmissionLog> Claimsubmissionlog
		{
			get
			{
				return this.GetTable<ClaimSubmissionLog>();
			}
		}

		public Table<ConfigSettings> Configsettings
		{
			get
			{
				return this.GetTable<ConfigSettings>();
			}
		}

		public Table<Contact> Contact
		{
			get
			{
				return this.GetTable<Contact>();
			}
		}

		public Table<ContactMethod> Contactmethod
		{
			get
			{
				return this.GetTable<ContactMethod>();
			}
		}

		public Table<ContactPerson> Contactperson
		{
			get
			{
				return this.GetTable<ContactPerson>();
			}
		}

		public Table<Coverage> Coverage
		{
			get
			{
				return this.GetTable<Coverage>();
			}
		}

		public Table<CoverageTypeCisg> Coveragetypecisg
		{
			get
			{
				return this.GetTable<CoverageTypeCisg>();
			}
		}

		public Table<CsaLastBranch> Csalastbranch
		{
			get
			{
				return this.GetTable<CsaLastBranch>();
			}
		}

		public Table<Dbconnection> Dbconnection
		{
			get
			{
				return this.GetTable<Dbconnection>();
			}
		}

		public Table<DbId> Dbid
		{
			get
			{
				return this.GetTable<DbId>();
			}
		}

		public Table<DedicatedWebservers> Dedicatedwebservers
		{
			get
			{
				return this.GetTable<DedicatedWebservers>();
			}
		}

		public Table<DepartmentCodes> Departmentcodes
		{
			get
			{
				return this.GetTable<DepartmentCodes>();
			}
		}

		public Table<DestinationProperty> Destinationproperty
		{
			get
			{
				return this.GetTable<DestinationProperty>();
			}
		}

		public Table<DiaryRules> Diaryrules
		{
			get
			{
				return this.GetTable<DiaryRules>();
			}
		}

		public Table<DistributionSuppression> Distributionsuppression
		{
			get
			{
				return this.GetTable<DistributionSuppression>();
			}
		}

		public Table<Driver> Driver
		{
			get
			{
				return this.GetTable<Driver>();
			}
		}

		public Table<EdiOutboundField> Edioutboundfield
		{
			get
			{
				return this.GetTable<EdiOutboundField>();
			}
		}

		public Table<EdiOutboundFile> Edioutboundfile
		{
			get
			{
				return this.GetTable<EdiOutboundFile>();
			}
		}

		public Table<EdiOutboundItem> Edioutbounditem
		{
			get
			{
				return this.GetTable<EdiOutboundItem>();
			}
		}

		public Table<EdiOutboundMapping> Edioutboundmapping
		{
			get
			{
				return this.GetTable<EdiOutboundMapping>();
			}
		}

		public Table<EdiOutboundSegment> Edioutboundsegment
		{
			get
			{
				return this.GetTable<EdiOutboundSegment>();
			}
		}

		public Table<EdiOutboundTopSegments> Edioutboundtopsegments
		{
			get
			{
				return this.GetTable<EdiOutboundTopSegments>();
			}
		}

		public Table<EmailDistribution> Emaildistribution
		{
			get
			{
				return this.GetTable<EmailDistribution>();
			}
		}

		public Table<Employee> Employee
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}

		public Table<EmployeeEligibility> Employeeeligibility
		{
			get
			{
				return this.GetTable<EmployeeEligibility>();
			}
		}

		public Table<EmployeeExt> EmployeeExtension
		{
			get
			{
				return this.GetTable<EmployeeExt>();
			}
		}

		public Table<EncryptAttribute> Encryptattribute
		{
			get
			{
				return this.GetTable<EncryptAttribute>();
			}
		}

		public Table<Enrollment> Enrollment
		{
			get
			{
				return this.GetTable<Enrollment>();
			}
		}

		public Table<EnrollmentStatusCodes> Enrollmentstatuscodes
		{
			get
			{
				return this.GetTable<EnrollmentStatusCodes>();
			}
		}

		public Table<EscalationOutcome> Escalationoutcome
		{
			get
			{
				return this.GetTable<EscalationOutcome>();
			}
		}

		public Table<EscalationOutcomeStep> Escalationoutcomestep
		{
			get
			{
				return this.GetTable<EscalationOutcomeStep>();
			}
		}

		public Table<EscalationPlan> Escalationplan
		{
			get
			{
				return this.GetTable<EscalationPlan>();
			}
		}

		public Table<EscalationSeqStep> Escalationseqstep
		{
			get
			{
				return this.GetTable<EscalationSeqStep>();
			}
		}

		public Table<EsisSeverityCodeTrigger> Esisseveritycodetrigger
		{
			get
			{
				return this.GetTable<EsisSeverityCodeTrigger>();
			}
		}

		public Table<FaxFileImport> Faxfileimport
		{
			get
			{
				return this.GetTable<FaxFileImport>();
			}
		}

		public Table<FaxFileImportAssignment> Faxfileimportassignment
		{
			get
			{
				return this.GetTable<FaxFileImportAssignment>();
			}
		}

		public Table<FaxFileImportDef> Faxfileimportdef
		{
			get
			{
				return this.GetTable<FaxFileImportDef>();
			}
		}

		public Table<FaxFileImportLog> Faxfileimportlog
		{
			get
			{
				return this.GetTable<FaxFileImportLog>();
			}
		}

		public Table<FileOutputDef> Fileoutputdef
		{
			get
			{
				return this.GetTable<FileOutputDef>();
			}
		}

		public Table<FileTransmissionDef> Filetransmissiondef
		{
			get
			{
				return this.GetTable<FileTransmissionDef>();
			}
		}

		public Table<FileTransmissionError> Filetransmissionerror
		{
			get
			{
				return this.GetTable<FileTransmissionError>();
			}
		}

		public Table<FileTransmissionLog> Filetransmissionlog
		{
			get
			{
				return this.GetTable<FileTransmissionLog>();
			}
		}

		public Table<Frame> Frame
		{
			get
			{
				return this.GetTable<Frame>();
			}
		}

		public Table<FrameOrder> Frameorder
		{
			get
			{
				return this.GetTable<FrameOrder>();
			}
		}

		public Table<FraudDetectionRule> Frauddetectionrule
		{
			get
			{
				return this.GetTable<FraudDetectionRule>();
			}
		}

		public Table<FraudDetectionType> Frauddetectiontype
		{
			get
			{
				return this.GetTable<FraudDetectionType>();
			}
		}

		public Table<FroiFileDef> Froifiledef
		{
			get
			{
				return this.GetTable<FroiFileDef>();
			}
		}

		public Table<FroiFileInbound> Froifileinbound
		{
			get
			{
				return this.GetTable<FroiFileInbound>();
			}
		}

		public Table<FroiFileInboundStep> Froifileinboundstep
		{
			get
			{
				return this.GetTable<FroiFileInboundStep>();
			}
		}

		public Table<FroiImpConversion> Froiimpconversion
		{
			get
			{
				return this.GetTable<FroiImpConversion>();
			}
		}

		public Table<FroiImpConvType> Froiimpconvtype
		{
			get
			{
				return this.GetTable<FroiImpConvType>();
			}
		}

		public Table<FroiImpFunction> Froiimpfunction
		{
			get
			{
				return this.GetTable<FroiImpFunction>();
			}
		}

		public Table<FroiImpMap> Froiimpmap
		{
			get
			{
				return this.GetTable<FroiImpMap>();
			}
		}

		public Table<FroiImpMapConversion> Froiimpmapconversion
		{
			get
			{
				return this.GetTable<FroiImpMapConversion>();
			}
		}

		public Table<FroiImpMapFunction> Froiimpmapfunction
		{
			get
			{
				return this.GetTable<FroiImpMapFunction>();
			}
		}

		public Table<FroiImpRecord> Froiimprecord
		{
			get
			{
				return this.GetTable<FroiImpRecord>();
			}
		}

		public Table<Function> Function
		{
			get
			{
				return this.GetTable<Function>();
			}
		}

		public Table<Groups> Groups
		{
			get
			{
				return this.GetTable<Groups>();
			}
		}

		public Table<HelpType> Helptype
		{
			get
			{
				return this.GetTable<HelpType>();
			}
		}

		public Table<Inboundcall> Inboundcall
		{
			get
			{
				return this.GetTable<Inboundcall>();
			}
		}

		public Table<InboundXmissionRecord> Inboundxmissionrecord
		{
			get
			{
				return this.GetTable<InboundXmissionRecord>();
			}
		}

		public Table<Inetpolicy> Inetpolicy
		{
			get
			{
				return this.GetTable<Inetpolicy>();
			}
		}

		public Table<InfReasonCodes> Infreasoncodes
		{
			get
			{
				return this.GetTable<InfReasonCodes>();
			}
		}

		public Table<JurisdictionState> Jurisdictionstate
		{
			get
			{
				return this.GetTable<JurisdictionState>();
			}
		}

		public Table<Keyiv> Keyiv
		{
			get
			{
				return this.GetTable<Keyiv>();
			}
		}

		public Table<Lob> Lob
		{
			get
			{
				return this.GetTable<Lob>();
			}
		}

		public Table<LocationCode> Locationcode
		{
			get
			{
				return this.GetTable<LocationCode>();
			}
		}

		public Table<LocationCoverage> Locationcoverage
		{
			get
			{
				return this.GetTable<LocationCoverage>();
			}
		}

		public Table<LocationLien> Locationlien
		{
			get
			{
				return this.GetTable<LocationLien>();
			}
		}

		public Table<LocationsUser> Locationsuser
		{
			get
			{
				return this.GetTable<LocationsUser>();
			}
		}

		public Table<Locationtree> Locationtree
		{
			get
			{
				return this.GetTable<Locationtree>();
			}
		}

		public Table<LuCode> Lucode
		{
			get
			{
				return this.GetTable<LuCode>();
			}
		}

		public Table<LuType> Lutype
		{
			get
			{
				return this.GetTable<LuType>();
			}
		}

		public Table<Mailbox> Mailbox
		{
			get
			{
				return this.GetTable<Mailbox>();
			}
		}

		public Table<MailboxAssignmentRule> Mailboxassignmentrule
		{
			get
			{
				return this.GetTable<MailboxAssignmentRule>();
			}
		}

		public Table<MailboxAssignmentType> Mailboxassignmenttype
		{
			get
			{
				return this.GetTable<MailboxAssignmentType>();
			}
		}

		public Table<ManagedCareType> Managedcaretype
		{
			get
			{
				return this.GetTable<ManagedCareType>();
			}
		}

		public Table<McBranchassignmentRule> Mcbranchassignmentrule
		{
			get
			{
				return this.GetTable<McBranchassignmentRule>();
			}
		}

		public Table<McBranchassignmenttype> Mcbranchassignmenttype
		{
			get
			{
				return this.GetTable<McBranchassignmenttype>();
			}
		}

		public Table<MedicalProvider> Medicalprovider
		{
			get
			{
				return this.GetTable<MedicalProvider>();
			}
		}

		public Table<Mercury> Mercury
		{
			get
			{
				return this.GetTable<Mercury>();
			}
		}

		public Table<MercuryForwarding> Mercuryforwarding
		{
			get
			{
				return this.GetTable<MercuryForwarding>();
			}
		}

		public Table<Messaging> Messaging
		{
			get
			{
				return this.GetTable<Messaging>();
			}
		}

		public Table<MigrationDetail> Migrationdetail
		{
			get
			{
				return this.GetTable<MigrationDetail>();
			}
		}

		public Table<Migrationerrorlog> Migrationerrorlog
		{
			get
			{
				return this.GetTable<Migrationerrorlog>();
			}
		}

		public Table<MigrationJob> Migrationjob
		{
			get
			{
				return this.GetTable<MigrationJob>();
			}
		}

		public Table<NaicsCodes> Naicscodes
		{
			get
			{
				return this.GetTable<NaicsCodes>();
			}
		}

		public Table<NcciCodes> Nccicodes
		{
			get
			{
				return this.GetTable<NcciCodes>();
			}
		}

		public Table<Network> Network
		{
			get
			{
				return this.GetTable<Network>();
			}
		}

		public Table<NikeEmployee> Nikeemployee
		{
			get
			{
				return this.GetTable<NikeEmployee>();
			}
		}

		public Table<NodeType> Nodetype
		{
			get
			{
				return this.GetTable<NodeType>();
			}
		}

		public Table<OutputDefinition> Outputdefinition
		{
			get
			{
				return this.GetTable<OutputDefinition>();
			}
		}

		public Table<OutputField> Outputfield
		{
			get
			{
				return this.GetTable<OutputField>();
			}
		}

		public Table<OutputFile> Outputfile
		{
			get
			{
				return this.GetTable<OutputFile>();
			}
		}

		public Table<OutputFilename> Outputfilename
		{
			get
			{
				return this.GetTable<OutputFilename>();
			}
		}

		public Table<OutputFilter> Outputfilter
		{
			get
			{
				return this.GetTable<OutputFilter>();
			}
		}

		public Table<OutputFilterGroup> Outputfiltergroup
		{
			get
			{
				return this.GetTable<OutputFilterGroup>();
			}
		}

		public Table<OutputItem> Outputitem
		{
			get
			{
				return this.GetTable<OutputItem>();
			}
		}

		public Table<OutputMapping> Outputmapping
		{
			get
			{
				return this.GetTable<OutputMapping>();
			}
		}

		public Table<OutputOverflow> Outputoverflow
		{
			get
			{
				return this.GetTable<OutputOverflow>();
			}
		}

		public Table<OutputPage> Outputpage
		{
			get
			{
				return this.GetTable<OutputPage>();
			}
		}

		public Table<OutputSubjectBody> Outputsubjectbody
		{
			get
			{
				return this.GetTable<OutputSubjectBody>();
			}
		}

		public Table<OutputXmltemplate> Outputxmltemplate
		{
			get
			{
				return this.GetTable<OutputXmltemplate>();
			}
		}

		public Table<Owner> Owner
		{
			get
			{
				return this.GetTable<Owner>();
			}
		}

		public Table<Policy> Policy
		{
			get
			{
				return this.GetTable<Policy>();
			}
		}

		public Table<PolicyExtension> Policyextension
		{
			get
			{
				return this.GetTable<PolicyExtension>();
			}
		}

		public Table<ReferralPlan> Referralplan
		{
			get
			{
				return this.GetTable<ReferralPlan>();
			}
		}

		public Table<ReferralType> Referraltype
		{
			get
			{
				return this.GetTable<ReferralType>();
			}
		}

		public Table<RefillStatusCodes> Refillstatuscodes
		{
			get
			{
				return this.GetTable<RefillStatusCodes>();
			}
		}

		public Table<ResubmitReason> Resubmitreason
		{
			get
			{
				return this.GetTable<ResubmitReason>();
			}
		}

		public Table<Routingaddress> Routingaddress
		{
			get
			{
				return this.GetTable<Routingaddress>();
			}
		}

		public Table<RoutingaddressRule> Routingaddressrule
		{
			get
			{
				return this.GetTable<RoutingaddressRule>();
			}
		}

		public Table<RoutingPlan> Routingplan
		{
			get
			{
				return this.GetTable<RoutingPlan>();
			}
		}

		public Table<Rules> Rules
		{
			get
			{
				return this.GetTable<Rules>();
			}
		}

		public Table<RuleSet> Ruleset
		{
			get
			{
				return this.GetTable<RuleSet>();
			}
		}

		public Table<SecurityLog> Securitylog
		{
			get
			{
				return this.GetTable<SecurityLog>();
			}
		}

		public Table<ServiceType> Servicetype
		{
			get
			{
				return this.GetTable<ServiceType>();
			}
		}

		public Table<Setting> Setting
		{
			get
			{
				return this.GetTable<Setting>();
			}
		}

		public Table<Site> Site
		{
			get
			{
				return this.GetTable<Site>();
			}
		}

		public Table<SpecificDestination> Specificdestination
		{
			get
			{
				return this.GetTable<SpecificDestination>();
			}
		}

		public Table<SpecificDestnSeqStep> Specificdestnseqstep
		{
			get
			{
				return this.GetTable<SpecificDestnSeqStep>();
			}
		}

		public Table<StorageField> Storagefield
		{
			get
			{
				return this.GetTable<StorageField>();
			}
		}

		public Table<StorageItem> Storageitem
		{
			get
			{
				return this.GetTable<StorageItem>();
			}
		}

		public Table<StorageType> Storagetype
		{
			get
			{
				return this.GetTable<StorageType>();
			}
		}

		public Table<SubrogationDetectionRule> Subrogationdetectionrule
		{
			get
			{
				return this.GetTable<SubrogationDetectionRule>();
			}
		}

		public Table<SubrogationDetectionType> Subrogationdetectiontype
		{
			get
			{
				return this.GetTable<SubrogationDetectionType>();
			}
		}

		public Table<TransmissionOutcome> Transmissionoutcome
		{
			get
			{
				return this.GetTable<TransmissionOutcome>();
			}
		}

		public Table<TransmissionOutcomeStep> Transmissionoutcomestep
		{
			get
			{
				return this.GetTable<TransmissionOutcomeStep>();
			}
		}

		public Table<TransmissionSeqStep> Transmissionseqstep
		{
			get
			{
				return this.GetTable<TransmissionSeqStep>();
			}
		}

		public Table<TransmissionType> Transmissiontype
		{
			get
			{
				return this.GetTable<TransmissionType>();
			}
		}

		public Table<TransmissionTypeStep> Transmissiontypestep
		{
			get
			{
				return this.GetTable<TransmissionTypeStep>();
			}
		}

		public Table<UifErrorCode> Uiferrorcode
		{
			get
			{
				return this.GetTable<UifErrorCode>();
			}
		}

		public Table<UifProcessRules> Uifprocessrules
		{
			get
			{
				return this.GetTable<UifProcessRules>();
			}
		}

		public Table<UserGroup> Usergroup
		{
			get
			{
				return this.GetTable<UserGroup>();
			}
		}

		public Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}

		public Table<ValidValue> Validvalue
		{
			get
			{
				return this.GetTable<ValidValue>();
			}
		}

		public Table<Vehicle> Vehicle
		{
			get
			{
				return this.GetTable<Vehicle>();
			}
		}

		public Table<VehicleCoverage> Vehiclecoverage
		{
			get
			{
				return this.GetTable<VehicleCoverage>();
			}
		}

		public Table<VehicleCoverageExt> Vehiclecoverageext
		{
			get
			{
				return this.GetTable<VehicleCoverageExt>();
			}
		}

		public Table<VehicleLien> Vehiclelien
		{
			get
			{
				return this.GetTable<VehicleLien>();
			}
		}

		public Table<Vendor> Vendor
		{
			get
			{
				return this.GetTable<Vendor>();
			}
		}

		public Table<VendorCodes> Vendorcodes
		{
			get
			{
				return this.GetTable<VendorCodes>();
			}
		}

		public Table<VendorDay> Vendorday
		{
			get
			{
				return this.GetTable<VendorDay>();
			}
		}

		public Table<VendorNetwork> Vendornetwork
		{
			get
			{
				return this.GetTable<VendorNetwork>();
			}
		}

		public Table<VendorPayType> Vendorpaytype
		{
			get
			{
				return this.GetTable<VendorPayType>();
			}
		}

		public Table<VendorReferralRule> Vendorreferralrule
		{
			get
			{
				return this.GetTable<VendorReferralRule>();
			}
		}

		public Table<VendorReferralType> Vendorreferraltype
		{
			get
			{
				return this.GetTable<VendorReferralType>();
			}
		}

		public Table<VendorService> Vendorservice
		{
			get
			{
				return this.GetTable<VendorService>();
			}
		}
	}

	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class FNSOWNER
	{
		
		public FNSOWNER(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT

	public partial class FNSOWNER
	{

		public FNSOWNER(IDbConnection connection) :
			base(connection, new DbLinq.Oracle.OracleVendor())
		{
			this.OnCreated();
		}

		public FNSOWNER(IDbConnection connection, IVendor sqlDialect) :
			base(connection, sqlDialect)
		{
			this.OnCreated();
		}

		public FNSOWNER(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) :
			base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion

	[Table(Name = "FNSOWNER.ACCESSPERMISSIONS")]
	public partial class Accesspermissions
	{

		private long _accessID;

		private long _accesstypeID;

		private System.DateTime _createdDate;

		private long _functionID;

		private System.Nullable<long> _groupID;

		private System.Nullable<long> _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccessIdChanged();

		partial void OnAccessIdChanging(long value);

		partial void OnAccesstypeIdChanged();

		partial void OnAccesstypeIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnFunctionIdChanged();

		partial void OnFunctionIdChanging(long value);

		partial void OnGroupIdChanged();

		partial void OnGroupIdChanging(System.Nullable<long> value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(System.Nullable<long> value);
		#endregion


		public Accesspermissions()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accessID", Name = "ACCESS_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccessId
		{
			get
			{
				return this._accessID;
			}
			set
			{
				if ((_accessID != value))
				{
					this.OnAccessIdChanging(value);
					this._accessID = value;
					this.OnAccessIdChanged();
				}
			}
		}

		[Column(Storage = "_accesstypeID", Name = "ACCESSTYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccesstypeId
		{
			get
			{
				return this._accesstypeID;
			}
			set
			{
				if ((_accesstypeID != value))
				{
					this.OnAccesstypeIdChanging(value);
					this._accesstypeID = value;
					this.OnAccesstypeIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_functionID", Name = "FUNCTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FunctionId
		{
			get
			{
				return this._functionID;
			}
			set
			{
				if ((_functionID != value))
				{
					this.OnFunctionIdChanging(value);
					this._functionID = value;
					this.OnFunctionIdChanged();
				}
			}
		}

		[Column(Storage = "_groupID", Name = "GROUP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> GroupId
		{
			get
			{
				return this._groupID;
			}
			set
			{
				if ((_groupID != value))
				{
					this.OnGroupIdChanging(value);
					this._groupID = value;
					this.OnGroupIdChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ACCESSTYPE")]
	public partial class Accesstype
	{

		private string _accesstype1;

		private long _accesstypeID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccesstype1Changed();

		partial void OnAccesstype1Changing(string value);

		partial void OnAccesstypeIdChanged();

		partial void OnAccesstypeIdChanging(long value);
		#endregion


		public Accesstype()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accesstype1", Name = "ACCESSTYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Accesstype1
		{
			get
			{
				return this._accesstype1;
			}
			set
			{
				if (((_accesstype1 == value)
							== false))
				{
					this.OnAccesstype1Changing(value);
					this._accesstype1 = value;
					this.OnAccesstype1Changed();
				}
			}
		}

		[Column(Storage = "_accesstypeID", Name = "ACCESSTYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccesstypeId
		{
			get
			{
				return this._accesstypeID;
			}
			set
			{
				if ((_accesstypeID != value))
				{
					this.OnAccesstypeIdChanging(value);
					this._accesstypeID = value;
					this.OnAccesstypeIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ACCOUNT_CALLFLOW")]
	public partial class AccountCallflow
	{

		private long _accntHrcyStepID;

		private long _accountcallflowID;

		private System.DateTime _activeEndDate;

		private System.DateTime _activeStartDate;

		private long _callflowID;

		private string _callflowType;

		private string _callStartFlag;

		private System.Nullable<long> _groupID;

		private string _lobCode;

		private System.Nullable<long> _validRuleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAccountcallflowIdChanged();

		partial void OnAccountcallflowIdChanging(long value);

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.DateTime value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.DateTime value);

		partial void OnCallflowIdChanged();

		partial void OnCallflowIdChanging(long value);

		partial void OnCallflowTypeChanged();

		partial void OnCallflowTypeChanging(string value);

		partial void OnCallStartFlagChanged();

		partial void OnCallStartFlagChanging(string value);

		partial void OnGroupIdChanged();

		partial void OnGroupIdChanging(System.Nullable<long> value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<long> value);
		#endregion


		public AccountCallflow()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_accountcallflowID", Name = "ACCOUNTCALLFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccountcallflowId
		{
			get
			{
				return this._accountcallflowID;
			}
			set
			{
				if ((_accountcallflowID != value))
				{
					this.OnAccountcallflowIdChanging(value);
					this._accountcallflowID = value;
					this.OnAccountcallflowIdChanged();
				}
			}
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_callflowID", Name = "CALLFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallflowId
		{
			get
			{
				return this._callflowID;
			}
			set
			{
				if ((_callflowID != value))
				{
					this.OnCallflowIdChanging(value);
					this._callflowID = value;
					this.OnCallflowIdChanged();
				}
			}
		}

		[Column(Storage = "_callflowType", Name = "CALLFLOW_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CallflowType
		{
			get
			{
				return this._callflowType;
			}
			set
			{
				if (((_callflowType == value)
							== false))
				{
					this.OnCallflowTypeChanging(value);
					this._callflowType = value;
					this.OnCallflowTypeChanged();
				}
			}
		}

		[Column(Storage = "_callStartFlag", Name = "CALL_START_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string CallStartFlag
		{
			get
			{
				return this._callStartFlag;
			}
			set
			{
				if (((_callStartFlag == value)
							== false))
				{
					this.OnCallStartFlagChanging(value);
					this._callStartFlag = value;
					this.OnCallStartFlagChanged();
				}
			}
		}

		[Column(Storage = "_groupID", Name = "GROUP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> GroupId
		{
			get
			{
				return this._groupID;
			}
			set
			{
				if ((_groupID != value))
				{
					this.OnGroupIdChanging(value);
					this._groupID = value;
					this.OnGroupIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ACCOUNT_HIERARCHY_STEP")]
	public partial class AccountHierarchyStep
	{

		private long _accntHrcyStepID;

		private System.Nullable<System.DateTime> _accountFromDate;

		private string _accountName;

		private string _accountPassword;

		private System.Nullable<System.DateTime> _accountToDate;

		private string _actecCode;

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private string _activeStatus;

		private string _additionalDeliveries;

		private string _address1;

		private string _address2;

		private string _address3;

		private string _agentBillingMethod;

		private string _agentPaymentType;

		private string _altFax;

		private string _altPhone;

		private string _autoEscalate;

		private string _city;

		private System.Nullable<long> _clientNodeID;

		private string _country;

		private string _county;

		private System.DateTime _createdDate;

		private string _currentFlag;

		private string _deptCode;

		private string _deptName;

		private string _divisionCode;

		private string _divisionName;

		private string _emailAddress;

		private string _escalationCallbackNum;

		private System.Nullable<System.DateTime> _exceptionDate;

		private string _fax;

		private string _fein;

		private System.Nullable<long> _fileTranLogID;

		private string _fips;

		private string _fnsClientCode;

		private string _locationCode;

		private string _locName;

		private string _managedCareType;

		private System.DateTime _modifiedDate;

		private string _naicsCode;

		private string _name;

		private string _nameFirst;

		private string _nameLast;

		private string _nameMi;

		private string _nameShort;

		private string _natureOfBusiness;

		private System.Nullable<long> _nodeLevel;

		private System.Nullable<long> _nodeTypeID;

		private System.Nullable<long> _parentNodeID;

		private System.Nullable<long> _peerNodeID;

		private string _phone;

		private string _secCode;

		private string _secName;

		private string _sic;

		private string _specificDestinationFlag;

		private string _state;

		private System.DateTime _statusDate;

		private string _suID;

		private string _type;

		private string _uploadKey;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAccountFromDateChanged();

		partial void OnAccountFromDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAccountNameChanged();

		partial void OnAccountNameChanging(string value);

		partial void OnAccountPasswordChanged();

		partial void OnAccountPasswordChanging(string value);

		partial void OnAccountToDateChanged();

		partial void OnAccountToDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActecCodeChanged();

		partial void OnActecCodeChanging(string value);

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStatusChanged();

		partial void OnActiveStatusChanging(string value);

		partial void OnAdditionalDeliveriesChanged();

		partial void OnAdditionalDeliveriesChanging(string value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnAddress3Changed();

		partial void OnAddress3Changing(string value);

		partial void OnAgentBillingMethodChanged();

		partial void OnAgentBillingMethodChanging(string value);

		partial void OnAgentPaymentTypeChanged();

		partial void OnAgentPaymentTypeChanging(string value);

		partial void OnAltFaxChanged();

		partial void OnAltFaxChanging(string value);

		partial void OnAltPhoneChanged();

		partial void OnAltPhoneChanging(string value);

		partial void OnAutoEscalateChanged();

		partial void OnAutoEscalateChanging(string value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnClientNodeIdChanged();

		partial void OnClientNodeIdChanging(System.Nullable<long> value);

		partial void OnCountryChanged();

		partial void OnCountryChanging(string value);

		partial void OnCountyChanged();

		partial void OnCountyChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnCurrentFlagChanged();

		partial void OnCurrentFlagChanging(string value);

		partial void OnDeptCodeChanged();

		partial void OnDeptCodeChanging(string value);

		partial void OnDeptNameChanged();

		partial void OnDeptNameChanging(string value);

		partial void OnDivisionCodeChanged();

		partial void OnDivisionCodeChanging(string value);

		partial void OnDivisionNameChanged();

		partial void OnDivisionNameChanging(string value);

		partial void OnEmailAddressChanged();

		partial void OnEmailAddressChanging(string value);

		partial void OnEscalationCallbackNumChanged();

		partial void OnEscalationCallbackNumChanging(string value);

		partial void OnExceptionDateChanged();

		partial void OnExceptionDateChanging(System.Nullable<System.DateTime> value);

		partial void OnFaxChanged();

		partial void OnFaxChanging(string value);

		partial void OnFeinChanged();

		partial void OnFeinChanging(string value);

		partial void OnFileTranLogIdChanged();

		partial void OnFileTranLogIdChanging(System.Nullable<long> value);

		partial void OnFipsChanged();

		partial void OnFipsChanging(string value);

		partial void OnFnsClientCodeChanged();

		partial void OnFnsClientCodeChanging(string value);

		partial void OnLocationCodeChanged();

		partial void OnLocationCodeChanging(string value);

		partial void OnLocNameChanged();

		partial void OnLocNameChanging(string value);

		partial void OnManagedCareTypeChanged();

		partial void OnManagedCareTypeChanging(string value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.DateTime value);

		partial void OnNaicsCodeChanged();

		partial void OnNaicsCodeChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnNameMiChanged();

		partial void OnNameMiChanging(string value);

		partial void OnNameShortChanged();

		partial void OnNameShortChanging(string value);

		partial void OnNatureOfBusinessChanged();

		partial void OnNatureOfBusinessChanging(string value);

		partial void OnNodeLevelChanged();

		partial void OnNodeLevelChanging(System.Nullable<long> value);

		partial void OnNodeTypeIdChanged();

		partial void OnNodeTypeIdChanging(System.Nullable<long> value);

		partial void OnParentNodeIdChanged();

		partial void OnParentNodeIdChanging(System.Nullable<long> value);

		partial void OnPeerNodeIdChanged();

		partial void OnPeerNodeIdChanging(System.Nullable<long> value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnSecCodeChanged();

		partial void OnSecCodeChanging(string value);

		partial void OnSecNameChanged();

		partial void OnSecNameChanging(string value);

		partial void OnSicChanged();

		partial void OnSicChanging(string value);

		partial void OnSpecificDestinationFlagChanged();

		partial void OnSpecificDestinationFlagChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnStatusDateChanged();

		partial void OnStatusDateChanging(System.DateTime value);

		partial void OnSuIdChanged();

		partial void OnSuIdChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public AccountHierarchyStep()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_accountFromDate", Name = "ACCOUNT_FROM_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> AccountFromDate
		{
			get
			{
				return this._accountFromDate;
			}
			set
			{
				if ((_accountFromDate != value))
				{
					this.OnAccountFromDateChanging(value);
					this._accountFromDate = value;
					this.OnAccountFromDateChanged();
				}
			}
		}

		[Column(Storage = "_accountName", Name = "ACCOUNT_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AccountName
		{
			get
			{
				return this._accountName;
			}
			set
			{
				if (((_accountName == value)
							== false))
				{
					this.OnAccountNameChanging(value);
					this._accountName = value;
					this.OnAccountNameChanged();
				}
			}
		}

		[Column(Storage = "_accountPassword", Name = "ACCOUNT_PASSWORD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AccountPassword
		{
			get
			{
				return this._accountPassword;
			}
			set
			{
				if (((_accountPassword == value)
							== false))
				{
					this.OnAccountPasswordChanging(value);
					this._accountPassword = value;
					this.OnAccountPasswordChanged();
				}
			}
		}

		[Column(Storage = "_accountToDate", Name = "ACCOUNT_TO_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> AccountToDate
		{
			get
			{
				return this._accountToDate;
			}
			set
			{
				if ((_accountToDate != value))
				{
					this.OnAccountToDateChanging(value);
					this._accountToDate = value;
					this.OnAccountToDateChanged();
				}
			}
		}

		[Column(Storage = "_actecCode", Name = "ACTEC_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ActecCode
		{
			get
			{
				return this._actecCode;
			}
			set
			{
				if (((_actecCode == value)
							== false))
				{
					this.OnActecCodeChanging(value);
					this._actecCode = value;
					this.OnActecCodeChanged();
				}
			}
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStatus", Name = "ACTIVE_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ActiveStatus
		{
			get
			{
				return this._activeStatus;
			}
			set
			{
				if (((_activeStatus == value)
							== false))
				{
					this.OnActiveStatusChanging(value);
					this._activeStatus = value;
					this.OnActiveStatusChanged();
				}
			}
		}

		[Column(Storage = "_additionalDeliveries", Name = "ADDITIONAL_DELIVERIES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AdditionalDeliveries
		{
			get
			{
				return this._additionalDeliveries;
			}
			set
			{
				if (((_additionalDeliveries == value)
							== false))
				{
					this.OnAdditionalDeliveriesChanging(value);
					this._additionalDeliveries = value;
					this.OnAdditionalDeliveriesChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS_1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS_2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_address3", Name = "ADDRESS_3", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address3
		{
			get
			{
				return this._address3;
			}
			set
			{
				if (((_address3 == value)
							== false))
				{
					this.OnAddress3Changing(value);
					this._address3 = value;
					this.OnAddress3Changed();
				}
			}
		}

		[Column(Storage = "_agentBillingMethod", Name = "AGENT_BILLING_METHOD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AgentBillingMethod
		{
			get
			{
				return this._agentBillingMethod;
			}
			set
			{
				if (((_agentBillingMethod == value)
							== false))
				{
					this.OnAgentBillingMethodChanging(value);
					this._agentBillingMethod = value;
					this.OnAgentBillingMethodChanged();
				}
			}
		}

		[Column(Storage = "_agentPaymentType", Name = "AGENT_PAYMENT_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AgentPaymentType
		{
			get
			{
				return this._agentPaymentType;
			}
			set
			{
				if (((_agentPaymentType == value)
							== false))
				{
					this.OnAgentPaymentTypeChanging(value);
					this._agentPaymentType = value;
					this.OnAgentPaymentTypeChanged();
				}
			}
		}

		[Column(Storage = "_altFax", Name = "ALT_FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AltFax
		{
			get
			{
				return this._altFax;
			}
			set
			{
				if (((_altFax == value)
							== false))
				{
					this.OnAltFaxChanging(value);
					this._altFax = value;
					this.OnAltFaxChanged();
				}
			}
		}

		[Column(Storage = "_altPhone", Name = "ALT_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AltPhone
		{
			get
			{
				return this._altPhone;
			}
			set
			{
				if (((_altPhone == value)
							== false))
				{
					this.OnAltPhoneChanging(value);
					this._altPhone = value;
					this.OnAltPhoneChanged();
				}
			}
		}

		[Column(Storage = "_autoEscalate", Name = "AUTO_ESCALATE", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AutoEscalate
		{
			get
			{
				return this._autoEscalate;
			}
			set
			{
				if (((_autoEscalate == value)
							== false))
				{
					this.OnAutoEscalateChanging(value);
					this._autoEscalate = value;
					this.OnAutoEscalateChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_clientNodeID", Name = "CLIENT_NODE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ClientNodeId
		{
			get
			{
				return this._clientNodeID;
			}
			set
			{
				if ((_clientNodeID != value))
				{
					this.OnClientNodeIdChanging(value);
					this._clientNodeID = value;
					this.OnClientNodeIdChanged();
				}
			}
		}

		[Column(Storage = "_country", Name = "COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Country
		{
			get
			{
				return this._country;
			}
			set
			{
				if (((_country == value)
							== false))
				{
					this.OnCountryChanging(value);
					this._country = value;
					this.OnCountryChanged();
				}
			}
		}

		[Column(Storage = "_county", Name = "COUNTY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string County
		{
			get
			{
				return this._county;
			}
			set
			{
				if (((_county == value)
							== false))
				{
					this.OnCountyChanging(value);
					this._county = value;
					this.OnCountyChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_currentFlag", Name = "CURRENT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string CurrentFlag
		{
			get
			{
				return this._currentFlag;
			}
			set
			{
				if (((_currentFlag == value)
							== false))
				{
					this.OnCurrentFlagChanging(value);
					this._currentFlag = value;
					this.OnCurrentFlagChanged();
				}
			}
		}

		[Column(Storage = "_deptCode", Name = "DEPT_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DeptCode
		{
			get
			{
				return this._deptCode;
			}
			set
			{
				if (((_deptCode == value)
							== false))
				{
					this.OnDeptCodeChanging(value);
					this._deptCode = value;
					this.OnDeptCodeChanged();
				}
			}
		}

		[Column(Storage = "_deptName", Name = "DEPT_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DeptName
		{
			get
			{
				return this._deptName;
			}
			set
			{
				if (((_deptName == value)
							== false))
				{
					this.OnDeptNameChanging(value);
					this._deptName = value;
					this.OnDeptNameChanged();
				}
			}
		}

		[Column(Storage = "_divisionCode", Name = "DIVISION_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DivisionCode
		{
			get
			{
				return this._divisionCode;
			}
			set
			{
				if (((_divisionCode == value)
							== false))
				{
					this.OnDivisionCodeChanging(value);
					this._divisionCode = value;
					this.OnDivisionCodeChanged();
				}
			}
		}

		[Column(Storage = "_divisionName", Name = "DIVISION_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DivisionName
		{
			get
			{
				return this._divisionName;
			}
			set
			{
				if (((_divisionName == value)
							== false))
				{
					this.OnDivisionNameChanging(value);
					this._divisionName = value;
					this.OnDivisionNameChanged();
				}
			}
		}

		[Column(Storage = "_emailAddress", Name = "EMAIL_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmailAddress
		{
			get
			{
				return this._emailAddress;
			}
			set
			{
				if (((_emailAddress == value)
							== false))
				{
					this.OnEmailAddressChanging(value);
					this._emailAddress = value;
					this.OnEmailAddressChanged();
				}
			}
		}

		[Column(Storage = "_escalationCallbackNum", Name = "ESCALATION_CALLBACK_NUM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EscalationCallbackNum
		{
			get
			{
				return this._escalationCallbackNum;
			}
			set
			{
				if (((_escalationCallbackNum == value)
							== false))
				{
					this.OnEscalationCallbackNumChanging(value);
					this._escalationCallbackNum = value;
					this.OnEscalationCallbackNumChanged();
				}
			}
		}

		[Column(Storage = "_exceptionDate", Name = "EXCEPTION_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ExceptionDate
		{
			get
			{
				return this._exceptionDate;
			}
			set
			{
				if ((_exceptionDate != value))
				{
					this.OnExceptionDateChanging(value);
					this._exceptionDate = value;
					this.OnExceptionDateChanged();
				}
			}
		}

		[Column(Storage = "_fax", Name = "FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fax
		{
			get
			{
				return this._fax;
			}
			set
			{
				if (((_fax == value)
							== false))
				{
					this.OnFaxChanging(value);
					this._fax = value;
					this.OnFaxChanged();
				}
			}
		}

		[Column(Storage = "_fein", Name = "FEIN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fein
		{
			get
			{
				return this._fein;
			}
			set
			{
				if (((_fein == value)
							== false))
				{
					this.OnFeinChanging(value);
					this._fein = value;
					this.OnFeinChanged();
				}
			}
		}

		[Column(Storage = "_fileTranLogID", Name = "FILE_TRAN_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTranLogId
		{
			get
			{
				return this._fileTranLogID;
			}
			set
			{
				if ((_fileTranLogID != value))
				{
					this.OnFileTranLogIdChanging(value);
					this._fileTranLogID = value;
					this.OnFileTranLogIdChanged();
				}
			}
		}

		[Column(Storage = "_fips", Name = "FIPS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fips
		{
			get
			{
				return this._fips;
			}
			set
			{
				if (((_fips == value)
							== false))
				{
					this.OnFipsChanging(value);
					this._fips = value;
					this.OnFipsChanged();
				}
			}
		}

		[Column(Storage = "_fnsClientCode", Name = "FNS_CLIENT_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FnsClientCode
		{
			get
			{
				return this._fnsClientCode;
			}
			set
			{
				if (((_fnsClientCode == value)
							== false))
				{
					this.OnFnsClientCodeChanging(value);
					this._fnsClientCode = value;
					this.OnFnsClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_locationCode", Name = "LOCATION_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LocationCode
		{
			get
			{
				return this._locationCode;
			}
			set
			{
				if (((_locationCode == value)
							== false))
				{
					this.OnLocationCodeChanging(value);
					this._locationCode = value;
					this.OnLocationCodeChanged();
				}
			}
		}

		[Column(Storage = "_locName", Name = "LOC_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LocName
		{
			get
			{
				return this._locName;
			}
			set
			{
				if (((_locName == value)
							== false))
				{
					this.OnLocNameChanging(value);
					this._locName = value;
					this.OnLocNameChanged();
				}
			}
		}

		[Column(Storage = "_managedCareType", Name = "MANAGED_CARE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ManagedCareType
		{
			get
			{
				return this._managedCareType;
			}
			set
			{
				if (((_managedCareType == value)
							== false))
				{
					this.OnManagedCareTypeChanging(value);
					this._managedCareType = value;
					this.OnManagedCareTypeChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_naicsCode", Name = "NAICS_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NaicsCode
		{
			get
			{
				return this._naicsCode;
			}
			set
			{
				if (((_naicsCode == value)
							== false))
				{
					this.OnNaicsCodeChanging(value);
					this._naicsCode = value;
					this.OnNaicsCodeChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_nameMi", Name = "NAME_MI", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameMi
		{
			get
			{
				return this._nameMi;
			}
			set
			{
				if (((_nameMi == value)
							== false))
				{
					this.OnNameMiChanging(value);
					this._nameMi = value;
					this.OnNameMiChanged();
				}
			}
		}

		[Column(Storage = "_nameShort", Name = "NAME_SHORT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameShort
		{
			get
			{
				return this._nameShort;
			}
			set
			{
				if (((_nameShort == value)
							== false))
				{
					this.OnNameShortChanging(value);
					this._nameShort = value;
					this.OnNameShortChanged();
				}
			}
		}

		[Column(Storage = "_natureOfBusiness", Name = "NATURE_OF_BUSINESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NatureOfBusiness
		{
			get
			{
				return this._natureOfBusiness;
			}
			set
			{
				if (((_natureOfBusiness == value)
							== false))
				{
					this.OnNatureOfBusinessChanging(value);
					this._natureOfBusiness = value;
					this.OnNatureOfBusinessChanged();
				}
			}
		}

		[Column(Storage = "_nodeLevel", Name = "NODE_LEVEL", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> NodeLevel
		{
			get
			{
				return this._nodeLevel;
			}
			set
			{
				if ((_nodeLevel != value))
				{
					this.OnNodeLevelChanging(value);
					this._nodeLevel = value;
					this.OnNodeLevelChanged();
				}
			}
		}

		[Column(Storage = "_nodeTypeID", Name = "NODE_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> NodeTypeId
		{
			get
			{
				return this._nodeTypeID;
			}
			set
			{
				if ((_nodeTypeID != value))
				{
					this.OnNodeTypeIdChanging(value);
					this._nodeTypeID = value;
					this.OnNodeTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_parentNodeID", Name = "PARENT_NODE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ParentNodeId
		{
			get
			{
				return this._parentNodeID;
			}
			set
			{
				if ((_parentNodeID != value))
				{
					this.OnParentNodeIdChanging(value);
					this._parentNodeID = value;
					this.OnParentNodeIdChanged();
				}
			}
		}

		[Column(Storage = "_peerNodeID", Name = "PEER_NODE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PeerNodeId
		{
			get
			{
				return this._peerNodeID;
			}
			set
			{
				if ((_peerNodeID != value))
				{
					this.OnPeerNodeIdChanging(value);
					this._peerNodeID = value;
					this.OnPeerNodeIdChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_secCode", Name = "SEC_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SecCode
		{
			get
			{
				return this._secCode;
			}
			set
			{
				if (((_secCode == value)
							== false))
				{
					this.OnSecCodeChanging(value);
					this._secCode = value;
					this.OnSecCodeChanged();
				}
			}
		}

		[Column(Storage = "_secName", Name = "SEC_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SecName
		{
			get
			{
				return this._secName;
			}
			set
			{
				if (((_secName == value)
							== false))
				{
					this.OnSecNameChanging(value);
					this._secName = value;
					this.OnSecNameChanged();
				}
			}
		}

		[Column(Storage = "_sic", Name = "SIC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sic
		{
			get
			{
				return this._sic;
			}
			set
			{
				if (((_sic == value)
							== false))
				{
					this.OnSicChanging(value);
					this._sic = value;
					this.OnSicChanged();
				}
			}
		}

		[Column(Storage = "_specificDestinationFlag", Name = "SPECIFIC_DESTINATION_FLAG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpecificDestinationFlag
		{
			get
			{
				return this._specificDestinationFlag;
			}
			set
			{
				if (((_specificDestinationFlag == value)
							== false))
				{
					this.OnSpecificDestinationFlagChanging(value);
					this._specificDestinationFlag = value;
					this.OnSpecificDestinationFlagChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_statusDate", Name = "STATUS_DATE", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime StatusDate
		{
			get
			{
				return this._statusDate;
			}
			set
			{
				if ((_statusDate != value))
				{
					this.OnStatusDateChanging(value);
					this._statusDate = value;
					this.OnStatusDateChanged();
				}
			}
		}

		[Column(Storage = "_suID", Name = "SUID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SuId
		{
			get
			{
				return this._suID;
			}
			set
			{
				if (((_suID == value)
							== false))
				{
					this.OnSuIdChanging(value);
					this._suID = value;
					this.OnSuIdChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ACCOUNT_USER")]
	public partial class AccountUser
	{

		private long _accntHrcyStepID;

		private long _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(long value);
		#endregion


		public AccountUser()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ACCOUNT_VENDOR")]
	public partial class AccountVendor
	{

		private long _accntHrcyStepID;

		private long _accountVendorID;

		private System.Nullable<long> _contactMethodID;

		private string _lob;

		private System.Nullable<long> _networkID;

		private string _script;

		private System.Nullable<long> _sequence;

		private System.Nullable<long> _serviceTypeID;

		private System.Nullable<long> _vendorID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAccountVendorIdChanged();

		partial void OnAccountVendorIdChanging(long value);

		partial void OnContactMethodIdChanged();

		partial void OnContactMethodIdChanging(System.Nullable<long> value);

		partial void OnLobChanged();

		partial void OnLobChanging(string value);

		partial void OnNetworkIdChanged();

		partial void OnNetworkIdChanging(System.Nullable<long> value);

		partial void OnScriptChanged();

		partial void OnScriptChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<long> value);

		partial void OnServiceTypeIdChanged();

		partial void OnServiceTypeIdChanging(System.Nullable<long> value);

		partial void OnVendorIdChanged();

		partial void OnVendorIdChanging(System.Nullable<long> value);
		#endregion


		public AccountVendor()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_accountVendorID", Name = "ACCOUNT_VENDOR_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccountVendorId
		{
			get
			{
				return this._accountVendorID;
			}
			set
			{
				if ((_accountVendorID != value))
				{
					this.OnAccountVendorIdChanging(value);
					this._accountVendorID = value;
					this.OnAccountVendorIdChanged();
				}
			}
		}

		[Column(Storage = "_contactMethodID", Name = "CONTACT_METHOD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ContactMethodId
		{
			get
			{
				return this._contactMethodID;
			}
			set
			{
				if ((_contactMethodID != value))
				{
					this.OnContactMethodIdChanging(value);
					this._contactMethodID = value;
					this.OnContactMethodIdChanged();
				}
			}
		}

		[Column(Storage = "_lob", Name = "LOB", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Lob
		{
			get
			{
				return this._lob;
			}
			set
			{
				if (((_lob == value)
							== false))
				{
					this.OnLobChanging(value);
					this._lob = value;
					this.OnLobChanged();
				}
			}
		}

		[Column(Storage = "_networkID", Name = "NETWORK_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> NetworkId
		{
			get
			{
				return this._networkID;
			}
			set
			{
				if ((_networkID != value))
				{
					this.OnNetworkIdChanging(value);
					this._networkID = value;
					this.OnNetworkIdChanged();
				}
			}
		}

		[Column(Storage = "_script", Name = "SCRIPT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Script
		{
			get
			{
				return this._script;
			}
			set
			{
				if (((_script == value)
							== false))
				{
					this.OnScriptChanging(value);
					this._script = value;
					this.OnScriptChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_serviceTypeID", Name = "SERVICE_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ServiceTypeId
		{
			get
			{
				return this._serviceTypeID;
			}
			set
			{
				if ((_serviceTypeID != value))
				{
					this.OnServiceTypeIdChanging(value);
					this._serviceTypeID = value;
					this.OnServiceTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_vendorID", Name = "VENDOR_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> VendorId
		{
			get
			{
				return this._vendorID;
			}
			set
			{
				if ((_vendorID != value))
				{
					this.OnVendorIdChanging(value);
					this._vendorID = value;
					this.OnVendorIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ACKNOWLEDGEMENT")]
	public partial class Acknowledgement
	{

		private string _ackInd;

		private decimal _acknowledgementID;

		private long _callID;

		private System.Nullable<System.DateTime> _createdDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAckIndChanged();

		partial void OnAckIndChanging(string value);

		partial void OnAcknowledgementIdChanged();

		partial void OnAcknowledgementIdChanging(decimal value);

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);
		#endregion


		public Acknowledgement()
		{
			this.OnCreated();
		}

		[Column(Storage = "_ackInd", Name = "ACK_IND", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AckInd
		{
			get
			{
				return this._ackInd;
			}
			set
			{
				if (((_ackInd == value)
							== false))
				{
					this.OnAckIndChanging(value);
					this._ackInd = value;
					this.OnAckIndChanged();
				}
			}
		}

		[Column(Storage = "_acknowledgementID", Name = "ACKNOWLEDGEMENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public decimal AcknowledgementId
		{
			get
			{
				return this._acknowledgementID;
			}
			set
			{
				if ((_acknowledgementID != value))
				{
					this.OnAcknowledgementIdChanging(value);
					this._acknowledgementID = value;
					this.OnAcknowledgementIdChanged();
				}
			}
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ACTIVE_DESTINATION")]
	public partial class ActiveDestination
	{

		private long _activeDestinationID;

		private System.DateTime _createdDate;

		private string _destinationString;

		private string _serverName;

		private System.Nullable<long> _transmissionTypeID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActiveDestinationIdChanged();

		partial void OnActiveDestinationIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnDestinationStringChanged();

		partial void OnDestinationStringChanging(string value);

		partial void OnServerNameChanged();

		partial void OnServerNameChanging(string value);

		partial void OnTransmissionTypeIdChanged();

		partial void OnTransmissionTypeIdChanging(System.Nullable<long> value);
		#endregion


		public ActiveDestination()
		{
			this.OnCreated();
		}

		[Column(Storage = "_activeDestinationID", Name = "ACTIVE_DESTINATION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ActiveDestinationId
		{
			get
			{
				return this._activeDestinationID;
			}
			set
			{
				if ((_activeDestinationID != value))
				{
					this.OnActiveDestinationIdChanging(value);
					this._activeDestinationID = value;
					this.OnActiveDestinationIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_destinationString", Name = "DESTINATION_STRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string DestinationString
		{
			get
			{
				return this._destinationString;
			}
			set
			{
				if (((_destinationString == value)
							== false))
				{
					this.OnDestinationStringChanging(value);
					this._destinationString = value;
					this.OnDestinationStringChanged();
				}
			}
		}

		[Column(Storage = "_serverName", Name = "SERVER_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ServerName
		{
			get
			{
				return this._serverName;
			}
			set
			{
				if (((_serverName == value)
							== false))
				{
					this.OnServerNameChanging(value);
					this._serverName = value;
					this.OnServerNameChanged();
				}
			}
		}

		[Column(Storage = "_transmissionTypeID", Name = "TRANSMISSION_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TransmissionTypeId
		{
			get
			{
				return this._transmissionTypeID;
			}
			set
			{
				if ((_transmissionTypeID != value))
				{
					this.OnTransmissionTypeIdChanging(value);
					this._transmissionTypeID = value;
					this.OnTransmissionTypeIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ADDRESS_BOOK_ENTRY")]
	public partial class AddressBookEntry
	{

		private long _addressBookEntryID;

		private long _callflowID;

		private string _description;

		private string _name;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAddressBookEntryIdChanged();

		partial void OnAddressBookEntryIdChanging(long value);

		partial void OnCallflowIdChanged();

		partial void OnCallflowIdChanging(long value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);
		#endregion


		public AddressBookEntry()
		{
			this.OnCreated();
		}

		[Column(Storage = "_addressBookEntryID", Name = "ADDRESS_BOOK_ENTRY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AddressBookEntryId
		{
			get
			{
				return this._addressBookEntryID;
			}
			set
			{
				if ((_addressBookEntryID != value))
				{
					this.OnAddressBookEntryIdChanging(value);
					this._addressBookEntryID = value;
					this.OnAddressBookEntryIdChanged();
				}
			}
		}

		[Column(Storage = "_callflowID", Name = "CALLFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallflowId
		{
			get
			{
				return this._callflowID;
			}
			set
			{
				if ((_callflowID != value))
				{
					this.OnCallflowIdChanging(value);
					this._callflowID = value;
					this.OnCallflowIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ADJUSTER")]
	public partial class Adjuster
	{

		private long _accntHrcyStepID;

		private long _adjusterID;

		private string _adjusterNumber;

		private string _assigned;

		private System.Nullable<long> _assignmentOrder;

		private string _branchNumber;

		private string _choicepointID;

		private string _email;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _name;

		private string _phone;

		private string _type;

		private string _uploadKey;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAdjusterIdChanged();

		partial void OnAdjusterIdChanging(long value);

		partial void OnAdjusterNumberChanged();

		partial void OnAdjusterNumberChanging(string value);

		partial void OnAssignedChanged();

		partial void OnAssignedChanging(string value);

		partial void OnAssignmentOrderChanged();

		partial void OnAssignmentOrderChanging(System.Nullable<long> value);

		partial void OnBranchNumberChanged();

		partial void OnBranchNumberChanging(string value);

		partial void OnChoicepointIdChanged();

		partial void OnChoicepointIdChanging(string value);

		partial void OnEmailChanged();

		partial void OnEmailChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);
		#endregion


		public Adjuster()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_adjusterID", Name = "ADJUSTER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AdjusterId
		{
			get
			{
				return this._adjusterID;
			}
			set
			{
				if ((_adjusterID != value))
				{
					this.OnAdjusterIdChanging(value);
					this._adjusterID = value;
					this.OnAdjusterIdChanged();
				}
			}
		}

		[Column(Storage = "_adjusterNumber", Name = "ADJUSTER_NUMBER", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AdjusterNumber
		{
			get
			{
				return this._adjusterNumber;
			}
			set
			{
				if (((_adjusterNumber == value)
							== false))
				{
					this.OnAdjusterNumberChanging(value);
					this._adjusterNumber = value;
					this.OnAdjusterNumberChanged();
				}
			}
		}

		[Column(Storage = "_assigned", Name = "ASSIGNED", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Assigned
		{
			get
			{
				return this._assigned;
			}
			set
			{
				if (((_assigned == value)
							== false))
				{
					this.OnAssignedChanging(value);
					this._assigned = value;
					this.OnAssignedChanged();
				}
			}
		}

		[Column(Storage = "_assignmentOrder", Name = "ASSIGNMENT_ORDER", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AssignmentOrder
		{
			get
			{
				return this._assignmentOrder;
			}
			set
			{
				if ((_assignmentOrder != value))
				{
					this.OnAssignmentOrderChanging(value);
					this._assignmentOrder = value;
					this.OnAssignmentOrderChanged();
				}
			}
		}

		[Column(Storage = "_branchNumber", Name = "BRANCH_NUMBER", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BranchNumber
		{
			get
			{
				return this._branchNumber;
			}
			set
			{
				if (((_branchNumber == value)
							== false))
				{
					this.OnBranchNumberChanging(value);
					this._branchNumber = value;
					this.OnBranchNumberChanged();
				}
			}
		}

		[Column(Storage = "_choicepointID", Name = "CHOICEPOINT_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ChoicepointId
		{
			get
			{
				return this._choicepointID;
			}
			set
			{
				if (((_choicepointID == value)
							== false))
				{
					this.OnChoicepointIdChanging(value);
					this._choicepointID = value;
					this.OnChoicepointIdChanged();
				}
			}
		}

		[Column(Storage = "_email", Name = "EMAIL", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value)
							== false))
				{
					this.OnEmailChanging(value);
					this._email = value;
					this.OnEmailChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AGENT")]
	public partial class Agent
	{

		private string _address;

		private string _agentBranchnum;

		private long _agentID;

		private string _agentNumber;

		private System.Nullable<long> _branchID;

		private string _city;

		private string _contactType;

		private string _emailAddress;

		private string _fax;

		private string _faxCode;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _gatCode;

		private System.Nullable<decimal> _lat;

		private System.Nullable<decimal> _lon;

		private string _name;

		private string _nameFirst;

		private string _nameLast;

		private string _nameMi;

		private string _phone;

		private string _phoneExt;

		private string _prefInd;

		private string _state;

		private string _status;

		private string _typeCode;

		private string _uploadKey;

		private string _zipcode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAddressChanged();

		partial void OnAddressChanging(string value);

		partial void OnAgentBranchnumChanged();

		partial void OnAgentBranchnumChanging(string value);

		partial void OnAgentIdChanged();

		partial void OnAgentIdChanging(long value);

		partial void OnAgentNumberChanged();

		partial void OnAgentNumberChanging(string value);

		partial void OnBranchIdChanged();

		partial void OnBranchIdChanging(System.Nullable<long> value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnContactTypeChanged();

		partial void OnContactTypeChanging(string value);

		partial void OnEmailAddressChanged();

		partial void OnEmailAddressChanging(string value);

		partial void OnFaxChanged();

		partial void OnFaxChanging(string value);

		partial void OnFaxCodeChanged();

		partial void OnFaxCodeChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnGatCodeChanged();

		partial void OnGatCodeChanging(string value);

		partial void OnLatChanged();

		partial void OnLatChanging(System.Nullable<decimal> value);

		partial void OnLonChanged();

		partial void OnLonChanging(System.Nullable<decimal> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnNameMiChanged();

		partial void OnNameMiChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnPhoneExtChanged();

		partial void OnPhoneExtChanging(string value);

		partial void OnPrefIndChanged();

		partial void OnPrefIndChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnTypeCodeChanged();

		partial void OnTypeCodeChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnZipcodeChanged();

		partial void OnZipcodeChanging(string value);
		#endregion


		public Agent()
		{
			this.OnCreated();
		}

		[Column(Storage = "_address", Name = "ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				if (((_address == value)
							== false))
				{
					this.OnAddressChanging(value);
					this._address = value;
					this.OnAddressChanged();
				}
			}
		}

		[Column(Storage = "_agentBranchnum", Name = "AGENT_BRANCHNUM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AgentBranchnum
		{
			get
			{
				return this._agentBranchnum;
			}
			set
			{
				if (((_agentBranchnum == value)
							== false))
				{
					this.OnAgentBranchnumChanging(value);
					this._agentBranchnum = value;
					this.OnAgentBranchnumChanged();
				}
			}
		}

		[Column(Storage = "_agentID", Name = "AGENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AgentId
		{
			get
			{
				return this._agentID;
			}
			set
			{
				if ((_agentID != value))
				{
					this.OnAgentIdChanging(value);
					this._agentID = value;
					this.OnAgentIdChanged();
				}
			}
		}

		[Column(Storage = "_agentNumber", Name = "AGENT_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AgentNumber
		{
			get
			{
				return this._agentNumber;
			}
			set
			{
				if (((_agentNumber == value)
							== false))
				{
					this.OnAgentNumberChanging(value);
					this._agentNumber = value;
					this.OnAgentNumberChanged();
				}
			}
		}

		[Column(Storage = "_branchID", Name = "BRANCH_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> BranchId
		{
			get
			{
				return this._branchID;
			}
			set
			{
				if ((_branchID != value))
				{
					this.OnBranchIdChanging(value);
					this._branchID = value;
					this.OnBranchIdChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_contactType", Name = "CONTACT_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactType
		{
			get
			{
				return this._contactType;
			}
			set
			{
				if (((_contactType == value)
							== false))
				{
					this.OnContactTypeChanging(value);
					this._contactType = value;
					this.OnContactTypeChanged();
				}
			}
		}

		[Column(Storage = "_emailAddress", Name = "EMAIL_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmailAddress
		{
			get
			{
				return this._emailAddress;
			}
			set
			{
				if (((_emailAddress == value)
							== false))
				{
					this.OnEmailAddressChanging(value);
					this._emailAddress = value;
					this.OnEmailAddressChanged();
				}
			}
		}

		[Column(Storage = "_fax", Name = "FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fax
		{
			get
			{
				return this._fax;
			}
			set
			{
				if (((_fax == value)
							== false))
				{
					this.OnFaxChanging(value);
					this._fax = value;
					this.OnFaxChanged();
				}
			}
		}

		[Column(Storage = "_faxCode", Name = "FAXCD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FaxCode
		{
			get
			{
				return this._faxCode;
			}
			set
			{
				if (((_faxCode == value)
							== false))
				{
					this.OnFaxCodeChanging(value);
					this._faxCode = value;
					this.OnFaxCodeChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_gatCode", Name = "GAT_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string GatCode
		{
			get
			{
				return this._gatCode;
			}
			set
			{
				if (((_gatCode == value)
							== false))
				{
					this.OnGatCodeChanging(value);
					this._gatCode = value;
					this.OnGatCodeChanged();
				}
			}
		}

		[Column(Storage = "_lat", Name = "LAT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Lat
		{
			get
			{
				return this._lat;
			}
			set
			{
				if ((_lat != value))
				{
					this.OnLatChanging(value);
					this._lat = value;
					this.OnLatChanged();
				}
			}
		}

		[Column(Storage = "_lon", Name = "LON", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Lon
		{
			get
			{
				return this._lon;
			}
			set
			{
				if ((_lon != value))
				{
					this.OnLonChanging(value);
					this._lon = value;
					this.OnLonChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_nameMi", Name = "NAME_MI", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameMi
		{
			get
			{
				return this._nameMi;
			}
			set
			{
				if (((_nameMi == value)
							== false))
				{
					this.OnNameMiChanging(value);
					this._nameMi = value;
					this.OnNameMiChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_phoneExt", Name = "PHONE_EXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneExt
		{
			get
			{
				return this._phoneExt;
			}
			set
			{
				if (((_phoneExt == value)
							== false))
				{
					this.OnPhoneExtChanging(value);
					this._phoneExt = value;
					this.OnPhoneExtChanged();
				}
			}
		}

		[Column(Storage = "_prefInd", Name = "PREF_IND", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PrefInd
		{
			get
			{
				return this._prefInd;
			}
			set
			{
				if (((_prefInd == value)
							== false))
				{
					this.OnPrefIndChanging(value);
					this._prefInd = value;
					this.OnPrefIndChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_typeCode", Name = "TYPECD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TypeCode
		{
			get
			{
				return this._typeCode;
			}
			set
			{
				if (((_typeCode == value)
							== false))
				{
					this.OnTypeCodeChanging(value);
					this._typeCode = value;
					this.OnTypeCodeChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_zipcode", Name = "ZIPCODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zipcode
		{
			get
			{
				return this._zipcode;
			}
			set
			{
				if (((_zipcode == value)
							== false))
				{
					this.OnZipcodeChanging(value);
					this._zipcode = value;
					this.OnZipcodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHS_AUD")]
	public partial class AhsAud
	{

		private System.Nullable<long> _accntHrcyStepID;

		private string _audCommand;

		private System.Nullable<System.DateTime> _audCrxdate;

		private string _audIpAddress;

		private string _audOsUser;

		private string _audSdFlag;

		private string _audTerminal;

		private string _specificDestinationFlag;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnAudCommandChanged();

		partial void OnAudCommandChanging(string value);

		partial void OnAudCrxdateChanged();

		partial void OnAudCrxdateChanging(System.Nullable<System.DateTime> value);

		partial void OnAudIpAddressChanged();

		partial void OnAudIpAddressChanging(string value);

		partial void OnAudOsUserChanged();

		partial void OnAudOsUserChanging(string value);

		partial void OnAudSdFlagChanged();

		partial void OnAudSdFlagChanging(string value);

		partial void OnAudTerminalChanged();

		partial void OnAudTerminalChanging(string value);

		partial void OnSpecificDestinationFlagChanged();

		partial void OnSpecificDestinationFlagChanging(string value);
		#endregion


		public AhsAud()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_audCommand", Name = "AUD_COMMAND", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AudCommand
		{
			get
			{
				return this._audCommand;
			}
			set
			{
				if (((_audCommand == value)
							== false))
				{
					this.OnAudCommandChanging(value);
					this._audCommand = value;
					this.OnAudCommandChanged();
				}
			}
		}

		[Column(Storage = "_audCrxdate", Name = "AUD_CRXDATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> AudCrxdate
		{
			get
			{
				return this._audCrxdate;
			}
			set
			{
				if ((_audCrxdate != value))
				{
					this.OnAudCrxdateChanging(value);
					this._audCrxdate = value;
					this.OnAudCrxdateChanged();
				}
			}
		}

		[Column(Storage = "_audIpAddress", Name = "AUD_IP_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AudIpAddress
		{
			get
			{
				return this._audIpAddress;
			}
			set
			{
				if (((_audIpAddress == value)
							== false))
				{
					this.OnAudIpAddressChanging(value);
					this._audIpAddress = value;
					this.OnAudIpAddressChanged();
				}
			}
		}

		[Column(Storage = "_audOsUser", Name = "AUD_OS_USER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AudOsUser
		{
			get
			{
				return this._audOsUser;
			}
			set
			{
				if (((_audOsUser == value)
							== false))
				{
					this.OnAudOsUserChanging(value);
					this._audOsUser = value;
					this.OnAudOsUserChanged();
				}
			}
		}

		[Column(Storage = "_audSdFlag", Name = "AUD_SD_FLAG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AudSdFlag
		{
			get
			{
				return this._audSdFlag;
			}
			set
			{
				if (((_audSdFlag == value)
							== false))
				{
					this.OnAudSdFlagChanging(value);
					this._audSdFlag = value;
					this.OnAudSdFlagChanged();
				}
			}
		}

		[Column(Storage = "_audTerminal", Name = "AUD_TERMINAL", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AudTerminal
		{
			get
			{
				return this._audTerminal;
			}
			set
			{
				if (((_audTerminal == value)
							== false))
				{
					this.OnAudTerminalChanging(value);
					this._audTerminal = value;
					this.OnAudTerminalChanged();
				}
			}
		}

		[Column(Storage = "_specificDestinationFlag", Name = "SPECIFIC_DESTINATION_FLAG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpecificDestinationFlag
		{
			get
			{
				return this._specificDestinationFlag;
			}
			set
			{
				if (((_specificDestinationFlag == value)
							== false))
				{
					this.OnSpecificDestinationFlagChanging(value);
					this._specificDestinationFlag = value;
					this.OnSpecificDestinationFlagChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHS_CONTACT")]
	public partial class AhsContact
	{

		private long _accntHrcyStepID;

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private long _ahsContactID;

		private long _contactID;

		private System.Nullable<long> _fileTransmissionLogID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAhsContactIdChanged();

		partial void OnAhsContactIdChanging(long value);

		partial void OnContactIdChanged();

		partial void OnContactIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);
		#endregion


		public AhsContact()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_ahsContactID", Name = "AHS_CONTACT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhsContactId
		{
			get
			{
				return this._ahsContactID;
			}
			set
			{
				if ((_ahsContactID != value))
				{
					this.OnAhsContactIdChanging(value);
					this._ahsContactID = value;
					this.OnAhsContactIdChanged();
				}
			}
		}

		[Column(Storage = "_contactID", Name = "CONTACT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ContactId
		{
			get
			{
				return this._contactID;
			}
			set
			{
				if ((_contactID != value))
				{
					this.OnContactIdChanging(value);
					this._contactID = value;
					this.OnContactIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHS_COVERAGE_CISG")]
	public partial class AhsCoverageCisg
	{

		private System.Nullable<long> _accntHrcyStepID;

		private long _ahsCoverageID;

		private string _coverageTypeCode;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _insuranceCompany;

		private string _lineOfBusiness;

		private string _origApplication;

		private System.Nullable<System.DateTime> _policyEffectiveDate;

		private System.Nullable<System.DateTime> _policyExpirationDate;

		private string _policyNum;

		private System.Nullable<short> _sequence;

		private string _status;

		private string _tpaBranchName;

		private string _tpaBranchNum;

		private string _uploadKey;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnAhsCoverageIdChanged();

		partial void OnAhsCoverageIdChanging(long value);

		partial void OnCoverageTypeCodeChanged();

		partial void OnCoverageTypeCodeChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnInsuranceCompanyChanged();

		partial void OnInsuranceCompanyChanging(string value);

		partial void OnLineOfBusinessChanged();

		partial void OnLineOfBusinessChanging(string value);

		partial void OnOrigApplicationChanged();

		partial void OnOrigApplicationChanging(string value);

		partial void OnPolicyEffectiveDateChanged();

		partial void OnPolicyEffectiveDateChanging(System.Nullable<System.DateTime> value);

		partial void OnPolicyExpirationDateChanged();

		partial void OnPolicyExpirationDateChanging(System.Nullable<System.DateTime> value);

		partial void OnPolicyNumChanged();

		partial void OnPolicyNumChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<short> value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnTpaBranchNameChanged();

		partial void OnTpaBranchNameChanging(string value);

		partial void OnTpaBranchNumChanged();

		partial void OnTpaBranchNumChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);
		#endregion


		public AhsCoverageCisg()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_ahsCoverageID", Name = "AHS_COVERAGE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhsCoverageId
		{
			get
			{
				return this._ahsCoverageID;
			}
			set
			{
				if ((_ahsCoverageID != value))
				{
					this.OnAhsCoverageIdChanging(value);
					this._ahsCoverageID = value;
					this.OnAhsCoverageIdChanged();
				}
			}
		}

		[Column(Storage = "_coverageTypeCode", Name = "COVERAGE_TYPE_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CoverageTypeCode
		{
			get
			{
				return this._coverageTypeCode;
			}
			set
			{
				if (((_coverageTypeCode == value)
							== false))
				{
					this.OnCoverageTypeCodeChanging(value);
					this._coverageTypeCode = value;
					this.OnCoverageTypeCodeChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_insuranceCompany", Name = "INSURANCE_COMPANY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string InsuranceCompany
		{
			get
			{
				return this._insuranceCompany;
			}
			set
			{
				if (((_insuranceCompany == value)
							== false))
				{
					this.OnInsuranceCompanyChanging(value);
					this._insuranceCompany = value;
					this.OnInsuranceCompanyChanged();
				}
			}
		}

		[Column(Storage = "_lineOfBusiness", Name = "LINE_OF_BUSINESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LineOfBusiness
		{
			get
			{
				return this._lineOfBusiness;
			}
			set
			{
				if (((_lineOfBusiness == value)
							== false))
				{
					this.OnLineOfBusinessChanging(value);
					this._lineOfBusiness = value;
					this.OnLineOfBusinessChanged();
				}
			}
		}

		[Column(Storage = "_origApplication", Name = "ORIG_APPLICATION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OrigApplication
		{
			get
			{
				return this._origApplication;
			}
			set
			{
				if (((_origApplication == value)
							== false))
				{
					this.OnOrigApplicationChanging(value);
					this._origApplication = value;
					this.OnOrigApplicationChanged();
				}
			}
		}

		[Column(Storage = "_policyEffectiveDate", Name = "POLICY_EFFECTIVE_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> PolicyEffectiveDate
		{
			get
			{
				return this._policyEffectiveDate;
			}
			set
			{
				if ((_policyEffectiveDate != value))
				{
					this.OnPolicyEffectiveDateChanging(value);
					this._policyEffectiveDate = value;
					this.OnPolicyEffectiveDateChanged();
				}
			}
		}

		[Column(Storage = "_policyExpirationDate", Name = "POLICY_EXPIRATION_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> PolicyExpirationDate
		{
			get
			{
				return this._policyExpirationDate;
			}
			set
			{
				if ((_policyExpirationDate != value))
				{
					this.OnPolicyExpirationDateChanging(value);
					this._policyExpirationDate = value;
					this.OnPolicyExpirationDateChanged();
				}
			}
		}

		[Column(Storage = "_policyNum", Name = "POLICY_NUM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PolicyNum
		{
			get
			{
				return this._policyNum;
			}
			set
			{
				if (((_policyNum == value)
							== false))
				{
					this.OnPolicyNumChanging(value);
					this._policyNum = value;
					this.OnPolicyNumChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_tpaBranchName", Name = "TPA_BRANCH_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TpaBranchName
		{
			get
			{
				return this._tpaBranchName;
			}
			set
			{
				if (((_tpaBranchName == value)
							== false))
				{
					this.OnTpaBranchNameChanging(value);
					this._tpaBranchName = value;
					this.OnTpaBranchNameChanged();
				}
			}
		}

		[Column(Storage = "_tpaBranchNum", Name = "TPA_BRANCH_NUM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TpaBranchNum
		{
			get
			{
				return this._tpaBranchNum;
			}
			set
			{
				if (((_tpaBranchNum == value)
							== false))
				{
					this.OnTpaBranchNumChanging(value);
					this._tpaBranchNum = value;
					this.OnTpaBranchNumChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHSEARCH_POLICY_VIEW")]
	public partial class AhsearchPolicyView
	{

		private string _aaDdress;

		private string _aaGentBranchnum;

		private string _aaGentNumber;

		private string _acIty;

		private string _acOntactType;

		private string _aeMailAddress;

		private string _afAx;

		private string _afAxCode;

		private long _ahAccntHrcyStepID;

		private string _ahAdditionalDeliveries;

		private string _ahAddress1;

		private string _ahAddress2;

		private string _ahAddress3;

		private string _ahAltPhone;

		private string _ahCity;

		private string _ahCountry;

		private string _ahCounty;

		private string _ahDeptCode;

		private string _ahDeptName;

		private string _ahDivisionCode;

		private string _ahDivisionName;

		private string _ahEmailAddress;

		private string _ahFax;

		private string _ahFein;

		private string _ahFips;

		private string _ahLocationCode;

		private string _ahLocName;

		private string _ahManagedCareType;

		private string _ahName;

		private string _ahNameFirst;

		private string _ahNameLast;

		private string _ahNameMi;

		private string _ahNatureOfBusiness;

		private string _ahPhone;

		private string _ahSecCode;

		private string _ahSecName;

		private string _ahSic;

		private string _ahSpecificDestnFlag;

		private string _ahState;

		private string _ahSuID;

		private string _ahZip;

		private System.Nullable<decimal> _alAt;

		private System.Nullable<decimal> _alOn;

		private string _anAme;

		private string _anAmeFirst;

		private string _anAmeLast;

		private string _anAmeMi;

		private string _apHone;

		private string _apHoneExt;

		private string _apRefInd;

		private string _asTate;

		private string _asTatus;

		private string _atYpeCode;

		private string _azIpcode;

		private string _baDdress1;

		private string _baDdress2;

		private string _baLtContactFnAme;

		private string _baLtContactLnAme;

		private string _baLtPhone;

		private string _bbAckupFax;

		private string _bbRanchNumber;

		private string _bbRanchType;

		private string _bcIty;

		private string _bcOntactFnAme;

		private string _bcOntactLnAme;

		private string _bcOntactTitle;

		private string _bcOuntry;

		private string _bfAx;

		private string _bfOreignZip;

		private System.Nullable<float> _blAt;

		private System.Nullable<float> _blOn;

		private string _bnOtes;

		private string _boFficeName;

		private System.Nullable<long> _boFficeNumber;

		private string _boFficeType;

		private string _boVernightAddress1;

		private string _boVernightAddress2;

		private string _boVernightAddressCity;

		private string _boVernightAddressState;

		private string _boVernightAddressZip;

		private string _bpHone;

		private string _bsTate;

		private string _bsTatus;

		private string _bzIp;

		private string _caDdress1;

		private string _caDdress2;

		private string _cbUreauCode;

		private string _cbUsinessType;

		private string _ccArrierNumber;

		private string _ccIty;

		private string _cfEin;

		private string _cnAme;

		private string _cpHone;

		private string _csTate;

		private string _ctItle;

		private string _czIp;

		private string _paDditionalDeliveries;

		private string _pcAncellationDate;

		private string _pcHangeDate;

		private string _pcOmpanyCode;

		private string _pdIvisionCode;

		private string _peFfectiveDate;

		private string _peXpirationDate;

		private string _plOadDate;

		private string _pmAnagedCareType;

		private string _poRiginalEffectiveDate;

		private string _ppOlicyCovCodes;

		private string _ppOlicyDecription;

		private long _ppOlicyID;

		private string _ppOlicyNumber;

		private string _ppOlicyType;

		private string _psElfInsured;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAAddressChanged();

		partial void OnAAddressChanging(string value);

		partial void OnAAgentBranchnumChanged();

		partial void OnAAgentBranchnumChanging(string value);

		partial void OnAAgentNumberChanged();

		partial void OnAAgentNumberChanging(string value);

		partial void OnACityChanged();

		partial void OnACityChanging(string value);

		partial void OnAContactTypeChanged();

		partial void OnAContactTypeChanging(string value);

		partial void OnAEmailAddressChanged();

		partial void OnAEmailAddressChanging(string value);

		partial void OnAFaxChanged();

		partial void OnAFaxChanging(string value);

		partial void OnAFaxCodeChanged();

		partial void OnAFaxCodeChanging(string value);

		partial void OnAhAccntHrcyStepIdChanged();

		partial void OnAhAccntHrcyStepIdChanging(long value);

		partial void OnAhAdditionalDeliveriesChanged();

		partial void OnAhAdditionalDeliveriesChanging(string value);

		partial void OnAhAddress1Changed();

		partial void OnAhAddress1Changing(string value);

		partial void OnAhAddress2Changed();

		partial void OnAhAddress2Changing(string value);

		partial void OnAhAddress3Changed();

		partial void OnAhAddress3Changing(string value);

		partial void OnAhAltPhoneChanged();

		partial void OnAhAltPhoneChanging(string value);

		partial void OnAhCityChanged();

		partial void OnAhCityChanging(string value);

		partial void OnAhCountryChanged();

		partial void OnAhCountryChanging(string value);

		partial void OnAhCountyChanged();

		partial void OnAhCountyChanging(string value);

		partial void OnAhDeptCodeChanged();

		partial void OnAhDeptCodeChanging(string value);

		partial void OnAhDeptNameChanged();

		partial void OnAhDeptNameChanging(string value);

		partial void OnAhDivisionCodeChanged();

		partial void OnAhDivisionCodeChanging(string value);

		partial void OnAhDivisionNameChanged();

		partial void OnAhDivisionNameChanging(string value);

		partial void OnAhEmailAddressChanged();

		partial void OnAhEmailAddressChanging(string value);

		partial void OnAhFaxChanged();

		partial void OnAhFaxChanging(string value);

		partial void OnAhFeinChanged();

		partial void OnAhFeinChanging(string value);

		partial void OnAhFipsChanged();

		partial void OnAhFipsChanging(string value);

		partial void OnAhLocationCodeChanged();

		partial void OnAhLocationCodeChanging(string value);

		partial void OnAhLocNameChanged();

		partial void OnAhLocNameChanging(string value);

		partial void OnAhManagedCareTypeChanged();

		partial void OnAhManagedCareTypeChanging(string value);

		partial void OnAhNameChanged();

		partial void OnAhNameChanging(string value);

		partial void OnAhNameFirstChanged();

		partial void OnAhNameFirstChanging(string value);

		partial void OnAhNameLastChanged();

		partial void OnAhNameLastChanging(string value);

		partial void OnAhNameMiChanged();

		partial void OnAhNameMiChanging(string value);

		partial void OnAhNatureOfBusinessChanged();

		partial void OnAhNatureOfBusinessChanging(string value);

		partial void OnAhPhoneChanged();

		partial void OnAhPhoneChanging(string value);

		partial void OnAhSecCodeChanged();

		partial void OnAhSecCodeChanging(string value);

		partial void OnAhSecNameChanged();

		partial void OnAhSecNameChanging(string value);

		partial void OnAhSicChanged();

		partial void OnAhSicChanging(string value);

		partial void OnAhSpecificDestnFlagChanged();

		partial void OnAhSpecificDestnFlagChanging(string value);

		partial void OnAhStateChanged();

		partial void OnAhStateChanging(string value);

		partial void OnAhSuIdChanged();

		partial void OnAhSuIdChanging(string value);

		partial void OnAhZipChanged();

		partial void OnAhZipChanging(string value);

		partial void OnALatChanged();

		partial void OnALatChanging(System.Nullable<decimal> value);

		partial void OnALonChanged();

		partial void OnALonChanging(System.Nullable<decimal> value);

		partial void OnANameChanged();

		partial void OnANameChanging(string value);

		partial void OnANameFirstChanged();

		partial void OnANameFirstChanging(string value);

		partial void OnANameLastChanged();

		partial void OnANameLastChanging(string value);

		partial void OnANameMiChanged();

		partial void OnANameMiChanging(string value);

		partial void OnAPhoneChanged();

		partial void OnAPhoneChanging(string value);

		partial void OnAPhoneExtChanged();

		partial void OnAPhoneExtChanging(string value);

		partial void OnAPrefIndChanged();

		partial void OnAPrefIndChanging(string value);

		partial void OnAStateChanged();

		partial void OnAStateChanging(string value);

		partial void OnAStatusChanged();

		partial void OnAStatusChanging(string value);

		partial void OnATypeCodeChanged();

		partial void OnATypeCodeChanging(string value);

		partial void OnAZipcodeChanged();

		partial void OnAZipcodeChanging(string value);

		partial void OnBAddress1Changed();

		partial void OnBAddress1Changing(string value);

		partial void OnBAddress2Changed();

		partial void OnBAddress2Changing(string value);

		partial void OnBAltContactFNameChanged();

		partial void OnBAltContactFNameChanging(string value);

		partial void OnBAltContactLNameChanged();

		partial void OnBAltContactLNameChanging(string value);

		partial void OnBAltPhoneChanged();

		partial void OnBAltPhoneChanging(string value);

		partial void OnBBackupFaxChanged();

		partial void OnBBackupFaxChanging(string value);

		partial void OnBBranchNumberChanged();

		partial void OnBBranchNumberChanging(string value);

		partial void OnBBranchTypeChanged();

		partial void OnBBranchTypeChanging(string value);

		partial void OnBCityChanged();

		partial void OnBCityChanging(string value);

		partial void OnBContactFNameChanged();

		partial void OnBContactFNameChanging(string value);

		partial void OnBContactLNameChanged();

		partial void OnBContactLNameChanging(string value);

		partial void OnBContactTitleChanged();

		partial void OnBContactTitleChanging(string value);

		partial void OnBCountryChanged();

		partial void OnBCountryChanging(string value);

		partial void OnBFaxChanged();

		partial void OnBFaxChanging(string value);

		partial void OnBForeignZipChanged();

		partial void OnBForeignZipChanging(string value);

		partial void OnBLatChanged();

		partial void OnBLatChanging(System.Nullable<float> value);

		partial void OnBLonChanged();

		partial void OnBLonChanging(System.Nullable<float> value);

		partial void OnBNotesChanged();

		partial void OnBNotesChanging(string value);

		partial void OnBOfficeNameChanged();

		partial void OnBOfficeNameChanging(string value);

		partial void OnBOfficeNumberChanged();

		partial void OnBOfficeNumberChanging(System.Nullable<long> value);

		partial void OnBOfficeTypeChanged();

		partial void OnBOfficeTypeChanging(string value);

		partial void OnBOvernightAddress1Changed();

		partial void OnBOvernightAddress1Changing(string value);

		partial void OnBOvernightAddress2Changed();

		partial void OnBOvernightAddress2Changing(string value);

		partial void OnBOvernightAddressCityChanged();

		partial void OnBOvernightAddressCityChanging(string value);

		partial void OnBOvernightAddressStateChanged();

		partial void OnBOvernightAddressStateChanging(string value);

		partial void OnBOvernightAddressZipChanged();

		partial void OnBOvernightAddressZipChanging(string value);

		partial void OnBPhoneChanged();

		partial void OnBPhoneChanging(string value);

		partial void OnBStateChanged();

		partial void OnBStateChanging(string value);

		partial void OnBStatusChanged();

		partial void OnBStatusChanging(string value);

		partial void OnBZipChanged();

		partial void OnBZipChanging(string value);

		partial void OnCAddress1Changed();

		partial void OnCAddress1Changing(string value);

		partial void OnCAddress2Changed();

		partial void OnCAddress2Changing(string value);

		partial void OnCBureauCodeChanged();

		partial void OnCBureauCodeChanging(string value);

		partial void OnCBusinessTypeChanged();

		partial void OnCBusinessTypeChanging(string value);

		partial void OnCCarrierNumberChanged();

		partial void OnCCarrierNumberChanging(string value);

		partial void OnCCityChanged();

		partial void OnCCityChanging(string value);

		partial void OnCFeinChanged();

		partial void OnCFeinChanging(string value);

		partial void OnCNameChanged();

		partial void OnCNameChanging(string value);

		partial void OnCPhoneChanged();

		partial void OnCPhoneChanging(string value);

		partial void OnCStateChanged();

		partial void OnCStateChanging(string value);

		partial void OnCTitleChanged();

		partial void OnCTitleChanging(string value);

		partial void OnCZipChanged();

		partial void OnCZipChanging(string value);

		partial void OnPAdditionalDeliveriesChanged();

		partial void OnPAdditionalDeliveriesChanging(string value);

		partial void OnPCancellationDateChanged();

		partial void OnPCancellationDateChanging(string value);

		partial void OnPChangeDateChanged();

		partial void OnPChangeDateChanging(string value);

		partial void OnPCompanyCodeChanged();

		partial void OnPCompanyCodeChanging(string value);

		partial void OnPDivisionCodeChanged();

		partial void OnPDivisionCodeChanging(string value);

		partial void OnPEffectiveDateChanged();

		partial void OnPEffectiveDateChanging(string value);

		partial void OnPExpirationDateChanged();

		partial void OnPExpirationDateChanging(string value);

		partial void OnPLoadDateChanged();

		partial void OnPLoadDateChanging(string value);

		partial void OnPManagedCareTypeChanged();

		partial void OnPManagedCareTypeChanging(string value);

		partial void OnPOriginalEffectiveDateChanged();

		partial void OnPOriginalEffectiveDateChanging(string value);

		partial void OnPPolicyCovCodesChanged();

		partial void OnPPolicyCovCodesChanging(string value);

		partial void OnPPolicyDecriptionChanged();

		partial void OnPPolicyDecriptionChanging(string value);

		partial void OnPPolicyIdChanged();

		partial void OnPPolicyIdChanging(long value);

		partial void OnPPolicyNumberChanged();

		partial void OnPPolicyNumberChanging(string value);

		partial void OnPPolicyTypeChanged();

		partial void OnPPolicyTypeChanging(string value);

		partial void OnPSelfInsuredChanged();

		partial void OnPSelfInsuredChanging(string value);
		#endregion


		public AhsearchPolicyView()
		{
			this.OnCreated();
		}

		[Column(Storage = "_aaDdress", Name = "A_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AAddress
		{
			get
			{
				return this._aaDdress;
			}
			set
			{
				if (((_aaDdress == value)
							== false))
				{
					this.OnAAddressChanging(value);
					this._aaDdress = value;
					this.OnAAddressChanged();
				}
			}
		}

		[Column(Storage = "_aaGentBranchnum", Name = "A_AGENT_BRANCHNUM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AAgentBranchnum
		{
			get
			{
				return this._aaGentBranchnum;
			}
			set
			{
				if (((_aaGentBranchnum == value)
							== false))
				{
					this.OnAAgentBranchnumChanging(value);
					this._aaGentBranchnum = value;
					this.OnAAgentBranchnumChanged();
				}
			}
		}

		[Column(Storage = "_aaGentNumber", Name = "A_AGENT_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AAgentNumber
		{
			get
			{
				return this._aaGentNumber;
			}
			set
			{
				if (((_aaGentNumber == value)
							== false))
				{
					this.OnAAgentNumberChanging(value);
					this._aaGentNumber = value;
					this.OnAAgentNumberChanged();
				}
			}
		}

		[Column(Storage = "_acIty", Name = "A_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ACity
		{
			get
			{
				return this._acIty;
			}
			set
			{
				if (((_acIty == value)
							== false))
				{
					this.OnACityChanging(value);
					this._acIty = value;
					this.OnACityChanged();
				}
			}
		}

		[Column(Storage = "_acOntactType", Name = "A_CONTACT_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AContactType
		{
			get
			{
				return this._acOntactType;
			}
			set
			{
				if (((_acOntactType == value)
							== false))
				{
					this.OnAContactTypeChanging(value);
					this._acOntactType = value;
					this.OnAContactTypeChanged();
				}
			}
		}

		[Column(Storage = "_aeMailAddress", Name = "A_EMAIL_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AEmailAddress
		{
			get
			{
				return this._aeMailAddress;
			}
			set
			{
				if (((_aeMailAddress == value)
							== false))
				{
					this.OnAEmailAddressChanging(value);
					this._aeMailAddress = value;
					this.OnAEmailAddressChanged();
				}
			}
		}

		[Column(Storage = "_afAx", Name = "A_FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AFax
		{
			get
			{
				return this._afAx;
			}
			set
			{
				if (((_afAx == value)
							== false))
				{
					this.OnAFaxChanging(value);
					this._afAx = value;
					this.OnAFaxChanged();
				}
			}
		}

		[Column(Storage = "_afAxCode", Name = "A_FAXCD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AFaxCode
		{
			get
			{
				return this._afAxCode;
			}
			set
			{
				if (((_afAxCode == value)
							== false))
				{
					this.OnAFaxCodeChanging(value);
					this._afAxCode = value;
					this.OnAFaxCodeChanged();
				}
			}
		}

		[Column(Storage = "_ahAccntHrcyStepID", Name = "AH_ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhAccntHrcyStepId
		{
			get
			{
				return this._ahAccntHrcyStepID;
			}
			set
			{
				if ((_ahAccntHrcyStepID != value))
				{
					this.OnAhAccntHrcyStepIdChanging(value);
					this._ahAccntHrcyStepID = value;
					this.OnAhAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_ahAdditionalDeliveries", Name = "AH_ADDITIONAL_DELIVERIES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhAdditionalDeliveries
		{
			get
			{
				return this._ahAdditionalDeliveries;
			}
			set
			{
				if (((_ahAdditionalDeliveries == value)
							== false))
				{
					this.OnAhAdditionalDeliveriesChanging(value);
					this._ahAdditionalDeliveries = value;
					this.OnAhAdditionalDeliveriesChanged();
				}
			}
		}

		[Column(Storage = "_ahAddress1", Name = "AH_ADDRESS_1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhAddress1
		{
			get
			{
				return this._ahAddress1;
			}
			set
			{
				if (((_ahAddress1 == value)
							== false))
				{
					this.OnAhAddress1Changing(value);
					this._ahAddress1 = value;
					this.OnAhAddress1Changed();
				}
			}
		}

		[Column(Storage = "_ahAddress2", Name = "AH_ADDRESS_2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhAddress2
		{
			get
			{
				return this._ahAddress2;
			}
			set
			{
				if (((_ahAddress2 == value)
							== false))
				{
					this.OnAhAddress2Changing(value);
					this._ahAddress2 = value;
					this.OnAhAddress2Changed();
				}
			}
		}

		[Column(Storage = "_ahAddress3", Name = "AH_ADDRESS_3", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhAddress3
		{
			get
			{
				return this._ahAddress3;
			}
			set
			{
				if (((_ahAddress3 == value)
							== false))
				{
					this.OnAhAddress3Changing(value);
					this._ahAddress3 = value;
					this.OnAhAddress3Changed();
				}
			}
		}

		[Column(Storage = "_ahAltPhone", Name = "AH_ALT_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhAltPhone
		{
			get
			{
				return this._ahAltPhone;
			}
			set
			{
				if (((_ahAltPhone == value)
							== false))
				{
					this.OnAhAltPhoneChanging(value);
					this._ahAltPhone = value;
					this.OnAhAltPhoneChanged();
				}
			}
		}

		[Column(Storage = "_ahCity", Name = "AH_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhCity
		{
			get
			{
				return this._ahCity;
			}
			set
			{
				if (((_ahCity == value)
							== false))
				{
					this.OnAhCityChanging(value);
					this._ahCity = value;
					this.OnAhCityChanged();
				}
			}
		}

		[Column(Storage = "_ahCountry", Name = "AH_COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhCountry
		{
			get
			{
				return this._ahCountry;
			}
			set
			{
				if (((_ahCountry == value)
							== false))
				{
					this.OnAhCountryChanging(value);
					this._ahCountry = value;
					this.OnAhCountryChanged();
				}
			}
		}

		[Column(Storage = "_ahCounty", Name = "AH_COUNTY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhCounty
		{
			get
			{
				return this._ahCounty;
			}
			set
			{
				if (((_ahCounty == value)
							== false))
				{
					this.OnAhCountyChanging(value);
					this._ahCounty = value;
					this.OnAhCountyChanged();
				}
			}
		}

		[Column(Storage = "_ahDeptCode", Name = "AH_DEPT_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhDeptCode
		{
			get
			{
				return this._ahDeptCode;
			}
			set
			{
				if (((_ahDeptCode == value)
							== false))
				{
					this.OnAhDeptCodeChanging(value);
					this._ahDeptCode = value;
					this.OnAhDeptCodeChanged();
				}
			}
		}

		[Column(Storage = "_ahDeptName", Name = "AH_DEPT_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhDeptName
		{
			get
			{
				return this._ahDeptName;
			}
			set
			{
				if (((_ahDeptName == value)
							== false))
				{
					this.OnAhDeptNameChanging(value);
					this._ahDeptName = value;
					this.OnAhDeptNameChanged();
				}
			}
		}

		[Column(Storage = "_ahDivisionCode", Name = "AH_DIVISION_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhDivisionCode
		{
			get
			{
				return this._ahDivisionCode;
			}
			set
			{
				if (((_ahDivisionCode == value)
							== false))
				{
					this.OnAhDivisionCodeChanging(value);
					this._ahDivisionCode = value;
					this.OnAhDivisionCodeChanged();
				}
			}
		}

		[Column(Storage = "_ahDivisionName", Name = "AH_DIVISION_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhDivisionName
		{
			get
			{
				return this._ahDivisionName;
			}
			set
			{
				if (((_ahDivisionName == value)
							== false))
				{
					this.OnAhDivisionNameChanging(value);
					this._ahDivisionName = value;
					this.OnAhDivisionNameChanged();
				}
			}
		}

		[Column(Storage = "_ahEmailAddress", Name = "AH_EMAIL_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhEmailAddress
		{
			get
			{
				return this._ahEmailAddress;
			}
			set
			{
				if (((_ahEmailAddress == value)
							== false))
				{
					this.OnAhEmailAddressChanging(value);
					this._ahEmailAddress = value;
					this.OnAhEmailAddressChanged();
				}
			}
		}

		[Column(Storage = "_ahFax", Name = "AH_FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhFax
		{
			get
			{
				return this._ahFax;
			}
			set
			{
				if (((_ahFax == value)
							== false))
				{
					this.OnAhFaxChanging(value);
					this._ahFax = value;
					this.OnAhFaxChanged();
				}
			}
		}

		[Column(Storage = "_ahFein", Name = "AH_FEIN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhFein
		{
			get
			{
				return this._ahFein;
			}
			set
			{
				if (((_ahFein == value)
							== false))
				{
					this.OnAhFeinChanging(value);
					this._ahFein = value;
					this.OnAhFeinChanged();
				}
			}
		}

		[Column(Storage = "_ahFips", Name = "AH_FIPS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhFips
		{
			get
			{
				return this._ahFips;
			}
			set
			{
				if (((_ahFips == value)
							== false))
				{
					this.OnAhFipsChanging(value);
					this._ahFips = value;
					this.OnAhFipsChanged();
				}
			}
		}

		[Column(Storage = "_ahLocationCode", Name = "AH_LOCATION_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhLocationCode
		{
			get
			{
				return this._ahLocationCode;
			}
			set
			{
				if (((_ahLocationCode == value)
							== false))
				{
					this.OnAhLocationCodeChanging(value);
					this._ahLocationCode = value;
					this.OnAhLocationCodeChanged();
				}
			}
		}

		[Column(Storage = "_ahLocName", Name = "AH_LOC_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhLocName
		{
			get
			{
				return this._ahLocName;
			}
			set
			{
				if (((_ahLocName == value)
							== false))
				{
					this.OnAhLocNameChanging(value);
					this._ahLocName = value;
					this.OnAhLocNameChanged();
				}
			}
		}

		[Column(Storage = "_ahManagedCareType", Name = "AH_MANAGED_CARE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhManagedCareType
		{
			get
			{
				return this._ahManagedCareType;
			}
			set
			{
				if (((_ahManagedCareType == value)
							== false))
				{
					this.OnAhManagedCareTypeChanging(value);
					this._ahManagedCareType = value;
					this.OnAhManagedCareTypeChanged();
				}
			}
		}

		[Column(Storage = "_ahName", Name = "AH_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhName
		{
			get
			{
				return this._ahName;
			}
			set
			{
				if (((_ahName == value)
							== false))
				{
					this.OnAhNameChanging(value);
					this._ahName = value;
					this.OnAhNameChanged();
				}
			}
		}

		[Column(Storage = "_ahNameFirst", Name = "AH_NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhNameFirst
		{
			get
			{
				return this._ahNameFirst;
			}
			set
			{
				if (((_ahNameFirst == value)
							== false))
				{
					this.OnAhNameFirstChanging(value);
					this._ahNameFirst = value;
					this.OnAhNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_ahNameLast", Name = "AH_NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhNameLast
		{
			get
			{
				return this._ahNameLast;
			}
			set
			{
				if (((_ahNameLast == value)
							== false))
				{
					this.OnAhNameLastChanging(value);
					this._ahNameLast = value;
					this.OnAhNameLastChanged();
				}
			}
		}

		[Column(Storage = "_ahNameMi", Name = "AH_NAME_MI", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhNameMi
		{
			get
			{
				return this._ahNameMi;
			}
			set
			{
				if (((_ahNameMi == value)
							== false))
				{
					this.OnAhNameMiChanging(value);
					this._ahNameMi = value;
					this.OnAhNameMiChanged();
				}
			}
		}

		[Column(Storage = "_ahNatureOfBusiness", Name = "AH_NATURE_OF_BUSINESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhNatureOfBusiness
		{
			get
			{
				return this._ahNatureOfBusiness;
			}
			set
			{
				if (((_ahNatureOfBusiness == value)
							== false))
				{
					this.OnAhNatureOfBusinessChanging(value);
					this._ahNatureOfBusiness = value;
					this.OnAhNatureOfBusinessChanged();
				}
			}
		}

		[Column(Storage = "_ahPhone", Name = "AH_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhPhone
		{
			get
			{
				return this._ahPhone;
			}
			set
			{
				if (((_ahPhone == value)
							== false))
				{
					this.OnAhPhoneChanging(value);
					this._ahPhone = value;
					this.OnAhPhoneChanged();
				}
			}
		}

		[Column(Storage = "_ahSecCode", Name = "AH_SEC_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhSecCode
		{
			get
			{
				return this._ahSecCode;
			}
			set
			{
				if (((_ahSecCode == value)
							== false))
				{
					this.OnAhSecCodeChanging(value);
					this._ahSecCode = value;
					this.OnAhSecCodeChanged();
				}
			}
		}

		[Column(Storage = "_ahSecName", Name = "AH_SEC_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhSecName
		{
			get
			{
				return this._ahSecName;
			}
			set
			{
				if (((_ahSecName == value)
							== false))
				{
					this.OnAhSecNameChanging(value);
					this._ahSecName = value;
					this.OnAhSecNameChanged();
				}
			}
		}

		[Column(Storage = "_ahSic", Name = "AH_SIC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhSic
		{
			get
			{
				return this._ahSic;
			}
			set
			{
				if (((_ahSic == value)
							== false))
				{
					this.OnAhSicChanging(value);
					this._ahSic = value;
					this.OnAhSicChanged();
				}
			}
		}

		[Column(Storage = "_ahSpecificDestnFlag", Name = "AH_SPECIFIC_DESTN_FLAG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhSpecificDestnFlag
		{
			get
			{
				return this._ahSpecificDestnFlag;
			}
			set
			{
				if (((_ahSpecificDestnFlag == value)
							== false))
				{
					this.OnAhSpecificDestnFlagChanging(value);
					this._ahSpecificDestnFlag = value;
					this.OnAhSpecificDestnFlagChanged();
				}
			}
		}

		[Column(Storage = "_ahState", Name = "AH_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhState
		{
			get
			{
				return this._ahState;
			}
			set
			{
				if (((_ahState == value)
							== false))
				{
					this.OnAhStateChanging(value);
					this._ahState = value;
					this.OnAhStateChanged();
				}
			}
		}

		[Column(Storage = "_ahSuID", Name = "AH_SUID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhSuId
		{
			get
			{
				return this._ahSuID;
			}
			set
			{
				if (((_ahSuID == value)
							== false))
				{
					this.OnAhSuIdChanging(value);
					this._ahSuID = value;
					this.OnAhSuIdChanged();
				}
			}
		}

		[Column(Storage = "_ahZip", Name = "AH_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AhZip
		{
			get
			{
				return this._ahZip;
			}
			set
			{
				if (((_ahZip == value)
							== false))
				{
					this.OnAhZipChanging(value);
					this._ahZip = value;
					this.OnAhZipChanged();
				}
			}
		}

		[Column(Storage = "_alAt", Name = "A_LAT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> ALat
		{
			get
			{
				return this._alAt;
			}
			set
			{
				if ((_alAt != value))
				{
					this.OnALatChanging(value);
					this._alAt = value;
					this.OnALatChanged();
				}
			}
		}

		[Column(Storage = "_alOn", Name = "A_LON", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> ALon
		{
			get
			{
				return this._alOn;
			}
			set
			{
				if ((_alOn != value))
				{
					this.OnALonChanging(value);
					this._alOn = value;
					this.OnALonChanged();
				}
			}
		}

		[Column(Storage = "_anAme", Name = "A_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AName
		{
			get
			{
				return this._anAme;
			}
			set
			{
				if (((_anAme == value)
							== false))
				{
					this.OnANameChanging(value);
					this._anAme = value;
					this.OnANameChanged();
				}
			}
		}

		[Column(Storage = "_anAmeFirst", Name = "A_NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ANameFirst
		{
			get
			{
				return this._anAmeFirst;
			}
			set
			{
				if (((_anAmeFirst == value)
							== false))
				{
					this.OnANameFirstChanging(value);
					this._anAmeFirst = value;
					this.OnANameFirstChanged();
				}
			}
		}

		[Column(Storage = "_anAmeLast", Name = "A_NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ANameLast
		{
			get
			{
				return this._anAmeLast;
			}
			set
			{
				if (((_anAmeLast == value)
							== false))
				{
					this.OnANameLastChanging(value);
					this._anAmeLast = value;
					this.OnANameLastChanged();
				}
			}
		}

		[Column(Storage = "_anAmeMi", Name = "A_NAME_MI", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ANameMi
		{
			get
			{
				return this._anAmeMi;
			}
			set
			{
				if (((_anAmeMi == value)
							== false))
				{
					this.OnANameMiChanging(value);
					this._anAmeMi = value;
					this.OnANameMiChanged();
				}
			}
		}

		[Column(Storage = "_apHone", Name = "A_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string APhone
		{
			get
			{
				return this._apHone;
			}
			set
			{
				if (((_apHone == value)
							== false))
				{
					this.OnAPhoneChanging(value);
					this._apHone = value;
					this.OnAPhoneChanged();
				}
			}
		}

		[Column(Storage = "_apHoneExt", Name = "A_PHONE_EXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string APhoneExt
		{
			get
			{
				return this._apHoneExt;
			}
			set
			{
				if (((_apHoneExt == value)
							== false))
				{
					this.OnAPhoneExtChanging(value);
					this._apHoneExt = value;
					this.OnAPhoneExtChanged();
				}
			}
		}

		[Column(Storage = "_apRefInd", Name = "A_PREF_IND", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string APrefInd
		{
			get
			{
				return this._apRefInd;
			}
			set
			{
				if (((_apRefInd == value)
							== false))
				{
					this.OnAPrefIndChanging(value);
					this._apRefInd = value;
					this.OnAPrefIndChanged();
				}
			}
		}

		[Column(Storage = "_asTate", Name = "A_STATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AState
		{
			get
			{
				return this._asTate;
			}
			set
			{
				if (((_asTate == value)
							== false))
				{
					this.OnAStateChanging(value);
					this._asTate = value;
					this.OnAStateChanged();
				}
			}
		}

		[Column(Storage = "_asTatus", Name = "A_STATUS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AStatus
		{
			get
			{
				return this._asTatus;
			}
			set
			{
				if (((_asTatus == value)
							== false))
				{
					this.OnAStatusChanging(value);
					this._asTatus = value;
					this.OnAStatusChanged();
				}
			}
		}

		[Column(Storage = "_atYpeCode", Name = "A_TYPECD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ATypeCode
		{
			get
			{
				return this._atYpeCode;
			}
			set
			{
				if (((_atYpeCode == value)
							== false))
				{
					this.OnATypeCodeChanging(value);
					this._atYpeCode = value;
					this.OnATypeCodeChanged();
				}
			}
		}

		[Column(Storage = "_azIpcode", Name = "A_ZIPCODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AZipcode
		{
			get
			{
				return this._azIpcode;
			}
			set
			{
				if (((_azIpcode == value)
							== false))
				{
					this.OnAZipcodeChanging(value);
					this._azIpcode = value;
					this.OnAZipcodeChanged();
				}
			}
		}

		[Column(Storage = "_baDdress1", Name = "B_ADDRESS_1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BAddress1
		{
			get
			{
				return this._baDdress1;
			}
			set
			{
				if (((_baDdress1 == value)
							== false))
				{
					this.OnBAddress1Changing(value);
					this._baDdress1 = value;
					this.OnBAddress1Changed();
				}
			}
		}

		[Column(Storage = "_baDdress2", Name = "B_ADDRESS_2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BAddress2
		{
			get
			{
				return this._baDdress2;
			}
			set
			{
				if (((_baDdress2 == value)
							== false))
				{
					this.OnBAddress2Changing(value);
					this._baDdress2 = value;
					this.OnBAddress2Changed();
				}
			}
		}

		[Column(Storage = "_baLtContactFnAme", Name = "B_ALT_CONTACT_F_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BAltContactFName
		{
			get
			{
				return this._baLtContactFnAme;
			}
			set
			{
				if (((_baLtContactFnAme == value)
							== false))
				{
					this.OnBAltContactFNameChanging(value);
					this._baLtContactFnAme = value;
					this.OnBAltContactFNameChanged();
				}
			}
		}

		[Column(Storage = "_baLtContactLnAme", Name = "B_ALT_CONTACT_L_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BAltContactLName
		{
			get
			{
				return this._baLtContactLnAme;
			}
			set
			{
				if (((_baLtContactLnAme == value)
							== false))
				{
					this.OnBAltContactLNameChanging(value);
					this._baLtContactLnAme = value;
					this.OnBAltContactLNameChanged();
				}
			}
		}

		[Column(Storage = "_baLtPhone", Name = "B_ALT_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BAltPhone
		{
			get
			{
				return this._baLtPhone;
			}
			set
			{
				if (((_baLtPhone == value)
							== false))
				{
					this.OnBAltPhoneChanging(value);
					this._baLtPhone = value;
					this.OnBAltPhoneChanged();
				}
			}
		}

		[Column(Storage = "_bbAckupFax", Name = "B_BACKUP_FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BBackupFax
		{
			get
			{
				return this._bbAckupFax;
			}
			set
			{
				if (((_bbAckupFax == value)
							== false))
				{
					this.OnBBackupFaxChanging(value);
					this._bbAckupFax = value;
					this.OnBBackupFaxChanged();
				}
			}
		}

		[Column(Storage = "_bbRanchNumber", Name = "B_BRANCH_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BBranchNumber
		{
			get
			{
				return this._bbRanchNumber;
			}
			set
			{
				if (((_bbRanchNumber == value)
							== false))
				{
					this.OnBBranchNumberChanging(value);
					this._bbRanchNumber = value;
					this.OnBBranchNumberChanged();
				}
			}
		}

		[Column(Storage = "_bbRanchType", Name = "B_BRANCH_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BBranchType
		{
			get
			{
				return this._bbRanchType;
			}
			set
			{
				if (((_bbRanchType == value)
							== false))
				{
					this.OnBBranchTypeChanging(value);
					this._bbRanchType = value;
					this.OnBBranchTypeChanged();
				}
			}
		}

		[Column(Storage = "_bcIty", Name = "B_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BCity
		{
			get
			{
				return this._bcIty;
			}
			set
			{
				if (((_bcIty == value)
							== false))
				{
					this.OnBCityChanging(value);
					this._bcIty = value;
					this.OnBCityChanged();
				}
			}
		}

		[Column(Storage = "_bcOntactFnAme", Name = "B_CONTACT_F_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BContactFName
		{
			get
			{
				return this._bcOntactFnAme;
			}
			set
			{
				if (((_bcOntactFnAme == value)
							== false))
				{
					this.OnBContactFNameChanging(value);
					this._bcOntactFnAme = value;
					this.OnBContactFNameChanged();
				}
			}
		}

		[Column(Storage = "_bcOntactLnAme", Name = "B_CONTACT_L_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BContactLName
		{
			get
			{
				return this._bcOntactLnAme;
			}
			set
			{
				if (((_bcOntactLnAme == value)
							== false))
				{
					this.OnBContactLNameChanging(value);
					this._bcOntactLnAme = value;
					this.OnBContactLNameChanged();
				}
			}
		}

		[Column(Storage = "_bcOntactTitle", Name = "B_CONTACT_TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BContactTitle
		{
			get
			{
				return this._bcOntactTitle;
			}
			set
			{
				if (((_bcOntactTitle == value)
							== false))
				{
					this.OnBContactTitleChanging(value);
					this._bcOntactTitle = value;
					this.OnBContactTitleChanged();
				}
			}
		}

		[Column(Storage = "_bcOuntry", Name = "B_COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BCountry
		{
			get
			{
				return this._bcOuntry;
			}
			set
			{
				if (((_bcOuntry == value)
							== false))
				{
					this.OnBCountryChanging(value);
					this._bcOuntry = value;
					this.OnBCountryChanged();
				}
			}
		}

		[Column(Storage = "_bfAx", Name = "B_FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BFax
		{
			get
			{
				return this._bfAx;
			}
			set
			{
				if (((_bfAx == value)
							== false))
				{
					this.OnBFaxChanging(value);
					this._bfAx = value;
					this.OnBFaxChanged();
				}
			}
		}

		[Column(Storage = "_bfOreignZip", Name = "B_FOREIGN_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BForeignZip
		{
			get
			{
				return this._bfOreignZip;
			}
			set
			{
				if (((_bfOreignZip == value)
							== false))
				{
					this.OnBForeignZipChanging(value);
					this._bfOreignZip = value;
					this.OnBForeignZipChanged();
				}
			}
		}

		[Column(Storage = "_blAt", Name = "B_LAT", DbType = "FLOAT", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> BLat
		{
			get
			{
				return this._blAt;
			}
			set
			{
				if ((_blAt != value))
				{
					this.OnBLatChanging(value);
					this._blAt = value;
					this.OnBLatChanged();
				}
			}
		}

		[Column(Storage = "_blOn", Name = "B_LON", DbType = "FLOAT", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> BLon
		{
			get
			{
				return this._blOn;
			}
			set
			{
				if ((_blOn != value))
				{
					this.OnBLonChanging(value);
					this._blOn = value;
					this.OnBLonChanged();
				}
			}
		}

		[Column(Storage = "_bnOtes", Name = "B_NOTES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BNotes
		{
			get
			{
				return this._bnOtes;
			}
			set
			{
				if (((_bnOtes == value)
							== false))
				{
					this.OnBNotesChanging(value);
					this._bnOtes = value;
					this.OnBNotesChanged();
				}
			}
		}

		[Column(Storage = "_boFficeName", Name = "B_OFFICE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BOfficeName
		{
			get
			{
				return this._boFficeName;
			}
			set
			{
				if (((_boFficeName == value)
							== false))
				{
					this.OnBOfficeNameChanging(value);
					this._boFficeName = value;
					this.OnBOfficeNameChanged();
				}
			}
		}

		[Column(Storage = "_boFficeNumber", Name = "B_OFFICE_NUMBER", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> BOfficeNumber
		{
			get
			{
				return this._boFficeNumber;
			}
			set
			{
				if ((_boFficeNumber != value))
				{
					this.OnBOfficeNumberChanging(value);
					this._boFficeNumber = value;
					this.OnBOfficeNumberChanged();
				}
			}
		}

		[Column(Storage = "_boFficeType", Name = "B_OFFICE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BOfficeType
		{
			get
			{
				return this._boFficeType;
			}
			set
			{
				if (((_boFficeType == value)
							== false))
				{
					this.OnBOfficeTypeChanging(value);
					this._boFficeType = value;
					this.OnBOfficeTypeChanged();
				}
			}
		}

		[Column(Storage = "_boVernightAddress1", Name = "B_OVERNIGHT_ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BOvernightAddress1
		{
			get
			{
				return this._boVernightAddress1;
			}
			set
			{
				if (((_boVernightAddress1 == value)
							== false))
				{
					this.OnBOvernightAddress1Changing(value);
					this._boVernightAddress1 = value;
					this.OnBOvernightAddress1Changed();
				}
			}
		}

		[Column(Storage = "_boVernightAddress2", Name = "B_OVERNIGHT_ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BOvernightAddress2
		{
			get
			{
				return this._boVernightAddress2;
			}
			set
			{
				if (((_boVernightAddress2 == value)
							== false))
				{
					this.OnBOvernightAddress2Changing(value);
					this._boVernightAddress2 = value;
					this.OnBOvernightAddress2Changed();
				}
			}
		}

		[Column(Storage = "_boVernightAddressCity", Name = "B_OVERNIGHT_ADDRESS_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BOvernightAddressCity
		{
			get
			{
				return this._boVernightAddressCity;
			}
			set
			{
				if (((_boVernightAddressCity == value)
							== false))
				{
					this.OnBOvernightAddressCityChanging(value);
					this._boVernightAddressCity = value;
					this.OnBOvernightAddressCityChanged();
				}
			}
		}

		[Column(Storage = "_boVernightAddressState", Name = "B_OVERNIGHT_ADDRESS_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BOvernightAddressState
		{
			get
			{
				return this._boVernightAddressState;
			}
			set
			{
				if (((_boVernightAddressState == value)
							== false))
				{
					this.OnBOvernightAddressStateChanging(value);
					this._boVernightAddressState = value;
					this.OnBOvernightAddressStateChanged();
				}
			}
		}

		[Column(Storage = "_boVernightAddressZip", Name = "B_OVERNIGHT_ADDRESS_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BOvernightAddressZip
		{
			get
			{
				return this._boVernightAddressZip;
			}
			set
			{
				if (((_boVernightAddressZip == value)
							== false))
				{
					this.OnBOvernightAddressZipChanging(value);
					this._boVernightAddressZip = value;
					this.OnBOvernightAddressZipChanged();
				}
			}
		}

		[Column(Storage = "_bpHone", Name = "B_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BPhone
		{
			get
			{
				return this._bpHone;
			}
			set
			{
				if (((_bpHone == value)
							== false))
				{
					this.OnBPhoneChanging(value);
					this._bpHone = value;
					this.OnBPhoneChanged();
				}
			}
		}

		[Column(Storage = "_bsTate", Name = "B_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BState
		{
			get
			{
				return this._bsTate;
			}
			set
			{
				if (((_bsTate == value)
							== false))
				{
					this.OnBStateChanging(value);
					this._bsTate = value;
					this.OnBStateChanged();
				}
			}
		}

		[Column(Storage = "_bsTatus", Name = "B_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BStatus
		{
			get
			{
				return this._bsTatus;
			}
			set
			{
				if (((_bsTatus == value)
							== false))
				{
					this.OnBStatusChanging(value);
					this._bsTatus = value;
					this.OnBStatusChanged();
				}
			}
		}

		[Column(Storage = "_bzIp", Name = "B_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BZip
		{
			get
			{
				return this._bzIp;
			}
			set
			{
				if (((_bzIp == value)
							== false))
				{
					this.OnBZipChanging(value);
					this._bzIp = value;
					this.OnBZipChanged();
				}
			}
		}

		[Column(Storage = "_caDdress1", Name = "C_ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CAddress1
		{
			get
			{
				return this._caDdress1;
			}
			set
			{
				if (((_caDdress1 == value)
							== false))
				{
					this.OnCAddress1Changing(value);
					this._caDdress1 = value;
					this.OnCAddress1Changed();
				}
			}
		}

		[Column(Storage = "_caDdress2", Name = "C_ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CAddress2
		{
			get
			{
				return this._caDdress2;
			}
			set
			{
				if (((_caDdress2 == value)
							== false))
				{
					this.OnCAddress2Changing(value);
					this._caDdress2 = value;
					this.OnCAddress2Changed();
				}
			}
		}

		[Column(Storage = "_cbUreauCode", Name = "C_BUREAU_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CBureauCode
		{
			get
			{
				return this._cbUreauCode;
			}
			set
			{
				if (((_cbUreauCode == value)
							== false))
				{
					this.OnCBureauCodeChanging(value);
					this._cbUreauCode = value;
					this.OnCBureauCodeChanged();
				}
			}
		}

		[Column(Storage = "_cbUsinessType", Name = "C_BUSINESS_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CBusinessType
		{
			get
			{
				return this._cbUsinessType;
			}
			set
			{
				if (((_cbUsinessType == value)
							== false))
				{
					this.OnCBusinessTypeChanging(value);
					this._cbUsinessType = value;
					this.OnCBusinessTypeChanged();
				}
			}
		}

		[Column(Storage = "_ccArrierNumber", Name = "C_CARRIER_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CCarrierNumber
		{
			get
			{
				return this._ccArrierNumber;
			}
			set
			{
				if (((_ccArrierNumber == value)
							== false))
				{
					this.OnCCarrierNumberChanging(value);
					this._ccArrierNumber = value;
					this.OnCCarrierNumberChanged();
				}
			}
		}

		[Column(Storage = "_ccIty", Name = "C_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CCity
		{
			get
			{
				return this._ccIty;
			}
			set
			{
				if (((_ccIty == value)
							== false))
				{
					this.OnCCityChanging(value);
					this._ccIty = value;
					this.OnCCityChanged();
				}
			}
		}

		[Column(Storage = "_cfEin", Name = "C_FEIN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CFein
		{
			get
			{
				return this._cfEin;
			}
			set
			{
				if (((_cfEin == value)
							== false))
				{
					this.OnCFeinChanging(value);
					this._cfEin = value;
					this.OnCFeinChanged();
				}
			}
		}

		[Column(Storage = "_cnAme", Name = "C_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CName
		{
			get
			{
				return this._cnAme;
			}
			set
			{
				if (((_cnAme == value)
							== false))
				{
					this.OnCNameChanging(value);
					this._cnAme = value;
					this.OnCNameChanged();
				}
			}
		}

		[Column(Storage = "_cpHone", Name = "C_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CPhone
		{
			get
			{
				return this._cpHone;
			}
			set
			{
				if (((_cpHone == value)
							== false))
				{
					this.OnCPhoneChanging(value);
					this._cpHone = value;
					this.OnCPhoneChanged();
				}
			}
		}

		[Column(Storage = "_csTate", Name = "C_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CState
		{
			get
			{
				return this._csTate;
			}
			set
			{
				if (((_csTate == value)
							== false))
				{
					this.OnCStateChanging(value);
					this._csTate = value;
					this.OnCStateChanged();
				}
			}
		}

		[Column(Storage = "_ctItle", Name = "C_TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CTitle
		{
			get
			{
				return this._ctItle;
			}
			set
			{
				if (((_ctItle == value)
							== false))
				{
					this.OnCTitleChanging(value);
					this._ctItle = value;
					this.OnCTitleChanged();
				}
			}
		}

		[Column(Storage = "_czIp", Name = "C_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CZip
		{
			get
			{
				return this._czIp;
			}
			set
			{
				if (((_czIp == value)
							== false))
				{
					this.OnCZipChanging(value);
					this._czIp = value;
					this.OnCZipChanged();
				}
			}
		}

		[Column(Storage = "_paDditionalDeliveries", Name = "P_ADDITIONAL_DELIVERIES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PAdditionalDeliveries
		{
			get
			{
				return this._paDditionalDeliveries;
			}
			set
			{
				if (((_paDditionalDeliveries == value)
							== false))
				{
					this.OnPAdditionalDeliveriesChanging(value);
					this._paDditionalDeliveries = value;
					this.OnPAdditionalDeliveriesChanged();
				}
			}
		}

		[Column(Storage = "_pcAncellationDate", Name = "P_CANCELLATION_DATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PCancellationDate
		{
			get
			{
				return this._pcAncellationDate;
			}
			set
			{
				if (((_pcAncellationDate == value)
							== false))
				{
					this.OnPCancellationDateChanging(value);
					this._pcAncellationDate = value;
					this.OnPCancellationDateChanged();
				}
			}
		}

		[Column(Storage = "_pcHangeDate", Name = "P_CHANGE_DATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PChangeDate
		{
			get
			{
				return this._pcHangeDate;
			}
			set
			{
				if (((_pcHangeDate == value)
							== false))
				{
					this.OnPChangeDateChanging(value);
					this._pcHangeDate = value;
					this.OnPChangeDateChanged();
				}
			}
		}

		[Column(Storage = "_pcOmpanyCode", Name = "P_COMPANY_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PCompanyCode
		{
			get
			{
				return this._pcOmpanyCode;
			}
			set
			{
				if (((_pcOmpanyCode == value)
							== false))
				{
					this.OnPCompanyCodeChanging(value);
					this._pcOmpanyCode = value;
					this.OnPCompanyCodeChanged();
				}
			}
		}

		[Column(Storage = "_pdIvisionCode", Name = "P_DIVISION_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PDivisionCode
		{
			get
			{
				return this._pdIvisionCode;
			}
			set
			{
				if (((_pdIvisionCode == value)
							== false))
				{
					this.OnPDivisionCodeChanging(value);
					this._pdIvisionCode = value;
					this.OnPDivisionCodeChanged();
				}
			}
		}

		[Column(Storage = "_peFfectiveDate", Name = "P_EFFECTIVE_DATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PEffectiveDate
		{
			get
			{
				return this._peFfectiveDate;
			}
			set
			{
				if (((_peFfectiveDate == value)
							== false))
				{
					this.OnPEffectiveDateChanging(value);
					this._peFfectiveDate = value;
					this.OnPEffectiveDateChanged();
				}
			}
		}

		[Column(Storage = "_peXpirationDate", Name = "P_EXPIRATION_DATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PExpirationDate
		{
			get
			{
				return this._peXpirationDate;
			}
			set
			{
				if (((_peXpirationDate == value)
							== false))
				{
					this.OnPExpirationDateChanging(value);
					this._peXpirationDate = value;
					this.OnPExpirationDateChanged();
				}
			}
		}

		[Column(Storage = "_plOadDate", Name = "P_LOAD_DATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PLoadDate
		{
			get
			{
				return this._plOadDate;
			}
			set
			{
				if (((_plOadDate == value)
							== false))
				{
					this.OnPLoadDateChanging(value);
					this._plOadDate = value;
					this.OnPLoadDateChanged();
				}
			}
		}

		[Column(Storage = "_pmAnagedCareType", Name = "P_MANAGED_CARE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string PManagedCareType
		{
			get
			{
				return this._pmAnagedCareType;
			}
			set
			{
				if (((_pmAnagedCareType == value)
							== false))
				{
					this.OnPManagedCareTypeChanging(value);
					this._pmAnagedCareType = value;
					this.OnPManagedCareTypeChanged();
				}
			}
		}

		[Column(Storage = "_poRiginalEffectiveDate", Name = "P_ORIGINAL_EFFECTIVE_DATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string POriginalEffectiveDate
		{
			get
			{
				return this._poRiginalEffectiveDate;
			}
			set
			{
				if (((_poRiginalEffectiveDate == value)
							== false))
				{
					this.OnPOriginalEffectiveDateChanging(value);
					this._poRiginalEffectiveDate = value;
					this.OnPOriginalEffectiveDateChanged();
				}
			}
		}

		[Column(Storage = "_ppOlicyCovCodes", Name = "P_POLICY_COV_CODES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PPolicyCovCodes
		{
			get
			{
				return this._ppOlicyCovCodes;
			}
			set
			{
				if (((_ppOlicyCovCodes == value)
							== false))
				{
					this.OnPPolicyCovCodesChanging(value);
					this._ppOlicyCovCodes = value;
					this.OnPPolicyCovCodesChanged();
				}
			}
		}

		[Column(Storage = "_ppOlicyDecription", Name = "P_POLICY_DESC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PPolicyDecription
		{
			get
			{
				return this._ppOlicyDecription;
			}
			set
			{
				if (((_ppOlicyDecription == value)
							== false))
				{
					this.OnPPolicyDecriptionChanging(value);
					this._ppOlicyDecription = value;
					this.OnPPolicyDecriptionChanged();
				}
			}
		}

		[Column(Storage = "_ppOlicyID", Name = "P_POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long PPolicyId
		{
			get
			{
				return this._ppOlicyID;
			}
			set
			{
				if ((_ppOlicyID != value))
				{
					this.OnPPolicyIdChanging(value);
					this._ppOlicyID = value;
					this.OnPPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_ppOlicyNumber", Name = "P_POLICY_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PPolicyNumber
		{
			get
			{
				return this._ppOlicyNumber;
			}
			set
			{
				if (((_ppOlicyNumber == value)
							== false))
				{
					this.OnPPolicyNumberChanging(value);
					this._ppOlicyNumber = value;
					this.OnPPolicyNumberChanged();
				}
			}
		}

		[Column(Storage = "_ppOlicyType", Name = "P_POLICY_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PPolicyType
		{
			get
			{
				return this._ppOlicyType;
			}
			set
			{
				if (((_ppOlicyType == value)
							== false))
				{
					this.OnPPolicyTypeChanging(value);
					this._ppOlicyType = value;
					this.OnPPolicyTypeChanged();
				}
			}
		}

		[Column(Storage = "_psElfInsured", Name = "P_SELF_INSURED", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string PSelfInsured
		{
			get
			{
				return this._psElfInsured;
			}
			set
			{
				if (((_psElfInsured == value)
							== false))
				{
					this.OnPSelfInsuredChanging(value);
					this._psElfInsured = value;
					this.OnPSelfInsuredChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHS_EXCEPTION")]
	public partial class AhsException
	{

		private long _accntHrcyStepID;

		private long _ahsExceptionID;

		private System.DateTime _exceptionEndDate;

		private System.DateTime _exceptionStartDate;

		private string _lobCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAhsExceptionIdChanged();

		partial void OnAhsExceptionIdChanging(long value);

		partial void OnExceptionEndDateChanged();

		partial void OnExceptionEndDateChanging(System.DateTime value);

		partial void OnExceptionStartDateChanged();

		partial void OnExceptionStartDateChanging(System.DateTime value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);
		#endregion


		public AhsException()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_ahsExceptionID", Name = "AHS_EXCEPTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhsExceptionId
		{
			get
			{
				return this._ahsExceptionID;
			}
			set
			{
				if ((_ahsExceptionID != value))
				{
					this.OnAhsExceptionIdChanging(value);
					this._ahsExceptionID = value;
					this.OnAhsExceptionIdChanged();
				}
			}
		}

		[Column(Storage = "_exceptionEndDate", Name = "EXCEPTION_END_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ExceptionEndDate
		{
			get
			{
				return this._exceptionEndDate;
			}
			set
			{
				if ((_exceptionEndDate != value))
				{
					this.OnExceptionEndDateChanging(value);
					this._exceptionEndDate = value;
					this.OnExceptionEndDateChanged();
				}
			}
		}

		[Column(Storage = "_exceptionStartDate", Name = "EXCEPTION_START_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ExceptionStartDate
		{
			get
			{
				return this._exceptionStartDate;
			}
			set
			{
				if ((_exceptionStartDate != value))
				{
					this.OnExceptionStartDateChanging(value);
					this._exceptionStartDate = value;
					this.OnExceptionStartDateChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHS_EXTENSION")]
	public partial class AhsExtension
	{

		private System.Nullable<long> _accntHrcyStepID;

		private long _ahsExtensionID;

		private string _fieldName;

		private string _fieldValue;

		private System.Nullable<long> _fileTransmissionLogID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnAhsExtensionIdChanged();

		partial void OnAhsExtensionIdChanging(long value);

		partial void OnFieldNameChanged();

		partial void OnFieldNameChanging(string value);

		partial void OnFieldValueChanged();

		partial void OnFieldValueChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);
		#endregion


		public AhsExtension()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_ahsExtensionID", Name = "AHS_EXTENSION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhsExtensionId
		{
			get
			{
				return this._ahsExtensionID;
			}
			set
			{
				if ((_ahsExtensionID != value))
				{
					this.OnAhsExtensionIdChanging(value);
					this._ahsExtensionID = value;
					this.OnAhsExtensionIdChanged();
				}
			}
		}

		[Column(Storage = "_fieldName", Name = "FIELD_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FieldName
		{
			get
			{
				return this._fieldName;
			}
			set
			{
				if (((_fieldName == value)
							== false))
				{
					this.OnFieldNameChanging(value);
					this._fieldName = value;
					this.OnFieldNameChanged();
				}
			}
		}

		[Column(Storage = "_fieldValue", Name = "FIELD_VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FieldValue
		{
			get
			{
				return this._fieldValue;
			}
			set
			{
				if (((_fieldValue == value)
							== false))
				{
					this.OnFieldValueChanging(value);
					this._fieldValue = value;
					this.OnFieldValueChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHS_OWNER")]
	public partial class AhsOwner
	{

		private long _accntHrcyStepID;

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private long _ahsOwnerID;

		private System.Nullable<long> _fileTransmissionLogID;

		private long _ownerID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAhsOwnerIdChanged();

		partial void OnAhsOwnerIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnOwnerIdChanged();

		partial void OnOwnerIdChanging(long value);
		#endregion


		public AhsOwner()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_ahsOwnerID", Name = "AHS_OWNER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhsOwnerId
		{
			get
			{
				return this._ahsOwnerID;
			}
			set
			{
				if ((_ahsOwnerID != value))
				{
					this.OnAhsOwnerIdChanging(value);
					this._ahsOwnerID = value;
					this.OnAhsOwnerIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_ownerID", Name = "OWNER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OwnerId
		{
			get
			{
				return this._ownerID;
			}
			set
			{
				if ((_ownerID != value))
				{
					this.OnOwnerIdChanging(value);
					this._ownerID = value;
					this.OnOwnerIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHS_POLICY")]
	public partial class AhsPolicy
	{

		private long _accntHrcyStepID;

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private long _ahsPolicyID;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _lobCode;

		private long _policyID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAhsPolicyIdChanged();

		partial void OnAhsPolicyIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnPolicyIdChanged();

		partial void OnPolicyIdChanging(long value);
		#endregion


		public AhsPolicy()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_ahsPolicyID", Name = "AHS_POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhsPolicyId
		{
			get
			{
				return this._ahsPolicyID;
			}
			set
			{
				if ((_ahsPolicyID != value))
				{
					this.OnAhsPolicyIdChanging(value);
					this._ahsPolicyID = value;
					this.OnAhsPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_policyID", Name = "POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long PolicyId
		{
			get
			{
				return this._policyID;
			}
			set
			{
				if ((_policyID != value))
				{
					this.OnPolicyIdChanging(value);
					this._policyID = value;
					this.OnPolicyIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.AHS_VALID_RULES")]
	public partial class AhsValidRules
	{

		private long _accntHrcyStepID;

		private long _ruleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(long value);
		#endregion


		public AhsValidRules()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ALTERNATE_CONTACT_NAME")]
	public partial class AlternateContactName
	{

		private long _alternateContactNameID;

		private long _contactID;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _name;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAlternateContactNameIdChanged();

		partial void OnAlternateContactNameIdChanging(long value);

		partial void OnContactIdChanged();

		partial void OnContactIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);
		#endregion


		public AlternateContactName()
		{
			this.OnCreated();
		}

		[Column(Storage = "_alternateContactNameID", Name = "ALTERNATE_CONTACT_NAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AlternateContactNameId
		{
			get
			{
				return this._alternateContactNameID;
			}
			set
			{
				if ((_alternateContactNameID != value))
				{
					this.OnAlternateContactNameIdChanging(value);
					this._alternateContactNameID = value;
					this.OnAlternateContactNameIdChanged();
				}
			}
		}

		[Column(Storage = "_contactID", Name = "CONTACT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ContactId
		{
			get
			{
				return this._contactID;
			}
			set
			{
				if ((_contactID != value))
				{
					this.OnContactIdChanging(value);
					this._contactID = value;
					this.OnContactIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ALTERNATE_DESTINATION")]
	public partial class AlternateDestination
	{

		private string _altDestinationString;

		private long _alternateDestinationID;

		private string _altTransmissionType;

		private string _comments;

		private System.DateTime _createdDate;

		private string _fnsClientCode;

		private System.DateTime _modifiedDate;

		private string _origDestinationString;

		private string _origTransmissionType;

		private string _status;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAltDestinationStringChanged();

		partial void OnAltDestinationStringChanging(string value);

		partial void OnAlternateDestinationIdChanged();

		partial void OnAlternateDestinationIdChanging(long value);

		partial void OnAltTransmissionTypeChanged();

		partial void OnAltTransmissionTypeChanging(string value);

		partial void OnCommentsChanged();

		partial void OnCommentsChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnFnsClientCodeChanged();

		partial void OnFnsClientCodeChanging(string value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.DateTime value);

		partial void OnOrigDestinationStringChanged();

		partial void OnOrigDestinationStringChanging(string value);

		partial void OnOrigTransmissionTypeChanged();

		partial void OnOrigTransmissionTypeChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);
		#endregion


		public AlternateDestination()
		{
			this.OnCreated();
		}

		[Column(Storage = "_altDestinationString", Name = "ALT_DESTINATION_STRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AltDestinationString
		{
			get
			{
				return this._altDestinationString;
			}
			set
			{
				if (((_altDestinationString == value)
							== false))
				{
					this.OnAltDestinationStringChanging(value);
					this._altDestinationString = value;
					this.OnAltDestinationStringChanged();
				}
			}
		}

		[Column(Storage = "_alternateDestinationID", Name = "ALTERNATE_DESTINATION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AlternateDestinationId
		{
			get
			{
				return this._alternateDestinationID;
			}
			set
			{
				if ((_alternateDestinationID != value))
				{
					this.OnAlternateDestinationIdChanging(value);
					this._alternateDestinationID = value;
					this.OnAlternateDestinationIdChanged();
				}
			}
		}

		[Column(Storage = "_altTransmissionType", Name = "ALT_TRANSMISSION_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AltTransmissionType
		{
			get
			{
				return this._altTransmissionType;
			}
			set
			{
				if (((_altTransmissionType == value)
							== false))
				{
					this.OnAltTransmissionTypeChanging(value);
					this._altTransmissionType = value;
					this.OnAltTransmissionTypeChanged();
				}
			}
		}

		[Column(Storage = "_comments", Name = "COMMENTS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				if (((_comments == value)
							== false))
				{
					this.OnCommentsChanging(value);
					this._comments = value;
					this.OnCommentsChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_fnsClientCode", Name = "FNS_CLIENT_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FnsClientCode
		{
			get
			{
				return this._fnsClientCode;
			}
			set
			{
				if (((_fnsClientCode == value)
							== false))
				{
					this.OnFnsClientCodeChanging(value);
					this._fnsClientCode = value;
					this.OnFnsClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_origDestinationString", Name = "ORIG_DESTINATION_STRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string OrigDestinationString
		{
			get
			{
				return this._origDestinationString;
			}
			set
			{
				if (((_origDestinationString == value)
							== false))
				{
					this.OnOrigDestinationStringChanging(value);
					this._origDestinationString = value;
					this.OnOrigDestinationStringChanged();
				}
			}
		}

		[Column(Storage = "_origTransmissionType", Name = "ORIG_TRANSMISSION_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string OrigTransmissionType
		{
			get
			{
				return this._origTransmissionType;
			}
			set
			{
				if (((_origTransmissionType == value)
							== false))
				{
					this.OnOrigTransmissionTypeChanging(value);
					this._origTransmissionType = value;
					this.OnOrigTransmissionTypeChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ALTERNATE_NAME")]
	public partial class AlternateName
	{

		private long _accntHrcyStepID;

		private long _alternateNameID;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _name;

		private System.Nullable<long> _policyID;

		private string _sequenceNumber;

		private string _uploadKey;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAlternateNameIdChanged();

		partial void OnAlternateNameIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPolicyIdChanged();

		partial void OnPolicyIdChanging(System.Nullable<long> value);

		partial void OnSequenceNumberChanged();

		partial void OnSequenceNumberChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);
		#endregion


		public AlternateName()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_alternateNameID", Name = "ALTERNATE_NAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AlternateNameId
		{
			get
			{
				return this._alternateNameID;
			}
			set
			{
				if ((_alternateNameID != value))
				{
					this.OnAlternateNameIdChanging(value);
					this._alternateNameID = value;
					this.OnAlternateNameIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_policyID", Name = "POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PolicyId
		{
			get
			{
				return this._policyID;
			}
			set
			{
				if ((_policyID != value))
				{
					this.OnPolicyIdChanging(value);
					this._policyID = value;
					this.OnPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_sequenceNumber", Name = "SEQUENCE_NUMBER", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SequenceNumber
		{
			get
			{
				return this._sequenceNumber;
			}
			set
			{
				if (((_sequenceNumber == value)
							== false))
				{
					this.OnSequenceNumberChanging(value);
					this._sequenceNumber = value;
					this.OnSequenceNumberChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ALTERNATE_OWNER_NAME")]
	public partial class AlternateOwnerName
	{

		private long _alternateOwnerNameID;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _name;

		private long _ownerID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAlternateOwnerNameIdChanged();

		partial void OnAlternateOwnerNameIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnOwnerIdChanged();

		partial void OnOwnerIdChanging(long value);
		#endregion


		public AlternateOwnerName()
		{
			this.OnCreated();
		}

		[Column(Storage = "_alternateOwnerNameID", Name = "ALTERNATE_OWNER_NAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AlternateOwnerNameId
		{
			get
			{
				return this._alternateOwnerNameID;
			}
			set
			{
				if ((_alternateOwnerNameID != value))
				{
					this.OnAlternateOwnerNameIdChanging(value);
					this._alternateOwnerNameID = value;
					this.OnAlternateOwnerNameIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_ownerID", Name = "OWNER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OwnerId
		{
			get
			{
				return this._ownerID;
			}
			set
			{
				if ((_ownerID != value))
				{
					this.OnOwnerIdChanging(value);
					this._ownerID = value;
					this.OnOwnerIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.APPLICATION_LOG")]
	public partial class ApplicationLog
	{

		private long _applicationLogID;

		private string _component;

		private System.DateTime _createdDate;

		private string _errorstring;

		private string _server;

		private System.Nullable<long> _serverity;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnApplicationLogIdChanged();

		partial void OnApplicationLogIdChanging(long value);

		partial void OnComponentChanged();

		partial void OnComponentChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnErrorstringChanged();

		partial void OnErrorstringChanging(string value);

		partial void OnServerChanged();

		partial void OnServerChanging(string value);

		partial void OnServerityChanged();

		partial void OnServerityChanging(System.Nullable<long> value);
		#endregion


		public ApplicationLog()
		{
			this.OnCreated();
		}

		[Column(Storage = "_applicationLogID", Name = "APPLICATION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ApplicationLogId
		{
			get
			{
				return this._applicationLogID;
			}
			set
			{
				if ((_applicationLogID != value))
				{
					this.OnApplicationLogIdChanging(value);
					this._applicationLogID = value;
					this.OnApplicationLogIdChanged();
				}
			}
		}

		[Column(Storage = "_component", Name = "COMPONENT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Component
		{
			get
			{
				return this._component;
			}
			set
			{
				if (((_component == value)
							== false))
				{
					this.OnComponentChanging(value);
					this._component = value;
					this.OnComponentChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_errorstring", Name = "ERRORSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Errorstring
		{
			get
			{
				return this._errorstring;
			}
			set
			{
				if (((_errorstring == value)
							== false))
				{
					this.OnErrorstringChanging(value);
					this._errorstring = value;
					this.OnErrorstringChanged();
				}
			}
		}

		[Column(Storage = "_server", Name = "SERVER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Server
		{
			get
			{
				return this._server;
			}
			set
			{
				if (((_server == value)
							== false))
				{
					this.OnServerChanging(value);
					this._server = value;
					this.OnServerChanged();
				}
			}
		}

		[Column(Storage = "_serverity", Name = "SERVERITY", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Serverity
		{
			get
			{
				return this._serverity;
			}
			set
			{
				if ((_serverity != value))
				{
					this.OnServerityChanging(value);
					this._serverity = value;
					this.OnServerityChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ATTRIBUTE")]
	public partial class Attribute
	{

		private System.Nullable<long> _actionID;

		private long _attributeID;

		private string _caption;

		private string _defaultvalue;

		private string _description;

		private System.Nullable<long> _enabledRuleID;

		private string _entrymask;

		private string _helpstring;

		private string _inputtype;

		private System.Nullable<long> _luTypeID;

		private string _name;

		private System.Nullable<long> _persistRuleID;

		private string _spellcheckFlag;

		private System.Nullable<long> _textlength;

		private string _unknownvalue;

		private System.Nullable<long> _validRuleID;

		private string _validvaluefieldFlag;

		private System.Nullable<long> _visibleRuleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActionIdChanged();

		partial void OnActionIdChanging(System.Nullable<long> value);

		partial void OnAttributeIdChanged();

		partial void OnAttributeIdChanging(long value);

		partial void OnCaptionChanged();

		partial void OnCaptionChanging(string value);

		partial void OnDefaultvalueChanged();

		partial void OnDefaultvalueChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<long> value);

		partial void OnEntrymaskChanged();

		partial void OnEntrymaskChanging(string value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnInputtypeChanged();

		partial void OnInputtypeChanging(string value);

		partial void OnLuTypeIdChanged();

		partial void OnLuTypeIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPersistRuleIdChanged();

		partial void OnPersistRuleIdChanging(System.Nullable<long> value);

		partial void OnSpellcheckFlagChanged();

		partial void OnSpellcheckFlagChanging(string value);

		partial void OnTextlengthChanged();

		partial void OnTextlengthChanging(System.Nullable<long> value);

		partial void OnUnknownvalueChanged();

		partial void OnUnknownvalueChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<long> value);

		partial void OnValidvaluefieldFlagChanged();

		partial void OnValidvaluefieldFlagChanging(string value);

		partial void OnVisibleRuleIdChanged();

		partial void OnVisibleRuleIdChanging(System.Nullable<long> value);
		#endregion


		public Attribute()
		{
			this.OnCreated();
		}

		[Column(Storage = "_actionID", Name = "ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ActionId
		{
			get
			{
				return this._actionID;
			}
			set
			{
				if ((_actionID != value))
				{
					this.OnActionIdChanging(value);
					this._actionID = value;
					this.OnActionIdChanged();
				}
			}
		}

		[Column(Storage = "_attributeID", Name = "ATTRIBUTE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttributeId
		{
			get
			{
				return this._attributeID;
			}
			set
			{
				if ((_attributeID != value))
				{
					this.OnAttributeIdChanging(value);
					this._attributeID = value;
					this.OnAttributeIdChanged();
				}
			}
		}

		[Column(Storage = "_caption", Name = "CAPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Caption
		{
			get
			{
				return this._caption;
			}
			set
			{
				if (((_caption == value)
							== false))
				{
					this.OnCaptionChanging(value);
					this._caption = value;
					this.OnCaptionChanged();
				}
			}
		}

		[Column(Storage = "_defaultvalue", Name = "DEFAULTVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Defaultvalue
		{
			get
			{
				return this._defaultvalue;
			}
			set
			{
				if (((_defaultvalue == value)
							== false))
				{
					this.OnDefaultvalueChanging(value);
					this._defaultvalue = value;
					this.OnDefaultvalueChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_entrymask", Name = "ENTRYMASK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Entrymask
		{
			get
			{
				return this._entrymask;
			}
			set
			{
				if (((_entrymask == value)
							== false))
				{
					this.OnEntrymaskChanging(value);
					this._entrymask = value;
					this.OnEntrymaskChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_inputtype", Name = "INPUTTYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Inputtype
		{
			get
			{
				return this._inputtype;
			}
			set
			{
				if (((_inputtype == value)
							== false))
				{
					this.OnInputtypeChanging(value);
					this._inputtype = value;
					this.OnInputtypeChanged();
				}
			}
		}

		[Column(Storage = "_luTypeID", Name = "LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LuTypeId
		{
			get
			{
				return this._luTypeID;
			}
			set
			{
				if ((_luTypeID != value))
				{
					this.OnLuTypeIdChanging(value);
					this._luTypeID = value;
					this.OnLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleID", Name = "PERSISTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PersistRuleId
		{
			get
			{
				return this._persistRuleID;
			}
			set
			{
				if ((_persistRuleID != value))
				{
					this.OnPersistRuleIdChanging(value);
					this._persistRuleID = value;
					this.OnPersistRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_spellcheckFlag", Name = "SPELLCHECK_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string SpellcheckFlag
		{
			get
			{
				return this._spellcheckFlag;
			}
			set
			{
				if (((_spellcheckFlag == value)
							== false))
				{
					this.OnSpellcheckFlagChanging(value);
					this._spellcheckFlag = value;
					this.OnSpellcheckFlagChanged();
				}
			}
		}

		[Column(Storage = "_textlength", Name = "TEXTLENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Textlength
		{
			get
			{
				return this._textlength;
			}
			set
			{
				if ((_textlength != value))
				{
					this.OnTextlengthChanging(value);
					this._textlength = value;
					this.OnTextlengthChanged();
				}
			}
		}

		[Column(Storage = "_unknownvalue", Name = "UNKNOWNVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Unknownvalue
		{
			get
			{
				return this._unknownvalue;
			}
			set
			{
				if (((_unknownvalue == value)
							== false))
				{
					this.OnUnknownvalueChanging(value);
					this._unknownvalue = value;
					this.OnUnknownvalueChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_validvaluefieldFlag", Name = "VALIDVALUEFIELD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ValidvaluefieldFlag
		{
			get
			{
				return this._validvaluefieldFlag;
			}
			set
			{
				if (((_validvaluefieldFlag == value)
							== false))
				{
					this.OnValidvaluefieldFlagChanging(value);
					this._validvaluefieldFlag = value;
					this.OnValidvaluefieldFlagChanged();
				}
			}
		}

		[Column(Storage = "_visibleRuleID", Name = "VISIBLERULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> VisibleRuleId
		{
			get
			{
				return this._visibleRuleID;
			}
			set
			{
				if ((_visibleRuleID != value))
				{
					this.OnVisibleRuleIdChanging(value);
					this._visibleRuleID = value;
					this.OnVisibleRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ATTRIBUTE_LU_VIEW")]
	public partial class AttributeLuView
	{

		private System.Nullable<long> _actionID;

		private string _actionText;

		private string _actionType;

		private long _attributeID;

		private string _caption;

		private string _defaultvalue;

		private string _description;

		private System.Nullable<long> _enabledRuleID;

		private string _enabledRuleText;

		private string _enabledRuleType;

		private string _entrymask;

		private string _helpstring;

		private string _inputtype;

		private string _luName;

		private System.Nullable<long> _luTypeID;

		private string _name;

		private System.Nullable<long> _persistRuleID;

		private string _persistRuleText;

		private string _persistRuleType;

		private string _spellcheckFlag;

		private System.Nullable<long> _textlength;

		private string _unknownvalue;

		private System.Nullable<long> _validRuleID;

		private string _validRuleText;

		private string _validRuleType;

		private string _validvaluefieldFlag;

		private System.Nullable<long> _visibleRuleID;

		private string _visibleRuleText;

		private string _visibleRuleType;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActionIdChanged();

		partial void OnActionIdChanging(System.Nullable<long> value);

		partial void OnActionTextChanged();

		partial void OnActionTextChanging(string value);

		partial void OnActionTypeChanged();

		partial void OnActionTypeChanging(string value);

		partial void OnAttributeIdChanged();

		partial void OnAttributeIdChanging(long value);

		partial void OnCaptionChanged();

		partial void OnCaptionChanging(string value);

		partial void OnDefaultvalueChanged();

		partial void OnDefaultvalueChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<long> value);

		partial void OnEnabledRuleTextChanged();

		partial void OnEnabledRuleTextChanging(string value);

		partial void OnEnabledRuleTypeChanged();

		partial void OnEnabledRuleTypeChanging(string value);

		partial void OnEntrymaskChanged();

		partial void OnEntrymaskChanging(string value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnInputtypeChanged();

		partial void OnInputtypeChanging(string value);

		partial void OnLuNameChanged();

		partial void OnLuNameChanging(string value);

		partial void OnLuTypeIdChanged();

		partial void OnLuTypeIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPersistRuleIdChanged();

		partial void OnPersistRuleIdChanging(System.Nullable<long> value);

		partial void OnPersistRuleTextChanged();

		partial void OnPersistRuleTextChanging(string value);

		partial void OnPersistRuleTypeChanged();

		partial void OnPersistRuleTypeChanging(string value);

		partial void OnSpellcheckFlagChanged();

		partial void OnSpellcheckFlagChanging(string value);

		partial void OnTextlengthChanged();

		partial void OnTextlengthChanging(System.Nullable<long> value);

		partial void OnUnknownvalueChanged();

		partial void OnUnknownvalueChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<long> value);

		partial void OnValidRuleTextChanged();

		partial void OnValidRuleTextChanging(string value);

		partial void OnValidRuleTypeChanged();

		partial void OnValidRuleTypeChanging(string value);

		partial void OnValidvaluefieldFlagChanged();

		partial void OnValidvaluefieldFlagChanging(string value);

		partial void OnVisibleRuleIdChanged();

		partial void OnVisibleRuleIdChanging(System.Nullable<long> value);

		partial void OnVisibleRuleTextChanged();

		partial void OnVisibleRuleTextChanging(string value);

		partial void OnVisibleRuleTypeChanged();

		partial void OnVisibleRuleTypeChanging(string value);
		#endregion


		public AttributeLuView()
		{
			this.OnCreated();
		}

		[Column(Storage = "_actionID", Name = "ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ActionId
		{
			get
			{
				return this._actionID;
			}
			set
			{
				if ((_actionID != value))
				{
					this.OnActionIdChanging(value);
					this._actionID = value;
					this.OnActionIdChanged();
				}
			}
		}

		[Column(Storage = "_actionText", Name = "ACTION_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ActionText
		{
			get
			{
				return this._actionText;
			}
			set
			{
				if (((_actionText == value)
							== false))
				{
					this.OnActionTextChanging(value);
					this._actionText = value;
					this.OnActionTextChanged();
				}
			}
		}

		[Column(Storage = "_actionType", Name = "ACTION_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ActionType
		{
			get
			{
				return this._actionType;
			}
			set
			{
				if (((_actionType == value)
							== false))
				{
					this.OnActionTypeChanging(value);
					this._actionType = value;
					this.OnActionTypeChanged();
				}
			}
		}

		[Column(Storage = "_attributeID", Name = "ATTRIBUTE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttributeId
		{
			get
			{
				return this._attributeID;
			}
			set
			{
				if ((_attributeID != value))
				{
					this.OnAttributeIdChanging(value);
					this._attributeID = value;
					this.OnAttributeIdChanged();
				}
			}
		}

		[Column(Storage = "_caption", Name = "CAPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Caption
		{
			get
			{
				return this._caption;
			}
			set
			{
				if (((_caption == value)
							== false))
				{
					this.OnCaptionChanging(value);
					this._caption = value;
					this.OnCaptionChanged();
				}
			}
		}

		[Column(Storage = "_defaultvalue", Name = "DEFAULTVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Defaultvalue
		{
			get
			{
				return this._defaultvalue;
			}
			set
			{
				if (((_defaultvalue == value)
							== false))
				{
					this.OnDefaultvalueChanging(value);
					this._defaultvalue = value;
					this.OnDefaultvalueChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleText", Name = "ENABLEDRULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnabledRuleText
		{
			get
			{
				return this._enabledRuleText;
			}
			set
			{
				if (((_enabledRuleText == value)
							== false))
				{
					this.OnEnabledRuleTextChanging(value);
					this._enabledRuleText = value;
					this.OnEnabledRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleType", Name = "ENABLEDRULE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnabledRuleType
		{
			get
			{
				return this._enabledRuleType;
			}
			set
			{
				if (((_enabledRuleType == value)
							== false))
				{
					this.OnEnabledRuleTypeChanging(value);
					this._enabledRuleType = value;
					this.OnEnabledRuleTypeChanged();
				}
			}
		}

		[Column(Storage = "_entrymask", Name = "ENTRYMASK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Entrymask
		{
			get
			{
				return this._entrymask;
			}
			set
			{
				if (((_entrymask == value)
							== false))
				{
					this.OnEntrymaskChanging(value);
					this._entrymask = value;
					this.OnEntrymaskChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_inputtype", Name = "INPUTTYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Inputtype
		{
			get
			{
				return this._inputtype;
			}
			set
			{
				if (((_inputtype == value)
							== false))
				{
					this.OnInputtypeChanging(value);
					this._inputtype = value;
					this.OnInputtypeChanged();
				}
			}
		}

		[Column(Storage = "_luName", Name = "LU_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LuName
		{
			get
			{
				return this._luName;
			}
			set
			{
				if (((_luName == value)
							== false))
				{
					this.OnLuNameChanging(value);
					this._luName = value;
					this.OnLuNameChanged();
				}
			}
		}

		[Column(Storage = "_luTypeID", Name = "LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LuTypeId
		{
			get
			{
				return this._luTypeID;
			}
			set
			{
				if ((_luTypeID != value))
				{
					this.OnLuTypeIdChanging(value);
					this._luTypeID = value;
					this.OnLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleID", Name = "PERSISTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PersistRuleId
		{
			get
			{
				return this._persistRuleID;
			}
			set
			{
				if ((_persistRuleID != value))
				{
					this.OnPersistRuleIdChanging(value);
					this._persistRuleID = value;
					this.OnPersistRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleText", Name = "PERSISTRULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PersistRuleText
		{
			get
			{
				return this._persistRuleText;
			}
			set
			{
				if (((_persistRuleText == value)
							== false))
				{
					this.OnPersistRuleTextChanging(value);
					this._persistRuleText = value;
					this.OnPersistRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleType", Name = "PERSISTRULE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PersistRuleType
		{
			get
			{
				return this._persistRuleType;
			}
			set
			{
				if (((_persistRuleType == value)
							== false))
				{
					this.OnPersistRuleTypeChanging(value);
					this._persistRuleType = value;
					this.OnPersistRuleTypeChanged();
				}
			}
		}

		[Column(Storage = "_spellcheckFlag", Name = "SPELLCHECK_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string SpellcheckFlag
		{
			get
			{
				return this._spellcheckFlag;
			}
			set
			{
				if (((_spellcheckFlag == value)
							== false))
				{
					this.OnSpellcheckFlagChanging(value);
					this._spellcheckFlag = value;
					this.OnSpellcheckFlagChanged();
				}
			}
		}

		[Column(Storage = "_textlength", Name = "TEXTLENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Textlength
		{
			get
			{
				return this._textlength;
			}
			set
			{
				if ((_textlength != value))
				{
					this.OnTextlengthChanging(value);
					this._textlength = value;
					this.OnTextlengthChanged();
				}
			}
		}

		[Column(Storage = "_unknownvalue", Name = "UNKNOWNVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Unknownvalue
		{
			get
			{
				return this._unknownvalue;
			}
			set
			{
				if (((_unknownvalue == value)
							== false))
				{
					this.OnUnknownvalueChanging(value);
					this._unknownvalue = value;
					this.OnUnknownvalueChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_validRuleText", Name = "VALIDRULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidRuleText
		{
			get
			{
				return this._validRuleText;
			}
			set
			{
				if (((_validRuleText == value)
							== false))
				{
					this.OnValidRuleTextChanging(value);
					this._validRuleText = value;
					this.OnValidRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_validRuleType", Name = "VALIDRULE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidRuleType
		{
			get
			{
				return this._validRuleType;
			}
			set
			{
				if (((_validRuleType == value)
							== false))
				{
					this.OnValidRuleTypeChanging(value);
					this._validRuleType = value;
					this.OnValidRuleTypeChanged();
				}
			}
		}

		[Column(Storage = "_validvaluefieldFlag", Name = "VALIDVALUEFIELD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ValidvaluefieldFlag
		{
			get
			{
				return this._validvaluefieldFlag;
			}
			set
			{
				if (((_validvaluefieldFlag == value)
							== false))
				{
					this.OnValidvaluefieldFlagChanging(value);
					this._validvaluefieldFlag = value;
					this.OnValidvaluefieldFlagChanged();
				}
			}
		}

		[Column(Storage = "_visibleRuleID", Name = "VISIBLERULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> VisibleRuleId
		{
			get
			{
				return this._visibleRuleID;
			}
			set
			{
				if ((_visibleRuleID != value))
				{
					this.OnVisibleRuleIdChanging(value);
					this._visibleRuleID = value;
					this.OnVisibleRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_visibleRuleText", Name = "VISIBLERULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string VisibleRuleText
		{
			get
			{
				return this._visibleRuleText;
			}
			set
			{
				if (((_visibleRuleText == value)
							== false))
				{
					this.OnVisibleRuleTextChanging(value);
					this._visibleRuleText = value;
					this.OnVisibleRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_visibleRuleType", Name = "VISIBLERULE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string VisibleRuleType
		{
			get
			{
				return this._visibleRuleType;
			}
			set
			{
				if (((_visibleRuleType == value)
							== false))
				{
					this.OnVisibleRuleTypeChanging(value);
					this._visibleRuleType = value;
					this.OnVisibleRuleTypeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ATTRIBUTE_OVERRIDE")]
	public partial class AttributeOverride
	{

		private System.Nullable<long> _actionID;

		private long _attributeoverrideID;

		private long _attrInstanceID;

		private string _caption;

		private string _defaultvalue;

		private string _description;

		private System.Nullable<long> _enabledRuleID;

		private string _entrymask;

		private string _helpstring;

		private string _inputtype;

		private System.Nullable<long> _luTypeID;

		private long _overrideRuleID;

		private System.Nullable<long> _persistRuleID;

		private string _propertyName;

		private long _sequence;

		private string _spellcheckFlag;

		private System.Nullable<long> _textlength;

		private string _unknownvalue;

		private System.Nullable<long> _validRuleID;

		private string _validvaluefieldFlag;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActionIdChanged();

		partial void OnActionIdChanging(System.Nullable<long> value);

		partial void OnAttributeoverrideIdChanged();

		partial void OnAttributeoverrideIdChanging(long value);

		partial void OnAttrInstanceIdChanged();

		partial void OnAttrInstanceIdChanging(long value);

		partial void OnCaptionChanged();

		partial void OnCaptionChanging(string value);

		partial void OnDefaultvalueChanged();

		partial void OnDefaultvalueChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<long> value);

		partial void OnEntrymaskChanged();

		partial void OnEntrymaskChanging(string value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnInputtypeChanged();

		partial void OnInputtypeChanging(string value);

		partial void OnLuTypeIdChanged();

		partial void OnLuTypeIdChanging(System.Nullable<long> value);

		partial void OnOverrideRuleIdChanged();

		partial void OnOverrideRuleIdChanging(long value);

		partial void OnPersistRuleIdChanged();

		partial void OnPersistRuleIdChanging(System.Nullable<long> value);

		partial void OnPropertyNameChanged();

		partial void OnPropertyNameChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);

		partial void OnSpellcheckFlagChanged();

		partial void OnSpellcheckFlagChanging(string value);

		partial void OnTextlengthChanged();

		partial void OnTextlengthChanging(System.Nullable<long> value);

		partial void OnUnknownvalueChanged();

		partial void OnUnknownvalueChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<long> value);

		partial void OnValidvaluefieldFlagChanged();

		partial void OnValidvaluefieldFlagChanging(string value);
		#endregion


		public AttributeOverride()
		{
			this.OnCreated();
		}

		[Column(Storage = "_actionID", Name = "ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ActionId
		{
			get
			{
				return this._actionID;
			}
			set
			{
				if ((_actionID != value))
				{
					this.OnActionIdChanging(value);
					this._actionID = value;
					this.OnActionIdChanged();
				}
			}
		}

		[Column(Storage = "_attributeoverrideID", Name = "ATTRIBUTEOVERRIDE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttributeoverrideId
		{
			get
			{
				return this._attributeoverrideID;
			}
			set
			{
				if ((_attributeoverrideID != value))
				{
					this.OnAttributeoverrideIdChanging(value);
					this._attributeoverrideID = value;
					this.OnAttributeoverrideIdChanged();
				}
			}
		}

		[Column(Storage = "_attrInstanceID", Name = "ATTR_INSTANCE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttrInstanceId
		{
			get
			{
				return this._attrInstanceID;
			}
			set
			{
				if ((_attrInstanceID != value))
				{
					this.OnAttrInstanceIdChanging(value);
					this._attrInstanceID = value;
					this.OnAttrInstanceIdChanged();
				}
			}
		}

		[Column(Storage = "_caption", Name = "CAPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Caption
		{
			get
			{
				return this._caption;
			}
			set
			{
				if (((_caption == value)
							== false))
				{
					this.OnCaptionChanging(value);
					this._caption = value;
					this.OnCaptionChanged();
				}
			}
		}

		[Column(Storage = "_defaultvalue", Name = "DEFAULTVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Defaultvalue
		{
			get
			{
				return this._defaultvalue;
			}
			set
			{
				if (((_defaultvalue == value)
							== false))
				{
					this.OnDefaultvalueChanging(value);
					this._defaultvalue = value;
					this.OnDefaultvalueChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_entrymask", Name = "ENTRYMASK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Entrymask
		{
			get
			{
				return this._entrymask;
			}
			set
			{
				if (((_entrymask == value)
							== false))
				{
					this.OnEntrymaskChanging(value);
					this._entrymask = value;
					this.OnEntrymaskChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_inputtype", Name = "INPUTTYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Inputtype
		{
			get
			{
				return this._inputtype;
			}
			set
			{
				if (((_inputtype == value)
							== false))
				{
					this.OnInputtypeChanging(value);
					this._inputtype = value;
					this.OnInputtypeChanged();
				}
			}
		}

		[Column(Storage = "_luTypeID", Name = "LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LuTypeId
		{
			get
			{
				return this._luTypeID;
			}
			set
			{
				if ((_luTypeID != value))
				{
					this.OnLuTypeIdChanging(value);
					this._luTypeID = value;
					this.OnLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_overrideRuleID", Name = "OVERRIDE_RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OverrideRuleId
		{
			get
			{
				return this._overrideRuleID;
			}
			set
			{
				if ((_overrideRuleID != value))
				{
					this.OnOverrideRuleIdChanging(value);
					this._overrideRuleID = value;
					this.OnOverrideRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleID", Name = "PERSISTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PersistRuleId
		{
			get
			{
				return this._persistRuleID;
			}
			set
			{
				if ((_persistRuleID != value))
				{
					this.OnPersistRuleIdChanging(value);
					this._persistRuleID = value;
					this.OnPersistRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_propertyName", Name = "PROPERTY_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				if (((_propertyName == value)
							== false))
				{
					this.OnPropertyNameChanging(value);
					this._propertyName = value;
					this.OnPropertyNameChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_spellcheckFlag", Name = "SPELLCHECK_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpellcheckFlag
		{
			get
			{
				return this._spellcheckFlag;
			}
			set
			{
				if (((_spellcheckFlag == value)
							== false))
				{
					this.OnSpellcheckFlagChanging(value);
					this._spellcheckFlag = value;
					this.OnSpellcheckFlagChanged();
				}
			}
		}

		[Column(Storage = "_textlength", Name = "TEXTLENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Textlength
		{
			get
			{
				return this._textlength;
			}
			set
			{
				if ((_textlength != value))
				{
					this.OnTextlengthChanging(value);
					this._textlength = value;
					this.OnTextlengthChanged();
				}
			}
		}

		[Column(Storage = "_unknownvalue", Name = "UNKNOWNVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Unknownvalue
		{
			get
			{
				return this._unknownvalue;
			}
			set
			{
				if (((_unknownvalue == value)
							== false))
				{
					this.OnUnknownvalueChanging(value);
					this._unknownvalue = value;
					this.OnUnknownvalueChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_validvaluefieldFlag", Name = "VALIDVALUEFIELD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidvaluefieldFlag
		{
			get
			{
				return this._validvaluefieldFlag;
			}
			set
			{
				if (((_validvaluefieldFlag == value)
							== false))
				{
					this.OnValidvaluefieldFlagChanging(value);
					this._validvaluefieldFlag = value;
					this.OnValidvaluefieldFlagChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ATTRIBUTE_OVERRIDE_VIEW")]
	public partial class AttributeOverrideView
	{

		private string _actionText;

		private long _attrInstanceID;

		private string _caption;

		private string _defaultvalue;

		private string _description;

		private string _enabledRuleText;

		private string _entrymask;

		private string _helpstring;

		private string _inputtype;

		private System.Nullable<long> _luTypeID;

		private long _overrideRuleID;

		private string _overrideRuleText;

		private string _persistRuleText;

		private string _propertyName;

		private long _sequence;

		private string _spellcheckFlag;

		private System.Nullable<long> _textlength;

		private string _unknownvalue;

		private string _validRuleText;

		private string _validvaluefieldFlag;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActionTextChanged();

		partial void OnActionTextChanging(string value);

		partial void OnAttrInstanceIdChanged();

		partial void OnAttrInstanceIdChanging(long value);

		partial void OnCaptionChanged();

		partial void OnCaptionChanging(string value);

		partial void OnDefaultvalueChanged();

		partial void OnDefaultvalueChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledRuleTextChanged();

		partial void OnEnabledRuleTextChanging(string value);

		partial void OnEntrymaskChanged();

		partial void OnEntrymaskChanging(string value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnInputtypeChanged();

		partial void OnInputtypeChanging(string value);

		partial void OnLuTypeIdChanged();

		partial void OnLuTypeIdChanging(System.Nullable<long> value);

		partial void OnOverrideRuleIdChanged();

		partial void OnOverrideRuleIdChanging(long value);

		partial void OnOverrideRuleTextChanged();

		partial void OnOverrideRuleTextChanging(string value);

		partial void OnPersistRuleTextChanged();

		partial void OnPersistRuleTextChanging(string value);

		partial void OnPropertyNameChanged();

		partial void OnPropertyNameChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);

		partial void OnSpellcheckFlagChanged();

		partial void OnSpellcheckFlagChanging(string value);

		partial void OnTextlengthChanged();

		partial void OnTextlengthChanging(System.Nullable<long> value);

		partial void OnUnknownvalueChanged();

		partial void OnUnknownvalueChanging(string value);

		partial void OnValidRuleTextChanged();

		partial void OnValidRuleTextChanging(string value);

		partial void OnValidvaluefieldFlagChanged();

		partial void OnValidvaluefieldFlagChanging(string value);
		#endregion


		public AttributeOverrideView()
		{
			this.OnCreated();
		}

		[Column(Storage = "_actionText", Name = "ACTION_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ActionText
		{
			get
			{
				return this._actionText;
			}
			set
			{
				if (((_actionText == value)
							== false))
				{
					this.OnActionTextChanging(value);
					this._actionText = value;
					this.OnActionTextChanged();
				}
			}
		}

		[Column(Storage = "_attrInstanceID", Name = "ATTR_INSTANCE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttrInstanceId
		{
			get
			{
				return this._attrInstanceID;
			}
			set
			{
				if ((_attrInstanceID != value))
				{
					this.OnAttrInstanceIdChanging(value);
					this._attrInstanceID = value;
					this.OnAttrInstanceIdChanged();
				}
			}
		}

		[Column(Storage = "_caption", Name = "CAPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Caption
		{
			get
			{
				return this._caption;
			}
			set
			{
				if (((_caption == value)
							== false))
				{
					this.OnCaptionChanging(value);
					this._caption = value;
					this.OnCaptionChanged();
				}
			}
		}

		[Column(Storage = "_defaultvalue", Name = "DEFAULTVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Defaultvalue
		{
			get
			{
				return this._defaultvalue;
			}
			set
			{
				if (((_defaultvalue == value)
							== false))
				{
					this.OnDefaultvalueChanging(value);
					this._defaultvalue = value;
					this.OnDefaultvalueChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleText", Name = "ENABLED_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnabledRuleText
		{
			get
			{
				return this._enabledRuleText;
			}
			set
			{
				if (((_enabledRuleText == value)
							== false))
				{
					this.OnEnabledRuleTextChanging(value);
					this._enabledRuleText = value;
					this.OnEnabledRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_entrymask", Name = "ENTRYMASK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Entrymask
		{
			get
			{
				return this._entrymask;
			}
			set
			{
				if (((_entrymask == value)
							== false))
				{
					this.OnEntrymaskChanging(value);
					this._entrymask = value;
					this.OnEntrymaskChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_inputtype", Name = "INPUTTYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Inputtype
		{
			get
			{
				return this._inputtype;
			}
			set
			{
				if (((_inputtype == value)
							== false))
				{
					this.OnInputtypeChanging(value);
					this._inputtype = value;
					this.OnInputtypeChanged();
				}
			}
		}

		[Column(Storage = "_luTypeID", Name = "LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LuTypeId
		{
			get
			{
				return this._luTypeID;
			}
			set
			{
				if ((_luTypeID != value))
				{
					this.OnLuTypeIdChanging(value);
					this._luTypeID = value;
					this.OnLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_overrideRuleID", Name = "OVERRIDE_RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OverrideRuleId
		{
			get
			{
				return this._overrideRuleID;
			}
			set
			{
				if ((_overrideRuleID != value))
				{
					this.OnOverrideRuleIdChanging(value);
					this._overrideRuleID = value;
					this.OnOverrideRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_overrideRuleText", Name = "OVERRIDE_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OverrideRuleText
		{
			get
			{
				return this._overrideRuleText;
			}
			set
			{
				if (((_overrideRuleText == value)
							== false))
				{
					this.OnOverrideRuleTextChanging(value);
					this._overrideRuleText = value;
					this.OnOverrideRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleText", Name = "PERSIST_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PersistRuleText
		{
			get
			{
				return this._persistRuleText;
			}
			set
			{
				if (((_persistRuleText == value)
							== false))
				{
					this.OnPersistRuleTextChanging(value);
					this._persistRuleText = value;
					this.OnPersistRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_propertyName", Name = "PROPERTY_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				if (((_propertyName == value)
							== false))
				{
					this.OnPropertyNameChanging(value);
					this._propertyName = value;
					this.OnPropertyNameChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_spellcheckFlag", Name = "SPELLCHECK_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpellcheckFlag
		{
			get
			{
				return this._spellcheckFlag;
			}
			set
			{
				if (((_spellcheckFlag == value)
							== false))
				{
					this.OnSpellcheckFlagChanging(value);
					this._spellcheckFlag = value;
					this.OnSpellcheckFlagChanged();
				}
			}
		}

		[Column(Storage = "_textlength", Name = "TEXTLENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Textlength
		{
			get
			{
				return this._textlength;
			}
			set
			{
				if ((_textlength != value))
				{
					this.OnTextlengthChanging(value);
					this._textlength = value;
					this.OnTextlengthChanged();
				}
			}
		}

		[Column(Storage = "_unknownvalue", Name = "UNKNOWNVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Unknownvalue
		{
			get
			{
				return this._unknownvalue;
			}
			set
			{
				if (((_unknownvalue == value)
							== false))
				{
					this.OnUnknownvalueChanging(value);
					this._unknownvalue = value;
					this.OnUnknownvalueChanged();
				}
			}
		}

		[Column(Storage = "_validRuleText", Name = "VALID_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidRuleText
		{
			get
			{
				return this._validRuleText;
			}
			set
			{
				if (((_validRuleText == value)
							== false))
				{
					this.OnValidRuleTextChanging(value);
					this._validRuleText = value;
					this.OnValidRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_validvaluefieldFlag", Name = "VALIDVALUEFIELD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidvaluefieldFlag
		{
			get
			{
				return this._validvaluefieldFlag;
			}
			set
			{
				if (((_validvaluefieldFlag == value)
							== false))
				{
					this.OnValidvaluefieldFlagChanging(value);
					this._validvaluefieldFlag = value;
					this.OnValidvaluefieldFlagChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ATTRIBUTE_VIEW")]
	public partial class AttributeView
	{

		private System.Nullable<decimal> _actionID;

		private string _actionText;

		private string _aoActionText;

		private string _aoCaption;

		private string _aoDefaultvalue;

		private string _aoDescription;

		private string _aoEnabledRuleText;

		private string _aoEntrymask;

		private string _aoHelpstring;

		private string _aoInputtype;

		private System.Nullable<long> _aoLuTypeID;

		private string _aoPersistRuleText;

		private System.Nullable<long> _aoSequence;

		private string _aoSpellcheckFlag;

		private System.Nullable<long> _aoTextlength;

		private string _aoUnknownvalue;

		private string _aoValidRuleText;

		private string _aoValidvaluefieldFlag;

		private string _attribName;

		private System.Nullable<long> _attributeframeID;

		private long _attributeID;

		private long _attrInstanceID;

		private string _caption;

		private string _defaultvalue;

		private string _description;

		private System.Nullable<decimal> _enabledRuleID;

		private string _enabledRuleText;

		private string _entrymask;

		private long _frameID;

		private System.Nullable<long> _height;

		private string _helpstring;

		private string _inputtype;

		private string _lucolumnName;

		private string _lucriteriaFlag;

		private string _ludisplayFlag;

		private string _lustorageFlag;

		private string _lustorageName;

		private System.Nullable<decimal> _luTypeID;

		private string _mandatoryFlag;

		private string _overrideRuleText;

		private System.Nullable<decimal> _persistRuleID;

		private string _persistRuleText;

		private string _propertyName;

		private string _reapplyoverrideFlag;

		private long _sequence;

		private string _spellcheckFlag;

		private System.Nullable<decimal> _textlength;

		private string _type;

		private string _unknownvalue;

		private System.Nullable<decimal> _validRuleID;

		private string _validRuleText;

		private string _validvaluefieldFlag;

		private System.Nullable<decimal> _visibleRuleID;

		private string _visibleRuleText;

		private System.Nullable<long> _width;

		private System.Nullable<long> _xpos;

		private System.Nullable<long> _ypos;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActionIdChanged();

		partial void OnActionIdChanging(System.Nullable<decimal> value);

		partial void OnActionTextChanged();

		partial void OnActionTextChanging(string value);

		partial void OnAoActionTextChanged();

		partial void OnAoActionTextChanging(string value);

		partial void OnAoCaptionChanged();

		partial void OnAoCaptionChanging(string value);

		partial void OnAoDefaultvalueChanged();

		partial void OnAoDefaultvalueChanging(string value);

		partial void OnAoDescriptionChanged();

		partial void OnAoDescriptionChanging(string value);

		partial void OnAoEnabledRuleTextChanged();

		partial void OnAoEnabledRuleTextChanging(string value);

		partial void OnAoEntrymaskChanged();

		partial void OnAoEntrymaskChanging(string value);

		partial void OnAoHelpstringChanged();

		partial void OnAoHelpstringChanging(string value);

		partial void OnAoInputtypeChanged();

		partial void OnAoInputtypeChanging(string value);

		partial void OnAoLuTypeIdChanged();

		partial void OnAoLuTypeIdChanging(System.Nullable<long> value);

		partial void OnAoPersistRuleTextChanged();

		partial void OnAoPersistRuleTextChanging(string value);

		partial void OnAoSequenceChanged();

		partial void OnAoSequenceChanging(System.Nullable<long> value);

		partial void OnAoSpellcheckFlagChanged();

		partial void OnAoSpellcheckFlagChanging(string value);

		partial void OnAoTextlengthChanged();

		partial void OnAoTextlengthChanging(System.Nullable<long> value);

		partial void OnAoUnknownvalueChanged();

		partial void OnAoUnknownvalueChanging(string value);

		partial void OnAoValidRuleTextChanged();

		partial void OnAoValidRuleTextChanging(string value);

		partial void OnAoValidvaluefieldFlagChanged();

		partial void OnAoValidvaluefieldFlagChanging(string value);

		partial void OnAttribNameChanged();

		partial void OnAttribNameChanging(string value);

		partial void OnAttributeframeIdChanged();

		partial void OnAttributeframeIdChanging(System.Nullable<long> value);

		partial void OnAttributeIdChanged();

		partial void OnAttributeIdChanging(long value);

		partial void OnAttrInstanceIdChanged();

		partial void OnAttrInstanceIdChanging(long value);

		partial void OnCaptionChanged();

		partial void OnCaptionChanging(string value);

		partial void OnDefaultvalueChanged();

		partial void OnDefaultvalueChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<decimal> value);

		partial void OnEnabledRuleTextChanged();

		partial void OnEnabledRuleTextChanging(string value);

		partial void OnEntrymaskChanged();

		partial void OnEntrymaskChanging(string value);

		partial void OnFrameIdChanged();

		partial void OnFrameIdChanging(long value);

		partial void OnHeightChanged();

		partial void OnHeightChanging(System.Nullable<long> value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnInputtypeChanged();

		partial void OnInputtypeChanging(string value);

		partial void OnLucolumnNameChanged();

		partial void OnLucolumnNameChanging(string value);

		partial void OnLucriteriaFlagChanged();

		partial void OnLucriteriaFlagChanging(string value);

		partial void OnLudisplayFlagChanged();

		partial void OnLudisplayFlagChanging(string value);

		partial void OnLustorageFlagChanged();

		partial void OnLustorageFlagChanging(string value);

		partial void OnLustorageNameChanged();

		partial void OnLustorageNameChanging(string value);

		partial void OnLuTypeIdChanged();

		partial void OnLuTypeIdChanging(System.Nullable<decimal> value);

		partial void OnMandatoryFlagChanged();

		partial void OnMandatoryFlagChanging(string value);

		partial void OnOverrideRuleTextChanged();

		partial void OnOverrideRuleTextChanging(string value);

		partial void OnPersistRuleIdChanged();

		partial void OnPersistRuleIdChanging(System.Nullable<decimal> value);

		partial void OnPersistRuleTextChanged();

		partial void OnPersistRuleTextChanging(string value);

		partial void OnPropertyNameChanged();

		partial void OnPropertyNameChanging(string value);

		partial void OnReapplyoverrideFlagChanged();

		partial void OnReapplyoverrideFlagChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);

		partial void OnSpellcheckFlagChanged();

		partial void OnSpellcheckFlagChanging(string value);

		partial void OnTextlengthChanged();

		partial void OnTextlengthChanging(System.Nullable<decimal> value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnUnknownvalueChanged();

		partial void OnUnknownvalueChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<decimal> value);

		partial void OnValidRuleTextChanged();

		partial void OnValidRuleTextChanging(string value);

		partial void OnValidvaluefieldFlagChanged();

		partial void OnValidvaluefieldFlagChanging(string value);

		partial void OnVisibleRuleIdChanged();

		partial void OnVisibleRuleIdChanging(System.Nullable<decimal> value);

		partial void OnVisibleRuleTextChanged();

		partial void OnVisibleRuleTextChanging(string value);

		partial void OnWidthChanged();

		partial void OnWidthChanging(System.Nullable<long> value);

		partial void OnXposChanged();

		partial void OnXposChanging(System.Nullable<long> value);

		partial void OnYposChanged();

		partial void OnYposChanging(System.Nullable<long> value);
		#endregion


		public AttributeView()
		{
			this.OnCreated();
		}

		[Column(Storage = "_actionID", Name = "ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> ActionId
		{
			get
			{
				return this._actionID;
			}
			set
			{
				if ((_actionID != value))
				{
					this.OnActionIdChanging(value);
					this._actionID = value;
					this.OnActionIdChanged();
				}
			}
		}

		[Column(Storage = "_actionText", Name = "ACTION_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ActionText
		{
			get
			{
				return this._actionText;
			}
			set
			{
				if (((_actionText == value)
							== false))
				{
					this.OnActionTextChanging(value);
					this._actionText = value;
					this.OnActionTextChanged();
				}
			}
		}

		[Column(Storage = "_aoActionText", Name = "AO_ACTION_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoActionText
		{
			get
			{
				return this._aoActionText;
			}
			set
			{
				if (((_aoActionText == value)
							== false))
				{
					this.OnAoActionTextChanging(value);
					this._aoActionText = value;
					this.OnAoActionTextChanged();
				}
			}
		}

		[Column(Storage = "_aoCaption", Name = "AO_CAPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoCaption
		{
			get
			{
				return this._aoCaption;
			}
			set
			{
				if (((_aoCaption == value)
							== false))
				{
					this.OnAoCaptionChanging(value);
					this._aoCaption = value;
					this.OnAoCaptionChanged();
				}
			}
		}

		[Column(Storage = "_aoDefaultvalue", Name = "AO_DEFAULTVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoDefaultvalue
		{
			get
			{
				return this._aoDefaultvalue;
			}
			set
			{
				if (((_aoDefaultvalue == value)
							== false))
				{
					this.OnAoDefaultvalueChanging(value);
					this._aoDefaultvalue = value;
					this.OnAoDefaultvalueChanged();
				}
			}
		}

		[Column(Storage = "_aoDescription", Name = "AO_DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoDescription
		{
			get
			{
				return this._aoDescription;
			}
			set
			{
				if (((_aoDescription == value)
							== false))
				{
					this.OnAoDescriptionChanging(value);
					this._aoDescription = value;
					this.OnAoDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_aoEnabledRuleText", Name = "AO_ENABLED_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoEnabledRuleText
		{
			get
			{
				return this._aoEnabledRuleText;
			}
			set
			{
				if (((_aoEnabledRuleText == value)
							== false))
				{
					this.OnAoEnabledRuleTextChanging(value);
					this._aoEnabledRuleText = value;
					this.OnAoEnabledRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_aoEntrymask", Name = "AO_ENTRYMASK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoEntrymask
		{
			get
			{
				return this._aoEntrymask;
			}
			set
			{
				if (((_aoEntrymask == value)
							== false))
				{
					this.OnAoEntrymaskChanging(value);
					this._aoEntrymask = value;
					this.OnAoEntrymaskChanged();
				}
			}
		}

		[Column(Storage = "_aoHelpstring", Name = "AO_HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoHelpstring
		{
			get
			{
				return this._aoHelpstring;
			}
			set
			{
				if (((_aoHelpstring == value)
							== false))
				{
					this.OnAoHelpstringChanging(value);
					this._aoHelpstring = value;
					this.OnAoHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_aoInputtype", Name = "AO_INPUTTYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoInputtype
		{
			get
			{
				return this._aoInputtype;
			}
			set
			{
				if (((_aoInputtype == value)
							== false))
				{
					this.OnAoInputtypeChanging(value);
					this._aoInputtype = value;
					this.OnAoInputtypeChanged();
				}
			}
		}

		[Column(Storage = "_aoLuTypeID", Name = "AO_LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AoLuTypeId
		{
			get
			{
				return this._aoLuTypeID;
			}
			set
			{
				if ((_aoLuTypeID != value))
				{
					this.OnAoLuTypeIdChanging(value);
					this._aoLuTypeID = value;
					this.OnAoLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_aoPersistRuleText", Name = "AO_PERSIST_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoPersistRuleText
		{
			get
			{
				return this._aoPersistRuleText;
			}
			set
			{
				if (((_aoPersistRuleText == value)
							== false))
				{
					this.OnAoPersistRuleTextChanging(value);
					this._aoPersistRuleText = value;
					this.OnAoPersistRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_aoSequence", Name = "AO_SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AoSequence
		{
			get
			{
				return this._aoSequence;
			}
			set
			{
				if ((_aoSequence != value))
				{
					this.OnAoSequenceChanging(value);
					this._aoSequence = value;
					this.OnAoSequenceChanged();
				}
			}
		}

		[Column(Storage = "_aoSpellcheckFlag", Name = "AO_SPELLCHECK_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoSpellcheckFlag
		{
			get
			{
				return this._aoSpellcheckFlag;
			}
			set
			{
				if (((_aoSpellcheckFlag == value)
							== false))
				{
					this.OnAoSpellcheckFlagChanging(value);
					this._aoSpellcheckFlag = value;
					this.OnAoSpellcheckFlagChanged();
				}
			}
		}

		[Column(Storage = "_aoTextlength", Name = "AO_TEXTLENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AoTextlength
		{
			get
			{
				return this._aoTextlength;
			}
			set
			{
				if ((_aoTextlength != value))
				{
					this.OnAoTextlengthChanging(value);
					this._aoTextlength = value;
					this.OnAoTextlengthChanged();
				}
			}
		}

		[Column(Storage = "_aoUnknownvalue", Name = "AO_UNKNOWNVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoUnknownvalue
		{
			get
			{
				return this._aoUnknownvalue;
			}
			set
			{
				if (((_aoUnknownvalue == value)
							== false))
				{
					this.OnAoUnknownvalueChanging(value);
					this._aoUnknownvalue = value;
					this.OnAoUnknownvalueChanged();
				}
			}
		}

		[Column(Storage = "_aoValidRuleText", Name = "AO_VALID_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoValidRuleText
		{
			get
			{
				return this._aoValidRuleText;
			}
			set
			{
				if (((_aoValidRuleText == value)
							== false))
				{
					this.OnAoValidRuleTextChanging(value);
					this._aoValidRuleText = value;
					this.OnAoValidRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_aoValidvaluefieldFlag", Name = "AO_VALIDVALUEFIELD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AoValidvaluefieldFlag
		{
			get
			{
				return this._aoValidvaluefieldFlag;
			}
			set
			{
				if (((_aoValidvaluefieldFlag == value)
							== false))
				{
					this.OnAoValidvaluefieldFlagChanging(value);
					this._aoValidvaluefieldFlag = value;
					this.OnAoValidvaluefieldFlagChanged();
				}
			}
		}

		[Column(Storage = "_attribName", Name = "ATTRIB_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttribName
		{
			get
			{
				return this._attribName;
			}
			set
			{
				if (((_attribName == value)
							== false))
				{
					this.OnAttribNameChanging(value);
					this._attribName = value;
					this.OnAttribNameChanged();
				}
			}
		}

		[Column(Storage = "_attributeframeID", Name = "ATTRIBUTEFRAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AttributeframeId
		{
			get
			{
				return this._attributeframeID;
			}
			set
			{
				if ((_attributeframeID != value))
				{
					this.OnAttributeframeIdChanging(value);
					this._attributeframeID = value;
					this.OnAttributeframeIdChanged();
				}
			}
		}

		[Column(Storage = "_attributeID", Name = "ATTRIBUTE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttributeId
		{
			get
			{
				return this._attributeID;
			}
			set
			{
				if ((_attributeID != value))
				{
					this.OnAttributeIdChanging(value);
					this._attributeID = value;
					this.OnAttributeIdChanged();
				}
			}
		}

		[Column(Storage = "_attrInstanceID", Name = "ATTR_INSTANCE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttrInstanceId
		{
			get
			{
				return this._attrInstanceID;
			}
			set
			{
				if ((_attrInstanceID != value))
				{
					this.OnAttrInstanceIdChanging(value);
					this._attrInstanceID = value;
					this.OnAttrInstanceIdChanged();
				}
			}
		}

		[Column(Storage = "_caption", Name = "CAPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Caption
		{
			get
			{
				return this._caption;
			}
			set
			{
				if (((_caption == value)
							== false))
				{
					this.OnCaptionChanging(value);
					this._caption = value;
					this.OnCaptionChanged();
				}
			}
		}

		[Column(Storage = "_defaultvalue", Name = "DEFAULTVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Defaultvalue
		{
			get
			{
				return this._defaultvalue;
			}
			set
			{
				if (((_defaultvalue == value)
							== false))
				{
					this.OnDefaultvalueChanging(value);
					this._defaultvalue = value;
					this.OnDefaultvalueChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleText", Name = "ENABLED_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnabledRuleText
		{
			get
			{
				return this._enabledRuleText;
			}
			set
			{
				if (((_enabledRuleText == value)
							== false))
				{
					this.OnEnabledRuleTextChanging(value);
					this._enabledRuleText = value;
					this.OnEnabledRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_entrymask", Name = "ENTRYMASK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Entrymask
		{
			get
			{
				return this._entrymask;
			}
			set
			{
				if (((_entrymask == value)
							== false))
				{
					this.OnEntrymaskChanging(value);
					this._entrymask = value;
					this.OnEntrymaskChanged();
				}
			}
		}

		[Column(Storage = "_frameID", Name = "FRAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FrameId
		{
			get
			{
				return this._frameID;
			}
			set
			{
				if ((_frameID != value))
				{
					this.OnFrameIdChanging(value);
					this._frameID = value;
					this.OnFrameIdChanged();
				}
			}
		}

		[Column(Storage = "_height", Name = "HEIGHT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Height
		{
			get
			{
				return this._height;
			}
			set
			{
				if ((_height != value))
				{
					this.OnHeightChanging(value);
					this._height = value;
					this.OnHeightChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_inputtype", Name = "INPUTTYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Inputtype
		{
			get
			{
				return this._inputtype;
			}
			set
			{
				if (((_inputtype == value)
							== false))
				{
					this.OnInputtypeChanging(value);
					this._inputtype = value;
					this.OnInputtypeChanged();
				}
			}
		}

		[Column(Storage = "_lucolumnName", Name = "LUCOLUMN_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LucolumnName
		{
			get
			{
				return this._lucolumnName;
			}
			set
			{
				if (((_lucolumnName == value)
							== false))
				{
					this.OnLucolumnNameChanging(value);
					this._lucolumnName = value;
					this.OnLucolumnNameChanged();
				}
			}
		}

		[Column(Storage = "_lucriteriaFlag", Name = "LUCRITERIA_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LucriteriaFlag
		{
			get
			{
				return this._lucriteriaFlag;
			}
			set
			{
				if (((_lucriteriaFlag == value)
							== false))
				{
					this.OnLucriteriaFlagChanging(value);
					this._lucriteriaFlag = value;
					this.OnLucriteriaFlagChanged();
				}
			}
		}

		[Column(Storage = "_ludisplayFlag", Name = "LUDISPLAY_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LudisplayFlag
		{
			get
			{
				return this._ludisplayFlag;
			}
			set
			{
				if (((_ludisplayFlag == value)
							== false))
				{
					this.OnLudisplayFlagChanging(value);
					this._ludisplayFlag = value;
					this.OnLudisplayFlagChanged();
				}
			}
		}

		[Column(Storage = "_lustorageFlag", Name = "LUSTORAGE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LustorageFlag
		{
			get
			{
				return this._lustorageFlag;
			}
			set
			{
				if (((_lustorageFlag == value)
							== false))
				{
					this.OnLustorageFlagChanging(value);
					this._lustorageFlag = value;
					this.OnLustorageFlagChanged();
				}
			}
		}

		[Column(Storage = "_lustorageName", Name = "LUSTORAGE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LustorageName
		{
			get
			{
				return this._lustorageName;
			}
			set
			{
				if (((_lustorageName == value)
							== false))
				{
					this.OnLustorageNameChanging(value);
					this._lustorageName = value;
					this.OnLustorageNameChanged();
				}
			}
		}

		[Column(Storage = "_luTypeID", Name = "LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> LuTypeId
		{
			get
			{
				return this._luTypeID;
			}
			set
			{
				if ((_luTypeID != value))
				{
					this.OnLuTypeIdChanging(value);
					this._luTypeID = value;
					this.OnLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_mandatoryFlag", Name = "MANDATORY_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string MandatoryFlag
		{
			get
			{
				return this._mandatoryFlag;
			}
			set
			{
				if (((_mandatoryFlag == value)
							== false))
				{
					this.OnMandatoryFlagChanging(value);
					this._mandatoryFlag = value;
					this.OnMandatoryFlagChanged();
				}
			}
		}

		[Column(Storage = "_overrideRuleText", Name = "OVERRIDE_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OverrideRuleText
		{
			get
			{
				return this._overrideRuleText;
			}
			set
			{
				if (((_overrideRuleText == value)
							== false))
				{
					this.OnOverrideRuleTextChanging(value);
					this._overrideRuleText = value;
					this.OnOverrideRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleID", Name = "PERSISTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> PersistRuleId
		{
			get
			{
				return this._persistRuleID;
			}
			set
			{
				if ((_persistRuleID != value))
				{
					this.OnPersistRuleIdChanging(value);
					this._persistRuleID = value;
					this.OnPersistRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleText", Name = "PERSIST_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PersistRuleText
		{
			get
			{
				return this._persistRuleText;
			}
			set
			{
				if (((_persistRuleText == value)
							== false))
				{
					this.OnPersistRuleTextChanging(value);
					this._persistRuleText = value;
					this.OnPersistRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_propertyName", Name = "PROPERTY_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				if (((_propertyName == value)
							== false))
				{
					this.OnPropertyNameChanging(value);
					this._propertyName = value;
					this.OnPropertyNameChanged();
				}
			}
		}

		[Column(Storage = "_reapplyoverrideFlag", Name = "REAPPLYOVERRIDE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReapplyoverrideFlag
		{
			get
			{
				return this._reapplyoverrideFlag;
			}
			set
			{
				if (((_reapplyoverrideFlag == value)
							== false))
				{
					this.OnReapplyoverrideFlagChanging(value);
					this._reapplyoverrideFlag = value;
					this.OnReapplyoverrideFlagChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_spellcheckFlag", Name = "SPELLCHECK_FLG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpellcheckFlag
		{
			get
			{
				return this._spellcheckFlag;
			}
			set
			{
				if (((_spellcheckFlag == value)
							== false))
				{
					this.OnSpellcheckFlagChanging(value);
					this._spellcheckFlag = value;
					this.OnSpellcheckFlagChanged();
				}
			}
		}

		[Column(Storage = "_textlength", Name = "TEXTLENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Textlength
		{
			get
			{
				return this._textlength;
			}
			set
			{
				if ((_textlength != value))
				{
					this.OnTextlengthChanging(value);
					this._textlength = value;
					this.OnTextlengthChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_unknownvalue", Name = "UNKNOWNVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Unknownvalue
		{
			get
			{
				return this._unknownvalue;
			}
			set
			{
				if (((_unknownvalue == value)
							== false))
				{
					this.OnUnknownvalueChanging(value);
					this._unknownvalue = value;
					this.OnUnknownvalueChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_validRuleText", Name = "VALID_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidRuleText
		{
			get
			{
				return this._validRuleText;
			}
			set
			{
				if (((_validRuleText == value)
							== false))
				{
					this.OnValidRuleTextChanging(value);
					this._validRuleText = value;
					this.OnValidRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_validvaluefieldFlag", Name = "VALIDVALUEFIELD_FLG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidvaluefieldFlag
		{
			get
			{
				return this._validvaluefieldFlag;
			}
			set
			{
				if (((_validvaluefieldFlag == value)
							== false))
				{
					this.OnValidvaluefieldFlagChanging(value);
					this._validvaluefieldFlag = value;
					this.OnValidvaluefieldFlagChanged();
				}
			}
		}

		[Column(Storage = "_visibleRuleID", Name = "VISIBLERULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> VisibleRuleId
		{
			get
			{
				return this._visibleRuleID;
			}
			set
			{
				if ((_visibleRuleID != value))
				{
					this.OnVisibleRuleIdChanging(value);
					this._visibleRuleID = value;
					this.OnVisibleRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_visibleRuleText", Name = "VISIBLE_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string VisibleRuleText
		{
			get
			{
				return this._visibleRuleText;
			}
			set
			{
				if (((_visibleRuleText == value)
							== false))
				{
					this.OnVisibleRuleTextChanging(value);
					this._visibleRuleText = value;
					this.OnVisibleRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_width", Name = "WIDTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Width
		{
			get
			{
				return this._width;
			}
			set
			{
				if ((_width != value))
				{
					this.OnWidthChanging(value);
					this._width = value;
					this.OnWidthChanged();
				}
			}
		}

		[Column(Storage = "_xpos", Name = "XPOS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Xpos
		{
			get
			{
				return this._xpos;
			}
			set
			{
				if ((_xpos != value))
				{
					this.OnXposChanging(value);
					this._xpos = value;
					this.OnXposChanged();
				}
			}
		}

		[Column(Storage = "_ypos", Name = "YPOS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Ypos
		{
			get
			{
				return this._ypos;
			}
			set
			{
				if ((_ypos != value))
				{
					this.OnYposChanging(value);
					this._ypos = value;
					this.OnYposChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ATTR_INSTANCE")]
	public partial class AttrInstance
	{

		private System.Nullable<long> _actionID;

		private System.Nullable<long> _attributeframeID;

		private long _attributeID;

		private long _attrInstanceID;

		private string _caption;

		private string _defaultvalue;

		private string _description;

		private System.Nullable<long> _enabledRuleID;

		private string _entrymask;

		private long _frameID;

		private System.Nullable<long> _height;

		private string _helpstring;

		private string _inputtype;

		private string _lucolumnName;

		private string _lucriteriaFlag;

		private string _ludisplayFlag;

		private string _lustorageFlag;

		private string _lustorageName;

		private System.Nullable<long> _luTypeID;

		private string _mandatoryFlag;

		private System.Nullable<long> _persistRuleID;

		private string _reapplyoverrideFlag;

		private long _sequence;

		private string _spellcheckFlag;

		private System.Nullable<long> _textlength;

		private string _type;

		private string _unknownvalue;

		private System.Nullable<long> _validRuleID;

		private string _validvaluefieldFlag;

		private System.Nullable<long> _visibleRuleID;

		private System.Nullable<long> _width;

		private System.Nullable<long> _xpos;

		private System.Nullable<long> _ypos;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActionIdChanged();

		partial void OnActionIdChanging(System.Nullable<long> value);

		partial void OnAttributeframeIdChanged();

		partial void OnAttributeframeIdChanging(System.Nullable<long> value);

		partial void OnAttributeIdChanged();

		partial void OnAttributeIdChanging(long value);

		partial void OnAttrInstanceIdChanged();

		partial void OnAttrInstanceIdChanging(long value);

		partial void OnCaptionChanged();

		partial void OnCaptionChanging(string value);

		partial void OnDefaultvalueChanged();

		partial void OnDefaultvalueChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<long> value);

		partial void OnEntrymaskChanged();

		partial void OnEntrymaskChanging(string value);

		partial void OnFrameIdChanged();

		partial void OnFrameIdChanging(long value);

		partial void OnHeightChanged();

		partial void OnHeightChanging(System.Nullable<long> value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnInputtypeChanged();

		partial void OnInputtypeChanging(string value);

		partial void OnLucolumnNameChanged();

		partial void OnLucolumnNameChanging(string value);

		partial void OnLucriteriaFlagChanged();

		partial void OnLucriteriaFlagChanging(string value);

		partial void OnLudisplayFlagChanged();

		partial void OnLudisplayFlagChanging(string value);

		partial void OnLustorageFlagChanged();

		partial void OnLustorageFlagChanging(string value);

		partial void OnLustorageNameChanged();

		partial void OnLustorageNameChanging(string value);

		partial void OnLuTypeIdChanged();

		partial void OnLuTypeIdChanging(System.Nullable<long> value);

		partial void OnMandatoryFlagChanged();

		partial void OnMandatoryFlagChanging(string value);

		partial void OnPersistRuleIdChanged();

		partial void OnPersistRuleIdChanging(System.Nullable<long> value);

		partial void OnReapplyoverrideFlagChanged();

		partial void OnReapplyoverrideFlagChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);

		partial void OnSpellcheckFlagChanged();

		partial void OnSpellcheckFlagChanging(string value);

		partial void OnTextlengthChanged();

		partial void OnTextlengthChanging(System.Nullable<long> value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnUnknownvalueChanged();

		partial void OnUnknownvalueChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<long> value);

		partial void OnValidvaluefieldFlagChanged();

		partial void OnValidvaluefieldFlagChanging(string value);

		partial void OnVisibleRuleIdChanged();

		partial void OnVisibleRuleIdChanging(System.Nullable<long> value);

		partial void OnWidthChanged();

		partial void OnWidthChanging(System.Nullable<long> value);

		partial void OnXposChanged();

		partial void OnXposChanging(System.Nullable<long> value);

		partial void OnYposChanged();

		partial void OnYposChanging(System.Nullable<long> value);
		#endregion


		public AttrInstance()
		{
			this.OnCreated();
		}

		[Column(Storage = "_actionID", Name = "ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ActionId
		{
			get
			{
				return this._actionID;
			}
			set
			{
				if ((_actionID != value))
				{
					this.OnActionIdChanging(value);
					this._actionID = value;
					this.OnActionIdChanged();
				}
			}
		}

		[Column(Storage = "_attributeframeID", Name = "ATTRIBUTEFRAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AttributeframeId
		{
			get
			{
				return this._attributeframeID;
			}
			set
			{
				if ((_attributeframeID != value))
				{
					this.OnAttributeframeIdChanging(value);
					this._attributeframeID = value;
					this.OnAttributeframeIdChanged();
				}
			}
		}

		[Column(Storage = "_attributeID", Name = "ATTRIBUTE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttributeId
		{
			get
			{
				return this._attributeID;
			}
			set
			{
				if ((_attributeID != value))
				{
					this.OnAttributeIdChanging(value);
					this._attributeID = value;
					this.OnAttributeIdChanged();
				}
			}
		}

		[Column(Storage = "_attrInstanceID", Name = "ATTR_INSTANCE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AttrInstanceId
		{
			get
			{
				return this._attrInstanceID;
			}
			set
			{
				if ((_attrInstanceID != value))
				{
					this.OnAttrInstanceIdChanging(value);
					this._attrInstanceID = value;
					this.OnAttrInstanceIdChanged();
				}
			}
		}

		[Column(Storage = "_caption", Name = "CAPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Caption
		{
			get
			{
				return this._caption;
			}
			set
			{
				if (((_caption == value)
							== false))
				{
					this.OnCaptionChanging(value);
					this._caption = value;
					this.OnCaptionChanged();
				}
			}
		}

		[Column(Storage = "_defaultvalue", Name = "DEFAULTVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Defaultvalue
		{
			get
			{
				return this._defaultvalue;
			}
			set
			{
				if (((_defaultvalue == value)
							== false))
				{
					this.OnDefaultvalueChanging(value);
					this._defaultvalue = value;
					this.OnDefaultvalueChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_entrymask", Name = "ENTRYMASK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Entrymask
		{
			get
			{
				return this._entrymask;
			}
			set
			{
				if (((_entrymask == value)
							== false))
				{
					this.OnEntrymaskChanging(value);
					this._entrymask = value;
					this.OnEntrymaskChanged();
				}
			}
		}

		[Column(Storage = "_frameID", Name = "FRAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FrameId
		{
			get
			{
				return this._frameID;
			}
			set
			{
				if ((_frameID != value))
				{
					this.OnFrameIdChanging(value);
					this._frameID = value;
					this.OnFrameIdChanged();
				}
			}
		}

		[Column(Storage = "_height", Name = "HEIGHT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Height
		{
			get
			{
				return this._height;
			}
			set
			{
				if ((_height != value))
				{
					this.OnHeightChanging(value);
					this._height = value;
					this.OnHeightChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_inputtype", Name = "INPUTTYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Inputtype
		{
			get
			{
				return this._inputtype;
			}
			set
			{
				if (((_inputtype == value)
							== false))
				{
					this.OnInputtypeChanging(value);
					this._inputtype = value;
					this.OnInputtypeChanged();
				}
			}
		}

		[Column(Storage = "_lucolumnName", Name = "LUCOLUMN_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LucolumnName
		{
			get
			{
				return this._lucolumnName;
			}
			set
			{
				if (((_lucolumnName == value)
							== false))
				{
					this.OnLucolumnNameChanging(value);
					this._lucolumnName = value;
					this.OnLucolumnNameChanged();
				}
			}
		}

		[Column(Storage = "_lucriteriaFlag", Name = "LUCRITERIA_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LucriteriaFlag
		{
			get
			{
				return this._lucriteriaFlag;
			}
			set
			{
				if (((_lucriteriaFlag == value)
							== false))
				{
					this.OnLucriteriaFlagChanging(value);
					this._lucriteriaFlag = value;
					this.OnLucriteriaFlagChanged();
				}
			}
		}

		[Column(Storage = "_ludisplayFlag", Name = "LUDISPLAY_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LudisplayFlag
		{
			get
			{
				return this._ludisplayFlag;
			}
			set
			{
				if (((_ludisplayFlag == value)
							== false))
				{
					this.OnLudisplayFlagChanging(value);
					this._ludisplayFlag = value;
					this.OnLudisplayFlagChanged();
				}
			}
		}

		[Column(Storage = "_lustorageFlag", Name = "LUSTORAGE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LustorageFlag
		{
			get
			{
				return this._lustorageFlag;
			}
			set
			{
				if (((_lustorageFlag == value)
							== false))
				{
					this.OnLustorageFlagChanging(value);
					this._lustorageFlag = value;
					this.OnLustorageFlagChanged();
				}
			}
		}

		[Column(Storage = "_lustorageName", Name = "LUSTORAGE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LustorageName
		{
			get
			{
				return this._lustorageName;
			}
			set
			{
				if (((_lustorageName == value)
							== false))
				{
					this.OnLustorageNameChanging(value);
					this._lustorageName = value;
					this.OnLustorageNameChanged();
				}
			}
		}

		[Column(Storage = "_luTypeID", Name = "LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LuTypeId
		{
			get
			{
				return this._luTypeID;
			}
			set
			{
				if ((_luTypeID != value))
				{
					this.OnLuTypeIdChanging(value);
					this._luTypeID = value;
					this.OnLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_mandatoryFlag", Name = "MANDATORY_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string MandatoryFlag
		{
			get
			{
				return this._mandatoryFlag;
			}
			set
			{
				if (((_mandatoryFlag == value)
							== false))
				{
					this.OnMandatoryFlagChanging(value);
					this._mandatoryFlag = value;
					this.OnMandatoryFlagChanged();
				}
			}
		}

		[Column(Storage = "_persistRuleID", Name = "PERSISTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PersistRuleId
		{
			get
			{
				return this._persistRuleID;
			}
			set
			{
				if ((_persistRuleID != value))
				{
					this.OnPersistRuleIdChanging(value);
					this._persistRuleID = value;
					this.OnPersistRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_reapplyoverrideFlag", Name = "REAPPLYOVERRIDE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReapplyoverrideFlag
		{
			get
			{
				return this._reapplyoverrideFlag;
			}
			set
			{
				if (((_reapplyoverrideFlag == value)
							== false))
				{
					this.OnReapplyoverrideFlagChanging(value);
					this._reapplyoverrideFlag = value;
					this.OnReapplyoverrideFlagChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_spellcheckFlag", Name = "SPELLCHECK_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpellcheckFlag
		{
			get
			{
				return this._spellcheckFlag;
			}
			set
			{
				if (((_spellcheckFlag == value)
							== false))
				{
					this.OnSpellcheckFlagChanging(value);
					this._spellcheckFlag = value;
					this.OnSpellcheckFlagChanged();
				}
			}
		}

		[Column(Storage = "_textlength", Name = "TEXTLENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Textlength
		{
			get
			{
				return this._textlength;
			}
			set
			{
				if ((_textlength != value))
				{
					this.OnTextlengthChanging(value);
					this._textlength = value;
					this.OnTextlengthChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_unknownvalue", Name = "UNKNOWNVALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Unknownvalue
		{
			get
			{
				return this._unknownvalue;
			}
			set
			{
				if (((_unknownvalue == value)
							== false))
				{
					this.OnUnknownvalueChanging(value);
					this._unknownvalue = value;
					this.OnUnknownvalueChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_validvaluefieldFlag", Name = "VALIDVALUEFIELD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidvaluefieldFlag
		{
			get
			{
				return this._validvaluefieldFlag;
			}
			set
			{
				if (((_validvaluefieldFlag == value)
							== false))
				{
					this.OnValidvaluefieldFlagChanging(value);
					this._validvaluefieldFlag = value;
					this.OnValidvaluefieldFlagChanged();
				}
			}
		}

		[Column(Storage = "_visibleRuleID", Name = "VISIBLERULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> VisibleRuleId
		{
			get
			{
				return this._visibleRuleID;
			}
			set
			{
				if ((_visibleRuleID != value))
				{
					this.OnVisibleRuleIdChanging(value);
					this._visibleRuleID = value;
					this.OnVisibleRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_width", Name = "WIDTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Width
		{
			get
			{
				return this._width;
			}
			set
			{
				if ((_width != value))
				{
					this.OnWidthChanging(value);
					this._width = value;
					this.OnWidthChanged();
				}
			}
		}

		[Column(Storage = "_xpos", Name = "XPOS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Xpos
		{
			get
			{
				return this._xpos;
			}
			set
			{
				if ((_xpos != value))
				{
					this.OnXposChanging(value);
					this._xpos = value;
					this.OnXposChanged();
				}
			}
		}

		[Column(Storage = "_ypos", Name = "YPOS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Ypos
		{
			get
			{
				return this._ypos;
			}
			set
			{
				if ((_ypos != value))
				{
					this.OnYposChanging(value);
					this._ypos = value;
					this.OnYposChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.BRANCH")]
	public partial class Branch
	{

		private long _accountHierarchyLoadID;

		private string _address1;

		private string _address2;

		private string _address3;

		private string _adjPhone;

		private string _altContactFnAme;

		private string _altContactLnAme;

		private string _altPhone;

		private string _altPhone1;

		private string _altPhone2;

		private string _backupFax;

		private long _branchID;

		private string _branchNumber;

		private string _branchType;

		private string _businessCode;

		private string _city;

		private string _contactFnAme;

		private string _contactLnAme;

		private string _contactMnAme;

		private string _contactTitle;

		private string _country;

		private string _emailAddress;

		private string _fax;

		private string _fein;

		private string _foreignZip;

		private System.Nullable<float> _lat;

		private System.Nullable<float> _lon;

		private string _notes;

		private string _officeHours;

		private string _officeName;

		private System.Nullable<long> _officeNumber;

		private string _officeType;

		private string _overnightAddress1;

		private string _overnightAddress2;

		private string _overnightAddressCity;

		private string _overnightAddressState;

		private string _overnightAddressZip;

		private string _phone;

		private string _state;

		private string _status;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccountHierarchyLoadIdChanged();

		partial void OnAccountHierarchyLoadIdChanging(long value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnAddress3Changed();

		partial void OnAddress3Changing(string value);

		partial void OnAdjPhoneChanged();

		partial void OnAdjPhoneChanging(string value);

		partial void OnAltContactFNameChanged();

		partial void OnAltContactFNameChanging(string value);

		partial void OnAltContactLNameChanged();

		partial void OnAltContactLNameChanging(string value);

		partial void OnAltPhoneChanged();

		partial void OnAltPhoneChanging(string value);

		partial void OnAltPhone1Changed();

		partial void OnAltPhone1Changing(string value);

		partial void OnAltPhone2Changed();

		partial void OnAltPhone2Changing(string value);

		partial void OnBackupFaxChanged();

		partial void OnBackupFaxChanging(string value);

		partial void OnBranchIdChanged();

		partial void OnBranchIdChanging(long value);

		partial void OnBranchNumberChanged();

		partial void OnBranchNumberChanging(string value);

		partial void OnBranchTypeChanged();

		partial void OnBranchTypeChanging(string value);

		partial void OnBusinessCodeChanged();

		partial void OnBusinessCodeChanging(string value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnContactFNameChanged();

		partial void OnContactFNameChanging(string value);

		partial void OnContactLNameChanged();

		partial void OnContactLNameChanging(string value);

		partial void OnContactMNameChanged();

		partial void OnContactMNameChanging(string value);

		partial void OnContactTitleChanged();

		partial void OnContactTitleChanging(string value);

		partial void OnCountryChanged();

		partial void OnCountryChanging(string value);

		partial void OnEmailAddressChanged();

		partial void OnEmailAddressChanging(string value);

		partial void OnFaxChanged();

		partial void OnFaxChanging(string value);

		partial void OnFeinChanged();

		partial void OnFeinChanging(string value);

		partial void OnForeignZipChanged();

		partial void OnForeignZipChanging(string value);

		partial void OnLatChanged();

		partial void OnLatChanging(System.Nullable<float> value);

		partial void OnLonChanged();

		partial void OnLonChanging(System.Nullable<float> value);

		partial void OnNotesChanged();

		partial void OnNotesChanging(string value);

		partial void OnOfficeHoursChanged();

		partial void OnOfficeHoursChanging(string value);

		partial void OnOfficeNameChanged();

		partial void OnOfficeNameChanging(string value);

		partial void OnOfficeNumberChanged();

		partial void OnOfficeNumberChanging(System.Nullable<long> value);

		partial void OnOfficeTypeChanged();

		partial void OnOfficeTypeChanging(string value);

		partial void OnOvernightAddress1Changed();

		partial void OnOvernightAddress1Changing(string value);

		partial void OnOvernightAddress2Changed();

		partial void OnOvernightAddress2Changing(string value);

		partial void OnOvernightAddressCityChanged();

		partial void OnOvernightAddressCityChanging(string value);

		partial void OnOvernightAddressStateChanged();

		partial void OnOvernightAddressStateChanging(string value);

		partial void OnOvernightAddressZipChanged();

		partial void OnOvernightAddressZipChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public Branch()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accountHierarchyLoadID", Name = "ACCOUNT_HIERARCHY_LOAD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccountHierarchyLoadId
		{
			get
			{
				return this._accountHierarchyLoadID;
			}
			set
			{
				if ((_accountHierarchyLoadID != value))
				{
					this.OnAccountHierarchyLoadIdChanging(value);
					this._accountHierarchyLoadID = value;
					this.OnAccountHierarchyLoadIdChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS_1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS_2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_address3", Name = "ADDRESS_3", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address3
		{
			get
			{
				return this._address3;
			}
			set
			{
				if (((_address3 == value)
							== false))
				{
					this.OnAddress3Changing(value);
					this._address3 = value;
					this.OnAddress3Changed();
				}
			}
		}

		[Column(Storage = "_adjPhone", Name = "ADJ_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AdjPhone
		{
			get
			{
				return this._adjPhone;
			}
			set
			{
				if (((_adjPhone == value)
							== false))
				{
					this.OnAdjPhoneChanging(value);
					this._adjPhone = value;
					this.OnAdjPhoneChanged();
				}
			}
		}

		[Column(Storage = "_altContactFnAme", Name = "ALT_CONTACT_F_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AltContactFName
		{
			get
			{
				return this._altContactFnAme;
			}
			set
			{
				if (((_altContactFnAme == value)
							== false))
				{
					this.OnAltContactFNameChanging(value);
					this._altContactFnAme = value;
					this.OnAltContactFNameChanged();
				}
			}
		}

		[Column(Storage = "_altContactLnAme", Name = "ALT_CONTACT_L_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AltContactLName
		{
			get
			{
				return this._altContactLnAme;
			}
			set
			{
				if (((_altContactLnAme == value)
							== false))
				{
					this.OnAltContactLNameChanging(value);
					this._altContactLnAme = value;
					this.OnAltContactLNameChanged();
				}
			}
		}

		[Column(Storage = "_altPhone", Name = "ALT_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AltPhone
		{
			get
			{
				return this._altPhone;
			}
			set
			{
				if (((_altPhone == value)
							== false))
				{
					this.OnAltPhoneChanging(value);
					this._altPhone = value;
					this.OnAltPhoneChanged();
				}
			}
		}

		[Column(Storage = "_altPhone1", Name = "ALT_PHONE1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AltPhone1
		{
			get
			{
				return this._altPhone1;
			}
			set
			{
				if (((_altPhone1 == value)
							== false))
				{
					this.OnAltPhone1Changing(value);
					this._altPhone1 = value;
					this.OnAltPhone1Changed();
				}
			}
		}

		[Column(Storage = "_altPhone2", Name = "ALT_PHONE2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AltPhone2
		{
			get
			{
				return this._altPhone2;
			}
			set
			{
				if (((_altPhone2 == value)
							== false))
				{
					this.OnAltPhone2Changing(value);
					this._altPhone2 = value;
					this.OnAltPhone2Changed();
				}
			}
		}

		[Column(Storage = "_backupFax", Name = "BACKUP_FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BackupFax
		{
			get
			{
				return this._backupFax;
			}
			set
			{
				if (((_backupFax == value)
							== false))
				{
					this.OnBackupFaxChanging(value);
					this._backupFax = value;
					this.OnBackupFaxChanged();
				}
			}
		}

		[Column(Storage = "_branchID", Name = "BRANCH_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long BranchId
		{
			get
			{
				return this._branchID;
			}
			set
			{
				if ((_branchID != value))
				{
					this.OnBranchIdChanging(value);
					this._branchID = value;
					this.OnBranchIdChanged();
				}
			}
		}

		[Column(Storage = "_branchNumber", Name = "BRANCH_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BranchNumber
		{
			get
			{
				return this._branchNumber;
			}
			set
			{
				if (((_branchNumber == value)
							== false))
				{
					this.OnBranchNumberChanging(value);
					this._branchNumber = value;
					this.OnBranchNumberChanged();
				}
			}
		}

		[Column(Storage = "_branchType", Name = "BRANCH_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string BranchType
		{
			get
			{
				return this._branchType;
			}
			set
			{
				if (((_branchType == value)
							== false))
				{
					this.OnBranchTypeChanging(value);
					this._branchType = value;
					this.OnBranchTypeChanged();
				}
			}
		}

		[Column(Storage = "_businessCode", Name = "BUSINESS_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BusinessCode
		{
			get
			{
				return this._businessCode;
			}
			set
			{
				if (((_businessCode == value)
							== false))
				{
					this.OnBusinessCodeChanging(value);
					this._businessCode = value;
					this.OnBusinessCodeChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_contactFnAme", Name = "CONTACT_F_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactFName
		{
			get
			{
				return this._contactFnAme;
			}
			set
			{
				if (((_contactFnAme == value)
							== false))
				{
					this.OnContactFNameChanging(value);
					this._contactFnAme = value;
					this.OnContactFNameChanged();
				}
			}
		}

		[Column(Storage = "_contactLnAme", Name = "CONTACT_L_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactLName
		{
			get
			{
				return this._contactLnAme;
			}
			set
			{
				if (((_contactLnAme == value)
							== false))
				{
					this.OnContactLNameChanging(value);
					this._contactLnAme = value;
					this.OnContactLNameChanged();
				}
			}
		}

		[Column(Storage = "_contactMnAme", Name = "CONTACT_M_NAME", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactMName
		{
			get
			{
				return this._contactMnAme;
			}
			set
			{
				if (((_contactMnAme == value)
							== false))
				{
					this.OnContactMNameChanging(value);
					this._contactMnAme = value;
					this.OnContactMNameChanged();
				}
			}
		}

		[Column(Storage = "_contactTitle", Name = "CONTACT_TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactTitle
		{
			get
			{
				return this._contactTitle;
			}
			set
			{
				if (((_contactTitle == value)
							== false))
				{
					this.OnContactTitleChanging(value);
					this._contactTitle = value;
					this.OnContactTitleChanged();
				}
			}
		}

		[Column(Storage = "_country", Name = "COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Country
		{
			get
			{
				return this._country;
			}
			set
			{
				if (((_country == value)
							== false))
				{
					this.OnCountryChanging(value);
					this._country = value;
					this.OnCountryChanged();
				}
			}
		}

		[Column(Storage = "_emailAddress", Name = "EMAIL_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmailAddress
		{
			get
			{
				return this._emailAddress;
			}
			set
			{
				if (((_emailAddress == value)
							== false))
				{
					this.OnEmailAddressChanging(value);
					this._emailAddress = value;
					this.OnEmailAddressChanged();
				}
			}
		}

		[Column(Storage = "_fax", Name = "FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fax
		{
			get
			{
				return this._fax;
			}
			set
			{
				if (((_fax == value)
							== false))
				{
					this.OnFaxChanging(value);
					this._fax = value;
					this.OnFaxChanged();
				}
			}
		}

		[Column(Storage = "_fein", Name = "FEIN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fein
		{
			get
			{
				return this._fein;
			}
			set
			{
				if (((_fein == value)
							== false))
				{
					this.OnFeinChanging(value);
					this._fein = value;
					this.OnFeinChanged();
				}
			}
		}

		[Column(Storage = "_foreignZip", Name = "FOREIGN_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ForeignZip
		{
			get
			{
				return this._foreignZip;
			}
			set
			{
				if (((_foreignZip == value)
							== false))
				{
					this.OnForeignZipChanging(value);
					this._foreignZip = value;
					this.OnForeignZipChanged();
				}
			}
		}

		[Column(Storage = "_lat", Name = "LAT", DbType = "FLOAT", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Lat
		{
			get
			{
				return this._lat;
			}
			set
			{
				if ((_lat != value))
				{
					this.OnLatChanging(value);
					this._lat = value;
					this.OnLatChanged();
				}
			}
		}

		[Column(Storage = "_lon", Name = "LON", DbType = "FLOAT", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Lon
		{
			get
			{
				return this._lon;
			}
			set
			{
				if ((_lon != value))
				{
					this.OnLonChanging(value);
					this._lon = value;
					this.OnLonChanged();
				}
			}
		}

		[Column(Storage = "_notes", Name = "NOTES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Notes
		{
			get
			{
				return this._notes;
			}
			set
			{
				if (((_notes == value)
							== false))
				{
					this.OnNotesChanging(value);
					this._notes = value;
					this.OnNotesChanged();
				}
			}
		}

		[Column(Storage = "_officeHours", Name = "OFFICE_HOURS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OfficeHours
		{
			get
			{
				return this._officeHours;
			}
			set
			{
				if (((_officeHours == value)
							== false))
				{
					this.OnOfficeHoursChanging(value);
					this._officeHours = value;
					this.OnOfficeHoursChanged();
				}
			}
		}

		[Column(Storage = "_officeName", Name = "OFFICE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OfficeName
		{
			get
			{
				return this._officeName;
			}
			set
			{
				if (((_officeName == value)
							== false))
				{
					this.OnOfficeNameChanging(value);
					this._officeName = value;
					this.OnOfficeNameChanged();
				}
			}
		}

		[Column(Storage = "_officeNumber", Name = "OFFICE_NUMBER", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> OfficeNumber
		{
			get
			{
				return this._officeNumber;
			}
			set
			{
				if ((_officeNumber != value))
				{
					this.OnOfficeNumberChanging(value);
					this._officeNumber = value;
					this.OnOfficeNumberChanged();
				}
			}
		}

		[Column(Storage = "_officeType", Name = "OFFICE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OfficeType
		{
			get
			{
				return this._officeType;
			}
			set
			{
				if (((_officeType == value)
							== false))
				{
					this.OnOfficeTypeChanging(value);
					this._officeType = value;
					this.OnOfficeTypeChanged();
				}
			}
		}

		[Column(Storage = "_overnightAddress1", Name = "OVERNIGHT_ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OvernightAddress1
		{
			get
			{
				return this._overnightAddress1;
			}
			set
			{
				if (((_overnightAddress1 == value)
							== false))
				{
					this.OnOvernightAddress1Changing(value);
					this._overnightAddress1 = value;
					this.OnOvernightAddress1Changed();
				}
			}
		}

		[Column(Storage = "_overnightAddress2", Name = "OVERNIGHT_ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OvernightAddress2
		{
			get
			{
				return this._overnightAddress2;
			}
			set
			{
				if (((_overnightAddress2 == value)
							== false))
				{
					this.OnOvernightAddress2Changing(value);
					this._overnightAddress2 = value;
					this.OnOvernightAddress2Changed();
				}
			}
		}

		[Column(Storage = "_overnightAddressCity", Name = "OVERNIGHT_ADDRESS_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OvernightAddressCity
		{
			get
			{
				return this._overnightAddressCity;
			}
			set
			{
				if (((_overnightAddressCity == value)
							== false))
				{
					this.OnOvernightAddressCityChanging(value);
					this._overnightAddressCity = value;
					this.OnOvernightAddressCityChanged();
				}
			}
		}

		[Column(Storage = "_overnightAddressState", Name = "OVERNIGHT_ADDRESS_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OvernightAddressState
		{
			get
			{
				return this._overnightAddressState;
			}
			set
			{
				if (((_overnightAddressState == value)
							== false))
				{
					this.OnOvernightAddressStateChanging(value);
					this._overnightAddressState = value;
					this.OnOvernightAddressStateChanged();
				}
			}
		}

		[Column(Storage = "_overnightAddressZip", Name = "OVERNIGHT_ADDRESS_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OvernightAddressZip
		{
			get
			{
				return this._overnightAddressZip;
			}
			set
			{
				if (((_overnightAddressZip == value)
							== false))
				{
					this.OnOvernightAddressZipChanging(value);
					this._overnightAddressZip = value;
					this.OnOvernightAddressZipChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.BRANCHASSIGNMENTRULE")]
	public partial class BranchassignmentRule
	{

		private long _branchassignmentRuleID;

		private long _branchassignmenttypeID;

		private long _branchID;

		private string _lobCode;

		private string _routingfips;

		private string _routingstate;

		private string _routingzip;

		private System.Nullable<long> _ruleID;

		private long _sequence;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBranchassignmentRuleIdChanged();

		partial void OnBranchassignmentRuleIdChanging(long value);

		partial void OnBranchassignmenttypeIdChanged();

		partial void OnBranchassignmenttypeIdChanging(long value);

		partial void OnBranchIdChanged();

		partial void OnBranchIdChanging(long value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnRoutingfipsChanged();

		partial void OnRoutingfipsChanging(string value);

		partial void OnRoutingstateChanged();

		partial void OnRoutingstateChanging(string value);

		partial void OnRoutingzipChanged();

		partial void OnRoutingzipChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);
		#endregion


		public BranchassignmentRule()
		{
			this.OnCreated();
		}

		[Column(Storage = "_branchassignmentRuleID", Name = "BRANCHASSIGNMENTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long BranchassignmentRuleId
		{
			get
			{
				return this._branchassignmentRuleID;
			}
			set
			{
				if ((_branchassignmentRuleID != value))
				{
					this.OnBranchassignmentRuleIdChanging(value);
					this._branchassignmentRuleID = value;
					this.OnBranchassignmentRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_branchassignmenttypeID", Name = "BRANCHASSIGNMENTTYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long BranchassignmenttypeId
		{
			get
			{
				return this._branchassignmenttypeID;
			}
			set
			{
				if ((_branchassignmenttypeID != value))
				{
					this.OnBranchassignmenttypeIdChanging(value);
					this._branchassignmenttypeID = value;
					this.OnBranchassignmenttypeIdChanged();
				}
			}
		}

		[Column(Storage = "_branchID", Name = "BRANCH_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long BranchId
		{
			get
			{
				return this._branchID;
			}
			set
			{
				if ((_branchID != value))
				{
					this.OnBranchIdChanging(value);
					this._branchID = value;
					this.OnBranchIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_routingfips", Name = "ROUTINGFIPS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Routingfips
		{
			get
			{
				return this._routingfips;
			}
			set
			{
				if (((_routingfips == value)
							== false))
				{
					this.OnRoutingfipsChanging(value);
					this._routingfips = value;
					this.OnRoutingfipsChanged();
				}
			}
		}

		[Column(Storage = "_routingstate", Name = "ROUTINGSTATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Routingstate
		{
			get
			{
				return this._routingstate;
			}
			set
			{
				if (((_routingstate == value)
							== false))
				{
					this.OnRoutingstateChanging(value);
					this._routingstate = value;
					this.OnRoutingstateChanged();
				}
			}
		}

		[Column(Storage = "_routingzip", Name = "ROUTINGZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Routingzip
		{
			get
			{
				return this._routingzip;
			}
			set
			{
				if (((_routingzip == value)
							== false))
				{
					this.OnRoutingzipChanging(value);
					this._routingzip = value;
					this.OnRoutingzipChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.BRANCHASSIGNMENTTYPE")]
	public partial class Branchassignmenttype
	{

		private long _accntHrcyStepID;

		private long _branchassignmenttypeID;

		private string _description;

		private System.Nullable<long> _ruleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnBranchassignmenttypeIdChanged();

		partial void OnBranchassignmenttypeIdChanging(long value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);
		#endregion


		public Branchassignmenttype()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_branchassignmenttypeID", Name = "BRANCHASSIGNMENTTYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long BranchassignmenttypeId
		{
			get
			{
				return this._branchassignmenttypeID;
			}
			set
			{
				if ((_branchassignmenttypeID != value))
				{
					this.OnBranchassignmenttypeIdChanging(value);
					this._branchassignmenttypeID = value;
					this.OnBranchassignmenttypeIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CALENDAR")]
	public partial class Calendar
	{

		private System.DateTime _endDate;

		private string _period;

		private System.DateTime _startDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnEndDateChanged();

		partial void OnEndDateChanging(System.DateTime value);

		partial void OnPeriodChanged();

		partial void OnPeriodChanging(string value);

		partial void OnStartDateChanged();

		partial void OnStartDateChanging(System.DateTime value);
		#endregion


		public Calendar()
		{
			this.OnCreated();
		}

		[Column(Storage = "_endDate", Name = "END_DATE", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime EndDate
		{
			get
			{
				return this._endDate;
			}
			set
			{
				if ((_endDate != value))
				{
					this.OnEndDateChanging(value);
					this._endDate = value;
					this.OnEndDateChanged();
				}
			}
		}

		[Column(Storage = "_period", Name = "PERIOD", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Period
		{
			get
			{
				return this._period;
			}
			set
			{
				if (((_period == value)
							== false))
				{
					this.OnPeriodChanging(value);
					this._period = value;
					this.OnPeriodChanged();
				}
			}
		}

		[Column(Storage = "_startDate", Name = "START_DATE", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime StartDate
		{
			get
			{
				return this._startDate;
			}
			set
			{
				if ((_startDate != value))
				{
					this.OnStartDateChanging(value);
					this._startDate = value;
					this.OnStartDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CALL")]
	public partial class Call
	{

		private string _accessCode;

		private long _accntHrcyStepID;

		private System.Nullable<System.DateTime> _callEndTime;

		private string _callerInfo;

		private System.Nullable<long> _callflowID;

		private long _callID;

		private System.DateTime _callStartTime;

		private string _claimNumber;

		private long _clientHrcyStepID;

		private System.DateTime _createdDate;

		private string _emailAddress;

		private string _enrollmentStatusCode;

		private string _enrollmentStatusReason;

		private System.Nullable<long> _entryPointHrcyStepID;

		private string _inputSystemName;

		private string _inputType;

		private System.DateTime _lastModifiedDate;

		private System.Nullable<long> _legacyCallID;

		private string _lobCode;

		private string _location;

		private System.Nullable<long> _orginalCallID;

		private string _policyNumber;

		private string _serverName;

		private string _status;

		private string _switchCallID;

		private string _type;

		private System.Nullable<long> _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccessCodeChanged();

		partial void OnAccessCodeChanging(string value);

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnCallEndTimeChanged();

		partial void OnCallEndTimeChanging(System.Nullable<System.DateTime> value);

		partial void OnCallerInfoChanged();

		partial void OnCallerInfoChanging(string value);

		partial void OnCallflowIdChanged();

		partial void OnCallflowIdChanging(System.Nullable<long> value);

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(long value);

		partial void OnCallStartTimeChanged();

		partial void OnCallStartTimeChanging(System.DateTime value);

		partial void OnClaimNumberChanged();

		partial void OnClaimNumberChanging(string value);

		partial void OnClientHrcyStepIdChanged();

		partial void OnClientHrcyStepIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnEmailAddressChanged();

		partial void OnEmailAddressChanging(string value);

		partial void OnEnrollmentStatusCodeChanged();

		partial void OnEnrollmentStatusCodeChanging(string value);

		partial void OnEnrollmentStatusReasonChanged();

		partial void OnEnrollmentStatusReasonChanging(string value);

		partial void OnEntryPointHrcyStepIdChanged();

		partial void OnEntryPointHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnInputSystemNameChanged();

		partial void OnInputSystemNameChanging(string value);

		partial void OnInputTypeChanged();

		partial void OnInputTypeChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnLegacyCallIdChanged();

		partial void OnLegacyCallIdChanging(System.Nullable<long> value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnLocationChanged();

		partial void OnLocationChanging(string value);

		partial void OnOrginalCallIdChanged();

		partial void OnOrginalCallIdChanging(System.Nullable<long> value);

		partial void OnPolicyNumberChanged();

		partial void OnPolicyNumberChanging(string value);

		partial void OnServerNameChanged();

		partial void OnServerNameChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnSwitchCallIdChanged();

		partial void OnSwitchCallIdChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(System.Nullable<long> value);
		#endregion


		public Call()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accessCode", Name = "ACCESS_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AccessCode
		{
			get
			{
				return this._accessCode;
			}
			set
			{
				if (((_accessCode == value)
							== false))
				{
					this.OnAccessCodeChanging(value);
					this._accessCode = value;
					this.OnAccessCodeChanged();
				}
			}
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_callEndTime", Name = "CALL_END_TIME", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CallEndTime
		{
			get
			{
				return this._callEndTime;
			}
			set
			{
				if ((_callEndTime != value))
				{
					this.OnCallEndTimeChanging(value);
					this._callEndTime = value;
					this.OnCallEndTimeChanged();
				}
			}
		}

		[Column(Storage = "_callerInfo", Name = "CALLER_INFO", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CallerInfo
		{
			get
			{
				return this._callerInfo;
			}
			set
			{
				if (((_callerInfo == value)
							== false))
				{
					this.OnCallerInfoChanging(value);
					this._callerInfo = value;
					this.OnCallerInfoChanged();
				}
			}
		}

		[Column(Storage = "_callflowID", Name = "CALLFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CallflowId
		{
			get
			{
				return this._callflowID;
			}
			set
			{
				if ((_callflowID != value))
				{
					this.OnCallflowIdChanging(value);
					this._callflowID = value;
					this.OnCallflowIdChanged();
				}
			}
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}

		[Column(Storage = "_callStartTime", Name = "CALL_START_TIME", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CallStartTime
		{
			get
			{
				return this._callStartTime;
			}
			set
			{
				if ((_callStartTime != value))
				{
					this.OnCallStartTimeChanging(value);
					this._callStartTime = value;
					this.OnCallStartTimeChanged();
				}
			}
		}

		[Column(Storage = "_claimNumber", Name = "CLAIM_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ClaimNumber
		{
			get
			{
				return this._claimNumber;
			}
			set
			{
				if (((_claimNumber == value)
							== false))
				{
					this.OnClaimNumberChanging(value);
					this._claimNumber = value;
					this.OnClaimNumberChanged();
				}
			}
		}

		[Column(Storage = "_clientHrcyStepID", Name = "CLIENT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClientHrcyStepId
		{
			get
			{
				return this._clientHrcyStepID;
			}
			set
			{
				if ((_clientHrcyStepID != value))
				{
					this.OnClientHrcyStepIdChanging(value);
					this._clientHrcyStepID = value;
					this.OnClientHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_emailAddress", Name = "EMAIL_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmailAddress
		{
			get
			{
				return this._emailAddress;
			}
			set
			{
				if (((_emailAddress == value)
							== false))
				{
					this.OnEmailAddressChanging(value);
					this._emailAddress = value;
					this.OnEmailAddressChanged();
				}
			}
		}

		[Column(Storage = "_enrollmentStatusCode", Name = "ENROLLMENT_STATUS_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnrollmentStatusCode
		{
			get
			{
				return this._enrollmentStatusCode;
			}
			set
			{
				if (((_enrollmentStatusCode == value)
							== false))
				{
					this.OnEnrollmentStatusCodeChanging(value);
					this._enrollmentStatusCode = value;
					this.OnEnrollmentStatusCodeChanged();
				}
			}
		}

		[Column(Storage = "_enrollmentStatusReason", Name = "ENROLLMENT_STATUS_REASON", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnrollmentStatusReason
		{
			get
			{
				return this._enrollmentStatusReason;
			}
			set
			{
				if (((_enrollmentStatusReason == value)
							== false))
				{
					this.OnEnrollmentStatusReasonChanging(value);
					this._enrollmentStatusReason = value;
					this.OnEnrollmentStatusReasonChanged();
				}
			}
		}

		[Column(Storage = "_entryPointHrcyStepID", Name = "ENTRY_POINT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EntryPointHrcyStepId
		{
			get
			{
				return this._entryPointHrcyStepID;
			}
			set
			{
				if ((_entryPointHrcyStepID != value))
				{
					this.OnEntryPointHrcyStepIdChanging(value);
					this._entryPointHrcyStepID = value;
					this.OnEntryPointHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_inputSystemName", Name = "INPUT_SYSTEM_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string InputSystemName
		{
			get
			{
				return this._inputSystemName;
			}
			set
			{
				if (((_inputSystemName == value)
							== false))
				{
					this.OnInputSystemNameChanging(value);
					this._inputSystemName = value;
					this.OnInputSystemNameChanged();
				}
			}
		}

		[Column(Storage = "_inputType", Name = "INPUT_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string InputType
		{
			get
			{
				return this._inputType;
			}
			set
			{
				if (((_inputType == value)
							== false))
				{
					this.OnInputTypeChanging(value);
					this._inputType = value;
					this.OnInputTypeChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_legacyCallID", Name = "LEGACY_CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LegacyCallId
		{
			get
			{
				return this._legacyCallID;
			}
			set
			{
				if ((_legacyCallID != value))
				{
					this.OnLegacyCallIdChanging(value);
					this._legacyCallID = value;
					this.OnLegacyCallIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_location", Name = "LOCATION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Location
		{
			get
			{
				return this._location;
			}
			set
			{
				if (((_location == value)
							== false))
				{
					this.OnLocationChanging(value);
					this._location = value;
					this.OnLocationChanged();
				}
			}
		}

		[Column(Storage = "_orginalCallID", Name = "ORGINAL_CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> OrginalCallId
		{
			get
			{
				return this._orginalCallID;
			}
			set
			{
				if ((_orginalCallID != value))
				{
					this.OnOrginalCallIdChanging(value);
					this._orginalCallID = value;
					this.OnOrginalCallIdChanged();
				}
			}
		}

		[Column(Storage = "_policyNumber", Name = "POLICY_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PolicyNumber
		{
			get
			{
				return this._policyNumber;
			}
			set
			{
				if (((_policyNumber == value)
							== false))
				{
					this.OnPolicyNumberChanging(value);
					this._policyNumber = value;
					this.OnPolicyNumberChanged();
				}
			}
		}

		[Column(Storage = "_serverName", Name = "SERVER_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ServerName
		{
			get
			{
				return this._serverName;
			}
			set
			{
				if (((_serverName == value)
							== false))
				{
					this.OnServerNameChanging(value);
					this._serverName = value;
					this.OnServerNameChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_switchCallID", Name = "SWITCH_CALL_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SwitchCallId
		{
			get
			{
				return this._switchCallID;
			}
			set
			{
				if (((_switchCallID == value)
							== false))
				{
					this.OnSwitchCallIdChanging(value);
					this._switchCallID = value;
					this.OnSwitchCallIdChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CALLFLOW")]
	public partial class Callflow
	{

		private long _callflowID;

		private long _calltypeID;

		private string _catFlag;

		private string _description;

		private System.DateTime _modifiedDate;

		private string _name;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCallflowIdChanged();

		partial void OnCallflowIdChanging(long value);

		partial void OnCalltypeIdChanged();

		partial void OnCalltypeIdChanging(long value);

		partial void OnCatFlagChanged();

		partial void OnCatFlagChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.DateTime value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);
		#endregion


		public Callflow()
		{
			this.OnCreated();
		}

		[Column(Storage = "_callflowID", Name = "CALLFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallflowId
		{
			get
			{
				return this._callflowID;
			}
			set
			{
				if ((_callflowID != value))
				{
					this.OnCallflowIdChanging(value);
					this._callflowID = value;
					this.OnCallflowIdChanged();
				}
			}
		}

		[Column(Storage = "_calltypeID", Name = "CALLTYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CalltypeId
		{
			get
			{
				return this._calltypeID;
			}
			set
			{
				if ((_calltypeID != value))
				{
					this.OnCalltypeIdChanging(value);
					this._calltypeID = value;
					this.OnCalltypeIdChanged();
				}
			}
		}

		[Column(Storage = "_catFlag", Name = "CAT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string CatFlag
		{
			get
			{
				return this._catFlag;
			}
			set
			{
				if (((_catFlag == value)
							== false))
				{
					this.OnCatFlagChanging(value);
					this._catFlag = value;
					this.OnCatFlagChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CALLFLOW_VIEW")]
	public partial class CallflowView
	{

		private long _accntHrcyStepID;

		private long _accountcallflowID;

		private System.Nullable<decimal> _actionID;

		private string _actionText;

		private System.DateTime _activeEndDate;

		private System.DateTime _activeStartDate;

		private string _attributePrefix;

		private string _backgroundstyle;

		private string _callflowDecription;

		private long _callflowID;

		private string _callflowName;

		private string _callflowType;

		private System.Nullable<long> _callflowValidRuleID;

		private string _callflowValidRuleText;

		private string _callStartFlag;

		private long _calltypeID;

		private string _catFlag;

		private string _enabledifRuleText;

		private System.Nullable<decimal> _enabledRuleID;

		private System.Nullable<decimal> _entryActionID;

		private string _entryActionText;

		private string _fnsClientCode;

		private string _frameDecription;

		private long _frameID;

		private string _frameName;

		private string _helpstring;

		private string _lobCode;

		private System.Nullable<decimal> _maxpageresultrows;

		private string _modalFlag;

		private string _onerowautoselectFlag;

		private System.Nullable<long> _sequence;

		private string _sqlfrom;

		private string _sqlorderby;

		private string _sqlselect;

		private string _sqlwhere;

		private string _title;

		private string _type;

		private string _validifRuleText;

		private System.Nullable<decimal> _validRuleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAccountcallflowIdChanged();

		partial void OnAccountcallflowIdChanging(long value);

		partial void OnActionIdChanged();

		partial void OnActionIdChanging(System.Nullable<decimal> value);

		partial void OnActionTextChanged();

		partial void OnActionTextChanging(string value);

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.DateTime value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.DateTime value);

		partial void OnAttributePrefixChanged();

		partial void OnAttributePrefixChanging(string value);

		partial void OnBackgroundstyleChanged();

		partial void OnBackgroundstyleChanging(string value);

		partial void OnCallflowDecriptionChanged();

		partial void OnCallflowDecriptionChanging(string value);

		partial void OnCallflowIdChanged();

		partial void OnCallflowIdChanging(long value);

		partial void OnCallflowNameChanged();

		partial void OnCallflowNameChanging(string value);

		partial void OnCallflowTypeChanged();

		partial void OnCallflowTypeChanging(string value);

		partial void OnCallflowValidRuleIdChanged();

		partial void OnCallflowValidRuleIdChanging(System.Nullable<long> value);

		partial void OnCallflowValidRuleTextChanged();

		partial void OnCallflowValidRuleTextChanging(string value);

		partial void OnCallStartFlagChanged();

		partial void OnCallStartFlagChanging(string value);

		partial void OnCalltypeIdChanged();

		partial void OnCalltypeIdChanging(long value);

		partial void OnCatFlagChanged();

		partial void OnCatFlagChanging(string value);

		partial void OnEnabledifRuleTextChanged();

		partial void OnEnabledifRuleTextChanging(string value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<decimal> value);

		partial void OnEntryActionIdChanged();

		partial void OnEntryActionIdChanging(System.Nullable<decimal> value);

		partial void OnEntryActionTextChanged();

		partial void OnEntryActionTextChanging(string value);

		partial void OnFnsClientCodeChanged();

		partial void OnFnsClientCodeChanging(string value);

		partial void OnFrameDecriptionChanged();

		partial void OnFrameDecriptionChanging(string value);

		partial void OnFrameIdChanged();

		partial void OnFrameIdChanging(long value);

		partial void OnFrameNameChanged();

		partial void OnFrameNameChanging(string value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnMaxpageresultrowsChanged();

		partial void OnMaxpageresultrowsChanging(System.Nullable<decimal> value);

		partial void OnModalFlagChanged();

		partial void OnModalFlagChanging(string value);

		partial void OnOnerowautoselectFlagChanged();

		partial void OnOnerowautoselectFlagChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<long> value);

		partial void OnSqlfromChanged();

		partial void OnSqlfromChanging(string value);

		partial void OnSqlorderbyChanged();

		partial void OnSqlorderbyChanging(string value);

		partial void OnSqlselectChanged();

		partial void OnSqlselectChanging(string value);

		partial void OnSqlwhereChanged();

		partial void OnSqlwhereChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnValidifRuleTextChanged();

		partial void OnValidifRuleTextChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<decimal> value);
		#endregion


		public CallflowView()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_accountcallflowID", Name = "ACCOUNTCALLFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccountcallflowId
		{
			get
			{
				return this._accountcallflowID;
			}
			set
			{
				if ((_accountcallflowID != value))
				{
					this.OnAccountcallflowIdChanging(value);
					this._accountcallflowID = value;
					this.OnAccountcallflowIdChanged();
				}
			}
		}

		[Column(Storage = "_actionID", Name = "ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> ActionId
		{
			get
			{
				return this._actionID;
			}
			set
			{
				if ((_actionID != value))
				{
					this.OnActionIdChanging(value);
					this._actionID = value;
					this.OnActionIdChanged();
				}
			}
		}

		[Column(Storage = "_actionText", Name = "ACTION_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ActionText
		{
			get
			{
				return this._actionText;
			}
			set
			{
				if (((_actionText == value)
							== false))
				{
					this.OnActionTextChanging(value);
					this._actionText = value;
					this.OnActionTextChanged();
				}
			}
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_attributePrefix", Name = "ATTRIBUTE_PREFIX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributePrefix
		{
			get
			{
				return this._attributePrefix;
			}
			set
			{
				if (((_attributePrefix == value)
							== false))
				{
					this.OnAttributePrefixChanging(value);
					this._attributePrefix = value;
					this.OnAttributePrefixChanged();
				}
			}
		}

		[Column(Storage = "_backgroundstyle", Name = "BACKGROUNDSTYLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Backgroundstyle
		{
			get
			{
				return this._backgroundstyle;
			}
			set
			{
				if (((_backgroundstyle == value)
							== false))
				{
					this.OnBackgroundstyleChanging(value);
					this._backgroundstyle = value;
					this.OnBackgroundstyleChanged();
				}
			}
		}

		[Column(Storage = "_callflowDecription", Name = "CALLFLOW_DESC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CallflowDecription
		{
			get
			{
				return this._callflowDecription;
			}
			set
			{
				if (((_callflowDecription == value)
							== false))
				{
					this.OnCallflowDecriptionChanging(value);
					this._callflowDecription = value;
					this.OnCallflowDecriptionChanged();
				}
			}
		}

		[Column(Storage = "_callflowID", Name = "CALLFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallflowId
		{
			get
			{
				return this._callflowID;
			}
			set
			{
				if ((_callflowID != value))
				{
					this.OnCallflowIdChanging(value);
					this._callflowID = value;
					this.OnCallflowIdChanged();
				}
			}
		}

		[Column(Storage = "_callflowName", Name = "CALLFLOW_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string CallflowName
		{
			get
			{
				return this._callflowName;
			}
			set
			{
				if (((_callflowName == value)
							== false))
				{
					this.OnCallflowNameChanging(value);
					this._callflowName = value;
					this.OnCallflowNameChanged();
				}
			}
		}

		[Column(Storage = "_callflowType", Name = "CALLFLOW_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CallflowType
		{
			get
			{
				return this._callflowType;
			}
			set
			{
				if (((_callflowType == value)
							== false))
				{
					this.OnCallflowTypeChanging(value);
					this._callflowType = value;
					this.OnCallflowTypeChanged();
				}
			}
		}

		[Column(Storage = "_callflowValidRuleID", Name = "CALLFLOWVALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CallflowValidRuleId
		{
			get
			{
				return this._callflowValidRuleID;
			}
			set
			{
				if ((_callflowValidRuleID != value))
				{
					this.OnCallflowValidRuleIdChanging(value);
					this._callflowValidRuleID = value;
					this.OnCallflowValidRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_callflowValidRuleText", Name = "CALLFLOWVALIDRULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CallflowValidRuleText
		{
			get
			{
				return this._callflowValidRuleText;
			}
			set
			{
				if (((_callflowValidRuleText == value)
							== false))
				{
					this.OnCallflowValidRuleTextChanging(value);
					this._callflowValidRuleText = value;
					this.OnCallflowValidRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_callStartFlag", Name = "CALL_START_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string CallStartFlag
		{
			get
			{
				return this._callStartFlag;
			}
			set
			{
				if (((_callStartFlag == value)
							== false))
				{
					this.OnCallStartFlagChanging(value);
					this._callStartFlag = value;
					this.OnCallStartFlagChanged();
				}
			}
		}

		[Column(Storage = "_calltypeID", Name = "CALLTYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CalltypeId
		{
			get
			{
				return this._calltypeID;
			}
			set
			{
				if ((_calltypeID != value))
				{
					this.OnCalltypeIdChanging(value);
					this._calltypeID = value;
					this.OnCalltypeIdChanged();
				}
			}
		}

		[Column(Storage = "_catFlag", Name = "CAT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string CatFlag
		{
			get
			{
				return this._catFlag;
			}
			set
			{
				if (((_catFlag == value)
							== false))
				{
					this.OnCatFlagChanging(value);
					this._catFlag = value;
					this.OnCatFlagChanged();
				}
			}
		}

		[Column(Storage = "_enabledifRuleText", Name = "ENABLEDIF_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnabledifRuleText
		{
			get
			{
				return this._enabledifRuleText;
			}
			set
			{
				if (((_enabledifRuleText == value)
							== false))
				{
					this.OnEnabledifRuleTextChanging(value);
					this._enabledifRuleText = value;
					this.OnEnabledifRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_entryActionID", Name = "ENTRY_ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> EntryActionId
		{
			get
			{
				return this._entryActionID;
			}
			set
			{
				if ((_entryActionID != value))
				{
					this.OnEntryActionIdChanging(value);
					this._entryActionID = value;
					this.OnEntryActionIdChanged();
				}
			}
		}

		[Column(Storage = "_entryActionText", Name = "ENTRY_ACTION_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EntryActionText
		{
			get
			{
				return this._entryActionText;
			}
			set
			{
				if (((_entryActionText == value)
							== false))
				{
					this.OnEntryActionTextChanging(value);
					this._entryActionText = value;
					this.OnEntryActionTextChanged();
				}
			}
		}

		[Column(Storage = "_fnsClientCode", Name = "FNS_CLIENT_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FnsClientCode
		{
			get
			{
				return this._fnsClientCode;
			}
			set
			{
				if (((_fnsClientCode == value)
							== false))
				{
					this.OnFnsClientCodeChanging(value);
					this._fnsClientCode = value;
					this.OnFnsClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_frameDecription", Name = "FRAME_DESC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FrameDecription
		{
			get
			{
				return this._frameDecription;
			}
			set
			{
				if (((_frameDecription == value)
							== false))
				{
					this.OnFrameDecriptionChanging(value);
					this._frameDecription = value;
					this.OnFrameDecriptionChanged();
				}
			}
		}

		[Column(Storage = "_frameID", Name = "FRAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FrameId
		{
			get
			{
				return this._frameID;
			}
			set
			{
				if ((_frameID != value))
				{
					this.OnFrameIdChanging(value);
					this._frameID = value;
					this.OnFrameIdChanged();
				}
			}
		}

		[Column(Storage = "_frameName", Name = "FRAME_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FrameName
		{
			get
			{
				return this._frameName;
			}
			set
			{
				if (((_frameName == value)
							== false))
				{
					this.OnFrameNameChanging(value);
					this._frameName = value;
					this.OnFrameNameChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_maxpageresultrows", Name = "MAXPAGERESULTROWS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Maxpageresultrows
		{
			get
			{
				return this._maxpageresultrows;
			}
			set
			{
				if ((_maxpageresultrows != value))
				{
					this.OnMaxpageresultrowsChanging(value);
					this._maxpageresultrows = value;
					this.OnMaxpageresultrowsChanged();
				}
			}
		}

		[Column(Storage = "_modalFlag", Name = "MODAL_FLG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ModalFlag
		{
			get
			{
				return this._modalFlag;
			}
			set
			{
				if (((_modalFlag == value)
							== false))
				{
					this.OnModalFlagChanging(value);
					this._modalFlag = value;
					this.OnModalFlagChanged();
				}
			}
		}

		[Column(Storage = "_onerowautoselectFlag", Name = "ONEROWAUTOSELECT_FLG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OnerowautoselectFlag
		{
			get
			{
				return this._onerowautoselectFlag;
			}
			set
			{
				if (((_onerowautoselectFlag == value)
							== false))
				{
					this.OnOnerowautoselectFlagChanging(value);
					this._onerowautoselectFlag = value;
					this.OnOnerowautoselectFlagChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_sqlfrom", Name = "SQLFROM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlfrom
		{
			get
			{
				return this._sqlfrom;
			}
			set
			{
				if (((_sqlfrom == value)
							== false))
				{
					this.OnSqlfromChanging(value);
					this._sqlfrom = value;
					this.OnSqlfromChanged();
				}
			}
		}

		[Column(Storage = "_sqlorderby", Name = "SQLORDERBY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlorderby
		{
			get
			{
				return this._sqlorderby;
			}
			set
			{
				if (((_sqlorderby == value)
							== false))
				{
					this.OnSqlorderbyChanging(value);
					this._sqlorderby = value;
					this.OnSqlorderbyChanged();
				}
			}
		}

		[Column(Storage = "_sqlselect", Name = "SQLSELECT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlselect
		{
			get
			{
				return this._sqlselect;
			}
			set
			{
				if (((_sqlselect == value)
							== false))
				{
					this.OnSqlselectChanging(value);
					this._sqlselect = value;
					this.OnSqlselectChanged();
				}
			}
		}

		[Column(Storage = "_sqlwhere", Name = "SQLWHERE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlwhere
		{
			get
			{
				return this._sqlwhere;
			}
			set
			{
				if (((_sqlwhere == value)
							== false))
				{
					this.OnSqlwhereChanging(value);
					this._sqlwhere = value;
					this.OnSqlwhereChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_validifRuleText", Name = "VALIDIF_RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ValidifRuleText
		{
			get
			{
				return this._validifRuleText;
			}
			set
			{
				if (((_validifRuleText == value)
							== false))
				{
					this.OnValidifRuleTextChanging(value);
					this._validifRuleText = value;
					this.OnValidifRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CALL_ROUTING")]
	public partial class CallRouting
	{

		private long _callID;

		private long _callRoutingID;

		private System.DateTime _createdDate;

		private string _finalSaveStatus;

		private string _lastMessage;

		private System.DateTime _lastModifiedDate;

		private string _routingStatus;

		private string _serverName;

		private long _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(long value);

		partial void OnCallRoutingIdChanged();

		partial void OnCallRoutingIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnFinalSaveStatusChanged();

		partial void OnFinalSaveStatusChanging(string value);

		partial void OnLastMessageChanged();

		partial void OnLastMessageChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnRoutingStatusChanged();

		partial void OnRoutingStatusChanging(string value);

		partial void OnServerNameChanged();

		partial void OnServerNameChanging(string value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(long value);
		#endregion


		public CallRouting()
		{
			this.OnCreated();
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}

		[Column(Storage = "_callRoutingID", Name = "CALL_ROUTING_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallRoutingId
		{
			get
			{
				return this._callRoutingID;
			}
			set
			{
				if ((_callRoutingID != value))
				{
					this.OnCallRoutingIdChanging(value);
					this._callRoutingID = value;
					this.OnCallRoutingIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_finalSaveStatus", Name = "FINAL_SAVE_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FinalSaveStatus
		{
			get
			{
				return this._finalSaveStatus;
			}
			set
			{
				if (((_finalSaveStatus == value)
							== false))
				{
					this.OnFinalSaveStatusChanging(value);
					this._finalSaveStatus = value;
					this.OnFinalSaveStatusChanged();
				}
			}
		}

		[Column(Storage = "_lastMessage", Name = "LAST_MESSAGE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LastMessage
		{
			get
			{
				return this._lastMessage;
			}
			set
			{
				if (((_lastMessage == value)
							== false))
				{
					this.OnLastMessageChanging(value);
					this._lastMessage = value;
					this.OnLastMessageChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_routingStatus", Name = "ROUTING_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string RoutingStatus
		{
			get
			{
				return this._routingStatus;
			}
			set
			{
				if (((_routingStatus == value)
							== false))
				{
					this.OnRoutingStatusChanging(value);
					this._routingStatus = value;
					this.OnRoutingStatusChanged();
				}
			}
		}

		[Column(Storage = "_serverName", Name = "SERVER_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ServerName
		{
			get
			{
				return this._serverName;
			}
			set
			{
				if (((_serverName == value)
							== false))
				{
					this.OnServerNameChanging(value);
					this._serverName = value;
					this.OnServerNameChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CALL_XML")]
	public partial class CallXml
	{

		private long _callID;

		private string _callXml1;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(long value);

		partial void OnCallXml1Changed();

		partial void OnCallXml1Changing(string value);
		#endregion


		public CallXml()
		{
			this.OnCreated();
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}

		[Column(Storage = "_callXml1", Name = "CALL_XML", DbType = "LONG", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CallXml1
		{
			get
			{
				return this._callXml1;
			}
			set
			{
				if (((_callXml1 == value)
							== false))
				{
					this.OnCallXml1Changing(value);
					this._callXml1 = value;
					this.OnCallXml1Changed();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CARRIER")]
	public partial class Carrier
	{

		private string _address1;

		private string _address2;

		private string _bureauCode;

		private string _businessType;

		private long _carrierID;

		private string _carrierNumber;

		private string _city;

		private string _fein;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _name;

		private string _phone;

		private string _state;

		private string _title;

		private string _uploadKey;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnBureauCodeChanged();

		partial void OnBureauCodeChanging(string value);

		partial void OnBusinessTypeChanged();

		partial void OnBusinessTypeChanging(string value);

		partial void OnCarrierIdChanged();

		partial void OnCarrierIdChanging(long value);

		partial void OnCarrierNumberChanged();

		partial void OnCarrierNumberChanging(string value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnFeinChanged();

		partial void OnFeinChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public Carrier()
		{
			this.OnCreated();
		}

		[Column(Storage = "_address1", Name = "ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_bureauCode", Name = "BUREAU_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BureauCode
		{
			get
			{
				return this._bureauCode;
			}
			set
			{
				if (((_bureauCode == value)
							== false))
				{
					this.OnBureauCodeChanging(value);
					this._bureauCode = value;
					this.OnBureauCodeChanged();
				}
			}
		}

		[Column(Storage = "_businessType", Name = "BUSINESS_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BusinessType
		{
			get
			{
				return this._businessType;
			}
			set
			{
				if (((_businessType == value)
							== false))
				{
					this.OnBusinessTypeChanging(value);
					this._businessType = value;
					this.OnBusinessTypeChanged();
				}
			}
		}

		[Column(Storage = "_carrierID", Name = "CARRIER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CarrierId
		{
			get
			{
				return this._carrierID;
			}
			set
			{
				if ((_carrierID != value))
				{
					this.OnCarrierIdChanging(value);
					this._carrierID = value;
					this.OnCarrierIdChanged();
				}
			}
		}

		[Column(Storage = "_carrierNumber", Name = "CARRIER_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CarrierNumber
		{
			get
			{
				return this._carrierNumber;
			}
			set
			{
				if (((_carrierNumber == value)
							== false))
				{
					this.OnCarrierNumberChanging(value);
					this._carrierNumber = value;
					this.OnCarrierNumberChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_fein", Name = "FEIN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fein
		{
			get
			{
				return this._fein;
			}
			set
			{
				if (((_fein == value)
							== false))
				{
					this.OnFeinChanging(value);
					this._fein = value;
					this.OnFeinChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CLAIM_CLASS_ASSIGNMENT")]
	public partial class ClaimClassAssignment
	{

		private System.Nullable<long> _accntHrcyStepID;

		private long _claimClassAssignmentID;

		private string _class;

		private string _lobCode;

		private System.Nullable<long> _ruleID;

		private System.Nullable<long> _seq;

		private System.Nullable<short> _weight;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnClaimClassAssignmentIdChanged();

		partial void OnClaimClassAssignmentIdChanging(long value);

		partial void OnClassChanged();

		partial void OnClassChanging(string value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);

		partial void OnSeqChanged();

		partial void OnSeqChanging(System.Nullable<long> value);

		partial void OnWeightChanged();

		partial void OnWeightChanging(System.Nullable<short> value);
		#endregion


		public ClaimClassAssignment()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_claimClassAssignmentID", Name = "CLAIM_CLASS_ASSIGNMENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClaimClassAssignmentId
		{
			get
			{
				return this._claimClassAssignmentID;
			}
			set
			{
				if ((_claimClassAssignmentID != value))
				{
					this.OnClaimClassAssignmentIdChanging(value);
					this._claimClassAssignmentID = value;
					this.OnClaimClassAssignmentIdChanged();
				}
			}
		}

		[Column(Storage = "_class", Name = "CLASS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Class
		{
			get
			{
				return this._class;
			}
			set
			{
				if (((_class == value)
							== false))
				{
					this.OnClassChanging(value);
					this._class = value;
					this.OnClassChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_seq", Name = "SEQ", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Seq
		{
			get
			{
				return this._seq;
			}
			set
			{
				if ((_seq != value))
				{
					this.OnSeqChanging(value);
					this._seq = value;
					this.OnSeqChanged();
				}
			}
		}

		[Column(Storage = "_weight", Name = "WEIGHT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> Weight
		{
			get
			{
				return this._weight;
			}
			set
			{
				if ((_weight != value))
				{
					this.OnWeightChanging(value);
					this._weight = value;
					this.OnWeightChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CLAIM_KOC_ASSIGNMENT")]
	public partial class ClaimKocAssignment
	{

		private string _activeFlag;

		private string _branchNumber;

		private string _claimKoc;

		private long _claimKocID;

		private System.Nullable<long> _length;

		private System.Nullable<long> _maximum;

		private System.Nullable<long> _minimum;

		private System.Nullable<long> _next;

		private System.Nullable<short> _notifiedNum;

		private System.Nullable<long> _notifyEvery;

		private System.Nullable<long> _routingPlanID;

		private System.Nullable<short> _seq;

		private System.Nullable<long> _warningpercent;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActiveFlagChanged();

		partial void OnActiveFlagChanging(string value);

		partial void OnBranchNumberChanged();

		partial void OnBranchNumberChanging(string value);

		partial void OnClaimKocChanged();

		partial void OnClaimKocChanging(string value);

		partial void OnClaimKocIdChanged();

		partial void OnClaimKocIdChanging(long value);

		partial void OnLengthChanged();

		partial void OnLengthChanging(System.Nullable<long> value);

		partial void OnMaximumChanged();

		partial void OnMaximumChanging(System.Nullable<long> value);

		partial void OnMinimumChanged();

		partial void OnMinimumChanging(System.Nullable<long> value);

		partial void OnNextChanged();

		partial void OnNextChanging(System.Nullable<long> value);

		partial void OnNotifiedNumChanged();

		partial void OnNotifiedNumChanging(System.Nullable<short> value);

		partial void OnNotifyEveryChanged();

		partial void OnNotifyEveryChanging(System.Nullable<long> value);

		partial void OnRoutingPlanIdChanged();

		partial void OnRoutingPlanIdChanging(System.Nullable<long> value);

		partial void OnSeqChanged();

		partial void OnSeqChanging(System.Nullable<short> value);

		partial void OnWarningpercentChanged();

		partial void OnWarningpercentChanging(System.Nullable<long> value);
		#endregion


		public ClaimKocAssignment()
		{
			this.OnCreated();
		}

		[Column(Storage = "_activeFlag", Name = "ACTIVE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ActiveFlag
		{
			get
			{
				return this._activeFlag;
			}
			set
			{
				if (((_activeFlag == value)
							== false))
				{
					this.OnActiveFlagChanging(value);
					this._activeFlag = value;
					this.OnActiveFlagChanged();
				}
			}
		}

		[Column(Storage = "_branchNumber", Name = "BRANCH_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BranchNumber
		{
			get
			{
				return this._branchNumber;
			}
			set
			{
				if (((_branchNumber == value)
							== false))
				{
					this.OnBranchNumberChanging(value);
					this._branchNumber = value;
					this.OnBranchNumberChanged();
				}
			}
		}

		[Column(Storage = "_claimKoc", Name = "CLAIM_KOC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ClaimKoc
		{
			get
			{
				return this._claimKoc;
			}
			set
			{
				if (((_claimKoc == value)
							== false))
				{
					this.OnClaimKocChanging(value);
					this._claimKoc = value;
					this.OnClaimKocChanged();
				}
			}
		}

		[Column(Storage = "_claimKocID", Name = "CLAIM_KOC_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClaimKocId
		{
			get
			{
				return this._claimKocID;
			}
			set
			{
				if ((_claimKocID != value))
				{
					this.OnClaimKocIdChanging(value);
					this._claimKocID = value;
					this.OnClaimKocIdChanged();
				}
			}
		}

		[Column(Storage = "_length", Name = "LENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Length
		{
			get
			{
				return this._length;
			}
			set
			{
				if ((_length != value))
				{
					this.OnLengthChanging(value);
					this._length = value;
					this.OnLengthChanged();
				}
			}
		}

		[Column(Storage = "_maximum", Name = "MAXIMUM", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Maximum
		{
			get
			{
				return this._maximum;
			}
			set
			{
				if ((_maximum != value))
				{
					this.OnMaximumChanging(value);
					this._maximum = value;
					this.OnMaximumChanged();
				}
			}
		}

		[Column(Storage = "_minimum", Name = "MINIMUM", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Minimum
		{
			get
			{
				return this._minimum;
			}
			set
			{
				if ((_minimum != value))
				{
					this.OnMinimumChanging(value);
					this._minimum = value;
					this.OnMinimumChanged();
				}
			}
		}

		[Column(Storage = "_next", Name = "NEXT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Next
		{
			get
			{
				return this._next;
			}
			set
			{
				if ((_next != value))
				{
					this.OnNextChanging(value);
					this._next = value;
					this.OnNextChanged();
				}
			}
		}

		[Column(Storage = "_notifiedNum", Name = "NOTIFIED_NUM", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> NotifiedNum
		{
			get
			{
				return this._notifiedNum;
			}
			set
			{
				if ((_notifiedNum != value))
				{
					this.OnNotifiedNumChanging(value);
					this._notifiedNum = value;
					this.OnNotifiedNumChanged();
				}
			}
		}

		[Column(Storage = "_notifyEvery", Name = "NOTIFY_EVERY", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> NotifyEvery
		{
			get
			{
				return this._notifyEvery;
			}
			set
			{
				if ((_notifyEvery != value))
				{
					this.OnNotifyEveryChanging(value);
					this._notifyEvery = value;
					this.OnNotifyEveryChanged();
				}
			}
		}

		[Column(Storage = "_routingPlanID", Name = "ROUTING_PLAN_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RoutingPlanId
		{
			get
			{
				return this._routingPlanID;
			}
			set
			{
				if ((_routingPlanID != value))
				{
					this.OnRoutingPlanIdChanging(value);
					this._routingPlanID = value;
					this.OnRoutingPlanIdChanged();
				}
			}
		}

		[Column(Storage = "_seq", Name = "SEQ", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> Seq
		{
			get
			{
				return this._seq;
			}
			set
			{
				if ((_seq != value))
				{
					this.OnSeqChanging(value);
					this._seq = value;
					this.OnSeqChanged();
				}
			}
		}

		[Column(Storage = "_warningpercent", Name = "WARNINGPERCENT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Warningpercent
		{
			get
			{
				return this._warningpercent;
			}
			set
			{
				if ((_warningpercent != value))
				{
					this.OnWarningpercentChanging(value);
					this._warningpercent = value;
					this.OnWarningpercentChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CLAIMNUMBERASSIGNMENTRULE")]
	public partial class ClaimnumberassignmentRule
	{

		private long _accntHrcyStepID;

		private string _assignToAttrName;

		private System.Nullable<long> _branchID;

		private long _claimnumberassignmentRuleID;

		private System.Nullable<long> _length;

		private string _lobCode;

		private System.Nullable<long> _maximum;

		private System.Nullable<long> _minimum;

		private System.Nullable<long> _next;

		private string _prefix;

		private string _reuseFlag;

		private System.Nullable<long> _ruleID;

		private System.Nullable<long> _sequence;

		private string _suffix;

		private string _usedupFlag;

		private System.Nullable<long> _warningpercent;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAssignToAttrNameChanged();

		partial void OnAssignToAttrNameChanging(string value);

		partial void OnBranchIdChanged();

		partial void OnBranchIdChanging(System.Nullable<long> value);

		partial void OnClaimnumberassignmentRuleIdChanged();

		partial void OnClaimnumberassignmentRuleIdChanging(long value);

		partial void OnLengthChanged();

		partial void OnLengthChanging(System.Nullable<long> value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnMaximumChanged();

		partial void OnMaximumChanging(System.Nullable<long> value);

		partial void OnMinimumChanged();

		partial void OnMinimumChanging(System.Nullable<long> value);

		partial void OnNextChanged();

		partial void OnNextChanging(System.Nullable<long> value);

		partial void OnPrefixChanged();

		partial void OnPrefixChanging(string value);

		partial void OnReuseFlagChanged();

		partial void OnReuseFlagChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<long> value);

		partial void OnSuffixChanged();

		partial void OnSuffixChanging(string value);

		partial void OnUsedupFlagChanged();

		partial void OnUsedupFlagChanging(string value);

		partial void OnWarningpercentChanged();

		partial void OnWarningpercentChanging(System.Nullable<long> value);
		#endregion


		public ClaimnumberassignmentRule()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_assignToAttrName", Name = "ASSIGN_TO_ATTR_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AssignToAttrName
		{
			get
			{
				return this._assignToAttrName;
			}
			set
			{
				if (((_assignToAttrName == value)
							== false))
				{
					this.OnAssignToAttrNameChanging(value);
					this._assignToAttrName = value;
					this.OnAssignToAttrNameChanged();
				}
			}
		}

		[Column(Storage = "_branchID", Name = "BRANCH_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> BranchId
		{
			get
			{
				return this._branchID;
			}
			set
			{
				if ((_branchID != value))
				{
					this.OnBranchIdChanging(value);
					this._branchID = value;
					this.OnBranchIdChanged();
				}
			}
		}

		[Column(Storage = "_claimnumberassignmentRuleID", Name = "CLAIMNUMBERASSIGNMENTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClaimnumberassignmentRuleId
		{
			get
			{
				return this._claimnumberassignmentRuleID;
			}
			set
			{
				if ((_claimnumberassignmentRuleID != value))
				{
					this.OnClaimnumberassignmentRuleIdChanging(value);
					this._claimnumberassignmentRuleID = value;
					this.OnClaimnumberassignmentRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_length", Name = "LENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Length
		{
			get
			{
				return this._length;
			}
			set
			{
				if ((_length != value))
				{
					this.OnLengthChanging(value);
					this._length = value;
					this.OnLengthChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_maximum", Name = "MAXIMUM", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Maximum
		{
			get
			{
				return this._maximum;
			}
			set
			{
				if ((_maximum != value))
				{
					this.OnMaximumChanging(value);
					this._maximum = value;
					this.OnMaximumChanged();
				}
			}
		}

		[Column(Storage = "_minimum", Name = "MINIMUM", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Minimum
		{
			get
			{
				return this._minimum;
			}
			set
			{
				if ((_minimum != value))
				{
					this.OnMinimumChanging(value);
					this._minimum = value;
					this.OnMinimumChanged();
				}
			}
		}

		[Column(Storage = "_next", Name = "NEXT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Next
		{
			get
			{
				return this._next;
			}
			set
			{
				if ((_next != value))
				{
					this.OnNextChanging(value);
					this._next = value;
					this.OnNextChanged();
				}
			}
		}

		[Column(Storage = "_prefix", Name = "PREFIX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Prefix
		{
			get
			{
				return this._prefix;
			}
			set
			{
				if (((_prefix == value)
							== false))
				{
					this.OnPrefixChanging(value);
					this._prefix = value;
					this.OnPrefixChanged();
				}
			}
		}

		[Column(Storage = "_reuseFlag", Name = "REUSE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ReuseFlag
		{
			get
			{
				return this._reuseFlag;
			}
			set
			{
				if (((_reuseFlag == value)
							== false))
				{
					this.OnReuseFlagChanging(value);
					this._reuseFlag = value;
					this.OnReuseFlagChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_suffix", Name = "SUFFIX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Suffix
		{
			get
			{
				return this._suffix;
			}
			set
			{
				if (((_suffix == value)
							== false))
				{
					this.OnSuffixChanging(value);
					this._suffix = value;
					this.OnSuffixChanged();
				}
			}
		}

		[Column(Storage = "_usedupFlag", Name = "USEDUP_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string UsedupFlag
		{
			get
			{
				return this._usedupFlag;
			}
			set
			{
				if (((_usedupFlag == value)
							== false))
				{
					this.OnUsedupFlagChanging(value);
					this._usedupFlag = value;
					this.OnUsedupFlagChanged();
				}
			}
		}

		[Column(Storage = "_warningpercent", Name = "WARNINGPERCENT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Warningpercent
		{
			get
			{
				return this._warningpercent;
			}
			set
			{
				if ((_warningpercent != value))
				{
					this.OnWarningpercentChanging(value);
					this._warningpercent = value;
					this.OnWarningpercentChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CLAIMNUMBERREUSE")]
	public partial class Claimnumberreuse
	{

		private string _claimnumber;

		private long _claimnumberassignmentRuleID;

		private long _claimnumberreuseID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnClaimnumberChanged();

		partial void OnClaimnumberChanging(string value);

		partial void OnClaimnumberassignmentRuleIdChanged();

		partial void OnClaimnumberassignmentRuleIdChanging(long value);

		partial void OnClaimnumberreuseIdChanged();

		partial void OnClaimnumberreuseIdChanging(long value);
		#endregion


		public Claimnumberreuse()
		{
			this.OnCreated();
		}

		[Column(Storage = "_claimnumber", Name = "CLAIMNUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Claimnumber
		{
			get
			{
				return this._claimnumber;
			}
			set
			{
				if (((_claimnumber == value)
							== false))
				{
					this.OnClaimnumberChanging(value);
					this._claimnumber = value;
					this.OnClaimnumberChanged();
				}
			}
		}

		[Column(Storage = "_claimnumberassignmentRuleID", Name = "CLAIMNUMBERASSIGNMENTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClaimnumberassignmentRuleId
		{
			get
			{
				return this._claimnumberassignmentRuleID;
			}
			set
			{
				if ((_claimnumberassignmentRuleID != value))
				{
					this.OnClaimnumberassignmentRuleIdChanging(value);
					this._claimnumberassignmentRuleID = value;
					this.OnClaimnumberassignmentRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_claimnumberreuseID", Name = "CLAIMNUMBERREUSE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClaimnumberreuseId
		{
			get
			{
				return this._claimnumberreuseID;
			}
			set
			{
				if ((_claimnumberreuseID != value))
				{
					this.OnClaimnumberreuseIdChanging(value);
					this._claimnumberreuseID = value;
					this.OnClaimnumberreuseIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CLAIM_SUBMISSION_LOG")]
	public partial class ClaimSubmissionLog
	{

		private long _claimSubmissionLogID;

		private System.DateTime _createdDate;

		private System.DateTime _lastModifiedDate;

		private string _request;

		private string _response;

		private string _rquID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnClaimSubmissionLogIdChanged();

		partial void OnClaimSubmissionLogIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnRequestChanged();

		partial void OnRequestChanging(string value);

		partial void OnResponseChanged();

		partial void OnResponseChanging(string value);

		partial void OnRquIdChanged();

		partial void OnRquIdChanging(string value);
		#endregion


		public ClaimSubmissionLog()
		{
			this.OnCreated();
		}

		[Column(Storage = "_claimSubmissionLogID", Name = "CLAIM_SUBMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClaimSubmissionLogId
		{
			get
			{
				return this._claimSubmissionLogID;
			}
			set
			{
				if ((_claimSubmissionLogID != value))
				{
					this.OnClaimSubmissionLogIdChanging(value);
					this._claimSubmissionLogID = value;
					this.OnClaimSubmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_request", Name = "REQUEST", DbType = "CLOB", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Request
		{
			get
			{
				return this._request;
			}
			set
			{
				if (((_request == value)
							== false))
				{
					this.OnRequestChanging(value);
					this._request = value;
					this.OnRequestChanged();
				}
			}
		}

		[Column(Storage = "_response", Name = "RESPONSE", DbType = "CLOB", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Response
		{
			get
			{
				return this._response;
			}
			set
			{
				if (((_response == value)
							== false))
				{
					this.OnResponseChanging(value);
					this._response = value;
					this.OnResponseChanged();
				}
			}
		}

		[Column(Storage = "_rquID", Name = "RQUID", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string RquId
		{
			get
			{
				return this._rquID;
			}
			set
			{
				if (((_rquID == value)
							== false))
				{
					this.OnRquIdChanging(value);
					this._rquID = value;
					this.OnRquIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CONFIG_SETTINGS")]
	public partial class ConfigSettings
	{

		private string _application;

		private string _key;

		private string _value;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnApplicationChanged();

		partial void OnApplicationChanging(string value);

		partial void OnKeyChanged();

		partial void OnKeyChanging(string value);

		partial void OnValueChanged();

		partial void OnValueChanging(string value);
		#endregion


		public ConfigSettings()
		{
			this.OnCreated();
		}

		[Column(Storage = "_application", Name = "APPLICATION", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Application
		{
			get
			{
				return this._application;
			}
			set
			{
				if (((_application == value)
							== false))
				{
					this.OnApplicationChanging(value);
					this._application = value;
					this.OnApplicationChanged();
				}
			}
		}

		[Column(Storage = "_key", Name = "KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				if (((_key == value)
							== false))
				{
					this.OnKeyChanging(value);
					this._key = value;
					this.OnKeyChanged();
				}
			}
		}

		[Column(Storage = "_value", Name = "VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (((_value == value)
							== false))
				{
					this.OnValueChanging(value);
					this._value = value;
					this.OnValueChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CONTACT")]
	public partial class Contact
	{

		private long _accntHrcyStepID;

		private string _addressLine1;

		private string _addressLine2;

		private string _city;

		private long _contactID;

		private string _country;

		private string _description;

		private string _email;

		private string _enableFlag;

		private string _fax;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _name;

		private string _phone;

		private string _state;

		private string _title;

		private string _type;

		private string _uploadKey;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAddressLine1Changed();

		partial void OnAddressLine1Changing(string value);

		partial void OnAddressLine2Changed();

		partial void OnAddressLine2Changing(string value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnContactIdChanged();

		partial void OnContactIdChanging(long value);

		partial void OnCountryChanged();

		partial void OnCountryChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEmailChanged();

		partial void OnEmailChanging(string value);

		partial void OnEnableFlagChanged();

		partial void OnEnableFlagChanging(string value);

		partial void OnFaxChanged();

		partial void OnFaxChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public Contact()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_addressLine1", Name = "ADDRESS_LINE1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressLine1
		{
			get
			{
				return this._addressLine1;
			}
			set
			{
				if (((_addressLine1 == value)
							== false))
				{
					this.OnAddressLine1Changing(value);
					this._addressLine1 = value;
					this.OnAddressLine1Changed();
				}
			}
		}

		[Column(Storage = "_addressLine2", Name = "ADDRESS_LINE2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressLine2
		{
			get
			{
				return this._addressLine2;
			}
			set
			{
				if (((_addressLine2 == value)
							== false))
				{
					this.OnAddressLine2Changing(value);
					this._addressLine2 = value;
					this.OnAddressLine2Changed();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_contactID", Name = "CONTACT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ContactId
		{
			get
			{
				return this._contactID;
			}
			set
			{
				if ((_contactID != value))
				{
					this.OnContactIdChanging(value);
					this._contactID = value;
					this.OnContactIdChanged();
				}
			}
		}

		[Column(Storage = "_country", Name = "COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Country
		{
			get
			{
				return this._country;
			}
			set
			{
				if (((_country == value)
							== false))
				{
					this.OnCountryChanging(value);
					this._country = value;
					this.OnCountryChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_email", Name = "EMAIL", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value)
							== false))
				{
					this.OnEmailChanging(value);
					this._email = value;
					this.OnEmailChanged();
				}
			}
		}

		[Column(Storage = "_enableFlag", Name = "ENABLE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnableFlag
		{
			get
			{
				return this._enableFlag;
			}
			set
			{
				if (((_enableFlag == value)
							== false))
				{
					this.OnEnableFlagChanging(value);
					this._enableFlag = value;
					this.OnEnableFlagChanged();
				}
			}
		}

		[Column(Storage = "_fax", Name = "FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fax
		{
			get
			{
				return this._fax;
			}
			set
			{
				if (((_fax == value)
							== false))
				{
					this.OnFaxChanging(value);
					this._fax = value;
					this.OnFaxChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CONTACT_METHOD")]
	public partial class ContactMethod
	{

		private long _contactMethodID;

		private string _description;

		private string _name;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnContactMethodIdChanged();

		partial void OnContactMethodIdChanging(long value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);
		#endregion


		public ContactMethod()
		{
			this.OnCreated();
		}

		[Column(Storage = "_contactMethodID", Name = "CONTACT_METHOD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ContactMethodId
		{
			get
			{
				return this._contactMethodID;
			}
			set
			{
				if ((_contactMethodID != value))
				{
					this.OnContactMethodIdChanging(value);
					this._contactMethodID = value;
					this.OnContactMethodIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CONTACT_PERSON")]
	public partial class ContactPerson
	{

		private System.Nullable<long> _accntHrcyStepID;

		private long _contactPersonID;

		private string _fax;

		private string _fnAme;

		private string _lnAme;

		private string _note;

		private string _phone;

		private string _title;

		private string _type;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnContactPersonIdChanged();

		partial void OnContactPersonIdChanging(long value);

		partial void OnFaxChanged();

		partial void OnFaxChanging(string value);

		partial void OnFNameChanged();

		partial void OnFNameChanging(string value);

		partial void OnLNameChanged();

		partial void OnLNameChanging(string value);

		partial void OnNoteChanged();

		partial void OnNoteChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);
		#endregion


		public ContactPerson()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_contactPersonID", Name = "CONTACT_PERSON_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ContactPersonId
		{
			get
			{
				return this._contactPersonID;
			}
			set
			{
				if ((_contactPersonID != value))
				{
					this.OnContactPersonIdChanging(value);
					this._contactPersonID = value;
					this.OnContactPersonIdChanged();
				}
			}
		}

		[Column(Storage = "_fax", Name = "FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fax
		{
			get
			{
				return this._fax;
			}
			set
			{
				if (((_fax == value)
							== false))
				{
					this.OnFaxChanging(value);
					this._fax = value;
					this.OnFaxChanged();
				}
			}
		}

		[Column(Storage = "_fnAme", Name = "F_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FName
		{
			get
			{
				return this._fnAme;
			}
			set
			{
				if (((_fnAme == value)
							== false))
				{
					this.OnFNameChanging(value);
					this._fnAme = value;
					this.OnFNameChanged();
				}
			}
		}

		[Column(Storage = "_lnAme", Name = "L_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LName
		{
			get
			{
				return this._lnAme;
			}
			set
			{
				if (((_lnAme == value)
							== false))
				{
					this.OnLNameChanging(value);
					this._lnAme = value;
					this.OnLNameChanged();
				}
			}
		}

		[Column(Storage = "_note", Name = "NOTE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Note
		{
			get
			{
				return this._note;
			}
			set
			{
				if (((_note == value)
							== false))
				{
					this.OnNoteChanging(value);
					this._note = value;
					this.OnNoteChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.COVERAGE")]
	public partial class Coverage
	{

		private long _coverageID;

		private System.Nullable<decimal> _deductible;

		private System.Nullable<System.DateTime> _effectiveDate;

		private System.Nullable<System.DateTime> _expirationDate;

		private System.Nullable<decimal> _limit;

		private System.Nullable<long> _policyID;

		private string _type;

		private System.Nullable<long> _vehicleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCoverageIdChanged();

		partial void OnCoverageIdChanging(long value);

		partial void OnDeductibleChanged();

		partial void OnDeductibleChanging(System.Nullable<decimal> value);

		partial void OnEffectiveDateChanged();

		partial void OnEffectiveDateChanging(System.Nullable<System.DateTime> value);

		partial void OnExpirationDateChanged();

		partial void OnExpirationDateChanging(System.Nullable<System.DateTime> value);

		partial void OnLimitChanged();

		partial void OnLimitChanging(System.Nullable<decimal> value);

		partial void OnPolicyIdChanged();

		partial void OnPolicyIdChanging(System.Nullable<long> value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnVehicleIdChanged();

		partial void OnVehicleIdChanging(System.Nullable<long> value);
		#endregion


		public Coverage()
		{
			this.OnCreated();
		}

		[Column(Storage = "_coverageID", Name = "COVERAGE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CoverageId
		{
			get
			{
				return this._coverageID;
			}
			set
			{
				if ((_coverageID != value))
				{
					this.OnCoverageIdChanging(value);
					this._coverageID = value;
					this.OnCoverageIdChanged();
				}
			}
		}

		[Column(Storage = "_deductible", Name = "DEDUCTIBLE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Deductible
		{
			get
			{
				return this._deductible;
			}
			set
			{
				if ((_deductible != value))
				{
					this.OnDeductibleChanging(value);
					this._deductible = value;
					this.OnDeductibleChanged();
				}
			}
		}

		[Column(Storage = "_effectiveDate", Name = "EFFECTIVE_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> EffectiveDate
		{
			get
			{
				return this._effectiveDate;
			}
			set
			{
				if ((_effectiveDate != value))
				{
					this.OnEffectiveDateChanging(value);
					this._effectiveDate = value;
					this.OnEffectiveDateChanged();
				}
			}
		}

		[Column(Storage = "_expirationDate", Name = "EXPIRATION_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ExpirationDate
		{
			get
			{
				return this._expirationDate;
			}
			set
			{
				if ((_expirationDate != value))
				{
					this.OnExpirationDateChanging(value);
					this._expirationDate = value;
					this.OnExpirationDateChanged();
				}
			}
		}

		[Column(Storage = "_limit", Name = "LIMIT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Limit
		{
			get
			{
				return this._limit;
			}
			set
			{
				if ((_limit != value))
				{
					this.OnLimitChanging(value);
					this._limit = value;
					this.OnLimitChanged();
				}
			}
		}

		[Column(Storage = "_policyID", Name = "POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> PolicyId
		{
			get
			{
				return this._policyID;
			}
			set
			{
				if ((_policyID != value))
				{
					this.OnPolicyIdChanging(value);
					this._policyID = value;
					this.OnPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_vehicleID", Name = "VEHICLE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> VehicleId
		{
			get
			{
				return this._vehicleID;
			}
			set
			{
				if ((_vehicleID != value))
				{
					this.OnVehicleIdChanging(value);
					this._vehicleID = value;
					this.OnVehicleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.COVERAGE_TYPE_CISG")]
	public partial class CoverageTypeCisg
	{

		private string _coverageTypeCode;

		private string _description;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCoverageTypeCodeChanged();

		partial void OnCoverageTypeCodeChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);
		#endregion


		public CoverageTypeCisg()
		{
			this.OnCreated();
		}

		[Column(Storage = "_coverageTypeCode", Name = "COVERAGE_TYPE_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string CoverageTypeCode
		{
			get
			{
				return this._coverageTypeCode;
			}
			set
			{
				if (((_coverageTypeCode == value)
							== false))
				{
					this.OnCoverageTypeCodeChanging(value);
					this._coverageTypeCode = value;
					this.OnCoverageTypeCodeChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.CSA_LAST_BRANCH")]
	public partial class CsaLastBranch
	{

		private string _branchNum;

		private long _callID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBranchNumChanged();

		partial void OnBranchNumChanging(string value);

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(long value);
		#endregion


		public CsaLastBranch()
		{
			this.OnCreated();
		}

		[Column(Storage = "_branchNum", Name = "BRANCH_NUM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BranchNum
		{
			get
			{
				return this._branchNum;
			}
			set
			{
				if (((_branchNum == value)
							== false))
				{
					this.OnBranchNumChanging(value);
					this._branchNum = value;
					this.OnBranchNumChanged();
				}
			}
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.DBCONNECTION")]
	public partial class Dbconnection
	{

		private string _connectstring;

		private long _dbconnectionID;

		private string _enabled;

		private string _environment;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnConnectstringChanged();

		partial void OnConnectstringChanging(string value);

		partial void OnDbconnectionIdChanged();

		partial void OnDbconnectionIdChanging(long value);

		partial void OnEnabledChanged();

		partial void OnEnabledChanging(string value);

		partial void OnEnvironmentChanged();

		partial void OnEnvironmentChanging(string value);
		#endregion


		public Dbconnection()
		{
			this.OnCreated();
		}

		[Column(Storage = "_connectstring", Name = "CONNECTSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Connectstring
		{
			get
			{
				return this._connectstring;
			}
			set
			{
				if (((_connectstring == value)
							== false))
				{
					this.OnConnectstringChanging(value);
					this._connectstring = value;
					this.OnConnectstringChanged();
				}
			}
		}

		[Column(Storage = "_dbconnectionID", Name = "DBCONNECTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long DbconnectionId
		{
			get
			{
				return this._dbconnectionID;
			}
			set
			{
				if ((_dbconnectionID != value))
				{
					this.OnDbconnectionIdChanging(value);
					this._dbconnectionID = value;
					this.OnDbconnectionIdChanged();
				}
			}
		}

		[Column(Storage = "_enabled", Name = "ENABLED", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if (((_enabled == value)
							== false))
				{
					this.OnEnabledChanging(value);
					this._enabled = value;
					this.OnEnabledChanged();
				}
			}
		}

		[Column(Storage = "_environment", Name = "ENVIRONMENT", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Environment
		{
			get
			{
				return this._environment;
			}
			set
			{
				if (((_environment == value)
							== false))
				{
					this.OnEnvironmentChanging(value);
					this._environment = value;
					this.OnEnvironmentChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.DBID")]
	public partial class DbId
	{

		private System.Nullable<System.DateTime> _createdDate;

		private string _dbComment;

		private string _dbDecription;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnDbCommentChanged();

		partial void OnDbCommentChanging(string value);

		partial void OnDbDecriptionChanged();

		partial void OnDbDecriptionChanging(string value);
		#endregion


		public DbId()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_dbComment", Name = "DB_COMMENT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DbComment
		{
			get
			{
				return this._dbComment;
			}
			set
			{
				if (((_dbComment == value)
							== false))
				{
					this.OnDbCommentChanging(value);
					this._dbComment = value;
					this.OnDbCommentChanged();
				}
			}
		}

		[Column(Storage = "_dbDecription", Name = "DB_DESC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DbDecription
		{
			get
			{
				return this._dbDecription;
			}
			set
			{
				if (((_dbDecription == value)
							== false))
				{
					this.OnDbDecriptionChanging(value);
					this._dbDecription = value;
					this.OnDbDecriptionChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.DEDICATED_WEBSERVERS")]
	public partial class DedicatedWebservers
	{

		private string _clientcode;

		private string _clientname;

		private string _returnServer;

		private string _server;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnClientcodeChanged();

		partial void OnClientcodeChanging(string value);

		partial void OnClientnameChanged();

		partial void OnClientnameChanging(string value);

		partial void OnReturnServerChanged();

		partial void OnReturnServerChanging(string value);

		partial void OnServerChanged();

		partial void OnServerChanging(string value);
		#endregion


		public DedicatedWebservers()
		{
			this.OnCreated();
		}

		[Column(Storage = "_clientcode", Name = "CLIENTCODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Clientcode
		{
			get
			{
				return this._clientcode;
			}
			set
			{
				if (((_clientcode == value)
							== false))
				{
					this.OnClientcodeChanging(value);
					this._clientcode = value;
					this.OnClientcodeChanged();
				}
			}
		}

		[Column(Storage = "_clientname", Name = "CLIENTNAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Clientname
		{
			get
			{
				return this._clientname;
			}
			set
			{
				if (((_clientname == value)
							== false))
				{
					this.OnClientnameChanging(value);
					this._clientname = value;
					this.OnClientnameChanged();
				}
			}
		}

		[Column(Storage = "_returnServer", Name = "RETURN_SERVER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReturnServer
		{
			get
			{
				return this._returnServer;
			}
			set
			{
				if (((_returnServer == value)
							== false))
				{
					this.OnReturnServerChanging(value);
					this._returnServer = value;
					this.OnReturnServerChanged();
				}
			}
		}

		[Column(Storage = "_server", Name = "SERVER", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Server
		{
			get
			{
				return this._server;
			}
			set
			{
				if (((_server == value)
							== false))
				{
					this.OnServerChanging(value);
					this._server = value;
					this.OnServerChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.DEPARTMENT_CODES")]
	public partial class DepartmentCodes
	{

		private long _accntHrcyStepID;

		private string _accountNumber;

		private string _departmentCode;

		private long _departmentCodesID;

		private string _departmentName;

		private System.Nullable<long> _fileTransmissionLogID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAccountNumberChanged();

		partial void OnAccountNumberChanging(string value);

		partial void OnDepartmentCodeChanged();

		partial void OnDepartmentCodeChanging(string value);

		partial void OnDepartmentCodesIdChanged();

		partial void OnDepartmentCodesIdChanging(long value);

		partial void OnDepartmentNameChanged();

		partial void OnDepartmentNameChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);
		#endregion


		public DepartmentCodes()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_accountNumber", Name = "ACCOUNT_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AccountNumber
		{
			get
			{
				return this._accountNumber;
			}
			set
			{
				if (((_accountNumber == value)
							== false))
				{
					this.OnAccountNumberChanging(value);
					this._accountNumber = value;
					this.OnAccountNumberChanged();
				}
			}
		}

		[Column(Storage = "_departmentCode", Name = "DEPARTMENT_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DepartmentCode
		{
			get
			{
				return this._departmentCode;
			}
			set
			{
				if (((_departmentCode == value)
							== false))
				{
					this.OnDepartmentCodeChanging(value);
					this._departmentCode = value;
					this.OnDepartmentCodeChanged();
				}
			}
		}

		[Column(Storage = "_departmentCodesID", Name = "DEPARTMENT_CODES_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long DepartmentCodesId
		{
			get
			{
				return this._departmentCodesID;
			}
			set
			{
				if ((_departmentCodesID != value))
				{
					this.OnDepartmentCodesIdChanging(value);
					this._departmentCodesID = value;
					this.OnDepartmentCodesIdChanged();
				}
			}
		}

		[Column(Storage = "_departmentName", Name = "DEPARTMENT_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string DepartmentName
		{
			get
			{
				return this._departmentName;
			}
			set
			{
				if (((_departmentName == value)
							== false))
				{
					this.OnDepartmentNameChanging(value);
					this._departmentName = value;
					this.OnDepartmentNameChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.DESTINATION_PROPERTY")]
	public partial class DestinationProperty
	{

		private string _description;

		private string _destinationString;

		private System.Nullable<long> _maxBatchCount;

		private System.Nullable<long> _maxConnectionCount;

		private long _transmissionTypeID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnDestinationStringChanged();

		partial void OnDestinationStringChanging(string value);

		partial void OnMaxBatchCountChanged();

		partial void OnMaxBatchCountChanging(System.Nullable<long> value);

		partial void OnMaxConnectionCountChanged();

		partial void OnMaxConnectionCountChanging(System.Nullable<long> value);

		partial void OnTransmissionTypeIdChanged();

		partial void OnTransmissionTypeIdChanging(long value);
		#endregion


		public DestinationProperty()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_destinationString", Name = "DESTINATION_STRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string DestinationString
		{
			get
			{
				return this._destinationString;
			}
			set
			{
				if (((_destinationString == value)
							== false))
				{
					this.OnDestinationStringChanging(value);
					this._destinationString = value;
					this.OnDestinationStringChanged();
				}
			}
		}

		[Column(Storage = "_maxBatchCount", Name = "MAX_BATCH_COUNT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> MaxBatchCount
		{
			get
			{
				return this._maxBatchCount;
			}
			set
			{
				if ((_maxBatchCount != value))
				{
					this.OnMaxBatchCountChanging(value);
					this._maxBatchCount = value;
					this.OnMaxBatchCountChanged();
				}
			}
		}

		[Column(Storage = "_maxConnectionCount", Name = "MAX_CONNECTION_COUNT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> MaxConnectionCount
		{
			get
			{
				return this._maxConnectionCount;
			}
			set
			{
				if ((_maxConnectionCount != value))
				{
					this.OnMaxConnectionCountChanging(value);
					this._maxConnectionCount = value;
					this.OnMaxConnectionCountChanged();
				}
			}
		}

		[Column(Storage = "_transmissionTypeID", Name = "TRANSMISSION_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long TransmissionTypeId
		{
			get
			{
				return this._transmissionTypeID;
			}
			set
			{
				if ((_transmissionTypeID != value))
				{
					this.OnTransmissionTypeIdChanging(value);
					this._transmissionTypeID = value;
					this.OnTransmissionTypeIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.DIARY_RULES")]
	public partial class DiaryRules
	{

		private long _accntHrcyStepID;

		private string _actionCode;

		private string _code;

		private System.DateTime _createdDate;

		private string _currentFlag;

		private string _description;

		private long _diaryRuleID;

		private System.DateTime _lastModifiedDate;

		private string _lobCode;

		private long _ruleID;

		private System.Nullable<short> _seq;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnActionCodeChanged();

		partial void OnActionCodeChanging(string value);

		partial void OnCodeChanged();

		partial void OnCodeChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnCurrentFlagChanged();

		partial void OnCurrentFlagChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnDiaryRuleIdChanged();

		partial void OnDiaryRuleIdChanging(long value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(long value);

		partial void OnSeqChanged();

		partial void OnSeqChanging(System.Nullable<short> value);
		#endregion


		public DiaryRules()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_actionCode", Name = "ACTION_CODE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ActionCode
		{
			get
			{
				return this._actionCode;
			}
			set
			{
				if (((_actionCode == value)
							== false))
				{
					this.OnActionCodeChanging(value);
					this._actionCode = value;
					this.OnActionCodeChanged();
				}
			}
		}

		[Column(Storage = "_code", Name = "CODE", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if (((_code == value)
							== false))
				{
					this.OnCodeChanging(value);
					this._code = value;
					this.OnCodeChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_currentFlag", Name = "CURRENT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string CurrentFlag
		{
			get
			{
				return this._currentFlag;
			}
			set
			{
				if (((_currentFlag == value)
							== false))
				{
					this.OnCurrentFlagChanging(value);
					this._currentFlag = value;
					this.OnCurrentFlagChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_diaryRuleID", Name = "DIARY_RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long DiaryRuleId
		{
			get
			{
				return this._diaryRuleID;
			}
			set
			{
				if ((_diaryRuleID != value))
				{
					this.OnDiaryRuleIdChanging(value);
					this._diaryRuleID = value;
					this.OnDiaryRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_seq", Name = "SEQ", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> Seq
		{
			get
			{
				return this._seq;
			}
			set
			{
				if ((_seq != value))
				{
					this.OnSeqChanging(value);
					this._seq = value;
					this.OnSeqChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.DISTRIBUTION_SUPPRESSION")]
	public partial class DistributionSuppression
	{

		private string _benefitState;

		private string _branchNumber;

		private string _clientCode;

		private string _distributionSupFlag;

		private long _distributionSuppressionID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBenefitStateChanged();

		partial void OnBenefitStateChanging(string value);

		partial void OnBranchNumberChanged();

		partial void OnBranchNumberChanging(string value);

		partial void OnClientCodeChanged();

		partial void OnClientCodeChanging(string value);

		partial void OnDistributionSupFlagChanged();

		partial void OnDistributionSupFlagChanging(string value);

		partial void OnDistributionSuppressionIdChanged();

		partial void OnDistributionSuppressionIdChanging(long value);
		#endregion


		public DistributionSuppression()
		{
			this.OnCreated();
		}

		[Column(Storage = "_benefitState", Name = "BENEFIT_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BenefitState
		{
			get
			{
				return this._benefitState;
			}
			set
			{
				if (((_benefitState == value)
							== false))
				{
					this.OnBenefitStateChanging(value);
					this._benefitState = value;
					this.OnBenefitStateChanged();
				}
			}
		}

		[Column(Storage = "_branchNumber", Name = "BRANCH_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BranchNumber
		{
			get
			{
				return this._branchNumber;
			}
			set
			{
				if (((_branchNumber == value)
							== false))
				{
					this.OnBranchNumberChanging(value);
					this._branchNumber = value;
					this.OnBranchNumberChanged();
				}
			}
		}

		[Column(Storage = "_clientCode", Name = "CLIENT_CODE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ClientCode
		{
			get
			{
				return this._clientCode;
			}
			set
			{
				if (((_clientCode == value)
							== false))
				{
					this.OnClientCodeChanging(value);
					this._clientCode = value;
					this.OnClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_distributionSupFlag", Name = "DISTRIBUTION_SUP_FLAG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string DistributionSupFlag
		{
			get
			{
				return this._distributionSupFlag;
			}
			set
			{
				if (((_distributionSupFlag == value)
							== false))
				{
					this.OnDistributionSupFlagChanging(value);
					this._distributionSupFlag = value;
					this.OnDistributionSupFlagChanged();
				}
			}
		}

		[Column(Storage = "_distributionSuppressionID", Name = "DISTRIBUTION_SUPPRESSION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long DistributionSuppressionId
		{
			get
			{
				return this._distributionSuppressionID;
			}
			set
			{
				if ((_distributionSuppressionID != value))
				{
					this.OnDistributionSuppressionIdChanging(value);
					this._distributionSuppressionID = value;
					this.OnDistributionSuppressionIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.DRIVER")]
	public partial class Driver
	{

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private string _address1;

		private string _address2;

		private System.Nullable<System.DateTime> _birthDate;

		private string _city;

		private long _driverID;

		private string _driverNumber;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _gender;

		private string _licenseNumber;

		private string _nameFirst;

		private string _nameLast;

		private string _phone;

		private long _policyID;

		private string _relationToInsured;

		private string _ssn;

		private string _state;

		private string _uploadKey;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnBirthDateChanged();

		partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnDriverIdChanged();

		partial void OnDriverIdChanging(long value);

		partial void OnDriverNumberChanged();

		partial void OnDriverNumberChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnGenderChanged();

		partial void OnGenderChanging(string value);

		partial void OnLicenseNumberChanged();

		partial void OnLicenseNumberChanging(string value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnPolicyIdChanged();

		partial void OnPolicyIdChanging(long value);

		partial void OnRelationToInsuredChanged();

		partial void OnRelationToInsuredChanging(string value);

		partial void OnSsnChanged();

		partial void OnSsnChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public Driver()
		{
			this.OnCreated();
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_birthDate", Name = "BIRTH_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._birthDate;
			}
			set
			{
				if ((_birthDate != value))
				{
					this.OnBirthDateChanging(value);
					this._birthDate = value;
					this.OnBirthDateChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_driverID", Name = "DRIVER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long DriverId
		{
			get
			{
				return this._driverID;
			}
			set
			{
				if ((_driverID != value))
				{
					this.OnDriverIdChanging(value);
					this._driverID = value;
					this.OnDriverIdChanged();
				}
			}
		}

		[Column(Storage = "_driverNumber", Name = "DRIVER_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DriverNumber
		{
			get
			{
				return this._driverNumber;
			}
			set
			{
				if (((_driverNumber == value)
							== false))
				{
					this.OnDriverNumberChanging(value);
					this._driverNumber = value;
					this.OnDriverNumberChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_gender", Name = "GENDER", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if (((_gender == value)
							== false))
				{
					this.OnGenderChanging(value);
					this._gender = value;
					this.OnGenderChanged();
				}
			}
		}

		[Column(Storage = "_licenseNumber", Name = "LICENSE_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LicenseNumber
		{
			get
			{
				return this._licenseNumber;
			}
			set
			{
				if (((_licenseNumber == value)
							== false))
				{
					this.OnLicenseNumberChanging(value);
					this._licenseNumber = value;
					this.OnLicenseNumberChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_policyID", Name = "POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long PolicyId
		{
			get
			{
				return this._policyID;
			}
			set
			{
				if ((_policyID != value))
				{
					this.OnPolicyIdChanging(value);
					this._policyID = value;
					this.OnPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_relationToInsured", Name = "RELATION_TO_INSURED", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RelationToInsured
		{
			get
			{
				return this._relationToInsured;
			}
			set
			{
				if (((_relationToInsured == value)
							== false))
				{
					this.OnRelationToInsuredChanging(value);
					this._relationToInsured = value;
					this.OnRelationToInsuredChanged();
				}
			}
		}

		[Column(Storage = "_ssn", Name = "SSN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Ssn
		{
			get
			{
				return this._ssn;
			}
			set
			{
				if (((_ssn == value)
							== false))
				{
					this.OnSsnChanging(value);
					this._ssn = value;
					this.OnSsnChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EDI_OUTBOUND_FIELD")]
	public partial class EdiOutboundField
	{

		private string _attributeName;

		private string _defaultValue;

		private long _ediOutboundFieldID;

		private long _ediOutboundSegmentID;

		private string _fieldName;

		private string _inheritSegmentObjName;

		private string _mandatoryFlag;

		private long _sequence;

		private string _staticFlag;

		private long _typeCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAttributeNameChanged();

		partial void OnAttributeNameChanging(string value);

		partial void OnDefaultValueChanged();

		partial void OnDefaultValueChanging(string value);

		partial void OnEdiOutboundFieldIdChanged();

		partial void OnEdiOutboundFieldIdChanging(long value);

		partial void OnEdiOutboundSegmentIdChanged();

		partial void OnEdiOutboundSegmentIdChanging(long value);

		partial void OnFieldNameChanged();

		partial void OnFieldNameChanging(string value);

		partial void OnInheritSegmentObjNameChanged();

		partial void OnInheritSegmentObjNameChanging(string value);

		partial void OnMandatoryFlagChanged();

		partial void OnMandatoryFlagChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);

		partial void OnStaticFlagChanged();

		partial void OnStaticFlagChanging(string value);

		partial void OnTypeCodeChanged();

		partial void OnTypeCodeChanging(long value);
		#endregion


		public EdiOutboundField()
		{
			this.OnCreated();
		}

		[Column(Storage = "_attributeName", Name = "ATTRIBUTE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value)
							== false))
				{
					this.OnAttributeNameChanging(value);
					this._attributeName = value;
					this.OnAttributeNameChanged();
				}
			}
		}

		[Column(Storage = "_defaultValue", Name = "DEFAULT_VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				if (((_defaultValue == value)
							== false))
				{
					this.OnDefaultValueChanging(value);
					this._defaultValue = value;
					this.OnDefaultValueChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundFieldID", Name = "EDI_OUTBOUND_FIELD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundFieldId
		{
			get
			{
				return this._ediOutboundFieldID;
			}
			set
			{
				if ((_ediOutboundFieldID != value))
				{
					this.OnEdiOutboundFieldIdChanging(value);
					this._ediOutboundFieldID = value;
					this.OnEdiOutboundFieldIdChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundSegmentID", Name = "EDI_OUTBOUND_SEGMENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundSegmentId
		{
			get
			{
				return this._ediOutboundSegmentID;
			}
			set
			{
				if ((_ediOutboundSegmentID != value))
				{
					this.OnEdiOutboundSegmentIdChanging(value);
					this._ediOutboundSegmentID = value;
					this.OnEdiOutboundSegmentIdChanged();
				}
			}
		}

		[Column(Storage = "_fieldName", Name = "FIELD_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FieldName
		{
			get
			{
				return this._fieldName;
			}
			set
			{
				if (((_fieldName == value)
							== false))
				{
					this.OnFieldNameChanging(value);
					this._fieldName = value;
					this.OnFieldNameChanged();
				}
			}
		}

		[Column(Storage = "_inheritSegmentObjName", Name = "INHERIT_SEGMENT_OBJ_NAME", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string InheritSegmentObjName
		{
			get
			{
				return this._inheritSegmentObjName;
			}
			set
			{
				if (((_inheritSegmentObjName == value)
							== false))
				{
					this.OnInheritSegmentObjNameChanging(value);
					this._inheritSegmentObjName = value;
					this.OnInheritSegmentObjNameChanged();
				}
			}
		}

		[Column(Storage = "_mandatoryFlag", Name = "MANDATORY_FLAG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string MandatoryFlag
		{
			get
			{
				return this._mandatoryFlag;
			}
			set
			{
				if (((_mandatoryFlag == value)
							== false))
				{
					this.OnMandatoryFlagChanging(value);
					this._mandatoryFlag = value;
					this.OnMandatoryFlagChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_staticFlag", Name = "STATIC_FLAG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string StaticFlag
		{
			get
			{
				return this._staticFlag;
			}
			set
			{
				if (((_staticFlag == value)
							== false))
				{
					this.OnStaticFlagChanging(value);
					this._staticFlag = value;
					this.OnStaticFlagChanged();
				}
			}
		}

		[Column(Storage = "_typeCode", Name = "TYPE_CODE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long TypeCode
		{
			get
			{
				return this._typeCode;
			}
			set
			{
				if ((_typeCode != value))
				{
					this.OnTypeCodeChanging(value);
					this._typeCode = value;
					this.OnTypeCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EDI_OUTBOUND_FILE")]
	public partial class EdiOutboundFile
	{

		private long _clientID;

		private long _ediOutboundFileID;

		private string _lobCode;

		private string _mapping;

		private System.Nullable<long> _mappingRuleID;

		private string _override;

		private System.Nullable<long> _overrideRuleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnClientIdChanged();

		partial void OnClientIdChanging(long value);

		partial void OnEdiOutboundFileIdChanged();

		partial void OnEdiOutboundFileIdChanging(long value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnMappingChanged();

		partial void OnMappingChanging(string value);

		partial void OnMappingRuleIdChanged();

		partial void OnMappingRuleIdChanging(System.Nullable<long> value);

		partial void OnOverrideChanged();

		partial void OnOverrideChanging(string value);

		partial void OnOverrideRuleIdChanged();

		partial void OnOverrideRuleIdChanging(System.Nullable<long> value);
		#endregion


		public EdiOutboundFile()
		{
			this.OnCreated();
		}

		[Column(Storage = "_clientID", Name = "CLIENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClientId
		{
			get
			{
				return this._clientID;
			}
			set
			{
				if ((_clientID != value))
				{
					this.OnClientIdChanging(value);
					this._clientID = value;
					this.OnClientIdChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundFileID", Name = "EDI_OUTBOUND_FILE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundFileId
		{
			get
			{
				return this._ediOutboundFileID;
			}
			set
			{
				if ((_ediOutboundFileID != value))
				{
					this.OnEdiOutboundFileIdChanging(value);
					this._ediOutboundFileID = value;
					this.OnEdiOutboundFileIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_mapping", Name = "MAPPING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Mapping
		{
			get
			{
				return this._mapping;
			}
			set
			{
				if (((_mapping == value)
							== false))
				{
					this.OnMappingChanging(value);
					this._mapping = value;
					this.OnMappingChanged();
				}
			}
		}

		[Column(Storage = "_mappingRuleID", Name = "MAPPING_RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> MappingRuleId
		{
			get
			{
				return this._mappingRuleID;
			}
			set
			{
				if ((_mappingRuleID != value))
				{
					this.OnMappingRuleIdChanging(value);
					this._mappingRuleID = value;
					this.OnMappingRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_override", Name = "OVERRIDE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Override
		{
			get
			{
				return this._override;
			}
			set
			{
				if (((_override == value)
							== false))
				{
					this.OnOverrideChanging(value);
					this._override = value;
					this.OnOverrideChanged();
				}
			}
		}

		[Column(Storage = "_overrideRuleID", Name = "OVERRIDE_RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> OverrideRuleId
		{
			get
			{
				return this._overrideRuleID;
			}
			set
			{
				if ((_overrideRuleID != value))
				{
					this.OnOverrideRuleIdChanging(value);
					this._overrideRuleID = value;
					this.OnOverrideRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EDI_OUTBOUND_ITEM")]
	public partial class EdiOutboundItem
	{

		private string _delimiter;

		private string _description;

		private long _ediOutboundItemID;

		private string _name;

		private string _recordDelimiter;

		private long _transmissionSeqStepID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDelimiterChanged();

		partial void OnDelimiterChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEdiOutboundItemIdChanged();

		partial void OnEdiOutboundItemIdChanging(long value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnRecordDelimiterChanged();

		partial void OnRecordDelimiterChanging(string value);

		partial void OnTransmissionSeqStepIdChanged();

		partial void OnTransmissionSeqStepIdChanging(long value);
		#endregion


		public EdiOutboundItem()
		{
			this.OnCreated();
		}

		[Column(Storage = "_delimiter", Name = "DELIMITER", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Delimiter
		{
			get
			{
				return this._delimiter;
			}
			set
			{
				if (((_delimiter == value)
							== false))
				{
					this.OnDelimiterChanging(value);
					this._delimiter = value;
					this.OnDelimiterChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundItemID", Name = "EDI_OUTBOUND_ITEM_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundItemId
		{
			get
			{
				return this._ediOutboundItemID;
			}
			set
			{
				if ((_ediOutboundItemID != value))
				{
					this.OnEdiOutboundItemIdChanging(value);
					this._ediOutboundItemID = value;
					this.OnEdiOutboundItemIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_recordDelimiter", Name = "RECORD_DELIMITER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RecordDelimiter
		{
			get
			{
				return this._recordDelimiter;
			}
			set
			{
				if (((_recordDelimiter == value)
							== false))
				{
					this.OnRecordDelimiterChanging(value);
					this._recordDelimiter = value;
					this.OnRecordDelimiterChanged();
				}
			}
		}

		[Column(Storage = "_transmissionSeqStepID", Name = "TRANSMISSION_SEQ_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long TransmissionSeqStepId
		{
			get
			{
				return this._transmissionSeqStepID;
			}
			set
			{
				if ((_transmissionSeqStepID != value))
				{
					this.OnTransmissionSeqStepIdChanging(value);
					this._transmissionSeqStepID = value;
					this.OnTransmissionSeqStepIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EDI_OUTBOUND_MAPPING")]
	public partial class EdiOutboundMapping
	{

		private long _accntHrcyStepID;

		private string _attributeName;

		private string _defaultValue;

		private long _ediOutboundFieldID;

		private long _ediOutboundMappingID;

		private string _inheritSegmentObjName;

		private string _staticFlag;

		private long _typeCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAttributeNameChanged();

		partial void OnAttributeNameChanging(string value);

		partial void OnDefaultValueChanged();

		partial void OnDefaultValueChanging(string value);

		partial void OnEdiOutboundFieldIdChanged();

		partial void OnEdiOutboundFieldIdChanging(long value);

		partial void OnEdiOutboundMappingIdChanged();

		partial void OnEdiOutboundMappingIdChanging(long value);

		partial void OnInheritSegmentObjNameChanged();

		partial void OnInheritSegmentObjNameChanging(string value);

		partial void OnStaticFlagChanged();

		partial void OnStaticFlagChanging(string value);

		partial void OnTypeCodeChanged();

		partial void OnTypeCodeChanging(long value);
		#endregion


		public EdiOutboundMapping()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_attributeName", Name = "ATTRIBUTE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value)
							== false))
				{
					this.OnAttributeNameChanging(value);
					this._attributeName = value;
					this.OnAttributeNameChanged();
				}
			}
		}

		[Column(Storage = "_defaultValue", Name = "DEFAULT_VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				if (((_defaultValue == value)
							== false))
				{
					this.OnDefaultValueChanging(value);
					this._defaultValue = value;
					this.OnDefaultValueChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundFieldID", Name = "EDI_OUTBOUND_FIELD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundFieldId
		{
			get
			{
				return this._ediOutboundFieldID;
			}
			set
			{
				if ((_ediOutboundFieldID != value))
				{
					this.OnEdiOutboundFieldIdChanging(value);
					this._ediOutboundFieldID = value;
					this.OnEdiOutboundFieldIdChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundMappingID", Name = "EDI_OUTBOUND_MAPPING_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundMappingId
		{
			get
			{
				return this._ediOutboundMappingID;
			}
			set
			{
				if ((_ediOutboundMappingID != value))
				{
					this.OnEdiOutboundMappingIdChanging(value);
					this._ediOutboundMappingID = value;
					this.OnEdiOutboundMappingIdChanged();
				}
			}
		}

		[Column(Storage = "_inheritSegmentObjName", Name = "INHERIT_SEGMENT_OBJ_NAME", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string InheritSegmentObjName
		{
			get
			{
				return this._inheritSegmentObjName;
			}
			set
			{
				if (((_inheritSegmentObjName == value)
							== false))
				{
					this.OnInheritSegmentObjNameChanging(value);
					this._inheritSegmentObjName = value;
					this.OnInheritSegmentObjNameChanged();
				}
			}
		}

		[Column(Storage = "_staticFlag", Name = "STATIC_FLAG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string StaticFlag
		{
			get
			{
				return this._staticFlag;
			}
			set
			{
				if (((_staticFlag == value)
							== false))
				{
					this.OnStaticFlagChanging(value);
					this._staticFlag = value;
					this.OnStaticFlagChanged();
				}
			}
		}

		[Column(Storage = "_typeCode", Name = "TYPE_CODE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long TypeCode
		{
			get
			{
				return this._typeCode;
			}
			set
			{
				if ((_typeCode != value))
				{
					this.OnTypeCodeChanging(value);
					this._typeCode = value;
					this.OnTypeCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EDI_OUTBOUND_SEGMENT")]
	public partial class EdiOutboundSegment
	{

		private string _description;

		private System.Nullable<long> _ediOutboundParentSegmentID;

		private long _ediOutboundSegmentID;

		private string _inheritParentObjectName;

		private string _logicalRecordFlag;

		private string _loop;

		private string _loopIndexes;

		private string _objectName;

		private long _sequence;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEdiOutboundParentSegmentIdChanged();

		partial void OnEdiOutboundParentSegmentIdChanging(System.Nullable<long> value);

		partial void OnEdiOutboundSegmentIdChanged();

		partial void OnEdiOutboundSegmentIdChanging(long value);

		partial void OnInheritParentObjectNameChanged();

		partial void OnInheritParentObjectNameChanging(string value);

		partial void OnLogicalRecordFlagChanged();

		partial void OnLogicalRecordFlagChanging(string value);

		partial void OnLoopChanged();

		partial void OnLoopChanging(string value);

		partial void OnLoopIndexesChanged();

		partial void OnLoopIndexesChanging(string value);

		partial void OnObjectNameChanged();

		partial void OnObjectNameChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);
		#endregion


		public EdiOutboundSegment()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundParentSegmentID", Name = "EDI_OUTBOUND_PARENT_SEGMENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EdiOutboundParentSegmentId
		{
			get
			{
				return this._ediOutboundParentSegmentID;
			}
			set
			{
				if ((_ediOutboundParentSegmentID != value))
				{
					this.OnEdiOutboundParentSegmentIdChanging(value);
					this._ediOutboundParentSegmentID = value;
					this.OnEdiOutboundParentSegmentIdChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundSegmentID", Name = "EDI_OUTBOUND_SEGMENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundSegmentId
		{
			get
			{
				return this._ediOutboundSegmentID;
			}
			set
			{
				if ((_ediOutboundSegmentID != value))
				{
					this.OnEdiOutboundSegmentIdChanging(value);
					this._ediOutboundSegmentID = value;
					this.OnEdiOutboundSegmentIdChanged();
				}
			}
		}

		[Column(Storage = "_inheritParentObjectName", Name = "INHERIT_PARENT_OBJECT_NAME", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string InheritParentObjectName
		{
			get
			{
				return this._inheritParentObjectName;
			}
			set
			{
				if (((_inheritParentObjectName == value)
							== false))
				{
					this.OnInheritParentObjectNameChanging(value);
					this._inheritParentObjectName = value;
					this.OnInheritParentObjectNameChanged();
				}
			}
		}

		[Column(Storage = "_logicalRecordFlag", Name = "LOGICAL_RECORD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LogicalRecordFlag
		{
			get
			{
				return this._logicalRecordFlag;
			}
			set
			{
				if (((_logicalRecordFlag == value)
							== false))
				{
					this.OnLogicalRecordFlagChanging(value);
					this._logicalRecordFlag = value;
					this.OnLogicalRecordFlagChanged();
				}
			}
		}

		[Column(Storage = "_loop", Name = "LOOP", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Loop
		{
			get
			{
				return this._loop;
			}
			set
			{
				if (((_loop == value)
							== false))
				{
					this.OnLoopChanging(value);
					this._loop = value;
					this.OnLoopChanged();
				}
			}
		}

		[Column(Storage = "_loopIndexes", Name = "LOOP_INDEXES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LoopIndexes
		{
			get
			{
				return this._loopIndexes;
			}
			set
			{
				if (((_loopIndexes == value)
							== false))
				{
					this.OnLoopIndexesChanging(value);
					this._loopIndexes = value;
					this.OnLoopIndexesChanged();
				}
			}
		}

		[Column(Storage = "_objectName", Name = "OBJECT_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ObjectName
		{
			get
			{
				return this._objectName;
			}
			set
			{
				if (((_objectName == value)
							== false))
				{
					this.OnObjectNameChanging(value);
					this._objectName = value;
					this.OnObjectNameChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EDI_OUTBOUND_TOP_SEGMENTS")]
	public partial class EdiOutboundTopSegments
	{

		private long _ediOutboundItemID;

		private long _ediOutboundSegmentID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnEdiOutboundItemIdChanged();

		partial void OnEdiOutboundItemIdChanging(long value);

		partial void OnEdiOutboundSegmentIdChanged();

		partial void OnEdiOutboundSegmentIdChanging(long value);
		#endregion


		public EdiOutboundTopSegments()
		{
			this.OnCreated();
		}

		[Column(Storage = "_ediOutboundItemID", Name = "EDI_OUTBOUND_ITEM_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundItemId
		{
			get
			{
				return this._ediOutboundItemID;
			}
			set
			{
				if ((_ediOutboundItemID != value))
				{
					this.OnEdiOutboundItemIdChanging(value);
					this._ediOutboundItemID = value;
					this.OnEdiOutboundItemIdChanged();
				}
			}
		}

		[Column(Storage = "_ediOutboundSegmentID", Name = "EDI_OUTBOUND_SEGMENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EdiOutboundSegmentId
		{
			get
			{
				return this._ediOutboundSegmentID;
			}
			set
			{
				if ((_ediOutboundSegmentID != value))
				{
					this.OnEdiOutboundSegmentIdChanging(value);
					this._ediOutboundSegmentID = value;
					this.OnEdiOutboundSegmentIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EMAIL_DISTRIBUTION")]
	public partial class EmailDistribution
	{

		private string _distributionFrom;

		private string _distributionTo;

		private string _distributionType;

		private System.Nullable<long> _ruleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDistributionFromChanged();

		partial void OnDistributionFromChanging(string value);

		partial void OnDistributionToChanged();

		partial void OnDistributionToChanging(string value);

		partial void OnDistributionTypeChanged();

		partial void OnDistributionTypeChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);
		#endregion


		public EmailDistribution()
		{
			this.OnCreated();
		}

		[Column(Storage = "_distributionFrom", Name = "DISTRIBUTION_FROM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DistributionFrom
		{
			get
			{
				return this._distributionFrom;
			}
			set
			{
				if (((_distributionFrom == value)
							== false))
				{
					this.OnDistributionFromChanging(value);
					this._distributionFrom = value;
					this.OnDistributionFromChanged();
				}
			}
		}

		[Column(Storage = "_distributionTo", Name = "DISTRIBUTION_TO", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DistributionTo
		{
			get
			{
				return this._distributionTo;
			}
			set
			{
				if (((_distributionTo == value)
							== false))
				{
					this.OnDistributionToChanging(value);
					this._distributionTo = value;
					this.OnDistributionToChanged();
				}
			}
		}

		[Column(Storage = "_distributionType", Name = "DISTRIBUTION_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string DistributionType
		{
			get
			{
				return this._distributionType;
			}
			set
			{
				if (((_distributionType == value)
							== false))
				{
					this.OnDistributionTypeChanging(value);
					this._distributionType = value;
					this.OnDistributionTypeChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EMPLOYEE")]
	public partial class Employee
	{

		private long _accntHrcyStepID;

		private string _address1;

		private string _address2;

		private System.Nullable<decimal> _annualSalary;

		private string _city;

		private string _clientNumber;

		private System.Nullable<System.DateTime> _closeDate;

		private string _costCenterID;

		private string _country;

		private System.Nullable<decimal> _dailyWage;

		private System.Nullable<System.DateTime> _dateOfBirth;

		private System.Nullable<System.DateTime> _dateOfHire;

		private System.Nullable<System.DateTime> _dateOfTermination;

		private string _department;

		private System.Nullable<short> _dependents18uNder;

		private string _employeeCode;

		private long _employeeID;

		private string _employmentStatus;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _filingState;

		private string _flsaStatus;

		private string _gender;

		private System.Nullable<decimal> _hourlyWage;

		private string _jobCode;

		private string _jobTitle;

		private string _maritalStatus;

		private System.Nullable<decimal> _monthlyWage;

		private string _nameFirst;

		private string _nameLast;

		private string _nameMiD;

		private string _ncciJobclass;

		private string _paidForOvertimeFlag;

		private string _phone;

		private string _phoneWork;

		private string _reportingUnit;

		private string _specialID;

		private string _ssn;

		private string _state;

		private string _status;

		private string _supervisorEmailAddress;

		private string _supervisorNameFirst;

		private string _supervisorNameLast;

		private string _supervisorPhoneWork;

		private string _telecommuterFlag;

		private string _testFlag;

		private string _title;

		private System.Nullable<short> _totalDependents;

		private string _unionCode;

		private string _uploadKey;

		private string _wageFrequency;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnAnnualSalaryChanged();

		partial void OnAnnualSalaryChanging(System.Nullable<decimal> value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnClientNumberChanged();

		partial void OnClientNumberChanging(string value);

		partial void OnCloseDateChanged();

		partial void OnCloseDateChanging(System.Nullable<System.DateTime> value);

		partial void OnCostCenterIdChanged();

		partial void OnCostCenterIdChanging(string value);

		partial void OnCountryChanged();

		partial void OnCountryChanging(string value);

		partial void OnDailyWageChanged();

		partial void OnDailyWageChanging(System.Nullable<decimal> value);

		partial void OnDateOfBirthChanged();

		partial void OnDateOfBirthChanging(System.Nullable<System.DateTime> value);

		partial void OnDateOfHireChanged();

		partial void OnDateOfHireChanging(System.Nullable<System.DateTime> value);

		partial void OnDateOfTerminationChanged();

		partial void OnDateOfTerminationChanging(System.Nullable<System.DateTime> value);

		partial void OnDepartmentChanged();

		partial void OnDepartmentChanging(string value);

		partial void OnDependents18UnderChanged();

		partial void OnDependents18UnderChanging(System.Nullable<short> value);

		partial void OnEmployeeCodeChanged();

		partial void OnEmployeeCodeChanging(string value);

		partial void OnEmployeeIdChanged();

		partial void OnEmployeeIdChanging(long value);

		partial void OnEmploymentStatusChanged();

		partial void OnEmploymentStatusChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnFilingStateChanged();

		partial void OnFilingStateChanging(string value);

		partial void OnFlsaStatusChanged();

		partial void OnFlsaStatusChanging(string value);

		partial void OnGenderChanged();

		partial void OnGenderChanging(string value);

		partial void OnHourlyWageChanged();

		partial void OnHourlyWageChanging(System.Nullable<decimal> value);

		partial void OnJobCodeChanged();

		partial void OnJobCodeChanging(string value);

		partial void OnJobTitleChanged();

		partial void OnJobTitleChanging(string value);

		partial void OnMaritalStatusChanged();

		partial void OnMaritalStatusChanging(string value);

		partial void OnMonthlyWageChanged();

		partial void OnMonthlyWageChanging(System.Nullable<decimal> value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnNameMIdChanged();

		partial void OnNameMIdChanging(string value);

		partial void OnNcciJobclassChanged();

		partial void OnNcciJobclassChanging(string value);

		partial void OnPaidForOvertimeFlagChanged();

		partial void OnPaidForOvertimeFlagChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnPhoneWorkChanged();

		partial void OnPhoneWorkChanging(string value);

		partial void OnReportingUnitChanged();

		partial void OnReportingUnitChanging(string value);

		partial void OnSpecialIdChanged();

		partial void OnSpecialIdChanging(string value);

		partial void OnSsnChanged();

		partial void OnSsnChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnSupervisorEmailAddressChanged();

		partial void OnSupervisorEmailAddressChanging(string value);

		partial void OnSupervisorNameFirstChanged();

		partial void OnSupervisorNameFirstChanging(string value);

		partial void OnSupervisorNameLastChanged();

		partial void OnSupervisorNameLastChanging(string value);

		partial void OnSupervisorPhoneWorkChanged();

		partial void OnSupervisorPhoneWorkChanging(string value);

		partial void OnTelecommuterFlagChanged();

		partial void OnTelecommuterFlagChanging(string value);

		partial void OnTestFlagChanged();

		partial void OnTestFlagChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnTotalDependentsChanged();

		partial void OnTotalDependentsChanging(System.Nullable<short> value);

		partial void OnUnionCodeChanged();

		partial void OnUnionCodeChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnWageFrequencyChanged();

		partial void OnWageFrequencyChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public Employee()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_annualSalary", Name = "ANNUAL_SALARY", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> AnnualSalary
		{
			get
			{
				return this._annualSalary;
			}
			set
			{
				if ((_annualSalary != value))
				{
					this.OnAnnualSalaryChanging(value);
					this._annualSalary = value;
					this.OnAnnualSalaryChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_clientNumber", Name = "CLIENT_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ClientNumber
		{
			get
			{
				return this._clientNumber;
			}
			set
			{
				if (((_clientNumber == value)
							== false))
				{
					this.OnClientNumberChanging(value);
					this._clientNumber = value;
					this.OnClientNumberChanged();
				}
			}
		}

		[Column(Storage = "_closeDate", Name = "CLOSE_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CloseDate
		{
			get
			{
				return this._closeDate;
			}
			set
			{
				if ((_closeDate != value))
				{
					this.OnCloseDateChanging(value);
					this._closeDate = value;
					this.OnCloseDateChanged();
				}
			}
		}

		[Column(Storage = "_costCenterID", Name = "COST_CENTER_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CostCenterId
		{
			get
			{
				return this._costCenterID;
			}
			set
			{
				if (((_costCenterID == value)
							== false))
				{
					this.OnCostCenterIdChanging(value);
					this._costCenterID = value;
					this.OnCostCenterIdChanged();
				}
			}
		}

		[Column(Storage = "_country", Name = "COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Country
		{
			get
			{
				return this._country;
			}
			set
			{
				if (((_country == value)
							== false))
				{
					this.OnCountryChanging(value);
					this._country = value;
					this.OnCountryChanged();
				}
			}
		}

		[Column(Storage = "_dailyWage", Name = "DAILY_WAGE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> DailyWage
		{
			get
			{
				return this._dailyWage;
			}
			set
			{
				if ((_dailyWage != value))
				{
					this.OnDailyWageChanging(value);
					this._dailyWage = value;
					this.OnDailyWageChanged();
				}
			}
		}

		[Column(Storage = "_dateOfBirth", Name = "DATE_OF_BIRTH", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._dateOfBirth;
			}
			set
			{
				if ((_dateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this._dateOfBirth = value;
					this.OnDateOfBirthChanged();
				}
			}
		}

		[Column(Storage = "_dateOfHire", Name = "DATE_OF_HIRE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateOfHire
		{
			get
			{
				return this._dateOfHire;
			}
			set
			{
				if ((_dateOfHire != value))
				{
					this.OnDateOfHireChanging(value);
					this._dateOfHire = value;
					this.OnDateOfHireChanged();
				}
			}
		}

		[Column(Storage = "_dateOfTermination", Name = "DATE_OF_TERMINATION", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateOfTermination
		{
			get
			{
				return this._dateOfTermination;
			}
			set
			{
				if ((_dateOfTermination != value))
				{
					this.OnDateOfTerminationChanging(value);
					this._dateOfTermination = value;
					this.OnDateOfTerminationChanged();
				}
			}
		}

		[Column(Storage = "_department", Name = "DEPARTMENT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Department
		{
			get
			{
				return this._department;
			}
			set
			{
				if (((_department == value)
							== false))
				{
					this.OnDepartmentChanging(value);
					this._department = value;
					this.OnDepartmentChanged();
				}
			}
		}

		[Column(Storage = "_dependents18uNder", Name = "DEPENDENTS_18_UNDER", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> Dependents18Under
		{
			get
			{
				return this._dependents18uNder;
			}
			set
			{
				if ((_dependents18uNder != value))
				{
					this.OnDependents18UnderChanging(value);
					this._dependents18uNder = value;
					this.OnDependents18UnderChanged();
				}
			}
		}

		[Column(Storage = "_employeeCode", Name = "EMPLOYEE_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmployeeCode
		{
			get
			{
				return this._employeeCode;
			}
			set
			{
				if (((_employeeCode == value)
							== false))
				{
					this.OnEmployeeCodeChanging(value);
					this._employeeCode = value;
					this.OnEmployeeCodeChanged();
				}
			}
		}

		[Column(Storage = "_employeeID", Name = "EMPLOYEE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EmployeeId
		{
			get
			{
				return this._employeeID;
			}
			set
			{
				if ((_employeeID != value))
				{
					this.OnEmployeeIdChanging(value);
					this._employeeID = value;
					this.OnEmployeeIdChanged();
				}
			}
		}

		[Column(Storage = "_employmentStatus", Name = "EMPLOYMENT_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmploymentStatus
		{
			get
			{
				return this._employmentStatus;
			}
			set
			{
				if (((_employmentStatus == value)
							== false))
				{
					this.OnEmploymentStatusChanging(value);
					this._employmentStatus = value;
					this.OnEmploymentStatusChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_filingState", Name = "FILING_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FilingState
		{
			get
			{
				return this._filingState;
			}
			set
			{
				if (((_filingState == value)
							== false))
				{
					this.OnFilingStateChanging(value);
					this._filingState = value;
					this.OnFilingStateChanged();
				}
			}
		}

		[Column(Storage = "_flsaStatus", Name = "FLSA_STATUS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FlsaStatus
		{
			get
			{
				return this._flsaStatus;
			}
			set
			{
				if (((_flsaStatus == value)
							== false))
				{
					this.OnFlsaStatusChanging(value);
					this._flsaStatus = value;
					this.OnFlsaStatusChanged();
				}
			}
		}

		[Column(Storage = "_gender", Name = "GENDER", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if (((_gender == value)
							== false))
				{
					this.OnGenderChanging(value);
					this._gender = value;
					this.OnGenderChanged();
				}
			}
		}

		[Column(Storage = "_hourlyWage", Name = "HOURLY_WAGE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> HourlyWage
		{
			get
			{
				return this._hourlyWage;
			}
			set
			{
				if ((_hourlyWage != value))
				{
					this.OnHourlyWageChanging(value);
					this._hourlyWage = value;
					this.OnHourlyWageChanged();
				}
			}
		}

		[Column(Storage = "_jobCode", Name = "JOB_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string JobCode
		{
			get
			{
				return this._jobCode;
			}
			set
			{
				if (((_jobCode == value)
							== false))
				{
					this.OnJobCodeChanging(value);
					this._jobCode = value;
					this.OnJobCodeChanged();
				}
			}
		}

		[Column(Storage = "_jobTitle", Name = "JOB_TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string JobTitle
		{
			get
			{
				return this._jobTitle;
			}
			set
			{
				if (((_jobTitle == value)
							== false))
				{
					this.OnJobTitleChanging(value);
					this._jobTitle = value;
					this.OnJobTitleChanged();
				}
			}
		}

		[Column(Storage = "_maritalStatus", Name = "MARITAL_STATUS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MaritalStatus
		{
			get
			{
				return this._maritalStatus;
			}
			set
			{
				if (((_maritalStatus == value)
							== false))
				{
					this.OnMaritalStatusChanging(value);
					this._maritalStatus = value;
					this.OnMaritalStatusChanged();
				}
			}
		}

		[Column(Storage = "_monthlyWage", Name = "MONTHLY_WAGE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> MonthlyWage
		{
			get
			{
				return this._monthlyWage;
			}
			set
			{
				if ((_monthlyWage != value))
				{
					this.OnMonthlyWageChanging(value);
					this._monthlyWage = value;
					this.OnMonthlyWageChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_nameMiD", Name = "NAME_MID", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameMId
		{
			get
			{
				return this._nameMiD;
			}
			set
			{
				if (((_nameMiD == value)
							== false))
				{
					this.OnNameMIdChanging(value);
					this._nameMiD = value;
					this.OnNameMIdChanged();
				}
			}
		}

		[Column(Storage = "_ncciJobclass", Name = "NCCI_JOBCLASS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NcciJobclass
		{
			get
			{
				return this._ncciJobclass;
			}
			set
			{
				if (((_ncciJobclass == value)
							== false))
				{
					this.OnNcciJobclassChanging(value);
					this._ncciJobclass = value;
					this.OnNcciJobclassChanged();
				}
			}
		}

		[Column(Storage = "_paidForOvertimeFlag", Name = "PAID_FOR_OVERTIME_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PaidForOvertimeFlag
		{
			get
			{
				return this._paidForOvertimeFlag;
			}
			set
			{
				if (((_paidForOvertimeFlag == value)
							== false))
				{
					this.OnPaidForOvertimeFlagChanging(value);
					this._paidForOvertimeFlag = value;
					this.OnPaidForOvertimeFlagChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_phoneWork", Name = "PHONE_WORK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneWork
		{
			get
			{
				return this._phoneWork;
			}
			set
			{
				if (((_phoneWork == value)
							== false))
				{
					this.OnPhoneWorkChanging(value);
					this._phoneWork = value;
					this.OnPhoneWorkChanged();
				}
			}
		}

		[Column(Storage = "_reportingUnit", Name = "REPORTING_UNIT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReportingUnit
		{
			get
			{
				return this._reportingUnit;
			}
			set
			{
				if (((_reportingUnit == value)
							== false))
				{
					this.OnReportingUnitChanging(value);
					this._reportingUnit = value;
					this.OnReportingUnitChanged();
				}
			}
		}

		[Column(Storage = "_specialID", Name = "SPECIAL_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpecialId
		{
			get
			{
				return this._specialID;
			}
			set
			{
				if (((_specialID == value)
							== false))
				{
					this.OnSpecialIdChanging(value);
					this._specialID = value;
					this.OnSpecialIdChanged();
				}
			}
		}

		[Column(Storage = "_ssn", Name = "SSN", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Ssn
		{
			get
			{
				return this._ssn;
			}
			set
			{
				if (((_ssn == value)
							== false))
				{
					this.OnSsnChanging(value);
					this._ssn = value;
					this.OnSsnChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_supervisorEmailAddress", Name = "SUPERVISOR_EMAIL_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorEmailAddress
		{
			get
			{
				return this._supervisorEmailAddress;
			}
			set
			{
				if (((_supervisorEmailAddress == value)
							== false))
				{
					this.OnSupervisorEmailAddressChanging(value);
					this._supervisorEmailAddress = value;
					this.OnSupervisorEmailAddressChanged();
				}
			}
		}

		[Column(Storage = "_supervisorNameFirst", Name = "SUPERVISOR_NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorNameFirst
		{
			get
			{
				return this._supervisorNameFirst;
			}
			set
			{
				if (((_supervisorNameFirst == value)
							== false))
				{
					this.OnSupervisorNameFirstChanging(value);
					this._supervisorNameFirst = value;
					this.OnSupervisorNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_supervisorNameLast", Name = "SUPERVISOR_NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorNameLast
		{
			get
			{
				return this._supervisorNameLast;
			}
			set
			{
				if (((_supervisorNameLast == value)
							== false))
				{
					this.OnSupervisorNameLastChanging(value);
					this._supervisorNameLast = value;
					this.OnSupervisorNameLastChanged();
				}
			}
		}

		[Column(Storage = "_supervisorPhoneWork", Name = "SUPERVISOR_PHONE_WORK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorPhoneWork
		{
			get
			{
				return this._supervisorPhoneWork;
			}
			set
			{
				if (((_supervisorPhoneWork == value)
							== false))
				{
					this.OnSupervisorPhoneWorkChanging(value);
					this._supervisorPhoneWork = value;
					this.OnSupervisorPhoneWorkChanged();
				}
			}
		}

		[Column(Storage = "_telecommuterFlag", Name = "TELECOMMUTER_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TelecommuterFlag
		{
			get
			{
				return this._telecommuterFlag;
			}
			set
			{
				if (((_telecommuterFlag == value)
							== false))
				{
					this.OnTelecommuterFlagChanging(value);
					this._telecommuterFlag = value;
					this.OnTelecommuterFlagChanged();
				}
			}
		}

		[Column(Storage = "_testFlag", Name = "TEST_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string TestFlag
		{
			get
			{
				return this._testFlag;
			}
			set
			{
				if (((_testFlag == value)
							== false))
				{
					this.OnTestFlagChanging(value);
					this._testFlag = value;
					this.OnTestFlagChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_totalDependents", Name = "TOTAL_DEPENDENTS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> TotalDependents
		{
			get
			{
				return this._totalDependents;
			}
			set
			{
				if ((_totalDependents != value))
				{
					this.OnTotalDependentsChanging(value);
					this._totalDependents = value;
					this.OnTotalDependentsChanged();
				}
			}
		}

		[Column(Storage = "_unionCode", Name = "UNION_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UnionCode
		{
			get
			{
				return this._unionCode;
			}
			set
			{
				if (((_unionCode == value)
							== false))
				{
					this.OnUnionCodeChanging(value);
					this._unionCode = value;
					this.OnUnionCodeChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_wageFrequency", Name = "WAGE_FREQUENCY", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string WageFrequency
		{
			get
			{
				return this._wageFrequency;
			}
			set
			{
				if (((_wageFrequency == value)
							== false))
				{
					this.OnWageFrequencyChanging(value);
					this._wageFrequency = value;
					this.OnWageFrequencyChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EMPLOYEE_ELIGIBILITY")]
	public partial class EmployeeEligibility
	{

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private string _address1;

		private string _address2;

		private System.Nullable<short> _age;

		private System.Nullable<decimal> _annualSalary;

		private System.Nullable<System.DateTime> _birthDate;

		private string _city;

		private string _departmentID;

		private long _employeeEligibilityID;

		private System.Nullable<int> _employeeID;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _fips;

		private string _gender;

		private System.Nullable<System.DateTime> _hireDate;

		private System.Nullable<decimal> _hoursPerWeek;

		private string _locationCode;

		private string _locationState;

		private string _maritalStatus;

		private string _nameFirst;

		private string _nameLast;

		private string _nameMi;

		private string _ncciJobclass;

		private System.Nullable<long> _numDependents;

		private string _paidForOvertimeFlag;

		private string _pasStatus;

		private string _payType;

		private string _phoneFax;

		private string _phoneHome;

		private string _phoneWork;

		private string _policyNumber;

		private string _ssn;

		private string _state;

		private string _supervisorNameFirst;

		private string _supervisorNameLast;

		private string _supervisorPhoneWork;

		private string _title;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnAgeChanged();

		partial void OnAgeChanging(System.Nullable<short> value);

		partial void OnAnnualSalaryChanged();

		partial void OnAnnualSalaryChanging(System.Nullable<decimal> value);

		partial void OnBirthDateChanged();

		partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnDepartmentIdChanged();

		partial void OnDepartmentIdChanging(string value);

		partial void OnEmployeeEligibilityIdChanged();

		partial void OnEmployeeEligibilityIdChanging(long value);

		partial void OnEmployeeIdChanged();

		partial void OnEmployeeIdChanging(System.Nullable<int> value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnFipsChanged();

		partial void OnFipsChanging(string value);

		partial void OnGenderChanged();

		partial void OnGenderChanging(string value);

		partial void OnHireDateChanged();

		partial void OnHireDateChanging(System.Nullable<System.DateTime> value);

		partial void OnHoursPerWeekChanged();

		partial void OnHoursPerWeekChanging(System.Nullable<decimal> value);

		partial void OnLocationCodeChanged();

		partial void OnLocationCodeChanging(string value);

		partial void OnLocationStateChanged();

		partial void OnLocationStateChanging(string value);

		partial void OnMaritalStatusChanged();

		partial void OnMaritalStatusChanging(string value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnNameMiChanged();

		partial void OnNameMiChanging(string value);

		partial void OnNcciJobclassChanged();

		partial void OnNcciJobclassChanging(string value);

		partial void OnNumDependentsChanged();

		partial void OnNumDependentsChanging(System.Nullable<long> value);

		partial void OnPaidForOvertimeFlagChanged();

		partial void OnPaidForOvertimeFlagChanging(string value);

		partial void OnPasStatusChanged();

		partial void OnPasStatusChanging(string value);

		partial void OnPayTypeChanged();

		partial void OnPayTypeChanging(string value);

		partial void OnPhoneFaxChanged();

		partial void OnPhoneFaxChanging(string value);

		partial void OnPhoneHomeChanged();

		partial void OnPhoneHomeChanging(string value);

		partial void OnPhoneWorkChanged();

		partial void OnPhoneWorkChanging(string value);

		partial void OnPolicyNumberChanged();

		partial void OnPolicyNumberChanging(string value);

		partial void OnSsnChanged();

		partial void OnSsnChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnSupervisorNameFirstChanged();

		partial void OnSupervisorNameFirstChanging(string value);

		partial void OnSupervisorNameLastChanged();

		partial void OnSupervisorNameLastChanging(string value);

		partial void OnSupervisorPhoneWorkChanged();

		partial void OnSupervisorPhoneWorkChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public EmployeeEligibility()
		{
			this.OnCreated();
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_age", Name = "AGE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> Age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((_age != value))
				{
					this.OnAgeChanging(value);
					this._age = value;
					this.OnAgeChanged();
				}
			}
		}

		[Column(Storage = "_annualSalary", Name = "ANNUAL_SALARY", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> AnnualSalary
		{
			get
			{
				return this._annualSalary;
			}
			set
			{
				if ((_annualSalary != value))
				{
					this.OnAnnualSalaryChanging(value);
					this._annualSalary = value;
					this.OnAnnualSalaryChanged();
				}
			}
		}

		[Column(Storage = "_birthDate", Name = "BIRTH_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._birthDate;
			}
			set
			{
				if ((_birthDate != value))
				{
					this.OnBirthDateChanging(value);
					this._birthDate = value;
					this.OnBirthDateChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_departmentID", Name = "DEPARTMENT_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DepartmentId
		{
			get
			{
				return this._departmentID;
			}
			set
			{
				if (((_departmentID == value)
							== false))
				{
					this.OnDepartmentIdChanging(value);
					this._departmentID = value;
					this.OnDepartmentIdChanged();
				}
			}
		}

		[Column(Storage = "_employeeEligibilityID", Name = "EMPLOYEE_ELIGIBILITY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EmployeeEligibilityId
		{
			get
			{
				return this._employeeEligibilityID;
			}
			set
			{
				if ((_employeeEligibilityID != value))
				{
					this.OnEmployeeEligibilityIdChanging(value);
					this._employeeEligibilityID = value;
					this.OnEmployeeEligibilityIdChanged();
				}
			}
		}

		[Column(Storage = "_employeeID", Name = "EMPLOYEE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._employeeID;
			}
			set
			{
				if ((_employeeID != value))
				{
					this.OnEmployeeIdChanging(value);
					this._employeeID = value;
					this.OnEmployeeIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_fips", Name = "FIPS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fips
		{
			get
			{
				return this._fips;
			}
			set
			{
				if (((_fips == value)
							== false))
				{
					this.OnFipsChanging(value);
					this._fips = value;
					this.OnFipsChanged();
				}
			}
		}

		[Column(Storage = "_gender", Name = "GENDER", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if (((_gender == value)
							== false))
				{
					this.OnGenderChanging(value);
					this._gender = value;
					this.OnGenderChanged();
				}
			}
		}

		[Column(Storage = "_hireDate", Name = "HIRE_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> HireDate
		{
			get
			{
				return this._hireDate;
			}
			set
			{
				if ((_hireDate != value))
				{
					this.OnHireDateChanging(value);
					this._hireDate = value;
					this.OnHireDateChanged();
				}
			}
		}

		[Column(Storage = "_hoursPerWeek", Name = "HOURS_PER_WEEK", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> HoursPerWeek
		{
			get
			{
				return this._hoursPerWeek;
			}
			set
			{
				if ((_hoursPerWeek != value))
				{
					this.OnHoursPerWeekChanging(value);
					this._hoursPerWeek = value;
					this.OnHoursPerWeekChanged();
				}
			}
		}

		[Column(Storage = "_locationCode", Name = "LOCATION_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LocationCode
		{
			get
			{
				return this._locationCode;
			}
			set
			{
				if (((_locationCode == value)
							== false))
				{
					this.OnLocationCodeChanging(value);
					this._locationCode = value;
					this.OnLocationCodeChanged();
				}
			}
		}

		[Column(Storage = "_locationState", Name = "LOCATION_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LocationState
		{
			get
			{
				return this._locationState;
			}
			set
			{
				if (((_locationState == value)
							== false))
				{
					this.OnLocationStateChanging(value);
					this._locationState = value;
					this.OnLocationStateChanged();
				}
			}
		}

		[Column(Storage = "_maritalStatus", Name = "MARITAL_STATUS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MaritalStatus
		{
			get
			{
				return this._maritalStatus;
			}
			set
			{
				if (((_maritalStatus == value)
							== false))
				{
					this.OnMaritalStatusChanging(value);
					this._maritalStatus = value;
					this.OnMaritalStatusChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_nameMi", Name = "NAME_MI", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameMi
		{
			get
			{
				return this._nameMi;
			}
			set
			{
				if (((_nameMi == value)
							== false))
				{
					this.OnNameMiChanging(value);
					this._nameMi = value;
					this.OnNameMiChanged();
				}
			}
		}

		[Column(Storage = "_ncciJobclass", Name = "NCCI_JOBCLASS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NcciJobclass
		{
			get
			{
				return this._ncciJobclass;
			}
			set
			{
				if (((_ncciJobclass == value)
							== false))
				{
					this.OnNcciJobclassChanging(value);
					this._ncciJobclass = value;
					this.OnNcciJobclassChanged();
				}
			}
		}

		[Column(Storage = "_numDependents", Name = "NUM_DEPENDENTS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> NumDependents
		{
			get
			{
				return this._numDependents;
			}
			set
			{
				if ((_numDependents != value))
				{
					this.OnNumDependentsChanging(value);
					this._numDependents = value;
					this.OnNumDependentsChanged();
				}
			}
		}

		[Column(Storage = "_paidForOvertimeFlag", Name = "PAID_FOR_OVERTIME_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PaidForOvertimeFlag
		{
			get
			{
				return this._paidForOvertimeFlag;
			}
			set
			{
				if (((_paidForOvertimeFlag == value)
							== false))
				{
					this.OnPaidForOvertimeFlagChanging(value);
					this._paidForOvertimeFlag = value;
					this.OnPaidForOvertimeFlagChanged();
				}
			}
		}

		[Column(Storage = "_pasStatus", Name = "PAS_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PasStatus
		{
			get
			{
				return this._pasStatus;
			}
			set
			{
				if (((_pasStatus == value)
							== false))
				{
					this.OnPasStatusChanging(value);
					this._pasStatus = value;
					this.OnPasStatusChanged();
				}
			}
		}

		[Column(Storage = "_payType", Name = "PAY_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PayType
		{
			get
			{
				return this._payType;
			}
			set
			{
				if (((_payType == value)
							== false))
				{
					this.OnPayTypeChanging(value);
					this._payType = value;
					this.OnPayTypeChanged();
				}
			}
		}

		[Column(Storage = "_phoneFax", Name = "PHONE_FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneFax
		{
			get
			{
				return this._phoneFax;
			}
			set
			{
				if (((_phoneFax == value)
							== false))
				{
					this.OnPhoneFaxChanging(value);
					this._phoneFax = value;
					this.OnPhoneFaxChanged();
				}
			}
		}

		[Column(Storage = "_phoneHome", Name = "PHONE_HOME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneHome
		{
			get
			{
				return this._phoneHome;
			}
			set
			{
				if (((_phoneHome == value)
							== false))
				{
					this.OnPhoneHomeChanging(value);
					this._phoneHome = value;
					this.OnPhoneHomeChanged();
				}
			}
		}

		[Column(Storage = "_phoneWork", Name = "PHONE_WORK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneWork
		{
			get
			{
				return this._phoneWork;
			}
			set
			{
				if (((_phoneWork == value)
							== false))
				{
					this.OnPhoneWorkChanging(value);
					this._phoneWork = value;
					this.OnPhoneWorkChanged();
				}
			}
		}

		[Column(Storage = "_policyNumber", Name = "POLICY_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PolicyNumber
		{
			get
			{
				return this._policyNumber;
			}
			set
			{
				if (((_policyNumber == value)
							== false))
				{
					this.OnPolicyNumberChanging(value);
					this._policyNumber = value;
					this.OnPolicyNumberChanged();
				}
			}
		}

		[Column(Storage = "_ssn", Name = "SSN", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Ssn
		{
			get
			{
				return this._ssn;
			}
			set
			{
				if (((_ssn == value)
							== false))
				{
					this.OnSsnChanging(value);
					this._ssn = value;
					this.OnSsnChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_supervisorNameFirst", Name = "SUPERVISOR_NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorNameFirst
		{
			get
			{
				return this._supervisorNameFirst;
			}
			set
			{
				if (((_supervisorNameFirst == value)
							== false))
				{
					this.OnSupervisorNameFirstChanging(value);
					this._supervisorNameFirst = value;
					this.OnSupervisorNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_supervisorNameLast", Name = "SUPERVISOR_NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorNameLast
		{
			get
			{
				return this._supervisorNameLast;
			}
			set
			{
				if (((_supervisorNameLast == value)
							== false))
				{
					this.OnSupervisorNameLastChanging(value);
					this._supervisorNameLast = value;
					this.OnSupervisorNameLastChanged();
				}
			}
		}

		[Column(Storage = "_supervisorPhoneWork", Name = "SUPERVISOR_PHONE_WORK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorPhoneWork
		{
			get
			{
				return this._supervisorPhoneWork;
			}
			set
			{
				if (((_supervisorPhoneWork == value)
							== false))
				{
					this.OnSupervisorPhoneWorkChanging(value);
					this._supervisorPhoneWork = value;
					this.OnSupervisorPhoneWorkChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.EMPLOYEE_EXT")]
	public partial class EmployeeExt
	{
		private long _employeeExtID;

		private long _employeeID;

		private string _fieldName;

		private string _fieldValue;

		private long _fileTransmissionLogID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnEmployeeExtIdChanged();

		partial void OnEmployeeExtIdChanging(long value);

		partial void OnEmployeeIdChanged();

		partial void OnEmployeeIdChanging(long value);

		partial void OnFieldNameChanged();

		partial void OnFieldNameChanging(string value);

		partial void OnFieldValueChanged();

		partial void OnFieldValueChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(long value);
		#endregion


		public EmployeeExt()
		{
			this.OnCreated();
		}

		[Column(Storage = "_employeeExtID", Name = "EMPLOYEE_EXT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EmployeeExtId
		{
			get
			{
				return this._employeeExtID;
			}
			set
			{
				if ((_employeeExtID != value))
				{
					this.OnEmployeeExtIdChanging(value);
					this._employeeExtID = value;
					this.OnEmployeeExtIdChanged();
				}
			}
		}

		[Column(Storage = "_employeeID", Name = "EMPLOYEE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public long EmployeeId
		{
			get
			{
				return this._employeeID;
			}
			set
			{
				if ((_employeeID != value))
				{
					this.OnEmployeeIdChanging(value);
					this._employeeID = value;
					this.OnEmployeeIdChanged();
				}
			}
		}

		[Column(Storage = "_fieldName", Name = "FIELD_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FieldName
		{
			get
			{
				return this._fieldName;
			}
			set
			{
				if (((_fieldName == value)
							== false))
				{
					this.OnFieldNameChanging(value);
					this._fieldName = value;
					this.OnFieldNameChanged();
				}
			}
		}

		[Column(Storage = "_fieldValue", Name = "FIELD_VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FieldValue
		{
			get
			{
				return this._fieldValue;
			}
			set
			{
				if (((_fieldValue == value)
							== false))
				{
					this.OnFieldValueChanging(value);
					this._fieldValue = value;
					this.OnFieldValueChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ENCRYPT_ATTRIBUTE")]
	public partial class EncryptAttribute
	{

		private long _accntHrcyStepID;

		private string _attributeName;

		private System.DateTime _createdDate;

		private long _encryptAttributeID;

		private string _encryptType;

		private System.DateTime _lastModifiedDate;

		private string _lobCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAttributeNameChanged();

		partial void OnAttributeNameChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnEncryptAttributeIdChanged();

		partial void OnEncryptAttributeIdChanging(long value);

		partial void OnEncryptTypeChanged();

		partial void OnEncryptTypeChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);
		#endregion


		public EncryptAttribute()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_attributeName", Name = "ATTRIBUTE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value)
							== false))
				{
					this.OnAttributeNameChanging(value);
					this._attributeName = value;
					this.OnAttributeNameChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_encryptAttributeID", Name = "ENCRYPT_ATTRIBUTE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EncryptAttributeId
		{
			get
			{
				return this._encryptAttributeID;
			}
			set
			{
				if ((_encryptAttributeID != value))
				{
					this.OnEncryptAttributeIdChanging(value);
					this._encryptAttributeID = value;
					this.OnEncryptAttributeIdChanged();
				}
			}
		}

		[Column(Storage = "_encryptType", Name = "ENCRYPT_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string EncryptType
		{
			get
			{
				return this._encryptType;
			}
			set
			{
				if (((_encryptType == value)
							== false))
				{
					this.OnEncryptTypeChanging(value);
					this._encryptType = value;
					this.OnEncryptTypeChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ENROLLMENT")]
	public partial class Enrollment
	{

		private long _accntHrcyStepID;

		private string _accountReceivable;

		private string _billingAddress1;

		private string _billingAddress2;

		private string _billingCity;

		private string _billingState;

		private string _billingZip;

		private string _creditCardExpiration;

		private string _creditCardName;

		private string _creditCardNumber;

		private string _creditCardType;

		private short _dhhCallCount;

		private string _dhhStatusCode;

		private System.Nullable<System.DateTime> _dhhStatusDate;

		private System.Nullable<System.DateTime> _enrolleeBirthDate;

		private short _enrollmentCallCount;

		private System.Nullable<System.DateTime> _enrollmentHistoryDate;

		private long _enrollmentID;

		private string _enrollmentStatusCode;

		private System.Nullable<System.DateTime> _enrollmentStatusDate;

		private string _firstShipmentInd;

		private string _lockInd;

		private string _mailcode;

		private string _medicaidNumber;

		private string _medicareNumber;

		private string _patientCode;

		private string _programType;

		private System.Nullable<short> _refillCallCount;

		private string _refillStatusCode;

		private System.Nullable<System.DateTime> _refillStatusDate;

		private string _regionalMedicaidOffice;

		private string _shipToAddress1;

		private string _shipToAddress2;

		private string _shipToCity;

		private string _shipToName;

		private string _shipToPhone;

		private string _shipToState;

		private string _shipToZip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAccountReceivableChanged();

		partial void OnAccountReceivableChanging(string value);

		partial void OnBillingAddress1Changed();

		partial void OnBillingAddress1Changing(string value);

		partial void OnBillingAddress2Changed();

		partial void OnBillingAddress2Changing(string value);

		partial void OnBillingCityChanged();

		partial void OnBillingCityChanging(string value);

		partial void OnBillingStateChanged();

		partial void OnBillingStateChanging(string value);

		partial void OnBillingZipChanged();

		partial void OnBillingZipChanging(string value);

		partial void OnCreditCardExpirationChanged();

		partial void OnCreditCardExpirationChanging(string value);

		partial void OnCreditCardNameChanged();

		partial void OnCreditCardNameChanging(string value);

		partial void OnCreditCardNumberChanged();

		partial void OnCreditCardNumberChanging(string value);

		partial void OnCreditCardTypeChanged();

		partial void OnCreditCardTypeChanging(string value);

		partial void OnDhhCallCountChanged();

		partial void OnDhhCallCountChanging(short value);

		partial void OnDhhStatusCodeChanged();

		partial void OnDhhStatusCodeChanging(string value);

		partial void OnDhhStatusDateChanged();

		partial void OnDhhStatusDateChanging(System.Nullable<System.DateTime> value);

		partial void OnEnrolleeBirthDateChanged();

		partial void OnEnrolleeBirthDateChanging(System.Nullable<System.DateTime> value);

		partial void OnEnrollmentCallCountChanged();

		partial void OnEnrollmentCallCountChanging(short value);

		partial void OnEnrollmentHistoryDateChanged();

		partial void OnEnrollmentHistoryDateChanging(System.Nullable<System.DateTime> value);

		partial void OnEnrollmentIdChanged();

		partial void OnEnrollmentIdChanging(long value);

		partial void OnEnrollmentStatusCodeChanged();

		partial void OnEnrollmentStatusCodeChanging(string value);

		partial void OnEnrollmentStatusDateChanged();

		partial void OnEnrollmentStatusDateChanging(System.Nullable<System.DateTime> value);

		partial void OnFirstShipmentIndChanged();

		partial void OnFirstShipmentIndChanging(string value);

		partial void OnLockIndChanged();

		partial void OnLockIndChanging(string value);

		partial void OnMailcodeChanged();

		partial void OnMailcodeChanging(string value);

		partial void OnMedicaidNumberChanged();

		partial void OnMedicaidNumberChanging(string value);

		partial void OnMedicareNumberChanged();

		partial void OnMedicareNumberChanging(string value);

		partial void OnPatientCodeChanged();

		partial void OnPatientCodeChanging(string value);

		partial void OnProgramTypeChanged();

		partial void OnProgramTypeChanging(string value);

		partial void OnRefillCallCountChanged();

		partial void OnRefillCallCountChanging(System.Nullable<short> value);

		partial void OnRefillStatusCodeChanged();

		partial void OnRefillStatusCodeChanging(string value);

		partial void OnRefillStatusDateChanged();

		partial void OnRefillStatusDateChanging(System.Nullable<System.DateTime> value);

		partial void OnRegionalMedicaidOfficeChanged();

		partial void OnRegionalMedicaidOfficeChanging(string value);

		partial void OnShipToAddress1Changed();

		partial void OnShipToAddress1Changing(string value);

		partial void OnShipToAddress2Changed();

		partial void OnShipToAddress2Changing(string value);

		partial void OnShipToCityChanged();

		partial void OnShipToCityChanging(string value);

		partial void OnShipToNameChanged();

		partial void OnShipToNameChanging(string value);

		partial void OnShipToPhoneChanged();

		partial void OnShipToPhoneChanging(string value);

		partial void OnShipToStateChanged();

		partial void OnShipToStateChanging(string value);

		partial void OnShipToZipChanged();

		partial void OnShipToZipChanging(string value);
		#endregion


		public Enrollment()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_accountReceivable", Name = "ACCOUNT_RECEIVABLE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AccountReceivable
		{
			get
			{
				return this._accountReceivable;
			}
			set
			{
				if (((_accountReceivable == value)
							== false))
				{
					this.OnAccountReceivableChanging(value);
					this._accountReceivable = value;
					this.OnAccountReceivableChanged();
				}
			}
		}

		[Column(Storage = "_billingAddress1", Name = "BILLING_ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BillingAddress1
		{
			get
			{
				return this._billingAddress1;
			}
			set
			{
				if (((_billingAddress1 == value)
							== false))
				{
					this.OnBillingAddress1Changing(value);
					this._billingAddress1 = value;
					this.OnBillingAddress1Changed();
				}
			}
		}

		[Column(Storage = "_billingAddress2", Name = "BILLING_ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BillingAddress2
		{
			get
			{
				return this._billingAddress2;
			}
			set
			{
				if (((_billingAddress2 == value)
							== false))
				{
					this.OnBillingAddress2Changing(value);
					this._billingAddress2 = value;
					this.OnBillingAddress2Changed();
				}
			}
		}

		[Column(Storage = "_billingCity", Name = "BILLING_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BillingCity
		{
			get
			{
				return this._billingCity;
			}
			set
			{
				if (((_billingCity == value)
							== false))
				{
					this.OnBillingCityChanging(value);
					this._billingCity = value;
					this.OnBillingCityChanged();
				}
			}
		}

		[Column(Storage = "_billingState", Name = "BILLING_STATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BillingState
		{
			get
			{
				return this._billingState;
			}
			set
			{
				if (((_billingState == value)
							== false))
				{
					this.OnBillingStateChanging(value);
					this._billingState = value;
					this.OnBillingStateChanged();
				}
			}
		}

		[Column(Storage = "_billingZip", Name = "BILLING_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BillingZip
		{
			get
			{
				return this._billingZip;
			}
			set
			{
				if (((_billingZip == value)
							== false))
				{
					this.OnBillingZipChanging(value);
					this._billingZip = value;
					this.OnBillingZipChanged();
				}
			}
		}

		[Column(Storage = "_creditCardExpiration", Name = "CREDIT_CARD_EXPIRATION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CreditCardExpiration
		{
			get
			{
				return this._creditCardExpiration;
			}
			set
			{
				if (((_creditCardExpiration == value)
							== false))
				{
					this.OnCreditCardExpirationChanging(value);
					this._creditCardExpiration = value;
					this.OnCreditCardExpirationChanged();
				}
			}
		}

		[Column(Storage = "_creditCardName", Name = "CREDIT_CARD_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CreditCardName
		{
			get
			{
				return this._creditCardName;
			}
			set
			{
				if (((_creditCardName == value)
							== false))
				{
					this.OnCreditCardNameChanging(value);
					this._creditCardName = value;
					this.OnCreditCardNameChanged();
				}
			}
		}

		[Column(Storage = "_creditCardNumber", Name = "CREDIT_CARD_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CreditCardNumber
		{
			get
			{
				return this._creditCardNumber;
			}
			set
			{
				if (((_creditCardNumber == value)
							== false))
				{
					this.OnCreditCardNumberChanging(value);
					this._creditCardNumber = value;
					this.OnCreditCardNumberChanged();
				}
			}
		}

		[Column(Storage = "_creditCardType", Name = "CREDIT_CARD_TYPE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CreditCardType
		{
			get
			{
				return this._creditCardType;
			}
			set
			{
				if (((_creditCardType == value)
							== false))
				{
					this.OnCreditCardTypeChanging(value);
					this._creditCardType = value;
					this.OnCreditCardTypeChanged();
				}
			}
		}

		[Column(Storage = "_dhhCallCount", Name = "DHH_CALL_COUNT", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public short DhhCallCount
		{
			get
			{
				return this._dhhCallCount;
			}
			set
			{
				if ((_dhhCallCount != value))
				{
					this.OnDhhCallCountChanging(value);
					this._dhhCallCount = value;
					this.OnDhhCallCountChanged();
				}
			}
		}

		[Column(Storage = "_dhhStatusCode", Name = "DHH_STATUS_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DhhStatusCode
		{
			get
			{
				return this._dhhStatusCode;
			}
			set
			{
				if (((_dhhStatusCode == value)
							== false))
				{
					this.OnDhhStatusCodeChanging(value);
					this._dhhStatusCode = value;
					this.OnDhhStatusCodeChanged();
				}
			}
		}

		[Column(Storage = "_dhhStatusDate", Name = "DHH_STATUS_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DhhStatusDate
		{
			get
			{
				return this._dhhStatusDate;
			}
			set
			{
				if ((_dhhStatusDate != value))
				{
					this.OnDhhStatusDateChanging(value);
					this._dhhStatusDate = value;
					this.OnDhhStatusDateChanged();
				}
			}
		}

		[Column(Storage = "_enrolleeBirthDate", Name = "ENROLLEE_BIRTH_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> EnrolleeBirthDate
		{
			get
			{
				return this._enrolleeBirthDate;
			}
			set
			{
				if ((_enrolleeBirthDate != value))
				{
					this.OnEnrolleeBirthDateChanging(value);
					this._enrolleeBirthDate = value;
					this.OnEnrolleeBirthDateChanged();
				}
			}
		}

		[Column(Storage = "_enrollmentCallCount", Name = "ENROLLMENT_CALL_COUNT", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public short EnrollmentCallCount
		{
			get
			{
				return this._enrollmentCallCount;
			}
			set
			{
				if ((_enrollmentCallCount != value))
				{
					this.OnEnrollmentCallCountChanging(value);
					this._enrollmentCallCount = value;
					this.OnEnrollmentCallCountChanged();
				}
			}
		}

		[Column(Storage = "_enrollmentHistoryDate", Name = "ENROLLMENT_HISTORY_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> EnrollmentHistoryDate
		{
			get
			{
				return this._enrollmentHistoryDate;
			}
			set
			{
				if ((_enrollmentHistoryDate != value))
				{
					this.OnEnrollmentHistoryDateChanging(value);
					this._enrollmentHistoryDate = value;
					this.OnEnrollmentHistoryDateChanged();
				}
			}
		}

		[Column(Storage = "_enrollmentID", Name = "ENROLLMENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EnrollmentId
		{
			get
			{
				return this._enrollmentID;
			}
			set
			{
				if ((_enrollmentID != value))
				{
					this.OnEnrollmentIdChanging(value);
					this._enrollmentID = value;
					this.OnEnrollmentIdChanged();
				}
			}
		}

		[Column(Storage = "_enrollmentStatusCode", Name = "ENROLLMENT_STATUS_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string EnrollmentStatusCode
		{
			get
			{
				return this._enrollmentStatusCode;
			}
			set
			{
				if (((_enrollmentStatusCode == value)
							== false))
				{
					this.OnEnrollmentStatusCodeChanging(value);
					this._enrollmentStatusCode = value;
					this.OnEnrollmentStatusCodeChanged();
				}
			}
		}

		[Column(Storage = "_enrollmentStatusDate", Name = "ENROLLMENT_STATUS_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> EnrollmentStatusDate
		{
			get
			{
				return this._enrollmentStatusDate;
			}
			set
			{
				if ((_enrollmentStatusDate != value))
				{
					this.OnEnrollmentStatusDateChanging(value);
					this._enrollmentStatusDate = value;
					this.OnEnrollmentStatusDateChanged();
				}
			}
		}

		[Column(Storage = "_firstShipmentInd", Name = "FIRST_SHIPMENT_IND", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FirstShipmentInd
		{
			get
			{
				return this._firstShipmentInd;
			}
			set
			{
				if (((_firstShipmentInd == value)
							== false))
				{
					this.OnFirstShipmentIndChanging(value);
					this._firstShipmentInd = value;
					this.OnFirstShipmentIndChanged();
				}
			}
		}

		[Column(Storage = "_lockInd", Name = "LOCK_IND", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LockInd
		{
			get
			{
				return this._lockInd;
			}
			set
			{
				if (((_lockInd == value)
							== false))
				{
					this.OnLockIndChanging(value);
					this._lockInd = value;
					this.OnLockIndChanged();
				}
			}
		}

		[Column(Storage = "_mailcode", Name = "MAILCODE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Mailcode
		{
			get
			{
				return this._mailcode;
			}
			set
			{
				if (((_mailcode == value)
							== false))
				{
					this.OnMailcodeChanging(value);
					this._mailcode = value;
					this.OnMailcodeChanged();
				}
			}
		}

		[Column(Storage = "_medicaidNumber", Name = "MEDICAID_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MedicaidNumber
		{
			get
			{
				return this._medicaidNumber;
			}
			set
			{
				if (((_medicaidNumber == value)
							== false))
				{
					this.OnMedicaidNumberChanging(value);
					this._medicaidNumber = value;
					this.OnMedicaidNumberChanged();
				}
			}
		}

		[Column(Storage = "_medicareNumber", Name = "MEDICARE_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MedicareNumber
		{
			get
			{
				return this._medicareNumber;
			}
			set
			{
				if (((_medicareNumber == value)
							== false))
				{
					this.OnMedicareNumberChanging(value);
					this._medicareNumber = value;
					this.OnMedicareNumberChanged();
				}
			}
		}

		[Column(Storage = "_patientCode", Name = "PATIENT_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PatientCode
		{
			get
			{
				return this._patientCode;
			}
			set
			{
				if (((_patientCode == value)
							== false))
				{
					this.OnPatientCodeChanging(value);
					this._patientCode = value;
					this.OnPatientCodeChanged();
				}
			}
		}

		[Column(Storage = "_programType", Name = "PROGRAM_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProgramType
		{
			get
			{
				return this._programType;
			}
			set
			{
				if (((_programType == value)
							== false))
				{
					this.OnProgramTypeChanging(value);
					this._programType = value;
					this.OnProgramTypeChanged();
				}
			}
		}

		[Column(Storage = "_refillCallCount", Name = "REFILL_CALL_COUNT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> RefillCallCount
		{
			get
			{
				return this._refillCallCount;
			}
			set
			{
				if ((_refillCallCount != value))
				{
					this.OnRefillCallCountChanging(value);
					this._refillCallCount = value;
					this.OnRefillCallCountChanged();
				}
			}
		}

		[Column(Storage = "_refillStatusCode", Name = "REFILL_STATUS_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RefillStatusCode
		{
			get
			{
				return this._refillStatusCode;
			}
			set
			{
				if (((_refillStatusCode == value)
							== false))
				{
					this.OnRefillStatusCodeChanging(value);
					this._refillStatusCode = value;
					this.OnRefillStatusCodeChanged();
				}
			}
		}

		[Column(Storage = "_refillStatusDate", Name = "REFILL_STATUS_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> RefillStatusDate
		{
			get
			{
				return this._refillStatusDate;
			}
			set
			{
				if ((_refillStatusDate != value))
				{
					this.OnRefillStatusDateChanging(value);
					this._refillStatusDate = value;
					this.OnRefillStatusDateChanged();
				}
			}
		}

		[Column(Storage = "_regionalMedicaidOffice", Name = "REGIONAL_MEDICAID_OFFICE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RegionalMedicaidOffice
		{
			get
			{
				return this._regionalMedicaidOffice;
			}
			set
			{
				if (((_regionalMedicaidOffice == value)
							== false))
				{
					this.OnRegionalMedicaidOfficeChanging(value);
					this._regionalMedicaidOffice = value;
					this.OnRegionalMedicaidOfficeChanged();
				}
			}
		}

		[Column(Storage = "_shipToAddress1", Name = "SHIP_TO_ADDRESS_1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShipToAddress1
		{
			get
			{
				return this._shipToAddress1;
			}
			set
			{
				if (((_shipToAddress1 == value)
							== false))
				{
					this.OnShipToAddress1Changing(value);
					this._shipToAddress1 = value;
					this.OnShipToAddress1Changed();
				}
			}
		}

		[Column(Storage = "_shipToAddress2", Name = "SHIP_TO_ADDRESS_2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShipToAddress2
		{
			get
			{
				return this._shipToAddress2;
			}
			set
			{
				if (((_shipToAddress2 == value)
							== false))
				{
					this.OnShipToAddress2Changing(value);
					this._shipToAddress2 = value;
					this.OnShipToAddress2Changed();
				}
			}
		}

		[Column(Storage = "_shipToCity", Name = "SHIP_TO_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShipToCity
		{
			get
			{
				return this._shipToCity;
			}
			set
			{
				if (((_shipToCity == value)
							== false))
				{
					this.OnShipToCityChanging(value);
					this._shipToCity = value;
					this.OnShipToCityChanged();
				}
			}
		}

		[Column(Storage = "_shipToName", Name = "SHIP_TO_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShipToName
		{
			get
			{
				return this._shipToName;
			}
			set
			{
				if (((_shipToName == value)
							== false))
				{
					this.OnShipToNameChanging(value);
					this._shipToName = value;
					this.OnShipToNameChanged();
				}
			}
		}

		[Column(Storage = "_shipToPhone", Name = "SHIP_TO_PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShipToPhone
		{
			get
			{
				return this._shipToPhone;
			}
			set
			{
				if (((_shipToPhone == value)
							== false))
				{
					this.OnShipToPhoneChanging(value);
					this._shipToPhone = value;
					this.OnShipToPhoneChanged();
				}
			}
		}

		[Column(Storage = "_shipToState", Name = "SHIP_TO_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShipToState
		{
			get
			{
				return this._shipToState;
			}
			set
			{
				if (((_shipToState == value)
							== false))
				{
					this.OnShipToStateChanging(value);
					this._shipToState = value;
					this.OnShipToStateChanged();
				}
			}
		}

		[Column(Storage = "_shipToZip", Name = "SHIP_TO_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ShipToZip
		{
			get
			{
				return this._shipToZip;
			}
			set
			{
				if (((_shipToZip == value)
							== false))
				{
					this.OnShipToZipChanging(value);
					this._shipToZip = value;
					this.OnShipToZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ENROLLMENT_STATUS_CODES")]
	public partial class EnrollmentStatusCodes
	{

		private string _enrollmentStatus;

		private string _enrollmentStatusCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnEnrollmentStatusChanged();

		partial void OnEnrollmentStatusChanging(string value);

		partial void OnEnrollmentStatusCodeChanged();

		partial void OnEnrollmentStatusCodeChanging(string value);
		#endregion


		public EnrollmentStatusCodes()
		{
			this.OnCreated();
		}

		[Column(Storage = "_enrollmentStatus", Name = "ENROLLMENT_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnrollmentStatus
		{
			get
			{
				return this._enrollmentStatus;
			}
			set
			{
				if (((_enrollmentStatus == value)
							== false))
				{
					this.OnEnrollmentStatusChanging(value);
					this._enrollmentStatus = value;
					this.OnEnrollmentStatusChanged();
				}
			}
		}

		[Column(Storage = "_enrollmentStatusCode", Name = "ENROLLMENT_STATUS_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string EnrollmentStatusCode
		{
			get
			{
				return this._enrollmentStatusCode;
			}
			set
			{
				if (((_enrollmentStatusCode == value)
							== false))
				{
					this.OnEnrollmentStatusCodeChanging(value);
					this._enrollmentStatusCode = value;
					this.OnEnrollmentStatusCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ESCALATION_OUTCOME")]
	public partial class EscalationOutcome
	{

		private long _callID;

		private System.DateTime _createdDate;

		private string _description;

		private long _escalationOutcomeID;

		private long _escalationPlanID;

		private System.DateTime _modifiedDate;

		private string _status;

		private System.Nullable<long> _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEscalationOutcomeIdChanged();

		partial void OnEscalationOutcomeIdChanging(long value);

		partial void OnEscalationPlanIdChanged();

		partial void OnEscalationPlanIdChanging(long value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.DateTime value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(System.Nullable<long> value);
		#endregion


		public EscalationOutcome()
		{
			this.OnCreated();
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_escalationOutcomeID", Name = "ESCALATION_OUTCOME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EscalationOutcomeId
		{
			get
			{
				return this._escalationOutcomeID;
			}
			set
			{
				if ((_escalationOutcomeID != value))
				{
					this.OnEscalationOutcomeIdChanging(value);
					this._escalationOutcomeID = value;
					this.OnEscalationOutcomeIdChanged();
				}
			}
		}

		[Column(Storage = "_escalationPlanID", Name = "ESCALATION_PLAN_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EscalationPlanId
		{
			get
			{
				return this._escalationPlanID;
			}
			set
			{
				if ((_escalationPlanID != value))
				{
					this.OnEscalationPlanIdChanging(value);
					this._escalationPlanID = value;
					this.OnEscalationPlanIdChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ESCALATION_OUTCOME_STEP")]
	public partial class EscalationOutcomeStep
	{

		private string _contactPerson;

		private string _contactPersonTitle;

		private string _contactPhoneNumber;

		private System.DateTime _createdDate;

		private string _description;

		private long _escalationOutcomeID;

		private long _escalationOutcomeStepID;

		private System.DateTime _modifiedDate;

		private long _sequence;

		private string _status;

		private long _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnContactPersonChanged();

		partial void OnContactPersonChanging(string value);

		partial void OnContactPersonTitleChanged();

		partial void OnContactPersonTitleChanging(string value);

		partial void OnContactPhoneNumberChanged();

		partial void OnContactPhoneNumberChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEscalationOutcomeIdChanged();

		partial void OnEscalationOutcomeIdChanging(long value);

		partial void OnEscalationOutcomeStepIdChanged();

		partial void OnEscalationOutcomeStepIdChanging(long value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.DateTime value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(long value);
		#endregion


		public EscalationOutcomeStep()
		{
			this.OnCreated();
		}

		[Column(Storage = "_contactPerson", Name = "CONTACT_PERSON", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactPerson
		{
			get
			{
				return this._contactPerson;
			}
			set
			{
				if (((_contactPerson == value)
							== false))
				{
					this.OnContactPersonChanging(value);
					this._contactPerson = value;
					this.OnContactPersonChanged();
				}
			}
		}

		[Column(Storage = "_contactPersonTitle", Name = "CONTACT_PERSON_TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactPersonTitle
		{
			get
			{
				return this._contactPersonTitle;
			}
			set
			{
				if (((_contactPersonTitle == value)
							== false))
				{
					this.OnContactPersonTitleChanging(value);
					this._contactPersonTitle = value;
					this.OnContactPersonTitleChanged();
				}
			}
		}

		[Column(Storage = "_contactPhoneNumber", Name = "CONTACT_PHONE_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactPhoneNumber
		{
			get
			{
				return this._contactPhoneNumber;
			}
			set
			{
				if (((_contactPhoneNumber == value)
							== false))
				{
					this.OnContactPhoneNumberChanging(value);
					this._contactPhoneNumber = value;
					this.OnContactPhoneNumberChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_escalationOutcomeID", Name = "ESCALATION_OUTCOME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EscalationOutcomeId
		{
			get
			{
				return this._escalationOutcomeID;
			}
			set
			{
				if ((_escalationOutcomeID != value))
				{
					this.OnEscalationOutcomeIdChanging(value);
					this._escalationOutcomeID = value;
					this.OnEscalationOutcomeIdChanged();
				}
			}
		}

		[Column(Storage = "_escalationOutcomeStepID", Name = "ESCALATION_OUTCOME_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EscalationOutcomeStepId
		{
			get
			{
				return this._escalationOutcomeStepID;
			}
			set
			{
				if ((_escalationOutcomeStepID != value))
				{
					this.OnEscalationOutcomeStepIdChanging(value);
					this._escalationOutcomeStepID = value;
					this.OnEscalationOutcomeStepIdChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ESCALATION_PLAN")]
	public partial class EscalationPlan
	{

		private long _accntHrcyStepID;

		private string _description;

		private string _enabledFlag;

		private System.Nullable<long> _enableRuleID;

		private long _escalationPlanID;

		private string _lobCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledFlagChanged();

		partial void OnEnabledFlagChanging(string value);

		partial void OnEnableRuleIdChanged();

		partial void OnEnableRuleIdChanging(System.Nullable<long> value);

		partial void OnEscalationPlanIdChanged();

		partial void OnEscalationPlanIdChanging(long value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);
		#endregion


		public EscalationPlan()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledFlag", Name = "ENABLED_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string EnabledFlag
		{
			get
			{
				return this._enabledFlag;
			}
			set
			{
				if (((_enabledFlag == value)
							== false))
				{
					this.OnEnabledFlagChanging(value);
					this._enabledFlag = value;
					this.OnEnabledFlagChanged();
				}
			}
		}

		[Column(Storage = "_enableRuleID", Name = "ENABLERULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnableRuleId
		{
			get
			{
				return this._enableRuleID;
			}
			set
			{
				if ((_enableRuleID != value))
				{
					this.OnEnableRuleIdChanging(value);
					this._enableRuleID = value;
					this.OnEnableRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_escalationPlanID", Name = "ESCALATION_PLAN_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EscalationPlanId
		{
			get
			{
				return this._escalationPlanID;
			}
			set
			{
				if ((_escalationPlanID != value))
				{
					this.OnEscalationPlanIdChanging(value);
					this._escalationPlanID = value;
					this.OnEscalationPlanIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ESCALATION_SEQ_STEP")]
	public partial class EscalationSeqStep
	{

		private System.Nullable<long> _contactID;

		private System.Nullable<long> _enabledRuleID;

		private System.Nullable<long> _escalationPlanID;

		private long _escalationSeqStepID;

		private long _sequenceNumber;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnContactIdChanged();

		partial void OnContactIdChanging(System.Nullable<long> value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<long> value);

		partial void OnEscalationPlanIdChanged();

		partial void OnEscalationPlanIdChanging(System.Nullable<long> value);

		partial void OnEscalationSeqStepIdChanged();

		partial void OnEscalationSeqStepIdChanging(long value);

		partial void OnSequenceNumberChanged();

		partial void OnSequenceNumberChanging(long value);
		#endregion


		public EscalationSeqStep()
		{
			this.OnCreated();
		}

		[Column(Storage = "_contactID", Name = "CONTACT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ContactId
		{
			get
			{
				return this._contactID;
			}
			set
			{
				if ((_contactID != value))
				{
					this.OnContactIdChanging(value);
					this._contactID = value;
					this.OnContactIdChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_escalationPlanID", Name = "ESCALATION_PLAN_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EscalationPlanId
		{
			get
			{
				return this._escalationPlanID;
			}
			set
			{
				if ((_escalationPlanID != value))
				{
					this.OnEscalationPlanIdChanging(value);
					this._escalationPlanID = value;
					this.OnEscalationPlanIdChanged();
				}
			}
		}

		[Column(Storage = "_escalationSeqStepID", Name = "ESCALATION_SEQ_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EscalationSeqStepId
		{
			get
			{
				return this._escalationSeqStepID;
			}
			set
			{
				if ((_escalationSeqStepID != value))
				{
					this.OnEscalationSeqStepIdChanging(value);
					this._escalationSeqStepID = value;
					this.OnEscalationSeqStepIdChanged();
				}
			}
		}

		[Column(Storage = "_sequenceNumber", Name = "SEQUENCE_NUMBER", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long SequenceNumber
		{
			get
			{
				return this._sequenceNumber;
			}
			set
			{
				if ((_sequenceNumber != value))
				{
					this.OnSequenceNumberChanging(value);
					this._sequenceNumber = value;
					this.OnSequenceNumberChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ESIS_SEVERITY_CODE_TRIGGER")]
	public partial class EsisSeverityCodeTrigger
	{

		private string _attributeName;

		private string _attributeValue;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAttributeNameChanged();

		partial void OnAttributeNameChanging(string value);

		partial void OnAttributeValueChanged();

		partial void OnAttributeValueChanging(string value);
		#endregion


		public EsisSeverityCodeTrigger()
		{
			this.OnCreated();
		}

		[Column(Storage = "_attributeName", Name = "ATTRIBUTE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value)
							== false))
				{
					this.OnAttributeNameChanging(value);
					this._attributeName = value;
					this.OnAttributeNameChanged();
				}
			}
		}

		[Column(Storage = "_attributeValue", Name = "ATTRIBUTE_VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttributeValue
		{
			get
			{
				return this._attributeValue;
			}
			set
			{
				if (((_attributeValue == value)
							== false))
				{
					this.OnAttributeValueChanging(value);
					this._attributeValue = value;
					this.OnAttributeValueChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FAX_FILE_IMPORT")]
	public partial class FaxFileImport
	{

		private System.DateTime _createdDate;

		private string _description;

		private long _faxFileImportDefID;

		private long _length;

		private System.Nullable<System.DateTime> _modifiedDate;

		private long _startpos;

		private string _variablename;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFaxFileImportDefIdChanged();

		partial void OnFaxFileImportDefIdChanging(long value);

		partial void OnLengthChanged();

		partial void OnLengthChanging(long value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnStartposChanged();

		partial void OnStartposChanging(long value);

		partial void OnVariablenameChanged();

		partial void OnVariablenameChanging(string value);
		#endregion


		public FaxFileImport()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_faxFileImportDefID", Name = "FAX_FILE_IMPORT_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FaxFileImportDefId
		{
			get
			{
				return this._faxFileImportDefID;
			}
			set
			{
				if ((_faxFileImportDefID != value))
				{
					this.OnFaxFileImportDefIdChanging(value);
					this._faxFileImportDefID = value;
					this.OnFaxFileImportDefIdChanged();
				}
			}
		}

		[Column(Storage = "_length", Name = "LENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Length
		{
			get
			{
				return this._length;
			}
			set
			{
				if ((_length != value))
				{
					this.OnLengthChanging(value);
					this._length = value;
					this.OnLengthChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_startpos", Name = "STARTPOS", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Startpos
		{
			get
			{
				return this._startpos;
			}
			set
			{
				if ((_startpos != value))
				{
					this.OnStartposChanging(value);
					this._startpos = value;
					this.OnStartposChanged();
				}
			}
		}

		[Column(Storage = "_variablename", Name = "VARIABLENAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Variablename
		{
			get
			{
				return this._variablename;
			}
			set
			{
				if (((_variablename == value)
							== false))
				{
					this.OnVariablenameChanging(value);
					this._variablename = value;
					this.OnVariablenameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FAX_FILE_IMPORT_ASSIGNMENT")]
	public partial class FaxFileImportAssignment
	{

		private string _clientCode;

		private string _description;

		private long _faxFileImportDefID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnClientCodeChanged();

		partial void OnClientCodeChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFaxFileImportDefIdChanged();

		partial void OnFaxFileImportDefIdChanging(long value);
		#endregion


		public FaxFileImportAssignment()
		{
			this.OnCreated();
		}

		[Column(Storage = "_clientCode", Name = "CLIENT_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ClientCode
		{
			get
			{
				return this._clientCode;
			}
			set
			{
				if (((_clientCode == value)
							== false))
				{
					this.OnClientCodeChanging(value);
					this._clientCode = value;
					this.OnClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_faxFileImportDefID", Name = "FAX_FILE_IMPORT_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FaxFileImportDefId
		{
			get
			{
				return this._faxFileImportDefID;
			}
			set
			{
				if ((_faxFileImportDefID != value))
				{
					this.OnFaxFileImportDefIdChanging(value);
					this._faxFileImportDefID = value;
					this.OnFaxFileImportDefIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FAX_FILE_IMPORT_DEF")]
	public partial class FaxFileImportDef
	{

		private string _description;

		private long _faxFileImportDefID;

		private string _lobCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFaxFileImportDefIdChanged();

		partial void OnFaxFileImportDefIdChanging(long value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);
		#endregion


		public FaxFileImportDef()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_faxFileImportDefID", Name = "FAX_FILE_IMPORT_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FaxFileImportDefId
		{
			get
			{
				return this._faxFileImportDefID;
			}
			set
			{
				if ((_faxFileImportDefID != value))
				{
					this.OnFaxFileImportDefIdChanging(value);
					this._faxFileImportDefID = value;
					this.OnFaxFileImportDefIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FAX_FILE_IMPORT_LOG")]
	public partial class FaxFileImportLog
	{

		private System.Nullable<long> _callID;

		private System.DateTime _createdDate;

		private string _errorText;

		private long _faxFileImportLogID;

		private string _fileName;

		private string _legacyKeyCallID;

		private string _legacyKeyClientCode;

		private System.Nullable<long> _legacyKeyInstance;

		private string _legacyKeyLocationID;

		private string _legacyKeyLocationType;

		private System.DateTime _modifiedDate;

		private string _status;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(System.Nullable<long> value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnErrorTextChanged();

		partial void OnErrorTextChanging(string value);

		partial void OnFaxFileImportLogIdChanged();

		partial void OnFaxFileImportLogIdChanging(long value);

		partial void OnFileNameChanged();

		partial void OnFileNameChanging(string value);

		partial void OnLegacyKeyCallIdChanged();

		partial void OnLegacyKeyCallIdChanging(string value);

		partial void OnLegacyKeyClientCodeChanged();

		partial void OnLegacyKeyClientCodeChanging(string value);

		partial void OnLegacyKeyInstanceChanged();

		partial void OnLegacyKeyInstanceChanging(System.Nullable<long> value);

		partial void OnLegacyKeyLocationIdChanged();

		partial void OnLegacyKeyLocationIdChanging(string value);

		partial void OnLegacyKeyLocationTypeChanged();

		partial void OnLegacyKeyLocationTypeChanging(string value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.DateTime value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);
		#endregion


		public FaxFileImportLog()
		{
			this.OnCreated();
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DATE", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_errorText", Name = "ERROR_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ErrorText
		{
			get
			{
				return this._errorText;
			}
			set
			{
				if (((_errorText == value)
							== false))
				{
					this.OnErrorTextChanging(value);
					this._errorText = value;
					this.OnErrorTextChanged();
				}
			}
		}

		[Column(Storage = "_faxFileImportLogID", Name = "FAX_FILE_IMPORT_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FaxFileImportLogId
		{
			get
			{
				return this._faxFileImportLogID;
			}
			set
			{
				if ((_faxFileImportLogID != value))
				{
					this.OnFaxFileImportLogIdChanging(value);
					this._faxFileImportLogID = value;
					this.OnFaxFileImportLogIdChanged();
				}
			}
		}

		[Column(Storage = "_fileName", Name = "FILE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				if (((_fileName == value)
							== false))
				{
					this.OnFileNameChanging(value);
					this._fileName = value;
					this.OnFileNameChanged();
				}
			}
		}

		[Column(Storage = "_legacyKeyCallID", Name = "LEGACY_KEY_CALL_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LegacyKeyCallId
		{
			get
			{
				return this._legacyKeyCallID;
			}
			set
			{
				if (((_legacyKeyCallID == value)
							== false))
				{
					this.OnLegacyKeyCallIdChanging(value);
					this._legacyKeyCallID = value;
					this.OnLegacyKeyCallIdChanged();
				}
			}
		}

		[Column(Storage = "_legacyKeyClientCode", Name = "LEGACY_KEY_CLIENT_CODE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LegacyKeyClientCode
		{
			get
			{
				return this._legacyKeyClientCode;
			}
			set
			{
				if (((_legacyKeyClientCode == value)
							== false))
				{
					this.OnLegacyKeyClientCodeChanging(value);
					this._legacyKeyClientCode = value;
					this.OnLegacyKeyClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_legacyKeyInstance", Name = "LEGACY_KEY_INSTANCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LegacyKeyInstance
		{
			get
			{
				return this._legacyKeyInstance;
			}
			set
			{
				if ((_legacyKeyInstance != value))
				{
					this.OnLegacyKeyInstanceChanging(value);
					this._legacyKeyInstance = value;
					this.OnLegacyKeyInstanceChanged();
				}
			}
		}

		[Column(Storage = "_legacyKeyLocationID", Name = "LEGACY_KEY_LOCATION_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LegacyKeyLocationId
		{
			get
			{
				return this._legacyKeyLocationID;
			}
			set
			{
				if (((_legacyKeyLocationID == value)
							== false))
				{
					this.OnLegacyKeyLocationIdChanging(value);
					this._legacyKeyLocationID = value;
					this.OnLegacyKeyLocationIdChanged();
				}
			}
		}

		[Column(Storage = "_legacyKeyLocationType", Name = "LEGACY_KEY_LOCATION_TYPE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LegacyKeyLocationType
		{
			get
			{
				return this._legacyKeyLocationType;
			}
			set
			{
				if (((_legacyKeyLocationType == value)
							== false))
				{
					this.OnLegacyKeyLocationTypeChanging(value);
					this._legacyKeyLocationType = value;
					this.OnLegacyKeyLocationTypeChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DATE", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FILE_OUTPUT_DEF")]
	public partial class FileOutputDef
	{

		private string _attributeName;

		private string _description;

		private short _fieldSize;

		private long _fileOutputDefID;

		private string _fileOutputType;

		private long _offset;

		private short _seq;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAttributeNameChanged();

		partial void OnAttributeNameChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFieldSizeChanged();

		partial void OnFieldSizeChanging(short value);

		partial void OnFileOutputDefIdChanged();

		partial void OnFileOutputDefIdChanging(long value);

		partial void OnFileOutputTypeChanged();

		partial void OnFileOutputTypeChanging(string value);

		partial void OnOffsetChanged();

		partial void OnOffsetChanging(long value);

		partial void OnSeqChanged();

		partial void OnSeqChanging(short value);
		#endregion


		public FileOutputDef()
		{
			this.OnCreated();
		}

		[Column(Storage = "_attributeName", Name = "ATTRIBUTE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value)
							== false))
				{
					this.OnAttributeNameChanging(value);
					this._attributeName = value;
					this.OnAttributeNameChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_fieldSize", Name = "FIELD_SIZE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public short FieldSize
		{
			get
			{
				return this._fieldSize;
			}
			set
			{
				if ((_fieldSize != value))
				{
					this.OnFieldSizeChanging(value);
					this._fieldSize = value;
					this.OnFieldSizeChanged();
				}
			}
		}

		[Column(Storage = "_fileOutputDefID", Name = "FILE_OUTPUT_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FileOutputDefId
		{
			get
			{
				return this._fileOutputDefID;
			}
			set
			{
				if ((_fileOutputDefID != value))
				{
					this.OnFileOutputDefIdChanging(value);
					this._fileOutputDefID = value;
					this.OnFileOutputDefIdChanged();
				}
			}
		}

		[Column(Storage = "_fileOutputType", Name = "FILE_OUTPUT_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FileOutputType
		{
			get
			{
				return this._fileOutputType;
			}
			set
			{
				if (((_fileOutputType == value)
							== false))
				{
					this.OnFileOutputTypeChanging(value);
					this._fileOutputType = value;
					this.OnFileOutputTypeChanged();
				}
			}
		}

		[Column(Storage = "_offset", Name = "OFFSET", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Offset
		{
			get
			{
				return this._offset;
			}
			set
			{
				if ((_offset != value))
				{
					this.OnOffsetChanging(value);
					this._offset = value;
					this.OnOffsetChanged();
				}
			}
		}

		[Column(Storage = "_seq", Name = "SEQ", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public short Seq
		{
			get
			{
				return this._seq;
			}
			set
			{
				if ((_seq != value))
				{
					this.OnSeqChanging(value);
					this._seq = value;
					this.OnSeqChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FILE_TRANSMISSION_DEF")]
	public partial class FileTransmissionDef
	{

		private System.Nullable<long> _accntHrcyStepID;

		private System.DateTime _createdDate;

		private string _description;

		private string _destinationUifLocation;

		private string _directory;

		private string _fileNamePattern;

		private long _fileTransmissionDefID;

		private System.Nullable<long> _froiImpRecordID;

		private System.Nullable<long> _lastLoadSequence;

		private string _locationIdentifier;

		private System.Nullable<bool> _reportType;

		private System.Nullable<long> _sequence;

		private string _server;

		private string _sourceLocation;

		private string _type;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnDestinationUifLocationChanged();

		partial void OnDestinationUifLocationChanging(string value);

		partial void OnDirectoryChanged();

		partial void OnDirectoryChanging(string value);

		partial void OnFileNamePatternChanged();

		partial void OnFileNamePatternChanging(string value);

		partial void OnFileTransmissionDefIdChanged();

		partial void OnFileTransmissionDefIdChanging(long value);

		partial void OnFroiImpRecordIdChanged();

		partial void OnFroiImpRecordIdChanging(System.Nullable<long> value);

		partial void OnLastLoadSequenceChanged();

		partial void OnLastLoadSequenceChanging(System.Nullable<long> value);

		partial void OnLocationIdentifierChanged();

		partial void OnLocationIdentifierChanging(string value);

		partial void OnReportTypeChanged();

		partial void OnReportTypeChanging(System.Nullable<bool> value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<long> value);

		partial void OnServerChanged();

		partial void OnServerChanging(string value);

		partial void OnSourceLocationChanged();

		partial void OnSourceLocationChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);
		#endregion


		public FileTransmissionDef()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_destinationUifLocation", Name = "DESTINATION_UIF_LOCATION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DestinationUifLocation
		{
			get
			{
				return this._destinationUifLocation;
			}
			set
			{
				if (((_destinationUifLocation == value)
							== false))
				{
					this.OnDestinationUifLocationChanging(value);
					this._destinationUifLocation = value;
					this.OnDestinationUifLocationChanged();
				}
			}
		}

		[Column(Storage = "_directory", Name = "DIRECTORY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Directory
		{
			get
			{
				return this._directory;
			}
			set
			{
				if (((_directory == value)
							== false))
				{
					this.OnDirectoryChanging(value);
					this._directory = value;
					this.OnDirectoryChanged();
				}
			}
		}

		[Column(Storage = "_fileNamePattern", Name = "FILE_NAME_PATTERN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FileNamePattern
		{
			get
			{
				return this._fileNamePattern;
			}
			set
			{
				if (((_fileNamePattern == value)
							== false))
				{
					this.OnFileNamePatternChanging(value);
					this._fileNamePattern = value;
					this.OnFileNamePatternChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionDefID", Name = "FILE_TRANSMISSION_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FileTransmissionDefId
		{
			get
			{
				return this._fileTransmissionDefID;
			}
			set
			{
				if ((_fileTransmissionDefID != value))
				{
					this.OnFileTransmissionDefIdChanging(value);
					this._fileTransmissionDefID = value;
					this.OnFileTransmissionDefIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpRecordID", Name = "FROI_IMP_RECORD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpRecordId
		{
			get
			{
				return this._froiImpRecordID;
			}
			set
			{
				if ((_froiImpRecordID != value))
				{
					this.OnFroiImpRecordIdChanging(value);
					this._froiImpRecordID = value;
					this.OnFroiImpRecordIdChanged();
				}
			}
		}

		[Column(Storage = "_lastLoadSequence", Name = "LAST_LOAD_SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> LastLoadSequence
		{
			get
			{
				return this._lastLoadSequence;
			}
			set
			{
				if ((_lastLoadSequence != value))
				{
					this.OnLastLoadSequenceChanging(value);
					this._lastLoadSequence = value;
					this.OnLastLoadSequenceChanged();
				}
			}
		}

		[Column(Storage = "_locationIdentifier", Name = "LOCATION_IDENTIFIER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LocationIdentifier
		{
			get
			{
				return this._locationIdentifier;
			}
			set
			{
				if (((_locationIdentifier == value)
							== false))
				{
					this.OnLocationIdentifierChanging(value);
					this._locationIdentifier = value;
					this.OnLocationIdentifierChanged();
				}
			}
		}

		[Column(Storage = "_reportType", Name = "REPORT_TYPE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<bool> ReportType
		{
			get
			{
				return this._reportType;
			}
			set
			{
				if ((_reportType != value))
				{
					this.OnReportTypeChanging(value);
					this._reportType = value;
					this.OnReportTypeChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_server", Name = "SERVER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Server
		{
			get
			{
				return this._server;
			}
			set
			{
				if (((_server == value)
							== false))
				{
					this.OnServerChanging(value);
					this._server = value;
					this.OnServerChanged();
				}
			}
		}

		[Column(Storage = "_sourceLocation", Name = "SOURCE_LOCATION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SourceLocation
		{
			get
			{
				return this._sourceLocation;
			}
			set
			{
				if (((_sourceLocation == value)
							== false))
				{
					this.OnSourceLocationChanging(value);
					this._sourceLocation = value;
					this.OnSourceLocationChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FILE_TRANSMISSION_ERROR")]
	public partial class FileTransmissionError
	{

		private System.Nullable<long> _accntHrcyStepID;

		private string _cancellationDate;

		private System.DateTime _createdDate;

		private string _effectiveDate;

		private string _entityID;

		private string _entityName;

		private string _errorCode;

		private string _errorText;

		private string _expirationDate;

		private long _fileTransmissionErrorID;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _lobCode;

		private string _name;

		private string _nodeID;

		private string _nodeName;

		private string _policyNumber;

		private string _recordData;

		private long _severity;

		private string _type;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnCancellationDateChanged();

		partial void OnCancellationDateChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnEffectiveDateChanged();

		partial void OnEffectiveDateChanging(string value);

		partial void OnEntityIdChanged();

		partial void OnEntityIdChanging(string value);

		partial void OnEntityNameChanged();

		partial void OnEntityNameChanging(string value);

		partial void OnErrorCodeChanged();

		partial void OnErrorCodeChanging(string value);

		partial void OnErrorTextChanged();

		partial void OnErrorTextChanging(string value);

		partial void OnExpirationDateChanged();

		partial void OnExpirationDateChanging(string value);

		partial void OnFileTransmissionErrorIdChanged();

		partial void OnFileTransmissionErrorIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnNodeIdChanged();

		partial void OnNodeIdChanging(string value);

		partial void OnNodeNameChanged();

		partial void OnNodeNameChanging(string value);

		partial void OnPolicyNumberChanged();

		partial void OnPolicyNumberChanging(string value);

		partial void OnRecordDataChanged();

		partial void OnRecordDataChanging(string value);

		partial void OnSeverityChanged();

		partial void OnSeverityChanging(long value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);
		#endregion


		public FileTransmissionError()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_cancellationDate", Name = "CANCELLATION_DT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CancellationDate
		{
			get
			{
				return this._cancellationDate;
			}
			set
			{
				if (((_cancellationDate == value)
							== false))
				{
					this.OnCancellationDateChanging(value);
					this._cancellationDate = value;
					this.OnCancellationDateChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_effectiveDate", Name = "EFFECTIVE_DT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EffectiveDate
		{
			get
			{
				return this._effectiveDate;
			}
			set
			{
				if (((_effectiveDate == value)
							== false))
				{
					this.OnEffectiveDateChanging(value);
					this._effectiveDate = value;
					this.OnEffectiveDateChanged();
				}
			}
		}

		[Column(Storage = "_entityID", Name = "ENTITY_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EntityId
		{
			get
			{
				return this._entityID;
			}
			set
			{
				if (((_entityID == value)
							== false))
				{
					this.OnEntityIdChanging(value);
					this._entityID = value;
					this.OnEntityIdChanged();
				}
			}
		}

		[Column(Storage = "_entityName", Name = "ENTITY_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EntityName
		{
			get
			{
				return this._entityName;
			}
			set
			{
				if (((_entityName == value)
							== false))
				{
					this.OnEntityNameChanging(value);
					this._entityName = value;
					this.OnEntityNameChanged();
				}
			}
		}

		[Column(Storage = "_errorCode", Name = "ERROR_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ErrorCode
		{
			get
			{
				return this._errorCode;
			}
			set
			{
				if (((_errorCode == value)
							== false))
				{
					this.OnErrorCodeChanging(value);
					this._errorCode = value;
					this.OnErrorCodeChanged();
				}
			}
		}

		[Column(Storage = "_errorText", Name = "ERROR_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ErrorText
		{
			get
			{
				return this._errorText;
			}
			set
			{
				if (((_errorText == value)
							== false))
				{
					this.OnErrorTextChanging(value);
					this._errorText = value;
					this.OnErrorTextChanged();
				}
			}
		}

		[Column(Storage = "_expirationDate", Name = "EXPIRATION_DT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ExpirationDate
		{
			get
			{
				return this._expirationDate;
			}
			set
			{
				if (((_expirationDate == value)
							== false))
				{
					this.OnExpirationDateChanging(value);
					this._expirationDate = value;
					this.OnExpirationDateChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionErrorID", Name = "FILE_TRANSMISSION_ERROR_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FileTransmissionErrorId
		{
			get
			{
				return this._fileTransmissionErrorID;
			}
			set
			{
				if ((_fileTransmissionErrorID != value))
				{
					this.OnFileTransmissionErrorIdChanging(value);
					this._fileTransmissionErrorID = value;
					this.OnFileTransmissionErrorIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_nodeID", Name = "NODE_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NodeId
		{
			get
			{
				return this._nodeID;
			}
			set
			{
				if (((_nodeID == value)
							== false))
				{
					this.OnNodeIdChanging(value);
					this._nodeID = value;
					this.OnNodeIdChanged();
				}
			}
		}

		[Column(Storage = "_nodeName", Name = "NODE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NodeName
		{
			get
			{
				return this._nodeName;
			}
			set
			{
				if (((_nodeName == value)
							== false))
				{
					this.OnNodeNameChanging(value);
					this._nodeName = value;
					this.OnNodeNameChanged();
				}
			}
		}

		[Column(Storage = "_policyNumber", Name = "POLICY_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PolicyNumber
		{
			get
			{
				return this._policyNumber;
			}
			set
			{
				if (((_policyNumber == value)
							== false))
				{
					this.OnPolicyNumberChanging(value);
					this._policyNumber = value;
					this.OnPolicyNumberChanged();
				}
			}
		}

		[Column(Storage = "_recordData", Name = "RECORD_DATA", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RecordData
		{
			get
			{
				return this._recordData;
			}
			set
			{
				if (((_recordData == value)
							== false))
				{
					this.OnRecordDataChanging(value);
					this._recordData = value;
					this.OnRecordDataChanged();
				}
			}
		}

		[Column(Storage = "_severity", Name = "SEVERITY", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Severity
		{
			get
			{
				return this._severity;
			}
			set
			{
				if ((_severity != value))
				{
					this.OnSeverityChanging(value);
					this._severity = value;
					this.OnSeverityChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FILE_TRANSMISSION_LOG")]
	public partial class FileTransmissionLog
	{

		private System.Nullable<System.DateTime> _createdDate;

		private string _fileName;

		private long _fileTransmissionDefID;

		private long _fileTransmissionLogID;

		private System.Nullable<System.DateTime> _modifiedDate;

		private System.Nullable<long> _parentID;

		private string _reportedFlag;

		private string _server;

		private string _status;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnFileNameChanged();

		partial void OnFileNameChanging(string value);

		partial void OnFileTransmissionDefIdChanged();

		partial void OnFileTransmissionDefIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(long value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnParentIdChanged();

		partial void OnParentIdChanging(System.Nullable<long> value);

		partial void OnReportedFlagChanged();

		partial void OnReportedFlagChanging(string value);

		partial void OnServerChanged();

		partial void OnServerChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);
		#endregion


		public FileTransmissionLog()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_fileName", Name = "FILE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				if (((_fileName == value)
							== false))
				{
					this.OnFileNameChanging(value);
					this._fileName = value;
					this.OnFileNameChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionDefID", Name = "FILE_TRANSMISSION_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FileTransmissionDefId
		{
			get
			{
				return this._fileTransmissionDefID;
			}
			set
			{
				if ((_fileTransmissionDefID != value))
				{
					this.OnFileTransmissionDefIdChanging(value);
					this._fileTransmissionDefID = value;
					this.OnFileTransmissionDefIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_parentID", Name = "PARENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ParentId
		{
			get
			{
				return this._parentID;
			}
			set
			{
				if ((_parentID != value))
				{
					this.OnParentIdChanging(value);
					this._parentID = value;
					this.OnParentIdChanged();
				}
			}
		}

		[Column(Storage = "_reportedFlag", Name = "REPORTED_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReportedFlag
		{
			get
			{
				return this._reportedFlag;
			}
			set
			{
				if (((_reportedFlag == value)
							== false))
				{
					this.OnReportedFlagChanging(value);
					this._reportedFlag = value;
					this.OnReportedFlagChanged();
				}
			}
		}

		[Column(Storage = "_server", Name = "SERVER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Server
		{
			get
			{
				return this._server;
			}
			set
			{
				if (((_server == value)
							== false))
				{
					this.OnServerChanging(value);
					this._server = value;
					this.OnServerChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FRAME")]
	public partial class Frame
	{

		private System.Nullable<long> _actionID;

		private string _attributePrefix;

		private string _backgroundstyle;

		private string _description;

		private System.Nullable<long> _enabledRuleID;

		private System.Nullable<long> _entryActionID;

		private long _frameID;

		private string _helpstring;

		private System.Nullable<long> _maxpageresultrows;

		private string _modalFlag;

		private string _name;

		private string _onerowautoselectFlag;

		private string _sqlfrom;

		private string _sqlorderby;

		private string _sqlselect;

		private string _sqlwhere;

		private string _title;

		private string _type;

		private System.Nullable<long> _validRuleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActionIdChanged();

		partial void OnActionIdChanging(System.Nullable<long> value);

		partial void OnAttributePrefixChanged();

		partial void OnAttributePrefixChanging(string value);

		partial void OnBackgroundstyleChanged();

		partial void OnBackgroundstyleChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<long> value);

		partial void OnEntryActionIdChanged();

		partial void OnEntryActionIdChanging(System.Nullable<long> value);

		partial void OnFrameIdChanged();

		partial void OnFrameIdChanging(long value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnMaxpageresultrowsChanged();

		partial void OnMaxpageresultrowsChanging(System.Nullable<long> value);

		partial void OnModalFlagChanged();

		partial void OnModalFlagChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnOnerowautoselectFlagChanged();

		partial void OnOnerowautoselectFlagChanging(string value);

		partial void OnSqlfromChanged();

		partial void OnSqlfromChanging(string value);

		partial void OnSqlorderbyChanged();

		partial void OnSqlorderbyChanging(string value);

		partial void OnSqlselectChanged();

		partial void OnSqlselectChanging(string value);

		partial void OnSqlwhereChanged();

		partial void OnSqlwhereChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<long> value);
		#endregion


		public Frame()
		{
			this.OnCreated();
		}

		[Column(Storage = "_actionID", Name = "ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ActionId
		{
			get
			{
				return this._actionID;
			}
			set
			{
				if ((_actionID != value))
				{
					this.OnActionIdChanging(value);
					this._actionID = value;
					this.OnActionIdChanged();
				}
			}
		}

		[Column(Storage = "_attributePrefix", Name = "ATTRIBUTE_PREFIX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributePrefix
		{
			get
			{
				return this._attributePrefix;
			}
			set
			{
				if (((_attributePrefix == value)
							== false))
				{
					this.OnAttributePrefixChanging(value);
					this._attributePrefix = value;
					this.OnAttributePrefixChanged();
				}
			}
		}

		[Column(Storage = "_backgroundstyle", Name = "BACKGROUNDSTYLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Backgroundstyle
		{
			get
			{
				return this._backgroundstyle;
			}
			set
			{
				if (((_backgroundstyle == value)
							== false))
				{
					this.OnBackgroundstyleChanging(value);
					this._backgroundstyle = value;
					this.OnBackgroundstyleChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_entryActionID", Name = "ENTRY_ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EntryActionId
		{
			get
			{
				return this._entryActionID;
			}
			set
			{
				if ((_entryActionID != value))
				{
					this.OnEntryActionIdChanging(value);
					this._entryActionID = value;
					this.OnEntryActionIdChanged();
				}
			}
		}

		[Column(Storage = "_frameID", Name = "FRAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FrameId
		{
			get
			{
				return this._frameID;
			}
			set
			{
				if ((_frameID != value))
				{
					this.OnFrameIdChanging(value);
					this._frameID = value;
					this.OnFrameIdChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_maxpageresultrows", Name = "MAXPAGERESULTROWS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Maxpageresultrows
		{
			get
			{
				return this._maxpageresultrows;
			}
			set
			{
				if ((_maxpageresultrows != value))
				{
					this.OnMaxpageresultrowsChanging(value);
					this._maxpageresultrows = value;
					this.OnMaxpageresultrowsChanged();
				}
			}
		}

		[Column(Storage = "_modalFlag", Name = "MODAL_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ModalFlag
		{
			get
			{
				return this._modalFlag;
			}
			set
			{
				if (((_modalFlag == value)
							== false))
				{
					this.OnModalFlagChanging(value);
					this._modalFlag = value;
					this.OnModalFlagChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_onerowautoselectFlag", Name = "ONEROWAUTOSELECT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string OnerowautoselectFlag
		{
			get
			{
				return this._onerowautoselectFlag;
			}
			set
			{
				if (((_onerowautoselectFlag == value)
							== false))
				{
					this.OnOnerowautoselectFlagChanging(value);
					this._onerowautoselectFlag = value;
					this.OnOnerowautoselectFlagChanged();
				}
			}
		}

		[Column(Storage = "_sqlfrom", Name = "SQLFROM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlfrom
		{
			get
			{
				return this._sqlfrom;
			}
			set
			{
				if (((_sqlfrom == value)
							== false))
				{
					this.OnSqlfromChanging(value);
					this._sqlfrom = value;
					this.OnSqlfromChanged();
				}
			}
		}

		[Column(Storage = "_sqlorderby", Name = "SQLORDERBY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlorderby
		{
			get
			{
				return this._sqlorderby;
			}
			set
			{
				if (((_sqlorderby == value)
							== false))
				{
					this.OnSqlorderbyChanging(value);
					this._sqlorderby = value;
					this.OnSqlorderbyChanged();
				}
			}
		}

		[Column(Storage = "_sqlselect", Name = "SQLSELECT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlselect
		{
			get
			{
				return this._sqlselect;
			}
			set
			{
				if (((_sqlselect == value)
							== false))
				{
					this.OnSqlselectChanging(value);
					this._sqlselect = value;
					this.OnSqlselectChanged();
				}
			}
		}

		[Column(Storage = "_sqlwhere", Name = "SQLWHERE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlwhere
		{
			get
			{
				return this._sqlwhere;
			}
			set
			{
				if (((_sqlwhere == value)
							== false))
				{
					this.OnSqlwhereChanging(value);
					this._sqlwhere = value;
					this.OnSqlwhereChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FRAME_ORDER")]
	public partial class FrameOrder
	{

		private System.Nullable<long> _actionID;

		private string _attributePrefix;

		private string _backgroundstyle;

		private long _callflowID;

		private string _description;

		private System.Nullable<long> _enabledRuleID;

		private System.Nullable<long> _entryActionID;

		private long _frameID;

		private string _helpstring;

		private System.Nullable<long> _maxpageresultrows;

		private string _modalFlag;

		private string _onerowautoselectFlag;

		private System.Nullable<long> _sequence;

		private string _sqlfrom;

		private string _sqlorderby;

		private string _sqlselect;

		private string _sqlwhere;

		private string _title;

		private string _type;

		private System.Nullable<long> _validRuleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActionIdChanged();

		partial void OnActionIdChanging(System.Nullable<long> value);

		partial void OnAttributePrefixChanged();

		partial void OnAttributePrefixChanging(string value);

		partial void OnBackgroundstyleChanged();

		partial void OnBackgroundstyleChanging(string value);

		partial void OnCallflowIdChanged();

		partial void OnCallflowIdChanging(long value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledRuleIdChanged();

		partial void OnEnabledRuleIdChanging(System.Nullable<long> value);

		partial void OnEntryActionIdChanged();

		partial void OnEntryActionIdChanging(System.Nullable<long> value);

		partial void OnFrameIdChanged();

		partial void OnFrameIdChanging(long value);

		partial void OnHelpstringChanged();

		partial void OnHelpstringChanging(string value);

		partial void OnMaxpageresultrowsChanged();

		partial void OnMaxpageresultrowsChanging(System.Nullable<long> value);

		partial void OnModalFlagChanged();

		partial void OnModalFlagChanging(string value);

		partial void OnOnerowautoselectFlagChanged();

		partial void OnOnerowautoselectFlagChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<long> value);

		partial void OnSqlfromChanged();

		partial void OnSqlfromChanging(string value);

		partial void OnSqlorderbyChanged();

		partial void OnSqlorderbyChanging(string value);

		partial void OnSqlselectChanged();

		partial void OnSqlselectChanging(string value);

		partial void OnSqlwhereChanged();

		partial void OnSqlwhereChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnValidRuleIdChanged();

		partial void OnValidRuleIdChanging(System.Nullable<long> value);
		#endregion


		public FrameOrder()
		{
			this.OnCreated();
		}

		[Column(Storage = "_actionID", Name = "ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ActionId
		{
			get
			{
				return this._actionID;
			}
			set
			{
				if ((_actionID != value))
				{
					this.OnActionIdChanging(value);
					this._actionID = value;
					this.OnActionIdChanged();
				}
			}
		}

		[Column(Storage = "_attributePrefix", Name = "ATTRIBUTE_PREFIX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributePrefix
		{
			get
			{
				return this._attributePrefix;
			}
			set
			{
				if (((_attributePrefix == value)
							== false))
				{
					this.OnAttributePrefixChanging(value);
					this._attributePrefix = value;
					this.OnAttributePrefixChanged();
				}
			}
		}

		[Column(Storage = "_backgroundstyle", Name = "BACKGROUNDSTYLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Backgroundstyle
		{
			get
			{
				return this._backgroundstyle;
			}
			set
			{
				if (((_backgroundstyle == value)
							== false))
				{
					this.OnBackgroundstyleChanging(value);
					this._backgroundstyle = value;
					this.OnBackgroundstyleChanged();
				}
			}
		}

		[Column(Storage = "_callflowID", Name = "CALLFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallflowId
		{
			get
			{
				return this._callflowID;
			}
			set
			{
				if ((_callflowID != value))
				{
					this.OnCallflowIdChanging(value);
					this._callflowID = value;
					this.OnCallflowIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledRuleID", Name = "ENABLEDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnabledRuleId
		{
			get
			{
				return this._enabledRuleID;
			}
			set
			{
				if ((_enabledRuleID != value))
				{
					this.OnEnabledRuleIdChanging(value);
					this._enabledRuleID = value;
					this.OnEnabledRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_entryActionID", Name = "ENTRY_ACTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EntryActionId
		{
			get
			{
				return this._entryActionID;
			}
			set
			{
				if ((_entryActionID != value))
				{
					this.OnEntryActionIdChanging(value);
					this._entryActionID = value;
					this.OnEntryActionIdChanged();
				}
			}
		}

		[Column(Storage = "_frameID", Name = "FRAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FrameId
		{
			get
			{
				return this._frameID;
			}
			set
			{
				if ((_frameID != value))
				{
					this.OnFrameIdChanging(value);
					this._frameID = value;
					this.OnFrameIdChanged();
				}
			}
		}

		[Column(Storage = "_helpstring", Name = "HELPSTRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Helpstring
		{
			get
			{
				return this._helpstring;
			}
			set
			{
				if (((_helpstring == value)
							== false))
				{
					this.OnHelpstringChanging(value);
					this._helpstring = value;
					this.OnHelpstringChanged();
				}
			}
		}

		[Column(Storage = "_maxpageresultrows", Name = "MAXPAGERESULTROWS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Maxpageresultrows
		{
			get
			{
				return this._maxpageresultrows;
			}
			set
			{
				if ((_maxpageresultrows != value))
				{
					this.OnMaxpageresultrowsChanging(value);
					this._maxpageresultrows = value;
					this.OnMaxpageresultrowsChanged();
				}
			}
		}

		[Column(Storage = "_modalFlag", Name = "MODAL_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ModalFlag
		{
			get
			{
				return this._modalFlag;
			}
			set
			{
				if (((_modalFlag == value)
							== false))
				{
					this.OnModalFlagChanging(value);
					this._modalFlag = value;
					this.OnModalFlagChanged();
				}
			}
		}

		[Column(Storage = "_onerowautoselectFlag", Name = "ONEROWAUTOSELECT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OnerowautoselectFlag
		{
			get
			{
				return this._onerowautoselectFlag;
			}
			set
			{
				if (((_onerowautoselectFlag == value)
							== false))
				{
					this.OnOnerowautoselectFlagChanging(value);
					this._onerowautoselectFlag = value;
					this.OnOnerowautoselectFlagChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_sqlfrom", Name = "SQLFROM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlfrom
		{
			get
			{
				return this._sqlfrom;
			}
			set
			{
				if (((_sqlfrom == value)
							== false))
				{
					this.OnSqlfromChanging(value);
					this._sqlfrom = value;
					this.OnSqlfromChanged();
				}
			}
		}

		[Column(Storage = "_sqlorderby", Name = "SQLORDERBY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlorderby
		{
			get
			{
				return this._sqlorderby;
			}
			set
			{
				if (((_sqlorderby == value)
							== false))
				{
					this.OnSqlorderbyChanging(value);
					this._sqlorderby = value;
					this.OnSqlorderbyChanged();
				}
			}
		}

		[Column(Storage = "_sqlselect", Name = "SQLSELECT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlselect
		{
			get
			{
				return this._sqlselect;
			}
			set
			{
				if (((_sqlselect == value)
							== false))
				{
					this.OnSqlselectChanging(value);
					this._sqlselect = value;
					this.OnSqlselectChanged();
				}
			}
		}

		[Column(Storage = "_sqlwhere", Name = "SQLWHERE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sqlwhere
		{
			get
			{
				return this._sqlwhere;
			}
			set
			{
				if (((_sqlwhere == value)
							== false))
				{
					this.OnSqlwhereChanging(value);
					this._sqlwhere = value;
					this.OnSqlwhereChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_validRuleID", Name = "VALIDRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ValidRuleId
		{
			get
			{
				return this._validRuleID;
			}
			set
			{
				if ((_validRuleID != value))
				{
					this.OnValidRuleIdChanging(value);
					this._validRuleID = value;
					this.OnValidRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FRAUD_DETECTION_RULE")]
	public partial class FraudDetectionRule
	{

		private long _fraudDetectionRuleID;

		private long _fraudDetectionTypeID;

		private string _name;

		private long _ruleID;

		private System.Nullable<long> _score;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnFraudDetectionRuleIdChanged();

		partial void OnFraudDetectionRuleIdChanging(long value);

		partial void OnFraudDetectionTypeIdChanged();

		partial void OnFraudDetectionTypeIdChanging(long value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(long value);

		partial void OnScoreChanged();

		partial void OnScoreChanging(System.Nullable<long> value);
		#endregion


		public FraudDetectionRule()
		{
			this.OnCreated();
		}

		[Column(Storage = "_fraudDetectionRuleID", Name = "FRAUD_DETECTION_RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FraudDetectionRuleId
		{
			get
			{
				return this._fraudDetectionRuleID;
			}
			set
			{
				if ((_fraudDetectionRuleID != value))
				{
					this.OnFraudDetectionRuleIdChanging(value);
					this._fraudDetectionRuleID = value;
					this.OnFraudDetectionRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_fraudDetectionTypeID", Name = "FRAUD_DETECTION_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FraudDetectionTypeId
		{
			get
			{
				return this._fraudDetectionTypeID;
			}
			set
			{
				if ((_fraudDetectionTypeID != value))
				{
					this.OnFraudDetectionTypeIdChanging(value);
					this._fraudDetectionTypeID = value;
					this.OnFraudDetectionTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_score", Name = "SCORE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Score
		{
			get
			{
				return this._score;
			}
			set
			{
				if ((_score != value))
				{
					this.OnScoreChanging(value);
					this._score = value;
					this.OnScoreChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FRAUD_DETECTION_TYPE")]
	public partial class FraudDetectionType
	{

		private long _accntHrcyStepID;

		private string _description;

		private long _fraudDetectionTypeID;

		private string _lobCode;

		private System.Nullable<long> _threshold;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFraudDetectionTypeIdChanged();

		partial void OnFraudDetectionTypeIdChanging(long value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnThresholdChanged();

		partial void OnThresholdChanging(System.Nullable<long> value);
		#endregion


		public FraudDetectionType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_fraudDetectionTypeID", Name = "FRAUD_DETECTION_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FraudDetectionTypeId
		{
			get
			{
				return this._fraudDetectionTypeID;
			}
			set
			{
				if ((_fraudDetectionTypeID != value))
				{
					this.OnFraudDetectionTypeIdChanging(value);
					this._fraudDetectionTypeID = value;
					this.OnFraudDetectionTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_threshold", Name = "THRESHOLD", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Threshold
		{
			get
			{
				return this._threshold;
			}
			set
			{
				if ((_threshold != value))
				{
					this.OnThresholdChanging(value);
					this._threshold = value;
					this.OnThresholdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_FILE_DEF")]
	public partial class FroiFileDef
	{

		private long _accntHrcyStepID;

		private System.Nullable<System.DateTime> _createdDate;

		private string _description;

		private string _fileClientCode;

		private string _froiClientCode;

		private long _froiFileDefID;

		private string _froiLobCode;

		private string _hasHeaderFlag;

		private string _hasTrailerFlag;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFileClientCodeChanged();

		partial void OnFileClientCodeChanging(string value);

		partial void OnFroiClientCodeChanged();

		partial void OnFroiClientCodeChanging(string value);

		partial void OnFroiFileDefIdChanged();

		partial void OnFroiFileDefIdChanging(long value);

		partial void OnFroiLobCodeChanged();

		partial void OnFroiLobCodeChanging(string value);

		partial void OnHasHeaderFlagChanged();

		partial void OnHasHeaderFlagChanging(string value);

		partial void OnHasTrailerFlagChanged();

		partial void OnHasTrailerFlagChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);
		#endregion


		public FroiFileDef()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_fileClientCode", Name = "FILE_CLIENT_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FileClientCode
		{
			get
			{
				return this._fileClientCode;
			}
			set
			{
				if (((_fileClientCode == value)
							== false))
				{
					this.OnFileClientCodeChanging(value);
					this._fileClientCode = value;
					this.OnFileClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_froiClientCode", Name = "FROI_CLIENT_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FroiClientCode
		{
			get
			{
				return this._froiClientCode;
			}
			set
			{
				if (((_froiClientCode == value)
							== false))
				{
					this.OnFroiClientCodeChanging(value);
					this._froiClientCode = value;
					this.OnFroiClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_froiFileDefID", Name = "FROI_FILE_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FroiFileDefId
		{
			get
			{
				return this._froiFileDefID;
			}
			set
			{
				if ((_froiFileDefID != value))
				{
					this.OnFroiFileDefIdChanging(value);
					this._froiFileDefID = value;
					this.OnFroiFileDefIdChanged();
				}
			}
		}

		[Column(Storage = "_froiLobCode", Name = "FROI_LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FroiLobCode
		{
			get
			{
				return this._froiLobCode;
			}
			set
			{
				if (((_froiLobCode == value)
							== false))
				{
					this.OnFroiLobCodeChanging(value);
					this._froiLobCode = value;
					this.OnFroiLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_hasHeaderFlag", Name = "HAS_HEADER_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string HasHeaderFlag
		{
			get
			{
				return this._hasHeaderFlag;
			}
			set
			{
				if (((_hasHeaderFlag == value)
							== false))
				{
					this.OnHasHeaderFlagChanging(value);
					this._hasHeaderFlag = value;
					this.OnHasHeaderFlagChanged();
				}
			}
		}

		[Column(Storage = "_hasTrailerFlag", Name = "HAS_TRAILER_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string HasTrailerFlag
		{
			get
			{
				return this._hasTrailerFlag;
			}
			set
			{
				if (((_hasTrailerFlag == value)
							== false))
				{
					this.OnHasTrailerFlagChanging(value);
					this._hasTrailerFlag = value;
					this.OnHasTrailerFlagChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_FILE_INBOUND")]
	public partial class FroiFileInbound
	{

		private System.Nullable<System.DateTime> _createdDate;

		private string _filename;

		private System.Nullable<long> _froiFileDefID;

		private System.Nullable<long> _froiFileInboundID;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		private string _serverName;

		private string _status;

		private string _statusText;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnFilenameChanged();

		partial void OnFilenameChanging(string value);

		partial void OnFroiFileDefIdChanged();

		partial void OnFroiFileDefIdChanging(System.Nullable<long> value);

		partial void OnFroiFileInboundIdChanged();

		partial void OnFroiFileInboundIdChanging(System.Nullable<long> value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnServerNameChanged();

		partial void OnServerNameChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnStatusTextChanged();

		partial void OnStatusTextChanging(string value);
		#endregion


		public FroiFileInbound()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_filename", Name = "FILENAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Filename
		{
			get
			{
				return this._filename;
			}
			set
			{
				if (((_filename == value)
							== false))
				{
					this.OnFilenameChanging(value);
					this._filename = value;
					this.OnFilenameChanged();
				}
			}
		}

		[Column(Storage = "_froiFileDefID", Name = "FROI_FILE_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiFileDefId
		{
			get
			{
				return this._froiFileDefID;
			}
			set
			{
				if ((_froiFileDefID != value))
				{
					this.OnFroiFileDefIdChanging(value);
					this._froiFileDefID = value;
					this.OnFroiFileDefIdChanged();
				}
			}
		}

		[Column(Storage = "_froiFileInboundID", Name = "FROI_FILE_INBOUND_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiFileInboundId
		{
			get
			{
				return this._froiFileInboundID;
			}
			set
			{
				if ((_froiFileInboundID != value))
				{
					this.OnFroiFileInboundIdChanging(value);
					this._froiFileInboundID = value;
					this.OnFroiFileInboundIdChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_serverName", Name = "SERVER_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ServerName
		{
			get
			{
				return this._serverName;
			}
			set
			{
				if (((_serverName == value)
							== false))
				{
					this.OnServerNameChanging(value);
					this._serverName = value;
					this.OnServerNameChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_statusText", Name = "STATUS_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string StatusText
		{
			get
			{
				return this._statusText;
			}
			set
			{
				if (((_statusText == value)
							== false))
				{
					this.OnStatusTextChanging(value);
					this._statusText = value;
					this.OnStatusTextChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_FILE_INBOUND_STEP")]
	public partial class FroiFileInboundStep
	{

		private System.Nullable<long> _callID;

		private System.Nullable<System.DateTime> _createdDate;

		private string _errorText;

		private System.Nullable<long> _froiFileInboundID;

		private System.Nullable<long> _froiFileInboundStepID;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		private string _status;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(System.Nullable<long> value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnErrorTextChanged();

		partial void OnErrorTextChanging(string value);

		partial void OnFroiFileInboundIdChanged();

		partial void OnFroiFileInboundIdChanging(System.Nullable<long> value);

		partial void OnFroiFileInboundStepIdChanged();

		partial void OnFroiFileInboundStepIdChanging(System.Nullable<long> value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);
		#endregion


		public FroiFileInboundStep()
		{
			this.OnCreated();
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_errorText", Name = "ERROR_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ErrorText
		{
			get
			{
				return this._errorText;
			}
			set
			{
				if (((_errorText == value)
							== false))
				{
					this.OnErrorTextChanging(value);
					this._errorText = value;
					this.OnErrorTextChanged();
				}
			}
		}

		[Column(Storage = "_froiFileInboundID", Name = "FROI_FILE_INBOUND_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiFileInboundId
		{
			get
			{
				return this._froiFileInboundID;
			}
			set
			{
				if ((_froiFileInboundID != value))
				{
					this.OnFroiFileInboundIdChanging(value);
					this._froiFileInboundID = value;
					this.OnFroiFileInboundIdChanged();
				}
			}
		}

		[Column(Storage = "_froiFileInboundStepID", Name = "FROI_FILE_INBOUND_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiFileInboundStepId
		{
			get
			{
				return this._froiFileInboundStepID;
			}
			set
			{
				if ((_froiFileInboundStepID != value))
				{
					this.OnFroiFileInboundStepIdChanging(value);
					this._froiFileInboundStepID = value;
					this.OnFroiFileInboundStepIdChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_IMP_CONVERSION")]
	public partial class FroiImpConversion
	{

		private string _convToValue;

		private System.Nullable<System.DateTime> _createdDate;

		private System.Nullable<long> _froiImpConversionID;

		private System.Nullable<long> _froiImpConvTypeID;

		private string _impValue;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnConvToValueChanged();

		partial void OnConvToValueChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnFroiImpConversionIdChanged();

		partial void OnFroiImpConversionIdChanging(System.Nullable<long> value);

		partial void OnFroiImpConvTypeIdChanged();

		partial void OnFroiImpConvTypeIdChanging(System.Nullable<long> value);

		partial void OnImpValueChanged();

		partial void OnImpValueChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);
		#endregion


		public FroiImpConversion()
		{
			this.OnCreated();
		}

		[Column(Storage = "_convToValue", Name = "CONV_TO_VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ConvToValue
		{
			get
			{
				return this._convToValue;
			}
			set
			{
				if (((_convToValue == value)
							== false))
				{
					this.OnConvToValueChanging(value);
					this._convToValue = value;
					this.OnConvToValueChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_froiImpConversionID", Name = "FROI_IMP_CONVERSION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpConversionId
		{
			get
			{
				return this._froiImpConversionID;
			}
			set
			{
				if ((_froiImpConversionID != value))
				{
					this.OnFroiImpConversionIdChanging(value);
					this._froiImpConversionID = value;
					this.OnFroiImpConversionIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpConvTypeID", Name = "FROI_IMP_CONV_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpConvTypeId
		{
			get
			{
				return this._froiImpConvTypeID;
			}
			set
			{
				if ((_froiImpConvTypeID != value))
				{
					this.OnFroiImpConvTypeIdChanging(value);
					this._froiImpConvTypeID = value;
					this.OnFroiImpConvTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_impValue", Name = "IMP_VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ImpValue
		{
			get
			{
				return this._impValue;
			}
			set
			{
				if (((_impValue == value)
							== false))
				{
					this.OnImpValueChanging(value);
					this._impValue = value;
					this.OnImpValueChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_IMP_CONV_TYPE")]
	public partial class FroiImpConvType
	{

		private System.Nullable<System.DateTime> _createdDate;

		private string _description;

		private System.Nullable<long> _froiImpConvTypeID;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFroiImpConvTypeIdChanged();

		partial void OnFroiImpConvTypeIdChanging(System.Nullable<long> value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);
		#endregion


		public FroiImpConvType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_froiImpConvTypeID", Name = "FROI_IMP_CONV_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpConvTypeId
		{
			get
			{
				return this._froiImpConvTypeID;
			}
			set
			{
				if ((_froiImpConvTypeID != value))
				{
					this.OnFroiImpConvTypeIdChanging(value);
					this._froiImpConvTypeID = value;
					this.OnFroiImpConvTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_IMP_FUNCTION")]
	public partial class FroiImpFunction
	{

		private System.Nullable<System.DateTime> _createdDate;

		private string _description;

		private System.Nullable<long> _froiImpFunctionID;

		private string _functionName;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFroiImpFunctionIdChanged();

		partial void OnFroiImpFunctionIdChanging(System.Nullable<long> value);

		partial void OnFunctionNameChanged();

		partial void OnFunctionNameChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);
		#endregion


		public FroiImpFunction()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_froiImpFunctionID", Name = "FROI_IMP_FUNCTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpFunctionId
		{
			get
			{
				return this._froiImpFunctionID;
			}
			set
			{
				if ((_froiImpFunctionID != value))
				{
					this.OnFroiImpFunctionIdChanging(value);
					this._froiImpFunctionID = value;
					this.OnFroiImpFunctionIdChanged();
				}
			}
		}

		[Column(Storage = "_functionName", Name = "FUNCTION_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FunctionName
		{
			get
			{
				return this._functionName;
			}
			set
			{
				if (((_functionName == value)
							== false))
				{
					this.OnFunctionNameChanging(value);
					this._functionName = value;
					this.OnFunctionNameChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_IMP_MAP")]
	public partial class FroiImpMap
	{

		private string _attributeName;

		private System.DateTime _createdDate;

		private string _dataDefinition;

		private string _defaultValue;

		private System.Nullable<long> _froiFileDefID;

		private long _froiImpMapID;

		private long _froiImpRecordID;

		private string _froiImpRecordType;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		private string _legacyFieldName;

		private long _length;

		private long _startpos;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAttributeNameChanged();

		partial void OnAttributeNameChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnDataDefinitionChanged();

		partial void OnDataDefinitionChanging(string value);

		partial void OnDefaultValueChanged();

		partial void OnDefaultValueChanging(string value);

		partial void OnFroiFileDefIdChanged();

		partial void OnFroiFileDefIdChanging(System.Nullable<long> value);

		partial void OnFroiImpMapIdChanged();

		partial void OnFroiImpMapIdChanging(long value);

		partial void OnFroiImpRecordIdChanged();

		partial void OnFroiImpRecordIdChanging(long value);

		partial void OnFroiImpRecordTypeChanged();

		partial void OnFroiImpRecordTypeChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnLegacyFieldNameChanged();

		partial void OnLegacyFieldNameChanging(string value);

		partial void OnLengthChanged();

		partial void OnLengthChanging(long value);

		partial void OnStartposChanged();

		partial void OnStartposChanging(long value);
		#endregion


		public FroiImpMap()
		{
			this.OnCreated();
		}

		[Column(Storage = "_attributeName", Name = "ATTRIBUTE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value)
							== false))
				{
					this.OnAttributeNameChanging(value);
					this._attributeName = value;
					this.OnAttributeNameChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_dataDefinition", Name = "DATA_DEFINITION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DataDefinition
		{
			get
			{
				return this._dataDefinition;
			}
			set
			{
				if (((_dataDefinition == value)
							== false))
				{
					this.OnDataDefinitionChanging(value);
					this._dataDefinition = value;
					this.OnDataDefinitionChanged();
				}
			}
		}

		[Column(Storage = "_defaultValue", Name = "DEFAULT_VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				if (((_defaultValue == value)
							== false))
				{
					this.OnDefaultValueChanging(value);
					this._defaultValue = value;
					this.OnDefaultValueChanged();
				}
			}
		}

		[Column(Storage = "_froiFileDefID", Name = "FROI_FILE_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiFileDefId
		{
			get
			{
				return this._froiFileDefID;
			}
			set
			{
				if ((_froiFileDefID != value))
				{
					this.OnFroiFileDefIdChanging(value);
					this._froiFileDefID = value;
					this.OnFroiFileDefIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpMapID", Name = "FROI_IMP_MAP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FroiImpMapId
		{
			get
			{
				return this._froiImpMapID;
			}
			set
			{
				if ((_froiImpMapID != value))
				{
					this.OnFroiImpMapIdChanging(value);
					this._froiImpMapID = value;
					this.OnFroiImpMapIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpRecordID", Name = "FROI_IMP_RECORD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FroiImpRecordId
		{
			get
			{
				return this._froiImpRecordID;
			}
			set
			{
				if ((_froiImpRecordID != value))
				{
					this.OnFroiImpRecordIdChanging(value);
					this._froiImpRecordID = value;
					this.OnFroiImpRecordIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpRecordType", Name = "FROI_IMP_RECORD_TYPE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FroiImpRecordType
		{
			get
			{
				return this._froiImpRecordType;
			}
			set
			{
				if (((_froiImpRecordType == value)
							== false))
				{
					this.OnFroiImpRecordTypeChanging(value);
					this._froiImpRecordType = value;
					this.OnFroiImpRecordTypeChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_legacyFieldName", Name = "LEGACY_FIELD_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LegacyFieldName
		{
			get
			{
				return this._legacyFieldName;
			}
			set
			{
				if (((_legacyFieldName == value)
							== false))
				{
					this.OnLegacyFieldNameChanging(value);
					this._legacyFieldName = value;
					this.OnLegacyFieldNameChanged();
				}
			}
		}

		[Column(Storage = "_length", Name = "LENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Length
		{
			get
			{
				return this._length;
			}
			set
			{
				if ((_length != value))
				{
					this.OnLengthChanging(value);
					this._length = value;
					this.OnLengthChanged();
				}
			}
		}

		[Column(Storage = "_startpos", Name = "STARTPOS", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Startpos
		{
			get
			{
				return this._startpos;
			}
			set
			{
				if ((_startpos != value))
				{
					this.OnStartposChanging(value);
					this._startpos = value;
					this.OnStartposChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_IMP_MAP_CONVERSION")]
	public partial class FroiImpMapConversion
	{

		private System.Nullable<System.DateTime> _createdDate;

		private string _description;

		private System.Nullable<long> _froiImpConvTypeID;

		private System.Nullable<long> _froiImpMapConversionID;

		private System.Nullable<long> _froiImpMapID;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFroiImpConvTypeIdChanged();

		partial void OnFroiImpConvTypeIdChanging(System.Nullable<long> value);

		partial void OnFroiImpMapConversionIdChanged();

		partial void OnFroiImpMapConversionIdChanging(System.Nullable<long> value);

		partial void OnFroiImpMapIdChanged();

		partial void OnFroiImpMapIdChanging(System.Nullable<long> value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);
		#endregion


		public FroiImpMapConversion()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_froiImpConvTypeID", Name = "FROI_IMP_CONV_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpConvTypeId
		{
			get
			{
				return this._froiImpConvTypeID;
			}
			set
			{
				if ((_froiImpConvTypeID != value))
				{
					this.OnFroiImpConvTypeIdChanging(value);
					this._froiImpConvTypeID = value;
					this.OnFroiImpConvTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpMapConversionID", Name = "FROI_IMP_MAP_CONVERSION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpMapConversionId
		{
			get
			{
				return this._froiImpMapConversionID;
			}
			set
			{
				if ((_froiImpMapConversionID != value))
				{
					this.OnFroiImpMapConversionIdChanging(value);
					this._froiImpMapConversionID = value;
					this.OnFroiImpMapConversionIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpMapID", Name = "FROI_IMP_MAP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpMapId
		{
			get
			{
				return this._froiImpMapID;
			}
			set
			{
				if ((_froiImpMapID != value))
				{
					this.OnFroiImpMapIdChanging(value);
					this._froiImpMapID = value;
					this.OnFroiImpMapIdChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_IMP_MAP_FUNCTION")]
	public partial class FroiImpMapFunction
	{

		private System.Nullable<System.DateTime> _createdDate;

		private System.Nullable<long> _froiImpFunctionID;

		private System.Nullable<long> _froiImpMapFunctionID;

		private System.Nullable<long> _froiImpMapID;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnFroiImpFunctionIdChanged();

		partial void OnFroiImpFunctionIdChanging(System.Nullable<long> value);

		partial void OnFroiImpMapFunctionIdChanged();

		partial void OnFroiImpMapFunctionIdChanging(System.Nullable<long> value);

		partial void OnFroiImpMapIdChanged();

		partial void OnFroiImpMapIdChanging(System.Nullable<long> value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);
		#endregion


		public FroiImpMapFunction()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_froiImpFunctionID", Name = "FROI_IMP_FUNCTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpFunctionId
		{
			get
			{
				return this._froiImpFunctionID;
			}
			set
			{
				if ((_froiImpFunctionID != value))
				{
					this.OnFroiImpFunctionIdChanging(value);
					this._froiImpFunctionID = value;
					this.OnFroiImpFunctionIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpMapFunctionID", Name = "FROI_IMP_MAP_FUNCTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpMapFunctionId
		{
			get
			{
				return this._froiImpMapFunctionID;
			}
			set
			{
				if ((_froiImpMapFunctionID != value))
				{
					this.OnFroiImpMapFunctionIdChanging(value);
					this._froiImpMapFunctionID = value;
					this.OnFroiImpMapFunctionIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpMapID", Name = "FROI_IMP_MAP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiImpMapId
		{
			get
			{
				return this._froiImpMapID;
			}
			set
			{
				if ((_froiImpMapID != value))
				{
					this.OnFroiImpMapIdChanging(value);
					this._froiImpMapID = value;
					this.OnFroiImpMapIdChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FROI_IMP_RECORD")]
	public partial class FroiImpRecord
	{

		private System.Nullable<System.DateTime> _createdDate;

		private System.Nullable<long> _froiFileDefID;

		private string _froiImpRecordDecription;

		private long _froiImpRecordID;

		private string _froiImpRecordType;

		private string _froiLobCode;

		private System.Nullable<System.DateTime> _lastModifiedDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnFroiFileDefIdChanged();

		partial void OnFroiFileDefIdChanging(System.Nullable<long> value);

		partial void OnFroiImpRecordDecriptionChanged();

		partial void OnFroiImpRecordDecriptionChanging(string value);

		partial void OnFroiImpRecordIdChanged();

		partial void OnFroiImpRecordIdChanging(long value);

		partial void OnFroiImpRecordTypeChanged();

		partial void OnFroiImpRecordTypeChanging(string value);

		partial void OnFroiLobCodeChanged();

		partial void OnFroiLobCodeChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.Nullable<System.DateTime> value);
		#endregion


		public FroiImpRecord()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_froiFileDefID", Name = "FROI_FILE_DEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FroiFileDefId
		{
			get
			{
				return this._froiFileDefID;
			}
			set
			{
				if ((_froiFileDefID != value))
				{
					this.OnFroiFileDefIdChanging(value);
					this._froiFileDefID = value;
					this.OnFroiFileDefIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpRecordDecription", Name = "FROI_IMP_RECORD_DESC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FroiImpRecordDecription
		{
			get
			{
				return this._froiImpRecordDecription;
			}
			set
			{
				if (((_froiImpRecordDecription == value)
							== false))
				{
					this.OnFroiImpRecordDecriptionChanging(value);
					this._froiImpRecordDecription = value;
					this.OnFroiImpRecordDecriptionChanged();
				}
			}
		}

		[Column(Storage = "_froiImpRecordID", Name = "FROI_IMP_RECORD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FroiImpRecordId
		{
			get
			{
				return this._froiImpRecordID;
			}
			set
			{
				if ((_froiImpRecordID != value))
				{
					this.OnFroiImpRecordIdChanging(value);
					this._froiImpRecordID = value;
					this.OnFroiImpRecordIdChanged();
				}
			}
		}

		[Column(Storage = "_froiImpRecordType", Name = "FROI_IMP_RECORD_TYPE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FroiImpRecordType
		{
			get
			{
				return this._froiImpRecordType;
			}
			set
			{
				if (((_froiImpRecordType == value)
							== false))
				{
					this.OnFroiImpRecordTypeChanging(value);
					this._froiImpRecordType = value;
					this.OnFroiImpRecordTypeChanged();
				}
			}
		}

		[Column(Storage = "_froiLobCode", Name = "FROI_LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FroiLobCode
		{
			get
			{
				return this._froiLobCode;
			}
			set
			{
				if (((_froiLobCode == value)
							== false))
				{
					this.OnFroiLobCodeChanging(value);
					this._froiLobCode = value;
					this.OnFroiLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.FUNCTION")]
	public partial class Function
	{

		private long _functionID;

		private string _functionNm;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnFunctionIdChanged();

		partial void OnFunctionIdChanging(long value);

		partial void OnFunctionNmChanged();

		partial void OnFunctionNmChanging(string value);
		#endregion


		public Function()
		{
			this.OnCreated();
		}

		[Column(Storage = "_functionID", Name = "FUNCTION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FunctionId
		{
			get
			{
				return this._functionID;
			}
			set
			{
				if ((_functionID != value))
				{
					this.OnFunctionIdChanging(value);
					this._functionID = value;
					this.OnFunctionIdChanged();
				}
			}
		}

		[Column(Storage = "_functionNm", Name = "FUNCTION_NM", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FunctionNm
		{
			get
			{
				return this._functionNm;
			}
			set
			{
				if (((_functionNm == value)
							== false))
				{
					this.OnFunctionNmChanging(value);
					this._functionNm = value;
					this.OnFunctionNmChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.GROUPS")]
	public partial class Groups
	{

		private long _groupID;

		private string _groupNm;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnGroupIdChanged();

		partial void OnGroupIdChanging(long value);

		partial void OnGroupNmChanged();

		partial void OnGroupNmChanging(string value);
		#endregion


		public Groups()
		{
			this.OnCreated();
		}

		[Column(Storage = "_groupID", Name = "GROUP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long GroupId
		{
			get
			{
				return this._groupID;
			}
			set
			{
				if ((_groupID != value))
				{
					this.OnGroupIdChanging(value);
					this._groupID = value;
					this.OnGroupIdChanged();
				}
			}
		}

		[Column(Storage = "_groupNm", Name = "GROUP_NM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string GroupNm
		{
			get
			{
				return this._groupNm;
			}
			set
			{
				if (((_groupNm == value)
							== false))
				{
					this.OnGroupNmChanging(value);
					this._groupNm = value;
					this.OnGroupNmChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.HELP_TYPE")]
	public partial class HelpType
	{

		private long _helpTypeID;

		private string _name;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnHelpTypeIdChanged();

		partial void OnHelpTypeIdChanging(long value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);
		#endregion


		public HelpType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_helpTypeID", Name = "HELP_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long HelpTypeId
		{
			get
			{
				return this._helpTypeID;
			}
			set
			{
				if ((_helpTypeID != value))
				{
					this.OnHelpTypeIdChanging(value);
					this._helpTypeID = value;
					this.OnHelpTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.INBOUNDCALL")]
	public partial class Inboundcall
	{

		private long _accntHrcyStepID;

		private string _accountTypeCode;

		private string _description;

		private string _greeting;

		private long _inboundcallID;

		private string _insuredFlag;

		private string _name;

		private string _phonenumber;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAccountTypeCodeChanged();

		partial void OnAccountTypeCodeChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnGreetingChanged();

		partial void OnGreetingChanging(string value);

		partial void OnInboundcallIdChanged();

		partial void OnInboundcallIdChanging(long value);

		partial void OnInsuredFlagChanged();

		partial void OnInsuredFlagChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPhonenumberChanged();

		partial void OnPhonenumberChanging(string value);
		#endregion


		public Inboundcall()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_accountTypeCode", Name = "ACCOUNT_TYPE_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AccountTypeCode
		{
			get
			{
				return this._accountTypeCode;
			}
			set
			{
				if (((_accountTypeCode == value)
							== false))
				{
					this.OnAccountTypeCodeChanging(value);
					this._accountTypeCode = value;
					this.OnAccountTypeCodeChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_greeting", Name = "GREETING", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Greeting
		{
			get
			{
				return this._greeting;
			}
			set
			{
				if (((_greeting == value)
							== false))
				{
					this.OnGreetingChanging(value);
					this._greeting = value;
					this.OnGreetingChanged();
				}
			}
		}

		[Column(Storage = "_inboundcallID", Name = "INBOUNDCALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long InboundcallId
		{
			get
			{
				return this._inboundcallID;
			}
			set
			{
				if ((_inboundcallID != value))
				{
					this.OnInboundcallIdChanging(value);
					this._inboundcallID = value;
					this.OnInboundcallIdChanged();
				}
			}
		}

		[Column(Storage = "_insuredFlag", Name = "INSURED_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string InsuredFlag
		{
			get
			{
				return this._insuredFlag;
			}
			set
			{
				if (((_insuredFlag == value)
							== false))
				{
					this.OnInsuredFlagChanging(value);
					this._insuredFlag = value;
					this.OnInsuredFlagChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_phonenumber", Name = "PHONENUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Phonenumber
		{
			get
			{
				return this._phonenumber;
			}
			set
			{
				if (((_phonenumber == value)
							== false))
				{
					this.OnPhonenumberChanging(value);
					this._phonenumber = value;
					this.OnPhonenumberChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.INBOUND_XMISSION_RECORD")]
	public partial class InboundXmissionRecord
	{

		private long _acctHierStepID;

		private string _address1;

		private string _address2;

		private string _address3;

		private string _city;

		private long _clientNum;

		private long _combLevelNum;

		private long _combLevelSeqNum;

		private string _contactName;

		private string _contactTitle;

		private System.DateTime _createdDate;

		private string _deactivateDate;

		private string _externalKey;

		private string _fax;

		private long _fileTransmissionLogID;

		private string _identifier;

		private long _inboundXmissionRecordID;

		private long _levelNum;

		private long _levelSeq;

		private string _orgName1;

		private string _orgName2;

		private long _parentLevNum;

		private long _parentLevSeq;

		private string _phone;

		private string _state;

		private string _statusCode;

		private System.Nullable<System.DateTime> _statusDate;

		private string _taxID;

		private string _unitSicCode;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAcctHierStepIdChanged();

		partial void OnAcctHierStepIdChanging(long value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnAddress3Changed();

		partial void OnAddress3Changing(string value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnClientNumChanged();

		partial void OnClientNumChanging(long value);

		partial void OnCombLevelNumChanged();

		partial void OnCombLevelNumChanging(long value);

		partial void OnCombLevelSeqNumChanged();

		partial void OnCombLevelSeqNumChanging(long value);

		partial void OnContactNameChanged();

		partial void OnContactNameChanging(string value);

		partial void OnContactTitleChanged();

		partial void OnContactTitleChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnDeactivateDateChanged();

		partial void OnDeactivateDateChanging(string value);

		partial void OnExternalKeyChanged();

		partial void OnExternalKeyChanging(string value);

		partial void OnFaxChanged();

		partial void OnFaxChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(long value);

		partial void OnIdentifierChanged();

		partial void OnIdentifierChanging(string value);

		partial void OnInboundXmissionRecordIdChanged();

		partial void OnInboundXmissionRecordIdChanging(long value);

		partial void OnLevelNumChanged();

		partial void OnLevelNumChanging(long value);

		partial void OnLevelSeqChanged();

		partial void OnLevelSeqChanging(long value);

		partial void OnOrgName1Changed();

		partial void OnOrgName1Changing(string value);

		partial void OnOrgName2Changed();

		partial void OnOrgName2Changing(string value);

		partial void OnParentLevNumChanged();

		partial void OnParentLevNumChanging(long value);

		partial void OnParentLevSeqChanged();

		partial void OnParentLevSeqChanging(long value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnStatusCodeChanged();

		partial void OnStatusCodeChanging(string value);

		partial void OnStatusDateChanged();

		partial void OnStatusDateChanging(System.Nullable<System.DateTime> value);

		partial void OnTaxIdChanged();

		partial void OnTaxIdChanging(string value);

		partial void OnUnitSicCodeChanged();

		partial void OnUnitSicCodeChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public InboundXmissionRecord()
		{
			this.OnCreated();
		}

		[Column(Storage = "_acctHierStepID", Name = "ACCT_HIER_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AcctHierStepId
		{
			get
			{
				return this._acctHierStepID;
			}
			set
			{
				if ((_acctHierStepID != value))
				{
					this.OnAcctHierStepIdChanging(value);
					this._acctHierStepID = value;
					this.OnAcctHierStepIdChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS_1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS_2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_address3", Name = "ADDRESS_3", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address3
		{
			get
			{
				return this._address3;
			}
			set
			{
				if (((_address3 == value)
							== false))
				{
					this.OnAddress3Changing(value);
					this._address3 = value;
					this.OnAddress3Changed();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_clientNum", Name = "CLIENT_NUM", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ClientNum
		{
			get
			{
				return this._clientNum;
			}
			set
			{
				if ((_clientNum != value))
				{
					this.OnClientNumChanging(value);
					this._clientNum = value;
					this.OnClientNumChanged();
				}
			}
		}

		[Column(Storage = "_combLevelNum", Name = "COMB_LEVEL_NUM", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CombLevelNum
		{
			get
			{
				return this._combLevelNum;
			}
			set
			{
				if ((_combLevelNum != value))
				{
					this.OnCombLevelNumChanging(value);
					this._combLevelNum = value;
					this.OnCombLevelNumChanged();
				}
			}
		}

		[Column(Storage = "_combLevelSeqNum", Name = "COMB_LEVEL_SEQ_NUM", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CombLevelSeqNum
		{
			get
			{
				return this._combLevelSeqNum;
			}
			set
			{
				if ((_combLevelSeqNum != value))
				{
					this.OnCombLevelSeqNumChanging(value);
					this._combLevelSeqNum = value;
					this.OnCombLevelSeqNumChanged();
				}
			}
		}

		[Column(Storage = "_contactName", Name = "CONTACT_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactName
		{
			get
			{
				return this._contactName;
			}
			set
			{
				if (((_contactName == value)
							== false))
				{
					this.OnContactNameChanging(value);
					this._contactName = value;
					this.OnContactNameChanged();
				}
			}
		}

		[Column(Storage = "_contactTitle", Name = "CONTACT_TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ContactTitle
		{
			get
			{
				return this._contactTitle;
			}
			set
			{
				if (((_contactTitle == value)
							== false))
				{
					this.OnContactTitleChanging(value);
					this._contactTitle = value;
					this.OnContactTitleChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_deactivateDate", Name = "DEACTIVATE_DATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DeactivateDate
		{
			get
			{
				return this._deactivateDate;
			}
			set
			{
				if (((_deactivateDate == value)
							== false))
				{
					this.OnDeactivateDateChanging(value);
					this._deactivateDate = value;
					this.OnDeactivateDateChanged();
				}
			}
		}

		[Column(Storage = "_externalKey", Name = "EXTERNAL_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ExternalKey
		{
			get
			{
				return this._externalKey;
			}
			set
			{
				if (((_externalKey == value)
							== false))
				{
					this.OnExternalKeyChanging(value);
					this._externalKey = value;
					this.OnExternalKeyChanged();
				}
			}
		}

		[Column(Storage = "_fax", Name = "FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fax
		{
			get
			{
				return this._fax;
			}
			set
			{
				if (((_fax == value)
							== false))
				{
					this.OnFaxChanging(value);
					this._fax = value;
					this.OnFaxChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_identifier", Name = "IDENTIFIER", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Identifier
		{
			get
			{
				return this._identifier;
			}
			set
			{
				if (((_identifier == value)
							== false))
				{
					this.OnIdentifierChanging(value);
					this._identifier = value;
					this.OnIdentifierChanged();
				}
			}
		}

		[Column(Storage = "_inboundXmissionRecordID", Name = "INBOUND_XMISSION_RECORD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long InboundXmissionRecordId
		{
			get
			{
				return this._inboundXmissionRecordID;
			}
			set
			{
				if ((_inboundXmissionRecordID != value))
				{
					this.OnInboundXmissionRecordIdChanging(value);
					this._inboundXmissionRecordID = value;
					this.OnInboundXmissionRecordIdChanged();
				}
			}
		}

		[Column(Storage = "_levelNum", Name = "LEVEL_NUM", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LevelNum
		{
			get
			{
				return this._levelNum;
			}
			set
			{
				if ((_levelNum != value))
				{
					this.OnLevelNumChanging(value);
					this._levelNum = value;
					this.OnLevelNumChanged();
				}
			}
		}

		[Column(Storage = "_levelSeq", Name = "LEVEL_SEQ", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LevelSeq
		{
			get
			{
				return this._levelSeq;
			}
			set
			{
				if ((_levelSeq != value))
				{
					this.OnLevelSeqChanging(value);
					this._levelSeq = value;
					this.OnLevelSeqChanged();
				}
			}
		}

		[Column(Storage = "_orgName1", Name = "ORG_NAME_1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OrgName1
		{
			get
			{
				return this._orgName1;
			}
			set
			{
				if (((_orgName1 == value)
							== false))
				{
					this.OnOrgName1Changing(value);
					this._orgName1 = value;
					this.OnOrgName1Changed();
				}
			}
		}

		[Column(Storage = "_orgName2", Name = "ORG_NAME_2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OrgName2
		{
			get
			{
				return this._orgName2;
			}
			set
			{
				if (((_orgName2 == value)
							== false))
				{
					this.OnOrgName2Changing(value);
					this._orgName2 = value;
					this.OnOrgName2Changed();
				}
			}
		}

		[Column(Storage = "_parentLevNum", Name = "PARENT_LEV_NUM", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ParentLevNum
		{
			get
			{
				return this._parentLevNum;
			}
			set
			{
				if ((_parentLevNum != value))
				{
					this.OnParentLevNumChanging(value);
					this._parentLevNum = value;
					this.OnParentLevNumChanged();
				}
			}
		}

		[Column(Storage = "_parentLevSeq", Name = "PARENT_LEV_SEQ", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ParentLevSeq
		{
			get
			{
				return this._parentLevSeq;
			}
			set
			{
				if ((_parentLevSeq != value))
				{
					this.OnParentLevSeqChanging(value);
					this._parentLevSeq = value;
					this.OnParentLevSeqChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_statusCode", Name = "STATUS_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string StatusCode
		{
			get
			{
				return this._statusCode;
			}
			set
			{
				if (((_statusCode == value)
							== false))
				{
					this.OnStatusCodeChanging(value);
					this._statusCode = value;
					this.OnStatusCodeChanged();
				}
			}
		}

		[Column(Storage = "_statusDate", Name = "STATUS_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> StatusDate
		{
			get
			{
				return this._statusDate;
			}
			set
			{
				if ((_statusDate != value))
				{
					this.OnStatusDateChanging(value);
					this._statusDate = value;
					this.OnStatusDateChanged();
				}
			}
		}

		[Column(Storage = "_taxID", Name = "TAX_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TaxId
		{
			get
			{
				return this._taxID;
			}
			set
			{
				if (((_taxID == value)
							== false))
				{
					this.OnTaxIdChanging(value);
					this._taxID = value;
					this.OnTaxIdChanged();
				}
			}
		}

		[Column(Storage = "_unitSicCode", Name = "UNIT_SIC_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UnitSicCode
		{
			get
			{
				return this._unitSicCode;
			}
			set
			{
				if (((_unitSicCode == value)
							== false))
				{
					this.OnUnitSicCodeChanging(value);
					this._unitSicCode = value;
					this.OnUnitSicCodeChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.INETPOLICY")]
	public partial class Inetpolicy
	{

		private string _addressCity;

		private string _addressLine1;

		private string _addressLine2;

		private string _addressState;

		private string _addressZip;

		private string _carrierName;

		private string _clientCode;

		private System.Nullable<System.DateTime> _createdDate;

		private string _insuredName;

		private System.Nullable<System.DateTime> _modifiedDate;

		private string _policyIdentifier;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAddressCityChanged();

		partial void OnAddressCityChanging(string value);

		partial void OnAddressLine1Changed();

		partial void OnAddressLine1Changing(string value);

		partial void OnAddressLine2Changed();

		partial void OnAddressLine2Changing(string value);

		partial void OnAddressStateChanged();

		partial void OnAddressStateChanging(string value);

		partial void OnAddressZipChanged();

		partial void OnAddressZipChanging(string value);

		partial void OnCarrierNameChanged();

		partial void OnCarrierNameChanging(string value);

		partial void OnClientCodeChanged();

		partial void OnClientCodeChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnInsuredNameChanged();

		partial void OnInsuredNameChanging(string value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnPolicyIdentifierChanged();

		partial void OnPolicyIdentifierChanging(string value);
		#endregion


		public Inetpolicy()
		{
			this.OnCreated();
		}

		[Column(Storage = "_addressCity", Name = "ADDRESS_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressCity
		{
			get
			{
				return this._addressCity;
			}
			set
			{
				if (((_addressCity == value)
							== false))
				{
					this.OnAddressCityChanging(value);
					this._addressCity = value;
					this.OnAddressCityChanged();
				}
			}
		}

		[Column(Storage = "_addressLine1", Name = "ADDRESS_LINE1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressLine1
		{
			get
			{
				return this._addressLine1;
			}
			set
			{
				if (((_addressLine1 == value)
							== false))
				{
					this.OnAddressLine1Changing(value);
					this._addressLine1 = value;
					this.OnAddressLine1Changed();
				}
			}
		}

		[Column(Storage = "_addressLine2", Name = "ADDRESS_LINE2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressLine2
		{
			get
			{
				return this._addressLine2;
			}
			set
			{
				if (((_addressLine2 == value)
							== false))
				{
					this.OnAddressLine2Changing(value);
					this._addressLine2 = value;
					this.OnAddressLine2Changed();
				}
			}
		}

		[Column(Storage = "_addressState", Name = "ADDRESS_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressState
		{
			get
			{
				return this._addressState;
			}
			set
			{
				if (((_addressState == value)
							== false))
				{
					this.OnAddressStateChanging(value);
					this._addressState = value;
					this.OnAddressStateChanged();
				}
			}
		}

		[Column(Storage = "_addressZip", Name = "ADDRESS_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressZip
		{
			get
			{
				return this._addressZip;
			}
			set
			{
				if (((_addressZip == value)
							== false))
				{
					this.OnAddressZipChanging(value);
					this._addressZip = value;
					this.OnAddressZipChanged();
				}
			}
		}

		[Column(Storage = "_carrierName", Name = "CARRIER_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CarrierName
		{
			get
			{
				return this._carrierName;
			}
			set
			{
				if (((_carrierName == value)
							== false))
				{
					this.OnCarrierNameChanging(value);
					this._carrierName = value;
					this.OnCarrierNameChanged();
				}
			}
		}

		[Column(Storage = "_clientCode", Name = "CLIENT_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ClientCode
		{
			get
			{
				return this._clientCode;
			}
			set
			{
				if (((_clientCode == value)
							== false))
				{
					this.OnClientCodeChanging(value);
					this._clientCode = value;
					this.OnClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_insuredName", Name = "INSURED_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string InsuredName
		{
			get
			{
				return this._insuredName;
			}
			set
			{
				if (((_insuredName == value)
							== false))
				{
					this.OnInsuredNameChanging(value);
					this._insuredName = value;
					this.OnInsuredNameChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_policyIdentifier", Name = "POLICY_IDENTIFIER", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string PolicyIdentifier
		{
			get
			{
				return this._policyIdentifier;
			}
			set
			{
				if (((_policyIdentifier == value)
							== false))
				{
					this.OnPolicyIdentifierChanging(value);
					this._policyIdentifier = value;
					this.OnPolicyIdentifierChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.INF_REASON_CODES")]
	public partial class InfReasonCodes
	{

		private long _callID;

		private System.DateTime _callStartTime;

		private string _reasonCodeList;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCallIdChanged();

		partial void OnCallIdChanging(long value);

		partial void OnCallStartTimeChanged();

		partial void OnCallStartTimeChanging(System.DateTime value);

		partial void OnReasonCodeListChanged();

		partial void OnReasonCodeListChanging(string value);
		#endregion


		public InfReasonCodes()
		{
			this.OnCreated();
		}

		[Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long CallId
		{
			get
			{
				return this._callID;
			}
			set
			{
				if ((_callID != value))
				{
					this.OnCallIdChanging(value);
					this._callID = value;
					this.OnCallIdChanged();
				}
			}
		}

		[Column(Storage = "_callStartTime", Name = "CALL_START_TIME", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CallStartTime
		{
			get
			{
				return this._callStartTime;
			}
			set
			{
				if ((_callStartTime != value))
				{
					this.OnCallStartTimeChanging(value);
					this._callStartTime = value;
					this.OnCallStartTimeChanged();
				}
			}
		}

		[Column(Storage = "_reasonCodeList", Name = "REASON_CODE_LIST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReasonCodeList
		{
			get
			{
				return this._reasonCodeList;
			}
			set
			{
				if (((_reasonCodeList == value)
							== false))
				{
					this.OnReasonCodeListChanging(value);
					this._reasonCodeList = value;
					this.OnReasonCodeListChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.JURISDICTION_STATE")]
	public partial class JurisdictionState
	{

		private System.Nullable<long> _fileTransmissionLogID;

		private long _policyID;

		private string _state;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnPolicyIdChanged();

		partial void OnPolicyIdChanging(long value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);
		#endregion


		public JurisdictionState()
		{
			this.OnCreated();
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_policyID", Name = "POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long PolicyId
		{
			get
			{
				return this._policyID;
			}
			set
			{
				if ((_policyID != value))
				{
					this.OnPolicyIdChanging(value);
					this._policyID = value;
					this.OnPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.KEYIV")]
	public partial class Keyiv
	{

		private string _algorithm;

		private string _clientCode;

		private string _component;

		private System.DateTime _createdDate;

		private string _iv;

		private string _key;

		private long _keyivID;

		private System.DateTime _modifiedDate;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAlgorithmChanged();

		partial void OnAlgorithmChanging(string value);

		partial void OnClientCodeChanged();

		partial void OnClientCodeChanging(string value);

		partial void OnComponentChanged();

		partial void OnComponentChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnIvChanged();

		partial void OnIvChanging(string value);

		partial void OnKeyChanged();

		partial void OnKeyChanging(string value);

		partial void OnKeyivIdChanged();

		partial void OnKeyivIdChanging(long value);

		partial void OnModifiedDateChanged();

		partial void OnModifiedDateChanging(System.DateTime value);
		#endregion


		public Keyiv()
		{
			this.OnCreated();
		}

		[Column(Storage = "_algorithm", Name = "ALGORITHM", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Algorithm
		{
			get
			{
				return this._algorithm;
			}
			set
			{
				if (((_algorithm == value)
							== false))
				{
					this.OnAlgorithmChanging(value);
					this._algorithm = value;
					this.OnAlgorithmChanged();
				}
			}
		}

		[Column(Storage = "_clientCode", Name = "CLIENT_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ClientCode
		{
			get
			{
				return this._clientCode;
			}
			set
			{
				if (((_clientCode == value)
							== false))
				{
					this.OnClientCodeChanging(value);
					this._clientCode = value;
					this.OnClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_component", Name = "COMPONENT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Component
		{
			get
			{
				return this._component;
			}
			set
			{
				if (((_component == value)
							== false))
				{
					this.OnComponentChanging(value);
					this._component = value;
					this.OnComponentChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_iv", Name = "IV", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Iv
		{
			get
			{
				return this._iv;
			}
			set
			{
				if (((_iv == value)
							== false))
				{
					this.OnIvChanging(value);
					this._iv = value;
					this.OnIvChanged();
				}
			}
		}

		[Column(Storage = "_key", Name = "KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				if (((_key == value)
							== false))
				{
					this.OnKeyChanging(value);
					this._key = value;
					this.OnKeyChanged();
				}
			}
		}

		[Column(Storage = "_keyivID", Name = "KEYIV_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long KeyivId
		{
			get
			{
				return this._keyivID;
			}
			set
			{
				if ((_keyivID != value))
				{
					this.OnKeyivIdChanging(value);
					this._keyivID = value;
					this.OnKeyivIdChanged();
				}
			}
		}

		[Column(Storage = "_modifiedDate", Name = "MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate;
			}
			set
			{
				if ((_modifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this._modifiedDate = value;
					this.OnModifiedDateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.LOB")]
	public partial class Lob
	{

		private string _lobCode;

		private string _lobName;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnLobNameChanged();

		partial void OnLobNameChanging(string value);
		#endregion


		public Lob()
		{
			this.OnCreated();
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_lobName", Name = "LOB_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LobName
		{
			get
			{
				return this._lobName;
			}
			set
			{
				if (((_lobName == value)
							== false))
				{
					this.OnLobNameChanging(value);
					this._lobName = value;
					this.OnLobNameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.LOCATION_CODE")]
	public partial class LocationCode
	{

		private string _city;

		private string _country;

		private string _county;

		private string _fips;

		private System.Nullable<float> _lat;

		private long _locationCodeID;

		private System.Nullable<float> _lon;

		private string _primaryLoc;

		private System.Nullable<short> _seq;

		private string _state;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnCountryChanged();

		partial void OnCountryChanging(string value);

		partial void OnCountyChanged();

		partial void OnCountyChanging(string value);

		partial void OnFipsChanged();

		partial void OnFipsChanging(string value);

		partial void OnLatChanged();

		partial void OnLatChanging(System.Nullable<float> value);

		partial void OnLocationCodeIdChanged();

		partial void OnLocationCodeIdChanging(long value);

		partial void OnLonChanged();

		partial void OnLonChanging(System.Nullable<float> value);

		partial void OnPrimaryLocChanged();

		partial void OnPrimaryLocChanging(string value);

		partial void OnSeqChanged();

		partial void OnSeqChanging(System.Nullable<short> value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public LocationCode()
		{
			this.OnCreated();
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_country", Name = "COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Country
		{
			get
			{
				return this._country;
			}
			set
			{
				if (((_country == value)
							== false))
				{
					this.OnCountryChanging(value);
					this._country = value;
					this.OnCountryChanged();
				}
			}
		}

		[Column(Storage = "_county", Name = "COUNTY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string County
		{
			get
			{
				return this._county;
			}
			set
			{
				if (((_county == value)
							== false))
				{
					this.OnCountyChanging(value);
					this._county = value;
					this.OnCountyChanged();
				}
			}
		}

		[Column(Storage = "_fips", Name = "FIPS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fips
		{
			get
			{
				return this._fips;
			}
			set
			{
				if (((_fips == value)
							== false))
				{
					this.OnFipsChanging(value);
					this._fips = value;
					this.OnFipsChanged();
				}
			}
		}

		[Column(Storage = "_lat", Name = "LAT", DbType = "FLOAT", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Lat
		{
			get
			{
				return this._lat;
			}
			set
			{
				if ((_lat != value))
				{
					this.OnLatChanging(value);
					this._lat = value;
					this.OnLatChanged();
				}
			}
		}

		[Column(Storage = "_locationCodeID", Name = "LOCATION_CODE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LocationCodeId
		{
			get
			{
				return this._locationCodeID;
			}
			set
			{
				if ((_locationCodeID != value))
				{
					this.OnLocationCodeIdChanging(value);
					this._locationCodeID = value;
					this.OnLocationCodeIdChanged();
				}
			}
		}

		[Column(Storage = "_lon", Name = "LON", DbType = "FLOAT", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Lon
		{
			get
			{
				return this._lon;
			}
			set
			{
				if ((_lon != value))
				{
					this.OnLonChanging(value);
					this._lon = value;
					this.OnLonChanged();
				}
			}
		}

		[Column(Storage = "_primaryLoc", Name = "PRIMARY_LOC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PrimaryLoc
		{
			get
			{
				return this._primaryLoc;
			}
			set
			{
				if (((_primaryLoc == value)
							== false))
				{
					this.OnPrimaryLocChanging(value);
					this._primaryLoc = value;
					this.OnPrimaryLocChanged();
				}
			}
		}

		[Column(Storage = "_seq", Name = "SEQ", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> Seq
		{
			get
			{
				return this._seq;
			}
			set
			{
				if ((_seq != value))
				{
					this.OnSeqChanging(value);
					this._seq = value;
					this.OnSeqChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.LOCATION_COVERAGE")]
	public partial class LocationCoverage
	{

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private long _ahsPolicyID;

		private string _coverageType;

		private System.Nullable<decimal> _deductible1;

		private System.Nullable<decimal> _deductible2;

		private System.Nullable<long> _fileTransmissionLogID;

		private System.Nullable<decimal> _limit1;

		private System.Nullable<decimal> _limit2;

		private long _locationCoverageID;

		private string _uploadKey;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAhsPolicyIdChanged();

		partial void OnAhsPolicyIdChanging(long value);

		partial void OnCoverageTypeChanged();

		partial void OnCoverageTypeChanging(string value);

		partial void OnDeductible1Changed();

		partial void OnDeductible1Changing(System.Nullable<decimal> value);

		partial void OnDeductible2Changed();

		partial void OnDeductible2Changing(System.Nullable<decimal> value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnLimit1Changed();

		partial void OnLimit1Changing(System.Nullable<decimal> value);

		partial void OnLimit2Changed();

		partial void OnLimit2Changing(System.Nullable<decimal> value);

		partial void OnLocationCoverageIdChanged();

		partial void OnLocationCoverageIdChanging(long value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);
		#endregion


		public LocationCoverage()
		{
			this.OnCreated();
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_ahsPolicyID", Name = "AHS_POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhsPolicyId
		{
			get
			{
				return this._ahsPolicyID;
			}
			set
			{
				if ((_ahsPolicyID != value))
				{
					this.OnAhsPolicyIdChanging(value);
					this._ahsPolicyID = value;
					this.OnAhsPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_coverageType", Name = "COVERAGE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CoverageType
		{
			get
			{
				return this._coverageType;
			}
			set
			{
				if (((_coverageType == value)
							== false))
				{
					this.OnCoverageTypeChanging(value);
					this._coverageType = value;
					this.OnCoverageTypeChanged();
				}
			}
		}

		[Column(Storage = "_deductible1", Name = "DEDUCTIBLE1", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Deductible1
		{
			get
			{
				return this._deductible1;
			}
			set
			{
				if ((_deductible1 != value))
				{
					this.OnDeductible1Changing(value);
					this._deductible1 = value;
					this.OnDeductible1Changed();
				}
			}
		}

		[Column(Storage = "_deductible2", Name = "DEDUCTIBLE2", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Deductible2
		{
			get
			{
				return this._deductible2;
			}
			set
			{
				if ((_deductible2 != value))
				{
					this.OnDeductible2Changing(value);
					this._deductible2 = value;
					this.OnDeductible2Changed();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_limit1", Name = "LIMIT1", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Limit1
		{
			get
			{
				return this._limit1;
			}
			set
			{
				if ((_limit1 != value))
				{
					this.OnLimit1Changing(value);
					this._limit1 = value;
					this.OnLimit1Changed();
				}
			}
		}

		[Column(Storage = "_limit2", Name = "LIMIT2", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Limit2
		{
			get
			{
				return this._limit2;
			}
			set
			{
				if ((_limit2 != value))
				{
					this.OnLimit2Changing(value);
					this._limit2 = value;
					this.OnLimit2Changed();
				}
			}
		}

		[Column(Storage = "_locationCoverageID", Name = "LOCATION_COVERAGE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LocationCoverageId
		{
			get
			{
				return this._locationCoverageID;
			}
			set
			{
				if ((_locationCoverageID != value))
				{
					this.OnLocationCoverageIdChanging(value);
					this._locationCoverageID = value;
					this.OnLocationCoverageIdChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.LOCATION_LIEN")]
	public partial class LocationLien
	{

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private string _address1;

		private string _address2;

		private long _ahsPolicyID;

		private string _city;

		private System.Nullable<long> _fileTransmissionLogID;

		private long _locationLienID;

		private string _nameFirst;

		private string _nameLast;

		private string _state;

		private string _uploadKey;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnAhsPolicyIdChanged();

		partial void OnAhsPolicyIdChanging(long value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnLocationLienIdChanged();

		partial void OnLocationLienIdChanging(long value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public LocationLien()
		{
			this.OnCreated();
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_ahsPolicyID", Name = "AHS_POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AhsPolicyId
		{
			get
			{
				return this._ahsPolicyID;
			}
			set
			{
				if ((_ahsPolicyID != value))
				{
					this.OnAhsPolicyIdChanging(value);
					this._ahsPolicyID = value;
					this.OnAhsPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_locationLienID", Name = "LOCATION_LIEN_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LocationLienId
		{
			get
			{
				return this._locationLienID;
			}
			set
			{
				if ((_locationLienID != value))
				{
					this.OnLocationLienIdChanging(value);
					this._locationLienID = value;
					this.OnLocationLienIdChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.LOCATIONS_USER")]
	public partial class LocationsUser
	{

		private long _accntHrcyStepID;

		private long _accountUserID;

		private string _fnsClientCode;

		private string _greeting;

		private string _lobCode;

		private long _locationAhsID;

		private long _locationUserID;

		private string _name;

		private string _phonenumber;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAccountUserIdChanged();

		partial void OnAccountUserIdChanging(long value);

		partial void OnFnsClientCodeChanged();

		partial void OnFnsClientCodeChanging(string value);

		partial void OnGreetingChanged();

		partial void OnGreetingChanging(string value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnLocationAhsIdChanged();

		partial void OnLocationAhsIdChanging(long value);

		partial void OnLocationUserIdChanged();

		partial void OnLocationUserIdChanging(long value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPhonenumberChanged();

		partial void OnPhonenumberChanging(string value);
		#endregion


		public LocationsUser()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_accountUserID", Name = "ACCOUNT_USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccountUserId
		{
			get
			{
				return this._accountUserID;
			}
			set
			{
				if ((_accountUserID != value))
				{
					this.OnAccountUserIdChanging(value);
					this._accountUserID = value;
					this.OnAccountUserIdChanged();
				}
			}
		}

		[Column(Storage = "_fnsClientCode", Name = "FNS_CLIENT_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string FnsClientCode
		{
			get
			{
				return this._fnsClientCode;
			}
			set
			{
				if (((_fnsClientCode == value)
							== false))
				{
					this.OnFnsClientCodeChanging(value);
					this._fnsClientCode = value;
					this.OnFnsClientCodeChanged();
				}
			}
		}

		[Column(Storage = "_greeting", Name = "GREETING", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Greeting
		{
			get
			{
				return this._greeting;
			}
			set
			{
				if (((_greeting == value)
							== false))
				{
					this.OnGreetingChanging(value);
					this._greeting = value;
					this.OnGreetingChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_locationAhsID", Name = "LOCATION_AHSID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LocationAhsId
		{
			get
			{
				return this._locationAhsID;
			}
			set
			{
				if ((_locationAhsID != value))
				{
					this.OnLocationAhsIdChanging(value);
					this._locationAhsID = value;
					this.OnLocationAhsIdChanged();
				}
			}
		}

		[Column(Storage = "_locationUserID", Name = "LOCATION_USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LocationUserId
		{
			get
			{
				return this._locationUserID;
			}
			set
			{
				if ((_locationUserID != value))
				{
					this.OnLocationUserIdChanging(value);
					this._locationUserID = value;
					this.OnLocationUserIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_phonenumber", Name = "PHONENUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Phonenumber
		{
			get
			{
				return this._phonenumber;
			}
			set
			{
				if (((_phonenumber == value)
							== false))
				{
					this.OnPhonenumberChanging(value);
					this._phonenumber = value;
					this.OnPhonenumberChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.LOCATIONTREE")]
	public partial class Locationtree
	{

		private string _activeStatus;

		private string _address1;

		private string _address2;

		private string _city;

		private string _code;

		private string _locationName;

		private string _state;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnActiveStatusChanged();

		partial void OnActiveStatusChanging(string value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnCodeChanged();

		partial void OnCodeChanging(string value);

		partial void OnLocationNameChanged();

		partial void OnLocationNameChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public Locationtree()
		{
			this.OnCreated();
		}

		[Column(Storage = "_activeStatus", Name = "ACTIVE_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ActiveStatus
		{
			get
			{
				return this._activeStatus;
			}
			set
			{
				if (((_activeStatus == value)
							== false))
				{
					this.OnActiveStatusChanging(value);
					this._activeStatus = value;
					this.OnActiveStatusChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS_1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS_2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_code", Name = "CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if (((_code == value)
							== false))
				{
					this.OnCodeChanging(value);
					this._code = value;
					this.OnCodeChanged();
				}
			}
		}

		[Column(Storage = "_locationName", Name = "LOCATION_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LocationName
		{
			get
			{
				return this._locationName;
			}
			set
			{
				if (((_locationName == value)
							== false))
				{
					this.OnLocationNameChanging(value);
					this._locationName = value;
					this.OnLocationNameChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.LU_CODE")]
	public partial class LuCode
	{

		private string _code;

		private long _luID;

		private long _luTypeID;

		private System.Nullable<long> _sequence;

		private string _value;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCodeChanged();

		partial void OnCodeChanging(string value);

		partial void OnLuIdChanged();

		partial void OnLuIdChanging(long value);

		partial void OnLuTypeIdChanged();

		partial void OnLuTypeIdChanging(long value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<long> value);

		partial void OnValueChanged();

		partial void OnValueChanging(string value);
		#endregion


		public LuCode()
		{
			this.OnCreated();
		}

		[Column(Storage = "_code", Name = "CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if (((_code == value)
							== false))
				{
					this.OnCodeChanging(value);
					this._code = value;
					this.OnCodeChanged();
				}
			}
		}

		[Column(Storage = "_luID", Name = "LU_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LuId
		{
			get
			{
				return this._luID;
			}
			set
			{
				if ((_luID != value))
				{
					this.OnLuIdChanging(value);
					this._luID = value;
					this.OnLuIdChanged();
				}
			}
		}

		[Column(Storage = "_luTypeID", Name = "LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LuTypeId
		{
			get
			{
				return this._luTypeID;
			}
			set
			{
				if ((_luTypeID != value))
				{
					this.OnLuTypeIdChanging(value);
					this._luTypeID = value;
					this.OnLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_value", Name = "VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (((_value == value)
							== false))
				{
					this.OnValueChanging(value);
					this._value = value;
					this.OnValueChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.LU_TYPE")]
	public partial class LuType
	{

		private long _luTypeID;

		private string _name;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnLuTypeIdChanged();

		partial void OnLuTypeIdChanging(long value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);
		#endregion


		public LuType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_luTypeID", Name = "LU_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long LuTypeId
		{
			get
			{
				return this._luTypeID;
			}
			set
			{
				if ((_luTypeID != value))
				{
					this.OnLuTypeIdChanging(value);
					this._luTypeID = value;
					this.OnLuTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MAILBOX")]
	public partial class Mailbox
	{

		private long _accountHierarchyLoadID;

		private System.DateTime _createdDate;

		private System.DateTime _lastModifiedDate;

		private long _mailboxID;

		private string _mailboxNumber;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccountHierarchyLoadIdChanged();

		partial void OnAccountHierarchyLoadIdChanging(long value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnMailboxIdChanged();

		partial void OnMailboxIdChanging(long value);

		partial void OnMailboxNumberChanged();

		partial void OnMailboxNumberChanging(string value);
		#endregion


		public Mailbox()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accountHierarchyLoadID", Name = "ACCOUNT_HIERARCHY_LOAD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccountHierarchyLoadId
		{
			get
			{
				return this._accountHierarchyLoadID;
			}
			set
			{
				if ((_accountHierarchyLoadID != value))
				{
					this.OnAccountHierarchyLoadIdChanging(value);
					this._accountHierarchyLoadID = value;
					this.OnAccountHierarchyLoadIdChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_mailboxID", Name = "MAILBOX_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long MailboxId
		{
			get
			{
				return this._mailboxID;
			}
			set
			{
				if ((_mailboxID != value))
				{
					this.OnMailboxIdChanging(value);
					this._mailboxID = value;
					this.OnMailboxIdChanged();
				}
			}
		}

		[Column(Storage = "_mailboxNumber", Name = "MAILBOX_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MailboxNumber
		{
			get
			{
				return this._mailboxNumber;
			}
			set
			{
				if (((_mailboxNumber == value)
							== false))
				{
					this.OnMailboxNumberChanging(value);
					this._mailboxNumber = value;
					this.OnMailboxNumberChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MAILBOX_ASSIGNMENT_RULE")]
	public partial class MailboxAssignmentRule
	{

		private System.DateTime _createdDate;

		private System.DateTime _lastModifiedDate;

		private string _lobCode;

		private long _mailboxAssignmentRuleID;

		private long _mailboxAssignmentTypeID;

		private long _mailboxID;

		private string _routingState;

		private System.Nullable<long> _ruleID;

		private System.Nullable<long> _sequenceNum;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnMailboxAssignmentRuleIdChanged();

		partial void OnMailboxAssignmentRuleIdChanging(long value);

		partial void OnMailboxAssignmentTypeIdChanged();

		partial void OnMailboxAssignmentTypeIdChanging(long value);

		partial void OnMailboxIdChanged();

		partial void OnMailboxIdChanging(long value);

		partial void OnRoutingStateChanged();

		partial void OnRoutingStateChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);

		partial void OnSequenceNumChanged();

		partial void OnSequenceNumChanging(System.Nullable<long> value);
		#endregion


		public MailboxAssignmentRule()
		{
			this.OnCreated();
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_mailboxAssignmentRuleID", Name = "MAILBOX_ASSIGNMENT_RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long MailboxAssignmentRuleId
		{
			get
			{
				return this._mailboxAssignmentRuleID;
			}
			set
			{
				if ((_mailboxAssignmentRuleID != value))
				{
					this.OnMailboxAssignmentRuleIdChanging(value);
					this._mailboxAssignmentRuleID = value;
					this.OnMailboxAssignmentRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_mailboxAssignmentTypeID", Name = "MAILBOX_ASSIGNMENT_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long MailboxAssignmentTypeId
		{
			get
			{
				return this._mailboxAssignmentTypeID;
			}
			set
			{
				if ((_mailboxAssignmentTypeID != value))
				{
					this.OnMailboxAssignmentTypeIdChanging(value);
					this._mailboxAssignmentTypeID = value;
					this.OnMailboxAssignmentTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_mailboxID", Name = "MAILBOX_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long MailboxId
		{
			get
			{
				return this._mailboxID;
			}
			set
			{
				if ((_mailboxID != value))
				{
					this.OnMailboxIdChanging(value);
					this._mailboxID = value;
					this.OnMailboxIdChanged();
				}
			}
		}

		[Column(Storage = "_routingState", Name = "ROUTING_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RoutingState
		{
			get
			{
				return this._routingState;
			}
			set
			{
				if (((_routingState == value)
							== false))
				{
					this.OnRoutingStateChanging(value);
					this._routingState = value;
					this.OnRoutingStateChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_sequenceNum", Name = "SEQUENCE_NUM", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> SequenceNum
		{
			get
			{
				return this._sequenceNum;
			}
			set
			{
				if ((_sequenceNum != value))
				{
					this.OnSequenceNumChanging(value);
					this._sequenceNum = value;
					this.OnSequenceNumChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MAILBOX_ASSIGNMENT_TYPE")]
	public partial class MailboxAssignmentType
	{

		private long _accntHrcyStepID;

		private string _branchNumber;

		private System.DateTime _createdDate;

		private string _description;

		private System.DateTime _lastModifiedDate;

		private long _mailboxAssignmentTypeID;

		private System.Nullable<long> _ruleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnBranchNumberChanged();

		partial void OnBranchNumberChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnMailboxAssignmentTypeIdChanged();

		partial void OnMailboxAssignmentTypeIdChanging(long value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);
		#endregion


		public MailboxAssignmentType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_branchNumber", Name = "BRANCH_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BranchNumber
		{
			get
			{
				return this._branchNumber;
			}
			set
			{
				if (((_branchNumber == value)
							== false))
				{
					this.OnBranchNumberChanging(value);
					this._branchNumber = value;
					this.OnBranchNumberChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_mailboxAssignmentTypeID", Name = "MAILBOX_ASSIGNMENT_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long MailboxAssignmentTypeId
		{
			get
			{
				return this._mailboxAssignmentTypeID;
			}
			set
			{
				if ((_mailboxAssignmentTypeID != value))
				{
					this.OnMailboxAssignmentTypeIdChanging(value);
					this._mailboxAssignmentTypeID = value;
					this.OnMailboxAssignmentTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MANAGED_CARE_TYPE")]
	public partial class ManagedCareType
	{

		private string _description;

		private string _type;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);
		#endregion


		public ManagedCareType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MC_BRANCHASSIGNMENTRULE")]
	public partial class McBranchassignmentRule
	{

		private long _branchID;

		private string _lobCode;

		private string _managedCareType;

		private long _mcBranchassignmentRuleID;

		private long _mcBranchassignmenttypeID;

		private string _routingFips;

		private string _routingState;

		private System.Nullable<long> _ruleID;

		private long _sequence;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBranchIdChanged();

		partial void OnBranchIdChanging(long value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnManagedCareTypeChanged();

		partial void OnManagedCareTypeChanging(string value);

		partial void OnMcBranchassignmentRuleIdChanged();

		partial void OnMcBranchassignmentRuleIdChanging(long value);

		partial void OnMcBranchassignmenttypeIdChanged();

		partial void OnMcBranchassignmenttypeIdChanging(long value);

		partial void OnRoutingFipsChanged();

		partial void OnRoutingFipsChanging(string value);

		partial void OnRoutingStateChanged();

		partial void OnRoutingStateChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);
		#endregion


		public McBranchassignmentRule()
		{
			this.OnCreated();
		}

		[Column(Storage = "_branchID", Name = "BRANCH_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long BranchId
		{
			get
			{
				return this._branchID;
			}
			set
			{
				if ((_branchID != value))
				{
					this.OnBranchIdChanging(value);
					this._branchID = value;
					this.OnBranchIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_managedCareType", Name = "MANAGED_CARE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ManagedCareType
		{
			get
			{
				return this._managedCareType;
			}
			set
			{
				if (((_managedCareType == value)
							== false))
				{
					this.OnManagedCareTypeChanging(value);
					this._managedCareType = value;
					this.OnManagedCareTypeChanged();
				}
			}
		}

		[Column(Storage = "_mcBranchassignmentRuleID", Name = "MC_BRANCHASSIGNMENTRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long McBranchassignmentRuleId
		{
			get
			{
				return this._mcBranchassignmentRuleID;
			}
			set
			{
				if ((_mcBranchassignmentRuleID != value))
				{
					this.OnMcBranchassignmentRuleIdChanging(value);
					this._mcBranchassignmentRuleID = value;
					this.OnMcBranchassignmentRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_mcBranchassignmenttypeID", Name = "MC_BRANCHASSIGNMENTTYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long McBranchassignmenttypeId
		{
			get
			{
				return this._mcBranchassignmenttypeID;
			}
			set
			{
				if ((_mcBranchassignmenttypeID != value))
				{
					this.OnMcBranchassignmenttypeIdChanging(value);
					this._mcBranchassignmenttypeID = value;
					this.OnMcBranchassignmenttypeIdChanged();
				}
			}
		}

		[Column(Storage = "_routingFips", Name = "ROUTING_FIPS", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string RoutingFips
		{
			get
			{
				return this._routingFips;
			}
			set
			{
				if (((_routingFips == value)
							== false))
				{
					this.OnRoutingFipsChanging(value);
					this._routingFips = value;
					this.OnRoutingFipsChanged();
				}
			}
		}

		[Column(Storage = "_routingState", Name = "ROUTING_STATE", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string RoutingState
		{
			get
			{
				return this._routingState;
			}
			set
			{
				if (((_routingState == value)
							== false))
				{
					this.OnRoutingStateChanging(value);
					this._routingState = value;
					this.OnRoutingStateChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MC_BRANCHASSIGNMENTTYPE")]
	public partial class McBranchassignmenttype
	{

		private long _accntHrcyStepID;

		private string _description;

		private long _mcBranchassignmenttypeID;

		private System.Nullable<long> _ruleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnMcBranchassignmenttypeIdChanged();

		partial void OnMcBranchassignmenttypeIdChanging(long value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);
		#endregion


		public McBranchassignmenttype()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_mcBranchassignmenttypeID", Name = "MC_BRANCHASSIGNMENTTYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long McBranchassignmenttypeId
		{
			get
			{
				return this._mcBranchassignmenttypeID;
			}
			set
			{
				if ((_mcBranchassignmenttypeID != value))
				{
					this.OnMcBranchassignmenttypeIdChanging(value);
					this._mcBranchassignmenttypeID = value;
					this.OnMcBranchassignmenttypeIdChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MEDICAL_PROVIDER")]
	public partial class MedicalProvider
	{

		private string _address1;

		private string _city;

		private string _county;

		private System.Nullable<decimal> _distance;

		private string _locationCode;

		private long _medicalProviderID;

		private string _name;

		private string _phone;

		private string _specialty;

		private string _state;

		private string _taxID;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnCountyChanged();

		partial void OnCountyChanging(string value);

		partial void OnDistanceChanged();

		partial void OnDistanceChanging(System.Nullable<decimal> value);

		partial void OnLocationCodeChanged();

		partial void OnLocationCodeChanging(string value);

		partial void OnMedicalProviderIdChanged();

		partial void OnMedicalProviderIdChanging(long value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnSpecialtyChanged();

		partial void OnSpecialtyChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnTaxIdChanged();

		partial void OnTaxIdChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public MedicalProvider()
		{
			this.OnCreated();
		}

		[Column(Storage = "_address1", Name = "ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_county", Name = "COUNTY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string County
		{
			get
			{
				return this._county;
			}
			set
			{
				if (((_county == value)
							== false))
				{
					this.OnCountyChanging(value);
					this._county = value;
					this.OnCountyChanged();
				}
			}
		}

		[Column(Storage = "_distance", Name = "DISTANCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> Distance
		{
			get
			{
				return this._distance;
			}
			set
			{
				if ((_distance != value))
				{
					this.OnDistanceChanging(value);
					this._distance = value;
					this.OnDistanceChanged();
				}
			}
		}

		[Column(Storage = "_locationCode", Name = "LOCATION_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LocationCode
		{
			get
			{
				return this._locationCode;
			}
			set
			{
				if (((_locationCode == value)
							== false))
				{
					this.OnLocationCodeChanging(value);
					this._locationCode = value;
					this.OnLocationCodeChanged();
				}
			}
		}

		[Column(Storage = "_medicalProviderID", Name = "MEDICAL_PROVIDER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long MedicalProviderId
		{
			get
			{
				return this._medicalProviderID;
			}
			set
			{
				if ((_medicalProviderID != value))
				{
					this.OnMedicalProviderIdChanging(value);
					this._medicalProviderID = value;
					this.OnMedicalProviderIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_specialty", Name = "SPECIALTY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Specialty
		{
			get
			{
				return this._specialty;
			}
			set
			{
				if (((_specialty == value)
							== false))
				{
					this.OnSpecialtyChanging(value);
					this._specialty = value;
					this.OnSpecialtyChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_taxID", Name = "TAX_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TaxId
		{
			get
			{
				return this._taxID;
			}
			set
			{
				if (((_taxID == value)
							== false))
				{
					this.OnTaxIdChanging(value);
					this._taxID = value;
					this.OnTaxIdChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MERCURY")]
	public partial class Mercury
	{

		private string _hostMachine;

		private string _queueName;

		private string _type;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnHostMachineChanged();

		partial void OnHostMachineChanging(string value);

		partial void OnQueueNameChanged();

		partial void OnQueueNameChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);
		#endregion


		public Mercury()
		{
			this.OnCreated();
		}

		[Column(Storage = "_hostMachine", Name = "HOST_MACHINE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string HostMachine
		{
			get
			{
				return this._hostMachine;
			}
			set
			{
				if (((_hostMachine == value)
							== false))
				{
					this.OnHostMachineChanging(value);
					this._hostMachine = value;
					this.OnHostMachineChanged();
				}
			}
		}

		[Column(Storage = "_queueName", Name = "QUEUE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string QueueName
		{
			get
			{
				return this._queueName;
			}
			set
			{
				if (((_queueName == value)
							== false))
				{
					this.OnQueueNameChanging(value);
					this._queueName = value;
					this.OnQueueNameChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MERCURY_FORWARDING")]
	public partial class MercuryForwarding
	{

		private string _forwardingHost;

		private string _forwardingQueue;

		private string _forwardRule;

		private string _hostMachine;

		private string _queueName;

		private string _type;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnForwardingHostChanged();

		partial void OnForwardingHostChanging(string value);

		partial void OnForwardingQueueChanged();

		partial void OnForwardingQueueChanging(string value);

		partial void OnForwardRuleChanged();

		partial void OnForwardRuleChanging(string value);

		partial void OnHostMachineChanged();

		partial void OnHostMachineChanging(string value);

		partial void OnQueueNameChanged();

		partial void OnQueueNameChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);
		#endregion


		public MercuryForwarding()
		{
			this.OnCreated();
		}

		[Column(Storage = "_forwardingHost", Name = "FORWARDING_HOST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ForwardingHost
		{
			get
			{
				return this._forwardingHost;
			}
			set
			{
				if (((_forwardingHost == value)
							== false))
				{
					this.OnForwardingHostChanging(value);
					this._forwardingHost = value;
					this.OnForwardingHostChanged();
				}
			}
		}

		[Column(Storage = "_forwardingQueue", Name = "FORWARDING_QUEUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ForwardingQueue
		{
			get
			{
				return this._forwardingQueue;
			}
			set
			{
				if (((_forwardingQueue == value)
							== false))
				{
					this.OnForwardingQueueChanging(value);
					this._forwardingQueue = value;
					this.OnForwardingQueueChanged();
				}
			}
		}

		[Column(Storage = "_forwardRule", Name = "FORWARD_RULE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ForwardRule
		{
			get
			{
				return this._forwardRule;
			}
			set
			{
				if (((_forwardRule == value)
							== false))
				{
					this.OnForwardRuleChanging(value);
					this._forwardRule = value;
					this.OnForwardRuleChanged();
				}
			}
		}

		[Column(Storage = "_hostMachine", Name = "HOST_MACHINE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string HostMachine
		{
			get
			{
				return this._hostMachine;
			}
			set
			{
				if (((_hostMachine == value)
							== false))
				{
					this.OnHostMachineChanging(value);
					this._hostMachine = value;
					this.OnHostMachineChanged();
				}
			}
		}

		[Column(Storage = "_queueName", Name = "QUEUE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string QueueName
		{
			get
			{
				return this._queueName;
			}
			set
			{
				if (((_queueName == value)
							== false))
				{
					this.OnQueueNameChanging(value);
					this._queueName = value;
					this.OnQueueNameChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MESSAGING")]
	public partial class Messaging
	{

		private byte[] _body;

		private System.Nullable<System.DateTime> _createdDate;

		private string _destination;

		private long _messagingID;

		private string _source;

		private string _status;

		private string _subject;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBodyChanged();

		partial void OnBodyChanging(byte[] value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);

		partial void OnDestinationChanged();

		partial void OnDestinationChanging(string value);

		partial void OnMessagingIdChanged();

		partial void OnMessagingIdChanging(long value);

		partial void OnSourceChanged();

		partial void OnSourceChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnSubjectChanged();

		partial void OnSubjectChanging(string value);
		#endregion


		public Messaging()
		{
			this.OnCreated();
		}

		[Column(Storage = "_body", Name = "BODY", DbType = "LONG RAW", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public byte[] Body
		{
			get
			{
				return this._body;
			}
			set
			{
				if (((_body == value)
							== false))
				{
					this.OnBodyChanging(value);
					this._body = value;
					this.OnBodyChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_destination", Name = "DESTINATION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				if (((_destination == value)
							== false))
				{
					this.OnDestinationChanging(value);
					this._destination = value;
					this.OnDestinationChanged();
				}
			}
		}

		[Column(Storage = "_messagingID", Name = "MESSAGING_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long MessagingId
		{
			get
			{
				return this._messagingID;
			}
			set
			{
				if ((_messagingID != value))
				{
					this.OnMessagingIdChanging(value);
					this._messagingID = value;
					this.OnMessagingIdChanged();
				}
			}
		}

		[Column(Storage = "_source", Name = "SOURCE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Source
		{
			get
			{
				return this._source;
			}
			set
			{
				if (((_source == value)
							== false))
				{
					this.OnSourceChanging(value);
					this._source = value;
					this.OnSourceChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_subject", Name = "SUBJECT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Subject
		{
			get
			{
				return this._subject;
			}
			set
			{
				if (((_subject == value)
							== false))
				{
					this.OnSubjectChanging(value);
					this._subject = value;
					this.OnSubjectChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MIGRATION_DETAIL")]
	public partial class MigrationDetail
	{

		private long _jobDetailID;

		private long _jobID;

		private System.Nullable<long> _outputDefinitionID;

		private System.Nullable<System.DateTime> _subsetEnd;

		private System.Nullable<long> _subsetID;

		private System.Nullable<System.DateTime> _subsetStart;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnJobDetailIdChanged();

		partial void OnJobDetailIdChanging(long value);

		partial void OnJobIdChanged();

		partial void OnJobIdChanging(long value);

		partial void OnOutputDefinitionIdChanged();

		partial void OnOutputDefinitionIdChanging(System.Nullable<long> value);

		partial void OnSubsetEndChanged();

		partial void OnSubsetEndChanging(System.Nullable<System.DateTime> value);

		partial void OnSubsetIdChanged();

		partial void OnSubsetIdChanging(System.Nullable<long> value);

		partial void OnSubsetStartChanged();

		partial void OnSubsetStartChanging(System.Nullable<System.DateTime> value);
		#endregion


		public MigrationDetail()
		{
			this.OnCreated();
		}

		[Column(Storage = "_jobDetailID", Name = "JOB_DETAIL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long JobDetailId
		{
			get
			{
				return this._jobDetailID;
			}
			set
			{
				if ((_jobDetailID != value))
				{
					this.OnJobDetailIdChanging(value);
					this._jobDetailID = value;
					this.OnJobDetailIdChanged();
				}
			}
		}

		[Column(Storage = "_jobID", Name = "JOB_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long JobId
		{
			get
			{
				return this._jobID;
			}
			set
			{
				if ((_jobID != value))
				{
					this.OnJobIdChanging(value);
					this._jobID = value;
					this.OnJobIdChanged();
				}
			}
		}

		[Column(Storage = "_outputDefinitionID", Name = "OUTPUT_DEFINITION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> OutputDefinitionId
		{
			get
			{
				return this._outputDefinitionID;
			}
			set
			{
				if ((_outputDefinitionID != value))
				{
					this.OnOutputDefinitionIdChanging(value);
					this._outputDefinitionID = value;
					this.OnOutputDefinitionIdChanged();
				}
			}
		}

		[Column(Storage = "_subsetEnd", Name = "SUBSET_END", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> SubsetEnd
		{
			get
			{
				return this._subsetEnd;
			}
			set
			{
				if ((_subsetEnd != value))
				{
					this.OnSubsetEndChanging(value);
					this._subsetEnd = value;
					this.OnSubsetEndChanged();
				}
			}
		}

		[Column(Storage = "_subsetID", Name = "SUBSET_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> SubsetId
		{
			get
			{
				return this._subsetID;
			}
			set
			{
				if ((_subsetID != value))
				{
					this.OnSubsetIdChanging(value);
					this._subsetID = value;
					this.OnSubsetIdChanged();
				}
			}
		}

		[Column(Storage = "_subsetStart", Name = "SUBSET_START", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> SubsetStart
		{
			get
			{
				return this._subsetStart;
			}
			set
			{
				if ((_subsetStart != value))
				{
					this.OnSubsetStartChanging(value);
					this._subsetStart = value;
					this.OnSubsetStartChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MIGRATIONERRORLOG")]
	public partial class Migrationerrorlog
	{

		private string _daterun;

		private string _failedprocess;

		private string _oraerror;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDaterunChanged();

		partial void OnDaterunChanging(string value);

		partial void OnFailedprocessChanged();

		partial void OnFailedprocessChanging(string value);

		partial void OnOraerrorChanged();

		partial void OnOraerrorChanging(string value);
		#endregion


		public Migrationerrorlog()
		{
			this.OnCreated();
		}

		[Column(Storage = "_daterun", Name = "DATERUN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Daterun
		{
			get
			{
				return this._daterun;
			}
			set
			{
				if (((_daterun == value)
							== false))
				{
					this.OnDaterunChanging(value);
					this._daterun = value;
					this.OnDaterunChanged();
				}
			}
		}

		[Column(Storage = "_failedprocess", Name = "FAILEDPROCESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Failedprocess
		{
			get
			{
				return this._failedprocess;
			}
			set
			{
				if (((_failedprocess == value)
							== false))
				{
					this.OnFailedprocessChanging(value);
					this._failedprocess = value;
					this.OnFailedprocessChanged();
				}
			}
		}

		[Column(Storage = "_oraerror", Name = "ORAERROR", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Oraerror
		{
			get
			{
				return this._oraerror;
			}
			set
			{
				if (((_oraerror == value)
							== false))
				{
					this.OnOraerrorChanging(value);
					this._oraerror = value;
					this.OnOraerrorChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.MIGRATION_JOB")]
	public partial class MigrationJob
	{

		private long _accntHrcyStepID;

		private System.Nullable<System.DateTime> _endTime;

		private long _jobID;

		private string _lobCode;

		private string _moveAllOutputDefs;

		private System.Nullable<System.DateTime> _scheduledStart;

		private System.Nullable<System.DateTime> _startTime;

		private System.Nullable<long> _statusCode;

		private string _statusMsg;

		private long _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnEndTimeChanged();

		partial void OnEndTimeChanging(System.Nullable<System.DateTime> value);

		partial void OnJobIdChanged();

		partial void OnJobIdChanging(long value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnMoveAllOutputDefsChanged();

		partial void OnMoveAllOutputDefsChanging(string value);

		partial void OnScheduledStartChanged();

		partial void OnScheduledStartChanging(System.Nullable<System.DateTime> value);

		partial void OnStartTimeChanged();

		partial void OnStartTimeChanging(System.Nullable<System.DateTime> value);

		partial void OnStatusCodeChanged();

		partial void OnStatusCodeChanging(System.Nullable<long> value);

		partial void OnStatusMsgChanged();

		partial void OnStatusMsgChanging(string value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(long value);
		#endregion


		public MigrationJob()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_endTime", Name = "END_TIME", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> EndTime
		{
			get
			{
				return this._endTime;
			}
			set
			{
				if ((_endTime != value))
				{
					this.OnEndTimeChanging(value);
					this._endTime = value;
					this.OnEndTimeChanged();
				}
			}
		}

		[Column(Storage = "_jobID", Name = "JOB_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long JobId
		{
			get
			{
				return this._jobID;
			}
			set
			{
				if ((_jobID != value))
				{
					this.OnJobIdChanging(value);
					this._jobID = value;
					this.OnJobIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_moveAllOutputDefs", Name = "MOVE_ALL_OUTPUT_DEFS", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string MoveAllOutputDefs
		{
			get
			{
				return this._moveAllOutputDefs;
			}
			set
			{
				if (((_moveAllOutputDefs == value)
							== false))
				{
					this.OnMoveAllOutputDefsChanging(value);
					this._moveAllOutputDefs = value;
					this.OnMoveAllOutputDefsChanged();
				}
			}
		}

		[Column(Storage = "_scheduledStart", Name = "SCHEDULED_START", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ScheduledStart
		{
			get
			{
				return this._scheduledStart;
			}
			set
			{
				if ((_scheduledStart != value))
				{
					this.OnScheduledStartChanging(value);
					this._scheduledStart = value;
					this.OnScheduledStartChanged();
				}
			}
		}

		[Column(Storage = "_startTime", Name = "START_TIME", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> StartTime
		{
			get
			{
				return this._startTime;
			}
			set
			{
				if ((_startTime != value))
				{
					this.OnStartTimeChanging(value);
					this._startTime = value;
					this.OnStartTimeChanged();
				}
			}
		}

		[Column(Storage = "_statusCode", Name = "STATUS_CD", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> StatusCode
		{
			get
			{
				return this._statusCode;
			}
			set
			{
				if ((_statusCode != value))
				{
					this.OnStatusCodeChanging(value);
					this._statusCode = value;
					this.OnStatusCodeChanged();
				}
			}
		}

		[Column(Storage = "_statusMsg", Name = "STATUS_MSG", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string StatusMsg
		{
			get
			{
				return this._statusMsg;
			}
			set
			{
				if (((_statusMsg == value)
							== false))
				{
					this.OnStatusMsgChanging(value);
					this._statusMsg = value;
					this.OnStatusMsgChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.NAICS_CODES")]
	public partial class NaicsCodes
	{

		private string _naicsCode;

		private string _naicsCodeDecription;

		private long _naicsCodesID;

		private string _sicCode;

		private string _sicCodeDecription;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnNaicsCodeChanged();

		partial void OnNaicsCodeChanging(string value);

		partial void OnNaicsCodeDecriptionChanged();

		partial void OnNaicsCodeDecriptionChanging(string value);

		partial void OnNaicsCodesIdChanged();

		partial void OnNaicsCodesIdChanging(long value);

		partial void OnSicCodeChanged();

		partial void OnSicCodeChanging(string value);

		partial void OnSicCodeDecriptionChanged();

		partial void OnSicCodeDecriptionChanging(string value);
		#endregion


		public NaicsCodes()
		{
			this.OnCreated();
		}

		[Column(Storage = "_naicsCode", Name = "NAICS_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NaicsCode
		{
			get
			{
				return this._naicsCode;
			}
			set
			{
				if (((_naicsCode == value)
							== false))
				{
					this.OnNaicsCodeChanging(value);
					this._naicsCode = value;
					this.OnNaicsCodeChanged();
				}
			}
		}

		[Column(Storage = "_naicsCodeDecription", Name = "NAICS_CODE_DESC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NaicsCodeDecription
		{
			get
			{
				return this._naicsCodeDecription;
			}
			set
			{
				if (((_naicsCodeDecription == value)
							== false))
				{
					this.OnNaicsCodeDecriptionChanging(value);
					this._naicsCodeDecription = value;
					this.OnNaicsCodeDecriptionChanged();
				}
			}
		}

		[Column(Storage = "_naicsCodesID", Name = "NAICS_CODES_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long NaicsCodesId
		{
			get
			{
				return this._naicsCodesID;
			}
			set
			{
				if ((_naicsCodesID != value))
				{
					this.OnNaicsCodesIdChanging(value);
					this._naicsCodesID = value;
					this.OnNaicsCodesIdChanged();
				}
			}
		}

		[Column(Storage = "_sicCode", Name = "SIC_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SicCode
		{
			get
			{
				return this._sicCode;
			}
			set
			{
				if (((_sicCode == value)
							== false))
				{
					this.OnSicCodeChanging(value);
					this._sicCode = value;
					this.OnSicCodeChanged();
				}
			}
		}

		[Column(Storage = "_sicCodeDecription", Name = "SIC_CODE_DESC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SicCodeDecription
		{
			get
			{
				return this._sicCodeDecription;
			}
			set
			{
				if (((_sicCodeDecription == value)
							== false))
				{
					this.OnSicCodeDecriptionChanging(value);
					this._sicCodeDecription = value;
					this.OnSicCodeDecriptionChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.NCCI_CODES")]
	public partial class NcciCodes
	{

		private long _accntHrcyStepID;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _ncciCode;

		private long _ncciCodesID;

		private string _ncciDescription;

		private string _sicCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNcciCodeChanged();

		partial void OnNcciCodeChanging(string value);

		partial void OnNcciCodesIdChanged();

		partial void OnNcciCodesIdChanging(long value);

		partial void OnNcciDescriptionChanged();

		partial void OnNcciDescriptionChanging(string value);

		partial void OnSicCodeChanged();

		partial void OnSicCodeChanging(string value);
		#endregion


		public NcciCodes()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_ncciCode", Name = "NCCI_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string NcciCode
		{
			get
			{
				return this._ncciCode;
			}
			set
			{
				if (((_ncciCode == value)
							== false))
				{
					this.OnNcciCodeChanging(value);
					this._ncciCode = value;
					this.OnNcciCodeChanged();
				}
			}
		}

		[Column(Storage = "_ncciCodesID", Name = "NCCI_CODES_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long NcciCodesId
		{
			get
			{
				return this._ncciCodesID;
			}
			set
			{
				if ((_ncciCodesID != value))
				{
					this.OnNcciCodesIdChanging(value);
					this._ncciCodesID = value;
					this.OnNcciCodesIdChanged();
				}
			}
		}

		[Column(Storage = "_ncciDescription", Name = "NCCI_DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string NcciDescription
		{
			get
			{
				return this._ncciDescription;
			}
			set
			{
				if (((_ncciDescription == value)
							== false))
				{
					this.OnNcciDescriptionChanging(value);
					this._ncciDescription = value;
					this.OnNcciDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_sicCode", Name = "SIC_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SicCode
		{
			get
			{
				return this._sicCode;
			}
			set
			{
				if (((_sicCode == value)
							== false))
				{
					this.OnSicCodeChanging(value);
					this._sicCode = value;
					this.OnSicCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.NETWORK")]
	public partial class Network
	{

		private string _description;

		private string _name;

		private long _networkID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnNetworkIdChanged();

		partial void OnNetworkIdChanging(long value);
		#endregion


		public Network()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_networkID", Name = "NETWORK_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long NetworkId
		{
			get
			{
				return this._networkID;
			}
			set
			{
				if ((_networkID != value))
				{
					this.OnNetworkIdChanging(value);
					this._networkID = value;
					this.OnNetworkIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.NIKE_EMPLOYEE")]
	public partial class NikeEmployee
	{

		private long _accntHrcyStepID;

		private string _address1;

		private string _address2;

		private System.Nullable<decimal> _annualSalary;

		private string _city;

		private string _clientNumber;

		private System.Nullable<System.DateTime> _closeDate;

		private string _costCenterID;

		private string _country;

		private System.Nullable<decimal> _dailyWage;

		private System.Nullable<System.DateTime> _dateOfBirth;

		private System.Nullable<System.DateTime> _dateOfHire;

		private System.Nullable<System.DateTime> _dateOfTermination;

		private string _department;

		private System.Nullable<short> _dependents18uNder;

		private string _employeeCode;

		private long _employeeID;

		private string _employmentStatus;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _filingState;

		private string _flsaStatus;

		private string _gender;

		private System.Nullable<decimal> _hourlyWage;

		private string _jobCode;

		private string _jobTitle;

		private string _maritalStatus;

		private System.Nullable<decimal> _monthlyWage;

		private string _nameFirst;

		private string _nameLast;

		private string _nameMiD;

		private string _ncciJobclass;

		private string _paidForOvertimeFlag;

		private string _phone;

		private string _phoneWork;

		private string _reportingUnit;

		private string _specialID;

		private string _ssn;

		private string _state;

		private string _status;

		private string _supervisorEmailAddress;

		private string _supervisorNameFirst;

		private string _supervisorNameLast;

		private string _supervisorPhoneWork;

		private string _telecommuterFlag;

		private string _testFlag;

		private string _title;

		private System.Nullable<short> _totalDependents;

		private string _unionCode;

		private string _uploadKey;

		private string _wageFrequency;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnAnnualSalaryChanged();

		partial void OnAnnualSalaryChanging(System.Nullable<decimal> value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnClientNumberChanged();

		partial void OnClientNumberChanging(string value);

		partial void OnCloseDateChanged();

		partial void OnCloseDateChanging(System.Nullable<System.DateTime> value);

		partial void OnCostCenterIdChanged();

		partial void OnCostCenterIdChanging(string value);

		partial void OnCountryChanged();

		partial void OnCountryChanging(string value);

		partial void OnDailyWageChanged();

		partial void OnDailyWageChanging(System.Nullable<decimal> value);

		partial void OnDateOfBirthChanged();

		partial void OnDateOfBirthChanging(System.Nullable<System.DateTime> value);

		partial void OnDateOfHireChanged();

		partial void OnDateOfHireChanging(System.Nullable<System.DateTime> value);

		partial void OnDateOfTerminationChanged();

		partial void OnDateOfTerminationChanging(System.Nullable<System.DateTime> value);

		partial void OnDepartmentChanged();

		partial void OnDepartmentChanging(string value);

		partial void OnDependents18UnderChanged();

		partial void OnDependents18UnderChanging(System.Nullable<short> value);

		partial void OnEmployeeCodeChanged();

		partial void OnEmployeeCodeChanging(string value);

		partial void OnEmployeeIdChanged();

		partial void OnEmployeeIdChanging(long value);

		partial void OnEmploymentStatusChanged();

		partial void OnEmploymentStatusChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnFilingStateChanged();

		partial void OnFilingStateChanging(string value);

		partial void OnFlsaStatusChanged();

		partial void OnFlsaStatusChanging(string value);

		partial void OnGenderChanged();

		partial void OnGenderChanging(string value);

		partial void OnHourlyWageChanged();

		partial void OnHourlyWageChanging(System.Nullable<decimal> value);

		partial void OnJobCodeChanged();

		partial void OnJobCodeChanging(string value);

		partial void OnJobTitleChanged();

		partial void OnJobTitleChanging(string value);

		partial void OnMaritalStatusChanged();

		partial void OnMaritalStatusChanging(string value);

		partial void OnMonthlyWageChanged();

		partial void OnMonthlyWageChanging(System.Nullable<decimal> value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnNameMIdChanged();

		partial void OnNameMIdChanging(string value);

		partial void OnNcciJobclassChanged();

		partial void OnNcciJobclassChanging(string value);

		partial void OnPaidForOvertimeFlagChanged();

		partial void OnPaidForOvertimeFlagChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnPhoneWorkChanged();

		partial void OnPhoneWorkChanging(string value);

		partial void OnReportingUnitChanged();

		partial void OnReportingUnitChanging(string value);

		partial void OnSpecialIdChanged();

		partial void OnSpecialIdChanging(string value);

		partial void OnSsnChanged();

		partial void OnSsnChanging(string value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnStatusChanged();

		partial void OnStatusChanging(string value);

		partial void OnSupervisorEmailAddressChanged();

		partial void OnSupervisorEmailAddressChanging(string value);

		partial void OnSupervisorNameFirstChanged();

		partial void OnSupervisorNameFirstChanging(string value);

		partial void OnSupervisorNameLastChanged();

		partial void OnSupervisorNameLastChanging(string value);

		partial void OnSupervisorPhoneWorkChanged();

		partial void OnSupervisorPhoneWorkChanging(string value);

		partial void OnTelecommuterFlagChanged();

		partial void OnTelecommuterFlagChanging(string value);

		partial void OnTestFlagChanged();

		partial void OnTestFlagChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnTotalDependentsChanged();

		partial void OnTotalDependentsChanging(System.Nullable<short> value);

		partial void OnUnionCodeChanged();

		partial void OnUnionCodeChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnWageFrequencyChanged();

		partial void OnWageFrequencyChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public NikeEmployee()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_annualSalary", Name = "ANNUAL_SALARY", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> AnnualSalary
		{
			get
			{
				return this._annualSalary;
			}
			set
			{
				if ((_annualSalary != value))
				{
					this.OnAnnualSalaryChanging(value);
					this._annualSalary = value;
					this.OnAnnualSalaryChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_clientNumber", Name = "CLIENT_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ClientNumber
		{
			get
			{
				return this._clientNumber;
			}
			set
			{
				if (((_clientNumber == value)
							== false))
				{
					this.OnClientNumberChanging(value);
					this._clientNumber = value;
					this.OnClientNumberChanged();
				}
			}
		}

		[Column(Storage = "_closeDate", Name = "CLOSE_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CloseDate
		{
			get
			{
				return this._closeDate;
			}
			set
			{
				if ((_closeDate != value))
				{
					this.OnCloseDateChanging(value);
					this._closeDate = value;
					this.OnCloseDateChanged();
				}
			}
		}

		[Column(Storage = "_costCenterID", Name = "COST_CENTER_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CostCenterId
		{
			get
			{
				return this._costCenterID;
			}
			set
			{
				if (((_costCenterID == value)
							== false))
				{
					this.OnCostCenterIdChanging(value);
					this._costCenterID = value;
					this.OnCostCenterIdChanged();
				}
			}
		}

		[Column(Storage = "_country", Name = "COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Country
		{
			get
			{
				return this._country;
			}
			set
			{
				if (((_country == value)
							== false))
				{
					this.OnCountryChanging(value);
					this._country = value;
					this.OnCountryChanged();
				}
			}
		}

		[Column(Storage = "_dailyWage", Name = "DAILY_WAGE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> DailyWage
		{
			get
			{
				return this._dailyWage;
			}
			set
			{
				if ((_dailyWage != value))
				{
					this.OnDailyWageChanging(value);
					this._dailyWage = value;
					this.OnDailyWageChanged();
				}
			}
		}

		[Column(Storage = "_dateOfBirth", Name = "DATE_OF_BIRTH", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._dateOfBirth;
			}
			set
			{
				if ((_dateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this._dateOfBirth = value;
					this.OnDateOfBirthChanged();
				}
			}
		}

		[Column(Storage = "_dateOfHire", Name = "DATE_OF_HIRE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateOfHire
		{
			get
			{
				return this._dateOfHire;
			}
			set
			{
				if ((_dateOfHire != value))
				{
					this.OnDateOfHireChanging(value);
					this._dateOfHire = value;
					this.OnDateOfHireChanged();
				}
			}
		}

		[Column(Storage = "_dateOfTermination", Name = "DATE_OF_TERMINATION", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateOfTermination
		{
			get
			{
				return this._dateOfTermination;
			}
			set
			{
				if ((_dateOfTermination != value))
				{
					this.OnDateOfTerminationChanging(value);
					this._dateOfTermination = value;
					this.OnDateOfTerminationChanged();
				}
			}
		}

		[Column(Storage = "_department", Name = "DEPARTMENT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Department
		{
			get
			{
				return this._department;
			}
			set
			{
				if (((_department == value)
							== false))
				{
					this.OnDepartmentChanging(value);
					this._department = value;
					this.OnDepartmentChanged();
				}
			}
		}

		[Column(Storage = "_dependents18uNder", Name = "DEPENDENTS_18_UNDER", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> Dependents18Under
		{
			get
			{
				return this._dependents18uNder;
			}
			set
			{
				if ((_dependents18uNder != value))
				{
					this.OnDependents18UnderChanging(value);
					this._dependents18uNder = value;
					this.OnDependents18UnderChanged();
				}
			}
		}

		[Column(Storage = "_employeeCode", Name = "EMPLOYEE_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmployeeCode
		{
			get
			{
				return this._employeeCode;
			}
			set
			{
				if (((_employeeCode == value)
							== false))
				{
					this.OnEmployeeCodeChanging(value);
					this._employeeCode = value;
					this.OnEmployeeCodeChanged();
				}
			}
		}

		[Column(Storage = "_employeeID", Name = "EMPLOYEE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long EmployeeId
		{
			get
			{
				return this._employeeID;
			}
			set
			{
				if ((_employeeID != value))
				{
					this.OnEmployeeIdChanging(value);
					this._employeeID = value;
					this.OnEmployeeIdChanged();
				}
			}
		}

		[Column(Storage = "_employmentStatus", Name = "EMPLOYMENT_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmploymentStatus
		{
			get
			{
				return this._employmentStatus;
			}
			set
			{
				if (((_employmentStatus == value)
							== false))
				{
					this.OnEmploymentStatusChanging(value);
					this._employmentStatus = value;
					this.OnEmploymentStatusChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_filingState", Name = "FILING_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FilingState
		{
			get
			{
				return this._filingState;
			}
			set
			{
				if (((_filingState == value)
							== false))
				{
					this.OnFilingStateChanging(value);
					this._filingState = value;
					this.OnFilingStateChanged();
				}
			}
		}

		[Column(Storage = "_flsaStatus", Name = "FLSA_STATUS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FlsaStatus
		{
			get
			{
				return this._flsaStatus;
			}
			set
			{
				if (((_flsaStatus == value)
							== false))
				{
					this.OnFlsaStatusChanging(value);
					this._flsaStatus = value;
					this.OnFlsaStatusChanged();
				}
			}
		}

		[Column(Storage = "_gender", Name = "GENDER", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if (((_gender == value)
							== false))
				{
					this.OnGenderChanging(value);
					this._gender = value;
					this.OnGenderChanged();
				}
			}
		}

		[Column(Storage = "_hourlyWage", Name = "HOURLY_WAGE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> HourlyWage
		{
			get
			{
				return this._hourlyWage;
			}
			set
			{
				if ((_hourlyWage != value))
				{
					this.OnHourlyWageChanging(value);
					this._hourlyWage = value;
					this.OnHourlyWageChanged();
				}
			}
		}

		[Column(Storage = "_jobCode", Name = "JOB_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string JobCode
		{
			get
			{
				return this._jobCode;
			}
			set
			{
				if (((_jobCode == value)
							== false))
				{
					this.OnJobCodeChanging(value);
					this._jobCode = value;
					this.OnJobCodeChanged();
				}
			}
		}

		[Column(Storage = "_jobTitle", Name = "JOB_TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string JobTitle
		{
			get
			{
				return this._jobTitle;
			}
			set
			{
				if (((_jobTitle == value)
							== false))
				{
					this.OnJobTitleChanging(value);
					this._jobTitle = value;
					this.OnJobTitleChanged();
				}
			}
		}

		[Column(Storage = "_maritalStatus", Name = "MARITAL_STATUS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MaritalStatus
		{
			get
			{
				return this._maritalStatus;
			}
			set
			{
				if (((_maritalStatus == value)
							== false))
				{
					this.OnMaritalStatusChanging(value);
					this._maritalStatus = value;
					this.OnMaritalStatusChanged();
				}
			}
		}

		[Column(Storage = "_monthlyWage", Name = "MONTHLY_WAGE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> MonthlyWage
		{
			get
			{
				return this._monthlyWage;
			}
			set
			{
				if ((_monthlyWage != value))
				{
					this.OnMonthlyWageChanging(value);
					this._monthlyWage = value;
					this.OnMonthlyWageChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_nameMiD", Name = "NAME_MID", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameMId
		{
			get
			{
				return this._nameMiD;
			}
			set
			{
				if (((_nameMiD == value)
							== false))
				{
					this.OnNameMIdChanging(value);
					this._nameMiD = value;
					this.OnNameMIdChanged();
				}
			}
		}

		[Column(Storage = "_ncciJobclass", Name = "NCCI_JOBCLASS", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NcciJobclass
		{
			get
			{
				return this._ncciJobclass;
			}
			set
			{
				if (((_ncciJobclass == value)
							== false))
				{
					this.OnNcciJobclassChanging(value);
					this._ncciJobclass = value;
					this.OnNcciJobclassChanged();
				}
			}
		}

		[Column(Storage = "_paidForOvertimeFlag", Name = "PAID_FOR_OVERTIME_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PaidForOvertimeFlag
		{
			get
			{
				return this._paidForOvertimeFlag;
			}
			set
			{
				if (((_paidForOvertimeFlag == value)
							== false))
				{
					this.OnPaidForOvertimeFlagChanging(value);
					this._paidForOvertimeFlag = value;
					this.OnPaidForOvertimeFlagChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_phoneWork", Name = "PHONE_WORK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneWork
		{
			get
			{
				return this._phoneWork;
			}
			set
			{
				if (((_phoneWork == value)
							== false))
				{
					this.OnPhoneWorkChanging(value);
					this._phoneWork = value;
					this.OnPhoneWorkChanged();
				}
			}
		}

		[Column(Storage = "_reportingUnit", Name = "REPORTING_UNIT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReportingUnit
		{
			get
			{
				return this._reportingUnit;
			}
			set
			{
				if (((_reportingUnit == value)
							== false))
				{
					this.OnReportingUnitChanging(value);
					this._reportingUnit = value;
					this.OnReportingUnitChanged();
				}
			}
		}

		[Column(Storage = "_specialID", Name = "SPECIAL_ID", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SpecialId
		{
			get
			{
				return this._specialID;
			}
			set
			{
				if (((_specialID == value)
							== false))
				{
					this.OnSpecialIdChanging(value);
					this._specialID = value;
					this.OnSpecialIdChanged();
				}
			}
		}

		[Column(Storage = "_ssn", Name = "SSN", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Ssn
		{
			get
			{
				return this._ssn;
			}
			set
			{
				if (((_ssn == value)
							== false))
				{
					this.OnSsnChanging(value);
					this._ssn = value;
					this.OnSsnChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_status", Name = "STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (((_status == value)
							== false))
				{
					this.OnStatusChanging(value);
					this._status = value;
					this.OnStatusChanged();
				}
			}
		}

		[Column(Storage = "_supervisorEmailAddress", Name = "SUPERVISOR_EMAIL_ADDRESS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorEmailAddress
		{
			get
			{
				return this._supervisorEmailAddress;
			}
			set
			{
				if (((_supervisorEmailAddress == value)
							== false))
				{
					this.OnSupervisorEmailAddressChanging(value);
					this._supervisorEmailAddress = value;
					this.OnSupervisorEmailAddressChanged();
				}
			}
		}

		[Column(Storage = "_supervisorNameFirst", Name = "SUPERVISOR_NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorNameFirst
		{
			get
			{
				return this._supervisorNameFirst;
			}
			set
			{
				if (((_supervisorNameFirst == value)
							== false))
				{
					this.OnSupervisorNameFirstChanging(value);
					this._supervisorNameFirst = value;
					this.OnSupervisorNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_supervisorNameLast", Name = "SUPERVISOR_NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorNameLast
		{
			get
			{
				return this._supervisorNameLast;
			}
			set
			{
				if (((_supervisorNameLast == value)
							== false))
				{
					this.OnSupervisorNameLastChanging(value);
					this._supervisorNameLast = value;
					this.OnSupervisorNameLastChanged();
				}
			}
		}

		[Column(Storage = "_supervisorPhoneWork", Name = "SUPERVISOR_PHONE_WORK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SupervisorPhoneWork
		{
			get
			{
				return this._supervisorPhoneWork;
			}
			set
			{
				if (((_supervisorPhoneWork == value)
							== false))
				{
					this.OnSupervisorPhoneWorkChanging(value);
					this._supervisorPhoneWork = value;
					this.OnSupervisorPhoneWorkChanged();
				}
			}
		}

		[Column(Storage = "_telecommuterFlag", Name = "TELECOMMUTER_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TelecommuterFlag
		{
			get
			{
				return this._telecommuterFlag;
			}
			set
			{
				if (((_telecommuterFlag == value)
							== false))
				{
					this.OnTelecommuterFlagChanging(value);
					this._telecommuterFlag = value;
					this.OnTelecommuterFlagChanged();
				}
			}
		}

		[Column(Storage = "_testFlag", Name = "TEST_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string TestFlag
		{
			get
			{
				return this._testFlag;
			}
			set
			{
				if (((_testFlag == value)
							== false))
				{
					this.OnTestFlagChanging(value);
					this._testFlag = value;
					this.OnTestFlagChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_totalDependents", Name = "TOTAL_DEPENDENTS", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<short> TotalDependents
		{
			get
			{
				return this._totalDependents;
			}
			set
			{
				if ((_totalDependents != value))
				{
					this.OnTotalDependentsChanging(value);
					this._totalDependents = value;
					this.OnTotalDependentsChanged();
				}
			}
		}

		[Column(Storage = "_unionCode", Name = "UNION_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UnionCode
		{
			get
			{
				return this._unionCode;
			}
			set
			{
				if (((_unionCode == value)
							== false))
				{
					this.OnUnionCodeChanging(value);
					this._unionCode = value;
					this.OnUnionCodeChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_wageFrequency", Name = "WAGE_FREQUENCY", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string WageFrequency
		{
			get
			{
				return this._wageFrequency;
			}
			set
			{
				if (((_wageFrequency == value)
							== false))
				{
					this.OnWageFrequencyChanging(value);
					this._wageFrequency = value;
					this.OnWageFrequencyChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.NODE_TYPE")]
	public partial class NodeType
	{

		private string _name;

		private long _nodeTypeID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnNodeTypeIdChanged();

		partial void OnNodeTypeIdChanging(long value);
		#endregion


		public NodeType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_nodeTypeID", Name = "NODE_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long NodeTypeId
		{
			get
			{
				return this._nodeTypeID;
			}
			set
			{
				if ((_nodeTypeID != value))
				{
					this.OnNodeTypeIdChanging(value);
					this._nodeTypeID = value;
					this.OnNodeTypeIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_DEFINITION")]
	public partial class OutputDefinition
	{

		private string _description;

		private string _duplexPrintFlag;

		private string _name;

		private long _outputdefID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnDuplexPrintFlagChanged();

		partial void OnDuplexPrintFlagChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnOutputdefIdChanged();

		partial void OnOutputdefIdChanging(long value);
		#endregion


		public OutputDefinition()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_duplexPrintFlag", Name = "DUPLEX_PRINT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string DuplexPrintFlag
		{
			get
			{
				return this._duplexPrintFlag;
			}
			set
			{
				if (((_duplexPrintFlag == value)
							== false))
				{
					this.OnDuplexPrintFlagChanging(value);
					this._duplexPrintFlag = value;
					this.OnDuplexPrintFlagChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_outputdefID", Name = "OUTPUTDEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputdefId
		{
			get
			{
				return this._outputdefID;
			}
			set
			{
				if ((_outputdefID != value))
				{
					this.OnOutputdefIdChanging(value);
					this._outputdefID = value;
					this.OnOutputdefIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_FIELD")]
	public partial class OutputField
	{

		private string _bmp;

		private string _boldFlag;

		private string _fontName;

		private System.Nullable<long> _fontSize;

		private long _height;

		private string _italicFlag;

		private string _mapping;

		private string _multilineFlag;

		private string _name;

		private long _outputFldID;

		private long _outputPageID;

		private string _strikeoutFlag;

		private string _underlineFlag;

		private long _width;

		private long _xpos;

		private long _ypos;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBmpChanged();

		partial void OnBmpChanging(string value);

		partial void OnBoldFlagChanged();

		partial void OnBoldFlagChanging(string value);

		partial void OnFontNameChanged();

		partial void OnFontNameChanging(string value);

		partial void OnFontSizeChanged();

		partial void OnFontSizeChanging(System.Nullable<long> value);

		partial void OnHeightChanged();

		partial void OnHeightChanging(long value);

		partial void OnItalicFlagChanged();

		partial void OnItalicFlagChanging(string value);

		partial void OnMappingChanged();

		partial void OnMappingChanging(string value);

		partial void OnMultilineFlagChanged();

		partial void OnMultilineFlagChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnOutputFldIdChanged();

		partial void OnOutputFldIdChanging(long value);

		partial void OnOutputPageIdChanged();

		partial void OnOutputPageIdChanging(long value);

		partial void OnStrikeoutFlagChanged();

		partial void OnStrikeoutFlagChanging(string value);

		partial void OnUnderlineFlagChanged();

		partial void OnUnderlineFlagChanging(string value);

		partial void OnWidthChanged();

		partial void OnWidthChanging(long value);

		partial void OnXposChanged();

		partial void OnXposChanging(long value);

		partial void OnYposChanged();

		partial void OnYposChanging(long value);
		#endregion


		public OutputField()
		{
			this.OnCreated();
		}

		[Column(Storage = "_bmp", Name = "BMP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Bmp
		{
			get
			{
				return this._bmp;
			}
			set
			{
				if (((_bmp == value)
							== false))
				{
					this.OnBmpChanging(value);
					this._bmp = value;
					this.OnBmpChanged();
				}
			}
		}

		[Column(Storage = "_boldFlag", Name = "BOLD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string BoldFlag
		{
			get
			{
				return this._boldFlag;
			}
			set
			{
				if (((_boldFlag == value)
							== false))
				{
					this.OnBoldFlagChanging(value);
					this._boldFlag = value;
					this.OnBoldFlagChanged();
				}
			}
		}

		[Column(Storage = "_fontName", Name = "FONT_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FontName
		{
			get
			{
				return this._fontName;
			}
			set
			{
				if (((_fontName == value)
							== false))
				{
					this.OnFontNameChanging(value);
					this._fontName = value;
					this.OnFontNameChanged();
				}
			}
		}

		[Column(Storage = "_fontSize", Name = "FONT_SIZE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FontSize
		{
			get
			{
				return this._fontSize;
			}
			set
			{
				if ((_fontSize != value))
				{
					this.OnFontSizeChanging(value);
					this._fontSize = value;
					this.OnFontSizeChanged();
				}
			}
		}

		[Column(Storage = "_height", Name = "HEIGHT", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Height
		{
			get
			{
				return this._height;
			}
			set
			{
				if ((_height != value))
				{
					this.OnHeightChanging(value);
					this._height = value;
					this.OnHeightChanged();
				}
			}
		}

		[Column(Storage = "_italicFlag", Name = "ITALIC_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ItalicFlag
		{
			get
			{
				return this._italicFlag;
			}
			set
			{
				if (((_italicFlag == value)
							== false))
				{
					this.OnItalicFlagChanging(value);
					this._italicFlag = value;
					this.OnItalicFlagChanged();
				}
			}
		}

		[Column(Storage = "_mapping", Name = "MAPPING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Mapping
		{
			get
			{
				return this._mapping;
			}
			set
			{
				if (((_mapping == value)
							== false))
				{
					this.OnMappingChanging(value);
					this._mapping = value;
					this.OnMappingChanged();
				}
			}
		}

		[Column(Storage = "_multilineFlag", Name = "MULTILINE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string MultilineFlag
		{
			get
			{
				return this._multilineFlag;
			}
			set
			{
				if (((_multilineFlag == value)
							== false))
				{
					this.OnMultilineFlagChanging(value);
					this._multilineFlag = value;
					this.OnMultilineFlagChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_outputFldID", Name = "OUTPUT_FLD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputFldId
		{
			get
			{
				return this._outputFldID;
			}
			set
			{
				if ((_outputFldID != value))
				{
					this.OnOutputFldIdChanging(value);
					this._outputFldID = value;
					this.OnOutputFldIdChanged();
				}
			}
		}

		[Column(Storage = "_outputPageID", Name = "OUTPUT_PAGE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputPageId
		{
			get
			{
				return this._outputPageID;
			}
			set
			{
				if ((_outputPageID != value))
				{
					this.OnOutputPageIdChanging(value);
					this._outputPageID = value;
					this.OnOutputPageIdChanged();
				}
			}
		}

		[Column(Storage = "_strikeoutFlag", Name = "STRIKEOUT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string StrikeoutFlag
		{
			get
			{
				return this._strikeoutFlag;
			}
			set
			{
				if (((_strikeoutFlag == value)
							== false))
				{
					this.OnStrikeoutFlagChanging(value);
					this._strikeoutFlag = value;
					this.OnStrikeoutFlagChanged();
				}
			}
		}

		[Column(Storage = "_underlineFlag", Name = "UNDERLINE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string UnderlineFlag
		{
			get
			{
				return this._underlineFlag;
			}
			set
			{
				if (((_underlineFlag == value)
							== false))
				{
					this.OnUnderlineFlagChanging(value);
					this._underlineFlag = value;
					this.OnUnderlineFlagChanged();
				}
			}
		}

		[Column(Storage = "_width", Name = "WIDTH", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Width
		{
			get
			{
				return this._width;
			}
			set
			{
				if ((_width != value))
				{
					this.OnWidthChanging(value);
					this._width = value;
					this.OnWidthChanged();
				}
			}
		}

		[Column(Storage = "_xpos", Name = "XPOS", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Xpos
		{
			get
			{
				return this._xpos;
			}
			set
			{
				if ((_xpos != value))
				{
					this.OnXposChanging(value);
					this._xpos = value;
					this.OnXposChanged();
				}
			}
		}

		[Column(Storage = "_ypos", Name = "YPOS", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Ypos
		{
			get
			{
				return this._ypos;
			}
			set
			{
				if ((_ypos != value))
				{
					this.OnYposChanging(value);
					this._ypos = value;
					this.OnYposChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_FILE")]
	public partial class OutputFile
	{

		private System.Nullable<long> _enableRuleID;

		private long _outputdefID;

		private string _outputFileFormat;

		private long _outputFileID;

		private string _outputFileName;

		private string _reportFileName;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnEnableRuleIdChanged();

		partial void OnEnableRuleIdChanging(System.Nullable<long> value);

		partial void OnOutputdefIdChanged();

		partial void OnOutputdefIdChanging(long value);

		partial void OnOutputFileFormatChanged();

		partial void OnOutputFileFormatChanging(string value);

		partial void OnOutputFileIdChanged();

		partial void OnOutputFileIdChanging(long value);

		partial void OnOutputFileNameChanged();

		partial void OnOutputFileNameChanging(string value);

		partial void OnReportFileNameChanged();

		partial void OnReportFileNameChanging(string value);
		#endregion


		public OutputFile()
		{
			this.OnCreated();
		}

		[Column(Storage = "_enableRuleID", Name = "ENABLE_RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnableRuleId
		{
			get
			{
				return this._enableRuleID;
			}
			set
			{
				if ((_enableRuleID != value))
				{
					this.OnEnableRuleIdChanging(value);
					this._enableRuleID = value;
					this.OnEnableRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_outputdefID", Name = "OUTPUTDEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputdefId
		{
			get
			{
				return this._outputdefID;
			}
			set
			{
				if ((_outputdefID != value))
				{
					this.OnOutputdefIdChanging(value);
					this._outputdefID = value;
					this.OnOutputdefIdChanged();
				}
			}
		}

		[Column(Storage = "_outputFileFormat", Name = "OUTPUT_FILE_FORMAT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OutputFileFormat
		{
			get
			{
				return this._outputFileFormat;
			}
			set
			{
				if (((_outputFileFormat == value)
							== false))
				{
					this.OnOutputFileFormatChanging(value);
					this._outputFileFormat = value;
					this.OnOutputFileFormatChanged();
				}
			}
		}

		[Column(Storage = "_outputFileID", Name = "OUTPUT_FILE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputFileId
		{
			get
			{
				return this._outputFileID;
			}
			set
			{
				if ((_outputFileID != value))
				{
					this.OnOutputFileIdChanging(value);
					this._outputFileID = value;
					this.OnOutputFileIdChanged();
				}
			}
		}

		[Column(Storage = "_outputFileName", Name = "OUTPUT_FILE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OutputFileName
		{
			get
			{
				return this._outputFileName;
			}
			set
			{
				if (((_outputFileName == value)
							== false))
				{
					this.OnOutputFileNameChanging(value);
					this._outputFileName = value;
					this.OnOutputFileNameChanged();
				}
			}
		}

		[Column(Storage = "_reportFileName", Name = "REPORT_FILE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReportFileName
		{
			get
			{
				return this._reportFileName;
			}
			set
			{
				if (((_reportFileName == value)
							== false))
				{
					this.OnReportFileNameChanging(value);
					this._reportFileName = value;
					this.OnReportFileNameChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_FILENAME")]
	public partial class OutputFilename
	{

		private string _description;

		private long _outputFilenameID;

		private long _ruleID;

		private long _transmissionSeqStepID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnOutputFilenameIdChanged();

		partial void OnOutputFilenameIdChanging(long value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(long value);

		partial void OnTransmissionSeqStepIdChanged();

		partial void OnTransmissionSeqStepIdChanging(long value);
		#endregion


		public OutputFilename()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_outputFilenameID", Name = "OUTPUT_FILENAME_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputFilenameId
		{
			get
			{
				return this._outputFilenameID;
			}
			set
			{
				if ((_outputFilenameID != value))
				{
					this.OnOutputFilenameIdChanging(value);
					this._outputFilenameID = value;
					this.OnOutputFilenameIdChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_transmissionSeqStepID", Name = "TRANSMISSION_SEQ_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long TransmissionSeqStepId
		{
			get
			{
				return this._transmissionSeqStepID;
			}
			set
			{
				if ((_transmissionSeqStepID != value))
				{
					this.OnTransmissionSeqStepIdChanging(value);
					this._transmissionSeqStepID = value;
					this.OnTransmissionSeqStepIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_FILTER")]
	public partial class OutputFilter
	{

		private long _outputFilterGroupID;

		private long _outputFilterID;

		private string _rule;

		private string _target;

		private string _value;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnOutputFilterGroupIdChanged();

		partial void OnOutputFilterGroupIdChanging(long value);

		partial void OnOutputFilterIdChanged();

		partial void OnOutputFilterIdChanging(long value);

		partial void OnRuleChanged();

		partial void OnRuleChanging(string value);

		partial void OnTargetChanged();

		partial void OnTargetChanging(string value);

		partial void OnValueChanged();

		partial void OnValueChanging(string value);
		#endregion


		public OutputFilter()
		{
			this.OnCreated();
		}

		[Column(Storage = "_outputFilterGroupID", Name = "OUTPUT_FILTER_GROUP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputFilterGroupId
		{
			get
			{
				return this._outputFilterGroupID;
			}
			set
			{
				if ((_outputFilterGroupID != value))
				{
					this.OnOutputFilterGroupIdChanging(value);
					this._outputFilterGroupID = value;
					this.OnOutputFilterGroupIdChanged();
				}
			}
		}

		[Column(Storage = "_outputFilterID", Name = "OUTPUT_FILTER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputFilterId
		{
			get
			{
				return this._outputFilterID;
			}
			set
			{
				if ((_outputFilterID != value))
				{
					this.OnOutputFilterIdChanging(value);
					this._outputFilterID = value;
					this.OnOutputFilterIdChanged();
				}
			}
		}

		[Column(Storage = "_rule", Name = "RULE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Rule
		{
			get
			{
				return this._rule;
			}
			set
			{
				if (((_rule == value)
							== false))
				{
					this.OnRuleChanging(value);
					this._rule = value;
					this.OnRuleChanged();
				}
			}
		}

		[Column(Storage = "_target", Name = "TARGET", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Target
		{
			get
			{
				return this._target;
			}
			set
			{
				if (((_target == value)
							== false))
				{
					this.OnTargetChanging(value);
					this._target = value;
					this.OnTargetChanged();
				}
			}
		}

		[Column(Storage = "_value", Name = "VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (((_value == value)
							== false))
				{
					this.OnValueChanging(value);
					this._value = value;
					this.OnValueChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_FILTER_GROUP")]
	public partial class OutputFilterGroup
	{

		private string _description;

		private string _groupName;

		private long _outputFilterGroupID;

		private System.Nullable<long> _ruleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnGroupNameChanged();

		partial void OnGroupNameChanging(string value);

		partial void OnOutputFilterGroupIdChanged();

		partial void OnOutputFilterGroupIdChanging(long value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);
		#endregion


		public OutputFilterGroup()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_groupName", Name = "GROUP_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string GroupName
		{
			get
			{
				return this._groupName;
			}
			set
			{
				if (((_groupName == value)
							== false))
				{
					this.OnGroupNameChanging(value);
					this._groupName = value;
					this.OnGroupNameChanged();
				}
			}
		}

		[Column(Storage = "_outputFilterGroupID", Name = "OUTPUT_FILTER_GROUP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputFilterGroupId
		{
			get
			{
				return this._outputFilterGroupID;
			}
			set
			{
				if ((_outputFilterGroupID != value))
				{
					this.OnOutputFilterGroupIdChanging(value);
					this._outputFilterGroupID = value;
					this.OnOutputFilterGroupIdChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_ITEM")]
	public partial class OutputItem
	{

		private long _outputdefID;

		private long _outputItemID;

		private System.Nullable<long> _ruleID;

		private System.Nullable<long> _sequence;

		private long _transmissionSeqStepID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnOutputdefIdChanged();

		partial void OnOutputdefIdChanging(long value);

		partial void OnOutputItemIdChanged();

		partial void OnOutputItemIdChanging(long value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(System.Nullable<long> value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<long> value);

		partial void OnTransmissionSeqStepIdChanged();

		partial void OnTransmissionSeqStepIdChanging(long value);
		#endregion


		public OutputItem()
		{
			this.OnCreated();
		}

		[Column(Storage = "_outputdefID", Name = "OUTPUTDEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputdefId
		{
			get
			{
				return this._outputdefID;
			}
			set
			{
				if ((_outputdefID != value))
				{
					this.OnOutputdefIdChanging(value);
					this._outputdefID = value;
					this.OnOutputdefIdChanged();
				}
			}
		}

		[Column(Storage = "_outputItemID", Name = "OUTPUT_ITEM_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputItemId
		{
			get
			{
				return this._outputItemID;
			}
			set
			{
				if ((_outputItemID != value))
				{
					this.OnOutputItemIdChanging(value);
					this._outputItemID = value;
					this.OnOutputItemIdChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_transmissionSeqStepID", Name = "TRANSMISSION_SEQ_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long TransmissionSeqStepId
		{
			get
			{
				return this._transmissionSeqStepID;
			}
			set
			{
				if ((_transmissionSeqStepID != value))
				{
					this.OnTransmissionSeqStepIdChanging(value);
					this._transmissionSeqStepID = value;
					this.OnTransmissionSeqStepIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_MAPPING")]
	public partial class OutputMapping
	{

		private long _accntHrcyStepID;

		private string _bmp;

		private string _boldFlag;

		private string _fontName;

		private System.Nullable<long> _fontSize;

		private long _height;

		private string _italicFlag;

		private string _mapping;

		private string _multilineFlag;

		private string _name;

		private long _outputFldID;

		private long _outputMappingID;

		private string _strikeoutFlag;

		private string _underlineFlag;

		private long _width;

		private long _xpos;

		private long _ypos;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnBmpChanged();

		partial void OnBmpChanging(string value);

		partial void OnBoldFlagChanged();

		partial void OnBoldFlagChanging(string value);

		partial void OnFontNameChanged();

		partial void OnFontNameChanging(string value);

		partial void OnFontSizeChanged();

		partial void OnFontSizeChanging(System.Nullable<long> value);

		partial void OnHeightChanged();

		partial void OnHeightChanging(long value);

		partial void OnItalicFlagChanged();

		partial void OnItalicFlagChanging(string value);

		partial void OnMappingChanged();

		partial void OnMappingChanging(string value);

		partial void OnMultilineFlagChanged();

		partial void OnMultilineFlagChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnOutputFldIdChanged();

		partial void OnOutputFldIdChanging(long value);

		partial void OnOutputMappingIdChanged();

		partial void OnOutputMappingIdChanging(long value);

		partial void OnStrikeoutFlagChanged();

		partial void OnStrikeoutFlagChanging(string value);

		partial void OnUnderlineFlagChanged();

		partial void OnUnderlineFlagChanging(string value);

		partial void OnWidthChanged();

		partial void OnWidthChanging(long value);

		partial void OnXposChanged();

		partial void OnXposChanging(long value);

		partial void OnYposChanged();

		partial void OnYposChanging(long value);
		#endregion


		public OutputMapping()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_bmp", Name = "BMP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Bmp
		{
			get
			{
				return this._bmp;
			}
			set
			{
				if (((_bmp == value)
							== false))
				{
					this.OnBmpChanging(value);
					this._bmp = value;
					this.OnBmpChanged();
				}
			}
		}

		[Column(Storage = "_boldFlag", Name = "BOLD_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string BoldFlag
		{
			get
			{
				return this._boldFlag;
			}
			set
			{
				if (((_boldFlag == value)
							== false))
				{
					this.OnBoldFlagChanging(value);
					this._boldFlag = value;
					this.OnBoldFlagChanged();
				}
			}
		}

		[Column(Storage = "_fontName", Name = "FONT_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FontName
		{
			get
			{
				return this._fontName;
			}
			set
			{
				if (((_fontName == value)
							== false))
				{
					this.OnFontNameChanging(value);
					this._fontName = value;
					this.OnFontNameChanged();
				}
			}
		}

		[Column(Storage = "_fontSize", Name = "FONT_SIZE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FontSize
		{
			get
			{
				return this._fontSize;
			}
			set
			{
				if ((_fontSize != value))
				{
					this.OnFontSizeChanging(value);
					this._fontSize = value;
					this.OnFontSizeChanged();
				}
			}
		}

		[Column(Storage = "_height", Name = "HEIGHT", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Height
		{
			get
			{
				return this._height;
			}
			set
			{
				if ((_height != value))
				{
					this.OnHeightChanging(value);
					this._height = value;
					this.OnHeightChanged();
				}
			}
		}

		[Column(Storage = "_italicFlag", Name = "ITALIC_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ItalicFlag
		{
			get
			{
				return this._italicFlag;
			}
			set
			{
				if (((_italicFlag == value)
							== false))
				{
					this.OnItalicFlagChanging(value);
					this._italicFlag = value;
					this.OnItalicFlagChanged();
				}
			}
		}

		[Column(Storage = "_mapping", Name = "MAPPING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Mapping
		{
			get
			{
				return this._mapping;
			}
			set
			{
				if (((_mapping == value)
							== false))
				{
					this.OnMappingChanging(value);
					this._mapping = value;
					this.OnMappingChanged();
				}
			}
		}

		[Column(Storage = "_multilineFlag", Name = "MULTILINE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string MultilineFlag
		{
			get
			{
				return this._multilineFlag;
			}
			set
			{
				if (((_multilineFlag == value)
							== false))
				{
					this.OnMultilineFlagChanging(value);
					this._multilineFlag = value;
					this.OnMultilineFlagChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_outputFldID", Name = "OUTPUT_FLD_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputFldId
		{
			get
			{
				return this._outputFldID;
			}
			set
			{
				if ((_outputFldID != value))
				{
					this.OnOutputFldIdChanging(value);
					this._outputFldID = value;
					this.OnOutputFldIdChanged();
				}
			}
		}

		[Column(Storage = "_outputMappingID", Name = "OUTPUT_MAPPING_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputMappingId
		{
			get
			{
				return this._outputMappingID;
			}
			set
			{
				if ((_outputMappingID != value))
				{
					this.OnOutputMappingIdChanging(value);
					this._outputMappingID = value;
					this.OnOutputMappingIdChanged();
				}
			}
		}

		[Column(Storage = "_strikeoutFlag", Name = "STRIKEOUT_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string StrikeoutFlag
		{
			get
			{
				return this._strikeoutFlag;
			}
			set
			{
				if (((_strikeoutFlag == value)
							== false))
				{
					this.OnStrikeoutFlagChanging(value);
					this._strikeoutFlag = value;
					this.OnStrikeoutFlagChanged();
				}
			}
		}

		[Column(Storage = "_underlineFlag", Name = "UNDERLINE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string UnderlineFlag
		{
			get
			{
				return this._underlineFlag;
			}
			set
			{
				if (((_underlineFlag == value)
							== false))
				{
					this.OnUnderlineFlagChanging(value);
					this._underlineFlag = value;
					this.OnUnderlineFlagChanged();
				}
			}
		}

		[Column(Storage = "_width", Name = "WIDTH", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Width
		{
			get
			{
				return this._width;
			}
			set
			{
				if ((_width != value))
				{
					this.OnWidthChanging(value);
					this._width = value;
					this.OnWidthChanged();
				}
			}
		}

		[Column(Storage = "_xpos", Name = "XPOS", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Xpos
		{
			get
			{
				return this._xpos;
			}
			set
			{
				if ((_xpos != value))
				{
					this.OnXposChanging(value);
					this._xpos = value;
					this.OnXposChanged();
				}
			}
		}

		[Column(Storage = "_ypos", Name = "YPOS", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Ypos
		{
			get
			{
				return this._ypos;
			}
			set
			{
				if ((_ypos != value))
				{
					this.OnYposChanging(value);
					this._ypos = value;
					this.OnYposChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_OVERFLOW")]
	public partial class OutputOverflow
	{

		private long _accntHrcyStepID;

		private string _attributeName;

		private string _caption;

		private System.Nullable<long> _captionLength;

		private string _lobCode;

		private string _mapping;

		private long _outputOverflowID;

		private long _sequence;

		private string _showWhenEmptyFlag;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAttributeNameChanged();

		partial void OnAttributeNameChanging(string value);

		partial void OnCaptionChanged();

		partial void OnCaptionChanging(string value);

		partial void OnCaptionLengthChanged();

		partial void OnCaptionLengthChanging(System.Nullable<long> value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnMappingChanged();

		partial void OnMappingChanging(string value);

		partial void OnOutputOverflowIdChanged();

		partial void OnOutputOverflowIdChanging(long value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);

		partial void OnShowWhenEmptyFlagChanged();

		partial void OnShowWhenEmptyFlagChanging(string value);
		#endregion


		public OutputOverflow()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_attributeName", Name = "ATTRIBUTE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				if (((_attributeName == value)
							== false))
				{
					this.OnAttributeNameChanging(value);
					this._attributeName = value;
					this.OnAttributeNameChanged();
				}
			}
		}

		[Column(Storage = "_caption", Name = "CAPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Caption
		{
			get
			{
				return this._caption;
			}
			set
			{
				if (((_caption == value)
							== false))
				{
					this.OnCaptionChanging(value);
					this._caption = value;
					this.OnCaptionChanged();
				}
			}
		}

		[Column(Storage = "_captionLength", Name = "CAPTION_LENGTH", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CaptionLength
		{
			get
			{
				return this._captionLength;
			}
			set
			{
				if ((_captionLength != value))
				{
					this.OnCaptionLengthChanging(value);
					this._captionLength = value;
					this.OnCaptionLengthChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_mapping", Name = "MAPPING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Mapping
		{
			get
			{
				return this._mapping;
			}
			set
			{
				if (((_mapping == value)
							== false))
				{
					this.OnMappingChanging(value);
					this._mapping = value;
					this.OnMappingChanged();
				}
			}
		}

		[Column(Storage = "_outputOverflowID", Name = "OUTPUT_OVERFLOW_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputOverflowId
		{
			get
			{
				return this._outputOverflowID;
			}
			set
			{
				if ((_outputOverflowID != value))
				{
					this.OnOutputOverflowIdChanging(value);
					this._outputOverflowID = value;
					this.OnOutputOverflowIdChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_showWhenEmptyFlag", Name = "SHOW_WHEN_EMPTY_FLAG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ShowWhenEmptyFlag
		{
			get
			{
				return this._showWhenEmptyFlag;
			}
			set
			{
				if (((_showWhenEmptyFlag == value)
							== false))
				{
					this.OnShowWhenEmptyFlagChanging(value);
					this._showWhenEmptyFlag = value;
					this.OnShowWhenEmptyFlagChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_PAGE")]
	public partial class OutputPage
	{

		private string _backgroundBmp;

		private string _name;

		private string _orientation;

		private long _outputdefID;

		private long _outputPageID;

		private string _outputTray;

		private long _pageNumber;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBackgroundBmpChanged();

		partial void OnBackgroundBmpChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnOrientationChanged();

		partial void OnOrientationChanging(string value);

		partial void OnOutputdefIdChanged();

		partial void OnOutputdefIdChanging(long value);

		partial void OnOutputPageIdChanged();

		partial void OnOutputPageIdChanging(long value);

		partial void OnOutputTrayChanged();

		partial void OnOutputTrayChanging(string value);

		partial void OnPageNumberChanged();

		partial void OnPageNumberChanging(long value);
		#endregion


		public OutputPage()
		{
			this.OnCreated();
		}

		[Column(Storage = "_backgroundBmp", Name = "BACKGROUND_BMP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BackgroundBmp
		{
			get
			{
				return this._backgroundBmp;
			}
			set
			{
				if (((_backgroundBmp == value)
							== false))
				{
					this.OnBackgroundBmpChanging(value);
					this._backgroundBmp = value;
					this.OnBackgroundBmpChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_orientation", Name = "ORIENTATION", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Orientation
		{
			get
			{
				return this._orientation;
			}
			set
			{
				if (((_orientation == value)
							== false))
				{
					this.OnOrientationChanging(value);
					this._orientation = value;
					this.OnOrientationChanged();
				}
			}
		}

		[Column(Storage = "_outputdefID", Name = "OUTPUTDEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputdefId
		{
			get
			{
				return this._outputdefID;
			}
			set
			{
				if ((_outputdefID != value))
				{
					this.OnOutputdefIdChanging(value);
					this._outputdefID = value;
					this.OnOutputdefIdChanged();
				}
			}
		}

		[Column(Storage = "_outputPageID", Name = "OUTPUT_PAGE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputPageId
		{
			get
			{
				return this._outputPageID;
			}
			set
			{
				if ((_outputPageID != value))
				{
					this.OnOutputPageIdChanging(value);
					this._outputPageID = value;
					this.OnOutputPageIdChanged();
				}
			}
		}

		[Column(Storage = "_outputTray", Name = "OUTPUT_TRAY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string OutputTray
		{
			get
			{
				return this._outputTray;
			}
			set
			{
				if (((_outputTray == value)
							== false))
				{
					this.OnOutputTrayChanging(value);
					this._outputTray = value;
					this.OnOutputTrayChanged();
				}
			}
		}

		[Column(Storage = "_pageNumber", Name = "PAGE_NUMBER", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long PageNumber
		{
			get
			{
				return this._pageNumber;
			}
			set
			{
				if ((_pageNumber != value))
				{
					this.OnPageNumberChanging(value);
					this._pageNumber = value;
					this.OnPageNumberChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_SUBJECT_BODY")]
	public partial class OutputSubjectBody
	{

		private string _bodyFileName;

		private System.Nullable<long> _outputdefID;

		private long _outputSubjectBodyID;

		private string _subjectFileName;

		private long _transmissionSeqStepID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBodyFileNameChanged();

		partial void OnBodyFileNameChanging(string value);

		partial void OnOutputdefIdChanged();

		partial void OnOutputdefIdChanging(System.Nullable<long> value);

		partial void OnOutputSubjectBodyIdChanged();

		partial void OnOutputSubjectBodyIdChanging(long value);

		partial void OnSubjectFileNameChanged();

		partial void OnSubjectFileNameChanging(string value);

		partial void OnTransmissionSeqStepIdChanged();

		partial void OnTransmissionSeqStepIdChanging(long value);
		#endregion


		public OutputSubjectBody()
		{
			this.OnCreated();
		}

		[Column(Storage = "_bodyFileName", Name = "BODY_FILE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BodyFileName
		{
			get
			{
				return this._bodyFileName;
			}
			set
			{
				if (((_bodyFileName == value)
							== false))
				{
					this.OnBodyFileNameChanging(value);
					this._bodyFileName = value;
					this.OnBodyFileNameChanged();
				}
			}
		}

		[Column(Storage = "_outputdefID", Name = "OUTPUTDEF_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> OutputdefId
		{
			get
			{
				return this._outputdefID;
			}
			set
			{
				if ((_outputdefID != value))
				{
					this.OnOutputdefIdChanging(value);
					this._outputdefID = value;
					this.OnOutputdefIdChanged();
				}
			}
		}

		[Column(Storage = "_outputSubjectBodyID", Name = "OUTPUT_SUBJECT_BODY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputSubjectBodyId
		{
			get
			{
				return this._outputSubjectBodyID;
			}
			set
			{
				if ((_outputSubjectBodyID != value))
				{
					this.OnOutputSubjectBodyIdChanging(value);
					this._outputSubjectBodyID = value;
					this.OnOutputSubjectBodyIdChanged();
				}
			}
		}

		[Column(Storage = "_subjectFileName", Name = "SUBJECT_FILE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SubjectFileName
		{
			get
			{
				return this._subjectFileName;
			}
			set
			{
				if (((_subjectFileName == value)
							== false))
				{
					this.OnSubjectFileNameChanging(value);
					this._subjectFileName = value;
					this.OnSubjectFileNameChanged();
				}
			}
		}

		[Column(Storage = "_transmissionSeqStepID", Name = "TRANSMISSION_SEQ_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long TransmissionSeqStepId
		{
			get
			{
				return this._transmissionSeqStepID;
			}
			set
			{
				if ((_transmissionSeqStepID != value))
				{
					this.OnTransmissionSeqStepIdChanging(value);
					this._transmissionSeqStepID = value;
					this.OnTransmissionSeqStepIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OUTPUT_XMLTEMPLATE")]
	public partial class OutputXmltemplate
	{

		private string _description;

		private string _fileName;

		private long _outputXmltemplateID;

		private System.Nullable<long> _transmissionSeqStepID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFileNameChanged();

		partial void OnFileNameChanging(string value);

		partial void OnOutputXmltemplateIdChanged();

		partial void OnOutputXmltemplateIdChanging(long value);

		partial void OnTransmissionSeqStepIdChanged();

		partial void OnTransmissionSeqStepIdChanging(System.Nullable<long> value);
		#endregion


		public OutputXmltemplate()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_fileName", Name = "FILE_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				if (((_fileName == value)
							== false))
				{
					this.OnFileNameChanging(value);
					this._fileName = value;
					this.OnFileNameChanged();
				}
			}
		}

		[Column(Storage = "_outputXmltemplateID", Name = "OUTPUT_XMLTEMPLATE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OutputXmltemplateId
		{
			get
			{
				return this._outputXmltemplateID;
			}
			set
			{
				if ((_outputXmltemplateID != value))
				{
					this.OnOutputXmltemplateIdChanging(value);
					this._outputXmltemplateID = value;
					this.OnOutputXmltemplateIdChanged();
				}
			}
		}

		[Column(Storage = "_transmissionSeqStepID", Name = "TRANSMISSION_SEQ_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TransmissionSeqStepId
		{
			get
			{
				return this._transmissionSeqStepID;
			}
			set
			{
				if ((_transmissionSeqStepID != value))
				{
					this.OnTransmissionSeqStepIdChanging(value);
					this._transmissionSeqStepID = value;
					this.OnTransmissionSeqStepIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.OWNER")]
	public partial class Owner
	{

		private string _accountNumber;

		private string _addressCity;

		private string _addressCountry;

		private string _addressCounty;

		private string _addressFips;

		private string _addressLine1;

		private string _addressLine2;

		private string _addressState;

		private string _addressZip;

		private string _description;

		private string _email;

		private string _enableFlag;

		private string _fein;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _nameFirst;

		private string _nameLast;

		private string _nameTitle;

		private long _ownerID;

		private string _phoneFax;

		private string _phoneHome;

		private string _phoneWork;

		private string _sic;

		private string _uploadKey;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccountNumberChanged();

		partial void OnAccountNumberChanging(string value);

		partial void OnAddressCityChanged();

		partial void OnAddressCityChanging(string value);

		partial void OnAddressCountryChanged();

		partial void OnAddressCountryChanging(string value);

		partial void OnAddressCountyChanged();

		partial void OnAddressCountyChanging(string value);

		partial void OnAddressFipsChanged();

		partial void OnAddressFipsChanging(string value);

		partial void OnAddressLine1Changed();

		partial void OnAddressLine1Changing(string value);

		partial void OnAddressLine2Changed();

		partial void OnAddressLine2Changing(string value);

		partial void OnAddressStateChanged();

		partial void OnAddressStateChanging(string value);

		partial void OnAddressZipChanged();

		partial void OnAddressZipChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEmailChanged();

		partial void OnEmailChanging(string value);

		partial void OnEnableFlagChanged();

		partial void OnEnableFlagChanging(string value);

		partial void OnFeinChanged();

		partial void OnFeinChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnNameTitleChanged();

		partial void OnNameTitleChanging(string value);

		partial void OnOwnerIdChanged();

		partial void OnOwnerIdChanging(long value);

		partial void OnPhoneFaxChanged();

		partial void OnPhoneFaxChanging(string value);

		partial void OnPhoneHomeChanged();

		partial void OnPhoneHomeChanging(string value);

		partial void OnPhoneWorkChanged();

		partial void OnPhoneWorkChanging(string value);

		partial void OnSicChanged();

		partial void OnSicChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);
		#endregion


		public Owner()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accountNumber", Name = "ACCOUNT_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AccountNumber
		{
			get
			{
				return this._accountNumber;
			}
			set
			{
				if (((_accountNumber == value)
							== false))
				{
					this.OnAccountNumberChanging(value);
					this._accountNumber = value;
					this.OnAccountNumberChanged();
				}
			}
		}

		[Column(Storage = "_addressCity", Name = "ADDRESS_CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressCity
		{
			get
			{
				return this._addressCity;
			}
			set
			{
				if (((_addressCity == value)
							== false))
				{
					this.OnAddressCityChanging(value);
					this._addressCity = value;
					this.OnAddressCityChanged();
				}
			}
		}

		[Column(Storage = "_addressCountry", Name = "ADDRESS_COUNTRY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressCountry
		{
			get
			{
				return this._addressCountry;
			}
			set
			{
				if (((_addressCountry == value)
							== false))
				{
					this.OnAddressCountryChanging(value);
					this._addressCountry = value;
					this.OnAddressCountryChanged();
				}
			}
		}

		[Column(Storage = "_addressCounty", Name = "ADDRESS_COUNTY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressCounty
		{
			get
			{
				return this._addressCounty;
			}
			set
			{
				if (((_addressCounty == value)
							== false))
				{
					this.OnAddressCountyChanging(value);
					this._addressCounty = value;
					this.OnAddressCountyChanged();
				}
			}
		}

		[Column(Storage = "_addressFips", Name = "ADDRESS_FIPS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressFips
		{
			get
			{
				return this._addressFips;
			}
			set
			{
				if (((_addressFips == value)
							== false))
				{
					this.OnAddressFipsChanging(value);
					this._addressFips = value;
					this.OnAddressFipsChanged();
				}
			}
		}

		[Column(Storage = "_addressLine1", Name = "ADDRESS_LINE1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressLine1
		{
			get
			{
				return this._addressLine1;
			}
			set
			{
				if (((_addressLine1 == value)
							== false))
				{
					this.OnAddressLine1Changing(value);
					this._addressLine1 = value;
					this.OnAddressLine1Changed();
				}
			}
		}

		[Column(Storage = "_addressLine2", Name = "ADDRESS_LINE2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressLine2
		{
			get
			{
				return this._addressLine2;
			}
			set
			{
				if (((_addressLine2 == value)
							== false))
				{
					this.OnAddressLine2Changing(value);
					this._addressLine2 = value;
					this.OnAddressLine2Changed();
				}
			}
		}

		[Column(Storage = "_addressState", Name = "ADDRESS_STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressState
		{
			get
			{
				return this._addressState;
			}
			set
			{
				if (((_addressState == value)
							== false))
				{
					this.OnAddressStateChanging(value);
					this._addressState = value;
					this.OnAddressStateChanged();
				}
			}
		}

		[Column(Storage = "_addressZip", Name = "ADDRESS_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressZip
		{
			get
			{
				return this._addressZip;
			}
			set
			{
				if (((_addressZip == value)
							== false))
				{
					this.OnAddressZipChanging(value);
					this._addressZip = value;
					this.OnAddressZipChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_email", Name = "EMAIL", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value)
							== false))
				{
					this.OnEmailChanging(value);
					this._email = value;
					this.OnEmailChanged();
				}
			}
		}

		[Column(Storage = "_enableFlag", Name = "ENABLE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EnableFlag
		{
			get
			{
				return this._enableFlag;
			}
			set
			{
				if (((_enableFlag == value)
							== false))
				{
					this.OnEnableFlagChanging(value);
					this._enableFlag = value;
					this.OnEnableFlagChanged();
				}
			}
		}

		[Column(Storage = "_fein", Name = "FEIN", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fein
		{
			get
			{
				return this._fein;
			}
			set
			{
				if (((_fein == value)
							== false))
				{
					this.OnFeinChanging(value);
					this._fein = value;
					this.OnFeinChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_nameTitle", Name = "NAME_TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameTitle
		{
			get
			{
				return this._nameTitle;
			}
			set
			{
				if (((_nameTitle == value)
							== false))
				{
					this.OnNameTitleChanging(value);
					this._nameTitle = value;
					this.OnNameTitleChanged();
				}
			}
		}

		[Column(Storage = "_ownerID", Name = "OWNER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long OwnerId
		{
			get
			{
				return this._ownerID;
			}
			set
			{
				if ((_ownerID != value))
				{
					this.OnOwnerIdChanging(value);
					this._ownerID = value;
					this.OnOwnerIdChanged();
				}
			}
		}

		[Column(Storage = "_phoneFax", Name = "PHONE_FAX", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneFax
		{
			get
			{
				return this._phoneFax;
			}
			set
			{
				if (((_phoneFax == value)
							== false))
				{
					this.OnPhoneFaxChanging(value);
					this._phoneFax = value;
					this.OnPhoneFaxChanged();
				}
			}
		}

		[Column(Storage = "_phoneHome", Name = "PHONE_HOME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneHome
		{
			get
			{
				return this._phoneHome;
			}
			set
			{
				if (((_phoneHome == value)
							== false))
				{
					this.OnPhoneHomeChanging(value);
					this._phoneHome = value;
					this.OnPhoneHomeChanged();
				}
			}
		}

		[Column(Storage = "_phoneWork", Name = "PHONE_WORK", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PhoneWork
		{
			get
			{
				return this._phoneWork;
			}
			set
			{
				if (((_phoneWork == value)
							== false))
				{
					this.OnPhoneWorkChanging(value);
					this._phoneWork = value;
					this.OnPhoneWorkChanged();
				}
			}
		}

		[Column(Storage = "_sic", Name = "SIC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Sic
		{
			get
			{
				return this._sic;
			}
			set
			{
				if (((_sic == value)
							== false))
				{
					this.OnSicChanging(value);
					this._sic = value;
					this.OnSicChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.POLICY")]
	public partial class Policy
	{

		private System.Nullable<long> _accntHrcyStepID;

		private System.Nullable<System.DateTime> _activeEndDate;

		private System.Nullable<System.DateTime> _activeStartDate;

		private string _additionalDeliveries;

		private System.Nullable<long> _agentID;

		private System.Nullable<System.DateTime> _cancellationDate;

		private System.Nullable<long> _carrierID;

		private System.Nullable<System.DateTime> _changeDate;

		private string _companyCode;

		private string _divisionCode;

		private System.DateTime _effectiveDate;

		private System.DateTime _expirationDate;

		private System.Nullable<long> _fileTranLogID;

		private System.DateTime _loadDate;

		private string _lobCode;

		private string _managedCareType;

		private System.Nullable<System.DateTime> _originalEffectiveDate;

		private string _policyCovCodes;

		private string _policyDecription;

		private long _policyID;

		private string _policyNumber;

		private string _policyType;

		private string _selfInsured;

		private System.Nullable<long> _tpaID;

		private string _uploadKey;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnActiveEndDateChanged();

		partial void OnActiveEndDateChanging(System.Nullable<System.DateTime> value);

		partial void OnActiveStartDateChanged();

		partial void OnActiveStartDateChanging(System.Nullable<System.DateTime> value);

		partial void OnAdditionalDeliveriesChanged();

		partial void OnAdditionalDeliveriesChanging(string value);

		partial void OnAgentIdChanged();

		partial void OnAgentIdChanging(System.Nullable<long> value);

		partial void OnCancellationDateChanged();

		partial void OnCancellationDateChanging(System.Nullable<System.DateTime> value);

		partial void OnCarrierIdChanged();

		partial void OnCarrierIdChanging(System.Nullable<long> value);

		partial void OnChangeDateChanged();

		partial void OnChangeDateChanging(System.Nullable<System.DateTime> value);

		partial void OnCompanyCodeChanged();

		partial void OnCompanyCodeChanging(string value);

		partial void OnDivisionCodeChanged();

		partial void OnDivisionCodeChanging(string value);

		partial void OnEffectiveDateChanged();

		partial void OnEffectiveDateChanging(System.DateTime value);

		partial void OnExpirationDateChanged();

		partial void OnExpirationDateChanging(System.DateTime value);

		partial void OnFileTranLogIdChanged();

		partial void OnFileTranLogIdChanging(System.Nullable<long> value);

		partial void OnLoadDateChanged();

		partial void OnLoadDateChanging(System.DateTime value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnManagedCareTypeChanged();

		partial void OnManagedCareTypeChanging(string value);

		partial void OnOriginalEffectiveDateChanged();

		partial void OnOriginalEffectiveDateChanging(System.Nullable<System.DateTime> value);

		partial void OnPolicyCovCodesChanged();

		partial void OnPolicyCovCodesChanging(string value);

		partial void OnPolicyDecriptionChanged();

		partial void OnPolicyDecriptionChanging(string value);

		partial void OnPolicyIdChanged();

		partial void OnPolicyIdChanging(long value);

		partial void OnPolicyNumberChanged();

		partial void OnPolicyNumberChanging(string value);

		partial void OnPolicyTypeChanged();

		partial void OnPolicyTypeChanging(string value);

		partial void OnSelfInsuredChanged();

		partial void OnSelfInsuredChanging(string value);

		partial void OnTpaIdChanged();

		partial void OnTpaIdChanging(System.Nullable<long> value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);
		#endregion


		public Policy()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_activeEndDate", Name = "ACTIVE_END_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveEndDate
		{
			get
			{
				return this._activeEndDate;
			}
			set
			{
				if ((_activeEndDate != value))
				{
					this.OnActiveEndDateChanging(value);
					this._activeEndDate = value;
					this.OnActiveEndDateChanged();
				}
			}
		}

		[Column(Storage = "_activeStartDate", Name = "ACTIVE_START_DT", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ActiveStartDate
		{
			get
			{
				return this._activeStartDate;
			}
			set
			{
				if ((_activeStartDate != value))
				{
					this.OnActiveStartDateChanging(value);
					this._activeStartDate = value;
					this.OnActiveStartDateChanged();
				}
			}
		}

		[Column(Storage = "_additionalDeliveries", Name = "ADDITIONAL_DELIVERIES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AdditionalDeliveries
		{
			get
			{
				return this._additionalDeliveries;
			}
			set
			{
				if (((_additionalDeliveries == value)
							== false))
				{
					this.OnAdditionalDeliveriesChanging(value);
					this._additionalDeliveries = value;
					this.OnAdditionalDeliveriesChanged();
				}
			}
		}

		[Column(Storage = "_agentID", Name = "AGENT_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AgentId
		{
			get
			{
				return this._agentID;
			}
			set
			{
				if ((_agentID != value))
				{
					this.OnAgentIdChanging(value);
					this._agentID = value;
					this.OnAgentIdChanged();
				}
			}
		}

		[Column(Storage = "_cancellationDate", Name = "CANCELLATION_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CancellationDate
		{
			get
			{
				return this._cancellationDate;
			}
			set
			{
				if ((_cancellationDate != value))
				{
					this.OnCancellationDateChanging(value);
					this._cancellationDate = value;
					this.OnCancellationDateChanged();
				}
			}
		}

		[Column(Storage = "_carrierID", Name = "CARRIER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> CarrierId
		{
			get
			{
				return this._carrierID;
			}
			set
			{
				if ((_carrierID != value))
				{
					this.OnCarrierIdChanging(value);
					this._carrierID = value;
					this.OnCarrierIdChanged();
				}
			}
		}

		[Column(Storage = "_changeDate", Name = "CHANGE_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ChangeDate
		{
			get
			{
				return this._changeDate;
			}
			set
			{
				if ((_changeDate != value))
				{
					this.OnChangeDateChanging(value);
					this._changeDate = value;
					this.OnChangeDateChanged();
				}
			}
		}

		[Column(Storage = "_companyCode", Name = "COMPANY_CODE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CompanyCode
		{
			get
			{
				return this._companyCode;
			}
			set
			{
				if (((_companyCode == value)
							== false))
				{
					this.OnCompanyCodeChanging(value);
					this._companyCode = value;
					this.OnCompanyCodeChanged();
				}
			}
		}

		[Column(Storage = "_divisionCode", Name = "DIVISION_CD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DivisionCode
		{
			get
			{
				return this._divisionCode;
			}
			set
			{
				if (((_divisionCode == value)
							== false))
				{
					this.OnDivisionCodeChanging(value);
					this._divisionCode = value;
					this.OnDivisionCodeChanged();
				}
			}
		}

		[Column(Storage = "_effectiveDate", Name = "EFFECTIVE_DATE", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime EffectiveDate
		{
			get
			{
				return this._effectiveDate;
			}
			set
			{
				if ((_effectiveDate != value))
				{
					this.OnEffectiveDateChanging(value);
					this._effectiveDate = value;
					this.OnEffectiveDateChanged();
				}
			}
		}

		[Column(Storage = "_expirationDate", Name = "EXPIRATION_DATE", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime ExpirationDate
		{
			get
			{
				return this._expirationDate;
			}
			set
			{
				if ((_expirationDate != value))
				{
					this.OnExpirationDateChanging(value);
					this._expirationDate = value;
					this.OnExpirationDateChanged();
				}
			}
		}

		[Column(Storage = "_fileTranLogID", Name = "FILE_TRAN_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTranLogId
		{
			get
			{
				return this._fileTranLogID;
			}
			set
			{
				if ((_fileTranLogID != value))
				{
					this.OnFileTranLogIdChanging(value);
					this._fileTranLogID = value;
					this.OnFileTranLogIdChanged();
				}
			}
		}

		[Column(Storage = "_loadDate", Name = "LOAD_DATE", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LoadDate
		{
			get
			{
				return this._loadDate;
			}
			set
			{
				if ((_loadDate != value))
				{
					this.OnLoadDateChanging(value);
					this._loadDate = value;
					this.OnLoadDateChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_managedCareType", Name = "MANAGED_CARE_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string ManagedCareType
		{
			get
			{
				return this._managedCareType;
			}
			set
			{
				if (((_managedCareType == value)
							== false))
				{
					this.OnManagedCareTypeChanging(value);
					this._managedCareType = value;
					this.OnManagedCareTypeChanged();
				}
			}
		}

		[Column(Storage = "_originalEffectiveDate", Name = "ORIGINAL_EFFECTIVE_DATE", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> OriginalEffectiveDate
		{
			get
			{
				return this._originalEffectiveDate;
			}
			set
			{
				if ((_originalEffectiveDate != value))
				{
					this.OnOriginalEffectiveDateChanging(value);
					this._originalEffectiveDate = value;
					this.OnOriginalEffectiveDateChanged();
				}
			}
		}

		[Column(Storage = "_policyCovCodes", Name = "POLICY_COV_CODES", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PolicyCovCodes
		{
			get
			{
				return this._policyCovCodes;
			}
			set
			{
				if (((_policyCovCodes == value)
							== false))
				{
					this.OnPolicyCovCodesChanging(value);
					this._policyCovCodes = value;
					this.OnPolicyCovCodesChanged();
				}
			}
		}

		[Column(Storage = "_policyDecription", Name = "POLICY_DESC", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PolicyDecription
		{
			get
			{
				return this._policyDecription;
			}
			set
			{
				if (((_policyDecription == value)
							== false))
				{
					this.OnPolicyDecriptionChanging(value);
					this._policyDecription = value;
					this.OnPolicyDecriptionChanged();
				}
			}
		}

		[Column(Storage = "_policyID", Name = "POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long PolicyId
		{
			get
			{
				return this._policyID;
			}
			set
			{
				if ((_policyID != value))
				{
					this.OnPolicyIdChanging(value);
					this._policyID = value;
					this.OnPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_policyNumber", Name = "POLICY_NUMBER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PolicyNumber
		{
			get
			{
				return this._policyNumber;
			}
			set
			{
				if (((_policyNumber == value)
							== false))
				{
					this.OnPolicyNumberChanging(value);
					this._policyNumber = value;
					this.OnPolicyNumberChanged();
				}
			}
		}

		[Column(Storage = "_policyType", Name = "POLICY_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PolicyType
		{
			get
			{
				return this._policyType;
			}
			set
			{
				if (((_policyType == value)
							== false))
				{
					this.OnPolicyTypeChanging(value);
					this._policyType = value;
					this.OnPolicyTypeChanged();
				}
			}
		}

		[Column(Storage = "_selfInsured", Name = "SELF_INSURED", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string SelfInsured
		{
			get
			{
				return this._selfInsured;
			}
			set
			{
				if (((_selfInsured == value)
							== false))
				{
					this.OnSelfInsuredChanging(value);
					this._selfInsured = value;
					this.OnSelfInsuredChanged();
				}
			}
		}

		[Column(Storage = "_tpaID", Name = "TPA_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TpaId
		{
			get
			{
				return this._tpaID;
			}
			set
			{
				if ((_tpaID != value))
				{
					this.OnTpaIdChanging(value);
					this._tpaID = value;
					this.OnTpaIdChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.POLICY_EXTENSION")]
	public partial class PolicyExtension
	{

		private System.Nullable<long> _fileTransmissionLogID;

		private string _name;

		private long _policyExtensionID;

		private long _policyID;

		private string _uploadKey;

		private string _value;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnPolicyExtensionIdChanged();

		partial void OnPolicyExtensionIdChanging(long value);

		partial void OnPolicyIdChanged();

		partial void OnPolicyIdChanging(long value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnValueChanged();

		partial void OnValueChanging(string value);
		#endregion


		public PolicyExtension()
		{
			this.OnCreated();
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_policyExtensionID", Name = "POLICY_EXTENSION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long PolicyExtensionId
		{
			get
			{
				return this._policyExtensionID;
			}
			set
			{
				if ((_policyExtensionID != value))
				{
					this.OnPolicyExtensionIdChanging(value);
					this._policyExtensionID = value;
					this.OnPolicyExtensionIdChanged();
				}
			}
		}

		[Column(Storage = "_policyID", Name = "POLICY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long PolicyId
		{
			get
			{
				return this._policyID;
			}
			set
			{
				if ((_policyID != value))
				{
					this.OnPolicyIdChanging(value);
					this._policyID = value;
					this.OnPolicyIdChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_value", Name = "VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (((_value == value)
							== false))
				{
					this.OnValueChanging(value);
					this._value = value;
					this.OnValueChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.REFERRAL_PLAN")]
	public partial class ReferralPlan
	{

		private System.Nullable<long> _accntHrcyStepID;

		private string _description;

		private string _enabledFlag;

		private System.Nullable<long> _enableRuleID;

		private string _lobCode;

		private string _locationZip;

		private long _referralPlanID;

		private long _referralTypeID;

		private System.Nullable<long> _serviceTypeID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(System.Nullable<long> value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnEnabledFlagChanged();

		partial void OnEnabledFlagChanging(string value);

		partial void OnEnableRuleIdChanged();

		partial void OnEnableRuleIdChanging(System.Nullable<long> value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnLocationZipChanged();

		partial void OnLocationZipChanging(string value);

		partial void OnReferralPlanIdChanged();

		partial void OnReferralPlanIdChanging(long value);

		partial void OnReferralTypeIdChanged();

		partial void OnReferralTypeIdChanging(long value);

		partial void OnServiceTypeIdChanged();

		partial void OnServiceTypeIdChanging(System.Nullable<long> value);
		#endregion


		public ReferralPlan()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_enabledFlag", Name = "ENABLED_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string EnabledFlag
		{
			get
			{
				return this._enabledFlag;
			}
			set
			{
				if (((_enabledFlag == value)
							== false))
				{
					this.OnEnabledFlagChanging(value);
					this._enabledFlag = value;
					this.OnEnabledFlagChanged();
				}
			}
		}

		[Column(Storage = "_enableRuleID", Name = "ENABLERULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnableRuleId
		{
			get
			{
				return this._enableRuleID;
			}
			set
			{
				if ((_enableRuleID != value))
				{
					this.OnEnableRuleIdChanging(value);
					this._enableRuleID = value;
					this.OnEnableRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_locationZip", Name = "LOCATION_ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LocationZip
		{
			get
			{
				return this._locationZip;
			}
			set
			{
				if (((_locationZip == value)
							== false))
				{
					this.OnLocationZipChanging(value);
					this._locationZip = value;
					this.OnLocationZipChanged();
				}
			}
		}

		[Column(Storage = "_referralPlanID", Name = "REFERRAL_PLAN_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ReferralPlanId
		{
			get
			{
				return this._referralPlanID;
			}
			set
			{
				if ((_referralPlanID != value))
				{
					this.OnReferralPlanIdChanging(value);
					this._referralPlanID = value;
					this.OnReferralPlanIdChanged();
				}
			}
		}

		[Column(Storage = "_referralTypeID", Name = "REFERRAL_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ReferralTypeId
		{
			get
			{
				return this._referralTypeID;
			}
			set
			{
				if ((_referralTypeID != value))
				{
					this.OnReferralTypeIdChanging(value);
					this._referralTypeID = value;
					this.OnReferralTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_serviceTypeID", Name = "SERVICE_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> ServiceTypeId
		{
			get
			{
				return this._serviceTypeID;
			}
			set
			{
				if ((_serviceTypeID != value))
				{
					this.OnServiceTypeIdChanging(value);
					this._serviceTypeID = value;
					this.OnServiceTypeIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.REFERRAL_TYPE")]
	public partial class ReferralType
	{

		private string _description;

		private string _name;

		private long _referralTypeID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnReferralTypeIdChanged();

		partial void OnReferralTypeIdChanging(long value);
		#endregion


		public ReferralType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_referralTypeID", Name = "REFERRAL_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ReferralTypeId
		{
			get
			{
				return this._referralTypeID;
			}
			set
			{
				if ((_referralTypeID != value))
				{
					this.OnReferralTypeIdChanging(value);
					this._referralTypeID = value;
					this.OnReferralTypeIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.REFILL_STATUS_CODES")]
	public partial class RefillStatusCodes
	{

		private string _refillStatus;

		private string _refillStatusCode;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnRefillStatusChanged();

		partial void OnRefillStatusChanging(string value);

		partial void OnRefillStatusCodeChanged();

		partial void OnRefillStatusCodeChanging(string value);
		#endregion


		public RefillStatusCodes()
		{
			this.OnCreated();
		}

		[Column(Storage = "_refillStatus", Name = "REFILL_STATUS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RefillStatus
		{
			get
			{
				return this._refillStatus;
			}
			set
			{
				if (((_refillStatus == value)
							== false))
				{
					this.OnRefillStatusChanging(value);
					this._refillStatus = value;
					this.OnRefillStatusChanged();
				}
			}
		}

		[Column(Storage = "_refillStatusCode", Name = "REFILL_STATUS_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string RefillStatusCode
		{
			get
			{
				return this._refillStatusCode;
			}
			set
			{
				if (((_refillStatusCode == value)
							== false))
				{
					this.OnRefillStatusCodeChanging(value);
					this._refillStatusCode = value;
					this.OnRefillStatusCodeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.RESUBMIT_REASON")]
	public partial class ResubmitReason
	{

		private string _billableFlag;

		private string _description;

		private string _name;

		private long _resubmitReasonID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnBillableFlagChanged();

		partial void OnBillableFlagChanging(string value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnResubmitReasonIdChanged();

		partial void OnResubmitReasonIdChanging(long value);
		#endregion


		public ResubmitReason()
		{
			this.OnCreated();
		}

		[Column(Storage = "_billableFlag", Name = "BILLABLE_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string BillableFlag
		{
			get
			{
				return this._billableFlag;
			}
			set
			{
				if (((_billableFlag == value)
							== false))
				{
					this.OnBillableFlagChanging(value);
					this._billableFlag = value;
					this.OnBillableFlagChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_resubmitReasonID", Name = "RESUBMIT_REASON_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ResubmitReasonId
		{
			get
			{
				return this._resubmitReasonID;
			}
			set
			{
				if ((_resubmitReasonID != value))
				{
					this.OnResubmitReasonIdChanging(value);
					this._resubmitReasonID = value;
					this.OnResubmitReasonIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ROUTINGADDRESS")]
	public partial class Routingaddress
	{

		private string _description;

		private string _fips;

		private long _routingaddressID;

		private string _state;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnFipsChanged();

		partial void OnFipsChanging(string value);

		partial void OnRoutingaddressIdChanged();

		partial void OnRoutingaddressIdChanging(long value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public Routingaddress()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_fips", Name = "FIPS", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Fips
		{
			get
			{
				return this._fips;
			}
			set
			{
				if (((_fips == value)
							== false))
				{
					this.OnFipsChanging(value);
					this._fips = value;
					this.OnFipsChanged();
				}
			}
		}

		[Column(Storage = "_routingaddressID", Name = "ROUTINGADDRESS_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RoutingaddressId
		{
			get
			{
				return this._routingaddressID;
			}
			set
			{
				if ((_routingaddressID != value))
				{
					this.OnRoutingaddressIdChanging(value);
					this._routingaddressID = value;
					this.OnRoutingaddressIdChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ROUTINGADDRESSRULE")]
	public partial class RoutingaddressRule
	{

		private long _accntHrcyStepID;

		private string _lobCode;

		private long _routingaddressID;

		private long _routingaddressRuleID;

		private System.Nullable<long> _routingRuleID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnRoutingaddressIdChanged();

		partial void OnRoutingaddressIdChanging(long value);

		partial void OnRoutingaddressRuleIdChanged();

		partial void OnRoutingaddressRuleIdChanging(long value);

		partial void OnRoutingRuleIdChanged();

		partial void OnRoutingRuleIdChanging(System.Nullable<long> value);
		#endregion


		public RoutingaddressRule()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_routingaddressID", Name = "ROUTINGADDRESS_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RoutingaddressId
		{
			get
			{
				return this._routingaddressID;
			}
			set
			{
				if ((_routingaddressID != value))
				{
					this.OnRoutingaddressIdChanging(value);
					this._routingaddressID = value;
					this.OnRoutingaddressIdChanged();
				}
			}
		}

		[Column(Storage = "_routingaddressRuleID", Name = "ROUTINGADDRESSRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RoutingaddressRuleId
		{
			get
			{
				return this._routingaddressRuleID;
			}
			set
			{
				if ((_routingaddressRuleID != value))
				{
					this.OnRoutingaddressRuleIdChanging(value);
					this._routingaddressRuleID = value;
					this.OnRoutingaddressRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_routingRuleID", Name = "ROUTINGRULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RoutingRuleId
		{
			get
			{
				return this._routingRuleID;
			}
			set
			{
				if ((_routingRuleID != value))
				{
					this.OnRoutingRuleIdChanging(value);
					this._routingRuleID = value;
					this.OnRoutingRuleIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.ROUTING_PLAN")]
	public partial class RoutingPlan
	{

		private long _accntHrcyStepID;

		private string _description;

		private string _destinationType;

		private string _enabledFlag;

		private System.Nullable<long> _enableRuleID;

		private string _inputSystemName;

		private string _lobCode;

		private long _routingPlanID;

		private string _state;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnDestinationTypeChanged();

		partial void OnDestinationTypeChanging(string value);

		partial void OnEnabledFlagChanged();

		partial void OnEnabledFlagChanging(string value);

		partial void OnEnableRuleIdChanged();

		partial void OnEnableRuleIdChanging(System.Nullable<long> value);

		partial void OnInputSystemNameChanged();

		partial void OnInputSystemNameChanging(string value);

		partial void OnLobCodeChanged();

		partial void OnLobCodeChanging(string value);

		partial void OnRoutingPlanIdChanged();

		partial void OnRoutingPlanIdChanging(long value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);
		#endregion


		public RoutingPlan()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_destinationType", Name = "DESTINATION_TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DestinationType
		{
			get
			{
				return this._destinationType;
			}
			set
			{
				if (((_destinationType == value)
							== false))
				{
					this.OnDestinationTypeChanging(value);
					this._destinationType = value;
					this.OnDestinationTypeChanged();
				}
			}
		}

		[Column(Storage = "_enabledFlag", Name = "ENABLED_FLG", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string EnabledFlag
		{
			get
			{
				return this._enabledFlag;
			}
			set
			{
				if (((_enabledFlag == value)
							== false))
				{
					this.OnEnabledFlagChanging(value);
					this._enabledFlag = value;
					this.OnEnabledFlagChanged();
				}
			}
		}

		[Column(Storage = "_enableRuleID", Name = "ENABLERULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> EnableRuleId
		{
			get
			{
				return this._enableRuleID;
			}
			set
			{
				if ((_enableRuleID != value))
				{
					this.OnEnableRuleIdChanging(value);
					this._enableRuleID = value;
					this.OnEnableRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_inputSystemName", Name = "INPUT_SYSTEM_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string InputSystemName
		{
			get
			{
				return this._inputSystemName;
			}
			set
			{
				if (((_inputSystemName == value)
							== false))
				{
					this.OnInputSystemNameChanging(value);
					this._inputSystemName = value;
					this.OnInputSystemNameChanged();
				}
			}
		}

		[Column(Storage = "_lobCode", Name = "LOB_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LobCode
		{
			get
			{
				return this._lobCode;
			}
			set
			{
				if (((_lobCode == value)
							== false))
				{
					this.OnLobCodeChanging(value);
					this._lobCode = value;
					this.OnLobCodeChanged();
				}
			}
		}

		[Column(Storage = "_routingPlanID", Name = "ROUTING_PLAN_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RoutingPlanId
		{
			get
			{
				return this._routingPlanID;
			}
			set
			{
				if ((_routingPlanID != value))
				{
					this.OnRoutingPlanIdChanging(value);
					this._routingPlanID = value;
					this.OnRoutingPlanIdChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.RULES")]
	public partial class Rules
	{

		private string _comments;

		private System.DateTime _createdDate;

		private string _languageTypeCode;

		private System.DateTime _lastModifiedDate;

		private long _ruleID;

		private string _ruleText;

		private string _type;

		private System.Nullable<long> _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnCommentsChanged();

		partial void OnCommentsChanging(string value);

		partial void OnCreatedDateChanged();

		partial void OnCreatedDateChanging(System.DateTime value);

		partial void OnLanguageTypeCodeChanged();

		partial void OnLanguageTypeCodeChanging(string value);

		partial void OnLastModifiedDateChanged();

		partial void OnLastModifiedDateChanging(System.DateTime value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(long value);

		partial void OnRuleTextChanged();

		partial void OnRuleTextChanging(string value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(System.Nullable<long> value);
		#endregion


		public Rules()
		{
			this.OnCreated();
		}

		[Column(Storage = "_comments", Name = "COMMENTS", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				if (((_comments == value)
							== false))
				{
					this.OnCommentsChanging(value);
					this._comments = value;
					this.OnCommentsChanged();
				}
			}
		}

		[Column(Storage = "_createdDate", Name = "CREATED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._createdDate;
			}
			set
			{
				if ((_createdDate != value))
				{
					this.OnCreatedDateChanging(value);
					this._createdDate = value;
					this.OnCreatedDateChanged();
				}
			}
		}

		[Column(Storage = "_languageTypeCode", Name = "LANGUAGE_TYPE_CD", DbType = "CHAR", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string LanguageTypeCode
		{
			get
			{
				return this._languageTypeCode;
			}
			set
			{
				if (((_languageTypeCode == value)
							== false))
				{
					this.OnLanguageTypeCodeChanging(value);
					this._languageTypeCode = value;
					this.OnLanguageTypeCodeChanged();
				}
			}
		}

		[Column(Storage = "_lastModifiedDate", Name = "LAST_MODIFIED_DT", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._lastModifiedDate;
			}
			set
			{
				if ((_lastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this._lastModifiedDate = value;
					this.OnLastModifiedDateChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_ruleText", Name = "RULE_TEXT", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string RuleText
		{
			get
			{
				return this._ruleText;
			}
			set
			{
				if (((_ruleText == value)
							== false))
				{
					this.OnRuleTextChanging(value);
					this._ruleText = value;
					this.OnRuleTextChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.RULE_SET")]
	public partial class RuleSet
	{

		private long _accntHrcyStepID;

		private string _event;

		private long _ruleID;

		private long _ruleSetID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnEventChanged();

		partial void OnEventChanging(string value);

		partial void OnRuleIdChanged();

		partial void OnRuleIdChanging(long value);

		partial void OnRuleSetIdChanged();

		partial void OnRuleSetIdChanging(long value);
		#endregion


		public RuleSet()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_event", Name = "EVENT", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Event
		{
			get
			{
				return this._event;
			}
			set
			{
				if (((_event == value)
							== false))
				{
					this.OnEventChanging(value);
					this._event = value;
					this.OnEventChanged();
				}
			}
		}

		[Column(Storage = "_ruleID", Name = "RULE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RuleId
		{
			get
			{
				return this._ruleID;
			}
			set
			{
				if ((_ruleID != value))
				{
					this.OnRuleIdChanging(value);
					this._ruleID = value;
					this.OnRuleIdChanged();
				}
			}
		}

		[Column(Storage = "_ruleSetID", Name = "RULE_SET_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long RuleSetId
		{
			get
			{
				return this._ruleSetID;
			}
			set
			{
				if ((_ruleSetID != value))
				{
					this.OnRuleSetIdChanging(value);
					this._ruleSetID = value;
					this.OnRuleSetIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.SECURITY_LOG")]
	public partial class SecurityLog
	{

		private System.Nullable<System.DateTime> _logoffTime;

		private System.DateTime _logonTime;

		private string _phoneextension;

		private long _securityLogID;

		private long _userID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnLogoffTimeChanged();

		partial void OnLogoffTimeChanging(System.Nullable<System.DateTime> value);

		partial void OnLogonTimeChanged();

		partial void OnLogonTimeChanging(System.DateTime value);

		partial void OnPhoneextensionChanged();

		partial void OnPhoneextensionChanging(string value);

		partial void OnSecurityLogIdChanged();

		partial void OnSecurityLogIdChanging(long value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(long value);
		#endregion


		public SecurityLog()
		{
			this.OnCreated();
		}

		[Column(Storage = "_logoffTime", Name = "LOGOFF_TIME", DbType = "DATE", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LogoffTime
		{
			get
			{
				return this._logoffTime;
			}
			set
			{
				if ((_logoffTime != value))
				{
					this.OnLogoffTimeChanging(value);
					this._logoffTime = value;
					this.OnLogoffTimeChanged();
				}
			}
		}

		[Column(Storage = "_logonTime", Name = "LOGON_TIME", DbType = "DATE", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public System.DateTime LogonTime
		{
			get
			{
				return this._logonTime;
			}
			set
			{
				if ((_logonTime != value))
				{
					this.OnLogonTimeChanging(value);
					this._logonTime = value;
					this.OnLogonTimeChanged();
				}
			}
		}

		[Column(Storage = "_phoneextension", Name = "PHONEEXTENSION", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phoneextension
		{
			get
			{
				return this._phoneextension;
			}
			set
			{
				if (((_phoneextension == value)
							== false))
				{
					this.OnPhoneextensionChanging(value);
					this._phoneextension = value;
					this.OnPhoneextensionChanged();
				}
			}
		}

		[Column(Storage = "_securityLogID", Name = "SECURITY_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long SecurityLogId
		{
			get
			{
				return this._securityLogID;
			}
			set
			{
				if ((_securityLogID != value))
				{
					this.OnSecurityLogIdChanging(value);
					this._securityLogID = value;
					this.OnSecurityLogIdChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.SERVICE_TYPE")]
	public partial class ServiceType
	{

		private string _description;

		private long _serviceTypeID;

		private string _type;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnDescriptionChanged();

		partial void OnDescriptionChanging(string value);

		partial void OnServiceTypeIdChanged();

		partial void OnServiceTypeIdChanging(long value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);
		#endregion


		public ServiceType()
		{
			this.OnCreated();
		}

		[Column(Storage = "_description", Name = "DESCRIPTION", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value)
							== false))
				{
					this.OnDescriptionChanging(value);
					this._description = value;
					this.OnDescriptionChanged();
				}
			}
		}

		[Column(Storage = "_serviceTypeID", Name = "SERVICE_TYPE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long ServiceTypeId
		{
			get
			{
				return this._serviceTypeID;
			}
			set
			{
				if ((_serviceTypeID != value))
				{
					this.OnServiceTypeIdChanging(value);
					this._serviceTypeID = value;
					this.OnServiceTypeIdChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.SETTING")]
	public partial class Setting
	{

		private System.Nullable<long> _keyID;

		private string _name;

		private System.Nullable<long> _sequence;

		private long _settingID;

		private string _type;

		private System.Nullable<long> _userID;

		private string _value;

		private System.Nullable<long> _version;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnKeyIdChanged();

		partial void OnKeyIdChanging(System.Nullable<long> value);

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(System.Nullable<long> value);

		partial void OnSettingIdChanged();

		partial void OnSettingIdChanging(long value);

		partial void OnTypeChanged();

		partial void OnTypeChanging(string value);

		partial void OnUserIdChanged();

		partial void OnUserIdChanging(System.Nullable<long> value);

		partial void OnValueChanged();

		partial void OnValueChanging(string value);

		partial void OnVersionChanged();

		partial void OnVersionChanging(System.Nullable<long> value);
		#endregion


		public Setting()
		{
			this.OnCreated();
		}

		[Column(Storage = "_keyID", Name = "KEY_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> KeyId
		{
			get
			{
				return this._keyID;
			}
			set
			{
				if ((_keyID != value))
				{
					this.OnKeyIdChanging(value);
					this._keyID = value;
					this.OnKeyIdChanged();
				}
			}
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_settingID", Name = "SETTING_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long SettingId
		{
			get
			{
				return this._settingID;
			}
			set
			{
				if ((_settingID != value))
				{
					this.OnSettingIdChanging(value);
					this._settingID = value;
					this.OnSettingIdChanged();
				}
			}
		}

		[Column(Storage = "_type", Name = "TYPE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				if (((_type == value)
							== false))
				{
					this.OnTypeChanging(value);
					this._type = value;
					this.OnTypeChanged();
				}
			}
		}

		[Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> UserId
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIdChanging(value);
					this._userID = value;
					this.OnUserIdChanged();
				}
			}
		}

		[Column(Storage = "_value", Name = "VALUE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (((_value == value)
							== false))
				{
					this.OnValueChanging(value);
					this._value = value;
					this.OnValueChanged();
				}
			}
		}

		[Column(Storage = "_version", Name = "VERSION", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> Version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((_version != value))
				{
					this.OnVersionChanging(value);
					this._version = value;
					this.OnVersionChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.SITE")]
	public partial class Site
	{

		private string _name;

		private long _siteID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnNameChanged();

		partial void OnNameChanging(string value);

		partial void OnSiteIdChanged();

		partial void OnSiteIdChanging(long value);
		#endregion


		public Site()
		{
			this.OnCreated();
		}

		[Column(Storage = "_name", Name = "NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value)
							== false))
				{
					this.OnNameChanging(value);
					this._name = value;
					this.OnNameChanged();
				}
			}
		}

		[Column(Storage = "_siteID", Name = "SITE_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long SiteId
		{
			get
			{
				return this._siteID;
			}
			set
			{
				if ((_siteID != value))
				{
					this.OnSiteIdChanging(value);
					this._siteID = value;
					this.OnSiteIdChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.SPECIFIC_DESTINATION")]
	public partial class SpecificDestination
	{

		private long _accntHrcyStepID;

		private string _address1;

		private string _address2;

		private string _alternateFormFlag;

		private string _city;

		private System.Nullable<long> _fileTransmissionLogID;

		private string _lob;

		private string _nameFirst;

		private string _nameLast;

		private string _nameMi;

		private string _phone;

		private long _specificDestinationID;

		private string _state;

		private string _title;

		private string _uploadKey;

		private string _zip;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAccntHrcyStepIdChanged();

		partial void OnAccntHrcyStepIdChanging(long value);

		partial void OnAddress1Changed();

		partial void OnAddress1Changing(string value);

		partial void OnAddress2Changed();

		partial void OnAddress2Changing(string value);

		partial void OnAlternateFormFlagChanged();

		partial void OnAlternateFormFlagChanging(string value);

		partial void OnCityChanged();

		partial void OnCityChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnLobChanged();

		partial void OnLobChanging(string value);

		partial void OnNameFirstChanged();

		partial void OnNameFirstChanging(string value);

		partial void OnNameLastChanged();

		partial void OnNameLastChanging(string value);

		partial void OnNameMiChanged();

		partial void OnNameMiChanging(string value);

		partial void OnPhoneChanged();

		partial void OnPhoneChanging(string value);

		partial void OnSpecificDestinationIdChanged();

		partial void OnSpecificDestinationIdChanging(long value);

		partial void OnStateChanged();

		partial void OnStateChanging(string value);

		partial void OnTitleChanged();

		partial void OnTitleChanging(string value);

		partial void OnUploadKeyChanged();

		partial void OnUploadKeyChanging(string value);

		partial void OnZipChanged();

		partial void OnZipChanging(string value);
		#endregion


		public SpecificDestination()
		{
			this.OnCreated();
		}

		[Column(Storage = "_accntHrcyStepID", Name = "ACCNT_HRCY_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long AccntHrcyStepId
		{
			get
			{
				return this._accntHrcyStepID;
			}
			set
			{
				if ((_accntHrcyStepID != value))
				{
					this.OnAccntHrcyStepIdChanging(value);
					this._accntHrcyStepID = value;
					this.OnAccntHrcyStepIdChanged();
				}
			}
		}

		[Column(Storage = "_address1", Name = "ADDRESS1", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address1
		{
			get
			{
				return this._address1;
			}
			set
			{
				if (((_address1 == value)
							== false))
				{
					this.OnAddress1Changing(value);
					this._address1 = value;
					this.OnAddress1Changed();
				}
			}
		}

		[Column(Storage = "_address2", Name = "ADDRESS2", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address2
		{
			get
			{
				return this._address2;
			}
			set
			{
				if (((_address2 == value)
							== false))
				{
					this.OnAddress2Changing(value);
					this._address2 = value;
					this.OnAddress2Changed();
				}
			}
		}

		[Column(Storage = "_alternateFormFlag", Name = "ALTERNATE_FORM_FLG", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AlternateFormFlag
		{
			get
			{
				return this._alternateFormFlag;
			}
			set
			{
				if (((_alternateFormFlag == value)
							== false))
				{
					this.OnAlternateFormFlagChanging(value);
					this._alternateFormFlag = value;
					this.OnAlternateFormFlagChanged();
				}
			}
		}

		[Column(Storage = "_city", Name = "CITY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string City
		{
			get
			{
				return this._city;
			}
			set
			{
				if (((_city == value)
							== false))
				{
					this.OnCityChanging(value);
					this._city = value;
					this.OnCityChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_lob", Name = "LOB", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Lob
		{
			get
			{
				return this._lob;
			}
			set
			{
				if (((_lob == value)
							== false))
				{
					this.OnLobChanging(value);
					this._lob = value;
					this.OnLobChanged();
				}
			}
		}

		[Column(Storage = "_nameFirst", Name = "NAME_FIRST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameFirst
		{
			get
			{
				return this._nameFirst;
			}
			set
			{
				if (((_nameFirst == value)
							== false))
				{
					this.OnNameFirstChanging(value);
					this._nameFirst = value;
					this.OnNameFirstChanged();
				}
			}
		}

		[Column(Storage = "_nameLast", Name = "NAME_LAST", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameLast
		{
			get
			{
				return this._nameLast;
			}
			set
			{
				if (((_nameLast == value)
							== false))
				{
					this.OnNameLastChanging(value);
					this._nameLast = value;
					this.OnNameLastChanged();
				}
			}
		}

		[Column(Storage = "_nameMi", Name = "NAME_MI", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NameMi
		{
			get
			{
				return this._nameMi;
			}
			set
			{
				if (((_nameMi == value)
							== false))
				{
					this.OnNameMiChanging(value);
					this._nameMi = value;
					this.OnNameMiChanged();
				}
			}
		}

		[Column(Storage = "_phone", Name = "PHONE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if (((_phone == value)
							== false))
				{
					this.OnPhoneChanging(value);
					this._phone = value;
					this.OnPhoneChanged();
				}
			}
		}

		[Column(Storage = "_specificDestinationID", Name = "SPECIFIC_DESTINATION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long SpecificDestinationId
		{
			get
			{
				return this._specificDestinationID;
			}
			set
			{
				if ((_specificDestinationID != value))
				{
					this.OnSpecificDestinationIdChanging(value);
					this._specificDestinationID = value;
					this.OnSpecificDestinationIdChanged();
				}
			}
		}

		[Column(Storage = "_state", Name = "STATE", DbType = "CHAR", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				if (((_state == value)
							== false))
				{
					this.OnStateChanging(value);
					this._state = value;
					this.OnStateChanged();
				}
			}
		}

		[Column(Storage = "_title", Name = "TITLE", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value)
							== false))
				{
					this.OnTitleChanging(value);
					this._title = value;
					this.OnTitleChanged();
				}
			}
		}

		[Column(Storage = "_uploadKey", Name = "UPLOAD_KEY", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UploadKey
		{
			get
			{
				return this._uploadKey;
			}
			set
			{
				if (((_uploadKey == value)
							== false))
				{
					this.OnUploadKeyChanging(value);
					this._uploadKey = value;
					this.OnUploadKeyChanged();
				}
			}
		}

		[Column(Storage = "_zip", Name = "ZIP", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Zip
		{
			get
			{
				return this._zip;
			}
			set
			{
				if (((_zip == value)
							== false))
				{
					this.OnZipChanging(value);
					this._zip = value;
					this.OnZipChanged();
				}
			}
		}
	}

	[Table(Name = "FNSOWNER.SPECIFIC_DESTN_SEQ_STEP")]
	public partial class SpecificDestnSeqStep
	{

		private string _altDestinationString;

		private string _destinationString;

		private System.Nullable<long> _fileTransmissionLogID;

		private System.Nullable<long> _retryCount;

		private System.Nullable<long> _retryWaitTime;

		private long _sequence;

		private System.Nullable<long> _specificDestinationID;

		private long _specificDestnSeqStepID;

		private long _transmissionTypeID;

		#region Extensibility Method Declarations
		partial void OnCreated();

		partial void OnAltDestinationStringChanged();

		partial void OnAltDestinationStringChanging(string value);

		partial void OnDestinationStringChanged();

		partial void OnDestinationStringChanging(string value);

		partial void OnFileTransmissionLogIdChanged();

		partial void OnFileTransmissionLogIdChanging(System.Nullable<long> value);

		partial void OnRetryCountChanged();

		partial void OnRetryCountChanging(System.Nullable<long> value);

		partial void OnRetryWaitTimeChanged();

		partial void OnRetryWaitTimeChanging(System.Nullable<long> value);

		partial void OnSequenceChanged();

		partial void OnSequenceChanging(long value);

		partial void OnSpecificDestinationIdChanged();

		partial void OnSpecificDestinationIdChanging(System.Nullable<long> value);

		partial void OnSpecificDestnSeqStepIdChanged();

		partial void OnSpecificDestnSeqStepIdChanging(long value);

		partial void OnTransmissionTypeIdChanged();

		partial void OnTransmissionTypeIdChanging(long value);
		#endregion


		public SpecificDestnSeqStep()
		{
			this.OnCreated();
		}

		[Column(Storage = "_altDestinationString", Name = "ALT_DESTINATION_STRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AltDestinationString
		{
			get
			{
				return this._altDestinationString;
			}
			set
			{
				if (((_altDestinationString == value)
							== false))
				{
					this.OnAltDestinationStringChanging(value);
					this._altDestinationString = value;
					this.OnAltDestinationStringChanged();
				}
			}
		}

		[Column(Storage = "_destinationString", Name = "DESTINATION_STRING", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DestinationString
		{
			get
			{
				return this._destinationString;
			}
			set
			{
				if (((_destinationString == value)
							== false))
				{
					this.OnDestinationStringChanging(value);
					this._destinationString = value;
					this.OnDestinationStringChanged();
				}
			}
		}

		[Column(Storage = "_fileTransmissionLogID", Name = "FILE_TRANSMISSION_LOG_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> FileTransmissionLogId
		{
			get
			{
				return this._fileTransmissionLogID;
			}
			set
			{
				if ((_fileTransmissionLogID != value))
				{
					this.OnFileTransmissionLogIdChanging(value);
					this._fileTransmissionLogID = value;
					this.OnFileTransmissionLogIdChanged();
				}
			}
		}

		[Column(Storage = "_retryCount", Name = "RETRY_COUNT", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RetryCount
		{
			get
			{
				return this._retryCount;
			}
			set
			{
				if ((_retryCount != value))
				{
					this.OnRetryCountChanging(value);
					this._retryCount = value;
					this.OnRetryCountChanged();
				}
			}
		}

		[Column(Storage = "_retryWaitTime", Name = "RETRY_WAIT_TIME", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> RetryWaitTime
		{
			get
			{
				return this._retryWaitTime;
			}
			set
			{
				if ((_retryWaitTime != value))
				{
					this.OnRetryWaitTimeChanging(value);
					this._retryWaitTime = value;
					this.OnRetryWaitTimeChanged();
				}
			}
		}

		[Column(Storage = "_sequence", Name = "SEQUENCE", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long Sequence
		{
			get
			{
				return this._sequence;
			}
			set
			{
				if ((_sequence != value))
				{
					this.OnSequenceChanging(value);
					this._sequence = value;
					this.OnSequenceChanged();
				}
			}
		}

		[Column(Storage = "_specificDestinationID", Name = "SPECIFIC_DESTINATION_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> SpecificDestinationId
		{
			get
			{
				return this._specificDestinationID;
			}
			set
			{
				if ((_specificDestinationID != value))
				{
					this.OnSpecificDestinationIdChanging(value);
					this._specificDestinationID = value;
					this.OnSpecificDestinationIdChanged();
				}
			}
		}

		[Column(Storage = "_specificDestnSeqStepID", Name = "SPECIFIC_DESTN_SEQ_STEP_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
		[DebuggerNonUserCode()]
		public long SpecificDestnSeqStepId
		{
			get
			{
				return this._specificDestnSeqStepID;
			}
			set
			{
				if ((_specificDestnSeqStepID != value))
				{
					this.OnSpecificDestnSeqStepIdChanging(value);
					this._specificDestnSeqStepID = value;
					this.OnSpecificDestnSeqStepIdChanged();
				}
			}
		}

		{
			get
			{
		}