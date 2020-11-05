CREATE OR REPLACE PROCEDURE FNSOWNER.ILOG_ITEM (
  p_id out I_LOG.I_LOG_ID%TYPE,
  p_issue in I_LOG.ISSUE_NUMBER%TYPE,
  p_item in I_LOG.ITEM%TYPE,
  p_contents in I_LOG.CONTENTS%TYPE ) 
is
    v_id			I_LOG.I_LOG_ID%TYPE;
    
	  CURSOR curIlogItemCursor
    IS
      SELECT *
      FROM I_LOG
      WHERE I_LOG.ISSUE_NUMBER = p_issue AND I_LOG.ITEM = p_item;
      
      ITEM_REC curIlogItemCursor%ROWTYPE;
		
BEGIN
	  OPEN curIlogItemCursor;
      fetch curIlogItemCursor into ITEM_REC;
      
      -- If no I_LOG record then we insert
      if curIlogItemCursor%NOTFOUND then
        v_id := SeqFunctions.GetNextSeq('I_LOG');
   			INSERT INTO I_LOG (I_LOG_ID,ISSUE_NUMBER,ITEM,CONTENTS) 
          values(v_id,p_issue, p_item, p_contents);
      else
		v_id :=  ITEM_REC.I_LOG_ID;
        UPDATE I_LOG SET CONTENTS = p_contents WHERE I_LOG_ID = v_id;
      end if;
      
      p_id := v_id;
      
      
EXCEPTION
	WHEN OTHERS THEN
		p_id := -1;
		raise;
		
END ILOG_ITEM;
/

