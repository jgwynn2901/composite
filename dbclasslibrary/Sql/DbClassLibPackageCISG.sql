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
-- DBCLASSLIBRARY package definition for CRAWP database instances
---------------------------------------------------------------------------
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Sql/DbClassLibPackageCISG.sql 1     9/25/09 2:47p John.gwynn $ */
---------------------------------------------------------------------------
CREATE OR REPLACE PACKAGE DBCLASSLIBRARY AS

TYPE  CURSOR_TYPE IS REF CURSOR;

PROCEDURE GetMercuryDestinations (
	destinationType					IN		MERCURY.TYPE%TYPE,
	results									OUT		CURSOR_TYPE);
		
PROCEDURE GetOverflowSet (
	p_accntHrcyStepId				IN		OUTPUT_OVERFLOW.ACCNT_HRCY_STEP_ID%TYPE,
	p_LineOfBusiness				IN		OUTPUT_OVERFLOW.LOB_CD%TYPE,
	results									OUT		CURSOR_TYPE);
	
PROCEDURE GetFileTranDefSet (
	p_accntHrcyStepId	IN		FILE_TRANSMISSION_DEF.ACCNT_HRCY_STEP_ID%TYPE,
	p_Server					IN		FILE_TRANSMISSION_DEF.SERVER%TYPE,
	p_Type						IN		FILE_TRANSMISSION_DEF.TYPE%TYPE,
	results									OUT		CURSOR_TYPE);
	
	
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
	
PROCEDURE ProcessEmployeeExtension(
	p_nEmployeeExtId		OUT		EMPLOYEE_EXT.EMPLOYEE_EXT_ID%TYPE,
	p_nEmployeeId				IN		EMPLOYEE_EXT.EMPLOYEE_ID%TYPE,
	p_nFileTranLogId		IN		EMPLOYEE_EXT.FILE_TRANSMISSION_LOG_ID%TYPE,
	p_nFieldName				IN		EMPLOYEE_EXT.FIELD_NAME%TYPE,
	p_nFieldValue				IN		EMPLOYEE_EXT.FIELD_VALUE%TYPE
	 
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
								DESTINATION_UIF_LOCATION
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
	
END DBCLASSLIBRARY;
/
