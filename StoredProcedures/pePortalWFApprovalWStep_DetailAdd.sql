if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWStep_DetailAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWStep_DetailAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WStep_Detail] table.
CREATE PROCEDURE pePortalWFApprovalWStep_DetailAdd
    @p_WSD_WS_ID int,
    @p_WSD_W_U_ID int,
    @p_WSD_Desc varchar(50),
    @p_WSD_Status varchar(50),
    @p_WSD_Variable_Ref int,
    @p_WSD_Variable_SQL varchar(100),
    @p_WSD_Expire smallint,
    @p_WSD_W_U_ID_Delegate int,
    @p_WSD_Is_Escalate bit,
    @p_WSD_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WStep_Detail]
        (
            [WSD_WS_ID],
            [WSD_W_U_ID],
            [WSD_Desc],
            [WSD_Status],
            [WSD_Variable_Ref],
            [WSD_Variable_SQL],
            [WSD_W_U_ID_Delegate]
        )
    VALUES
        (
             @p_WSD_WS_ID,
             @p_WSD_W_U_ID,
             @p_WSD_Desc,
             @p_WSD_Status,
             @p_WSD_Variable_Ref,
             @p_WSD_Variable_SQL,
             @p_WSD_W_U_ID_Delegate
        )

    SET @p_WSD_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_WSD_Expire IS NOT NULL
        UPDATE [dbo].[WStep_Detail] SET [WSD_Expire] = @p_WSD_Expire WHERE [WSD_ID] = @p_WSD_ID_out

    IF @p_WSD_Is_Escalate IS NOT NULL
        UPDATE [dbo].[WStep_Detail] SET [WSD_Is_Escalate] = @p_WSD_Is_Escalate WHERE [WSD_ID] = @p_WSD_ID_out

END

