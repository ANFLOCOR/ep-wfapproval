﻿if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_ShowSubmitApproval2Get') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_ShowSubmitApproval2Get 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[sel_ShowSubmitApproval] table.
CREATE PROCEDURE pePortalWFApprovalSel_ShowSubmitApproval2Get
        @pk_PONUMBER char(17)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[sel_ShowSubmitApproval]
    WHERE [PONUMBER] =@pk_PONUMBER

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [PONUMBER],
        [POSTATUS],
        [DOCDATE],
        [SUBTOTAL],
        [TRDISAMT],
        [FRTAMNT],
        [MSCCHAMT],
        [TAXAMNT],
        [VENDORID],
        [VENDNAME],
        [CMPANYID],
        [COMMNTID],
        [BUYERID],
        [Workflow_Approval_Status],
        [CompanyID],
        [WPOP_PONMBR],
        [REMARKS],
        [POTOTAL],
        [POP_Status],
        CAST(BINARY_CHECKSUM([PONUMBER],[POSTATUS],[DOCDATE],[SUBTOTAL],[TRDISAMT],[FRTAMNT],[MSCCHAMT],[TAXAMNT],[VENDORID],[VENDNAME],[CMPANYID],[COMMNTID],[BUYERID],[Workflow_Approval_Status],[CompanyID],[WPOP_PONMBR],[REMARKS],[POTOTAL],[POP_Status]) AS nvarchar(max)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[sel_ShowSubmitApproval]
    WHERE [PONUMBER] =@pk_PONUMBER
    SET NOCOUNT OFF
END

