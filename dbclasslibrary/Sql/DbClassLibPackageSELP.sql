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
-- DBCLASSLIBRARY package definition for SELECTIVE database instances
---------------------------------------------------------------------------
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Sql/DbClassLibPackageSELP.sql 4     6/20/11 7:45p Gwynnj $ */
---------------------------------------------------------------------------
CREATE OR REPLACE PACKAGE DBCLASSLIBRARY AS

TYPE  CURSOR_TYPE IS REF CURSOR;

PROCEDURE CreateClaimSubmission(
	claimSubId							OUT		CLAIM_SUBMISSION.CLAIM_SUBMISSION_ID%TYPE,
	callId									IN		CLAIM_SUBMISSION.CALL_ID%TYPE,
	rquId										IN		CLAIM_SUBMISSION.RQID%TYPE,
	policyNumber						IN		CLAIM_SUBMISSION.POLICY_NUMBER%TYPE,
	dateOfLoss							IN		CLAIM_SUBMISSION.DATE_OF_LOSS%TYPE,
	fileFormatCode					IN		CLAIM_SUBMISSION.FILE_FORMAT_CD%TYPE,
	lossFileNumber					IN		CLAIM_SUBMISSION.LOSS_FILE_NUM%TYPE,
	claimNumber							IN		CLAIM_SUBMISSION.CLAIM_NUMBER%TYPE,
	claimStatus							IN		CLAIM_SUBMISSION.STATUS%TYPE,
	errorCode								IN		CLAIM_SUBMISSION.ERROR_CD%TYPE,
	errorText								IN		CLAIM_SUBMISSION.ERROR_TEXT%TYPE);
	
PROCEDURE UpdateClaimSubmissionStatus(
	claimSubId							OUT		CLAIM_SUBMISSION.CLAIM_SUBMISSION_ID%TYPE,
	rquId										IN		CLAIM_SUBMISSION.RQID%TYPE,
	claimStatus							IN		CLAIM_SUBMISSION.STATUS%TYPE);	

PROCEDURE ResetClaimSubmissionStatus(
	rquId										IN		CLAIM_SUBMISSION.RQID%TYPE);	



PROCEDURE GetMercuryDestinations (
	destinationType					IN		MERCURY.TYPE%TYPE,
	results									OUT		CURSOR_TYPE);
	
PROCEDURE GetOverflowSet (
	p_accntHrcyStepId				IN		OUTPUT_OVERFLOW.ACCNT_HRCY_STEP_ID%TYPE,
	p_LineOfBusiness				IN		OUTPUT_OVERFLOW.LOB_CD%TYPE,
	results									OUT		CURSOR_TYPE);

PROCEDURE GetMandatoryFields (
	p_LOB_CD								IN		SEL_MANDATORY_FIELDS.LOB_CD%TYPE,
	results									OUT		CURSOR_TYPE);	
	
