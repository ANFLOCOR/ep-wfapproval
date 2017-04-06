if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WPO_WFTaskAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WPO_WFTaskAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WPO_WFTask] table.
CREATE PROCEDURE pePortalWFApprovalSel_WPO_WFTaskAdd
    @p_PONUMBER char(17),
    @p_POSTATUS smallint,
    @p_DOCDATE datetime,
    @p_TOTAL numeric(15,2),
    @p_VENDORID char(15),
    @p_VENDNAME char(65),
    @p_BUYERID char(15),
    @p_Workflow_Approval_Status smallint,
    @p_CompanyID int,
    @p_COMMENTS varchar(204),
    @p_SUBTOTAL numeric(19,5),
    @p_TRDISAMT numeric(19,5),
    @p_FRTAMNT numeric(19,5),
    @p_MSCCHAMT numeric(19,5),
    @p_TAXAMNT numeric(19,5),
    @p_isINC varchar(9)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WPO_WFTask]
        (
            [PONUMBER],
            [POSTATUS],
            [DOCDATE],
            [TOTAL],
            [VENDORID],
            [VENDNAME],
            [BUYERID],
            [Workflow_Approval_Status],
            [CompanyID],
            [COMMENTS],
            [SUBTOTAL],
            [TRDISAMT],
            [FRTAMNT],
            [MSCCHAMT],
            [TAXAMNT],
            [isINC]
        )
    VALUES
        (
             @p_PONUMBER,
             @p_POSTATUS,
             @p_DOCDATE,
             @p_TOTAL,
             @p_VENDORID,
             @p_VENDNAME,
             @p_BUYERID,
             @p_Workflow_Approval_Status,
             @p_CompanyID,
             @p_COMMENTS,
             @p_SUBTOTAL,
             @p_TRDISAMT,
             @p_FRTAMNT,
             @p_MSCCHAMT,
             @p_TAXAMNT,
             @p_isINC
        )

END

