if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WF_DYNAMICS_CompanyAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WF_DYNAMICS_CompanyAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WF_DYNAMICS_Company] table.
CREATE PROCEDURE pePortalWFApprovalSel_WF_DYNAMICS_CompanyAdd
    @p_Company_ID smallint,
    @p_Company_Desc varchar(250),
    @p_Company_Short_Name varchar(10),
    @p_INTERID varchar(10),
    @p_FULLADDRESS varchar(224)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WF_DYNAMICS_Company]
        (
            [Company_ID],
            [Company_Desc],
            [Company_Short_Name],
            [INTERID],
            [FULLADDRESS]
        )
    VALUES
        (
             @p_Company_ID,
             @p_Company_Desc,
             @p_Company_Short_Name,
             @p_INTERID,
             @p_FULLADDRESS
        )

END

