---------------------------------------------------------------------------
-- First Notice Systems
-- 529 Main Street
-- Boston, MA 02129
-- (617) 886 2600
--
-- Proprietary Source Code -- Distribution restricted
--
-- Copyright (c) 2006 by First Notice Systems
---------------------------------------------------------------------------
-- DBCLASSLIBRARY package definition for FNSP database instances
---------------------------------------------------------------------------
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Sql/DbClassLibPackageFNSP.sql 7     6/20/11 7:45p Gwynnj $ */
---------------------------------------------------------------------------
CREATE OR REPLACE PACKAGE DBCLASSLIBRARY AS

TYPE  CURSOR_TYPE IS REF CURSOR;

PROCEDURE GetAHSRecord (
	p_AHSID					IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
	p_UploadKey			IN		ACCOUNT_HIERARCHY_STEP.UPLOAD_KEY%TYPE,
	results					OUT		CURSOR_TYPE);

PROCEDURE GetMercuryDestinations (
	destinationType					IN		MERCURY.TYPE%TYPE,
	results									OUT		CURSOR_TYPE);
	
PROCEDURE GetEncrptAttributeSet (
	p_ahsId					IN		ENCRYPT_ATTRIBUTE.ACCNT_HRCY_STEP_ID%TYPE,
	p_lobCd					IN		ENCRYPT_ATTRIBUTE.LOB_CD%TYPE,
	p_encryptType		IN		ENCRYPT_ATTRIBUTE.ENCRYPT_TYPE%TYPE,
	results					OUT		CURSOR_TYPE);
	
	
PROCEDURE GetOverflowSet (
	p_accntHrcyStepId				IN		OUTPUT_OVERFLOW.ACCNT_HRCY_STEP_ID%TYPE,
	p_LineOfBusiness				IN		OUTPUT_OVERFLOW.LOB_CD%TYPE,
	results									OUT		CURSOR_TYPE);
	
PROCEDURE GetFileTranDefSet (
	p_accntHrcyStepId	IN		FILE_TRANSMISSION_DEF.ACCNT_HRCY_STEP_ID%TYPE,
	p_Server					IN		FILE_TRANSMISSION_DEF.SERVER%TYPE,
	p_Type						IN		FILE_TRANSMISSION_DEF.TYPE%TYPE,
	results									OUT		CURSOR_TYPE);
	
PROCEDURE ProcessClaimSubmissionLog(
	p_id								OUT	CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE,
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_requestType				IN	VARCHAR2,
	clobData						IN	CLOB);
	
PROCEDURE UpdateClaimSubmissionLog(
    p_id                         OUT    CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE,
    p_rquID                      IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_requestType                IN    VARCHAR2,
    p_timestamp					 IN	   VARCHAR2,
    clobData                     IN    CLOB);
	
PROCEDURE CreateUpdateEntities(
	p_id							OUT	ENTITIES.ENTITY_ID%TYPE,
	p_rquID							IN	ENTITIES.RQUID%TYPE,
	p_sourceData					IN	CLOB);
	
PROCEDURE GetEntity(
	p_rquID							IN	ENTITIES.RQUID%TYPE,
	p_sourceData					OUT	CLOB);
	
PROCEDURE GetClaimSubLogData (
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_requestType				IN	VARCHAR2,
	clobData						OUT	CLOB);

PROCEDURE ResetClaimLogResponse (
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_results						OUT	int);

PROCEDURE UpdateProviderStatus (
	p_providerID							OUT	PROVIDER.PROVIDER_ID%TYPE,
	p_uID											IN	varchar2,
	p_statusCode							IN	varchar2,
	p_address1								IN PROVIDER.NEW_ADDRESS_1%TYPE,
	p_address2								IN PROVIDER.NEW_ADDRESS_2%TYPE,
	p_city										IN PROVIDER.NEW_CITY%TYPE,
	p_state										IN PROVIDER.NEW_STATE%TYPE,
	p_zipCode									IN PROVIDER.NEW_ZIP%TYPE,
	p_phone										IN PROVIDER.NEW_PHONE%TYPE,
	p_email										IN PROVIDER.NEW_EMAIL%TYPE,
	p_groupName								IN PROVIDER.NEW_GROUP_NAME%TYPE,
	p_groupContact  					IN PROVIDER.NEW_GROUP_CONTACT%TYPE,
	p_groupPhone	  					IN PROVIDER.NEW_GROUP_PHONE%TYPE,
	p_mailPreference					IN PROVIDER. MAIL_PREFERENCE%TYPE,
	p_comments								IN PROVIDER.COMMENTS%TYPE);

PROCEDURE UpdateProviderFollowupStatus (
	p_providerID							OUT	PROVIDER.PROVIDER_ID%TYPE,
	p_uID											IN	varchar2,
	p_statusCode							IN	varchar2,
	p_address1								IN PROVIDER.NEW_ADDRESS_1%TYPE,
	p_address2								IN PROVIDER.NEW_ADDRESS_2%TYPE,
	p_city										IN PROVIDER.NEW_CITY%TYPE,
	p_state										IN PROVIDER.NEW_STATE%TYPE,
	p_zipCode									IN PROVIDER.NEW_ZIP%TYPE,
	p_phone										IN PROVIDER.NEW_PHONE%TYPE,
	p_email										IN PROVIDER.NEW_EMAIL%TYPE,
	p_groupName								IN PROVIDER.NEW_GROUP_NAME%TYPE,
	p_groupContact  					IN PROVIDER.NEW_GROUP_CONTACT%TYPE,
	p_groupPhone	  					IN PROVIDER.NEW_GROUP_PHONE%TYPE,
	p_mailPreference					IN PROVIDER. MAIL_PREFERENCE%TYPE,
	p_comments								IN PROVIDER.COMMENTS%TYPE);

PROCEDURE UnlockProvider (
	p_providerID							OUT	PROVIDER.PROVIDER_ID%TYPE,
	p_uID											IN	varchar2);
PROCEDURE UnlockProviderFollowup (
	p_providerID							OUT	PROVIDER.PROVIDER_ID%TYPE,
	p_uID											IN	varchar2);
	
PROCEDURE AddVehicleCoverageExtension (
	p_nVehicleCoverageExtId		OUT	VEHICLE_COVERAGE_EXT.VEHICLE_COVERAGE_EXT_ID%TYPE,
	p_nVehicleCoverageId			IN	VEHICLE_COVERAGE.VEHICLE_COVERAGE_ID%TYPE,
	p_nFileTranLogId					IN	VEHICLE_COVERAGE_EXT.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nDescr									IN	VEHICLE_COVERAGE_EXT.DESCR%TYPE);
	
PROCEDURE ProcessVehicleCoverage(
	p_nVehicleCoverageID	OUT		VEHICLE_COVERAGE.VEHICLE_COVERAGE_ID%TYPE,
	p_nFileTranLogId			IN		VEHICLE_COVERAGE.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nVehicleID					IN		VEHICLE_COVERAGE.VEHICLE_ID%TYPE,
	p_nCOVERAGE_TYPE			IN		VEHICLE_COVERAGE.COVERAGE_TYPE%TYPE,
	p_nLIMIT1							IN		VEHICLE_COVERAGE.LIMIT1%TYPE,
	p_nLIMIT2							IN		VEHICLE_COVERAGE.LIMIT2%TYPE,
	p_nDEDUCTIBLE1				IN		VEHICLE_COVERAGE.DEDUCTIBLE1%TYPE,
	p_nDEDUCTIBLE2				IN		VEHICLE_COVERAGE.DEDUCTIBLE2%TYPE,
	p_nUploadKey					IN		VEHICLE_COVERAGE.UPLOAD_KEY%TYPE,
	p_nActiveStartDt			IN		VEHICLE_COVERAGE.ACTIVE_START_DT%TYPE,
	p_nActiveEndDt				IN		VEHICLE_COVERAGE.ACTIVE_END_DT%TYPE,
	p_nReceivedStartDt		IN		VEHICLE_COVERAGE.RECEIVED_START_DT%TYPE,
	p_nReceivedEndDt			IN		VEHICLE_COVERAGE.RECEIVED_END_DT%TYPE,
	p_nDescr							IN		VEHICLE_COVERAGE_EXT.DESCR%TYPE );

PROCEDURE CreateFileTranLogRecord (
	p_nFileTranLogID	OUT		FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nFileTranDefID	IN		FILE_TRANSMISSION_DEF.FILE_TRANSMISSION_DEF_ID%TYPE,
	p_nFileName				IN		FILE_TRANSMISSION_LOG.FILE_NAME%TYPE,
	p_nStatus					IN		FILE_TRANSMISSION_LOG.STATUS%TYPE,
	p_nServer					IN		FILE_TRANSMISSION_LOG.SERVER%TYPE,
	p_nParenId				IN		FILE_TRANSMISSION_LOG.PARENT_ID%TYPE);
	
PROCEDURE UpdateFileTranLogStatus (
	p_nFileTranLogID	IN		FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nStatus					IN		FILE_TRANSMISSION_LOG.STATUS%TYPE);

PROCEDURE GetCityFromZip (
	p_nZipCode				IN		LOCATION_CODE.ZIP%TYPE,
	p_nCity						OUT		LOCATION_CODE.CITY%TYPE);
	
PROCEDURE GetStateFromZip (
	p_nZipCode				IN		LOCATION_CODE.ZIP%TYPE,
	p_nState						OUT	LOCATION_CODE.STATE%TYPE);

PROCEDURE UpdateKemperVendorNetwork (
	p_fileTranLogId						IN	VENDOR.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_recordCount							OUT	integer);

PROCEDURE UpdateCsaaVendorNetwork (
	p_fileTranLogId						IN	VENDOR.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_recordCount							OUT	integer);
	
PROCEDURE ProcessDriver(
	p_nDriverID				OUT		DRIVER.DRIVER_ID%TYPE,
	p_nFileTranLogId	IN		DRIVER.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nPolicyID				IN		DRIVER.POLICY_ID%TYPE,
	p_nSSN						IN		DRIVER.SSN%TYPE,
	p_nNameFirst			IN		DRIVER.NAME_FIRST%TYPE,
	p_nNameLast				IN		DRIVER.NAME_LAST%TYPE,
	p_nAddress1				IN		DRIVER.ADDRESS1%TYPE,
	p_nAddress2				IN		DRIVER.ADDRESS2%TYPE,
	p_nCity						IN		DRIVER.CITY%TYPE,
	p_nState					IN		DRIVER.STATE%TYPE,
	p_nZip						IN		DRIVER.ZIP%TYPE,
	p_nPhone					IN		DRIVER.PHONE%TYPE,
	p_nRelation				IN		DRIVER.RELATION_TO_INSURED%TYPE,
	p_nLicenseNumber	IN		DRIVER.LICENSE_NUMBER%TYPE,
	p_nUploadKey			IN		DRIVER.UPLOAD_KEY%TYPE,
	p_nActiveStartDt	IN		DRIVER.ACTIVE_START_DT%TYPE,
	p_nActiveEndDt		IN		DRIVER.ACTIVE_END_DT%TYPE,
	p_nDriverNumber		IN		DRIVER.DRIVER_NUMBER%TYPE,
	p_nBirthdDt				IN		DRIVER.BIRTH_DT%TYPE,
	p_nGender					IN		DRIVER.GENDER%TYPE
);

PROCEDURE ProcessVehicle(
	p_nVehicleID			OUT		VEHICLE.VEHICLE_ID%TYPE,
	p_nFileTranLogId	IN		VEHICLE.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nPolicyID				IN		VEHICLE.POLICY_ID%TYPE,
	p_nVIN						IN		VEHICLE.VIN%TYPE,
	p_nYEAR						IN		VEHICLE.YEAR%TYPE,
	p_nMAKE						IN		VEHICLE.MAKE%TYPE,
	p_nMODEL					IN		VEHICLE.MODEL%TYPE,
	p_nLICENSE_PLATE	IN		VEHICLE.LICENSE_PLATE%TYPE,
	p_nLICENSE_PLATE_STATE	IN		VEHICLE.LICENSE_PLATE_STATE%TYPE,
	p_nREGISTRATION_STATE		IN		VEHICLE.REGISTRATION_STATE%TYPE,
	p_nCOLOR					IN		VEHICLE.COLOR%TYPE,
	p_nUploadKey			IN		VEHICLE.UPLOAD_KEY%TYPE,
	p_nActiveStartDt	IN		VEHICLE.ACTIVE_START_DT%TYPE,
	p_nActiveEndDt		IN		VEHICLE.ACTIVE_END_DT%TYPE,
	p_nDriver1Number	IN		VEHICLE.DRIVER1_NUMBER%TYPE,
	p_nDriver1Percent	IN		VEHICLE.DRIVER1_PERCENT%TYPE,
	p_nDriver2Number	IN		VEHICLE.DRIVER2_NUMBER%TYPE,
	p_nDriver2Percent	IN		VEHICLE.DRIVER2_PERCENT%TYPE,
	p_nMisc						IN		VEHICLE.MISC%TYPE,
	p_nVehicleNumber	IN		VEHICLE.VEHICLE_NUMBER%TYPE 
);

PROCEDURE ProcessPolicyExtension(
	p_nPolExtID				OUT		POLICY_EXTENSION.POLICY_EXTENSION_ID%TYPE,
	p_nPolicyID				IN		POLICY_EXTENSION.POLICY_ID%TYPE,
	p_nName						IN		POLICY_EXTENSION.NAME%TYPE,
	p_nValue					IN		POLICY_EXTENSION.VALUE%TYPE,
	p_nUploadKey			IN		POLICY_EXTENSION.UPLOAD_KEY%TYPE,
	p_nFileTranLogId	IN		POLICY_EXTENSION.FILE_TRANSMISSION_LOG_ID%TYPE 
);
	
PROCEDURE GetTableDefinition (
	p_tableName				IN		USER_TAB_COLUMNS.TABLE_NAME%TYPE,
	results									OUT		CURSOR_TYPE);
	
PROCEDURE GetProcedureDefinition (
	p_packageName			IN		USER_ARGUMENTS.PACKAGE_NAME%TYPE,
	p_procedureName		IN		USER_ARGUMENTS.OBJECT_NAME%TYPE,
	results						OUT		CURSOR_TYPE);
	
