CREATE OR REPLACE PACKAGE DBCLASSLIBRARY AS

TYPE  CURSOR_TYPE IS REF CURSOR;

con_ErrTypeInfo        CONSTANT NUMBER := 1;
con_ErrTypeWarning    CONSTANT NUMBER := 2;
con_ErrTypeError    CONSTANT NUMBER := 3;
con_Component        CONSTANT VARCHAR2(30) := 'DbClassLibPackage';
numApplicationLogID    APPLICATION_LOG.APPLICATION_LOG_ID%TYPE;
strServer        APPLICATION_LOG.SERVER%TYPE;
strErrorString        APPLICATION_LOG.ERRORSTRING%TYPE;
strSQLCODE        NUMBER;
strSQLERRM        VARCHAR2(600);

PROCEDURE GetMercuryDestinations (
    destinationType                    IN        MERCURY.TYPE%TYPE,
    results                                    OUT        CURSOR_TYPE);
        
PROCEDURE GetOverflowSet (
    p_accntHrcyStepId                IN        OUTPUT_OVERFLOW.ACCNT_HRCY_STEP_ID%TYPE,
    p_LineOfBusiness                IN        OUTPUT_OVERFLOW.LOB_CD%TYPE,
    results                                    OUT        CURSOR_TYPE);
    
PROCEDURE GetFileTranDefSet (
    p_accntHrcyStepId    IN        FILE_TRANSMISSION_DEF.ACCNT_HRCY_STEP_ID%TYPE,
    p_Server                    IN        FILE_TRANSMISSION_DEF.SERVER%TYPE,
    p_Type                        IN        FILE_TRANSMISSION_DEF.TYPE%TYPE,
    results                                    OUT        CURSOR_TYPE);
    
PROCEDURE CreateFileTranLogRecord (
    p_nFileTranLogID    OUT        FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nFileTranDefID    IN        FILE_TRANSMISSION_DEF.FILE_TRANSMISSION_DEF_ID%TYPE,
    p_nFileName                IN        FILE_TRANSMISSION_LOG.FILE_NAME%TYPE,
    p_nStatus                    IN        FILE_TRANSMISSION_LOG.STATUS%TYPE,
    p_nServer                    IN        FILE_TRANSMISSION_LOG.SERVER%TYPE,
    p_nParenId                IN        FILE_TRANSMISSION_LOG.PARENT_ID%TYPE);
    
PROCEDURE UpdateFileTranLogStatus (
    p_nFileTranLogID    IN        FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nStatus                    IN        FILE_TRANSMISSION_LOG.STATUS%TYPE);
    
PROCEDURE GetCityFromZip (
    p_nZipCode                IN        LOCATION_CODE.ZIP%TYPE,
    p_nCity                        OUT        LOCATION_CODE.CITY%TYPE);
    
PROCEDURE ProcessEmployeeExtension(
    p_nEmployeeExtId        OUT        EMPLOYEE_EXT.EMPLOYEE_EXT_ID%TYPE,
    p_nEmployeeId                IN        EMPLOYEE_EXT.EMPLOYEE_ID%TYPE,
    p_nFileTranLogId        IN        EMPLOYEE_EXT.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nFieldName                IN        EMPLOYEE_EXT.FIELD_NAME%TYPE,
    p_nFieldValue                IN        EMPLOYEE_EXT.FIELD_VALUE%TYPE
     
);
PROCEDURE GetAHSRecord (
    p_AHSID                    IN        ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
    p_UploadKey            IN        ACCOUNT_HIERARCHY_STEP.UPLOAD_KEY%TYPE,
    results                    OUT        CURSOR_TYPE);

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
    
  PROCEDURE ProcessClaimSubmissionLog(
    p_id                                OUT    CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE,
    p_rquID                            IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_requestType                IN    VARCHAR2,
    clobData                        IN    CLOB);
    
PROCEDURE UpdateClaimSubmissionLog(
    p_id                         OUT    CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE,
    p_rquID                      IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_requestType                IN    VARCHAR2,
    p_timestamp					 IN	   VARCHAR2,
    clobData                     IN    CLOB);
    
PROCEDURE GetClaimSubLogData (
    p_rquID                            IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_requestType                IN    VARCHAR2,
    clobData                        OUT    CLOB);

PROCEDURE ResetClaimLogResponse (
    p_rquID                            IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_results                        OUT    int);
  
PROCEDURE ProcessSEDVehicle(
	p_nVehicleID            OUT       VEHICLE.VEHICLE_ID%TYPE,
	p_nFileTranLogId        IN        VEHICLE.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nPolicyID             IN        VEHICLE.POLICY_ID%TYPE,
	p_nVIN                  IN        VEHICLE.VIN%TYPE,
	p_nYEAR                 IN        VEHICLE.YEAR%TYPE,
	p_nMAKE                 IN        VEHICLE.MAKE%TYPE,
	p_nMODEL                IN        VEHICLE.MODEL%TYPE,
	p_nLICENSE_PLATE        IN        VEHICLE.LICENSE_PLATE%TYPE,
	p_nLICENSE_PLATE_STATE  IN        VEHICLE.LICENSE_PLATE_STATE%TYPE,
	p_nREGISTRATION_STATE   IN        VEHICLE.REGISTRATION_STATE%TYPE,
	p_nCOLOR                IN        VEHICLE.COLOR%TYPE,
	p_nUploadKey            IN        VEHICLE.UPLOAD_KEY%TYPE,
	p_nActiveStartDt        IN        VEHICLE.ACTIVE_START_DT%TYPE,
	p_nActiveEndDt          IN        VEHICLE.ACTIVE_END_DT%TYPE,
	p_nDriver1Number        IN        VEHICLE.DRIVER1_NUMBER%TYPE,
	p_nDriver1Percent       IN        VEHICLE.DRIVER1_PERCENT%TYPE,
	p_nDriver2Number        IN        VEHICLE.DRIVER2_NUMBER%TYPE,
	p_nDriver2Percent       IN        VEHICLE.DRIVER2_PERCENT%TYPE,
	p_nMisc                 IN        VEHICLE.MISC%TYPE,
	p_nVehicleNumber        IN        VEHICLE.VEHICLE_NUMBER%TYPE,
	p_nBodyType             IN        VEHICLE.BODY_TYPE%TYPE,
	p_nLocationId           IN        VEHICLE.LOCATION_ID%TYPE,
	p_nLicenseWeight        IN        VEHICLE.LOCATION_WEIGHT%TYPE,
	p_nEntityName           IN        VEHICLE.ENTITY_NAME%TYPE,
	p_nApportionedFlag      IN        VEHICLE.APPORTIONED_FLG%TYPE,
	p_nDotNumber            IN        VEHICLE.DOT_NUMBER%TYPE,
	p_nMileage              IN        VEHICLE.MILEAGE%TYPE,
	p_nTitleNumber          IN        VEHICLE.TITLE_NUMBER%TYPE,
	p_nVehicleType          IN        VEHICLE.VEHICLE_TYPE%TYPE,
	p_nVehicleDesc          IN        VEHICLE.VEHICLE_DESC%TYPE,
	p_nClientNum            IN        VEHICLE.CLIENT_NUM%TYPE,
	p_nArchivedFlag         IN        VEHICLE.ARCHIVED_FLG%TYPE
);

PROCEDURE GetAppSetting (
    p_Application              IN    CONFIG_SETTINGS.APPLICATION%TYPE,
    p_Key					             IN    CONFIG_SETTINGS.KEY%TYPE,
    p_Results                 OUT    CONFIG_SETTINGS.VALUE%TYPE
);

PROCEDURE GetTableDefinition (
	p_tableName				IN		USER_TAB_COLUMNS.TABLE_NAME%TYPE,
	results									OUT		CURSOR_TYPE);
	
