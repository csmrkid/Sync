namespace WindowsFormsApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Dwstg : DbContext
    {
        public Dwstg()
            : base("name=Dwstg")
        {
        }

        public virtual DbSet<AIRWB> AIRWBs { get; set; }
        public virtual DbSet<CITY> CITies { get; set; }
        public virtual DbSet<COUNTRY> COUNTRies { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<DOCUMENT> DOCUMENTs { get; set; }
        public virtual DbSet<ETL_CTRL> ETL_CTRL { get; set; }
        public virtual DbSet<ETL_ERR> ETL_ERR { get; set; }
        public virtual DbSet<ETL_LOG> ETL_LOG { get; set; }
        public virtual DbSet<FRTTYPE> FRTTYPEs { get; set; }
        public virtual DbSet<IATA> IATAs { get; set; }
        public virtual DbSet<INCOTERM> INCOTERMS { get; set; }
        public virtual DbSet<IR_REASON> IR_REASON { get; set; }
        public virtual DbSet<LOGIN> LOGINs { get; set; }
        public virtual DbSet<MEC_REGION> MEC_REGION { get; set; }
        public virtual DbSet<MILESTONE> MILESTONEs { get; set; }
        public virtual DbSet<MODULE> MODULEs { get; set; }
        public virtual DbSet<PARENT> PARENTs { get; set; }
        public virtual DbSet<PORT> PORTs { get; set; }
        public virtual DbSet<REFERENCE> REFERENCEs { get; set; }
        public virtual DbSet<REPORT> REPORTs { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<ROLEAGENTACCESS> ROLEAGENTACCESSes { get; set; }
        public virtual DbSet<ROLECUSTACCESS> ROLECUSTACCESSes { get; set; }
        public virtual DbSet<ROLEMODULEACCESS> ROLEMODULEACCESSes { get; set; }
        public virtual DbSet<ROLEPARENTACCESS> ROLEPARENTACCESSes { get; set; }
        public virtual DbSet<ROLEPORTACCESS> ROLEPORTACCESSes { get; set; }
        public virtual DbSet<ROLESTATIONACCESS> ROLESTATIONACCESSes { get; set; }
        public virtual DbSet<SEAWB> SEAWBs { get; set; }
        public virtual DbSet<SERVICELEVEL> SERVICELEVELs { get; set; }
        public virtual DbSet<SERVICETYPE> SERVICETYPEs { get; set; }
        public virtual DbSet<SHPT_BILLINGDS> SHPT_BILLINGDS { get; set; }
        public virtual DbSet<SHPT_BILLINGMS> SHPT_BILLINGMS { get; set; }
        public virtual DbSet<SHPT_CONTAINERS> SHPT_CONTAINERS { get; set; }
        public virtual DbSet<SHPT_CURSTATUS> SHPT_CURSTATUS { get; set; }
        public virtual DbSet<SHPT_DIMENSIONS> SHPT_DIMENSIONS { get; set; }
        public virtual DbSet<SHPT_DOCUMENTS> SHPT_DOCUMENTS { get; set; }
        public virtual DbSet<SHPT_MILESTONES> SHPT_MILESTONES { get; set; }
        public virtual DbSet<SHPT_NOTIDS> SHPT_NOTIDS { get; set; }
        public virtual DbSet<SHPT_NOTIMS> SHPT_NOTIMS { get; set; }
        public virtual DbSet<SHPT_PARTNERS> SHPT_PARTNERS { get; set; }
        public virtual DbSet<SHPT_PROFITS> SHPT_PROFITS { get; set; }
        public virtual DbSet<SHPT_REFERENCES> SHPT_REFERENCES { get; set; }
        public virtual DbSet<SHPT_ROUTES> SHPT_ROUTES { get; set; }
        public virtual DbSet<STATION> STATIONs { get; set; }
        public virtual DbSet<UNIT> UNITs { get; set; }
        public virtual DbSet<USER_NOTI_CTRL> USER_NOTI_CTRL { get; set; }
        public virtual DbSet<USER_NOTI_DETS> USER_NOTI_DETS { get; set; }
        public virtual DbSet<USER_RPT_PCTRL> USER_RPT_PCTRL { get; set; }
        public virtual DbSet<USER_RPT_PROFILE> USER_RPT_PROFILE { get; set; }
        public virtual DbSet<PL_BLSTATUS> PL_BLSTATUS { get; set; }
        public virtual DbSet<STATION_BRANCH> STATION_BRANCH { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AIRWB>()
                .Property(e => e.AIRWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.MAWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.BOOKING_NO)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.QUOT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.SVC_LEVEL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.SVC_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.INCOTERMS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.FRT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.ORIG_PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.DEST_PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CUSTOMER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.SHPR_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CNEE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CARRIER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.COMMODITY)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.PKG_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.GW)
                .HasPrecision(10, 3);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.GW_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.VW)
                .HasPrecision(10, 3);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.VW_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CW)
                .HasPrecision(10, 3);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CW_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CUR_STATUS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.ORIG_COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.DEST_COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.CUR_SIGNED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.SVC_COMPLETE_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<AIRWB>()
                .Property(e => e.MEC_BROKER_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.CITY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.CITY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.CITY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.STATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CITY>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRY>()
                .Property(e => e.COUNTRY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRY>()
                .Property(e => e.COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRY>()
                .Property(e => e.COUNTRY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRY>()
                .Property(e => e.IATA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRY>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRY>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRY>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<COUNTRY>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CUSTOMER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CUSTOMER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CUSTOMER_NAME1)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CUSTOMER_NAME2)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PARENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ADDR2)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ADDR3)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ADDR4)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CITY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.STATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.POSTAL)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.IS_CUST)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.IS_SHPR)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.IS_CNEE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.IS_AGENT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.IS_MORRISON)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.NATURE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.MILESTONES_CTRL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENT>()
                .Property(e => e.DOC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENT>()
                .Property(e => e.DOC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENT>()
                .Property(e => e.DOC_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENT>()
                .Property(e => e.DOC_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENT>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENT>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENT>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENT>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_CTRL>()
                .Property(e => e.ETL_CTRL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_CTRL>()
                .Property(e => e.ETL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_CTRL>()
                .Property(e => e.ETL_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_CTRL>()
                .Property(e => e.SOURCE_TABLE)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_CTRL>()
                .Property(e => e.DEST_TABLE)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_CTRL>()
                .Property(e => e.ETL_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_CTRL>()
                .Property(e => e.LAST_REC_SEQ_NO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.ETL_ERR_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.ETL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.SQL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.SQL_ERR_MSG)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.ERR_REC_SEQ_NO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.KEY_FIELD_01)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.KEY_FIELD_02)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.KEY_FIELD_03)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.KEY_FIELD_04)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_ERR>()
                .Property(e => e.KEY_FIELD_05)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_LOG>()
                .Property(e => e.ETL_LOG_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_LOG>()
                .Property(e => e.ETL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ETL_LOG>()
                .Property(e => e.FROM_REC_SEQ_NO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETL_LOG>()
                .Property(e => e.TO_REC_SEQ_NO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FRTTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<FRTTYPE>()
                .Property(e => e.CODE_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<IATA>()
                .Property(e => e.IATA_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IATA>()
                .Property(e => e.IATA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<IATA>()
                .Property(e => e.IATA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IATA>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IATA>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<IATA>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IATA>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<INCOTERM>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<INCOTERM>()
                .Property(e => e.CODE_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<IR_REASON>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<IR_REASON>()
                .Property(e => e.CODE_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.USER_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.USER_PWD)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.USER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.USER_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<MEC_REGION>()
                .Property(e => e.MEC_REGION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MEC_REGION>()
                .Property(e => e.MEC_REGION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<MEC_REGION>()
                .Property(e => e.MEC_REGION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MEC_REGION>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MEC_REGION>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<MEC_REGION>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MEC_REGION>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.MILESTONE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.MILESTONE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.MILESTONE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.MILESTONE_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.DISP_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.PL_EVENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.PL_EVENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.MILESTONE_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.IS_AIR)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.IS_SEA)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.EI_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<MILESTONE>()
                .Property(e => e.MANDATORY_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<MODULE>()
                .Property(e => e.MODULE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<MODULE>()
                .Property(e => e.MODULE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<MODULE>()
                .Property(e => e.MODULE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MODULE>()
                .Property(e => e.MODULE_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<PARENT>()
                .Property(e => e.PARENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PARENT>()
                .Property(e => e.PARENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PARENT>()
                .Property(e => e.PARENT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PARENT>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PARENT>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<PARENT>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PARENT>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.PORT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.PORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.CITY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.STATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.IATA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<PORT>()
                .Property(e => e.TZONE_OFFSET)
                .HasPrecision(3, 1);

            modelBuilder.Entity<PORT>()
                .Property(e => e.LATITUDE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PORT>()
                .Property(e => e.LONGITUDE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REFERENCE>()
                .Property(e => e.REF_ID)
                .IsUnicode(false);

            modelBuilder.Entity<REFERENCE>()
                .Property(e => e.REF_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<REFERENCE>()
                .Property(e => e.REF_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REFERENCE>()
                .Property(e => e.REF_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<REFERENCE>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<REFERENCE>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<REFERENCE>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<REFERENCE>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<REPORT>()
                .Property(e => e.RPT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<REPORT>()
                .Property(e => e.RPT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<REPORT>()
                .Property(e => e.RPT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<REPORT>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<REPORT>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<REPORT>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<REPORT>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<REPORT>()
                .Property(e => e.RPT_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.ROLE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.ROLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .Property(e => e.IS_MEC)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEAGENTACCESS>()
                .Property(e => e.ROLEAGENTACCESS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEAGENTACCESS>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEAGENTACCESS>()
                .Property(e => e.AGENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEAGENTACCESS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEAGENTACCESS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<ROLECUSTACCESS>()
                .Property(e => e.ROLECUSTACC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLECUSTACCESS>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLECUSTACCESS>()
                .Property(e => e.CUSTOMER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLECUSTACCESS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLECUSTACCESS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEMODULEACCESS>()
                .Property(e => e.ROLEMODULEACC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEMODULEACCESS>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEMODULEACCESS>()
                .Property(e => e.MODULE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPARENTACCESS>()
                .Property(e => e.ROLEPARENTACC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPARENTACCESS>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPARENTACCESS>()
                .Property(e => e.PARENT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPARENTACCESS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPARENTACCESS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPORTACCESS>()
                .Property(e => e.ROLEPORTACC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPORTACCESS>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPORTACCESS>()
                .Property(e => e.PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPORTACCESS>()
                .Property(e => e.PORTACC_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPORTACCESS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLEPORTACCESS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<ROLESTATIONACCESS>()
                .Property(e => e.ROLESTATIONACC_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLESTATIONACCESS>()
                .Property(e => e.ROLE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLESTATIONACCESS>()
                .Property(e => e.STATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ROLESTATIONACCESS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ROLESTATIONACCESS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.SEAWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.BL_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.MBL_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.BOOKING_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.QUOT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.INCOTERMS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.FRT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.POR_PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.POR_COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.POL_PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.POL_COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.POD_PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.POD_COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.DLV_PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.DLV_COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.CUSTOMER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.SHPR_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.CNEE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.CARRIER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.COMMODITY)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.VESSEL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.VOYAGE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.VOYAGE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.PKG_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.GW)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.GW_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.CBM)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.CUR_STATUS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.LOT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.TEU)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.SVC_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.CUR_SIGNED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.SVC_COMPLETE_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<SEAWB>()
                .Property(e => e.MEC_BROKER_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICELEVEL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICELEVEL>()
                .Property(e => e.CODE_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICETYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICETYPE>()
                .Property(e => e.CODE_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.SHPT_BILLINGDS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.INV_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.CHRG_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.CHRG_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.INV_AMT_L)
                .HasPrecision(16, 5);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.INV_AMT_USD)
                .HasPrecision(16, 5);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.DEP)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.CHRG_DEP)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGDS>()
                .Property(e => e.INV_CRNCY)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.SHPT_BILLINGMS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.INV_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.INV_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.INV_CRNCY)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.INV_AMT_L)
                .HasPrecision(16, 5);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.INV_AMT_USD)
                .HasPrecision(16, 5);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.DEP)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_BILLINGMS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.SHPT_CONTAINERS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.CONTAINER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.CONTAINER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.SERVICE_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.PKG_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.GW)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.GW_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.CBM)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CONTAINERS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.SHPT_CURSTATUS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.BK_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.APU_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.ETD_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.ATD_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.ETA_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.ATA_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.CC_IMP_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.DOC_RLS_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.OFD_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.POD_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.CUR_STATUS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.CUR_SIGNED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.DELV_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_CURSTATUS>()
                .Property(e => e.SVC_COMPLETE_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.SHPT_DIMENSIONS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.PKG_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.LENGTH)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.WIDTH)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.HEIGHT)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.VW)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.VW_UNIT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.COMMODITY)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DIMENSIONS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.SHPT_DOCUMENTS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.DOC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.DOC_REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.DOC_FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.DOC_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.CONTENT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_DOCUMENTS>()
                .Property(e => e.CONTENT_SUB_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.SHPT_MILESTONES_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.STATUS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.SIGNED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.CITY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.STATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.REMARK1)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_MILESTONES>()
                .Property(e => e.IR_REASON_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.SHPT_NOTIDS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.SHPT_NOTIMS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.STATUS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.STATUS_D)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.STATUS_T)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.STATUS_D_OLD)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.STATUS_T_OLD)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.IS_CHANGE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIDS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.SHPT_NOTIMS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.NOTI_CTRL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.NOTI_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.NOTI_SENT_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.CUSTOMER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_NOTIMS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.SHPT_PARTNERS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.PARTNER_QFR_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.PARTNER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.DEP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PARTNERS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.SHPT_PROFITS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.AWB_REV_PRE_PL)
                .HasPrecision(16, 5);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_PROFITS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.SHPT_REFERENCES_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.REF_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.REF_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_REFERENCES>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.SHPT_ROUTES_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.MAWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.FLIGHT_NO)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.FR_PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.FR_COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.TO_PORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.TO_COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.VESSEL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.VOYAGE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SHPT_ROUTES>()
                .Property(e => e.VOYAGE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.STATION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.STATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.STATION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.ADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.CITY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.STATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.POSTAL)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.COUNTRY_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.IATA_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.MEC_REGION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.CODE_DESCP)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.USER_NOTI_CTRL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.AWB_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.USER_NOTI_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_CTRL>()
                .Property(e => e.NOTI_TO)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.USER_NOTI_DETS_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.USER_NOTI_CTRL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.STATUS_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.STATUS_NOTI_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.STATUS_D_LAST)
                .IsUnicode(false);

            modelBuilder.Entity<USER_NOTI_DETS>()
                .Property(e => e.STATUS_T_LAST)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.USER_RPT_PCTRL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.RPT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.RPT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.PROFILE_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PCTRL>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.USER_RPT_PROFILE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.USER_RPT_PROFILE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.RPT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.RPT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.COL_ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.COL_QRY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.COL_DISP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.COL_DISP_FCOLOR)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.MODE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.COL_DISP_BCOLOR)
                .IsUnicode(false);

            modelBuilder.Entity<USER_RPT_PROFILE>()
                .Property(e => e.REF_RPT_PROFILE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.MAWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.AWB_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.DEP)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.STATUS_CD)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.PROCESS_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.PROCESS_TIME)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.PROCESS_BY)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<PL_BLSTATUS>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.STATIONBRANCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.STATION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.STATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.PRODUCT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.CREATED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.CREATED_VIA)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.LAST_MODIFIED_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION_BRANCH>()
                .Property(e => e.LAST_MODIFIED_VIA)
                .IsUnicode(false);
        }
    }
}
