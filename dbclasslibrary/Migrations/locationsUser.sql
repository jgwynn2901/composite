  
      /*
      CHANGE REPORT for Table LOCATIONS_USER
          - Adding column ACCOUNT_LOCATION_CODE
      ACTION is ALTER or modify Table LOCATIONS_USER
      */

ALTER TABLE LOCATIONS_USER ADD (ACCOUNT_LOCATION_CODE VARCHAR(20) NULL);
/
update LOCATIONS_USER L set L.ACCOUNT_LOCATION_CODE = (select ahs.location_code from account_hierarchy_step ahs where ahs.accnt_hrcy_step_id = L.LOCATION_AHSID)
/
CREATE OR REPLACE TRIGGER "FNSOWNER".ti_locations_user
BEFORE INSERT
ON fnsowner.locations_user
REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW
begin
if :new.ACCOUNT_LOCATION_CODE is NULL or :new.ACCOUNT_LOCATION_CODE = '' then
    select ahs.location_code  into :new.ACCOUNT_LOCATION_CODE from account_hierarchy_step ahs where ahs.accnt_hrcy_step_id = :new.LOCATION_AHSID;
  end if;
end;
/