PROCEDURE GetProcedureDefinition (
	p_packageName			IN		USER_ARGUMENTS.PACKAGE_NAME%TYPE,
	p_procedureName		IN		USER_ARGUMENTS.OBJECT_NAME%TYPE,
	results						OUT		CURSOR_TYPE
);

PROCEDURE CreateUpdateEntities(
	p_id							OUT	ENTITIES.ENTITY_ID%TYPE,
	p_rquID							IN	ENTITIES.RQUID%TYPE,
	p_sourceData					IN	CLOB);
	
PROCEDURE GetEntity(
	p_rquID							IN	ENTITIES.RQUID%TYPE,
	p_sourceData					OUT	CLOB);
	
PROCEDURE GetEncrptAttributeSet (
	p_ahsId					IN		ENCRYPT_ATTRIBUTE.ACCNT_HRCY_STEP_ID%TYPE,
	p_lobCd					IN		ENCRYPT_ATTRIBUTE.LOB_CD%TYPE,
	p_encryptType			IN		ENCRYPT_ATTRIBUTE.ENCRYPT_TYPE%TYPE,
	results					OUT		CURSOR_TYPE);
	
PROCEDURE LockClaimNumber (
          pin_ruleId  IN CLAIMNUMBERASSIGNMENTRULE.CLAIMNUMBERASSIGNMENTRULE_ID%TYPE,
          pin_maximum IN CLAIMNUMBERASSIGNMENTRULE.NEXT%TYPE,
          pin_claim_number OUT CLAIMNUMBERASSIGNMENTRULE.NEXT%TYPE);	
          
PROCEDURE AddEscalationOutcomeStep(
		p_EscalationOutcomeId	IN ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_ID%TYPE,
		p_UserId				IN ESCALATION_OUTCOME_STEP.USER_ID%TYPE,
		p_Name					IN VARCHAR2,
		P_Title					IN VARCHAR2,
		p_PhoneNumber			IN VARCHAR2,
		p_Description			IN VARCHAR2,
		p_Complete				IN VARCHAR2,
		p_result				OUT ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_STEP_ID%TYPE);

PROCEDURE UpdateEscalationOutcomeStep(
		p_EscalationOutcomeId	IN ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_ID%TYPE,
		p_Step_Id				IN ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_STEP_ID%TYPE,
		p_UserId				IN ESCALATION_OUTCOME_STEP.USER_ID%TYPE,
		p_Name					IN VARCHAR2,
		p_Title					IN VARCHAR2,
		p_PhoneNumber			IN VARCHAR2,
		p_Description			IN VARCHAR2,
		p_Complete				IN VARCHAR2,
		p_result				OUT int);          
	    
PROCEDURE GetRuleUsedBy (
    p_MatchRuleId		  IN	NUMBER,
    results           OUT CURSOR_TYPE);
    
PROCEDURE SrchAHSNodesDownTreeSql(
    inAtAHSID		IN ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
    inAHSID			IN ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
    inAHSName		IN ACCOUNT_HIERARCHY_STEP.NAME%TYPE,
    inAddress1		IN ACCOUNT_HIERARCHY_STEP.ADDRESS_1%TYPE,
    inCity			IN ACCOUNT_HIERARCHY_STEP.CITY%TYPE,
    inState			IN ACCOUNT_HIERARCHY_STEP.STATE%TYPE,
    inZip			IN ACCOUNT_HIERARCHY_STEP.ZIP%TYPE,
    inLocationCode 	IN ACCOUNT_HIERARCHY_STEP.LOCATION_CODE%TYPE,
    inUserID		IN USERS.USER_ID%TYPE,
		inSrchType	IN NUMBER,
    results			OUT		VARCHAR2);
    
PROCEDURE SrchAHSNodesUpTreeSQL(
    inAtAHSID		IN ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
    inAHSID			IN ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
    inAHSName		IN ACCOUNT_HIERARCHY_STEP.NAME%TYPE,
    inAddress1		IN ACCOUNT_HIERARCHY_STEP.ADDRESS_1%TYPE,
    inCity			IN ACCOUNT_HIERARCHY_STEP.CITY%TYPE,
    inState			IN ACCOUNT_HIERARCHY_STEP.STATE%TYPE,
    inZip			IN ACCOUNT_HIERARCHY_STEP.ZIP%TYPE,
    inLocationCode 	IN ACCOUNT_HIERARCHY_STEP.LOCATION_CODE%TYPE,
    inUserID		IN USERS.USER_ID%TYPE,
		inSrchType	IN NUMBER,
    results			OUT		VARCHAR2);

PROCEDURE AddAccountUser(StrAcctID	IN VARCHAR2,
			StrUserID	IN VARCHAR2,
			StatusMsg	OUT VARCHAR2,
			StatusNum	OUT NUMBER);
			    
END DBCLASSLIBRARY;
/



CREATE OR REPLACE PACKAGE BODY DBCLASSLIBRARY AS


------------------------------------------------------------------------
-- Get GetOverflowSet (AHSID,LOB_CD) 
-- returns Set of OUTPUT_OVERFLOW
------------------------------------------------------------------------    
PROCEDURE GetOverflowSet (
    p_accntHrcyStepId                IN        OUTPUT_OVERFLOW.ACCNT_HRCY_STEP_ID%TYPE,
    p_LineOfBusiness                IN        OUTPUT_OVERFLOW.LOB_CD%TYPE,
    results                                    OUT        CURSOR_TYPE
)
IS
    v_cursor            CURSOR_TYPE;

BEGIN
    OPEN v_cursor FOR
                Select    SEQUENCE,
                                ATTRIBUTE_NAME,
                                CAPTION,MAPPING,
                                CAPTION_LENGTH,
                                SHOW_WHEN_EMPTY_FLAG 
                from        OUTPUT_OVERFLOW 
                where        ACCNT_HRCY_STEP_ID = p_accntHrcyStepId and LOB_CD = p_LineOfBusiness
                order by SEQUENCE;

    results := v_cursor;

EXCEPTION
    WHEN OTHERS THEN
        raise;
        
END GetOverflowSet;
        
------------------------------------------------------------------------
-- Get Mercury (EMAIL MSMQ)Destination(s) 
-- returns Set of TYPE MERCURY
------------------------------------------------------------------------    
PROCEDURE GetMercuryDestinations (
    destinationType                    IN        MERCURY.TYPE%TYPE,
    results                                    OUT        CURSOR_TYPE
)
IS
    v_cursor            CURSOR_TYPE;

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
-- GetFileTranDefSet returns the set of FILE_TRANSMISSION_DEF records
-- for a given AHSID, SERVER and TYPE
------------------------------------------------------------------------    
PROCEDURE GetFileTranDefSet (
    p_accntHrcyStepId    IN        FILE_TRANSMISSION_DEF.ACCNT_HRCY_STEP_ID%TYPE,
    p_Server                    IN        FILE_TRANSMISSION_DEF.SERVER%TYPE,
    p_Type                        IN        FILE_TRANSMISSION_DEF.TYPE%TYPE,
    results                                    OUT        CURSOR_TYPE
)
IS
    v_cursor            CURSOR_TYPE;

BEGIN
    OPEN v_cursor FOR
                Select    FILE_TRANSMISSION_DEF_ID,
                                DIRECTORY,
                                LAST_LOAD_SEQUENCE,
                                FILE_NAME_PATTERN,
                                LOCATION_IDENTIFIER,
                                DESCRIPTION,
                                SEQUENCE,
                                SOURCE_LOCATION,
                                DESTINATION_UIF_LOCATION,
                                FROI_IMP_RECORD_ID
                from        FILE_TRANSMISSION_DEF 
                where        ACCNT_HRCY_STEP_ID = p_accntHrcyStepId 
                        and SERVER = p_Server
                        and TYPE = p_Type
                order by SEQUENCE;

    results := v_cursor;

