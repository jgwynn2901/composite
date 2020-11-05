-- "Set scan off" turns off substitution variables. 
Set scan off; 

CREATE OR REPLACE PACKAGE FNSOWNER.DBCLASSLIBRARY AS

TYPE  CURSOR_TYPE IS REF CURSOR;

PROCEDURE SetOrGetSentryLastLocation (
	inputLogId					IN		SENTRY_LAST_LOCATION.FILE_TRANSMISSION_LOG_ID%TYPE,
	outputLogId					OUT		SENTRY_LAST_LOCATION.FILE_TRANSMISSION_LOG_ID%TYPE);

PROCEDURE GetMercuryDestinations (
	destinationType					IN		MERCURY.TYPE%TYPE,
	results									OUT		CURSOR_TYPE);

PROCEDURE GetOverflowSet (
	p_accntHrcyStepId				IN		OUTPUT_OVERFLOW.ACCNT_HRCY_STEP_ID%TYPE,
	p_LineOfBusiness				IN		OUTPUT_OVERFLOW.LOB_CD%TYPE,
	results									OUT		CURSOR_TYPE);

PROCEDURE ProcessClaimSubmissionLog(
	p_id								OUT	CLAIM_SUBMISSION_LOG.CLAIM_SUBMISSION_LOG_ID%TYPE,
	p_rquID							IN	CLAIM_SUBMISSION_LOG.RQUID%TYPE,
	p_requestType				IN	VARCHAR2,
	clobData						IN	CLOB);
	

END DBCLASSLIBRARY;
/


CREATE OR REPLACE PACKAGE BODY FNSOWNER.DBCLASSLIBRARY AS

-----------------------------------------------------------------------
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

-----------------------------------------------------------------------
-- Get SetOrGetSentryLastLocation
-- returns or updates last location file post processed
------------------------------------------------------------------------
PROCEDURE SetOrGetSentryLastLocation (
	inputLogId					IN		SENTRY_LAST_LOCATION.FILE_TRANSMISSION_LOG_ID%TYPE,
	outputLogId					OUT		SENTRY_LAST_LOCATION.FILE_TRANSMISSION_LOG_ID%TYPE
)
IS
	v_current					SENTRY_LAST_LOCATION.FILE_TRANSMISSION_LOG_ID%TYPE;

BEGIN
	SELECT FILE_TRANSMISSION_LOG_ID INTO v_current from SENTRY_LAST_LOCATION;


	IF inputLogId > -1 THEN
		update SENTRY_LAST_LOCATION SET FILE_TRANSMISSION_LOG_ID = inputLogId;
	END IF;

	outputLogId := v_current;

EXCEPTION
	WHEN OTHERS THEN
		raise;

END SetOrGetSentryLastLocation;

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

END DBCLASSLIBRARY;
/


