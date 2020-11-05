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
/* $Header: /SourceCode/Components/VS.NET2005/DbClassLibrary/DbClassLibPackage.sql 1     1/02/07 3:53p John.gwynn $ */
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
		WHERE		CALL_ID = p_callID;

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
								CMS_ID = p_cmsID,
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

END DBCLASSLIBRARY;
/
