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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Sql/DbClassLibPackageTOWP.sql 4     6/20/11 7:45p Gwynnj $ */
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

PROCEDURE GetPolicyIdFromUploadKey (
    p_nUploadKey                IN    POLICY.UPLOAD_KEY%TYPE,
    p_nPolicyId                        OUT    POLICY.POLICY_ID%TYPE
);

PROCEDURE GetAppSetting (
    p_Application              IN    CONFIG_SETTINGS.APPLICATION%TYPE,
    p_Key					             IN    CONFIG_SETTINGS.KEY%TYPE,
    p_Results                 OUT    CONFIG_SETTINGS.VALUE%TYPE
);

PROCEDURE ProcessDriverExtended(
    p_nDriverID                OUT        DRIVER.DRIVER_ID%TYPE,
    p_nFileTranLogId    IN        DRIVER.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nPolicyID                IN        DRIVER.POLICY_ID%TYPE,
    p_nSSN                        IN        DRIVER.SSN%TYPE,
    p_nNameFirst            IN        DRIVER.NAME_FIRST%TYPE,
    p_nNameLast                IN        DRIVER.NAME_LAST%TYPE,
    p_nAddress1                IN        DRIVER.ADDRESS1%TYPE,
    p_nAddress2                IN        DRIVER.ADDRESS2%TYPE,
    p_nCity                        IN        DRIVER.CITY%TYPE,
    p_nState                    IN        DRIVER.STATE%TYPE,
    p_nZip                        IN        DRIVER.ZIP%TYPE,
    p_nPhone                    IN        DRIVER.PHONE%TYPE,
    p_nRelation                IN        DRIVER.RELATION_TO_INSURED%TYPE,
    p_nLicenseNumber    IN        DRIVER.LICENSE_NUMBER%TYPE,
    p_nUploadKey            IN        DRIVER.UPLOAD_KEY%TYPE,
    p_nActiveStartDt    IN        DRIVER.ACTIVE_START_DT%TYPE,
    p_nActiveEndDt        IN        DRIVER.ACTIVE_END_DT%TYPE,
    p_nDriverNumber        IN        DRIVER.DRIVER_NUMBER%TYPE,
    p_nBirthdDt                IN        DRIVER.BIRTH_DT%TYPE,
    p_nGender                    IN        DRIVER.GENDER%TYPE,
    p_nType             IN DRIVER.TYPE%TYPE,
    p_nNameMi                IN        DRIVER.NAME_MI%TYPE,
    p_nMaritalStatus                    IN        DRIVER.MARITAL_STATUS%TYPE,
    p_nEmailAddress             IN DRIVER.EMAIL_ADDRESS%TYPE,
    p_nLicenseState             IN DRIVER.LICENSE_STATE%TYPE
    
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

------------------------------------------------------------------------
--  Extended driver functionality to add 3 more columns
------------------------------------------------------------------------    
PROCEDURE ProcessDriverExtended(
    p_nDriverID                OUT        DRIVER.DRIVER_ID%TYPE,
    p_nFileTranLogId           IN        DRIVER.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nPolicyID                IN        DRIVER.POLICY_ID%TYPE,
    p_nSSN                     IN        DRIVER.SSN%TYPE,
    p_nNameFirst               IN        DRIVER.NAME_FIRST%TYPE,
    p_nNameLast                IN        DRIVER.NAME_LAST%TYPE,
    p_nAddress1                IN        DRIVER.ADDRESS1%TYPE,
    p_nAddress2                IN        DRIVER.ADDRESS2%TYPE,
    p_nCity                    IN        DRIVER.CITY%TYPE,
    p_nState                   IN        DRIVER.STATE%TYPE,
    p_nZip                     IN        DRIVER.ZIP%TYPE,
    p_nPhone                   IN        DRIVER.PHONE%TYPE,
    p_nRelation                IN        DRIVER.RELATION_TO_INSURED%TYPE,
    p_nLicenseNumber           IN        DRIVER.LICENSE_NUMBER%TYPE,
    p_nUploadKey               IN        DRIVER.UPLOAD_KEY%TYPE,
    p_nActiveStartDt           IN        DRIVER.ACTIVE_START_DT%TYPE,
    p_nActiveEndDt             IN        DRIVER.ACTIVE_END_DT%TYPE,
    p_nDriverNumber            IN        DRIVER.DRIVER_NUMBER%TYPE,
    p_nBirthdDt                IN        DRIVER.BIRTH_DT%TYPE,
    p_nGender                  IN        DRIVER.GENDER%TYPE,
    p_nType                    IN        DRIVER.TYPE%TYPE,
    p_nNameMi                 IN        DRIVER.NAME_MI%TYPE,
    p_nMaritalStatus          IN        DRIVER.MARITAL_STATUS%TYPE,
    p_nEmailAddress           IN        DRIVER.EMAIL_ADDRESS%TYPE,
    p_nLicenseState			  IN		DRIVER.LICENSE_STATE%TYPE
    
    
)
IS
    CURSOR curDriverRec
    IS
        SELECT *
        FROM DRIVER
        WHERE UPLOAD_KEY = p_nUploadKey;
    CurActiveStart         DRIVER.ACTIVE_START_DT%TYPE;
    CurBirthDate         DRIVER.BIRTH_DT%TYPE;
    CurActiveEnd         DRIVER.ACTIVE_END_DT%TYPE;
    DRIVER_REC         curDriverRec%ROWTYPE;
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
    IF p_nBirthdDt IS NULL THEN
      CurBirthDate := NULL;
    ELSE
      CurBirthDate := p_nBirthdDt;
    END IF;
    OPEN curDriverRec;
    fetch curDriverRec into DRIVER_REC;
    -- If no POLICY record then insert
    IF curDriverRec%NOTFOUND THEN
    -- Get the new POLICY ID
        p_nDriverID := SeqFunctions.GetNextSeq('DRIVER');
        insert into DRIVER
                        (
                            DRIVER_ID,
                            FILE_TRANSMISSION_LOG_ID,
                            POLICY_ID,
                            SSN,
                            NAME_FIRST,
                            NAME_LAST,
                            ADDRESS1,
                            ADDRESS2,
                            CITY,
                            STATE,
                            ZIP,
                            PHONE,
                            RELATION_TO_INSURED,
                            LICENSE_NUMBER,
                            ACTIVE_START_DT,
                            ACTIVE_END_DT,
                            UPLOAD_KEY,
                            DRIVER_NUMBER,
                            BIRTH_DT,
                            GENDER,
                            TYPE,
                            NAME_MI,
                            MARITAL_STATUS,
                            EMAIL_ADDRESS,
                            LICENSE_STATE
                        )
        VALUES
                        (
                            p_nDriverID,
                            p_nFileTranLogId,
                            p_nPolicyID,
                            p_nSSN,
                            p_nNameFirst,
                            p_nNameLast,
                            p_nAddress1,
                            p_nAddress2,
                            p_nCity,
                            p_nState,
                            p_nZip,
                            p_nPhone,
                            p_nRelation,
                            p_nLicenseNumber,
                            CurActiveStart,
                            CurActiveEnd,
                            p_nUploadKey,
                            p_nDriverNumber,
                            CurBirthDate,
                            p_nGender,
                            p_nType,
                            p_nNameMi,
                            p_nMaritalStatus,
                            p_nEmailAddress,
                            p_nLicenseState
                        );
    ELSE
        p_nDriverID :=  DRIVER_REC.DRIVER_ID;
        update DRIVER
                    set                FILE_TRANSMISSION_LOG_ID    = p_nFileTranLogId,
                                    POLICY_ID                      = p_nPolicyID,
                                    NAME_FIRST                     = p_nNameFirst,
                                    NAME_LAST                      = p_nNameLast,
                                    ADDRESS1                       = p_nAddress1,
                                    ADDRESS2                       = p_nAddress2,
                                    CITY                           = p_nCity,
                                    STATE                          = p_nState,
                                    ZIP                            = p_nZip,
                                    PHONE                          = p_nPhone,
                                    RELATION_TO_INSURED            = p_nRelation,
                                    LICENSE_NUMBER                 = p_nLicenseNumber,
                                    ACTIVE_START_DT                = CurActiveStart,
                                    ACTIVE_END_DT                  = CurActiveEnd,
                                    UPLOAD_KEY                     = p_nUploadKey,
                                    DRIVER_NUMBER                  = p_nDriverNumber,
                                    BIRTH_DT                       = CurBirthDate,
                                    GENDER                         = p_nGender,
                                    TYPE                           = p_nType,
                                    NAME_MI                        = p_nNameMi,
                                    MARITAL_STATUS                 = p_nMaritalStatus,
                                    EMAIL_ADDRESS                  = p_nEmailAddress,
                                    LICENSE_STATE				   = p_nLicenseState
                                    
                where
                                    DRIVER_ID                      = p_nDriverID;
    END IF;
    COMMIT;
EXCEPTION
    WHEN OTHERS THEN
    p_nDriverID := -1;
    rollback;
    raise;
END ProcessDriverExtended;

END DBCLASSLIBRARY;
/