PROCEDURE ProcessSpecificDestination (
    p_specDestId            OUT    SPECIFIC_DESTINATION.SPECIFIC_DESTINATION_ID%TYPE,
    p_ahsId                        IN    SPECIFIC_DESTINATION.ACCNT_HRCY_STEP_ID%TYPE,
    p_nameFirst                IN    SPECIFIC_DESTINATION.NAME_FIRST%TYPE,
    p_nameLast                IN    SPECIFIC_DESTINATION.NAME_LAST%TYPE,
    p_nameMid                 IN    SPECIFIC_DESTINATION.NAME_MI%TYPE,
    p_nameTitle                IN    SPECIFIC_DESTINATION.TITLE%TYPE,
    p_address1                IN    SPECIFIC_DESTINATION.ADDRESS1%TYPE,
    p_address2                IN  SPECIFIC_DESTINATION.ADDRESS2%TYPE,
    p_city                        IN  SPECIFIC_DESTINATION.CITY%TYPE,
    p_state                        IN  SPECIFIC_DESTINATION.STATE%TYPE,
    p_zip                            IN  SPECIFIC_DESTINATION.ZIP%TYPE,
    p_phone                        IN  SPECIFIC_DESTINATION.PHONE%TYPE,
    p_altFormFlg            IN  SPECIFIC_DESTINATION.ALTERNATE_FORM_FLG%TYPE,
    p_lobCd                        IN  SPECIFIC_DESTINATION.LOB%TYPE,
    p_uploadKey                    IN    SPECIFIC_DESTINATION.UPLOAD_KEY%TYPE,
    p_fileTranLogId                IN    SPECIFIC_DESTINATION.FILE_TRANSMISSION_LOG_ID%TYPE  );
    	
PROCEDURE ProcessSpecificDestSeqStep (
    p_specDestSeqStepId    OUT    SPECIFIC_DESTN_SEQ_STEP.SPECIFIC_DESTN_SEQ_STEP_ID%TYPE,
    p_specDestId                IN    SPECIFIC_DESTN_SEQ_STEP.SPECIFIC_DESTINATION_ID%TYPE,
    p_sequence                    IN    SPECIFIC_DESTN_SEQ_STEP.SEQUENCE%TYPE,
    p_retryCount                IN    SPECIFIC_DESTN_SEQ_STEP.RETRY_COUNT%TYPE,
    p_retryWaitTime         IN    SPECIFIC_DESTN_SEQ_STEP.RETRY_WAIT_TIME%TYPE,
    p_DestinationString    IN    SPECIFIC_DESTN_SEQ_STEP.DESTINATION_STRING%TYPE,
    p_tranTypeId                IN    SPECIFIC_DESTN_SEQ_STEP.TRANSMISSION_TYPE_ID%TYPE,
    p_altDestString         IN  SPECIFIC_DESTN_SEQ_STEP.ALT_DESTINATION_STRING%TYPE,
    p_fileTranLogId                IN    SPECIFIC_DESTN_SEQ_STEP.FILE_TRANSMISSION_LOG_ID%TYPE  );

PROCEDURE DoEsisLookupByPolicy (
	p_parentNodeId  		IN		ACCOUNT_HIERARCHY_STEP.PARENT_NODE_ID%TYPE DEFAULT NULL,
	p_permittedNodeId		IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE DEFAULT NULL,
	p_policyNumber			IN		POLICY.POLICY_NUMBER%TYPE DEFAULT NULL,
	p_lobCd							IN		POLICY.LOB_CD%TYPE DEFAULT NULL,
	p_locationCode  		IN		ACCOUNT_HIERARCHY_STEP.LOCATION_CODE%TYPE DEFAULT NULL,
	p_departmentCode 		IN		DEPARTMENT_CODES.DEPARTMENT_CODE%TYPE DEFAULT NULL,
	p_contractNumber 		IN		POLICY_EXTENSION.VALUE%TYPE DEFAULT NULL,
	p_name					 		IN		ACCOUNT_HIERARCHY_STEP.NAME%TYPE DEFAULT NULL,
	p_city					 		IN		ACCOUNT_HIERARCHY_STEP.CITY%TYPE DEFAULT NULL,
	p_state					 		IN		ACCOUNT_HIERARCHY_STEP.STATE%TYPE DEFAULT NULL,
	p_zip						 		IN		ACCOUNT_HIERARCHY_STEP.ZIP%TYPE DEFAULT NULL,
	results						OUT		CURSOR_TYPE);

PROCEDURE ProcessEmployeeExtension(
	p_nEmployeeExtId		OUT		EMPLOYEE_EXT.EMPLOYEE_EXT_ID%TYPE,
	p_nEmployeeId				IN		EMPLOYEE_EXT.EMPLOYEE_ID%TYPE,
	p_nFileTranLogId		IN		EMPLOYEE_EXT.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nFieldName				IN		EMPLOYEE_EXT.FIELD_NAME%TYPE,
	p_nFieldValue				IN		EMPLOYEE_EXT.FIELD_VALUE%TYPE
	 
);


PROCEDURE GetFipsFromZip(
	p_nZip					IN		LOCATION_CODE.ZIP%TYPE,
	p_nFips					OUT		LOCATION_CODE.FIPS%TYPE
	);
	
PROCEDURE GetZipFromCityState(
	p_nCity					IN		LOCATION_CODE.CITY%TYPE,
	p_nState				IN		LOCATION_CODE.STATE%TYPE,
	p_nZip					OUT		LOCATION_CODE.ZIP%TYPE
	);
	
PROCEDURE GetLocationAHSIDFromFein(
	p_nFein					IN		ACCOUNT_HIERARCHY_STEP.FEIN%TYPE,
	p_nAhsid				OUT		ACCOUNT_HIERARCHY_STEP.accnt_hrcy_step_id%TYPE
	);
	
PROCEDURE GetCountyFromZip(
	p_nZip					IN		LOCATION_CODE.ZIP%TYPE,
	p_nCounty					OUT		LOCATION_CODE.COUNTY%TYPE	
	);

PROCEDURE ProcessDepartmentCodes(
	p_nDepartmentCodeID		OUT		DEPARTMENT_CODES.DEPARTMENT_CODES_ID%TYPE,
	p_nAHSID				IN		DEPARTMENT_CODES.ACCNT_HRCY_STEP_ID%TYPE,
	p_nDepartmentCode		IN		DEPARTMENT_CODES.DEPARTMENT_CODE%TYPE,
	p_nName					IN		DEPARTMENT_CODES.DEPARTMENT_NAME%TYPE,
	p_nFileTranLogID		IN		DEPARTMENT_CODES.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nAccountNumber		IN		DEPARTMENT_CODES.ACCOUNT_NUMBER%TYPE
);
------------------------------------------------------------------------
--  returns AgentId for a given KEY
--  used by SAFETY to populate their policy data
------------------------------------------------------------------------	
PROCEDURE GetAgentIdFromUploadKey (
	p_nUploadKey				IN	AGENT.UPLOAD_KEY%TYPE,
	p_nresuts						OUT	AGENT.AGENT_ID%TYPE
);

----
--- The following stored procedures used by Alaska National data load
---
PROCEDURE ProcessAlternateName(
    p_nAlternateNameID                OUT        ALTERNATE_NAME.ALTERNATE_NAME_ID%TYPE,
    p_nAHSID                IN        ALTERNATE_NAME.ACCNT_HRCY_STEP_ID%TYPE,
    p_nName            IN        ALTERNATE_NAME.NAME%TYPE,
    p_nFileTranLogId    IN         ALTERNATE_NAME.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nSequenceNumber    IN            ALTERNATE_NAME.SEQUENCE_NUMBER%TYPE,
    p_nUploadKey        IN            ALTERNATE_NAME.UPLOAD_KEY%TYPE,
    p_nPolicyId			IN			   ALTERNATE_NAME.POLICY_ID%TYPE );
    
  

PROCEDURE ProcessANI_LocationCode(
    p_nANI_LocationCodeID       OUT     ANI_LOCATION_CODE.ANI_LOCATION_CODE_ID%TYPE,
    p_nAccountNumber            IN        ANI_LOCATION_CODE.ACCOUNT_NUMBER%TYPE,
    p_nAHSID                IN      ANI_LOCATION_CODE.ACCNT_HRCY_STEP_ID%TYPE,
    p_nCodingValue1   IN          ANI_LOCATION_CODE.CODINGVALUE1%TYPE,
    p_nCodingDesc1      IN          ANI_LOCATION_CODE.CODINGDESC1%TYPE,
    p_nCodingValue2     IN          ANI_LOCATION_CODE.CODINGVALUE2%TYPE,
    p_nCodingDesc2      IN          ANI_LOCATION_CODE.CODINGDESC2%TYPE,
    p_nCodingValue3     IN          ANI_LOCATION_CODE.CODINGVALUE3%TYPE,
    p_nCodingDesc3       IN         ANI_LOCATION_CODE.CODINGDESC3%TYPE,
    p_nCodingValue4     IN          ANI_LOCATION_CODE.CODINGVALUE4%TYPE,
    p_nCodingDesc4      IN          ANI_LOCATION_CODE.CODINGDESC4%TYPE,
    p_nCodingValue5     IN          ANI_LOCATION_CODE.CODINGVALUE5%TYPE,
    p_nCodingDesc5      IN          ANI_LOCATION_CODE.CODINGDESC5%TYPE,
    p_nUploadKey        IN          ANI_LOCATION_CODE.UPLOAD_KEY%TYPE,
    p_nFileTranLogId    IN         ANI_LOCATION_CODE.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nType1			IN			ANI_LOCATION_CODE.TYPE1%TYPE,
    p_nType2			IN			ANI_LOCATION_CODE.TYPE2%TYPE,
    p_nType3			IN			ANI_LOCATION_CODE.TYPE3%TYPE,
    p_nType4			IN			ANI_LOCATION_CODE.TYPE4%TYPE,
    p_nType5			IN			ANI_LOCATION_CODE.TYPE5%TYPE,
    p_nLastCodeValue	IN			ANI_LOCATION_CODE.LAST_CODEVALUE%TYPE,
    p_nLastCodeDescription	IN		ANI_LOCATION_CODE.LAST_CODEDESCRIPTION%TYPE
    
    );
    
  PROCEDURE GetPolicyIdFromUploadKey (
    p_nUploadKey                IN    POLICY.UPLOAD_KEY%TYPE,
    p_nPolicyId                        OUT    POLICY.POLICY_ID%TYPE
);

  PROCEDURE  UpdateANILocationCode (
    p_AccountNumber                        IN    ANI_LOCATION_CODE.ACCOUNT_NUMBER%TYPE,
    p_FileTranLogId                         IN      ANI_LOCATION_CODE.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_recordCount                            OUT    integer
);

Procedure UpdateANIAltInsuredRecords( 
	p_uploadKey     IN   POLICY.UPLOAD_KEY%TYPE,
	p_FileTranLogId  IN    POLICY.FILE_TRAN_LOG_ID%TYPE,
	p_recordCount  OUT    integer);
                                                   
PROCEDURE GetANIAHSRecord (
	p_AHSID					IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
	p_UploadKey			IN		ACCOUNT_HIERARCHY_STEP.UPLOAD_KEY%TYPE,
	results					OUT		CURSOR_TYPE
);
     
 
Procedure UpdateANIPolicyRecords    ( 
	p_AccountNumber     IN   ACCOUNT_HIERARCHY_STEP.LOCATION_CODE%TYPE,
	p_FileTranLogId  IN    ACCOUNT_HIERARCHY_STEP.FILE_TRAN_LOG_ID%TYPE,
	p_recordCount  OUT    integer      );   
	
---	                                       
---The above stored procedures used by Alaska National data load
---

PROCEDURE GetAppSetting (
    p_Application              IN    CONFIG_SETTINGS.APPLICATION%TYPE,
    p_Key					             IN    CONFIG_SETTINGS.KEY%TYPE,
    p_Results                 OUT    CONFIG_SETTINGS.VALUE%TYPE
);

END DBCLASSLIBRARY;
/

CREATE OR REPLACE PACKAGE BODY DBCLASSLIBRARY AS