PROCEDURE GetQueueAssignments (
	p_attributeName					IN		SEL_QUEUE_ASSIGNMENT.NAME%TYPE,
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
	
PROCEDURE GetClaimSubLogData (
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_requestType				IN	VARCHAR2,
	clobData						OUT	CLOB);

PROCEDURE ResetClaimLogResponse (
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_results						OUT	int);
	
PROCEDURE UpdateClaimCsrId (
	p_selCsrID					OUT	SEL_CSR.SEL_CSR_ID%TYPE,
	p_csrID							IN	SEL_CSR.CSR_ID%TYPE,
	p_callID						IN	SEL_CSR.CALL_ID%TYPE,
	p_lastName					IN	SEL_CSR.NAME_LAST%TYPE,
	p_firstName					IN	SEL_CSR.NAME_FIRST%TYPE);
	
PROCEDURE UpdateClaimCmsId (
	p_selCmsID					OUT	SEL_CMS.SEL_CMS_ID%TYPE,
	p_cmsID							IN	SEL_CMS.CMS_ID%TYPE,
	p_callID						IN	SEL_CMS.CALL_ID%TYPE,
	p_lastName					IN	SEL_CMS.NAME_LAST%TYPE,
	p_firstName					IN	SEL_CMS.NAME_FIRST%TYPE);

PROCEDURE UpdateClaimCmsId2 (
	p_selCmsID					OUT	SEL_CMS.SEL_CMS_ID%TYPE,
	p_cmsID							IN	SEL_CMS.CMS_ID%TYPE,
	p_callID						IN	SEL_CMS.CALL_ID%TYPE,
	p_lastName					IN	SEL_CMS.NAME_LAST%TYPE,
	p_firstName					IN	SEL_CMS.NAME_FIRST%TYPE,
	p_middleInit				IN	SEL_CMS.NAME_MID%TYPE,
	p_prefix						IN  SEL_CMS.NAME_PREFIX%TYPE,
	p_suffix						IN	SEL_CMS.NAME_SUFFIX%TYPE,
	p_propQId						IN	SEL_CMS.PROPQ_ID%TYPE,
	p_propQName					IN	SEL_CMS.PROPQ_NAME%TYPE);

PROCEDURE ResetClaimCsr (
	p_callID						IN	SEL_CSR.CALL_ID%TYPE);
	
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
	
PROCEDURE GetAppSetting (
    p_Application              IN    CONFIG_SETTINGS.APPLICATION%TYPE,
    p_Key					             IN    CONFIG_SETTINGS.KEY%TYPE,
    p_Results                 OUT    CONFIG_SETTINGS.VALUE%TYPE
);

PROCEDURE CreateUpdateEntities(
	p_id							OUT	ENTITIES.ENTITY_ID%TYPE,
	p_rquID							IN	ENTITIES.RQUID%TYPE,
	p_sourceData					IN	CLOB);
	
PROCEDURE GetEntity(
	p_rquID							IN	ENTITIES.RQUID%TYPE,
	p_sourceData					OUT	CLOB);
	
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
	
END DBCLASSLIBRARY;
/

CREATE OR REPLACE PACKAGE BODY DBCLASSLIBRARY AS

------------------------------------------------------------------------
-- creates a new CLAIM_SUBMISSION entry 
-- RQID must be unique 
-- returns CLAIM_SUBMISSION_ID on success -1 on failure
------------------------------------------------------------------------
PROCEDURE CreateClaimSubmission(
	claimSubId							OUT		CLAIM_SUBMISSION.CLAIM_SUBMISSION_ID%TYPE,
	callId									IN		CLAIM_SUBMISSION.CALL_ID%TYPE,
	rquId										IN		CLAIM_SUBMISSION.RQID%TYPE,
	policyNumber						IN		CLAIM_SUBMISSION.POLICY_NUMBER%TYPE,
	dateOfLoss							IN		CLAIM_SUBMISSION.DATE_OF_LOSS%TYPE,
	fileFormatCode					IN		CLAIM_SUBMISSION.FILE_FORMAT_CD%TYPE,
	lossFileNumber					IN		CLAIM_SUBMISSION.LOSS_FILE_NUM%TYPE,
	claimNumber							IN		CLAIM_SUBMISSION.CLAIM_NUMBER%TYPE,
	claimStatus							IN		CLAIM_SUBMISSION.STATUS%TYPE,
	errorCode								IN		CLAIM_SUBMISSION.ERROR_CD%TYPE,
	errorText								IN		CLAIM_SUBMISSION.ERROR_TEXT%TYPE
)
IS
	CURSOR currentClaimSubmission
	IS
		SELECT *
		FROM CLAIM_SUBMISSION
		WHERE RQID = rquId;

	claim				 currentClaimSubmission%ROWTYPE;
	RqIdExistsException		EXCEPTION;
	
BEGIN

	OPEN currentClaimSubmission;
	fetch currentClaimSubmission into claim;

	-- If no pre-existing RQID then we can insert
	IF currentClaimSubmission%NOTFOUND THEN
	
		-- Get the new CLAIM_SUBMISSION_ID
		claimSubId := SeqFunctions.GetNextSeq('CLAIM_SUBMISSION');
	
		insert into CLAIM_SUBMISSION (
												CLAIM_SUBMISSION_ID,
												CALL_ID,
												RQID,
												POLICY_NUMBER,
												DATE_OF_LOSS,
												FILE_FORMAT_CD,
												LOSS_FILE_NUM,
												CLAIM_NUMBER,
												STATUS,
												ERROR_CD,
												ERROR_TEXT)
		values (						
												claimSubId,
												callId,
												rquId,
												policyNumber,
												dateOfLoss,
												fileFormatCode,
												lossFileNumber,
												claimNumber,
												claimStatus,
												errorCode,
												errorText);
	ELSE
		-- return an indication that this call has already been submitted
		RAISE RqIdExistsException;
	END IF;

	COMMIT;
	
EXCEPTION
	WHEN RqIdExistsException THEN
		claimSubId := -1;	
		RAISE_APPLICATION_ERROR(-20001,'Attempt to transmit claim: RQUID EXISTS');
	WHEN OTHERS THEN
	claimSubId := -1;
	raise;

END CreateClaimSubmission;
------------------------------------------------------------------------
-- Update Claim_Submission status 
-- returns CLAIM_SUBMISSION_ID on success -1 on failure
------------------------------------------------------------------------
PROCEDURE UpdateClaimSubmissionStatus(
	claimSubId							OUT		CLAIM_SUBMISSION.CLAIM_SUBMISSION_ID%TYPE,
	rquId										IN		CLAIM_SUBMISSION.RQID%TYPE,
	claimStatus							IN		CLAIM_SUBMISSION.STATUS%TYPE
)
IS
	CURSOR currentClaimSubmissionUpdate
	IS
		SELECT *
		FROM CLAIM_SUBMISSION
		WHERE RQID = rquId;

	claim								currentClaimSubmissionUpdate%ROWTYPE;
	NotFoundException		EXCEPTION;
	
BEGIN

	OPEN currentClaimSubmissionUpdate;
	fetch currentClaimSubmissionUpdate into claim;
	
	-- If no pre-existing RQID then we can insert
	IF currentClaimSubmissionUpdate%NOTFOUND THEN
		RAISE NotFoundException;
	ELSE
			UPDATE CLAIM_SUBMISSION SET STATUS = claimStatus
			WHERE CLAIM_SUBMISSION_ID = claim.CLAIM_SUBMISSION_ID;
			claimSubId := claim.CLAIM_SUBMISSION_ID;
	END IF;

	COMMIT;
	
EXCEPTION
	WHEN NotFoundException THEN
		claimSubId := -1;	
		RAISE_APPLICATION_ERROR(-20001,'Attempt to update claim: RQUID NOT FOUND');
	WHEN OTHERS THEN
		claimSubId := -1;
		raise;

END UpdateClaimSubmissionStatus;	
		
------------------------------------------------------------------------
-- ResetClaimSubmissionStatus
-- remove prior claim entry for resubmit
------------------------------------------------------------------------	
PROCEDURE ResetClaimSubmissionStatus(
	rquId										IN		CLAIM_SUBMISSION.RQID%TYPE
)
IS
		
BEGIN

	DELETE FROM CLAIM_SUBMISSION WHERE RQID = rquId;
	COMMIT;
	
EXCEPTION
	WHEN OTHERS THEN
		raise;

END ResetClaimSubmissionStatus;				
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
-- Get Selective Mandatory Fields for  Xml validation 
-- returns Set of TYPE SEL_MANDATORY_FIELDS
------------------------------------------------------------------------	
PROCEDURE GetMandatoryFields (
	p_LOB_CD								IN		SEL_MANDATORY_FIELDS.LOB_CD%TYPE,
	results									OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN
	OPEN v_cursor FOR
				select NAME, LOB_CD, R1.RULE_TEXT as RULE1_TEXT, 
							R2.RULE_TEXT as RULE2_TEXT from SEL_MANDATORY_FIELDS S, RULES R1, RULES R2
				where LOB_CD = p_LOB_CD
							and S.RULE1 = R1.RULE_ID(+) 
							and S.RULE2 = R2.RULE_ID(+);
	
	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetMandatoryFields;

------------------------------------------------------------------------
-- Get Selective Queue Assignment 
-- returns Set of TYPE SEL_MANDATORY_FIELDS
------------------------------------------------------------------------	
PROCEDURE GetQueueAssignments (
	p_attributeName					IN		SEL_QUEUE_ASSIGNMENT.NAME%TYPE,
	results									OUT		CURSOR_TYPE
)
IS
	v_cursor			CURSOR_TYPE;

BEGIN

	IF p_attributeName IS NOT NULL AND LENGTH(p_attributeName) > 0 THEN
		OPEN v_cursor FOR
					select NAME, SEQUENCE, DEFAULTVALUE, RULE_TEXT from SEL_QUEUE_ASSIGNMENT 
					where NAME = p_attributeName ORDER BY SEQUENCE;
	
	ELSE
		OPEN v_cursor FOR
					select NAME, SEQUENCE, DEFAULTVALUE, RULE_TEXT from SEL_QUEUE_ASSIGNMENT 
					ORDER BY NAME, SEQUENCE;

	END IF;
	
	results := v_cursor;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetQueueAssignments;

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

PROCEDURE UpdateClaimCsrId (
	p_selCsrID					OUT	SEL_CSR.SEL_CSR_ID%TYPE,
	p_csrID							IN	SEL_CSR.CSR_ID%TYPE,
	p_callID						IN	SEL_CSR.CALL_ID%TYPE,
	p_lastName					IN	SEL_CSR.NAME_LAST%TYPE,
	p_firstName					IN	SEL_CSR.NAME_FIRST%TYPE
)
IS

	CURSOR curCsId
	IS
		SELECT *
		FROM SEL_CSR
		WHERE		CSR_ID	= p_csrID
			AND CALL_ID = p_callID;

	SEL_CSRID_REC				 curCsId%ROWTYPE;
BEGIN
	
	OPEN curCsId;
	FETCH curCsId into SEL_CSRID_REC;
	 
	IF( curCsId%NOTFOUND ) THEN
		
		-- Get the new SEL_CSR_ID
		p_selCsrID := SeqFunctions.GetNextSeq('SEL_CSR');
		
		INSERT INTO SEL_CSR (
												SEL_CSR_ID,
												CSR_ID,
												CALL_ID,
												NAME_LAST,
												NAME_FIRST)
						VALUES (
											p_selCsrID,
											p_csrID,
											p_callID,
											p_lastName,
											p_firstName);
	ELSE
			
		p_selCsrID :=  SEL_CSRID_REC.SEL_CSR_ID;
			
		UPDATE 	SEL_CSR SET
								CALL_ID = p_callID,
								NAME_LAST = p_lastName,
								NAME_FIRST = p_firstName
			WHERE SEL_CSR_ID = SEL_CSRID_REC.SEL_CSR_ID ;
				
	END IF;
	
	COMMIT;												


EXCEPTION
	WHEN OTHERS THEN
		p_selCsrID := -1;
		raise;
		
END UpdateClaimCsrId;
-----------------------------------------------------
-- Reset prior to lookup to clear out old records
-- if any exist
-----------------------------------------------------
PROCEDURE ResetClaimCsr (
	p_callID						IN	SEL_CSR.CALL_ID%TYPE)
IS
	v_count			integer;
	
	BEGIN
		
		DELETE from SEL_CSR where CALL_ID = p_callID;
		DELETE from SEL_CMS where CALL_ID = p_callID;
	
		COMMIT;												


EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END ResetClaimCsr;
-----------------------------------------------------
-- Update Selective CMS values
-----------------------------------------------------
PROCEDURE UpdateClaimCmsId (
	p_selCmsID					OUT	SEL_CMS.SEL_CMS_ID%TYPE,
	p_cmsID							IN	SEL_CMS.CMS_ID%TYPE,
	p_callID						IN	SEL_CMS.CALL_ID%TYPE,
	p_lastName					IN	SEL_CMS.NAME_LAST%TYPE,
	p_firstName					IN	SEL_CMS.NAME_FIRST%TYPE
)
IS

	CURSOR curCsId
	IS
		SELECT *
		FROM SEL_CMS
		WHERE		CALL_ID = p_callID
		AND CMS_ID = p_cmsID;

	SEL_CMSID_REC				 curCsId%ROWTYPE;
BEGIN
	
	OPEN curCsId;
	FETCH curCsId into SEL_CMSID_REC;
	 
	IF( curCsId%NOTFOUND ) THEN
		
		-- Get the new SEL_CMS_ID
		p_selCmsID := SeqFunctions.GetNextSeq('SEL_CMS');
		
		INSERT INTO SEL_CMS (
												SEL_CMS_ID,
												CMS_ID,
												CALL_ID,
												NAME_LAST,
												NAME_FIRST)
						VALUES (
											p_selCmsID,
											p_cmsID,
											p_callID,
											p_lastName,
											p_firstName);
	ELSE
			
		p_selCmsID :=  SEL_CMSID_REC.SEL_CMS_ID;
			
		UPDATE 	SEL_CMS SET
								NAME_LAST = p_lastName,
								NAME_FIRST = p_firstName
			WHERE SEL_CMS_ID = SEL_CMSID_REC.SEL_CMS_ID;
				
	END IF;
	
	COMMIT;												


EXCEPTION
	WHEN OTHERS THEN
		p_selCmsID := -1;
		raise;
		
END UpdateClaimCmsId;

-----------------------------------------------------
-- Update Selective CMS values version 2
-----------------------------------------------------
PROCEDURE UpdateClaimCmsId2 (
	p_selCmsID					OUT	SEL_CMS.SEL_CMS_ID%TYPE,
	p_cmsID							IN	SEL_CMS.CMS_ID%TYPE,
	p_callID						IN	SEL_CMS.CALL_ID%TYPE,
	p_lastName					IN	SEL_CMS.NAME_LAST%TYPE,
	p_firstName					IN	SEL_CMS.NAME_FIRST%TYPE,
	p_middleInit				IN	SEL_CMS.NAME_MID%TYPE,
	p_prefix						IN  SEL_CMS.NAME_PREFIX%TYPE,
	p_suffix						IN	SEL_CMS.NAME_SUFFIX%TYPE,
	p_propQId						IN	SEL_CMS.PROPQ_ID%TYPE,
	p_propQName					IN	SEL_CMS.PROPQ_NAME%TYPE
)
IS

	CURSOR curCsId
	IS
		SELECT *
		FROM SEL_CMS
		WHERE		CALL_ID = p_callID
			AND CMS_ID = p_cmsID;

	SEL_CMSID_REC				 curCsId%ROWTYPE;
BEGIN
	
	OPEN curCsId;
	FETCH curCsId into SEL_CMSID_REC;
	 
	IF( curCsId%NOTFOUND ) THEN
		
		-- Get the new SEL_CMS_ID
		p_selCmsID := SeqFunctions.GetNextSeq('SEL_CMS');
		
		INSERT INTO SEL_CMS (
												SEL_CMS_ID,
												CMS_ID,
												CALL_ID,
												NAME_LAST,
												NAME_FIRST,
												NAME_MID,
												NAME_PREFIX,
												NAME_SUFFIX,
												PROPQ_ID,
												PROPQ_NAME)
						VALUES (
											p_selCmsID,
											p_cmsID,
											p_callID,
											p_lastName,
											p_firstName,
											p_middleInit,
											p_prefix,
											p_suffix,
											p_propQId,
											p_propQName);
	ELSE
			
		p_selCmsID :=  SEL_CMSID_REC.SEL_CMS_ID;
			
		UPDATE 	SEL_CMS SET
								NAME_LAST = p_lastName,
								NAME_FIRST = p_firstName,
								NAME_MID = p_middleInit,
								NAME_PREFIX = p_prefix,
								NAME_SUFFIX = p_suffix,
								PROPQ_ID = p_propQId,
								PROPQ_NAME = p_propQName
			WHERE SEL_CMS_ID = SEL_CMSID_REC.SEL_CMS_ID;
				
	END IF;
	
	COMMIT;												


EXCEPTION
	WHEN OTHERS THEN
		p_selCmsID := -1;
		raise;
		
END UpdateClaimCmsId2;

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
							
		IF p_nDescr IS NOT NULL THEN
			AddVehicleCoverageExtension (v_VehicleCoverageExtId,p_nVehicleCoverageId,p_nFileTranLogId,p_nDescr);	
		END IF;
							
	ELSE

		p_nVehicleCoverageId :=  VEHICLE_REC.VEHICLE_COVERAGE_ID;

	END IF;
	
	
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_nVehicleCoverageId := -1;
	raise;

END ProcessVehicleCoverage;		

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
			WHERE RQUID = p_rquID;
	
	p_sourceData := v_cData;

EXCEPTION
	WHEN OTHERS THEN
		raise;
		
END GetEntity;

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
END;

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
END;

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

END DBCLASSLIBRARY;
/