EXCEPTION
    WHEN OTHERS THEN
        raise;
        
END GetFileTranDefSet;
        

------------------------------------------------------------------------
--  Create a new FileTranLog Record
--  return the pk (no update)
------------------------------------------------------------------------    
PROCEDURE CreateFileTranLogRecord (
    p_nFileTranLogId    OUT        FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nFileTranDefId    IN        FILE_TRANSMISSION_DEF.FILE_TRANSMISSION_DEF_ID%TYPE,
    p_nFileName                IN        FILE_TRANSMISSION_LOG.FILE_NAME%TYPE,
    p_nStatus                    IN        FILE_TRANSMISSION_LOG.STATUS%TYPE,
    p_nServer                    IN        FILE_TRANSMISSION_LOG.SERVER%TYPE,
    p_nParenId                IN        FILE_TRANSMISSION_LOG.PARENT_ID%TYPE
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
    p_nFileTranLogID    IN        FILE_TRANSMISSION_LOG.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nStatus                    IN        FILE_TRANSMISSION_LOG.STATUS%TYPE
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
    p_nZipCode                IN        LOCATION_CODE.ZIP%TYPE,
    p_nCity                        OUT        LOCATION_CODE.CITY%TYPE
)
IS
    CURSOR curLocationCodeRec
    IS
        SELECT *
        FROM LOCATION_CODE
        WHERE ZIP = p_nZipCode
                    AND PRIMARY_LOC = 'Y'
                    AND SEQ = 1;
    
    Loc_Rec    curLocationCodeRec%ROWTYPE;
    

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
--  Addes EMPLOYEE_EXT records for IPM Employee loads
--  used by CRA Cisco
--- Can be extended to all UIF
------------------------------------------------------------------------    
PROCEDURE ProcessEmployeeExtension(
    p_nEmployeeExtId        OUT        EMPLOYEE_EXT.EMPLOYEE_EXT_ID%TYPE,
    p_nEmployeeId                IN        EMPLOYEE_EXT.EMPLOYEE_ID%TYPE,
    p_nFileTranLogId        IN        EMPLOYEE_EXT.FILE_TRANSMISSION_LOG_ID%TYPE,
    p_nFieldName                IN        EMPLOYEE_EXT.FIELD_NAME%TYPE,
    p_nFieldValue                IN        EMPLOYEE_EXT.FIELD_VALUE%TYPE
)
IS
    CURSOR curEmployeeExtRec
    IS
        SELECT *
        FROM EMPLOYEE_EXT
        WHERE EMPLOYEE_ID = p_nEmployeeId
            AND  FIELD_NAME = p_nFieldName;

    EMP_EXT_REC         curEmployeeExtRec%ROWTYPE;


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
                        set            FILE_TRANSMISSION_LOG_ID    = p_nFileTranLogId,
                                        FIELD_NAME                    = p_nFieldName,
                                        FIELD_VALUE                    = p_nFieldValue
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
-- Get ACCOUNT_HIERARCHY_STEP record by AHSID 
-- returns Set of TYPE ACCOUNT_HIERARCHY_STEP
------------------------------------------------------------------------    
PROCEDURE GetAHSRecord (
    p_AHSID                    IN        ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
    p_UploadKey            IN        ACCOUNT_HIERARCHY_STEP.UPLOAD_KEY%TYPE,
    results                    OUT        CURSOR_TYPE
)
IS
    v_cursor            CURSOR_TYPE;

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

---New stored procedures created For Sedgwick Dissemination SOW

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
        WHERE ACCNT_HRCY_STEP_ID = p_ahsId and
        UPLOAD_KEY = p_uploadKey;

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

---New stored procedures created For Sedgwick Dissemination SOW

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

    DESTINATION_REC         curSpecificDestStepRec%ROWTYPE;


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

PROCEDURE ProcessClaimSubmissionLog(
    p_id                                OUT    CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE,
    p_rquID                            IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_requestType                IN    VARCHAR2,
    clobData                        IN    CLOB
)
IS
    v_id            CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE;
    
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
-- GetClaimSubLogData
-- return REQUEST or RESPONSE
------------------------------------------------------------------------    
PROCEDURE GetClaimSubLogData (
    p_rquID                            IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_requestType                IN    VARCHAR2,
    clobData                        OUT    CLOB
)
IS
    v_cData            CLOB;
    
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

