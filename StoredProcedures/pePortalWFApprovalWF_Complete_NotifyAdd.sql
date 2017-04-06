if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWF_Complete_NotifyAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWF_Complete_NotifyAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WF_Complete_Notify] table.
CREATE PROCEDURE pePortalWFApprovalWF_Complete_NotifyAdd
    @p_WFCN_C_ID smallint,
    @p_WFCN_U_ID int,
    @p_WFCN_DocType varchar(10),
    @p_WFCN_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WF_Complete_Notify]
        (
            [WFCN_C_ID],
            [WFCN_U_ID],
            [WFCN_DocType]
        )
    VALUES
        (
             @p_WFCN_C_ID,
             @p_WFCN_U_ID,
             @p_WFCN_DocType
        )

    SET @p_WFCN_ID_out = SCOPE_IDENTITY()

END