------------------------------------------------------------------------
-- Get GetOverflowSet (AHSID,LOB_CD) 
-- returns Set of OUTPUT_OVERFLOW
------------------------------------------------------------------------	
PROCEDURE GetOverflowSet (
	p_accntHrcyStepId				IN		OUTPUT_OVERFLOW.ACCNT_HRCY_STEP_ID%TYPE,
	p_LineOfBusiness				IN		OUTPUT_OVERFLOW.LOB_CD%TYPE,
	results									OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
				Select	SEQUENCE,
								ATTRIBUTE_NAME,
								CAPTION,MAPPING,
								CAPTION_LENGTH,
								SHOW_WHEN_EMPTY_FLAG 
				from		OUTPUT_OVERFLOW 
				where		ACCNT_HRCY_STEP_ID = p_accntHrcyStepId and LOB_CD = p_LineOfBusiness
				order by SEQUENCE;

	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetOverflowSet;
		
------------------------------------------------------------------------
-- Get ACCOUNT_HIERARCHY_STEP record by AHSID 
-- returns Set of TYPE ACCOUNT_HIERARCHY_STEP
------------------------------------------------------------------------	
PROCEDURE GetAHSRecord (
	p_AHSID					IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
	p_UploadKey			IN		ACCOUNT_HIERARCHY_STEP.UPLOAD_KEY%TYPE,
	results					OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
		SELECT 
			ACCNT_HRCY_STEP_ID, 
			NODE_TYPE_ID, 
			PARENT_NODE_ID, 
			CLIENT_NODE_ID, 
			TYPE, 
			NAME, 
			NAME_FIRST, 
			NAME_LAST, 
			NAME_MI, 
			ADDRESS_1, 
			ADDRESS_2, 
			ADDRESS_3, 
			CITY, 
			STATE, 
			ZIP, 
			PHONE, 
			ALT_PHONE, 
			FAX, 
			ALT_FAX, 
			FIPS, 
			COUNTY, 
			COUNTRY, 
			FEIN, 
			SIC, 
			SUID, 
			NATURE_OF_BUSINESS, 
			NODE_LEVEL, 
			LOCATION_CODE, 
			UPLOAD_KEY, 
			ACTIVE_STATUS, 
			SEC_NAME, 
			SEC_CD, 
			LOC_NAME, 
			DIVISION_NAME, 
			DIVISION_CD, 
			DEPT_NAME, 
			DEPT_CD, 
			NAME_SHORT, 
			ACTEC_CD, 
			FILE_TRAN_LOG_ID, 
			ACCOUNT_FROM_DATE, 
			ACCOUNT_TO_DATE, 
			ACCOUNT_NAME, 
			EMAIL_ADDRESS, 
			NAICS_CD, 
			AGENT_BILLING_METHOD, 
			AGENT_PAYMENT_TYPE,
			SPECIFIC_DESTINATION_FLAG 
		from ACCOUNT_HIERARCHY_STEP
		WHERE ACCNT_HRCY_STEP_ID = p_AHSID OR UPLOAD_KEY = p_UploadKey;
	
	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetAHSRecord;		
------------------------------------------------------------------------
-- Get Mercury (EMAIL MSMQ)Destination(s) 
-- returns Set of TYPE MERCURY
------------------------------------------------------------------------	
PROCEDURE GetMercuryDestinations (
	destinationType					IN		MERCURY.TYPE%TYPE,
	results									OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
				SELECT HOST_MACHINE, QUEUE_NAME from MERCURY
				WHERE TYPE = destinationType;
	
	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetMercuryDestinations;
------------------------------------------------------------------------
-- GetEncrptAttributeSet 
-- returns Set of ENCRYPT_ATTRIBUTE attributes by LOB_CD 
-- for a given client AhsId
------------------------------------------------------------------------	
PROCEDURE GetEncrptAttributeSet (
	p_ahsId					IN		ENCRYPT_ATTRIBUTE.ACCNT_HRCY_STEP_ID%TYPE,
	p_lobCd					IN		ENCRYPT_ATTRIBUTE.LOB_CD%TYPE,
	p_encryptType		IN		ENCRYPT_ATTRIBUTE.ENCRYPT_TYPE%TYPE,
	results					OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
				Select	ATTRIBUTE_NAME,
								ENCRYPT_TYPE
				from		ENCRYPT_ATTRIBUTE 
				where		ACCNT_HRCY_STEP_ID = p_ahsId 
				and			LOB_CD = p_lobCd 
				and			ENCRYPT_TYPE = p_encryptType
				order by ATTRIBUTE_NAME;

	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetEncrptAttributeSet;
------------------------------------------------------------------------
-- GetFileTranDefSet returns the set of FILE_TRANSMISSION_DEF records
-- for a given AHSID, SERVER and TYPE
------------------------------------------------------------------------	
PROCEDURE GetFileTranDefSet (
	p_accntHrcyStepId	IN		FILE_TRANSMISSION_DEF.ACCNT_HRCY_STEP_ID%TYPE,
	p_Server					IN		FILE_TRANSMISSION_DEF.SERVER%TYPE,
	p_Type						IN		FILE_TRANSMISSION_DEF.TYPE%TYPE,
	results									OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
				Select	FILE_TRANSMISSION_DEF_ID,
								DIRECTORY,
								LAST_LOAD_SEQUENCE,
								FILE_NAME_PATTERN,
								LOCATION_IDENTIFIER,
								DESCRIPTION,
								SEQUENCE,
								SOURCE_LOCATION,
								DESTINATION_UIF_LOCATION,
								FROI_IMP_RECORD_ID
				from		FILE_TRANSMISSION_DEF 
				where		ACCNT_HRCY_STEP_ID = p_accntHrcyStepId 
						and SERVER = p_Server
						and TYPE = p_Type
				order by SEQUENCE;

	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetFileTranDefSet;

------------------------------------------------------------------------
-- ProcessClaimSubmissionLog insert or update request and response
-- return ID
------------------------------------------------------------------------	
PROCEDURE ProcessClaimSubmissionLog(
	p_id								OUT	CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE,
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_requestType				IN	VARCHAR2,
	clobData						IN	CLOB
)
IS
	v_id			CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE;
	
	CURSOR curClaimSubmissionRec
	IS
		SELECT *
		FROM CLAIM_SUBMISSION_LOG
		WHERE RQUID = p_rquID;

	CLAIM_REC     curClaimSubmissionRec%ROWTYPE;

BEGIN

	OPEN curClaimSubmissionRec;
	fetch curClaimSubmissionRec into CLAIM_REC;

	-- If no CLAIM_SUBMISSION_LOG record then we insert
	if curClaimSubmissionRec%NOTFOUND then
		
		v_id := SeqFunctions.GetNextSeq('CLAIM_SUBMISSION_LOG');
		
		if p_requestType = 'REQUEST' then
			INSERT INTO CLAIM_SUBMISSION_LOG (CLAIM_SUBMISSION_LOG_ID,RQUID,REQUEST) values(v_id,p_rquID, clobData);
		else
			INSERT INTO CLAIM_SUBMISSION_LOG (CLAIM_SUBMISSION_LOG_ID,RQUID,RESPONSE) values(v_id,p_rquID, clobData);
		end if;
	
	else
	
		v_id := CLAIM_REC.CLAIM_SUBMISSION_LOG_ID;
	
		if p_requestType = 'REQUEST' then
		
			UPDATE CLAIM_SUBMISSION_LOG SET RQUID = p_rquID,REQUEST = clobData 
				WHERE CLAIM_SUBMISSION_LOG_ID = v_id;
		
		else
		
			UPDATE CLAIM_SUBMISSION_LOG SET RQUID = p_rquID,RESPONSE = clobData
				WHERE CLAIM_SUBMISSION_LOG_ID = v_id;
		
		end if;
	end if;
	
	p_id := v_id;

EXCEPTION
	WHEN OTHERS THEN
		p_id := -1;
		raise;
		
END ProcessClaimSubmissionLog;

PROCEDURE UpdateClaimSubmissionLog(
    p_id                         OUT    CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE,
    p_rquID                      IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_requestType                IN    VARCHAR2,
    p_timestamp					 IN	   VARCHAR2,
    clobData                     IN    CLOB
)
IS
    v_id            CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE;
    
    CURSOR curClaimSubmissionRec
    IS
        SELECT *
        FROM CLAIM_SUBMISSION_LOG
        WHERE RQUID = p_rquID;

    CLAIM_REC     curClaimSubmissionRec%ROWTYPE;
    v_time_stamp  CLAIM_SUBMISSION_LOG.REQUEST_TIME%TYPE;

BEGIN

    OPEN curClaimSubmissionRec;
    fetch curClaimSubmissionRec into CLAIM_REC;
    
    v_time_stamp := TO_DATE(p_timestamp, 'YYYYMMDD HH24:MI:SS');

    -- If no CLAIM_SUBMISSION_LOG record then we insert
    if curClaimSubmissionRec%NOTFOUND then
        
        v_id := SeqFunctions.GetNextSeq('CLAIM_SUBMISSION_LOG');
        
        if p_requestType = 'REQUEST' then
            INSERT INTO CLAIM_SUBMISSION_LOG (CLAIM_SUBMISSION_LOG_ID,RQUID,REQUEST_TIME,REQUEST) values(v_id,p_rquID,v_time_stamp,clobData);
        else
            INSERT INTO CLAIM_SUBMISSION_LOG (CLAIM_SUBMISSION_LOG_ID,RQUID,RESPONSE_TIME,RESPONSE) values(v_id,p_rquID,v_time_stamp,clobData);
        end if;
    
    else
    
        v_id := CLAIM_REC.CLAIM_SUBMISSION_LOG_ID;
    
        if p_requestType = 'REQUEST' then
        
            UPDATE CLAIM_SUBMISSION_LOG SET RQUID = p_rquID, REQUEST_TIME = v_time_stamp, REQUEST = clobData 
                WHERE CLAIM_SUBMISSION_LOG_ID = v_id;
        
        else
        
            UPDATE CLAIM_SUBMISSION_LOG SET RQUID = p_rquID, RESPONSE_TIME = v_time_stamp, RESPONSE = clobData
                WHERE CLAIM_SUBMISSION_LOG_ID = v_id;
        
        end if;
    end if;
    
    p_id := v_id;

EXCEPTION
    WHEN OTHERS THEN
        p_id := -1;
        raise;
        
END UpdateClaimSubmissionLog;    

------------------------------------------------------------------------
-- CreateUpdateEntities insert or update entity responsed by RequestID
-- returns row ID
------------------------------------------------------------------------	
PROCEDURE CreateUpdateEntities(
	p_id							OUT	ENTITIES.ENTITY_ID%TYPE,
	p_rquID							IN	ENTITIES.RQUID%TYPE,
	p_sourceData					IN	CLOB)
IS
	v_id			ENTITIES.ENTITY_ID%TYPE;
	
	CURSOR curEntityRec
	IS
		SELECT *
		FROM ENTITIES
		WHERE RQUID = p_rquID;

	ENTITY_REC     curEntityRec%ROWTYPE;

BEGIN

	OPEN curEntityRec;
	fetch curEntityRec into ENTITY_REC;

	-- If no current Entity record then we insert
	if curEntityRec%NOTFOUND then
		
		v_id := SeqFunctions.GetNextSeq('ENTITIES');
		INSERT INTO ENTITIES (ENTITY_ID, RQUID, SOURCE) values (v_id, p_rquID, p_sourceData);
		
	else
		v_id := ENTITY_REC.ENTITY_ID;
		UPDATE ENTITIES SET SOURCE = p_sourceData 
				WHERE ENTITY_ID = v_id;
		
	end if;

	p_id := v_id;

EXCEPTION
	WHEN OTHERS THEN
		p_id := -1;
		raise;
		
END CreateUpdateEntities;	
------------------------------------------------------------------------
-- GetClaimSubLogData
-- return REQUEST or RESPONSE
------------------------------------------------------------------------	
PROCEDURE GetClaimSubLogData (
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_requestType				IN	VARCHAR2,
	clobData						OUT	CLOB
)
IS
	v_cData			CLOB;
	
BEGIN

	if p_requestType = 'REQUEST' then
		
		SELECT REQUEST INTO  v_cData FROM CLAIM_SUBMISSION_LOG
			WHERE RQUID = p_rquID;
	else
		SELECT RESPONSE INTO  v_cData FROM CLAIM_SUBMISSION_LOG
			WHERE RQUID = p_rquID;
	end if;
	
	clobData := v_cData;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetClaimSubLogData;

-----------------------------------------------------------------------
-- GetEntity
-- return SOURCE for Entity (Affirmative data contract)
------------------------------------------------------------------------	
PROCEDURE GetEntity(
	p_rquID							IN	ENTITIES.RQUID%TYPE,
	p_sourceData					OUT	CLOB)
IS
	v_cData			CLOB;
	
BEGIN

	SELECT SOURCE INTO  v_cData FROM ENTITIES
			WHERE RQUID = p_rquID;
	
	p_sourceData := v_cData;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetEntity;

------------------------------------------------------------------------
-- ResetClaimLogResponse
-- remove RESPONSE data
------------------------------------------------------------------------	
PROCEDURE ResetClaimLogResponse (
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_results						OUT	int
)
IS

BEGIN
	
	UPDATE CLAIM_SUBMISSION_LOG set RESPONSE = NULL
		WHERE RQUID = p_rquID;
		
	p_results := 1;


EXCEPTION
	WHEN OTHERS THEN
		p_results := 0;
		raise;
		
END ResetClaimLogResponse;

------------------------------------------------------------------------
-- UpdateProviderStatus
-- increments Call Counter and touch record
------------------------------------------------------------------------	
PROCEDURE UpdateProviderStatus (
	p_providerID							OUT	PROVIDER.PROVIDER_ID%TYPE,
	p_uID											IN	varchar2,
	p_statusCode							IN	varchar2,
	p_address1								IN PROVIDER.NEW_ADDRESS_1%TYPE,
	p_address2								IN PROVIDER.NEW_ADDRESS_2%TYPE,
	p_city										IN PROVIDER.NEW_CITY%TYPE,
	p_state										IN PROVIDER.NEW_STATE%TYPE,
	p_zipCode									IN PROVIDER.NEW_ZIP%TYPE,
	p_phone										IN PROVIDER.NEW_PHONE%TYPE,
	p_email										IN PROVIDER.NEW_EMAIL%TYPE,
	p_groupName								IN PROVIDER.NEW_GROUP_NAME%TYPE,
	p_groupContact  					IN PROVIDER.NEW_GROUP_CONTACT%TYPE,
	p_groupPhone	  					IN PROVIDER.NEW_GROUP_PHONE%TYPE,
	p_mailPreference					IN PROVIDER. MAIL_PREFERENCE%TYPE,
	p_comments								IN PROVIDER.COMMENTS%TYPE
)
IS
	
	v_count number default 0;
	
	CURSOR curProviderRec
	IS
		SELECT *
		FROM PROVIDER
		WHERE U_ID = p_uID;
		
	PROV_REC	curProviderRec%ROWTYPE;

BEGIN

	OPEN curProviderRec;
	fetch curProviderRec into PROV_REC;

	-- If no CLAIM_SUBMISSION_LOG record then we insert
	if curProviderRec%NOTFOUND then
		p_providerID := -1;
	else
	
		if PROV_REC.PROVIDER_CALL_COUNT is NULL then
			v_count := 0;
		else
			v_count := PROV_REC.PROVIDER_CALL_COUNT;
		end if;

		v_count := v_count + 1;
		
		UPDATE PROVIDER set PROVIDER_STATUS_CD = p_statusCode,
												PROVIDER_STATUS_DT = sysdate,
												LOCK_IND	= 'N',
												PROVIDER_CALL_COUNT = v_count,
												NEW_ADDRESS_1 = p_address1,
												NEW_ADDRESS_2 = p_address2,
												NEW_CITY = p_city,
												NEW_STATE = p_state,
												NEW_ZIP = p_zipCode,
												NEW_PHONE = p_phone,
												NEW_EMAIL = p_email,
												NEW_GROUP_NAME = p_groupName,
												NEW_GROUP_CONTACT = p_groupContact,
												NEW_GROUP_PHONE = p_groupPhone,
												MAIL_PREFERENCE = p_mailPreference,
												COMMENTS = p_comments
			WHERE PROVIDER_ID = PROV_REC.PROVIDER_ID;
												
		
		p_providerID := PROV_REC.PROVIDER_ID;
	end if;
	
EXCEPTION
	WHEN OTHERS THEN
		p_providerID := -1;
		raise;
		
END UpdateProviderStatus;

------------------------------------------------------------------------
-- UpdateProviderFollowupStatus
-- increments Call Counter and touch record
------------------------------------------------------------------------	
PROCEDURE UpdateProviderFollowupStatus (
	p_providerID							OUT	PROVIDER.PROVIDER_ID%TYPE,
	p_uID											IN	varchar2,
	p_statusCode							IN	varchar2,
	p_address1								IN PROVIDER.NEW_ADDRESS_1%TYPE,
	p_address2								IN PROVIDER.NEW_ADDRESS_2%TYPE,
	p_city										IN PROVIDER.NEW_CITY%TYPE,
	p_state										IN PROVIDER.NEW_STATE%TYPE,
	p_zipCode									IN PROVIDER.NEW_ZIP%TYPE,
	p_phone										IN PROVIDER.NEW_PHONE%TYPE,
	p_email										IN PROVIDER.NEW_EMAIL%TYPE,
	p_groupName								IN PROVIDER.NEW_GROUP_NAME%TYPE,
	p_groupContact  					IN PROVIDER.NEW_GROUP_CONTACT%TYPE,
	p_groupPhone	  					IN PROVIDER.NEW_GROUP_PHONE%TYPE,
	p_mailPreference					IN PROVIDER. MAIL_PREFERENCE%TYPE,
	p_comments								IN PROVIDER.COMMENTS%TYPE
)
IS
	
	v_count number default 0;
	
	CURSOR curProviderRec
	IS
		SELECT *
		FROM PROVIDER_FOLLOWUP
		WHERE U_ID = p_uID;
		
	PROV_REC	curProviderRec%ROWTYPE;

BEGIN

	OPEN curProviderRec;
	fetch curProviderRec into PROV_REC;

	-- If no CLAIM_SUBMISSION_LOG record then we insert
	if curProviderRec%NOTFOUND then
		p_providerID := -1;
	else
	
		if PROV_REC.PROVIDER_CALL_COUNT is NULL then
			v_count := 0;
		else
			v_count := PROV_REC.PROVIDER_CALL_COUNT;
		end if;

		v_count := v_count + 1;
		
		UPDATE PROVIDER_FOLLOWUP set PROVIDER_STATUS_CD = p_statusCode,
												PROVIDER_STATUS_DT = sysdate,
												LOCK_IND	= 'N',
												PROVIDER_CALL_COUNT = v_count,
												NEW_ADDRESS_1 = p_address1,
												NEW_ADDRESS_2 = p_address2,
												NEW_CITY = p_city,
												NEW_STATE = p_state,
												NEW_ZIP = p_zipCode,
												NEW_PHONE = p_phone,
												NEW_EMAIL = p_email,
												NEW_GROUP_NAME = p_groupName,
												NEW_GROUP_CONTACT = p_groupContact,
												NEW_GROUP_PHONE = p_groupPhone,
												MAIL_PREFERENCE = p_mailPreference,
												COMMENTS = p_comments
			WHERE PROVIDER_FOLLOWUP_ID = PROV_REC.PROVIDER_FOLLOWUP_ID;
												
		
		p_providerID := PROV_REC.PROVIDER_FOLLOWUP_ID;
	end if;
	
EXCEPTION
	WHEN OTHERS THEN
		p_providerID := -1;
		raise;
		
END UpdateProviderFollowupStatus;

------------------------------------------------------------------------
-- UnlockProvider
-- increments Call Counter and touch record
------------------------------------------------------------------------	
PROCEDURE UnlockProvider (
	p_providerID							OUT	PROVIDER.PROVIDER_ID%TYPE,
	p_uID											IN	varchar2
)
IS
	
	CURSOR curProviderRec
	IS
		SELECT *
		FROM PROVIDER
		WHERE U_ID = p_uID;
		
	PROV_REC	curProviderRec%ROWTYPE;

BEGIN

	OPEN curProviderRec;
	fetch curProviderRec into PROV_REC;

	-- If no CLAIM_SUBMISSION_LOG record then we insert
	if curProviderRec%NOTFOUND then
		p_providerID := -1;
	else
	
		UPDATE PROVIDER set LOCK_IND	= 'N'
			WHERE PROVIDER_ID = PROV_REC.PROVIDER_ID;
												
		p_providerID := PROV_REC.PROVIDER_ID;
		
	end if;
	
EXCEPTION
	WHEN OTHERS THEN
		p_providerID := -1;
		raise;
		
END UnlockProvider;


------------------------------------------------------------------------
-- UnlockProviderFollowup
-- increments Call Counter and touch record
------------------------------------------------------------------------	
PROCEDURE UnlockProviderFollowup (
	p_providerID							OUT	PROVIDER.PROVIDER_ID%TYPE,
	p_uID											IN	varchar2
)
IS
	
	CURSOR curProviderRec
	IS
		SELECT *
		FROM PROVIDER_FOLLOWUP
		WHERE U_ID = p_uID;
		
	PROV_REC	curProviderRec%ROWTYPE;

BEGIN

	OPEN curProviderRec;
	fetch curProviderRec into PROV_REC;

	-- If no CLAIM_SUBMISSION_LOG record then we insert
	if curProviderRec%NOTFOUND then
		p_providerID := -1;
	else
	
		UPDATE PROVIDER_FOLLOWUP set LOCK_IND	= 'N'
			WHERE PROVIDER_FOLLOWUP_ID = PROV_REC.PROVIDER_FOLLOWUP_ID;
												
		p_providerID := PROV_REC.PROVIDER_FOLLOWUP_ID;
		
	end if;
	
EXCEPTION
	WHEN OTHERS THEN
		p_providerID := -1;
		raise;
		
END UnlockProviderFollowup;



--------------------------------------------------------------------------------
----- CSAA and SELECTIVE extension to Vehicle Coverage records 
--------------------------------------------------------------------------------
PROCEDURE AddVehicleCoverageExtension (
	p_nVehicleCoverageExtId		OUT	VEHICLE_COVERAGE_EXT.VEHICLE_COVERAGE_EXT_ID%TYPE,
	p_nVehicleCoverageId			IN	VEHICLE_COVERAGE.VEHICLE_COVERAGE_ID%TYPE,
	p_nFileTranLogId					IN	VEHICLE_COVERAGE_EXT.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nDescr									IN	VEHICLE_COVERAGE_EXT.DESCR%TYPE
)
IS
	CURSOR curVehicleCoverageExtRec
	IS
		SELECT *
		FROM VEHICLE_COVERAGE_EXT
		WHERE VEHICLE_COVERAGE_ID = p_nVehicleCoverageId;

	VEH_COV_EXT_REC		 curVehicleCoverageExtRec%ROWTYPE;

BEGIN
	OPEN curVehicleCoverageExtRec;
	fetch curVehicleCoverageExtRec into VEH_COV_EXT_REC;

	-- If no POLICY record then insert
	IF curVehicleCoverageExtRec%NOTFOUND THEN
    
    -- Get the new POLICY ID
		p_nVehicleCoverageExtId := SeqFunctions.GetNextSeq('VEHICLE_COVERAGE_EXT');
		
		insert into VEHICLE_COVERAGE_EXT 
						(	
							VEHICLE_COVERAGE_EXT_ID,
							VEHICLE_COVERAGE_ID,
			   			FILE_TRANSMISSION_LOG_ID,
							DESCR							
						)
		VALUES		
						(	
							p_nVehicleCoverageExtId,
							p_nVehicleCoverageId,
							p_nFileTranLogId,
							p_nDescr	
						);
	ELSE

		p_nVehicleCoverageExtId :=  VEH_COV_EXT_REC.VEHICLE_COVERAGE_EXT_ID;

		update VEHICLE_COVERAGE_EXT
					set			FILE_TRANSMISSION_LOG_ID = p_nFileTranLogId,
									DESCR	= p_nDescr
				where
							VEHICLE_COVERAGE_EXT_ID = p_nVehicleCoverageExtId;

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_nVehicleCoverageExtId := -1;
	rollback;
	raise;

END AddVehicleCoverageExtension;
--------------------------------------------------------------------------------
----- CSAA and SELECTIVE ProcessVehicleCoverage
----- adapted from UIFSEGMENT package to include DESCR extension
--------------------------------------------------------------------------------
PROCEDURE ProcessVehicleCoverage(
	p_nVehicleCoverageID	OUT		VEHICLE_COVERAGE.VEHICLE_COVERAGE_ID%TYPE,
	p_nFileTranLogId		IN		VEHICLE_COVERAGE.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nVehicleID			IN		VEHICLE_COVERAGE.VEHICLE_ID%TYPE,
	p_nCOVERAGE_TYPE		IN		VEHICLE_COVERAGE.COVERAGE_TYPE%TYPE,
	p_nLIMIT1				IN		VEHICLE_COVERAGE.LIMIT1%TYPE,
	p_nLIMIT2				IN		VEHICLE_COVERAGE.LIMIT2%TYPE,
	p_nDEDUCTIBLE1			IN		VEHICLE_COVERAGE.DEDUCTIBLE1%TYPE,
	p_nDEDUCTIBLE2			IN		VEHICLE_COVERAGE.DEDUCTIBLE2%TYPE,
	p_nUploadKey			IN		VEHICLE_COVERAGE.UPLOAD_KEY%TYPE,
	p_nActiveStartDt		IN		VEHICLE_COVERAGE.ACTIVE_START_DT%TYPE,
	p_nActiveEndDt			IN		VEHICLE_COVERAGE.ACTIVE_END_DT%TYPE,
	p_nReceivedStartDt		IN		VEHICLE_COVERAGE.RECEIVED_START_DT%TYPE,
	p_nReceivedEndDt		IN		VEHICLE_COVERAGE.RECEIVED_END_DT%TYPE,
	p_nDescr							IN		VEHICLE_COVERAGE_EXT.DESCR%TYPE )
IS
	CURSOR curVehicleRec
	IS
		SELECT *
		FROM VEHICLE_COVERAGE
		WHERE UPLOAD_KEY = p_nUploadKey;

	CurActiveStart					VEHICLE_COVERAGE.ACTIVE_START_DT%TYPE;
	CurActiveEnd						VEHICLE_COVERAGE.ACTIVE_END_DT%TYPE;
	CurReceivedStart				VEHICLE_COVERAGE.RECEIVED_START_DT%TYPE;
	CurReceivedEnd					VEHICLE_COVERAGE.RECEIVED_END_DT%TYPE;
	v_VehicleCoverageExtId	VEHICLE_COVERAGE_EXT.VEHICLE_COVERAGE_EXT_ID%TYPE;

	VEHICLE_REC		 curVehicleRec%ROWTYPE;

BEGIN
	
	IF p_nActiveStartDt IS NULL THEN
	  CurActiveStart := NULL;
	ELSE
	  CurActiveStart := p_nActiveStartDt;
	END IF;
	
	IF p_nActiveEndDt IS NULL THEN
	  CurActiveEnd := NULL;
	ELSE
	  CurActiveEnd := p_nActiveEndDt;
	END IF;

	IF p_nReceivedStartDt IS NULL THEN
	  CurReceivedStart := NULL;
	ELSE
	  CurReceivedStart := p_nReceivedStartDt;
	END IF;
	
	IF p_nReceivedEndDt IS NULL THEN
	  CurReceivedEnd := NULL;
	ELSE
	  CurReceivedEnd := p_nReceivedEndDt;
	END IF;


	OPEN curVehicleRec;
	fetch curVehicleRec into VEHICLE_REC;

	-- If no POLICY record then insert
	IF curVehicleRec%NOTFOUND THEN
    
    -- Get the new POLICY ID
		p_nVehicleCoverageId := SeqFunctions.GetNextSeq('VEHICLE_COVERAGE');
		
		insert into VEHICLE_COVERAGE 
						(	
							VEHICLE_COVERAGE_ID,
			   			 	FILE_TRANSMISSION_LOG_ID,
							VEHICLE_ID,
							COVERAGE_TYPE,
							LIMIT1,
							LIMIT2,
							DEDUCTIBLE1,
							DEDUCTIBLE2,
							ACTIVE_START_DT,
							ACTIVE_END_DT,
							RECEIVED_START_DT,
							RECEIVED_END_DT,
							UPLOAD_KEY
						)
		VALUES		
						(	
							p_nVehicleCoverageId,
							p_nFileTranLogId,
							p_nVehicleId,
							p_nCOVERAGE_TYPE,
							p_nLIMIT1,
							p_nLIMIT2,
							p_nDEDUCTIBLE1,
							p_nDEDUCTIBLE2,
							CurActiveStart,
							CurActiveEnd,
							CurReceivedStart,
							CurReceivedEnd,
							p_nUploadKey	
						);	
							
		update 	VEHICLE_COVERAGE SET RECEIVED_END_DT = CurActiveStart - 1 
		where 	VEHICLE_ID = p_nVehicleId and COVERAGE_TYPE = p_nCOVERAGE_TYPE 
				and ACTIVE_END_DT = CurActiveEnd and VEHICLE_COVERAGE_ID <> p_nVehicleCoverageId;

	ELSE

		p_nVehicleCoverageId :=  VEHICLE_REC.VEHICLE_COVERAGE_ID;

		IF VEHICLE_REC.ACTIVE_END_DT <> CurActiveEnd THEN
			CurReceivedEnd := CurActiveEnd;
		END IF;
		
		update VEHICLE_COVERAGE
					set				FILE_TRANSMISSION_LOG_ID   = p_nFileTranLogId,
									VEHICLE_ID				  = p_nVehicleId,
									COVERAGE_TYPE			 = p_nCOVERAGE_TYPE,
									LIMIT1					= p_nLIMIT1,
									LIMIT2				   = p_nLIMIT2,
									DEDUCTIBLE1			  = p_nDEDUCTIBLE1,
									DEDUCTIBLE2			 = p_nDEDUCTIBLE2,
									ACTIVE_END_DT	   = CurActiveEnd,
									RECEIVED_START_DT = CurReceivedStart,
									RECEIVED_END_DT  = CurReceivedEnd,
									UPLOAD_KEY      = p_nUploadKey
				where
							VEHICLE_COVERAGE_ID    = p_nVehicleCoverageId;

	END IF;
	
	IF p_nDescr IS NOT NULL THEN
		AddVehicleCoverageExtension (v_VehicleCoverageExtId,p_nVehicleCoverageId,p_nFileTranLogId,p_nDescr);	
	END IF;
	
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_nVehicleCoverageId := -1;
	rollback;
	raise;

END ProcessVehicleCoverage;				

------------------------------------------------------------------------
--  Create a new FileTranLog Record
--  return the pk (no update)
------------------------------------------------------------------------	
PROCEDURE CreateFileTranLogRecord (
	p_nFileTranLogId	OUT		FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nFileTranDefId	IN		FILE_TRANSMISSION_DEF.FILE_TRANSMISSION_DEF_ID%TYPE,
	p_nFileName				IN		FILE_TRANSMISSION_LOG.FILE_NAME%TYPE,
	p_nStatus					IN		FILE_TRANSMISSION_LOG.STATUS%TYPE,
	p_nServer					IN		FILE_TRANSMISSION_LOG.SERVER%TYPE,
	p_nParenId				IN		FILE_TRANSMISSION_LOG.PARENT_ID%TYPE
)
IS
	
	v_FileTranLogId FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE;

BEGIN
			
	v_FileTranLogId := SeqFunctions.GetNextSeq('FILE_TRANSMISSION_LOG');
	
	INSERT INTO FILE_TRANSMISSION_LOG (
							FILE_TRANSMISSION_LOG_ID,
							FILE_TRANSMISSION_DEF_ID,
							FILE_NAME,
							STATUS,
							SERVER,
							PARENT_ID,
							CREATED_DATE,
							MODIFIED_DATE)
			VALUES ( 
							v_FileTranLogId,
							p_nFileTranDefID,
							p_nFileName,
							p_nStatus,
							p_nServer,
							p_nParenId,
							sysdate,
							sysdate);
																								
																								
	p_nFileTranLogID := v_FileTranLogId;
			
			
	EXCEPTION
	WHEN OTHERS THEN
		v_FileTranLogId := -1;
		raise;
		
END CreateFileTranLogRecord;
------------------------------------------------------------------------
--  Update FileTranLog Record STATUS
--  return void
------------------------------------------------------------------------	
PROCEDURE UpdateFileTranLogStatus (
	p_nFileTranLogID	IN		FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nStatus					IN		FILE_TRANSMISSION_LOG.STATUS%TYPE
)
IS

BEGIN
			
	
	UPDATE  FILE_TRANSMISSION_LOG 
		SET STATUS = p_nStatus, 
				MODIFIED_DATE = sysdate
		WHERE
				FILE_TRANSMISSION_LOG_ID = p_nFileTranLogID;
																								
																								
	EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END UpdateFileTranLogStatus;
------------------------------------------------------------------------
--  returns CITY value for a given Zip
--  used by CSAA per their request to spplement specific cases where
--- the CITY attribute is not present in the source 
------------------------------------------------------------------------	
PROCEDURE GetCityFromZip (
	p_nZipCode				IN		LOCATION_CODE.ZIP%TYPE,
	p_nCity						OUT		LOCATION_CODE.CITY%TYPE
)
IS
	CURSOR curLocationCodeRec
	IS
		SELECT *
		FROM LOCATION_CODE
		WHERE ZIP = p_nZipCode
					AND PRIMARY_LOC = 'Y'
					AND SEQ = 1;
	
	Loc_Rec	curLocationCodeRec%ROWTYPE;
	

BEGIN
	OPEN curLocationCodeRec;
	fetch curLocationCodeRec into Loc_Rec;
	
	-- If no POLICY record then insert
	IF curLocationCodeRec%FOUND THEN
		
		p_nCity := Loc_Rec.CITY;
																																	
	END IF;
		
EXCEPTION
	WHEN OTHERS THEN
		p_nCity := 'UNKNOWN';
		
END GetCityFromZip;

------------------------------------------------------------------------
--  returns STATE value for a given Zip
--  used by ALM per their request to spplement specific cases where
--- the STATE attribute is not present in correct form 
------------------------------------------------------------------------	
PROCEDURE GetStateFromZip (
	p_nZipCode				IN		LOCATION_CODE.ZIP%TYPE,
	p_nState					OUT		LOCATION_CODE.STATE%TYPE
)
IS
	CURSOR curLocationCodeRec
	IS
		SELECT *
		FROM LOCATION_CODE
		WHERE ZIP = p_nZipCode
					AND PRIMARY_LOC = 'Y'
					AND SEQ = 1;
	
	Loc_Rec	curLocationCodeRec%ROWTYPE;
	

BEGIN
	OPEN curLocationCodeRec;
	fetch curLocationCodeRec into Loc_Rec;
	
	-- If no POLICY record then insert
	IF curLocationCodeRec%FOUND THEN
		
		p_nState := Loc_Rec.STATE;
																																	
	END IF;
		
EXCEPTION
	WHEN OTHERS THEN
		p_nState := '';
		
END GetStateFromZip;
------------------------------------------------------------------------
--  remove any and all VENDOR records from KMP load that were NOT
--  touched by the most recent load (fileTranLogId)
--- Kemper requires each load to be full refresh. 
------------------------------------------------------------------------	
PROCEDURE UpdateKemperVendorNetwork (
	p_fileTranLogId						IN	VENDOR.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_recordCount							OUT	integer
)
IS
	v_recordCount integer;
	
BEGIN

	SELECT COUNT(*) INTO v_recordCount 
		from VENDOR 
		where SPECIALTY_CD = 'KM' 
		and FILE_TRANSMISSION_LOG_ID < p_fileTranLogId;
		
	IF v_recordCount > 0 THEN
	
		delete from VENDOR_NETWORK where NETWORK_ID = 73 and VENDOR_ID IN 
			( select VENDOR_ID from VENDOR 
				where SPECIALTY_CD = 'KM' 
				and FILE_TRANSMISSION_LOG_ID < p_fileTranLogId);
				
		delete from VENDOR_SERVICE where  VENDOR_ID IN 
			( select VENDOR_ID from VENDOR 
				where SPECIALTY_CD = 'KM' 
				and FILE_TRANSMISSION_LOG_ID < p_fileTranLogId);
				
		delete from VENDOR 
			where SPECIALTY_CD = 'KM' 
			and FILE_TRANSMISSION_LOG_ID < p_fileTranLogId;
	
		COMMIT;
		
	END IF;
	
EXCEPTION
	WHEN OTHERS THEN
		p_recordCount := 0;
		
END UpdateKemperVendorNetwork;	
------------------------------------------------------------------------
--  remove any and all VENDOR records from CSA load that were NOT
--  touched by the most recent load (fileTranLogId)
--- Kemper requires each load to be full refresh. 
------------------------------------------------------------------------	
PROCEDURE UpdateCsaaVendorNetwork (
	p_fileTranLogId						IN	VENDOR.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_recordCount							OUT	integer
)
IS
	v_recordCount integer;
	
BEGIN

	SELECT COUNT(*) INTO v_recordCount 
		from VENDOR 
		where upload_key like 'CSA%'
		and FILE_TRANSMISSION_LOG_ID < p_fileTranLogId;
		
	IF v_recordCount > 0 THEN
	
		delete from VENDOR_NETWORK where NETWORK_ID = 123 and VENDOR_ID IN 
			( select VENDOR_ID from VENDOR 
				where upload_key like 'CSA%' 
				and FILE_TRANSMISSION_LOG_ID < p_fileTranLogId);
				
		delete from VENDOR_SERVICE where  VENDOR_ID IN 
			( select VENDOR_ID from VENDOR 
				where upload_key like 'CSA%'
				and FILE_TRANSMISSION_LOG_ID < p_fileTranLogId);
				
		delete from VENDOR 
			where upload_key like 'CSA%' 
			and FILE_TRANSMISSION_LOG_ID < p_fileTranLogId;
	
		COMMIT;
		
	END IF;
	
EXCEPTION
	WHEN OTHERS THEN
		p_recordCount := 0;
		
END UpdateCsaaVendorNetwork;	
------------------------------------------------------------------------
--  submit DRIVER inserts or updates with encryption
--  of certain fields...
------------------------------------------------------------------------	
PROCEDURE ProcessDriver(
	p_nDriverID				OUT		DRIVER.DRIVER_ID%TYPE,
	p_nFileTranLogId		IN		DRIVER.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nPolicyID				IN		DRIVER.POLICY_ID%TYPE,
	p_nSSN					IN		DRIVER.SSN%TYPE,
	p_nNameFirst			IN		DRIVER.NAME_FIRST%TYPE,
	p_nNameLast				IN		DRIVER.NAME_LAST%TYPE,
	p_nAddress1				IN		DRIVER.ADDRESS1%TYPE,
	p_nAddress2				IN		DRIVER.ADDRESS2%TYPE,
	p_nCity					IN		DRIVER.CITY%TYPE,
	p_nState				IN		DRIVER.STATE%TYPE,
	p_nZip					IN		DRIVER.ZIP%TYPE,
	p_nPhone				IN		DRIVER.PHONE%TYPE,
	p_nRelation				IN		DRIVER.RELATION_TO_INSURED%TYPE,
	p_nLicenseNumber		IN		DRIVER.LICENSE_NUMBER%TYPE,
	p_nUploadKey			IN		DRIVER.UPLOAD_KEY%TYPE,
	p_nActiveStartDt		IN		DRIVER.ACTIVE_START_DT%TYPE,
	p_nActiveEndDt			IN		DRIVER.ACTIVE_END_DT%TYPE,
	p_nDriverNumber			IN		DRIVER.DRIVER_NUMBER%TYPE,
	p_nBirthdDt				IN		DRIVER.BIRTH_DT%TYPE,
	p_nGender				IN		DRIVER.GENDER%TYPE
)
IS
	
BEGIN
	
	UIFSEGMENT.ProcessDriver(
						p_nDriverID,
						p_nFileTranLogId,
						p_nPolicyID,
						DesEncrypt(p_nSSN),
						p_nNameFirst,
						p_nNameLast,
						p_nAddress1,
						p_nAddress2,
						p_nCity,
						p_nState,
						p_nZip,
						p_nPhone,
						p_nRelation,
						DesEncrypt(p_nLicenseNumber),
						p_nUploadKey,
						p_nActiveStartDt,
						p_nActiveEndDt,
						p_nDriverNumber,
						NULL,
						p_nGender);

EXCEPTION
	WHEN OTHERS THEN
	p_nDriverID := -1;

END ProcessDriver;

PROCEDURE ProcessVehicle(
	p_nVehicleID			OUT		VEHICLE.VEHICLE_ID%TYPE,
	p_nFileTranLogId		IN		VEHICLE.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nPolicyID				IN		VEHICLE.POLICY_ID%TYPE,
	p_nVIN					IN		VEHICLE.VIN%TYPE,
	p_nYEAR					IN		VEHICLE.YEAR%TYPE,
	p_nMAKE					IN		VEHICLE.MAKE%TYPE,
	p_nMODEL				IN		VEHICLE.MODEL%TYPE,
	p_nLICENSE_PLATE		IN		VEHICLE.LICENSE_PLATE%TYPE,
	p_nLICENSE_PLATE_STATE	IN		VEHICLE.LICENSE_PLATE_STATE%TYPE,
	p_nREGISTRATION_STATE	IN		VEHICLE.REGISTRATION_STATE%TYPE,
	p_nCOLOR				IN		VEHICLE.COLOR%TYPE,
	p_nUploadKey			IN		VEHICLE.UPLOAD_KEY%TYPE,
	p_nActiveStartDt		IN		VEHICLE.ACTIVE_START_DT%TYPE,
	p_nActiveEndDt			IN		VEHICLE.ACTIVE_END_DT%TYPE,
	p_nDriver1Number		IN		VEHICLE.DRIVER1_NUMBER%TYPE,
	p_nDriver1Percent		IN		VEHICLE.DRIVER1_PERCENT%TYPE,
	p_nDriver2Number		IN		VEHICLE.DRIVER2_NUMBER%TYPE,
	p_nDriver2Percent		IN		VEHICLE.DRIVER2_PERCENT%TYPE,
	p_nMisc					IN		VEHICLE.MISC%TYPE,
	p_nVehicleNumber		IN		VEHICLE.VEHICLE_NUMBER%TYPE 
)
IS

BEGIN
	
	UIFSEGMENT.ProcessVehicle(
						p_nVehicleID,
						p_nFileTranLogId,
						p_nPolicyID,
						DesEncrypt(p_nVIN),
						p_nYEAR,
						p_nMAKE,
						p_nMODEL,
						DesEncrypt(p_nLICENSE_PLATE),
						p_nLICENSE_PLATE_STATE,
						p_nREGISTRATION_STATE,
						p_nCOLOR,
						p_nUploadKey,
						p_nActiveStartDt,
						p_nActiveEndDt,
						p_nDriver1Number,
						p_nDriver1Percent,
						p_nDriver2Number,
						p_nDriver2Percent,
						p_nMisc,
						p_nVehicleNumber );

EXCEPTION
	WHEN OTHERS THEN
	p_nVehicleID := -1;

END ProcessVehicle;

PROCEDURE ProcessPolicyExtension(
	p_nPolExtID				OUT		POLICY_EXTENSION.POLICY_EXTENSION_ID%TYPE,
	p_nPolicyID				IN		POLICY_EXTENSION.POLICY_ID%TYPE,
	p_nName					IN		POLICY_EXTENSION.NAME%TYPE,
	p_nValue				IN		POLICY_EXTENSION.VALUE%TYPE,
	p_nUploadKey			IN		POLICY_EXTENSION.UPLOAD_KEY%TYPE,
	p_nFileTranLogId		IN		POLICY_EXTENSION.FILE_TRANSMISSION_LOG_ID%TYPE )
IS
	CURSOR curPolicyExtRec
	IS
		SELECT *
		FROM POLICY_EXTENSION
		WHERE POLICY_ID = p_nPolicyID
		AND NAME = p_nName;

	POLICY_EXT_REC		 curPolicyExtRec%ROWTYPE;


BEGIN

	OPEN curPolicyExtRec;
	fetch curPolicyExtRec into POLICY_EXT_REC;

	-- If no POLICY record then insert
	IF curPolicyExtRec%NOTFOUND THEN

    -- Get the new POLICY ID
		p_nPolExtID := SeqFunctions.GetNextSeq('POLICY_EXTENSION');

		insert into POLICY_EXTENSION
						(
							POLICY_EXTENSION_ID,
			   			 	FILE_TRANSMISSION_LOG_ID,
							POLICY_ID,
							NAME,
							VALUE,
							UPLOAD_KEY
						)
		VALUES
						(
							p_nPolExtID,
							p_nFileTranLogId,
							p_nPolicyID,
							p_nName,
							p_nValue,
							p_nUploadKey
						);

	ELSE

		p_nPolExtID :=  POLICY_EXT_REC.POLICY_EXTENSION_ID;

		update POLICY_EXTENSION
						set				FILE_TRANSMISSION_LOG_ID	= p_nFileTranLogId,
										POLICY_ID					= p_nPolicyID,
										NAME						= p_nName,
										VALUE						= p_nValue
					where
										POLICY_EXTENSION_ID = p_nPolExtID;

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_nPolExtID := -1;
	rollback;
	raise;

END ProcessPolicyExtension;

------------------------------------------------------------------------
-- GetTableDefinition
-- return SCHEMA for TABLE
------------------------------------------------------------------------	
PROCEDURE GetTableDefinition (
	p_tableName				IN		USER_TAB_COLUMNS.TABLE_NAME%TYPE,
	results									OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
				Select	COLUMN_ID, 
								COLUMN_NAME, 
								DATA_TYPE, 
								DATA_LENGTH,
								DATA_PRECISION, 
								DATA_SCALE, 
								NULLABLE, 
								DATA_DEFAULT
				from		USER_TAB_COLUMNS 
				where		TABLE_NAME = p_tableName
				ORDER BY COLUMN_ID;

	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetTableDefinition;

------------------------------------------------------------------------
-- GetProcedureDefinition
-- return SCHEMA for Stored Procedures
------------------------------------------------------------------------	
PROCEDURE GetProcedureDefinition (
	p_packageName			IN		USER_ARGUMENTS.PACKAGE_NAME%TYPE,
	p_procedureName		IN		USER_ARGUMENTS.OBJECT_NAME%TYPE,
	results						OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
		SELECT	POSITION,
						ARGUMENT_NAME,
						DATA_TYPE,	   
						IN_OUT
		from		USER_ARGUMENTS 
		where PACKAGE_NAME = UPPER(p_packageName)
					AND OBJECT_NAME = UPPER(p_procedureName)
		ORDER BY POSITION;

	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetProcedureDefinition;
------------------------------------------------------------------------
-- GetProcedureDefinition
-- return ESIS policy lookup resultset by policy number
------------------------------------------------------------------------	
PROCEDURE DoEsisLookupByPolicy (
	p_parentNodeId  		IN		ACCOUNT_HIERARCHY_STEP.PARENT_NODE_ID%TYPE DEFAULT NULL,
	p_permittedNodeId		IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE DEFAULT NULL,
	p_policyNumber			IN		POLICY.POLICY_NUMBER%TYPE DEFAULT NULL,
	p_lobCd							IN		POLICY.LOB_CD%TYPE DEFAULT NULL,
	p_locationCode  		IN		ACCOUNT_HIERARCHY_STEP.LOCATION_CODE%TYPE DEFAULT NULL,
	p_departmentCode 		IN		DEPARTMENT_CODES.DEPARTMENT_CODE%TYPE DEFAULT NULL,
	p_contractNumber 		IN		POLICY_EXTENSION.VALUE%TYPE DEFAULT NULL,
	p_name					 		IN		ACCOUNT_HIERARCHY_STEP.NAME%TYPE DEFAULT NULL,
	p_city					 		IN		ACCOUNT_HIERARCHY_STEP.CITY%TYPE DEFAULT NULL,
	p_state					 		IN		ACCOUNT_HIERARCHY_STEP.STATE%TYPE DEFAULT NULL,
	p_zip						 		IN		ACCOUNT_HIERARCHY_STEP.ZIP%TYPE DEFAULT NULL,
	results						OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
		SELECT 	DISTINCT 
						to_char(AHSP.AHS_POLICY_ID) AS POLICY_ID, 
						to_char(DPT.DEPARTMENT_CODES_ID) AS DEPT_ID,
						AHSP.LOB_CD, 
						AHS.ACCNT_HRCY_STEP_ID, 
						AHS.NAME, 
						AHS.LOCATION_CODE,  
						POL.POLICY_NUMBER,
						to_char(POL.EFFECTIVE_DATE), 
						to_char(POL.EXPIRATION_DATE),
						TO_CHAR(POL.EFFECTIVE_DATE,'MM/DD/YYYY') || ' - ' || TO_CHAR(POL.EXPIRATION_DATE,'MM/DD/YYYY') POL_DATE,
						AHS.ADDRESS_1, 
						AHS.CITY, 
						AHS.STATE, 
						AHS.ZIP ,
						AHS.TYPE,
						AHS.PARENT_NODE_ID, 
						POL.POLICY_DESC, 
						DPT.DEPARTMENT_CODE,
						DPT.DEPARTMENT_NAME, 
						PE.VALUE AS CONTRACT_NUMBER
		FROM 
						ACCOUNT_HIERARCHY_STEP AHS, 
						AHS_POLICY AHSP, 
						POLICY POL, 
						DEPARTMENT_CODES DPT, 
						POLICY_EXTENSION PE
		WHERE 
						AHS.CLIENT_NODE_ID = 202
						AND AHS.ACTIVE_STATUS = 'ACTIVE' 
						AND AHSP.ACCNT_HRCY_STEP_ID = AHS.ACCNT_HRCY_STEP_ID
						AND AHSP.POLICY_ID = POL.POLICY_ID 
						AND AHS.ACCNT_HRCY_STEP_ID = DPT.ACCNT_HRCY_STEP_ID (+)
						AND POL.POLICY_ID=PE.POLICY_ID(+)
						AND AHSP.LOB_CD = p_lobCd
						AND (POL.POLICY_NUMBER LIKE DECODE(p_policyNumber,NULL,NULL,CONCAT(p_policyNumber,'%')) OR p_policyNumber IS NULL )
						AND (AHS.LOCATION_CODE LIKE DECODE(p_locationCode,NULL,NULL,CONCAT(p_locationCode,'%')) OR p_locationCode IS NULL)
						AND (AHS.PARENT_NODE_ID = p_parentNodeId OR p_parentNodeId IS NULL)
						AND (IS_PERMITTED(AHS.ACCNT_HRCY_STEP_ID,p_permittedNodeId) = 1 OR p_permittedNodeId IS NULL)
						AND (AHS.NAME LIKE DECODE(p_name,NULL,NULL,CONCAT(p_name,'%')) OR p_name IS NULL)
						AND (AHS.CITY LIKE DECODE(p_city,NULL,NULL,CONCAT(p_city,'%')) OR p_city IS NULL)
						AND (AHS.STATE = DECODE(p_state,NULL,NULL,p_state) OR p_state IS NULL)
						AND (AHS.ZIP LIKE DECODE(p_zip,NULL,NULL,CONCAT(p_zip,'%')) OR p_zip IS NULL)
		ORDER BY AHS.NAME, LOCATION_CODE;
						
	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END DoEsisLookupByPolicy;
------------------------------------------------------------------------
-- ProcessSpecificDestination
-- insert/update for SPECIFIC_DESTINATION table
------------------------------------------------------------------------
PROCEDURE ProcessSpecificDestination (
    p_specDestId            OUT    SPECIFIC_DESTINATION.SPECIFIC_DESTINATION_ID%TYPE,
    p_ahsId                        IN    SPECIFIC_DESTINATION.ACCNT_HRCY_STEP_ID%TYPE,
    p_nameFirst                IN    SPECIFIC_DESTINATION.NAME_FIRST%TYPE,
    p_nameLast                IN    SPECIFIC_DESTINATION.NAME_LAST%TYPE,
    p_nameMid                 IN    SPECIFIC_DESTINATION.NAME_MI%TYPE,
    p_nameTitle                IN    SPECIFIC_DESTINATION.TITLE%TYPE,
    p_address1                IN    SPECIFIC_DESTINATION.ADDRESS1%TYPE,
    p_address2                IN  SPECIFIC_DESTINATION.ADDRESS2%TYPE,
    p_city                        IN  SPECIFIC_DESTINATION.CITY%TYPE,
    p_state                        IN  SPECIFIC_DESTINATION.STATE%TYPE,
    p_zip                            IN  SPECIFIC_DESTINATION.ZIP%TYPE,
    p_phone                        IN  SPECIFIC_DESTINATION.PHONE%TYPE,
    p_altFormFlg            IN  SPECIFIC_DESTINATION.ALTERNATE_FORM_FLG%TYPE,
    p_lobCd                        IN  SPECIFIC_DESTINATION.LOB%TYPE,
    p_uploadKey                    IN    SPECIFIC_DESTINATION.UPLOAD_KEY%TYPE,
    p_fileTranLogId                IN    SPECIFIC_DESTINATION.FILE_TRANSMISSION_LOG_ID%TYPE )
IS
    CURSOR curSpecificDestRec
    IS
        SELECT *
					FROM SPECIFIC_DESTINATION
					WHERE ACCNT_HRCY_STEP_ID = p_ahsId
					AND ((NAME_LAST = p_nameLast) OR (NAME_LAST IS NULL and p_nameLast IS NULL))
					AND ((NAME_FIRST = p_nameFirst)  OR (NAME_FIRST IS NULL and p_nameFirst IS NULL))
					AND ((ADDRESS1 = p_address1)  OR (ADDRESS1 IS NULL and p_address1 IS NULL))
					AND ((CITY = p_city)  OR (CITY IS NULL and p_city IS NULL))
					AND ((STATE = p_state)  OR (STATE IS NULL and p_state IS NULL))
					AND ((ZIP = p_zip)  OR (ZIP IS NULL and p_zip IS NULL));


    DESTINATION_REC         curSpecificDestRec%ROWTYPE;


BEGIN

    OPEN curSpecificDestRec;
    fetch curSpecificDestRec into DESTINATION_REC;

    -- If no POLICY record then insert
    IF curSpecificDestRec%NOTFOUND THEN

    -- Get the new POLICY ID
        p_specDestId := SeqFunctions.GetNextSeq('SPECIFIC_DESTINATION');

        insert into SPECIFIC_DESTINATION
                        (
                            SPECIFIC_DESTINATION_ID,
                           ACCNT_HRCY_STEP_ID,
                            NAME_FIRST,
                            NAME_LAST,
                            NAME_MI,
                            TITLE,
                            ADDRESS1,
                            ADDRESS2,
                            CITY,
                            STATE,
                            ZIP,
                            PHONE,
                            ALTERNATE_FORM_FLG,
                            LOB,
                            UPLOAD_KEY,
                            FILE_TRANSMISSION_LOG_ID
                        )
        VALUES
                        (
                            p_specDestId,
                            p_ahsId,
                            p_nameFirst,
                            p_nameLast,
                            p_nameMid,
                            p_nameTitle,
                            p_address1,
                            p_address2,
                            p_city,
                            p_state,
                            p_zip,
                            p_phone,
                            p_altFormFlg,
                            p_lobCd,
                            p_uploadKey,
                            p_fileTranLogId
                        );

    ELSE

        p_specDestId :=  DESTINATION_REC.SPECIFIC_DESTINATION_ID;

        update SPECIFIC_DESTINATION
                        set            ADDRESS2    = p_address2,
                                        TITLE = p_nameTitle,
                                        PHONE    = p_phone,
                                        ALTERNATE_FORM_FLG = p_altFormFlg,
                                        LOB    = p_lobCd,
                                        FILE_TRANSMISSION_LOG_ID = p_fileTranLogId
                    where
                                        SPECIFIC_DESTINATION_ID = p_specDestId;

    END IF;
    COMMIT;

EXCEPTION
    WHEN OTHERS THEN
    p_specDestId := -1;
    raise;
    
END ProcessSpecificDestination;    

------------------------------------------------------------------------
-- ProcessSpecificDestSeqStep
-- insert/update for SPECIFIC_DESTN_SEQ_STEP table
------------------------------------------------------------------------
PROCEDURE ProcessSpecificDestSeqStep (
    p_specDestSeqStepId    OUT    SPECIFIC_DESTN_SEQ_STEP.SPECIFIC_DESTN_SEQ_STEP_ID%TYPE,
    p_specDestId                IN    SPECIFIC_DESTN_SEQ_STEP.SPECIFIC_DESTINATION_ID%TYPE,
    p_sequence                    IN    SPECIFIC_DESTN_SEQ_STEP.SEQUENCE%TYPE,
    p_retryCount                IN    SPECIFIC_DESTN_SEQ_STEP.RETRY_COUNT%TYPE,
    p_retryWaitTime         IN    SPECIFIC_DESTN_SEQ_STEP.RETRY_WAIT_TIME%TYPE,
    p_DestinationString    IN    SPECIFIC_DESTN_SEQ_STEP.DESTINATION_STRING%TYPE,
    p_tranTypeId                IN    SPECIFIC_DESTN_SEQ_STEP.TRANSMISSION_TYPE_ID%TYPE,
    p_altDestString         IN  SPECIFIC_DESTN_SEQ_STEP.ALT_DESTINATION_STRING%TYPE,
    p_fileTranLogId                IN    SPECIFIC_DESTN_SEQ_STEP.FILE_TRANSMISSION_LOG_ID%TYPE  )
IS
	CURSOR curSpecificDestStepRec
	IS
		SELECT *
		FROM SPECIFIC_DESTN_SEQ_STEP
		WHERE SPECIFIC_DESTINATION_ID = p_specDestId
		AND TRANSMISSION_TYPE_ID = p_tranTypeId
		AND DESTINATION_STRING = p_DestinationString;

	DESTINATION_REC		 curSpecificDestStepRec%ROWTYPE;


BEGIN

	OPEN curSpecificDestStepRec;
	fetch curSpecificDestStepRec into DESTINATION_REC;

	-- If no POLICY record then insert
	IF curSpecificDestStepRec%NOTFOUND THEN

    -- Get the new POLICY ID
		p_specDestSeqStepId := SeqFunctions.GetNextSeq('SPECIFIC_DESTN_SEQ_STEP');

		insert into SPECIFIC_DESTN_SEQ_STEP
                        (
                            SPECIFIC_DESTN_SEQ_STEP_ID,
                           SPECIFIC_DESTINATION_ID,
                            SEQUENCE,
                            RETRY_COUNT,
                            RETRY_WAIT_TIME,
                            DESTINATION_STRING,
                            TRANSMISSION_TYPE_ID,
                            ALT_DESTINATION_STRING,
                            FILE_TRANSMISSION_LOG_ID
                        )
        VALUES
                        (
                            p_specDestSeqStepId,
                            p_specDestId,
                            p_sequence,
                            p_retryCount,
                            p_retryWaitTime,
                            p_DestinationString,
                            p_tranTypeId,
                            p_altDestString,
                            p_fileTranLogId
                        );

	ELSE

		p_specDestSeqStepId :=  DESTINATION_REC.SPECIFIC_DESTN_SEQ_STEP_ID;

        update SPECIFIC_DESTN_SEQ_STEP
                        set            SEQUENCE = p_sequence,
                                        RETRY_COUNT    = p_retryCount,
                                        RETRY_WAIT_TIME = p_retryWaitTime,
                                        ALT_DESTINATION_STRING    = p_altDestString,
                                        FILE_TRANSMISSION_LOG_ID  = p_fileTranLogId
                    where
                                        SPECIFIC_DESTN_SEQ_STEP_ID = p_specDestSeqStepId;

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_specDestSeqStepId := -1;
	raise;
	
END ProcessSpecificDestSeqStep;

------------------------------------------------------------------------
--  Addes EMPLOYEE_EXT records for IPM Employee loads
--  used by CRA Cisco
--- Can be extended to all UIF
------------------------------------------------------------------------	
PROCEDURE ProcessEmployeeExtension(
	p_nEmployeeExtId		OUT		EMPLOYEE_EXT.EMPLOYEE_EXT_ID%TYPE,
	p_nEmployeeId				IN		EMPLOYEE_EXT.EMPLOYEE_ID%TYPE,
	p_nFileTranLogId		IN		EMPLOYEE_EXT.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nFieldName				IN		EMPLOYEE_EXT.FIELD_NAME%TYPE,
	p_nFieldValue				IN		EMPLOYEE_EXT.FIELD_VALUE%TYPE
)
IS
	CURSOR curEmployeeExtRec
	IS
		SELECT *
		FROM EMPLOYEE_EXT
		WHERE EMPLOYEE_ID = p_nEmployeeId
			AND  FIELD_NAME = p_nFieldName;

	EMP_EXT_REC		 curEmployeeExtRec%ROWTYPE;


BEGIN
	
	OPEN curEmployeeExtRec;
	fetch curEmployeeExtRec into EMP_EXT_REC;

	-- If no POLICY record then insert
	IF curEmployeeExtRec%NOTFOUND THEN
    
		-- Get the new POLICY ID
		p_nEmployeeExtId := SeqFunctions.GetNextSeq('EMPLOYEE_EXT');
		
		insert into EMPLOYEE_EXT 
						(	
							EMPLOYEE_EXT_ID,
			   			FILE_TRANSMISSION_LOG_ID,
							EMPLOYEE_ID,
							FIELD_NAME,
							FIELD_VALUE
						)
		VALUES		
						(	
							p_nEmployeeExtId,
							p_nFileTranLogId,
							p_nEmployeeId,
							p_nFieldName,
							p_nFieldValue
						);									

	ELSE

		p_nEmployeeExtId :=  EMP_EXT_REC.EMPLOYEE_EXT_ID;
		
		update EMPLOYEE_EXT
						set			FILE_TRANSMISSION_LOG_ID	= p_nFileTranLogId,
										FIELD_NAME					= p_nFieldName,
										FIELD_VALUE					= p_nFieldValue
					where
										EMPLOYEE_EXT_ID = p_nEmployeeExtId;

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_nEmployeeExtId := -1;
	rollback;

END ProcessEmployeeExtension;

------------------------------------------------------------------------
--  returns AgentId for a given KEY
--  used by SAFETY to populate their policy data
------------------------------------------------------------------------	
PROCEDURE GetAgentIdFromUploadKey (
	p_nUploadKey				IN	AGENT.UPLOAD_KEY%TYPE,
	p_nresuts						OUT	AGENT.AGENT_ID%TYPE
)
IS
	v_cId			AGENT.AGENT_ID%TYPE;	
	
BEGIN
	select AGENT_ID into v_cId from AGENT where UPLOAD_KEY = p_nUploadKey;
	
	-- If no POLICY record then insert
	IF v_cId IS NOT NULL THEN
		
		p_nresuts := v_cId;
	ELSE
		p_nresuts := 0;
																																	
	END IF;
		
EXCEPTION
	WHEN OTHERS THEN
		p_nresuts := -1;
		
END GetAgentIdFromUploadKey;

--------------------------------------------------------------------------
-- return Fips using Zip
--------------------------------------------------------------------------
PROCEDURE GetFipsFromZip (
    p_nZip                IN        LOCATION_CODE.ZIP%TYPE,
    p_nFips	             OUT        LOCATION_CODE.FIPS%TYPE
)
IS
    CURSOR curLocationCodeRec
    IS
        SELECT *
        FROM LOCATION_CODE
        WHERE ZIP = p_nZip
                    AND PRIMARY_LOC = 'Y';
                       
    Loc_Rec    curLocationCodeRec%ROWTYPE;
    

BEGIN
    OPEN curLocationCodeRec;
    fetch curLocationCodeRec into Loc_Rec;
    
    -- If no POLICY record then insert
    IF curLocationCodeRec%FOUND THEN
        
        p_nFips := Loc_Rec.FIPS;
    
                                                                                                                                    
    END IF;
        
EXCEPTION
    WHEN OTHERS THEN
        p_nFIPS := '00000';
        
END GetFipsFromZip;


--------------------------------------------------------------------------
-- return Zip if possible from CITY and STATE
--------------------------------------------------------------------------
PROCEDURE GetZipFromCityState(
	p_nCity					IN		LOCATION_CODE.CITY%TYPE,
	p_nState				IN		LOCATION_CODE.STATE%TYPE,
	p_nZip					OUT		LOCATION_CODE.ZIP%TYPE
)
IS
    CURSOR curLocationCodeRec
    IS
        SELECT *
        FROM LOCATION_CODE
        WHERE CITY = p_nCity AND STATE = p_nState
                    AND PRIMARY_LOC = 'Y';
                       
    Loc_Rec    curLocationCodeRec%ROWTYPE;
    

BEGIN
    OPEN curLocationCodeRec;
    fetch curLocationCodeRec into Loc_Rec;
    
    -- If no POLICY record then insert
    IF curLocationCodeRec%FOUND THEN
        
        p_nZip := Loc_Rec.ZIP;
    
                 
    ELSE
			 p_nZip := '';      
			                                                                                                              
    END IF;
        
EXCEPTION
    WHEN OTHERS THEN
        p_nZip := '';
        
END GetZipFromCityState;

--------------------------------------------------------------------------
-- return Ahs record from Fein
--------------------------------------------------------------------------
PROCEDURE GetLocationAhsidFromFein (
    p_nFein                IN        ACCOUNT_HIERARCHY_STEP.FEIN%TYPE,
    p_nAhsid	            OUT        ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE
)
IS
    CURSOR curLocationRec
    IS
        SELECT *
        FROM ACCOUNT_HIERARCHY_STEP
        WHERE FEIN = p_nFein
        AND CLIENT_NODE_ID = 202
        AND TYPE = 'RISK LOCATION';
                       
    Loc_Rec    curLocationRec%ROWTYPE;
    

BEGIN
    OPEN curLocationRec;
    fetch curLocationRec into Loc_Rec;
    
    IF curLocationRec%FOUND THEN
        
        p_nAhsid := Loc_Rec.accnt_hrcy_step_id;
    
                                                                                                                                    
    END IF;
        
EXCEPTION
    WHEN OTHERS THEN
        p_nAhsid := '';
        
END GetLocationAhsidFromFein;

--------------------------------------------------------------------------
-- return County using Zip for Esis Load
--------------------------------------------------------------------------
PROCEDURE GetCountyFromZip (
    p_nZip                IN        LOCATION_CODE.ZIP%TYPE,
    p_nCounty	             OUT        LOCATION_CODE.COUNTY%TYPE
)
IS
    CURSOR curLocationCodeRec
    IS
        SELECT *
        FROM LOCATION_CODE
        WHERE ZIP = p_nZip
                    AND PRIMARY_LOC = 'Y';
                       
    Loc_Rec    curLocationCodeRec%ROWTYPE;
    

BEGIN
    OPEN curLocationCodeRec;
    fetch curLocationCodeRec into Loc_Rec;
    
    -- If no POLICY record then insert
    IF curLocationCodeRec%FOUND THEN
        
        p_nCounty := Loc_Rec.COUNTY;
    
                                                                                                                                    
    END IF;
        
EXCEPTION
    WHEN OTHERS THEN
        p_nCounty := '';
        
END GetCountyFromZip;

----------------------------------
-- Added for Alaska National 

----------------------------------

PROCEDURE ProcessAlternateName(
    p_nAlternateNameID                OUT        ALTERNATE_NAME.ALTERNATE_NAME_ID%TYPE,
    p_nAHSID                IN        ALTERNATE_NAME.ACCNT_HRCY_STEP_ID%TYPE,
    p_nName            IN        ALTERNATE_NAME.NAME%TYPE,
    p_nFileTranLogId    IN         ALTERNATE_NAME.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nSequenceNumber    IN            ALTERNATE_NAME.SEQUENCE_NUMBER%TYPE,
    p_nUploadKey        IN            ALTERNATE_NAME.UPLOAD_KEY%TYPE,
    p_nPolicyId			IN			   ALTERNATE_NAME.POLICY_ID%TYPE )
IS
    CURSOR curAlternateNameRec
    IS
        SELECT *
        FROM ALTERNATE_NAME
        WHERE    UPLOAD_KEY = p_nUploadKey;

   AlternateName_REC                 curAlternateNameRec%ROWTYPE;


BEGIN

    OPEN curAlternateNameRec;
    fetch curAlternateNameRec into  AlternateName_REC;

    
    IF curAlternateNameRec%NOTFOUND THEN

        p_nAlternateNameID := SeqFunctions.GetNextSeq('ALTERNATE_NAME');

        insert into ALTERNATE_NAME (    ALTERNATE_NAME_ID,
                                        ACCNT_HRCY_STEP_ID,
                                        NAME,
                                        FILE_TRANSMISSION_LOG_ID,
                                        SEQUENCE_NUMBER,
                                        UPLOAD_KEY,
                                        POLICY_ID
                                )
            VALUES
                                (
                                    p_nAlternateNameID,
                                    p_nAHSID,
                                    p_nName,
                                    p_nFileTranLogId,
                                    p_nSequenceNumber,
                                    p_nUploadKey,
                                    p_nPolicyId
                                );
    ELSE

        p_nAlternateNameID :=  AlternateName_REC.Alternate_Name_ID;

        update ALTERNATE_NAME    set       NAME = p_nNAME,
                                FILE_TRANSMISSION_LOG_ID = p_nFileTranLogId,
                                SEQUENCE_NUMBER   = p_nSequenceNumber,
                                ACCNT_HRCY_STEP_ID = p_nAHSID,
                                POLICY_ID = p_nPolicyId
                                where
                                        upload_key = p_nUploadKey;
                                       

    END IF;
    COMMIT;

EXCEPTION
    WHEN OTHERS THEN
    p_nAlternateNameID := -1;
    rollback;

END ProcessAlternateName;



--
-- Added for Alaska National
---
PROCEDURE ProcessANI_LocationCode(
    p_nANI_LocationCodeID       OUT     ANI_LOCATION_CODE.ANI_LOCATION_CODE_ID%TYPE,
    p_nAccountNumber            IN        ANI_LOCATION_CODE.ACCOUNT_NUMBER%TYPE,
    p_nAHSID                IN      ANI_LOCATION_CODE.ACCNT_HRCY_STEP_ID%TYPE,
    p_nCodingValue1   IN          ANI_LOCATION_CODE.CODINGVALUE1%TYPE,
    p_nCodingDesc1      IN          ANI_LOCATION_CODE.CODINGDESC1%TYPE,
    p_nCodingValue2     IN          ANI_LOCATION_CODE.CODINGVALUE2%TYPE,
    p_nCodingDesc2      IN          ANI_LOCATION_CODE.CODINGDESC2%TYPE,
    p_nCodingValue3     IN          ANI_LOCATION_CODE.CODINGVALUE3%TYPE,
    p_nCodingDesc3       IN         ANI_LOCATION_CODE.CODINGDESC3%TYPE,
    p_nCodingValue4     IN          ANI_LOCATION_CODE.CODINGVALUE4%TYPE,
    p_nCodingDesc4      IN          ANI_LOCATION_CODE.CODINGDESC4%TYPE,
    p_nCodingValue5     IN          ANI_LOCATION_CODE.CODINGVALUE5%TYPE,
    p_nCodingDesc5      IN          ANI_LOCATION_CODE.CODINGDESC5%TYPE,
    p_nUploadKey        IN          ANI_LOCATION_CODE.UPLOAD_KEY%TYPE,
    p_nFileTranLogId    IN         ANI_LOCATION_CODE.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nType1			IN			ANI_LOCATION_CODE.TYPE1%TYPE,
    p_nType2			IN			ANI_LOCATION_CODE.TYPE2%TYPE,
    p_nType3			IN			ANI_LOCATION_CODE.TYPE3%TYPE,
    p_nType4			IN			ANI_LOCATION_CODE.TYPE4%TYPE,
    p_nType5			IN			ANI_LOCATION_CODE.TYPE5%TYPE,
    p_nLastCodeValue	IN			ANI_LOCATION_CODE.LAST_CODEVALUE%TYPE,
    p_nLastCodeDescription	IN		ANI_LOCATION_CODE.LAST_CODEDESCRIPTION%TYPE
        
    )
IS
    CURSOR curANI_Location_CodeRec
    IS
        SELECT *
        FROM ANI_LOCATION_CODE
        WHERE    UPLOAD_KEY = p_nUploadKey;

  ANI_LOCATION_CODE_REC                 curANI_Location_CodeRec%ROWTYPE;


BEGIN

    OPEN curANI_Location_CodeRec;
    fetch curANI_Location_CodeRec into   ANI_LOCATION_CODE_REC;

    
    IF curANI_Location_CodeRec%NOTFOUND THEN

       p_nANI_LocationCodeID := SeqFunctions.GetNextSeq('ANI_LOCATION_CODE');

        insert into ANI_LOCATION_CODE ( ANI_LOCATION_CODE_ID,
                                        
                                        ACCOUNT_NUMBER,
                                        ACCNT_HRCY_STEP_ID,
                                        CODINGVALUE1,
                                        CODINGDESC1,
                                        CODINGVALUE2,
                                        CODINGDESC2,
                                        CODINGVALUE3,
                                        CODINGDESC3,
                                        CODINGVALUE4,
                                        CODINGDESC4,
                                        CODINGVALUE5,
                                        CODINGDESC5,
                                        UPLOAD_KEY,                                                                           
                                        FILE_TRANSMISSION_LOG_ID,
                                        TYPE1,
                                        TYPE2,
                                        TYPE3,
                                        TYPE4,
                                        TYPE5,
                                        LAST_CODEVALUE,
                                        LAST_CODEDESCRIPTION
                                )
            VALUES
                                (
                                    p_nANI_LocationCodeID,
                                    p_nAccountNumber,
                                    p_nAHSID,
                                    p_nCodingValue1,
                                    p_nCodingDesc1,
                                    p_nCodingValue2,
                                    p_nCodingDesc2,
                                    p_nCodingValue3,
                                    p_nCodingDesc3,
                                    p_nCodingValue4,
                                    p_nCodingDesc4,
                                    p_nCodingValue5,
                                    p_nCodingDesc5,
                                    p_nUploadKey,
                                    p_nFileTranLogId,
                                    p_nType1,
                                    p_nType2,
                                    p_nType3,
                                    p_nType4,
                                    p_nType5,
                                    p_nLastCodeValue,
                                    p_nLastCodeDescription
                                );
    ELSE

        p_nANI_LocationCodeID :=  ANI_LOCATION_CODE_REC.ANI_LOCATION_CODE_ID;

        update ANI_LOCATION_CODE    set    ACCOUNT_NUMBER = p_nAccountNumber,
                                ACCNT_HRCY_STEP_ID = p_nAHSID,
                                CODINGVALUE1 = p_nCodingValue1,
                                CODINGDESC1 = p_nCodingDesc1,
                                CODINGVALUE2 = p_nCodingValue2,
                                CODINGDESC2 = p_nCodingDesc2,
                                CODINGVALUE3 = p_nCodingValue3,
                                CODINGDESC3 = p_nCodingDesc3,
                                CODINGVALUE4 = p_nCodingValue4,
                                CODINGDESC4 = p_nCodingDesc4,
                                CODINGVALUE5 = p_nCodingValue5,
                                CODINGDESC5 = p_nCodingDesc5,
                                FILE_TRANSMISSION_LOG_ID = p_nFileTranLogId,
                                TYPE1 = p_nType1,
                                TYPE2 = p_nType2,
                                TYPE3 = p_nType3,
                                TYPE4 = p_nType4,
                                TYPE5 = p_nType5,
                                LAST_CODEVALUE = p_nLastCodeValue,
                                LAST_CODEDESCRIPTION = p_nLastCodeDescription
                                where  ANI_LOCATION_CODE_ID = p_nANI_LocationCodeID;

    END IF;
    COMMIT;

EXCEPTION
    WHEN OTHERS THEN
    p_nANI_LocationCodeID := -1;
   -- rollback;

END ProcessANI_LocationCode;

---To derive the Policy ID using Upload_key to process Alaska National Alternate Insured Data File

PROCEDURE GetPolicyIdFromUploadKey (
    p_nUploadKey                IN    POLICY.UPLOAD_KEY%TYPE,
    p_nPolicyId                        OUT    POLICY.POLICY_ID%TYPE
)
IS
    v_cId            POLICY.POLICY_ID%TYPE;    
    
BEGIN
    select POLICY_ID into v_cId from POLICY where UPLOAD_KEY = p_nUploadKey;
    
    
    IF v_cId IS NOT NULL THEN
        
        p_nPolicyId := v_cId;
    ELSE
        p_nPolicyId := 0;
                                                                                                                                    
    END IF;
        
EXCEPTION
    WHEN OTHERS THEN
        p_nPolicyId := -1;
        
END GetPolicyIdFromUploadKey;

--Update Location Code records for Alaska National by deleting 
--the old existing location code records for any given account number provided in the location code data file

PROCEDURE  UpdateANILocationCode (
    p_AccountNumber                        IN    ANI_LOCATION_CODE.ACCOUNT_NUMBER%TYPE,
    p_FileTranLogId                         IN      ANI_LOCATION_CODE.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_recordCount                            OUT    integer
)
IS
    v_recordCount integer;
    
BEGIN

    SELECT COUNT(*) INTO v_recordCount 
        from ANI_LOCATION_CODE 
        where ACCOUNT_NUMBER = p_AccountNumber 
        and FILE_TRANSMISSION_LOG_ID < p_FileTranLogId;
        
   IF v_recordCount > 0 THEN
    
        delete from ANI_LOCATION_CODE where ACCOUNT_NUMBER = p_AccountNumber 
               and FILE_TRANSMISSION_LOG_ID < p_FileTranLogId;
                
      p_recordCount := v_recordCount;
        
    
        COMMIT;
        
   END IF;
   
   
    
EXCEPTION
    WHEN OTHERS THEN
        p_recordCount := 0;
        
END UpdateANILocationCode;

-- Update Alternate Insured Name records for Alaska National

Procedure UpdateANIAltInsuredRecords( p_uploadKey     IN   POLICY.UPLOAD_KEY%TYPE,
                                                 p_FileTranLogId  IN    POLICY.FILE_TRAN_LOG_ID%TYPE,
                                                   p_recordCount  OUT    integer)
                                              
                                               
IS

v_recordCount integer;
    
BEGIN



    SELECT COUNT(*) INTO v_recordCount 
        from POLICY P
        where P.UPLOAD_KEY = p_uploadKey;
        
        
      
       
        
   IF v_recordCount > 0 THEN

         delete from ALTERNATE_NAME A where A.FILE_TRANSMISSION_LOG_ID < p_FileTranLogId
         AND A.POLICY_ID IN (         
         SELECT P.POLICY_ID FROM POLICY P
          WHERE P.UPLOAD_KEY = p_uploadKey);
          
           
     commit;
     
      v_recordCount := p_recordCount;
      
   End if;
   
   EXCEPTION
    WHEN OTHERS THEN
        p_recordCount := 0;
        
END UpdateANIAltInsuredRecords;  


--Get AHSRecord for Alaska National 


PROCEDURE GetANIAHSRecord (
	p_AHSID					IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
	p_UploadKey			IN		ACCOUNT_HIERARCHY_STEP.UPLOAD_KEY%TYPE,
	results					OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
		SELECT 
			ACCNT_HRCY_STEP_ID, 
			NODE_TYPE_ID, 
			PARENT_NODE_ID, 
			CLIENT_NODE_ID, 
			TYPE, 
			NAME, 
			NAME_FIRST, 
			NAME_LAST, 
			NAME_MI, 
			ADDRESS_1, 
			ADDRESS_2, 
			ADDRESS_3, 
			CITY, 
			STATE, 
			ZIP, 
			PHONE, 
			ALT_PHONE, 
			FAX, 
			ALT_FAX, 
			FIPS, 
			COUNTY, 
			COUNTRY, 
			FEIN, 
			SIC, 
			SUID, 
			NATURE_OF_BUSINESS, 
			NODE_LEVEL, 
			LOCATION_CODE, 
			UPLOAD_KEY, 
			ACTIVE_STATUS, 
			SEC_NAME, 
			SEC_CD, 
			LOC_NAME, 
			DIVISION_NAME, 
			DIVISION_CD, 
			DEPT_NAME, 
			DEPT_CD, 
			NAME_SHORT, 
			ACTEC_CD, 
			FILE_TRAN_LOG_ID, 
			ACCOUNT_FROM_DATE, 
			ACCOUNT_TO_DATE, 
			ACCOUNT_NAME, 
			EMAIL_ADDRESS, 
			NAICS_CD, 
			AGENT_BILLING_METHOD, 
			AGENT_PAYMENT_TYPE,
			SPECIFIC_DESTINATION_FLAG 
		from ACCOUNT_HIERARCHY_STEP
		WHERE ACTIVE_STATUS = 'ACTIVE' AND (ACCNT_HRCY_STEP_ID = p_AHSID OR UPLOAD_KEY = p_UploadKey);
	
	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetANIAHSRecord;	

--
--Update Policy Records throughly for Alaska National

--

Procedure UpdateANIPolicyRecords    ( p_AccountNumber     IN   ACCOUNT_HIERARCHY_STEP.LOCATION_CODE%TYPE,
                                                 p_FileTranLogId  IN    ACCOUNT_HIERARCHY_STEP.FILE_TRAN_LOG_ID%TYPE,
                                                   p_recordCount  OUT    integer
                                                   )
                                                
IS

v_recordCount integer;
    
BEGIN

    SELECT COUNT(*) INTO v_recordCount 
        from ACCOUNT_HIERARCHY_STEP AHS 
        where AHS.LOCATION_CODE = p_AccountNumber
        and ahs.CLIENT_NODE_ID = 152
        and ahs.type = 'INSURED' 
        and ahs.ACTIVE_STATUS = 'ACTIVE'
        and AHS.FILE_TRAN_LOG_ID < p_FileTranLogId;
        
       
        
   IF v_recordCount > 0 THEN

    
      
          
    delete from ahs_policy ahsp where policy_id in
        (         
         SELECT P.POLICY_ID FROM POLICY P, FILE_TRANSMISSION_LOG L , FILE_TRANSMISSION_DEF D
          WHERE P.COMPANY_CODE = p_AccountNumber and p.DIVISION_CD = 'ANI'
          AND L.FILE_TRANSMISSION_DEF_ID = D.FILE_TRANSMISSION_DEF_ID
          AND P.FILE_TRAN_LOG_ID = L.FILE_TRANSMISSION_LOG_ID
          AND L.FILE_TRANSMISSION_LOG_ID < p_FileTranLogId
          AND D.ACCNT_HRCY_STEP_ID =152
          AND D.FILE_TRANSMISSION_DEF_ID IN (4130,4310));
          
          
       
     
     
     commit;
     
      v_recordCount := p_recordCount;
      
   End if;
   
   EXCEPTION
    WHEN OTHERS THEN
        p_recordCount := 0;
        
END UpdateANIPolicyRecords;  

PROCEDURE ProcessDepartmentCodes(
	p_nDepartmentCodeID		OUT		DEPARTMENT_CODES.DEPARTMENT_CODES_ID%TYPE,
	p_nAHSID				IN		DEPARTMENT_CODES.ACCNT_HRCY_STEP_ID%TYPE,
	p_nDepartmentCode		IN		DEPARTMENT_CODES.DEPARTMENT_CODE%TYPE,
	p_nName					IN		DEPARTMENT_CODES.DEPARTMENT_NAME%TYPE,
	p_nFileTranLogID		IN		DEPARTMENT_CODES.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nAccountNumber		IN		DEPARTMENT_CODES.ACCOUNT_NUMBER%TYPE
)
IS

	CURSOR curDepartmentCode
	IS
		SELECT *
		FROM DEPARTMENT_CODES
		WHERE		ACCNT_HRCY_STEP_ID	= p_nAHSID
					AND DEPARTMENT_CODE = p_nDepartmentCode;
					
	DEPT_CODE_REC				 curDepartmentCode%ROWTYPE;


BEGIN

	OPEN curDepartmentCode;
	fetch curDepartmentCode into DEPT_CODE_REC;

	-- If no AHS record then insert
	IF curDepartmentCode%NOTFOUND THEN
    
		-- Get the new AHS ID
		p_nDepartmentCodeID := SeqFunctions.GetNextSeq('DEPARTMENT_CODES');

		insert into DEPARTMENT_CODES 
								(	DEPARTMENT_CODES_ID,
									ACCNT_HRCY_STEP_ID,
									DEPARTMENT_CODE,
			   				 		DEPARTMENT_NAME,
									FILE_TRANSMISSION_LOG_ID,
									ACCOUNT_NUMBER
								)
			VALUES
								(
									p_nDepartmentCodeID,
									p_nAHSID,
									p_nDepartmentCode,
									p_nName,
									p_nFileTranLogID,
									p_nAccountNumber
								);
	ELSE
		
		p_nDepartmentCodeID :=  DEPT_CODE_REC.DEPARTMENT_CODES_ID;

		update DEPARTMENT_CODES set
								FILE_TRANSMISSION_LOG_ID	= p_nFileTranLogId,
								DEPARTMENT_NAME				= p_nName,
								ACCOUNT_NUMBER				= p_nAccountNumber
				where
								DEPARTMENT_CODES_ID = p_nDepartmentCodeID;

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_nDepartmentCodeID := -1;
	rollback;
	raise;

END ProcessDepartmentCodes;
     	
------------------------------------------------------------------------
--  returns CONFIG settings by application
--  used by eSurance.com
------------------------------------------------------------------------    
PROCEDURE GetAppSetting (
    p_Application              IN    CONFIG_SETTINGS.APPLICATION%TYPE,
    p_Key					             IN    CONFIG_SETTINGS.KEY%TYPE,
    p_Results                 OUT    CONFIG_SETTINGS.VALUE%TYPE
)
IS
    v_Value           CONFIG_SETTINGS.VALUE%TYPE;    
    
BEGIN
    select VALUE into v_Value from CONFIG_SETTINGS where APPLICATION = p_Application and KEY = p_Key;

    IF v_Value IS NOT NULL THEN
        
        p_Results := v_Value;
    ELSE
        p_Results := '';
                                                                                                                                    
    END IF;
        
EXCEPTION
    WHEN OTHERS THEN
        p_Results := '';
        
END GetAppSetting;     	

END DBCLASSLIBRARY;
/
