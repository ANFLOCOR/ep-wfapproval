if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_MinimumAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_MinimumAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCAR_Minimum] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_MinimumAdd
    @p_WCM_C_ID smallint,
    @p_WCM_Min numeric(18,2),
    @p_WCM_WCur_ID smallint,
    @p_WCM_ID_out smallint output
AS
BEGIN
    INSERT
    INTO [dbo].[WCAR_Minimum]
        (
            [WCM_C_ID],
            [WCM_Min],
            [WCM_WCur_ID]
        )
    VALUES
        (
             @p_WCM_C_ID,
             @p_WCM_Min,
             @p_WCM_WCur_ID
        )

    SET @p_WCM_ID_out = SCOPE_IDENTITY()

END

