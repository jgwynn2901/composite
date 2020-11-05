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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Sql/DbClassLibPackageCRAWP.sql 1     9/25/09 2:47p John.gwynn $ */
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
	
PROCEDURE ProcessCrawfordNcciRecord (
	p_CraNcciClassCodeId		OUT		CRA_NCCI_CLASS_CODES.CRA_NCCI_CLASS_CODE_ID%TYPE,
	p_AHSID									IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
	p_LobCode								IN		CRA_NCCI_CLASS_CODES.LOB_CODE%TYPE,
	p_JobCode								IN		CRA_NCCI_CLASS_CODES.JOB_CODE%TYPE,
	p_StateCode							IN		CRA_NCCI_CLASS_CODES.STATE_CODE%TYPE,
	p_NcciCode							IN		NCCI_CODES.NCCI_CODE%TYPE);
	
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

PROCEDURE ProcessLocationsUser(
	p_nLocationUserID		OUT		LOCATIONS_USER.LOCATION_USER_ID%TYPE,
	p_nAHSID						IN		ACCOUNT_USER.ACCNT_HRCY_STEP_ID%TYPE,
	p_nUserID						IN		ACCOUNT_USER.USER_ID%TYPE,
	p_nLocationAHSID		IN		LOCATIONS_USER.LOCATION_AHSID%TYPE,
	p_nClientCd					IN		LOCATIONS_USER.FNS_CLIENT_CD%TYPE,
	p_nLOBCD						IN		LOCATIONS_USER.LOB_CD%TYPE,
	p_nGreeting					IN		LOCATIONS_USER.GREETING%TYPE,
	p_nLocName					IN		LOCATIONS_USER.NAME%TYPE,
	p_nPhone						IN		LOCATIONS_USER.PHONENUMBER%TYPE,
	p_nFileTransLogId		IN		LOCATIONS_USER.FILE_TRANSMISSION_LOG_ID%TYPE
);			 

PROCEDURE GetuserIDfromusername( 
			p_username  IN		users.NAME%TYPE,
			p_userid		OUT	  users.user_id%TYPE );
			 
PROCEDURE GetcrawcedarhilllocationAHSID( 
			p_locationcode  IN		account_hierarchy_step.location_code%TYPE,
			p_ahsid					OUT	  account_hierarchy_step.accnt_hrcy_step_id%TYPE );
			
			
PROCEDURE FNSOWNER.ProcessUserGroup(
	p_nUserID				IN				 USERS.USER_ID%TYPE,
	p_nGroupID				IN				 GROUPS.GROUP_ID%TYPE,
	p_nFileTransLogID		IN				 File_Transmission_Log.FILE_TRANSMISSION_LOG_ID%TYPE);
	
PROCEDURE FNSOWNER.ProcessUsers(
	p_UserId						OUT		USERS.USER_ID%TYPE,
	p_UserName						IN		USERS.NAME%TYPE,
	p_SiteId						IN		USERS.SITE_ID%TYPE,
	p_Password						IN		USERS.PASSWORD%TYPE,
	p_Active						IN		USERS.ACTIVE%TYPE,
	p_LastName						IN		USERS.LAST_NAME%TYPE,
	p_FirstName						IN		USERS.FIRST_NAME%TYPE,
	p_ActiveStartDate				IN		USERS.ACTIVE_START_DATE%TYPE,
	p_ActiveEndDate					IN		USERS.ACTIVE_END_DATE%TYPE,
	p_PasswordCreatedDate			IN		USERS.PASSWORD_CREATION_DATE%TYPE,
	p_PasswordExpirationDate		IN		USERS.PASSWORD_EXPIRATION_DATE%TYPE,
	p_LastChangeDate				IN		USERS.LAST_CHANGE_DATE%TYPE,
	p_NewUser						IN		USERS.NEW_USER%TYPE,
	p_InternetUser					IN		USERS.INTERNET_USER%TYPE,
	p_FileTransLogId				IN		USERS.FILE_TRANSMISSION_LOG_ID%TYPE);
	
	PROCEDURE FNSOWNER.ProcessAccountUser(
	p_nUserID				IN		USERS.USER_ID%TYPE,
	p_nAHSID				IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
	p_nFileTransLogId		IN		ACCOUNT_USER.FILE_TRANSMISSION_LOG_ID%TYPE);
	
	
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
-- for given NCCI code determine if new then insert 
-- in any case return the pk (no update)
------------------------------------------------------------------------	
PROCEDURE ProcessCrawfordNcciRecord (
	p_CraNcciClassCodeId		OUT		CRA_NCCI_CLASS_CODES.CRA_NCCI_CLASS_CODE_ID%TYPE,
	p_AHSID									IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
	p_LobCode								IN		CRA_NCCI_CLASS_CODES.LOB_CODE%TYPE,
	p_JobCode								IN		CRA_NCCI_CLASS_CODES.JOB_CODE%TYPE,
	p_StateCode							IN		CRA_NCCI_CLASS_CODES.STATE_CODE%TYPE,
	p_NcciCode							IN		NCCI_CODES.NCCI_CODE%TYPE
)
IS
	CURSOR curNcciRec
	IS
		SELECT *
		FROM CRA_NCCI_CLASS_CODES
		WHERE LOB_CODE = p_LobCode
					AND JOB_CODE = p_JobCode
					AND STATE_CODE = p_StateCode;
	
	CURSOR curNcciAhsRec
	IS
		SELECT * 
		FROM NCCI_CODES
		WHERE NCCI_CODE = p_NcciCode 
					AND ACCNT_HRCY_STEP_ID = p_AHSID;
					

	NCCI_REC					curNcciRec%ROWTYPE;
	NcciAhsIdRec			curNcciAhsRec%ROWTYPE;
	NcciCodeNotFound	EXCEPTION;
	