------------------------------------------------------------------------
-- ResetClaimLogResponse
-- remove RESPONSE data
------------------------------------------------------------------------    
PROCEDURE ResetClaimLogResponse (
    p_rquID                            IN    CLAIM_SUBMISSION_LOG.RQUID%TYPE,
    p_results                        OUT    int
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


PROCEDURE ProcessSEDVehicle(
	p_nVehicleID           OUT VEHICLE.VEHICLE_ID%TYPE,
	p_nFileTranLogId       IN  VEHICLE.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nPolicyID            IN  VEHICLE.POLICY_ID%TYPE,
	p_nVIN                 IN  VEHICLE.VIN%TYPE,
	p_nYEAR                IN  VEHICLE.YEAR%TYPE,
	p_nMAKE                IN  VEHICLE.MAKE%TYPE,
	p_nMODEL               IN  VEHICLE.MODEL%TYPE,
	p_nLICENSE_PLATE       IN  VEHICLE.LICENSE_PLATE%TYPE,
	p_nLICENSE_PLATE_STATE IN  VEHICLE.LICENSE_PLATE_STATE%TYPE,
	p_nREGISTRATION_STATE  IN  VEHICLE.REGISTRATION_STATE%TYPE,
	p_nCOLOR               IN  VEHICLE.COLOR%TYPE,
	p_nUploadKey           IN  VEHICLE.UPLOAD_KEY%TYPE,
	p_nActiveStartDt       IN  VEHICLE.ACTIVE_START_DT%TYPE,
	p_nActiveEndDt         IN  VEHICLE.ACTIVE_END_DT%TYPE,
	p_nDriver1Number       IN  VEHICLE.DRIVER1_NUMBER%TYPE,
	p_nDriver1Percent      IN  VEHICLE.DRIVER1_PERCENT%TYPE,
	p_nDriver2Number       IN  VEHICLE.DRIVER2_NUMBER%TYPE,
	p_nDriver2Percent      IN  VEHICLE.DRIVER2_PERCENT%TYPE,
	p_nMisc                IN  VEHICLE.MISC%TYPE,
	p_nVehicleNumber       IN  VEHICLE.VEHICLE_NUMBER%TYPE,
	p_nBodyType            IN  VEHICLE.BODY_TYPE%TYPE,
	p_nLocationId          IN  VEHICLE.LOCATION_ID%TYPE,
	p_nLicenseWeight       IN  VEHICLE.LOCATION_WEIGHT%TYPE,
	p_nEntityName          IN  VEHICLE.ENTITY_NAME%TYPE,
	p_nApportionedFlag     IN  VEHICLE.APPORTIONED_FLG%TYPE,
	p_nDotNumber           IN  VEHICLE.DOT_NUMBER%TYPE,
	p_nMileage             IN  VEHICLE.MILEAGE%TYPE,
	p_nTitleNumber         IN  VEHICLE.TITLE_NUMBER%TYPE,
	p_nVehicleType         IN  VEHICLE.VEHICLE_TYPE%TYPE,
	p_nVehicleDesc         IN  VEHICLE.VEHICLE_DESC%TYPE,
	p_nClientNum           IN  VEHICLE.CLIENT_NUM%TYPE,
	p_nArchivedFlag        IN  VEHICLE.ARCHIVED_FLG%TYPE
)
IS
	CURSOR curVehicleRec
        IS
        SELECT * FROM VEHICLE WHERE UPLOAD_KEY = p_nUploadKey;

	CurActiveStart  VEHICLE.ACTIVE_START_DT%TYPE;
	CurActiveEnd    VEHICLE.ACTIVE_END_DT%TYPE;

	VEHICLE_REC     curVehicleRec%ROWTYPE;

BEGIN

	OPEN curVehicleRec;
	FETCH curVehicleRec INTO VEHICLE_REC;

	-- If no POLICY record then insert
	IF curVehicleRec%NOTFOUND THEN

		-- Get the new POLICY ID
		p_nVehicleID := SeqFunctions.GetNextSeq('VEHICLE');

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


		INSERT INTO VEHICLE
			(
			VEHICLE_ID,
			FILE_TRANSMISSION_LOG_ID,
			POLICY_ID,
			VIN,
			YEAR,
			MAKE,
			MODEL,
			LICENSE_PLATE,
			LICENSE_PLATE_STATE,
			REGISTRATION_STATE,
			COLOR,
			ACTIVE_START_DT,
			ACTIVE_END_DT,
			UPLOAD_KEY,
			DRIVER1_NUMBER,
			DRIVER1_PERCENT,
			DRIVER2_NUMBER,
			DRIVER2_PERCENT,
			MISC,
			VEHICLE_NUMBER,
			BODY_TYPE,
			LOCATION_ID,
			LOCATION_WEIGHT,
			ENTITY_NAME,
			APPORTIONED_FLG,
			DOT_NUMBER,
			MILEAGE,
			TITLE_NUMBER,
			VEHICLE_TYPE,
			VEHICLE_DESC,
			CLIENT_NUM,
			ARCHIVED_FLG
			)
		VALUES
			(
			p_nVehicleID,
			p_nFileTranLogId,
			p_nPolicyID,
			p_nVIN,
			p_nYEAR,
			p_nMAKE,
			p_nMODEL,
			p_nLICENSE_PLATE,
			p_nLICENSE_PLATE_STATE,
			p_nREGISTRATION_STATE,
			p_nCOLOR,
			CurActiveStart,
			CurActiveEnd,
			p_nUploadKey,
			p_nDriver1Number,
			p_nDriver1Percent,
			p_nDriver2Number,
			p_nDriver2Percent,
			p_nMisc,
			p_nVehicleNumber,
			p_nBodyType,
			p_nLocationId,
			p_nLicenseWeight,
			p_nEntityName,
			p_nApportionedFlag,
			p_nDotNumber,
			p_nMileage,
			p_nTitleNumber,
			p_nVehicleType,
			p_nVehicleDesc,
			p_nClientNum,
			p_nArchivedFlag
			);

	ELSE

		p_nVehicleID := VEHICLE_REC.VEHICLE_ID;

		IF p_nActiveStartDt IS NULL THEN
			CurActiveStart := VEHICLE_REC.ACTIVE_START_DT;
		ELSE
			CurActiveStart := p_nActiveStartDt;
		END IF;

		IF p_nActiveEndDt IS NULL THEN
			CurActiveEnd := VEHICLE_REC.ACTIVE_END_DT;
		ELSE
			CurActiveEnd := p_nActiveEndDt;
		END IF;

		UPDATE VEHICLE
		SET FILE_TRANSMISSION_LOG_ID = p_nFileTranLogId,
			POLICY_ID                = p_nPolicyID,
			VIN                      = p_nVIN,
			YEAR                     = p_nYEAR,
			MAKE                     = p_nMAKE,
			MODEL                    = p_nMODEL,
			LICENSE_PLATE            = p_nLICENSE_PLATE,
			LICENSE_PLATE_STATE      = p_nLICENSE_PLATE_STATE,
			REGISTRATION_STATE       = p_nREGISTRATION_STATE,
			COLOR                    = p_nCOLOR,
			ACTIVE_START_DT          = CurActiveStart,
			ACTIVE_END_DT            = CurActiveEnd,
			DRIVER1_NUMBER           = p_nDriver1Number,
			DRIVER1_PERCENT          = p_nDriver1Percent,
			DRIVER2_NUMBER           = p_nDriver2Number,
			DRIVER2_PERCENT          = p_nDriver2Percent,
			MISC                     = p_nMisc,
			VEHICLE_NUMBER           = p_nVehicleNumber,
			BODY_TYPE                = p_nBodyType,
			LOCATION_ID              = p_nLocationId,
			LOCATION_WEIGHT          = p_nLicenseWeight,
			ENTITY_NAME              = p_nEntityName,
			APPORTIONED_FLG          = p_nApportionedFlag,
			DOT_NUMBER               = p_nDotNumber,
			MILEAGE                  = p_nMileage,
			TITLE_NUMBER             = p_nTitleNumber,
			VEHICLE_TYPE             = p_nVehicleType,
			VEHICLE_DESC             = p_nVehicleDesc,
			CLIENT_NUM               = p_nClientNum,
			ARCHIVED_FLG             = p_nArchivedFlag
		WHERE
			VEHICLE_ID               = p_nVehicleID;

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_nVehicleID := -1;
	ROLLBACK;
	RAISE;

END ProcessSEDVehicle;

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
  if p_packageName is null then
    OPEN v_cursor FOR
		  SELECT	POSITION,
						  ARGUMENT_NAME,
						  DATA_TYPE,	   
						  IN_OUT
		  from		USER_ARGUMENTS 
		  where OBJECT_NAME = UPPER(p_procedureName)
		  ORDER BY POSITION;
  else
	  OPEN v_cursor FOR
		  SELECT	POSITION,
						  ARGUMENT_NAME,
						  DATA_TYPE,	   
						  IN_OUT
		  from		USER_ARGUMENTS 
		  where PACKAGE_NAME = UPPER(p_packageName)
					  AND OBJECT_NAME = UPPER(p_procedureName)
		  ORDER BY POSITION;
  end if;
	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetProcedureDefinition;

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
			WHERE RQUID like CONCAT(p_rquID, '%');
	
	p_sourceData := v_cData;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetEntity;
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

PROCEDURE LockClaimNumber (
          pin_ruleId  IN CLAIMNUMBERASSIGNMENTRULE.CLAIMNUMBERASSIGNMENTRULE_ID%TYPE,
          pin_maximum IN CLAIMNUMBERASSIGNMENTRULE.NEXT%TYPE,
          pin_claim_number OUT CLAIMNUMBERASSIGNMENTRULE.NEXT%TYPE) 
IS
  strUsedUpFlg        CLAIMNUMBERASSIGNMENTRULE.USEDUP_FLG%TYPE;
  numTempNext        CLAIMNUMBERASSIGNMENTRULE.NEXT%TYPE;
  OTHERS            EXCEPTION;
  e_Claim_Number        EXCEPTION;
  
  CURSOR claimNumberAssignment IS
        SELECT * FROM CLAIMNUMBERASSIGNMENTRULE WHERE CLAIMNUMBERASSIGNMENTRULE_ID=pin_ruleId FOR UPDATE OF NEXT, USEDUP_FLG;
  claim_number_rec            claimNumberAssignment%ROWTYPE;
  
BEGIN
  -- Retrieve valid claim number rule
  OPEN claimNumberAssignment;
  FETCH claimNumberAssignment INTO claim_number_rec;
  
  IF claimNumberAssignment%FOUND THEN
    pin_claim_number:=claim_number_rec.Next;
    numTempNext:=claim_number_rec.Next;
    strUsedUpFlg:='N';
    IF claim_number_rec.Next=pin_maximum THEN
      numTempNext:=claim_number_rec.MINIMUM;
      send_mail_mult('firstreport@claimhost.com','krosati@sedgwick.com;echavez@sedgwick.com;','kkhushoo@sedgwick.com','Sedgwick Claim Number RESET Notification','Sedgwick claim number counter has been reset to ' || numTempNext);
    ELSE
      numTempNext:=numTempNext + 1;
    END IF;
    UPDATE CLAIMNUMBERASSIGNMENTRULE
    SET NEXT = numTempNext,
          USEDUP_FLG = strUsedUpFlg
    WHERE CURRENT OF claimNumberAssignment;
    COMMIT;
  ELSE
    RAISE e_Claim_Number;
  END IF;
  
EXCEPTION
  WHEN e_Claim_Number THEN
    ROLLBACK;
    IF claimNumberAssignment%ISOPEN THEN
      CLOSE claimNumberAssignment;
    END IF;
    numApplicationLogID:=SeqFunctions.GetNextSeq('APPLICATION_LOG');
    strSQLCODE:=TO_CHAR(SQLCODE);
    strSQLERRM:=SQLERRM;
    strErrorString:='Error within LockClaimNumber. Claim Number Rule record not found:   '|| strSQLCODE ||'  '|| strSQLERRM;
    strServer:='';
  INSERT INTO APPLICATION_LOG
        (APPLICATION_LOG_ID,
        COMPONENT,
        SERVER,
        SERVERITY,
        ERRORSTRING,
        CREATED_DT)
  VALUES
        (numApplicationLogID,
        con_Component,
        strServer,
        con_ErrTypeError,
        strErrorString,
        SYSDATE);
  COMMIT;
  WHEN OTHERS THEN
    ROLLBACK;
    IF claimNumberAssignment%ISOPEN THEN
      CLOSE claimNumberAssignment;
    END IF;
    numApplicationLogID:=SeqFunctions.GetNextSeq('APPLICATION_LOG');
    strSQLCODE:=TO_CHAR(SQLCODE);
    strSQLERRM:=SQLERRM;
    strErrorString:='General error within LockClaimNumber:   '|| strSQLCODE ||'  '|| strSQLERRM;
    strServer:='';
    INSERT INTO APPLICATION_LOG
        (APPLICATION_LOG_ID,
        COMPONENT,
        SERVER,
        SERVERITY,
        ERRORSTRING,
        CREATED_DT)
    VALUES
        (numApplicationLogID,
        con_Component,
        strServer,
        con_ErrTypeError,
        strErrorString,
        SYSDATE);
    COMMIT;
END LockClaimNumber;

PROCEDURE AddEscalationOutcomeStep(
		p_EscalationOutcomeId	IN ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_ID%TYPE,
		p_UserId				IN ESCALATION_OUTCOME_STEP.USER_ID%TYPE,
		p_Name					IN VARCHAR2,
		P_Title					IN VARCHAR2,
		p_PhoneNumber			IN VARCHAR2,
		p_Description			IN VARCHAR2,
		p_Complete				IN VARCHAR2,
		p_result				OUT ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_STEP_ID%TYPE)
AS
BEGIN
	DECLARE
		strStatus		VARCHAR2(100);
		numEOSID		ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_STEP_ID%TYPE;
		
	BEGIN
		IF p_Complete = 'Y' THEN
			strStatus := 'RESPONDED';
		ELSE
			strStatus := 'WAITING FOR RESPONSE';
		END IF;
		numEOSID := SeqFunctions.GetNextSeq('ESCALATION_OUTCOME_STEP');

		INSERT INTO ESCALATION_OUTCOME_STEP
					(ESCALATION_OUTCOME_STEP_ID,
					ESCALATION_OUTCOME_ID,
					USER_ID,
					STATUS,
					DESCRIPTION,
					CONTACT_PERSON,
					CONTACT_PHONE_NUMBER,
					CONTACT_PERSON_TITLE,
					SEQUENCE,
					CREATED_DT,
					MODIFIED_DT)
		VALUES
					(numEOSID,
					p_EscalationOutcomeId,
					p_UserId,
					strStatus,
					p_Description,
					p_Name,
					p_PhoneNumber,
					P_Title,
					0,
					SYSDATE,
					SYSDATE);

		IF p_Complete = 'Y' THEN
			UPDATE ESCALATION_OUTCOME SET STATUS='CLOSED', MODIFIED_DT = SYSDATE
			WHERE ESCALATION_OUTCOME_ID = p_EscalationOutcomeId;
		ELSE
			UPDATE ESCALATION_OUTCOME SET STATUS='IN PROCESS', MODIFIED_DT = SYSDATE
			WHERE ESCALATION_OUTCOME_ID = p_EscalationOutcomeId;
		END IF ;

		COMMIT;
		
		p_result := numEOSID;

	END;

	EXCEPTION
		WHEN OTHERS THEN
			ROLLBACK;
				p_result := 0;
           		RAISE_APPLICATION_ERROR(-20001,'SP_ADD_ESCALATION_OUTCOME_STEP failed');
END AddEscalationOutcomeStep;

PROCEDURE UpdateEscalationOutcomeStep(
		p_EscalationOutcomeId	IN ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_ID%TYPE,
		p_Step_Id				IN ESCALATION_OUTCOME_STEP.ESCALATION_OUTCOME_STEP_ID%TYPE,
		p_UserId				IN ESCALATION_OUTCOME_STEP.USER_ID%TYPE,
		p_Name					IN VARCHAR2,
		p_Title					IN VARCHAR2,
		p_PhoneNumber			IN VARCHAR2,
		p_Description			IN VARCHAR2,
		p_Complete				IN VARCHAR2,
		p_result				OUT int)
AS
BEGIN
	DECLARE
		strStatus			VARCHAR2(100);
	BEGIN

		IF p_Complete = 'Y' THEN
			strStatus := 'RESPONDED';
		ELSE
			strStatus := 'WAITING FOR RESPONSE';
		END IF;

		UPDATE ESCALATION_OUTCOME_STEP SET
					STATUS = strStatus,
					DESCRIPTION = p_Description,
					CONTACT_PERSON = p_Name,
					CONTACT_PHONE_NUMBER =p_PhoneNumber,
					CONTACT_PERSON_TITLE = p_Title,
					MODIFIED_DT = SYSDATE,
					USER_ID = p_UserId
		WHERE ESCALATION_OUTCOME_STEP_ID  = p_Step_Id;

		IF p_Complete = 'Y' THEN
			UPDATE ESCALATION_OUTCOME SET STATUS='CLOSED', MODIFIED_DT = SYSDATE
			WHERE ESCALATION_OUTCOME_ID = p_EscalationOutcomeId;
		ELSE
			UPDATE ESCALATION_OUTCOME SET MODIFIED_DT = SYSDATE
			WHERE ESCALATION_OUTCOME_ID = p_EscalationOutcomeId;
		END IF ;

		p_result := 1;
		COMMIT;

	END;

	EXCEPTION
		WHEN OTHERS THEN
			ROLLBACK;
			p_result := 0;
	      	RAISE_APPLICATION_ERROR(-20001,'SP_UPDATE_ESCALATION_OUTCOME_STEP failed');
END UpdateEscalationOutcomeStep;

PROCEDURE GetRuleUsedBy (
    p_MatchRuleId		  IN	NUMBER,
    results           OUT CURSOR_TYPE)
IS
    v_cursor            CURSOR_TYPE;

BEGIN
  OPEN v_cursor FOR
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, F.Frame_id FrameId, F.Name, 'FRAME' as UsedInTable, 'EnabledRule_id' as UsedInField  FROM RULES R, FRAME F WHERE  R.Rule_id = p_MatchRuleId AND F.EnabledRule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, F.Frame_id FrameId, F.Name, 'FRAME' as UsedInTable, 'ValidRule_id' as UsedInField FROM RULES R, FRAME F WHERE  R.Rule_id = p_MatchRuleId AND F.ValidRule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, F.Frame_id FrameId, F.Name, 'FRAME' as UsedInTable, 'Action_id' as UsedInField FROM RULES R, FRAME F WHERE  R.Rule_id = p_MatchRuleId AND F.Action_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, F.Frame_id FrameId, F.Name, 'FRAME' as UsedInTable, 'Entry_Action_id' as UsedInField FROM RULES R, FRAME F WHERE  R.Rule_id = p_MatchRuleId AND F.Entry_Action_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, FO.Frame_id FrameId, F.Name, 'FRAME_ORDER' as UsedInTable, 'EnabledRule_id' as UsedInField FROM RULES R, FRAME_ORDER FO, FRAME F WHERE R.Rule_id = p_MatchRuleId AND FO.EnabledRule_id = p_MatchRuleId AND FO.Frame_id = F.Frame_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, FO.Frame_id FrameId, F.Name, 'FRAME_ORDER' as UsedInTable, 'ValidRule_id' as UsedInField FROM RULES R, FRAME_ORDER FO, FRAME F WHERE  R.Rule_id = p_MatchRuleId AND FO.ValidRule_id = p_MatchRuleId AND FO.Frame_id = F.Frame_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, FO.Frame_id FrameId, F.Name, 'FRAME_ORDER' as UsedInTable, 'Action_id' as UsedInField FROM RULES R, FRAME_ORDER FO, FRAME F WHERE  R.Rule_id = p_MatchRuleId AND FO.Action_id = p_MatchRuleId AND FO.Frame_id = F.Frame_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, FO.Frame_id FrameId, F.Name, 'FRAME_ORDER' as UsedInTable, 'Entry_Action_id' as UsedInField FROM RULES R, FRAME_ORDER FO, FRAME F WHERE  R.Rule_id = p_MatchRuleId AND FO.Entry_Action_id = p_MatchRuleId AND FO.Frame_id = F.Frame_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, A.AccountCallflow_id as FrameId, C.Name, 'ACCOUNT_CALLFLOW' as UsedInTable, 'ValidRule_id' as UsedInField  FROM RULES R, ACCOUNT_CALLFLOW A, CALLFLOW C WHERE R.Rule_id = p_MatchRuleId AND A.ValidRule_id = p_MatchRuleId AND A.Callflow_id = C.Callflow_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, A.Attribute_id as FrameId, A.Name, 'ATTRIBUTE' as UsedInTable, 'EnabledRule_id' as UsedInField FROM RULES R, ATTRIBUTE A WHERE  R.Rule_id = p_MatchRuleId AND A.EnabledRule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, A.Attribute_id as FrameId, A.Name, 'ATTRIBUTE' as UsedInTable, 'ValidRule_id' as UsedInField FROM RULES R, ATTRIBUTE A WHERE  R.Rule_id = p_MatchRuleId AND A.ValidRule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, A.Attribute_id as FrameId, A.Name, 'ATTRIBUTE' as UsedInTable, 'Action_id' as UsedInField FROM RULES R, ATTRIBUTE A WHERE  R.Rule_id = p_MatchRuleId AND A.Action_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, A.Attribute_id as FrameId, A.Name, 'ATTRIBUTE' as UsedInTable, 'PersistRule_id' as UsedInField FROM RULES R, ATTRIBUTE A WHERE  R.Rule_id = p_MatchRuleId AND A.PersistRule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, A.Attribute_id as FrameId, A.Name, 'ATTRIBUTE' as UsedInTable, 'VisibleRule_id' as UsedInField FROM RULES R, ATTRIBUTE A WHERE  R.Rule_id = p_MatchRuleId AND A.VisibleRule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AI.Attr_Instance_id as FrameId, A.Name, 'ATTR_INSTANCE' as UsedInTable, 'EnabledRule_id' as UsedInField FROM RULES R, ATTR_INSTANCE AI, ATTRIBUTE A  WHERE  R.Rule_id = p_MatchRuleId AND AI.EnabledRule_id = R.Rule_id AND AI.Attribute_id = A.Attribute_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AI.Attr_Instance_id as FrameId, A.Name, 'ATTR_INSTANCE' as UsedInTable, 'ValidRule_id' as UsedInField FROM RULES R, ATTR_INSTANCE AI, ATTRIBUTE A  WHERE  R.Rule_id = p_MatchRuleId AND AI.ValidRule_id = R.Rule_id AND AI.Attribute_id = A.Attribute_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AI.Attr_Instance_id as FrameId, A.Name, 'ATTR_INSTANCE' as UsedInTable, 'Action_id' as UsedInField FROM RULES R, ATTR_INSTANCE AI, ATTRIBUTE A  WHERE  R.Rule_id = p_MatchRuleId AND AI.Action_id = R.Rule_id AND AI.Attribute_id = A.Attribute_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AI.Attr_Instance_id as FrameId, A.Name, 'ATTR_INSTANCE' as UsedInTable, 'PersistRule_id' as UsedInField FROM RULES R, ATTR_INSTANCE AI, ATTRIBUTE A  WHERE  R.Rule_id = p_MatchRuleId AND AI.PersistRule_id = R.Rule_id AND AI.Attribute_id = A.Attribute_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AI.Attr_Instance_id as FrameId, A.Name, 'ATTR_INSTANCE' as UsedInTable, 'VisibleRule_id' as UsedInField FROM RULES R, ATTR_INSTANCE AI, ATTRIBUTE A  WHERE  R.Rule_id = p_MatchRuleId AND AI.VisibleRule_id = R.Rule_id AND AI.Attribute_id = A.Attribute_id
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AO.AttributeOverride_id as FrameId, A.Name, 'ATTRIBUTE_OVERRIDE' as UsedInTable, 'EnabledRule_id' as UsedInField FROM RULES R, ATTRIBUTE_OVERRIDE AO, ATTRIBUTE A, ATTR_INSTANCE AI WHERE R.Rule_id = p_MatchRuleId AND AO.EnabledRule_id = p_MatchRuleId AND AO.Attr_Instance_id = AI.Attr_Instance_id AND AI.Attribute_ID = A.Attribute_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AO.AttributeOverride_id as FrameId, A.Name, 'ATTRIBUTE_OVERRIDE' as UsedInTable, 'ValidRule_id' as UsedInField FROM RULES R, ATTRIBUTE_OVERRIDE AO, ATTRIBUTE A, ATTR_INSTANCE AI WHERE R.Rule_id = p_MatchRuleId AND AO.ValidRule_id = p_MatchRuleId AND AO.Attr_Instance_id = AI.Attr_Instance_id AND AI.Attribute_ID = A.Attribute_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AO.AttributeOverride_id as FrameId, A.Name, 'ATTRIBUTE_OVERRIDE' as UsedInTable, 'PersistRule_id' as UsedInField FROM RULES R, ATTRIBUTE_OVERRIDE AO, ATTRIBUTE A, ATTR_INSTANCE AI WHERE R.Rule_id = p_MatchRuleId AND AO.PersistRule_id = p_MatchRuleId AND AO.Attr_Instance_id = AI.Attr_Instance_id AND AI.Attribute_ID = A.Attribute_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AO.AttributeOverride_id as FrameId, A.Name, 'ATTRIBUTE_OVERRIDE' as UsedInTable, 'Action_id' as UsedInField FROM RULES R, ATTRIBUTE_OVERRIDE AO, ATTRIBUTE A, ATTR_INSTANCE AI WHERE R.Rule_id = p_MatchRuleId AND AO.Action_id = p_MatchRuleId AND AO.Attr_Instance_id = AI.Attr_Instance_id AND AI.Attribute_ID = A.Attribute_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, AO.AttributeOverride_id as FrameId, A.Name, 'ATTRIBUTE_OVERRIDE' as UsedInTable, 'Override_Rule_id' as UsedInField FROM RULES R, ATTRIBUTE_OVERRIDE AO, ATTRIBUTE A, ATTR_INSTANCE AI WHERE R.Rule_id = p_MatchRuleId AND AO.Override_Rule_id = p_MatchRuleId AND AO.Attr_Instance_id = AI.Attr_Instance_id AND AI.Attribute_ID = A.Attribute_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, RP.Routing_Plan_id as FrameId, RP.Description as Name, 'ROUTING_PLAN' as UsedInTable, 'EnabledRule_id' as UsedInField FROM RULES R, ROUTING_PLAN RP WHERE R.Rule_id = p_MatchRuleId AND RP.EnableRule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, BAT.BranchAssignmentType_id as FrameId, BAT.Description as Name, 'BRANCHASSIGNMENTTYPE' as UsedInTable, 'Rule_id' as UsedInField FROM RULES R, BRANCHASSIGNMENTTYPE BAT WHERE R.Rule_id = p_MatchRuleId AND BAT.Rule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, BAR.BranchAssignmentRule_id as FrameId, BAT.Description as Name, 'BRANCHASSIGNMENTRULE' as UsedInTable, 'Rule_id' as UsedInField FROM RULES R, BRANCHASSIGNMENTRULE BAR, BRANCHASSIGNMENTTYPE BAT  WHERE R.Rule_id = p_MatchRuleId AND BAR.Rule_id = p_MatchRuleId AND  BAR.BranchAssignmentType_ID = BAT.BranchAssignmentType_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, R.RoutingAddressRule_id as FrameId, A.Name, 'ROUTINGADDRESSRULE' as UsedInTable, 'RoutingRule_id' as UsedInField FROM RULES R, ROUTINGADDRESSRULE R, ACCOUNT_HIERARCHY_STEP A  WHERE R.Rule_id = p_MatchRuleId AND R.RoutingRule_id = p_MatchRuleId AND  R.Accnt_hrcy_step_ID = A.Accnt_hrcy_Step_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, C.ClaimNumberAssignmentRule_id as FrameId, A.Name, 'CLAIMNUMBERASSIGNMENTRULE' as UsedInTable, 'Rule_id' as UsedInField FROM RULES R, CLAIMNUMBERASSIGNMENTRULE C, ACCOUNT_HIERARCHY_STEP A  WHERE R.Rule_id = p_MatchRuleId AND C.Rule_id = p_MatchRuleId AND  C.Accnt_hrcy_step_ID = A.Accnt_hrcy_Step_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, E.Escalation_Plan_id as FrameId, E.Description as Name, 'ESCALATION_PLAN' as UsedInTable, 'EnabledRule_id' as UsedInField FROM RULES R, ESCALATION_PLAN E WHERE R.Rule_id = p_MatchRuleId AND E.EnableRule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, E.Escalation_Seq_Step_id as FrameId, EP.Description as Name, 'ESCALATION_SEQ_STEP' as UsedInTable, 'EnabledRule_id' as UsedInField FROM RULES R, ESCALATION_SEQ_STEP E, ESCALATION_PLAN EP WHERE R.Rule_id = p_MatchRuleId AND E.EnabledRule_id = p_MatchRuleId AND E.Escalation_Plan_ID = EP.Escalation_Plan_ID
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, mBAT.MC_BranchAssignmentType_id as FrameId, mBAT.Description as Name, 'MC_BRANCHASSIGNMENTTYPE' as UsedInTable, 'Rule_id' as UsedInField FROM RULES R, MC_BRANCHASSIGNMENTTYPE mBAT WHERE R.Rule_id = p_MatchRuleId AND mBAT.Rule_id = p_MatchRuleId
UNION
SELECT DISTINCT R.Rule_id RuleId, R.Type RuleType, mBAR.MC_BranchAssignmentRule_id as FrameId, mBAT.Description as Name, 'MC_BRANCHASSIGNMENTRULE' as UsedInTable, 'Rule_id' as UsedInField FROM RULES R, MC_BRANCHASSIGNMENTRULE mBAR, MC_BRANCHASSIGNMENTTYPE mBAT  WHERE R.Rule_id = p_MatchRuleId AND mBAR.Rule_id = p_MatchRuleId AND  mBAR.MC_BranchAssignmentType_ID = mBAT.MC_BranchAssignmentType_ID;

  results := v_cursor;

EXCEPTION
    WHEN OTHERS THEN
        raise;

END GetRuleUsedBy;    
   
PROCEDURE SrchAHSNodesDownTreeSql(
			inAtAHSID		IN ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
			inAHSID			IN ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
			inAHSName		IN ACCOUNT_HIERARCHY_STEP.NAME%TYPE,
			inAddress1		IN ACCOUNT_HIERARCHY_STEP.ADDRESS_1%TYPE,
			inCity			IN ACCOUNT_HIERARCHY_STEP.CITY%TYPE,
			inState			IN ACCOUNT_HIERARCHY_STEP.STATE%TYPE,
			inZip			IN ACCOUNT_HIERARCHY_STEP.ZIP%TYPE,
			inLocationCode 	IN ACCOUNT_HIERARCHY_STEP.LOCATION_CODE%TYPE,
			inUserID		IN USERS.USER_ID%TYPE,
			inSrchType	IN NUMBER,
			results			OUT		VARCHAR2)
IS
	strSQL		VARCHAR2(1000);
	strWhere	VARCHAR2(1000);
	matchPre	VARCHAR2(2);
	matchSuf	VARCHAR2(2);
	nGotFirst	NUMBER;
	
BEGIN
	nGotFirst	:= 0;
	matchPre	:= '';
	matchSuf	:= '%';

	IF inSrchType = 2 THEN
		matchPre	:= '%';
		matchSuf	:= '%';
	END IF;

	IF inSrchType = 3 THEN
		matchPre	:= '';
		matchSuf	:= '';
	END IF;

	strSQL := 'SELECT AHS.accnt_hrcy_step_id AHSID, AHS.name AHSName, AHS.City AHSCity, AHS.State AHSState, AHS.Zip AHSZip FROM account_hierarchy_step AHS ';
	strWhere := ' ';

	IF (inAHSID IS NOT NULL) THEN
		nGotFirst := 1;
		strWhere := strWhere || ' AHS.accnt_hrcy_step_id LIKE ''' || matchPre || inAHSID || matchSuf || ''' ';
	END IF;

	IF (inAHSName IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.NAME) LIKE ''' || matchPre || UPPER(inAHSName) || matchSuf || ''' ';
	END IF;

	IF (inAddress1 IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.ADDRESS_1) LIKE ''' || matchPre || UPPER(inAddress1) || matchSuf || ''' ';
	END IF;

	IF (inCity IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.CITY) LIKE ''' || matchPre || UPPER(inCity) || matchSuf || ''' ';
	END IF;

	IF (inState IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.STATE) LIKE ''' || matchPre || UPPER(inState) || matchSuf || ''' ';
	END IF;

	IF (inZip IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.ZIP) LIKE ''' || matchPre || UPPER(inZip) || matchSuf || ''' ';
	END IF;

	IF (inLocationCode IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' AHS.LOCATION_CODE LIKE ''' || matchPre || inLocationCode || matchSuf || ''' ';
	END IF;

	IF nGotFirst = 1 THEN
		strWhere := 'WHERE ' || strWhere;
	END IF;

	IF nGotFirst = 1 THEN
		strWhere :=  strWhere || ' AND ';
	ELSE
		strWhere := strWhere || ' WHERE ';
	END IF;

	strWhere := strWhere || ' AHS.ACTIVE_STATUS = ''ACTIVE'' and rownum < 200 order by AHS.TYPE';
	strSQL := strSQL || strWhere ;

	results := strSQL;
	

	EXCEPTION
		WHEN OTHERS THEN
           	RAISE_APPLICATION_ERROR(-20001,'SrchAHSNodesDownTreeSql failed');

END SrchAHSNodesDownTreeSql;

PROCEDURE SrchAHSNodesUpTreeSQL(
		inAtAHSID		IN ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
    inAHSID			IN ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
    inAHSName		IN ACCOUNT_HIERARCHY_STEP.NAME%TYPE,
    inAddress1		IN ACCOUNT_HIERARCHY_STEP.ADDRESS_1%TYPE,
    inCity			IN ACCOUNT_HIERARCHY_STEP.CITY%TYPE,
    inState			IN ACCOUNT_HIERARCHY_STEP.STATE%TYPE,
    inZip			IN ACCOUNT_HIERARCHY_STEP.ZIP%TYPE,
    inLocationCode 	IN ACCOUNT_HIERARCHY_STEP.LOCATION_CODE%TYPE,
    inUserID		IN USERS.USER_ID%TYPE,
		inSrchType	IN NUMBER,
    results			OUT		VARCHAR2)
IS

	strSQL		VARCHAR2(1000);
	strWhere	VARCHAR2(1000);
	matchPre	VARCHAR2(2);
	matchSuf	VARCHAR2(2);
	nGotFirst	NUMBER;

BEGIN
	nGotFirst	:= 0;
	matchPre	:= '';
	matchSuf	:= '%';

	IF inSrchType = 2 THEN
		matchPre	:= '%';
		matchSuf	:= '%';
	END IF;

	IF inSrchType = 3 THEN
		matchPre	:= '';
		matchSuf	:= '';
	END IF;

	strSQL := 'SELECT AHS.accnt_hrcy_step_id AHSID, AHS.name AHSName, AHS.City AHSCity, AHS.State AHSState, AHS.Zip AHSZip, level FROM account_hierarchy_step AHS ';
	strWhere := ' ';

	IF (inAHSID IS NOT NULL) THEN
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.accnt_hrcy_step_id) LIKE ''' || matchPre || UPPER(inAHSID) || matchSuf || ''' ';
	END IF;

	IF (inAHSName IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.NAME) LIKE ''' || matchPre || UPPER(inAHSName) || matchSuf || ''' ';
	END IF;

	IF (inAddress1 IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.ADDRESS_1) LIKE ''' || matchPre || UPPER(inAddress1) || matchSuf || ''' ';
	END IF;

	IF (inCity IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.CITY) LIKE ''' || matchPre || UPPER(inCity) || matchSuf || ''' ';
	END IF;

	IF (inState IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.STATE) LIKE ''' || matchPre || UPPER(inState) || matchSuf || ''' ';
	END IF;

	IF (inZip IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.ZIP) LIKE ''' || matchPre || UPPER(inZip) || matchSuf || ''' ';
	END IF;

	IF (inLocationCode IS NOT NULL) THEN
		IF nGotFirst = 1 THEN
		strWhere := strWhere || 'AND ';
		END IF;
		nGotFirst := 1;
		strWhere := strWhere || ' UPPER(AHS.LOCATION_CODE) LIKE ''' || matchPre || UPPER(inLocationCode) || matchSuf || ''' ';
	END IF;

	IF nGotFirst = 1 THEN
		strWhere := 'WHERE ' || strWhere;
	END IF;

	IF (inUserID IS NOT NULL) THEN
		strWhere := strWhere || ' AND AHS.accnt_hrcy_step_id IN ( SELECT CHILD_ID FROM ACCOUNT_HIERARCHY_CHILD WHERE PARENT_ID IN (SELECT ACCNT_HRCY_STEP_ID FROM ACCOUNT_USER WHERE USER_ID = ' || inUserID || ')) ' ;
	End If;

	strSQL := strSQL || strWhere || ' START WITH AHS.accnt_hrcy_step_id = ' || inAtAHSID || ' CONNECT BY AHS.accnt_hrcy_step_id = PRIOR AHS.parent_node_id ';

	results := strSQL;

	EXCEPTION
		WHEN OTHERS THEN
           	RAISE_APPLICATION_ERROR(-20001,'SrchAHSNodesUpTree failed');

END SrchAHSNodesUpTreeSQL;

PROCEDURE AddAccountUser(StrAcctID	IN VARCHAR2,
			StrUserID	IN VARCHAR2,
			StatusMsg	OUT VARCHAR2,
			StatusNum	OUT NUMBER)
IS

	CURSOR curChildren IS SELECT CHILD_ID FROM ACCOUNT_HIERARCHY_CHILD WHERE PARENT_ID = StrAcctID AND CHILD_ID In (SELECT ACCNT_HRCY_STEP_ID FROM ACCOUNT_USER WHERE USER_ID = StrUserID);

	StatusStr		VARCHAR2(1000);
	ChildStr		VARCHAR2(1000);
	numFoundCurAcctID	ACCOUNT_HIERARCHY_CHILD.CHILD_ID%TYPE;
	countRec 		NUMBER DEFAULT 0;
	curStatus		NUMBER DEFAULT 0;
BEGIN

	ChildStr := '';
	StatusStr := '';
	StatusNum := curStatus;


--	IF StrAcctID = '1' THEN
--		StatusStr := 'Security cannot be added for Account ID: ' || StrAcctID ;
--		curStatus := 1;
--	END IF;


	--Check if security already exists for the account ID through a parent node
	IF curStatus = 0 THEN
		BEGIN
			SELECT CHILD_ID INTO numFoundCurAcctID FROM ACCOUNT_HIERARCHY_CHILD WHERE PARENT_ID IN
				(SELECT ACCNT_HRCY_STEP_ID FROM ACCOUNT_USER WHERE USER_ID = StrUserID)
				AND CHILD_ID = StrAcctID;
			StatusNum := 1;
			StatusStr := 'Security already exists for User ID: ' || StrUserID || ', Account ID: ' || StrAcctID || '  through this node or a parent node.';

		EXCEPTION WHEN NO_DATA_FOUND THEN
			curStatus := 0;
		END;
	END IF;


	--Check if any child nodes have security
	IF curStatus = 0 THEN
		FOR curRow IN curChildren LOOP
			IF countRec  = 0 THEN
				ChildStr := curRow.CHILD_ID;
			ELSE
				ChildStr := ChildStr || ', ' || curRow.CHILD_ID;
			END IF;
			countRec:= countRec + 1;
		END LOOP;

		IF countRec > 0 THEN
			curStatus := 1;
			StatusStr := 'Security already exists for User ID: ' || StrUserID || ', Account ID: ' || StrAcctID || ' at following child node(s): ' || ChildStr;
		END IF;
	END IF;


	IF curStatus = 0 THEN
		INSERT INTO ACCOUNT_USER (ACCNT_HRCY_STEP_ID, USER_ID) VALUES (StrAcctID, StrUserID);
		StatusStr := 'Success';
	END IF;

	StatusNum := curStatus;
	StatusMsg := StatusStr;

	EXCEPTION

		WHEN OTHERS THEN
				StatusMsg := SQLERRM;
				StatusNum := SQLCODE;

End AddAccountUser; 

END DBCLASSLIBRARY;
/

