if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWTask_Delegation1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWTask_Delegation1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WTask_Delegation] table.
CREATE PROCEDURE pePortalWFApprovalWTask_Delegation1Add
    @p_WTD_W_U_ID int,
    @p_WTD_W_U_ID_Delegate int,
    @p_WTD_WDT_Type varchar(5),
    @p_WTD_From smalldatetime,
    @p_WTD_To smalldatetime,
    @p_WTD_C_ID smallint,
    @p_WTD_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WTask_Delegation]
        (
            [WTD_W_U_ID],
            [WTD_W_U_ID_Delegate],
            [WTD_WDT_Type],
            [WTD_From],
            [WTD_To],
            [WTD_C_ID]
        )
    VALUES
        (
             @p_WTD_W_U_ID,
             @p_WTD_W_U_ID_Delegate,
             @p_WTD_WDT_Type,
             @p_WTD_From,
             @p_WTD_To,
             @p_WTD_C_ID
        )

    SET @p_WTD_ID_out = SCOPE_IDENTITY()

END

