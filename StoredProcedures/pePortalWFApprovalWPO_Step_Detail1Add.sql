if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Step_Detail1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Step_Detail1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_Step_Detail] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Step_Detail1Add
    @p_WPO_SD_S_ID int,
    @p_WPO_SD_W_U_ID int,
    @p_WPO_SD_Desc varchar(50),
    @p_WPO_SD_Status varchar(50),
    @p_WPO_SD_Variable_Ref int,
    @p_WPO_SD_Variable_SQL varchar(100),
    @p_WPO_SD_Expire smallint,
    @p_WPO_SD_W_U_ID_Delegate int,
    @p_WPO_SD_Is_Escalate bit,
    @p_WPO_SD_Is_FAP bit,
    @p_WPO_SD_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_Step_Detail]
        (
            [WPO_SD_S_ID],
            [WPO_SD_W_U_ID],
            [WPO_SD_Desc],
            [WPO_SD_Status],
            [WPO_SD_Variable_Ref],
            [WPO_SD_Variable_SQL],
            [WPO_SD_W_U_ID_Delegate],
            [WPO_SD_Is_FAP]
        )
    VALUES
        (
             @p_WPO_SD_S_ID,
             @p_WPO_SD_W_U_ID,
             @p_WPO_SD_Desc,
             @p_WPO_SD_Status,
             @p_WPO_SD_Variable_Ref,
             @p_WPO_SD_Variable_SQL,
             @p_WPO_SD_W_U_ID_Delegate,
             @p_WPO_SD_Is_FAP
        )

    SET @p_WPO_SD_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_WPO_SD_Expire IS NOT NULL
        UPDATE [dbo].[WPO_Step_Detail] SET [WPO_SD_Expire] = @p_WPO_SD_Expire WHERE [WPO_SD_ID] = @p_WPO_SD_ID_out

    IF @p_WPO_SD_Is_Escalate IS NOT NULL
        UPDATE [dbo].[WPO_Step_Detail] SET [WPO_SD_Is_Escalate] = @p_WPO_SD_Is_Escalate WHERE [WPO_SD_ID] = @p_WPO_SD_ID_out

END