BEGIN
	OPEN curNcciRec;
	fetch curNcciRec into NCCI_REC;

	-- If no POLICY record then insert
	IF curNcciRec%NOTFOUND THEN
		
		OPEN curNcciAhsRec;
		fetch curNcciAhsRec into NcciAhsIdRec;

		-- If no POLICY record then insert
		IF curNcciAhsRec%FOUND THEN
			
			p_CraNcciClassCodeId := SeqFunctions.GetNextSeq('CRA_NCCI_CLASS_CODES');
			
			INSERT INTO CRA_NCCI_CLASS_CODES VALUES ( p_CraNcciClassCodeId,
																								p_LobCode,
																								p_JobCode,
																								p_StateCode,
																								null,
																								NcciAhsIdRec.NCCI_CODES_ID);
		ELSE
		raise NcciCodeNotFound;
																																			
		END IF;
	
	END IF;
		
	EXCEPTION
	WHEN NcciCodeNotFound THEN 
         raise_application_error (-20010, 'No ARAMARK specific NCCI_CODE on file');

	WHEN OTHERS THEN
		p_CraNcciClassCodeId := -1;
		raise;
		
END ProcessCrawfordNcciRecord;

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

-----Retrieve  user id - introduced by crawford cedarhill account----
PROCEDURE GetuserIDfromusername( 
			p_username  IN		users.NAME%TYPE,
			p_userid		OUT	  users.user_id%TYPE
)
--NOTE 
IS
		CURSOR curUserIdRec
	IS
		SELECT *
		FROM USERS
		WHERE NAME = p_username;
	
	UserId_Rec	   curUserIdRec%ROWTYPE;
BEGIN
	OPEN curUserIdRec;
	fetch curUserIdRec into UserId_Rec;
		
	IF curUserIdRec%FOUND THEN
		
		p_userid := UserId_Rec.user_id;
																																	
	END IF;
		
EXCEPTION
	
	WHEN OTHERS THEN
		raise_application_error (-20010, 'No User Id on file');

END GetuserIDfromusername;

