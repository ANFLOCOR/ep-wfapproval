if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPR_Doc] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc1Add
    @p_WPRD_C_ID smallint,
    @p_WPRD_WDT_ID int,
    @p_WPRD_WCD_ID int,
    @p_WPRD_WCur_ID smallint,
    @p_WPRD_U_ID int,
    @p_WPRD_U_ID_Modify int,
    @p_WPRD_No varchar(50),
    @p_WPRD_Created smalldatetime,
    @p_WPRD_Modified smalldatetime,
    @p_WPRD_Total numeric(18,5),
    @p_WPRD_Comment varchar(500),
    @p_WPRD_WPRDS_ID smallint,
    @p_WPRD_Submit bit,
    @p_WPRD_Title varchar(250),
    @p_WPRD_Contract bit,
    @p_WPRD_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPR_Doc]
        (
            [WPRD_C_ID],
            [WPRD_WDT_ID],
            [WPRD_WCD_ID],
            [WPRD_WCur_ID],
            [WPRD_U_ID],
            [WPRD_U_ID_Modify],
            [WPRD_No],
            [WPRD_Created],
            [WPRD_Modified],
            [WPRD_Total],
            [WPRD_Comment],
            [WPRD_WPRDS_ID],
            [WPRD_Submit],
            [WPRD_Title],
            [WPRD_Contract]
        )
    VALUES
        (
             @p_WPRD_C_ID,
             @p_WPRD_WDT_ID,
             @p_WPRD_WCD_ID,
             @p_WPRD_WCur_ID,
             @p_WPRD_U_ID,
             @p_WPRD_U_ID_Modify,
             @p_WPRD_No,
             @p_WPRD_Created,
             @p_WPRD_Modified,
             @p_WPRD_Total,
             @p_WPRD_Comment,
             @p_WPRD_WPRDS_ID,
             @p_WPRD_Submit,
             @p_WPRD_Title,
             @p_WPRD_Contract
        )

    SET @p_WPRD_ID_out = SCOPE_IDENTITY()

END

