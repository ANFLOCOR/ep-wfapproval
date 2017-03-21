if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_ShowSubmitApproval2Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_ShowSubmitApproval2Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_ShowSubmitApproval] table.
CREATE PROCEDURE pePortalWFApprovalSel_ShowSubmitApproval2Add
    @p_PONUMBER char(17),
    @p_POSTATUS smallint,
    @p_DOCDATE datetime,
    @p_SUBTOTAL numeric(19,5),
    @p_TRDISAMT numeric(19,5),
    @p_FRTAMNT numeric(19,5),
    @p_MSCCHAMT numeric(19,5),
    @p_TAXAMNT numeric(19,5),
    @p_VENDORID char(15),
    @p_VENDNAME char(65),
    @p_CMPANYID smallint,
    @p_COMMNTID char(15),
    @p_BUYERID char(15),
    @p_Workflow_Approval_Status smallint,
    @p_CompanyID int,
    @p_WPOP_PONMBR nvarchar(17),
    @p_REMARKS varchar(22),
    @p_POTOTAL numeric(15,2),
    @p_POP_Status int
AS
BEGIN
    INSERT
    INTO [dbo].[sel_ShowSubmitApproval]
        (
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
            [POP_Status]
        )
    VALUES
        (
             @p_PONUMBER,
             @p_POSTATUS,
             @p_DOCDATE,
             @p_SUBTOTAL,
             @p_TRDISAMT,
             @p_FRTAMNT,
             @p_MSCCHAMT,
             @p_TAXAMNT,
             @p_VENDORID,
             @p_VENDNAME,
             @p_CMPANYID,
             @p_COMMNTID,
             @p_BUYERID,
             @p_Workflow_Approval_Status,
             @p_CompanyID,
             @p_WPOP_PONMBR,
             @p_REMARKS,
             @p_POTOTAL,
             @p_POP_Status
        )

END