--------Added new stored procedure to process location user data file introduced by this iLog # BCAB-0011------
PROCEDURE ProcessLocationsUser(
	p_nLocationUserID		OUT		LOCATIONS_USER.LOCATION_USER_ID%TYPE,
	p_nAHSID						IN		ACCOUNT_USER.ACCNT_HRCY_STEP_ID%TYPE,
	p_nUserID						IN		ACCOUNT_USER.USER_ID%TYPE,
	p_nLocationAHSID		IN		LOCATIONS_USER.LOCATION_AHSID%TYPE,
	p_nClientCd					IN		LOCATIONS_USER.FNS_CLIENT_CD%TYPE,
	p_nLOBCD						IN		LOCATIONS_USER.LOB_CD%TYPE,
	p_nGreeting					IN		LOCATIONS_USER.GREETING%TYPE,
	p_nLocName					IN		LOCATIONS_USER.NAME%TYPE,
	p_nPhone						IN		LOCATIONS_USER.PHONENUMBER%TYPE,
	p_nFileTransLogId		IN		LOCATIONS_USER.FILE_TRANSMISSION_LOG_ID%TYPE
)
IS
	CURSOR curLocationUser
	IS
		SELECT *
		FROM Locations_User
		WHERE		ACCNT_HRCY_STEP_ID	= p_nAHSID
					AND LOCATION_AHSID = p_nLocationAHSID
					AND ACCOUNT_USER_ID = p_nUserID;

	LOCATIONS_USER_REC				 curLocationUser%ROWTYPE;

BEGIN
	OPEN curLocationUser;
	fetch curLocationUser into LOCATIONS_USER_REC;

	-- If no location user record then insert
	IF curLocationUser%NOTFOUND THEN

		-- Get the new location user ID
		p_nLocationUserID := SeqFunctions.GetNextSeq('LOCATIONS_USER');

		insert into LOCATIONS_USER
								(	LOCATION_USER_ID,
									ACCNT_HRCY_STEP_ID,
									ACCOUNT_USER_ID,
									LOCATION_AHSID,
									FNS_CLIENT_CD,
			   				 	LOB_CD,
									GREETING,
									NAME,
									PHONENUMBER,
									FILE_TRANSMISSION_LOG_ID
									
								)
			VALUES
								(
									p_nLocationUserID,
									p_nAHSID,
									p_nUserID,
									p_nLocationAHSID,
									p_nClientCd,
									p_nLOBCD,
									p_nGreeting,
									p_nLocName,
									p_nPhone,
									p_nFileTransLogId
									
								);
	

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_nLocationUserID := -1;
	rollback;
	raise;

END ProcessLocationsUser;

Procedure GetcrawcedarhilllocationAHSID( 
			p_locationcode  IN		account_hierarchy_step.location_code%TYPE,
			p_ahsid					OUT	  account_hierarchy_step.accnt_hrcy_step_id%TYPE
			 )
--NOTE 
IS
		CURSOR curLocAHSIDRec
	IS
		SELECT accnt_hrcy_step_id
		FROM account_hierarchy_step
		WHERE location_code = p_locationcode
		and client_node_id = 81
		and type = 'RISK LOCATION'
		and parent_node_id = 609373
		and active_status = 'ACTIVE';
	AHSId_Rec    curLocAHSIDRec%ROWTYPE;
	
BEGIN
	OPEN curLocAHSIDRec;
	fetch curLocAHSIDRec into AHSId_Rec;
		
	IF curLocAHSIDRec%FOUND THEN
		
		p_ahsid := AHSId_Rec.accnt_hrcy_step_id;
																																	
	END IF;
		
EXCEPTION
	
	WHEN OTHERS THEN
		raise_application_error (-20010, 'No User Id on file');
		
END GetcrawcedarhilllocationAHSID;

PROCEDURE FNSOWNER.ProcessUsers(
	p_UserId						OUT		USERS.USER_ID%TYPE,
	p_UserName						IN		USERS.NAME%TYPE,
	p_SiteId						IN		USERS.SITE_ID%TYPE,
	p_Password						IN		USERS.PASSWORD%TYPE,
	p_Active						IN		USERS.ACTIVE%TYPE,
	p_LastName						IN		USERS.LAST_NAME%TYPE,
	p_FirstName						IN		USERS.FIRST_NAME%TYPE,
	p_ActiveStartDate				IN		USERS.ACTIVE_START_DATE%TYPE,
	p_ActiveEndDate					IN		USERS.ACTIVE_END_DATE%TYPE,
	p_PasswordCreatedDate			IN		USERS.PASSWORD_CREATION_DATE%TYPE,
	p_PasswordExpirationDate		IN		USERS.PASSWORD_EXPIRATION_DATE%TYPE,
	p_LastChangeDate				IN		USERS.LAST_CHANGE_DATE%TYPE,
	p_NewUser						IN		USERS.NEW_USER%TYPE,
	p_InternetUser					IN		USERS.INTERNET_USER%TYPE,
	p_FileTransLogId				IN		USERS.FILE_TRANSMISSION_LOG_ID%TYPE
	
)
IS
	CURSOR curUsers
	IS
		SELECT USER_ID
		FROM USERS
		WHERE		NAME	= p_UserName;
					
					

	USERS_REC				 curUsers%ROWTYPE;
	CurActiveStart           USERS.ACTIVE_START_DATE%TYPE;
    CurActiveEnd             USERS.ACTIVE_END_DATE%TYPE;


