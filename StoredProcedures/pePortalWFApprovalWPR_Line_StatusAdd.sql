if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Line_StatusAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Line_StatusAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPR_Line_Status] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Line_StatusAdd
    @p_WPRLS_Desc varchar(150),
    @p_WPRLS_Value smallint,
    @p_WPRLS_ID_out smallint output
AS
BEGIN
    INSERT
    INTO [dbo].[WPR_Line_Status]
        (
            [WPRLS_Desc],
            [WPRLS_Value]
        )
    VALUES
        (
             @p_WPRLS_Desc,
             @p_WPRLS_Value
        )

    SET @p_WPRLS_ID_out = SCOPE_IDENTITY()

END