BEGIN

	

	OPEN curUsers;
	fetch curUsers into USERS_REC;

	-- If no location user record then insert
	IF curUsers%NOTFOUND THEN

		-- Get the new location user ID
		p_UserID := SeqFunctions.GetNextSeq('USERS');

		insert into USERS
								(	USER_ID,
									SITE_ID,
									NAME,
									PASSWORD,
									ACTIVE,
			   				 		LAST_NAME,
									FIRST_NAME,
									ACTIVE_START_DATE,
									ACTIVE_END_DATE,
									PASSWORD_CREATION_DATE,
									PASSWORD_EXPIRATION_DATE,
									LAST_CHANGE_DATE,
									NEW_USER,
									INTERNET_USER,
									FILE_TRANSMISSION_LOG_ID
									
								)
			VALUES
								(
									p_UserID,
									p_SiteId,
									p_UserName,
									p_Password,
									p_Active,
									p_LastName,
									p_FirstName,
									p_ActiveStartDate,
									p_ActiveEndDate,
									p_PasswordCreatedDate,
									p_PasswordExpirationDate,
									p_LastChangeDate,
									p_NewUser,
									p_InternetUser,
									p_FileTransLogId
									
								);
								
								
	ELSE
	
	p_UserID := USERS_REC.USER_ID;
	

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	p_UserID := -1;
	rollback;
	raise;

END ProcessUsers;

PROCEDURE FNSOWNER.ProcessUserGroup(
	p_nUserID				IN				 USERS.USER_ID%TYPE,
	p_nGroupID				IN				 GROUPS.GROUP_ID%TYPE,
	p_nFileTransLogID		IN				 File_Transmission_Log.FILE_TRANSMISSION_LOG_ID%TYPE
	
)
IS
	CURSOR curUserGroup
	IS
		SELECT *
		FROM User_Group
		WHERE		User_ID	= p_nUserID
					AND Group_ID = p_nGroupID;
					

	User_Group_REC				 curUserGroup%ROWTYPE;


BEGIN


	OPEN curUserGroup;
	fetch curUserGroup into User_Group_REC;

	-- If no location user record then insert
	IF curUserGroup%NOTFOUND THEN



		insert into USER_GROUP
								(	USER_ID,
									GROUP_ID,
									FILE_TRANSMISSION_LOG_ID
									
									
								)
			VALUES
								(
									p_nUserID,
									p_nGroupID,
									p_nFileTransLogID
									
									
								);
	

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	rollback;
	raise;

END ProcessUserGroup;

PROCEDURE FNSOWNER.ProcessAccountUser(
	p_nUserID				IN		USERS.USER_ID%TYPE,
	p_nAHSID				IN		ACCOUNT_HIERARCHY_STEP.ACCNT_HRCY_STEP_ID%TYPE,
	p_nFileTransLogId		IN		ACCOUNT_USER.FILE_TRANSMISSION_LOG_ID%TYPE
	
)
IS
	CURSOR curAccountUser
	IS
		SELECT *
		FROM Account_User
		WHERE USER_ID = p_nUserID
		AND ACCNT_HRCY_STEP_ID = p_nAHSID;
					

	Account_User_REC				 curAccountUser%ROWTYPE;


BEGIN


	OPEN curAccountUser;
	fetch curAccountUser into Account_User_REC;

	-- If no location user record then insert
	IF curAccountUser%NOTFOUND THEN

	

		insert into ACCOUNT_USER
								(	USER_ID,
									ACCNT_HRCY_STEP_ID,
									FILE_TRANSMISSION_LOG_ID
									
									
								)
			VALUES
								(
									p_nUserID,
									p_nAHSID,
									p_nFileTransLogId
									
									
								);
	

	END IF;
	COMMIT;

EXCEPTION
	WHEN OTHERS THEN
	
	rollback;
	raise;

END ProcessAccountUser;

	
END DBCLASSLIBRARY;
/
